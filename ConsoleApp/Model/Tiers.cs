using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp.Model
{
    internal abstract class Tiers: BaseEntity
    {
        public string Nom { get; set; } = string.Empty;
        public Addresse Addresse { get; set; } 
        public virtual void GetNom()
        {
            Console.WriteLine($"Nom: {Nom}");
        }
    }
}
