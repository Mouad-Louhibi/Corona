using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        static string chaine = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\mouad\OneDrive\Documents\covid19.mdf;Integrated Security = True;Connect Timeout = 30";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        public void AfficheAllCitoyen(){
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM Citoyen";
            cmd.ExecuteNonQuery();

            DataTable tbl = new DataTable();
            adapter.Fill(tbl); // Error

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

        public void AfficheCitoyen(int idCitoyen)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT FROM Citoyen WHERE IdCitoyen = " + idCitoyen  + "";
            cmd.ExecuteNonQuery();
            DataTable tbl = new DataTable();
            adapter.Fill(tbl); // Error
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

        public void AjouterCitoyen(int idCitoyen, String nom, String adresse, String couleur, String statutCitoyen, String etatCitoyen, String etatHospitalier, String etatVaccination, String traitement, String profilePatient)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO Citoyen(IdCitoyen, Nom, Adresse, Couleur, StatutCitoyen, EtatCitoyen, EtatHospitalier, EtatVaccination, Traitement, ProfilePatient) " +
                 " VALUES('" + idCitoyen + "', '" + nom + "', '" + adresse + "', '" + couleur + "', '" + statutCitoyen + "', '" + etatCitoyen + "', '" + etatHospitalier + "', '" + etatVaccination + "', '" + traitement + "', '" + profilePatient + "')";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void ModifierCitoyen(int idCitoyen, String nom)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Citoyen SET Nom = '" + nom + "',  WHERE IdCitoyen= " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void SupprimerCitoyen(int idCitoyen)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM Citoyen WHERE IdCitoyen = " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void ChangeColor(int idCitoyen, String color)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Citoyen SET Couleur = '" + color + "' WHERE IdCitoyen = " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void ChangeStatutCitoyen(int idCitoyen, String statutCitoyen)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Citoyen SET statutCitoyen = '" + statutCitoyen  + "'  WHERE IdCitoyen = " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void ChangeEtatCitoyen(int idCitoyen, String etatCitoyen)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Citoyen SET EtatCitoyen = '" + etatCitoyen + "'  WHERE IdCitoyen = " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void ChangeEtatHospitalier(int idCitoyen, String etatHospitalier)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Citoyen SET EtatHospitalier = '" + etatHospitalier + "'  WHERE IdCitoyen = " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void ChangeEtatVaccination(int idCitoyen, String etatVaccination)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE Citoyen SET EtatVaccination = '" + etatVaccination + "' WHERE IdCitoyen = " + idCitoyen + "";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
