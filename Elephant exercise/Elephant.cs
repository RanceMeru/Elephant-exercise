using System;
using System.Collections.Generic;
using System.Text;

namespace Elephant_exercise
{
    class Elephant
    {   /*goal is to make two elephant objects then give them individual names ,earsize  the* reference values will be swapped*/

        public int EarSize; // theses will be methods that determine the ear size and names
        public string Name;
        //void methods I am still not too clear on
        //the behavior or actions is made by the mdethods
        public void WhoAmI()
        {
            Console.WriteLine("My name is " + Name + ".");
            Console.WriteLine("My ears are " + EarSize + " inches tall.");
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }

        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }

    }
}

