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
    class Program
    {
        static Persistence persistence = new Persistence();
        static Control control = new Control();

        public void Run(int idCitoyen)
        {
            // String color = "Grey";
            String etatCitoyen = "Normal";
            String etatHospitalier = "Normal";
            String decisionIntubation;
            
            // persistence.ChangeColor(idCitoyen, color = test.DecisionColor());

            // persistence.ChangeEtatCitoyen(idCitoyen, etatCitoyen = test.DecisionEtat(color));

            if (etatCitoyen == "Hospitalier")
            {
                persistence.ChangeEtatHospitalier(idCitoyen, etatHospitalier = control.DecisionControl());

                // if (etatHospitalier == "Normal") persistence.ChangeEtatHospitalier(idCitoyen, etatHospitalier = control.DecisionControl());
                // confinementTime.Start();


                // if (etatHospitalier == "Reanimation") persistence.ChangeEtatHospitalier(idCitoyen, etatHospitalier = control.DecisionControl());
                // countEtatHospitalier

                if (etatHospitalier == "Intubation")
                {
                    decisionIntubation = control.Intubation();

                    if (decisionIntubation == "Died")
                        persistence.ChangeStatutCitoyen(idCitoyen, "Died");

                    if (decisionIntubation == "Normal")
                        persistence.ChangeEtatHospitalier(idCitoyen, "Normal");
                }
            }

            if (etatCitoyen == "Confiner")
            {
                //confinementTime.Start();
            }

            //MessageBox.Show(color = test.DecisionColor());

            //if (color == "Green")
            //MessageBox.Show("Color Changed to Green");
            else
            {
                //MessageBox.Show("Color Changed to " + color);

                //MessageBox.Show("etatCitoyen Changed to " + (etatCitoyen = test.DecisionEtat(color)));

                if (etatCitoyen == "Hospitaliser")
                {
                    //MessageBox.Show("etatHospitalier Changed to " + (etatHospitalier = control.DecisionControl()));

                    if (etatHospitalier == "Normal")
                    {

                    }

                    if (etatHospitalier == "Reanimation")
                    {

                    }

                    if (etatHospitalier == "Intubation")
                    {
                        decisionIntubation = control.Intubation();

                        if (decisionIntubation == "Died")
                            //MessageBox.Show("statutCitoyen Changed to Died");

                            if (decisionIntubation == "Normal") { }
                        //MessageBox.Show("etatHospitalier Changed to Died");
                    }
                }

                if (etatCitoyen == "Confiner")
                {
                    //t.Start();
                }
            }
        }

        static void Main(string[] args)
        {
            /**************************************************   mainMenu   **************************************************/
            int operation;
            /*
            int idCitoyen;
            String nom;
            String adresse;
            String couleur; // Orang - Green - Red
            String statutCitoyen; // Recovered - Died - Sick
            String etatCitoyen; // Hospitaliser - Confiner
            String etatHospitalier; // Normal - Reanimation - Intubation
            String traitement;
            String etatVaccination; // Stable - Contagieux
            String profilePatient; // Ager - Maladie chronique
            */

            Console.WriteLine("1- Afficher les Citoyens");
            Console.WriteLine("2- Afficher Citoyens");
            Console.WriteLine("3- Modifier Citoyen");
            Console.WriteLine("4- Supprimer Citoyen");
            Console.WriteLine("5- Changer Couleur");
            Console.WriteLine("6- Change Statut Citoyen");
            Console.WriteLine("7- Change Etat Citoyen");
            Console.WriteLine("8- Change Etat Hospitalier");
            Console.WriteLine("9- Change Etat Vaccination");
            Console.WriteLine("10- Ajouter Citoyen");
            

            operation = Int32.Parse(Console.ReadLine());

            if (operation == 1)
            {
                persistence.AfficheAllCitoyen();
            }

            if (operation == 2)
            {
                int idCitoyen;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                persistence.AfficheCitoyen(idCitoyen);
            }

            if (operation == 3)
            {
                int idCitoyen;
                String nom;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Nom: ");
                nom = Console.ReadLine();

                persistence.ModifierCitoyen(idCitoyen, nom);
            }

            if (operation == 4)
            {
                int idCitoyen;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                persistence.SupprimerCitoyen(idCitoyen);
            }

            if (operation == 5)
            {
                int idCitoyen;
                String couleur; // Orang - Green - Red

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Couleur: ");
                couleur = Console.ReadLine();

                persistence.ChangeColor(idCitoyen, couleur);
            }

            if (operation == 6)
            {
                int idCitoyen;
                String statutCitoyen;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Statut: ");
                statutCitoyen = Console.ReadLine();

                persistence.ChangeStatutCitoyen(idCitoyen, statutCitoyen);
            }

            if (operation == 7)
            {
                int idCitoyen;
                String etatCitoyen;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Etat: ");
                etatCitoyen = Console.ReadLine();

                persistence.ChangeEtatCitoyen(idCitoyen, etatCitoyen);
            }

            if (operation == 8)
            {
                int idCitoyen;
                String etatHospitalier;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Etat: ");
                etatHospitalier = Console.ReadLine();

                persistence.ChangeEtatHospitalier(idCitoyen, etatHospitalier);
            }

            if (operation == 9)
            {
                int idCitoyen;
                String etatVaccination;

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Etat: ");
                etatVaccination = Console.ReadLine();

                persistence.ChangeEtatVaccination(idCitoyen, etatVaccination);
            }

            if (operation == 10)
            {
                int idCitoyen;
                String nom;
                String adresse;
                String couleur; // Orang - Green - Red
                String statutCitoyen; // Recovered - Died - Sick
                String etatCitoyen; // Hospitaliser - Confiner
                String etatHospitalier; // Reanimation - Intubation
                String traitement;
                String etatVaccination; // Stable - Contagieux
                String profilePatient; // Ager - Maladie chronique

                Console.WriteLine("ID: ");
                idCitoyen = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Nom: ");
                nom = Console.ReadLine();

                Console.WriteLine("Adresse: ");
                adresse = Console.ReadLine();

                Console.WriteLine("Couleur: ");
                couleur = Console.ReadLine();

                Console.WriteLine("Statut: ");
                statutCitoyen = Console.ReadLine();

                Console.WriteLine("Etat: ");
                etatCitoyen = Console.ReadLine();

                Console.WriteLine("Etat Hospitalier: ");
                etatHospitalier = Console.ReadLine();

                Console.WriteLine("Traitement: ");
                traitement = Console.ReadLine();

                Console.WriteLine("Etat Vaccination: ");
                etatVaccination = Console.ReadLine();

                Console.WriteLine("Profile Patient: ");
                profilePatient = Console.ReadLine();

                persistence.AjouterCitoyen(idCitoyen, nom, adresse, couleur, statutCitoyen, etatCitoyen, etatHospitalier, etatVaccination, traitement, profilePatient);
            }
        }
    }
}

