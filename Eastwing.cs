using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class EastwingForm : Form
    {
        public EastwingForm()
        {
            InitializeComponent();

            // Set the window state to Maximized for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void Eastwing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Close the current form (Eastwing.cs)
            this.Close();

            // Show Form1
            form1.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
