using System;

namespace CargoDelivery
{
    public class Cargo
    {
        int number = 2;
        int weight = 3;
        int bottle = 1;
        int LitreForEach = 2;
        public void AzeCargo()
        {
            
            Console.WriteLine ("Cargo to Azerbaijan costs " 
                + ((number*weight) + (bottle*LitreForEach*2.5)) + " AZN.");
            Console.WriteLine(((number * weight) + (bottle * LitreForEach * 2.5)) / 1.7 + " USD.");
        }

        public void USACargo()
        {

            Console.WriteLine("Cargo to the USA costs " 
                + ((number * weight * 5) + (bottle * LitreForEach * 6)) + " USD.");
        }

        public void NorwayCargo()
        {
            Console.WriteLine("Cargo to Norway costs "
                + ((number * weight * 55) + (bottle * LitreForEach * 63)) + " KON.");
            Console.WriteLine(((number * weight * 55) + (bottle * LitreForEach * 63)) * 0.094 + " USD.");
        }

        public void TrCargo()
        {
            Console.WriteLine("Cargo to Turkey costs "
                + ((number * weight * 20) + (bottle * LitreForEach * 35)) + " TL.");
            Console.WriteLine(((number * weight * 20) + (bottle * LitreForEach * 35)) * 0.054 + " USD.");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Costs of this luggage's export (per kilogram) from Azerbaijan to these countries: ");
            Cargo AZEbox = new Cargo();
            AZEbox.AzeCargo();
            Cargo Trbox = new Cargo();
            Trbox.TrCargo();
            Cargo USAbox = new Cargo();
            USAbox.USACargo();
            Cargo Norwaybox = new Cargo();
            Norwaybox.NorwayCargo();
        }
    }
}