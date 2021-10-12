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
    public partial class Search : Form
    {
        int temTurn = 1, corRes, counter = 0, turn = 1, corResF;
        FileStream fs;
        StreamReader sr;
        public Search()
        {

            InitializeComponent();
            this.CenterToScreen();
            if (!File.Exists("data.txt") || new FileInfo("data.txt").Length == 0)
            {
                MessageBox.Show("There is no data to show");
                gbSearch.Enabled = gbProperty.Enabled = false;
            }
            else
            {
                fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    for (int i = 1; i <= 17; i++)
                    {
                        sr.ReadLine();
                    }
                    counter++;
                }

                fs.Close();
                sr.Close();
                butPrevProp.Enabled = false;

            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();

        }

    
       
        private void butSearch_Click(object sender, EventArgs e)
        {
            DataList.price.Clear();
            corRes = 0;

            temTurn = 1;
            turn = 1;
            corResF = 0;


            checkPrice();
            checkRooms();
            checkContType();

            butPrevProp.Enabled = false;
            if (corRes <= 1)
            {
                butNextProp.Enabled = false;
            }
            else
            {
                butNextProp.Enabled = true;
            }
            corResF = corRes;
            checkQuant();
        }
        
        void  checkPrice()
        {
            if (rbPrice.Checked)
            {
                try
                {
                    int priceFrom = Convert.ToInt32(tbPriceFrom.Text);
                    int priceTo = Convert.ToInt32(tbPriceTo.Text);

                    for (int i = 1; i <= counter; i++)
                    {
                        int temp = i * 17;
                        temp -= 8;
                        fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);
                        for (int j = 1; j < temp; j++)
                        {
                            sr.ReadLine();
                        }
                        int price = Convert.ToInt32(inputHandler(sr.ReadLine()));

                        fs.Close();
                        sr.Close();
                        if (priceFrom <= price && priceTo >= price)
                        {
                            if (temTurn ==1)
                            {
                                turn = i;
                                DataList.price.Add(temp);
                                corRes++;
                            }
                            
                            dataWriter();
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                checkQuant();

            }
        }
        void checkRooms()
        {
            if (rbRooms.Checked)
            {
                try
                {

                    int roomsFrom = Convert.ToInt32(tbRoomsFrom.Text);
                    int roomsTo = Convert.ToInt32(tbRoomsTo.Text);

                    for (int i = 1; i <= counter; i++)
                    {
                        int temp = i * 17;
                        temp -= 11;
                        fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);
                        for (int j = 1; j < temp; j++)
                        {
                            sr.ReadLine();
                        }
                        int rooms = Convert.ToInt32(inputHandler(sr.ReadLine()));

                        fs.Close();
                        sr.Close();
                        if (roomsFrom <= rooms && roomsTo >= rooms)
                        {
                            if (temTurn == 1)
                            {
                                turn = i;
                                DataList.price.Add(temp);
                                corRes++;
                            }

                            dataWriter();
                        }

                       
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                checkQuant();
            }
        }
        void checkContType()
        {
            if (rbContType.Checked)
            {
                try
                {
                    string cont = cbConType.Text;
                    for (int i = 1; i <= counter; i++)
                    {
                        int temp = i * 17;
                        temp -= 9;
                        fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                        sr = new StreamReader(fs);
                        for (int j = 1; j < temp; j++)
                        {
                            sr.ReadLine();
                        }
                        string contType = inputHandler(sr.ReadLine());

                        fs.Close();
                        sr.Close();
                        if (cont == contType)// Sell Office Rental
                        {
                            if (temTurn == 1)
                            {
                                turn = i;
                                DataList.price.Add(temp);
                                corRes++;
                            }

                            dataWriter();
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                } 

                checkQuant();

            }
        }
        private string inputHandler(string s)
        {
            int doubleIndex = s.LastIndexOf(":");
            string finR = s.Substring(doubleIndex + 1).Trim();
            return finR;
        }

        private void pbImg_Click(object sender, EventArgs e)
        {
        }

        void dataWriter()
        {
            try
            {
                 fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                 sr = new StreamReader(fs);
                for (int i = 0; i < turn; i++)
                {
                    labId.Text = inputHandler(sr.ReadLine());
                    labSize.Text = inputHandler(sr.ReadLine());
                    labFloor.Text = inputHandler(sr.ReadLine());
                    labAge.Text = inputHandler(sr.ReadLine());
                    labAddr.Text = inputHandler(sr.ReadLine());
                    labRooms.Text = inputHandler(sr.ReadLine());
                    labBathr.Text = inputHandler(sr.ReadLine());
                    labContrType.Text = inputHandler(sr.ReadLine());
                    labPrice.Text = inputHandler(sr.ReadLine());
                    labOptionsList.Text = inputHandler(sr.ReadLine());
                    labName.Text = inputHandler(sr.ReadLine());
                    labSurname.Text = inputHandler(sr.ReadLine());
                    LabBirthday.Text = inputHandler(sr.ReadLine());
                    labAddrOwner.Text = inputHandler(sr.ReadLine());
                    labPhone.Text = inputHandler(sr.ReadLine());
                    labEmail.Text = inputHandler(sr.ReadLine());
                    string divider = sr.ReadLine();
                }
                fs.Close();
                sr.Close();
                string labelId = labId.Text;
                string[] allImg = Directory.GetFiles("img");
                foreach (string s in allImg)
                {
                    if (s.Contains(labelId))
                    {
                        pbImg.Image = Image.FromFile(s);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void butNextProp_Click(object sender, EventArgs e)
        {
            butPrevProp.Enabled = true;

            turn = Convert.ToInt32(DataList.price[temTurn] / 17);
            temTurn++;
            if (turn ==0)
            {
                turn = Convert.ToInt32(DataList.price[temTurn] / 17);
            }

            checkContType();
            checkRooms();
            checkPrice();
            if (temTurn >= corResF)
            {
                //temTurn--;
                butNextProp.Enabled = false;
            }
        }

        private void butPrevProp_Click(object sender, EventArgs e)
        {
            butNextProp.Enabled = true;
            temTurn--;
            turn = Convert.ToInt32(DataList.price[temTurn] / 17);
            if (turn + 1 != temTurn)
            {
                turn--;
            }

            checkContType();
            checkRooms();
            checkPrice();
            if (temTurn <= 1)
            {
                butPrevProp.Enabled = false;
            }
        }
        public void checkQuant()
        {
            if (DataList.price.Count() == 0)
            {
                temTurn = 0;
            }
            labNumProp.Text = $"{temTurn} out of {corResF}";
        }
    }
}
