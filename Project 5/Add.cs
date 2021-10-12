using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_5
{
    public partial class Add : Form
    {
        public string randId,tempOptions = "";

        public Add()
        {
            InitializeComponent();
            this.CenterToScreen();
            labId.Text = randomizeId();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            setDefault();

            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
        string randomizeId()
        {
            int rN = (new Random()).Next(0001, 9999);
            Random r = new Random();
            int num = r.Next(0, 26); 
            char let = (char)('A' + num);
            return randId =  let.ToString() + "-" + rN.ToString();

            // if similar id exist randomize another time
            FileStream fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                if (s.Contains(randId))
                {
                    randomizeId();
                }
            }
            fs.Close();
            sr.Close();          

            
        }
        Data d = new Data();
        
        
        Image File;
        OpenFileDialog ofd = new OpenFileDialog();
        private void butAddImg_Click(object sender, EventArgs e)
        {
            ofd.Filter = "(*.jpg, *.png) | *.jpg; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(ofd.FileName);
                pbImg.Image = File;
            }
        }
        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {

                int size = Convert.ToInt32(tbSize.Text);
                int floor = Convert.ToInt32(tbFloor.Text);
                int age = Convert.ToInt32(tbAge.Text);
                int rooms = Convert.ToInt32(tbRooms.Text);
                int bath = Convert.ToInt32(tbBath.Text);
                int price = Convert.ToInt32(tbPrice.Text);
                string address = tbAddr.Text;
                string conType = cbConType.Text;
                //owner
                string name = tbName.Text;
                string surname = tbSurname.Text;
                string birthDay = tbBirthday.Text;
                string addressOwner = tbAddrOwner.Text;
                string email = tbEmail.Text;
                long phone = Convert.ToInt64(tbPhone.Text);
                if (String.IsNullOrEmpty(address) || String.IsNullOrEmpty(conType) || String.IsNullOrEmpty(name)
                    || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(birthDay) || String.IsNullOrEmpty(addressOwner)
                    || String.IsNullOrEmpty(email))
                {
                    throw new ArgumentNullException("Forms cannot be empty");
                }

                if (cbFurnished.Checked)
                {
                    d.Furnished = cbFurnished.Text;
                    tempOptions += cbFurnished.Text + ", ";
                }
                if (cbWithOwner.Checked)
                {
                    d.WithOwner = cbWithOwner.Text;
                    tempOptions += cbWithOwner.Text + ", ";
                }
                if (cbInternet.Checked)
                {
                    d.Internet = cbInternet.Text;
                    tempOptions += cbInternet.Text + ", ";

                }
                if (cbElevator.Checked)
                {
                    d.Elevator = cbElevator.Text;
                    tempOptions += cbElevator.Text + ", ";
                }
                if (cbHCWater.Checked)
                {
                    d.HotColdWater = cbHCWater.Text;
                    tempOptions += cbHCWater.Text + ", ";
                }
                if (cbBath.Checked)
                {
                    d.BathTube = cbBath.Text;
                    tempOptions += cbBath.Text + ", ";
                }
                if (cbAirCon.Checked)
                {
                    d.AirCon = cbAirCon.Text;
                    tempOptions += cbAirCon.Text + ", ";
                }
                if (cbPool.Checked)
                {
                    d.Pool = cbPool.Text;
                    tempOptions += cbPool.Text + ", ";
                }
                if (cbIndStove.Checked)
                {
                    d.Stove = cbIndStove.Text;
                    tempOptions += cbIndStove.Text + ", ";
                }
                if (cbBalcony.Checked)
                {
                    d.Balcony = cbBalcony.Text;
                    tempOptions += cbBalcony.Text + ", ";
                }
                if (cbSecDesk.Checked)
                {
                    d.SecurityDesk = cbSecDesk.Text;
                    tempOptions += cbSecDesk.Text + ", ";
                }
                if (cbGym.Checked)
                {
                    d.Gym = cbGym.Text;
                    tempOptions += cbGym.Text + ", ";
                }
                d.Id = randId;
                d.Size = size;
                d.Floor = floor;
                d.Age = age;
                d.Bathrooms = bath;
                d.Rooms = rooms;
                d.Price = price;
                d.Address = address;
                d.ConType = conType;

                //owner
                d.Name = name;
                d.Surname = surname;
                d.Birthday = birthDay;
                d.AddressOwner = addressOwner;
                d.Phone = phone;
                d.Email = email;

                DataList.allData.Add(d);
                dataWrite();
                if (File != null)
                {
                    string imageName = "img\\" + labId.Text + "_" + ofd.SafeFileName;
                    pbImg.Image.Save(imageName);

                }
                MessageBox.Show("Contact Added!");
                setDefault();
                labId.Text = randomizeId();

              


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }




        }

        private void dataWrite()
        {
            try
            {
                int lastelement = DataList.allData.Count - 1;
                Data temp = DataList.allData[lastelement];
                FileStream fs = new FileStream("data.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine($"ID: {temp.Id}");
                sw.WriteLine($"Size: {temp.Size}");
                sw.WriteLine($"Floor: {temp.Floor}");
                sw.WriteLine($"Age: {temp.Age}");
                sw.WriteLine($"Address: {temp.Address}");
                sw.WriteLine($"Rooms: {temp.Rooms}");
                sw.WriteLine($"Bathrooms: {temp.Bathrooms}");
                sw.WriteLine($"Contract Type: {temp.ConType}");
                sw.WriteLine($"Price: {temp.Price}");
                sw.WriteLine($"Optons: {tempOptions}");
                sw.WriteLine($"Owner's name: {temp.Name}");
                sw.WriteLine($"Owner's surname: {temp.Surname}");
                sw.WriteLine($"Owner's birthday: {temp.Birthday}");
                sw.WriteLine($"Owner's address: {temp.Address}");
                sw.WriteLine($"Owner's phone: {temp.Phone}");
                sw.WriteLine($"Owner's email: {temp.Email}");
                sw.WriteLine("+++++++++++++++++++++++++++++");

                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
        }

        

        void setDefault()
        {
            foreach (Control c in gbProperty.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
               
                tempOptions = null;

            }
            tbSize.Text = tbFloor.Text = tbAge.Text = tbAddr.Text =
                tbRooms.Text = tbBath.Text = cbConType.Text = tbPrice.Text =
                tbName.Text = tbSurname.Text = tbBirthday.Text = tbAddrOwner.Text = tbPhone.Text = tbEmail.Text = "";
            File = null;
            pbImg.Image = Properties.Resources.image_not_available;
        }


    }
}
