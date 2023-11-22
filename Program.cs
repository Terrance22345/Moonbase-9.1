using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akka.Actor;
using Akka.Dispatch.SysMsg;

namespace Moonbase
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //create an actor system
            using (var system = ActorSystem.Create ("MyActorSystem"))
            {
                List<IActorRef> npcActors = new List<IActorRef>
                {
                system.ActorOf(Props.Create(() => new NPCActor("NPC1", "Job1")), "NPCActor1"),
                system.ActorOf(Props.Create(() => new NPCActor("NPC2", "Job2")), "NPCActor2"),
            };
             
                //Open the WestwingForm and pass the list of NPC actors
                Application.Run(new WestwingForm(npcActors));
            }
                
        }
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //Create the actor system
            using (var system = ActorSystem.Create("MyActorSystem"))
            {
                // Create an instance of PlayerControllerActor
                var playerControllerActor = system.ActorOf(Props.Create<PlayercontrollerActor>(), "PlayerControllerActor");

                // Send the "Westwing message to the actor
                playerControllerActor.Tell("Westwing");
                playerControllerActor.Tell("Southwing");
                playerControllerActor.Tell("Eastwing");

                Console.ReadLine();
            }
        }
        
    }
}
