using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19
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

        private int PassTest()
        {
            /*
             * 0 = Negative
             * 1 = Positive
             */
            Random resultat = new Random();
            return resultat.Next(2);
        }

        private String DegreeTest()
        {
            int resultat = PassTest();

            if (resultat == 0)
                // Degree < 41
                return "Pas Grave";

            // Positive
            return "Grave";
        }

        public String PCR()
        {
            int resultat = PassTest();

            if (resultat == 0)
                // Negative
                return "Green";

            // Positive
            return "Red";
        }

        public String DecisionTest()
        {
            String resultatTest = DegreeTest();

            if (resultatTest == "Grave")
                // Hospitaliser
                return "Hospitaliser";

            // Confiner
            return "Confiner";
        }
    }
}
