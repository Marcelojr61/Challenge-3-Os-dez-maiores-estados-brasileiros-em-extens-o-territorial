using System;
using System.Runtime.CompilerServices;

namespace Codenation.Challenge
{
    public class State
    {
        public string Name { get; set; }
        public string Acronym { get; set; }
        public double GeneralArea { get; set; }

        public State(string name, string acronym)
        {
            this.Name = name;
            this.Acronym = acronym;
        }

        public State(string name, string acronym, double generalArea) : this(name, acronym)
        {
            this.GeneralArea = generalArea;
        }
    }

}
