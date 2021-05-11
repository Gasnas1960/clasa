using System;

namespace clasa
{
       
              class Persoana
        {
            // declaratii atribute 
            public string Nume;
            public int Varsta;
            // constructor 
            public Persoana(string nume, int varsta)
            {
                Nume = nume; // echivalent cu this.Nume = nume; 
                Varsta = varsta;
            }
            // metoda 
            public void Afiseaza()
            {
                Console.WriteLine("{0} ({1} ani)", Nume, Varsta);
            }
        }

    public class AplicatieTest
    {

        public static void Main()
        {
            // creare obiect 
            Persoana pers = new Persoana("Popescu Maria", 23);
            // accesare atribute 
            string nume = pers.Nume;
            // accesare metoda 
            pers.Afiseaza();
        }

    }
    
}

