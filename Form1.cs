using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akka.Actor;

namespace Moonbase
{
    public partial class Form1 : Form
    {
        private ActorSystem actorSystem;
        private IActorRef playerControllerActor;
        private IActorRef funFactActor;
        public Form1()
        {
            InitializeComponent();

            // Set the window state to Maximized for full screen
            this.WindowState = FormWindowState.Maximized;

            //Create the actor system
            actorSystem = ActorSystem.Create("MyActorSystem");

            //Create an insteance of playerControllerActor
            playerControllerActor = actorSystem.ActorOf(Props.Create<PlayercontrollerActor>(), "PlayerControllerActor");

            //Create an instance of FunFact Actor
            funFactActor = actorSystem.ActorOf(Props.Create<FunFactActor>(), "FunFactActor");
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //This code pop up a message box asking you a question. Then either close
            //the box or the program depending on the input.
            DialogResult dr = MessageBox.Show("Are you sure you don't want to go on the Space Adventure!", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
            
        {
            // Simple code that checks if the box was checked. Then allows you to press sign up
            button2.Enabled = checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Just shows the acccount was created then closes the program.
            MessageBox.Show("Account is Created. Welcome to the Team!");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Code to navigate to WestwingForm
            WestwingForm westwingForm = new WestwingForm();
            westwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when WestwingForm is closed
            westwingForm.Show();
            //playerControllerActor.Tell("Westwing");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Code to navigate to EastwingForm
            EastwingForm eastwingForm = new EastwingForm();
            eastwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when EastwingForm is closed
            eastwingForm.Show();
            //playerControllerActor.Tell("Eastwing");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Code to navigate to SouthwingForm
            SouthwingForm southwingForm = new SouthwingForm();
            southwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when SouthwingForm is closed
            southwingForm.Show();
            //playerControllerActor.Tell("Southwing");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            funFactActor.Tell("ShowFunFact2");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            funFactActor.Tell("ShowFunFact");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            funFactActor.Tell("ShowFunFact3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            funFactActor.Tell("ShowFunFact4");
        }
    }
}
