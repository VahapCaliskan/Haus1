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
            string sa, sb, sc, sd, se;
            double da, db, dc, dd, de, df;
            Console.WriteLine("Bitte geben Sie alle Längen in Metern an!");
            Console.WriteLine("-------------------");
            Console.WriteLine("Seite a:");
            sa = Console.ReadLine();
            if (!Double.TryParse(sa, out da)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            da = Double.Parse(sa);
            if (da <= 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite b:");
            sb = Console.ReadLine();
            if (!Double.TryParse(sb, out db)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            db = Double.Parse(sb);
            if (db <= 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite c:");
            sc = Console.ReadLine();
            if (!Double.TryParse(sc, out dc)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dc = Double.Parse(sc);
            if (dc <= 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite d:");
            sd = Console.ReadLine();
            if (!Double.TryParse(sd, out dd)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            dd = Double.Parse(sd);
            if (dd <= 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            Console.WriteLine("Seite e:");
            se = Console.ReadLine();
            if (!Double.TryParse(se, out de)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
            de = Double.Parse(se);
            if (de <= 1) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q); return; }
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
