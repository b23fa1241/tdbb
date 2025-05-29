using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tdbb
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
           
                Personal_information userControl = new  Personal_information();
                userControl.Dock = DockStyle.Fill;
                panel2.Controls.Add(userControl);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Family_information userControl = new Family_information();
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
        }
    }
}
