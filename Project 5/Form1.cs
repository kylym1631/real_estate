using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

        }


        private void butAddProp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add aP = new Add();
            aP.ShowDialog();
            this.Close();
        }

        private void butSearchProp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search sP = new Search();
            sP.ShowDialog();
            this.Close();
        }

        private void butShowProp_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListOfProperties lOp = new ListOfProperties();
            lOp.ShowDialog();
            this.Close();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
