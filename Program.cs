/*
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using AlbinTest;


int a = 184; 

Console.WriteLine(a);

Fordon fordon = new();


fordon.namn = "BMW";
Fordon fordon1 = fordon;

Console.WriteLine(fordon1.namn);



using System.Net.WebSockets;

Fordon fordon = new("BMW", "320i", 2016);

Console.WriteLine($"Tillverkare: {fordon.GetTillverkare()}, Modell: {fordon.GetModell()}, årsmodell: {fordon.Getårsmodell()}");
*/






/*
uppgift 2
public class Fordon
{   private string tillverkare;
    private string modell;
    private int årsmodell;



    

    public Fordon(string tillverkare, string modell, int årsmodell)
    {
        this.tillverkare = tillverkare;
        this.modell = modell;
        this.årsmodell = årsmodell;
    }

    public string Tillverkare
    {
        get{ return tillverkare;}
        set{ tillverkare = value; }
    
    }
    public string Modell
    {
        get{ return modell;}
        set{ modell = value; }
    
    }
     public int Årsmodell
    {
       get{ return årsmodell;}
        set{ årsmodell = value; } 
    }

}
*/

using System.Linq.Expressions;

/*
uppgift 3 försök 1
private string fordon;
    private string modell;
    private int årsmodell;

    public fordon(string n, int a, string b);

public static void Main(){

    List<Fordon> fordonslista = new List<Fordon>();

    Fordson p = new fordon("lexus", 2020, "lfa");
    fordonslista.Add(p);
    fordonslista.Add(new Fordon("bmw", 1998, "M5"));

    foreach (Fordon element in fordonslista);{

        Console.WriteLine(element.fordon);
        Console.WriteLine(element.årsmodell);
        Console.WriteLine(element.modell);
    }


}
*/


using System;
using System.Collections.Generic;

public class Fordon
{
        public string Märke;
    public string Modell;
    public int Hastighet;
    public int År;

        public Fordon(string märke, string modell, int hastighet, int år)
    {
        Märke = märke;
        Modell = modell;
        Hastighet = hastighet;
        År = år;
    }

    public void VisaInformation()
    {
        Console.WriteLine($"Märke: {Märke}, Modell: {Modell}, Hastighet: {Hastighet} km/h, År: {År}");
    }
}

public class Fordonslista
{

    private List<Fordon> fordonLista = new List<Fordon>();

    public void LäggTillFordon(Fordon fordon)
    {
        fordonLista.Add(fordon);
    }

    public void SkrivUtRegistret()
    {
        if (fordonLista.Count == 0)
        {
            Console.WriteLine("Inget fordon i registret.");
            return;
        }

        foreach (var fordon in fordonLista)
        {
            fordon.VisaInformation();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Fordonslista fordonslista = new Fordonslista();

       
        fordonslista.LäggTillFordon(new Fordon("Volvo", "S60", 180, 2022));
        fordonslista.LäggTillFordon(new Fordon("BMW", "520D", 240, 2021));
        fordonslista.LäggTillFordon(new Fordon("Audi", "A6", 240, 2019));

        Console.WriteLine("Registret:");
        fordonslista.SkrivUtRegistret();
    }
}




