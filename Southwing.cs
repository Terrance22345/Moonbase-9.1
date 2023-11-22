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
    public partial class SouthwingForm : Form
    {
        public SouthwingForm()
        {
            InitializeComponent();

            // Set the window state to Maximized for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void Southwing_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Close the current form (Southwing.cs)
            this.Close();

            // Show Form1
            form1.Show();
        }
    }
}
