using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
  class Program
  {
    static void Main(string[] args)
    {
      // Három egész számot kérjünk be a felhasználótól
      // Döntsük el szerkeszthető-e belőle háromszög?
      // Hogyan dönthető el?
      //     -- bármely két oldal összege nagyobb
      //        kell legyen mint a harmadik         
      // Kimenet: Szerkeszthető / Nem szerkeszthető

      // Adatok bekérése
      // Mindig helyes adatot adunk meg! (ha egész akkor egész)
      int a, b, c;

      Console.Write("Kérek egy egész számot: ");
      a = Convert.ToInt32(Console.ReadLine());

      Console.Write("Kérek egy egész számot: ");
      b = Convert.ToInt32(Console.ReadLine());

      Console.Write("Kérek egy egész számot: ");
      c = Convert.ToInt32(Console.ReadLine());

      // logikai változó 
      // két értéke lehet: true, false
      //bool igaz = true;
      bool igaz;

      // Eldöntjük, hogy szerkeszthető-e belőlük háromszög
      //if (a + b < c) // ekkor nem
      //{
      //  igaz = false;
      //}
      //else if (a + c < b) // ekkor sem
      //{
      //  igaz = false;
      //} 
      //else if(b + c < a) // és ekkor sem
      //{
      //  igaz = false;
      //}

      // VAGY felhasználása
      //if ( a + b < c || a + c < b || b + c < a )
      //if ( (a + b < c) || (a + c < b) || (b + c < a) )
      //{
      //  igaz = false;
      //}

      if (a + b > c && a + c > b && b + c > a)
      {
        igaz = true;
      }
      else
      {
        igaz = false;
      }

      // ha "igaz" változó értéke 
      // true -> akkor szerkeszthető
      // false -> akkor nem szerkeszthető

      // == összehasonlítás (egyenlőségre)
      if ( igaz )
      {
        Console.WriteLine("Szerkeszthető");
      }
      else
      {
        Console.WriteLine("Nem szerkeszthető");
      }

      Console.ReadKey();
    }
  }
}
