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
        private String couleur; // Orang - Green - Red
        private String statutCitoyen; // Recovered - Died - Sick
        private String etatCitoyen; // Hospitaliser - Confiner
        private String etatHospitalier; // Reanimation - Intubation
        private String traitement;
        private String etatVaccination; // Stable - Contagieux
        private String profilePatient; // Ager - Maladie chronique

        public Citoyen(int idCitoyen, String nom, String adresse, String couleur, String statutCitoyen, String etatCitoyen, String etatHospitalier, String etatVaccination, String traitement, String profilePatient)
        {
            this.idCitoyen = idCitoyen;
            this.nom = nom;
            this.adresse = adresse;
            this.couleur = couleur;
            this.statutCitoyen = statutCitoyen;
            this.etatCitoyen = etatCitoyen;
            this.etatHospitalier = etatHospitalier;
            this.etatVaccination = etatVaccination;
            this.traitement = traitement;
            this.profilePatient = profilePatient;
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

        public void setEtatCitoyen(String etatCitoyen)
        {
            this.etatCitoyen = etatCitoyen;
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

        public void setProfilePatient(String profilePatient)
        {
            this.profilePatient = profilePatient;
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

        public String getEtatCitoyen()
        {
            return etatCitoyen;
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

        public String getProfilePatient()
        {
            return profilePatient;
        }
    }
}
