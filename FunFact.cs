using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using System.Windows.Forms;
using Akka.Actor.Dsl;
using System.ComponentModel.Design;
using System.Threading;

namespace Moonbase
{
    public class FunFactActor : ReceiveActor
    {
        public FunFactActor()
        {
            //Define the actor's behavior
            Receive<string>(message =>
                {
                    if (message.ToLower() == "showfunfact")
                    {
                        //show a message with a fun fact
                        MessageBox.Show("Welcome to the Moonbase, Earthling! I am your friendly robot guide, here to introduce you to our lunar sanctuary. My circuits are buzzing with excitement to show you around. As your trusty robotic companion, I am in charge of the Northwing, where innovation and exploration collide. Prepare to embark on an interstellar journey as we explore the wonders of the cosmos together. Follow me, and let the lunar adventures begin!");
                    }
                    if (message.ToLower() == "showfunfact2")
                    {
                        //show a message with a fun fact
                        MessageBox.Show("Greetings, Earthling explorer! I am your dedicated robot guide, designed to assist you on your lunar adventure.Allow me to extend a warm welcome to our Moonbase, where the mysteries of space unfold.I am your trustworthy companion, overseeing the Westwing, also known as our state - of - the - art Training Hall.Here, you will embark on educational odysseys and hone your skills for the cosmic challenges ahead.Together, we'll unravel the secrets of the universe. Let the learning and discovery commence!");
                    }
                    if (message.ToLower() == "showfunfact3")
                    {
                        //show a message with a fun fact
                        MessageBox.Show("Greetings, Earthling explorer! I am your robotic guide, programmed to assist you in navigating the marvels of our lunar home. Welcome to the Moonbase, where boundless possibilities await. I am proudly entrusted with overseeing the Eastwing, also referred to as our high-tech Control Room. Here, we orchestrate the moon's activities and ensure the smooth operation of our lunar sanctuary. Prepare to embark on a cosmic journey as we explore the universe together. Your adventure begins now!");
                    }
                    if (message.ToLower() == "showfunfact4")
                    {
                        //show a message with a fun fact
                        MessageBox.Show("Salutations, Earthling friend! I am your robotic guide, designed to accompany you on this extraordinary lunar expedition. Welcome to the Moonbase, our celestial haven amidst the stars. It is my honor to be in charge of the Southwing, lovingly known as the Sleeping Quarters. Here, you'll find comfort and rest after your cosmic adventures. As you embark on this interstellar journey, rest assured that I am here to assist you every step of the way. Sweet dreams under the lunar glow!");
                    }
                });
        }

    }
}
