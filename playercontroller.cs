using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Moonbase
{
    public class PlayercontrollerActor : ReceiveActor
    {
        public PlayercontrollerActor()
        {
            //Define the actor's behavior
            Receive<string>(message =>
            {
                if (message.ToLower() == "westwing")
                {


                    //Navigate to Westwing.cs
                    WestwingForm westwingForm = new WestwingForm();
                    westwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when WestwingForm is closed
                    westwingForm.Show();
                }
                else
                {
                    Console.WriteLine("Unknow command: " + message);
                }
                if (message.ToLower() == "southwing")
                {


                    //Navigate to Southwing.cs
                    SouthwingForm southwingForm = new SouthwingForm();
                    southwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when SouthwingForm is closed
                    southwingForm.Show();
                }
                else
                {
                    Console.WriteLine("Unknow command: " + message);
                }
                if (message.ToLower() == "eastwing")
                {


                    //Navigate to Eastwing.cs
                    EastwingForm eastwingForm = new EastwingForm();
                    eastwingForm.FormClosed += (s, args) => this.Hide(); // Close Form1 when EastwingForm is closed
                    eastwingForm.Show();
                }
                else
                {
                    Console.WriteLine("Unknow command: " + message);
                }
            });
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }
    }
}
