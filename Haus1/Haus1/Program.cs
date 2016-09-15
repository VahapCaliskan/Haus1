using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haus1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double da, db, dc, dd, de, df;
            Console.WriteLine("Bitte geben Sie alle Längen in Metern an!");
            Console.WriteLine("-------------------");
            Console.WriteLine("Seite a:");
            if (!Double.TryParse(input = Console.ReadLine(), out da)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            da = Double.Parse(input);
            if (da < 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite b:");
            if (!Double.TryParse(input = Console.ReadLine(), out db)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            db = Double.Parse(input);
            if (db < 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite c:");
            if (!Double.TryParse(input = Console.ReadLine(), out dc)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dc = Double.Parse(input);
            if (dc < 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite d:");
            if (!Double.TryParse(input = Console.ReadLine(), out dd)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dd = Double.Parse(input);
            if (dd < 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite e:");
            if (!Double.TryParse(input = Console.ReadLine(), out de)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            de = Double.Parse(input);
            if (de < 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            if (db < de + 6 || da < dd + 6) { Console.WriteLine("Es wurden falsche Angaben gemacht.\nErrorcode: minimum distance 3m\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            df = Math.Sqrt(Math.Pow((dc-da), 2) * Math.Pow(db, 2));
            double dPerimeterFence = da + db + dc + dd + de + df;
            double dAreaLawn = (da * db) + (((dc-da) * db) / 2) - (dd * de);
            Console.WriteLine("-------------------");
            Console.WriteLine("Zaunlänge: {0}m", dPerimeterFence);
            Console.WriteLine("Zu besähende Fläche: {0}m²", dAreaLawn);
            Console.Read();
        }
    }
}
