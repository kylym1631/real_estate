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
    public partial class ListOfProperties : Form
    {
        int counter = 0;
        int turn = 1;
        string options;
        StreamReader sr;
        FileStream fs;
        public ListOfProperties()
        {
            InitializeComponent();
            this.CenterToScreen();
            if (!File.Exists("data.txt") || new FileInfo("data.txt").Length == 0)
            {
                MessageBox.Show("There is no data to show");
                butPrevProp.Enabled = butNextProp.Enabled = gbFlat.Enabled = false;
            }
            else
            {

                try
                {
                    changeLab();
                    //for counting how many contact do I have
                    while (!sr.EndOfStream)
                    {
                        for (int i = 1; i <= 16; i++)
                        {
                            sr.ReadLine();
                        }
                        counter++;
                    }
                    //if there is only 1 contact
                    if (counter == 0)
                    {
                        counter++;
                        butNextProp.Enabled = false;
                    }
                    checkPrev();
                    checkQuant();
                    sr.Close();
                    fs.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);;
                }
            }
        }
        
        public void changeLab()
        {
            try
            {
                fs = new FileStream("data.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                //which contact's turn... reads that many times
                for (int i = 0; i < turn; i++)
                {
                    labId.Text =  inputHandler(sr.ReadLine());
                    labSize.Text = inputHandler(sr.ReadLine());
                    labFloor.Text =  inputHandler(sr.ReadLine());
                    labAge.Text =  inputHandler(sr.ReadLine());
                    labAddr.Text = inputHandler(sr.ReadLine());
                    labRooms.Text =  inputHandler(sr.ReadLine());
                    labBathr.Text =  inputHandler(sr.ReadLine());
                    labContrType.Text =  inputHandler(sr.ReadLine());
                    labPrice.Text =  inputHandler(sr.ReadLine());
                    options = inputHandler(sr.ReadLine());
                    labName.Text =  inputHandler(sr.ReadLine());
                    labSurname.Text =  inputHandler(sr.ReadLine());
                    LabBirthday.Text =  inputHandler(sr.ReadLine());
                    labAddrOwner.Text = inputHandler(sr.ReadLine());
                    labPhone.Text = inputHandler(sr.ReadLine());
                    labEmail.Text =  inputHandler(sr.ReadLine());
                    string divider = sr.ReadLine();
                }
                string labelId = labId.Text;
                string[] allImg = Directory.GetFiles("img");
                foreach (string s in allImg)
                {
                    if (s.Contains(labelId))
                    {
                        pbImg.Image = Image.FromFile(s);
                    }
                }




                if (options.Contains(cbFurnished.Text))
                {
                    cbFurnished.Checked = true;
                }

                if (options.Contains(cbWithOwner.Text))
                {
                    cbWithOwner.Checked = true;
                }
                if (options.Contains(cbInternet.Text))
                {
                    cbInternet.Checked = true;
                }
                if (options.Contains(cbElevator.Text))
                {
                    cbElevator.Checked = true;
                }
                if (options.Contains(cbHCWater.Text))
                {
                    cbHCWater.Checked = true;
                }
                if (options.Contains(cbBath.Text))
                {
                    cbBath.Checked = true;
                }
                if (options.Contains(cbAirCon.Text))
                {
                    cbAirCon.Checked = true;
                }
                if (options.Contains(cbPool.Text))
                {
                    cbPool.Checked = true;
                }
                if (options.Contains(cbIndStove.Text))
                {
                    cbIndStove.Checked = true;
                }
                if (options.Contains(cbBalcony.Text))
                {
                    cbBalcony.Checked = true;
                }
                if (options.Contains(cbSecDesk.Text))
                {
                    cbSecDesk.Checked = true;
                }
                if (options.Contains(cbGym.Text))
                {
                    cbGym.Checked = true;
                }

                foreach (Control c in gbFlat.Controls)
                {
                    if (c is CheckBox)
                    {
                        c.Enabled = false;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private string inputHandler(string s)
        {
            int doubleIndex = s.LastIndexOf(":");
            string finR = s.Substring(doubleIndex + 1).Trim();
            return finR;
        }
        private void butExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

       
        public void checkPrev()
        {
            if (turn == 1)
            {
                butPrevProp.Enabled = false;
            }
        }
        public void checkQuant()
        {
            labNumProp.Text = $"{turn} out of {counter}";
        }
        
        void clearCheckboxes()
        {
            foreach (Control c in gbFlat.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                c.Enabled = true;

            }
        }
        private void butNextProp_Click(object sender, EventArgs e)
        {
            clearCheckboxes();
            butPrevProp.Enabled = true;
            turn++;
            if (turn < counter + 1)
            {
                changeLab();
                if (turn == counter)
                {
                    butNextProp.Enabled = false;
                }
            }
            checkQuant();
            sr.Close();
            fs.Close();
        }

        private void butPrevProp_Click(object sender, EventArgs e)
        {
            clearCheckboxes();
            butNextProp.Enabled = true;
            checkPrev();
            if (turn > 1)
            {
                turn--;
                checkPrev();
                for (int i = 0; i < counter - 1; i++)
                {
                    changeLab();
                    sr.Close();
                    fs.Close();
                }
            }
            checkQuant();
            sr.Close();
            fs.Close();
        }
    }
}
