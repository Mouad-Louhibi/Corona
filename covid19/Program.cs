using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace covid19
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************************************************   mainMenu   **************************************************/
            int operation;

            Console.WriteLine("Taper un nombre pour choisir l'operation");
            Console.WriteLine("1- Afficher les citoyens");

            operation = Int32.Parse(Console.ReadLine());

            if (operation == 1)
            {
                Persistence persistence = new Persistence();

                persistence.SupprimerCitoyen(4);
            }
        }
    }
}
