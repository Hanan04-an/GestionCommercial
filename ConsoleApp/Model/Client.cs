using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    internal class Client: Tiers
    {
        public int PlafondCredit { get; set; }

        public override void GetNom()
        {
            base.GetNom();
            Console.WriteLine($"Je suis dans la classe Client  ");
        }

    }
}
