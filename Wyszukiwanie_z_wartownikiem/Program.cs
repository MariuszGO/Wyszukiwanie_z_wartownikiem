using System;

namespace Wyszukiwanie_z_wartownikiem
{
    internal class Program
    {
        public int []tab = new int [51];

/******************************************************
 nazwa funkcji: <losuj>
 argumenty: brak
 typ zwracany: void - watrtość pusta
 informacje: <funkcja losuje do tablicy 50 elementów z przedziału od 1 do 100>
 autor: <numer zdającego>
*****************************************************/

     public void losuj()
        {
            Random rand = new Random();

            for (int i = 0; i < 50; i++)
            {
                tab[i] = rand.Next(1, 100);
            }
        }
/******************************************************
 nazwa funkcji: <szukaj>
 argumenty: brak
 typ zwracany: int - wartość całkowita określająca index znalezionego elemnetu
 informacje: <funkcja wyszukuje index szukanego elementu, funkcja realizuje wyszukiwanie
 z wartownikiem>
 autor: <numer zdającego>
*****************************************************/

        public int szukaj()
        {
            Console.WriteLine("Podaj liczbę jaką chcesz wyszukać:");
            
            tab[50] =  Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 51; i++)
            {
                if (tab[i] == tab[50])
                {
                    return i; 
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Program obiekt = new Program();

            obiekt.losuj();
          
            int liczba = obiekt.szukaj();
            if (liczba == 50) {
                Console.WriteLine("Nie znaleziono liczby");
            }
            else
            {
                Console.WriteLine("Znaleziona liczba ma index" + liczba);
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(obiekt.tab[i] + ", ");
            }

        }
    }
}