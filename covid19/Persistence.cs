using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace covid19
{
    class Persistence
    {



        // Grab the connection string from App.fig
        // Make sure the connection string name is the same with App.Config

        static SqlConnection SQLserverConnection = new SqlConnection();
        static SqlDataAdapter SQLserverAdapter = new SqlDataAdapter();

        static string chaine = @"Data Source=DESKTOP-SK434AF;Initial Catalog=Covid19;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        //String couleur, String statutCitoyen, String etatHospitalier, String etatVaccination, String traitement
        Citoyen citoyen = new Citoyen(5, "Adam", "Sale", "Green", "Stable", "Null", "Null", "Null");

        //cmd.CommandText = "SELECT * FROM Login WHERE ID_Login = '" + comboBox1.Text + "' ";

        public void AfficheCitoyen(){
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;
            cmd.CommandText = "SELECT * FROM Citoyen";
            DataTable tbl = new DataTable();
            adapter.Fill(tbl);
            Console.WriteLine(tbl.Rows.Count);
            foreach (DataRow dataRow in tbl.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
            cnx.Close();
        }

        public void AjouterCitoyen(int idCitoyen)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;
            cmd.CommandText = "Delete Citoyen FROM Citoyen WHERE ID_Citoyen = '" + idCitoyen + "'";
            cnx.Close();
        }

        public void ModifierCitoyen(int idCitoyen, String nom)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;
            cmd.CommandText = "UPDATE Login SET Nom = '" + nom + "',  WHERE ID_Login = '" + idCitoyen + "'";;
            cnx.Close();
        }

        public void SupprimerCitoyen(int idCitoyen)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;
            cmd.CommandText = "DELET Citoyen FROM Citoyen WHERE ID_Citoyen = '" + idCitoyen + "'";
            cnx.Close();
        }

        public void ChangeColor(int idCitoyen, int resultatTest)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;

            if (resultatTest == 0)
                cmd.CommandText = "UPDATE Citoyen SET Couleur = 'Green'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            if (resultatTest == 1)
                cmd.CommandText = "UPDATE Citoyen SET Couleur = 'Red'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            cnx.Close();
        }

        public void ChangeStatutCitoyen(int idCitoyen, int resultatControl)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;

            if (resultatControl == 0)
                cmd.CommandText = "UPDATE Citoyen SET statutCitoyen = 'Recovered'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            if (resultatControl == 1)
                cmd.CommandText = "UPDATE Citoyen SET statutCitoyen = 'Died'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            if (resultatControl == 2)
                cmd.CommandText = "UPDATE Citoyen SET statutCitoyen = 'Sick'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            cnx.Close();
        }

        public void ChangeEtatCitoyen(int idCitoyen, int degree)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;

            if (degree == 0)
                cmd.CommandText = "UPDATE Citoyen SET EtatCitoyen = 'Hospitaliser'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            if (degree == 1)
                cmd.CommandText = "UPDATE Citoyen SET EtatCitoyen = 'Confiner'  WHERE ID_Citoyen = '" + idCitoyen + "'";

            cnx.Close();
        }

        public void ChangeEtatVaccination(int idCitoyen)
        {
            cnx.Open();
            chaine = ConfigurationManager.ConnectionStrings["covid19"].ConnectionString;
            cmd.CommandText = "UPDATE Login SET EtatVaccination = '' WHERE ID_Login = '" + idCitoyen + "'"; ;
            cnx.Close();
        }
    }
}
