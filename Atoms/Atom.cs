using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtomsLibrary
{
    public class Atom
    {
        public string Name;
        public string Symbol;
        public int Proton;
        public int Neutron;
        public double Weight;
        public Atom() { }
        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }
        public static Atom Parse(string line)
        {
            Atom obj;
            int pro, neu; double wei; string nam, sym;
            string[] parts = line.Split(' ');


            if (parts.Length == 5)
            {
                obj = new Atom(nam = parts[0],
                 pro = int.Parse(parts[1]),
                 neu = int.Parse(parts[2]),
                 wei = Double.Parse(parts[3]),
                 sym = parts[4]);
            }
            else
            {
                throw new Exception("OOPS! There should be 5 values/parts.");
            }
            return obj;



        }
        public override string ToString()
        {
            return string.Format("Element : {0} (Symbol : {1}, Weight : {2}, Proton : {3}, Neutron : {4})", Name, Symbol, Weight, Proton, Neutron);
        }
    }
}

