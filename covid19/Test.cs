using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid19
{
    class Test
    {
        private int idTest;
        private int resultatTest;
        private String decisionTest;

        public Test()
        {

        }

        public Test(int idTest, int resultatTest, String decisionTest)
        {
            this.idTest = idTest;
            this.resultatTest = resultatTest;
            this.decisionTest = decisionTest;
        }

        /********** ********** ********** ********** ********** ********** Setters ********** ********** ********** ********** ********** **********/

        public void setIdTest(int idTest)
        {
            this.idTest = idTest;
        }

        public void setResultatTest(int resultatTest)
        {
            this.resultatTest = resultatTest;
        }

        public void setDecisionTest(String decisionTest)
        {
            this.decisionTest = decisionTest;
        }

        /********** ********** ********** ********** ********** ********** Getters ********** ********** ********** ********** ********** **********/

        public int getIdTest()
        {
            return idTest;
        }

        public int getResultatTest()
        {
            return resultatTest;
        }

        public String getDecisionTest()
        {
            return decisionTest;
        }

        /********** ********** ********** ********** ********** ********** Functions ********** ********** ********** ********** ********** **********/
        public String DegreeTest()
        {
            Random random = new Random();
            int resultat;
            resultat = random.Next(2);


            if (resultat == 0)
                // Degree < 41
                return "Grave";

            // Positive
            return "PGrave";
        }

        public String PCR()
        {
            Random random = new Random();
            int resultat;

            resultat = random.Next(2);

            if (resultat == 0)
                // Negative
                return "Negative";

            // Positive
            return "Positive";
        }

        public String DecisionColor()
        {
            Random random = new Random();
            int resultat;

            resultat = random.Next(3);

            if (resultat == 0)
                // Orange
                return "Orange";

            if (resultat == 1)
                // Red
                return "Red";

            // Green
            return "Green";
        }

        public String DecisionEtat(String color)
        {
            if (color == "Orange")
                // Confiner
                return "Confiner";

            if (color == "Red")
                // Hospitaliser
                return "Hospitaliser";

            return "Normal";
        }

        public String Retest()
        {
            String resultat = DegreeTest();

            if (resultat == "Pas Grave")
                return "Confiner";

            return "Hospitaliser";
        }
    }
}