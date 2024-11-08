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

*/

Fordon fordon = new("BMW", "320i", 2016);

Console.WriteLine($"Tillverkare: {fordon.GetTillverkare()}, Modell: {fordon.GetModell()}, årsmodell: {fordon.Getårsmodell()}");

public class Fordon
{    private string tillverkare;
    private string modell;
    private int årsmodell;

    public Fordon(string tillverkare, string modell, int årsmodell)
    {
        this.tillverkare = tillverkare;
        this.modell = modell;
        this.årsmodell = årsmodell;
    }

    public string GetTillverkare()
    {
        return tillverkare;
    }

    public void SetTillverkare(string tillverkare)
    {
        this.tillverkare = tillverkare;
    }

    public string GetModell()
    {
        return modell;
    }

    public void SetModell(string modell)
    {
        this.modell = modell;
    }

    public int Getårsmodell()
    {
        return årsmodell;
    }

    public void SetÅrsmodell(int årsmodell)
    {
        this.årsmodell = årsmodell;
    }


}


