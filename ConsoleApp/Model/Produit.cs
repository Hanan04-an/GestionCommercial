using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    internal class Produit : BaseEntity, IWork
    {
        public string Libelle { get; set; } = string.Empty;
        public decimal Prix { get; set; }
        public int stock { get; set; }

       public void Update()
        {
            Console.WriteLine($"Produit {Libelle} mis à jour.");
        }   

       public void Create ()
        {
            Console.WriteLine($"Produit {Libelle} créé.");
        }
         public void Delete()
        {
            Console.WriteLine($"Produit {Libelle} supprimé.");
        }

    }
}
