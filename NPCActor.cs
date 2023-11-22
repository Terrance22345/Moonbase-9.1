using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace Moonbase
{
    public class NPCActor : ReceiveActor
    {
        public string Name { get; private set; }
        public string JobTitle { get; private set; }

        public NPCActor(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;

            //Define the actors behavior
            Receive<string>(message =>
            {
                // Handle messages if needed
            });
        }
    }
}

 