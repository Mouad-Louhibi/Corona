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
            String chaine;

            // Grab the connection string from App.fig
            // Make sure the connection string name is the same with App.Config
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;

            SqlConnection SQLserverConnection = new SqlConnection();
            SqlDataAdapter SQLserverAdapter = new SqlDataAdapter();

            //static string chaine = @"Data Source=DESKTOP-SK434AF;Initial Catalog=Covid19;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection cnx = new SqlConnection(chaine);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            // Create SQL connection object
            // Pass int connection string into the constructor

            // Open the DataBase connection
            cnx.Open();
            Console.WriteLine("Connected");

            // Close the connection after use
            cnx.Close();

            /**************************************************   mainMenu   **************************************************/
            int operation;

            Console.WriteLine("Taper un nombre pour choisir l'operation");
            Console.WriteLine("1- Afficher les citoyens");

            operation = Int32.Parse(Console.ReadLine());

            if (operation == 1)
            {
                Persistence persistence = new Persistence();

                persistence.AfficheCitoyen();
            }
        }
    }
}
