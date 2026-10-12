using ConsoleApp.Model;

var p1 = new Produit();

Produit p2 = new Produit();

Produit p3 = new Produit()
{
    Libelle = "Produit 3",
    Prix = 100.0m,
    stock = 50
};



var client = new Client()
{
    Nom = "Client 1",
    PlafondCredit = 1000
};

client.GetNom();
Produit P1 = new Produit()
{
    Libelle = "Produit 1",
    Prix = 50.0m,
    stock = 20
};
Produit P2 = new Produit()
{
    Libelle = "Produit 2",
    Prix = 75.0m,
    stock = 30
};
P1.Create();
P2.Create();
P1.Update();
P2.Delete();

