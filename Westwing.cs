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
    public partial class WestwingForm : Form
    {
        private List<IActorRef> npcActors;

        public WestwingForm(List<IActorRef> npcActors)
        {
            InitializeComponent();
            this.npcActors = npcActors;
            DisplayNPCInformation();
        }

        private void DisplayNPCInformation()
        {
            //Clear existing controls
            listBoxNPCNames.Items.Clear();
            listBoxJobTitles.Items.Clear();

            //Add NPC information to the lists
            foreach (var npcActor in npcActors)
            {
                var npc = new { Name = npcActor.Path.Name, JobTitle = npcActor.Ask<string>("GetJobTitle").Result };

                //Add to the NPC name lists
               listBoxNPCNames.Items.Add(npc.Name);

                //Add to the job titles list
                listBoxJobTitles.Items.Add(npc.JobTitle);

            }
        }

        public WestwingForm()
        {
            InitializeComponent();

            // Set the window state to Maximized for full screen
            this.WindowState = FormWindowState.Maximized;
        }

        private void Westwing_Load(object sender, EventArgs e)
        {

        }

        private void listBoxNPCNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected NPC name in the TextBox
            textBoxSelectedNPCName.Text = listBoxNPCNames.SelectedItem?.ToString();
        }

        private void listBoxJobTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the selected job title in the TextBox
            textBoxSelectedJobTitle.Text = listBoxJobTitles.SelectedItem?.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Close the current form (Westwing.cs)
            this.Close();

            // Show Form1
            form1.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            listBoxNPCNames.SelectedIndexChanged += listBoxNPCNames_SelectedIndexChanged;
        }
    }
}
