using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19
{
    class Citoyen
    {
        private int idCitoyen;
        private String nom;
        private String adresse;
        private String couleur;
        private String statutCitoyen;
        private String etatHospitalier;
        private String traitement;
        private String etatVaccination;

        public Citoyen(int idCitoyen, String nom, String adresse, String couleur, String statutCitoyen, String etatHospitalier, String etatVaccination, String traitement)
        {
            this.idCitoyen = idCitoyen;
            this.nom = nom;
            this.adresse = adresse;
            this.couleur = couleur;
            this.statutCitoyen = statutCitoyen;
            this.etatHospitalier = etatHospitalier;
            this.etatVaccination = etatVaccination;
            this.traitement = traitement;
        }

        public void setIdCitoyen(int idCitoyen)
        {
            this.idCitoyen = idCitoyen;
        }

        public void setNom(String nom)
        {
            this.nom = nom;
        }

        public void setAdresse(String adresse)
        {
            this.adresse = adresse;
        }

        public void setCouleur(String couleur)
        {
            this.couleur = couleur;
        }

        public void setStatutCitoyen(String statutCitoyen)
        {
            this.statutCitoyen = statutCitoyen;
        }

        public void setEtatHospitalier(String etatHospitalier)
        {
            this.etatHospitalier = etatHospitalier;
        }

        public void setTraitement(String traitement)
        {
            this.traitement = traitement;
        }

        public void setEtatVaccination(String etatVaccination)
        {
            this.etatVaccination = etatVaccination;
        }
    
        public int getId()
        {
            return idCitoyen;
        }

        public String getNom()
        {
            return nom;
        }

        public String getAdresse()
        {
            return adresse;
        }

        public String getCouleur()
        {
            return couleur;
        }

        public String getStatutCitoyen()
        {
            return statutCitoyen;
        }

        public String getEtatHospitalier()
        {
            return etatHospitalier;
        }

        public String getTraitement()
        {
            return traitement;
        }

        public String getEtatVaccination()
        {
            return etatVaccination;
        }
    
        public int Test()
        {
            Random resultat = new Random();
            return resultat.Next(2);
        }

        public int Control()
        {
            Random resultat = new Random();
            return resultat.Next(3);
        }

        public int Degree()
        {
            Random resultat = new Random();
            return resultat.Next(2);
        }
    }
}
