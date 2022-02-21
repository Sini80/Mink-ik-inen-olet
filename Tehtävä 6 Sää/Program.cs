// See https://aka.ms/new-console-template for more information

//Määritetään muuttuja
string paistaa;
string sataa;
string lampotila;

//Kysytään kysymykset ja tulostetaan
Console.Write("Paistaako aurinko (K/E) ? ");
paistaa = Console.ReadLine();
Console.Write("Sataako vettä (K/E) ? ");
sataa = Console.ReadLine();
Console.Write("Onko lämpötila > 0 (K/E) ? ");
lampotila = Console.ReadLine();

// if ja elsellä määritellään muuttujat. 
if(paistaa == "K" && sataa == "K" && lampotila == "K")
{
    Console.WriteLine(" Aurinko paistaa ja vettä sataa, taitaa tulla kesä ");// Tulostetaan lause (KKK)
}
else if(paistaa == "E" && sataa == "K" && lampotila == "K")// else ifillä muuttujille toiset arvot
{
    Console.WriteLine(" Syksy saapui tuuli vei lehdet mennessään  ");//Tulostetaan lause (E,K;K)
}
else if (paistaa == "E" && sataa == "E" && lampotila == "K") //else ifillä muuttujille toiset arvot
{
    Console.WriteLine(" Jo joutui armas aika ja suvi suloinen  ");// Tilostetaan lause(E,E,K)
}
else if (paistaa == "K" && sataa == "E" && lampotila == "E")//else ifillä muuttujille toiset arvot
{
    Console.WriteLine(" Keväinen talvi kesän tuo  ");//Tulostetaan lause (K,E,E)
}
else
{
    Console.WriteLine(" Ompa erikoinen sää !");// Elsellä, kun muuta ei löytynyt
}