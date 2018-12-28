using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Account user = Account.Instance;      

            Console.WriteLine(user.id);
            Console.WriteLine("Welcome " + user.name + " take a seat and play!");
            ConsoleKeyInfo key;
            //ldo
            //{
                Console.WriteLine("Choose game: (g - Go, c - Chess,  d - draughts)");
                key = Console.ReadKey();
                
                Console.WriteLine("\n" + "Chosen game: {0}", key.KeyChar);

                Facade facade = new Facade();
                facade.createGame(key.KeyChar, user);
            //} while (key.KeyChar != 'g' | key.KeyChar != 'c' | key.KeyChar != 'd');
            
            Console.ReadKey();
        }
    }
}
