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
    }
}
