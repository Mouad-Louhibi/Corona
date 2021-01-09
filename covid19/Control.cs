using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covid19
{
    class Control
    {
        private int idControl;
        private int resultatControl;
        private String decisionControl;

        public Control()
        {

        }

        public Control(int idControl, int resultatControl, String decisionControl)
        {
            this.idControl = idControl;
            this.resultatControl = resultatControl;
            this.decisionControl = decisionControl;
        }

        public void setIdControl(int idControl)
        {
            this.idControl = idControl;
        }

        public void setResultatControl(int resultatControl)
        {
            this.resultatControl = resultatControl;
        }

        public void setDecisionControl(String decisionControl)
        {
            this.decisionControl = decisionControl;
        }

        public int getIdControl()
        {
            return idControl;
        }

        public int getResultatControl()
        {
            return resultatControl;
        }

        public String getDecisionControl()
        {
            return decisionControl;
        }

        private int PassControl()
        {
            /*
             * 0 = Normal
             * 1 = Reanimation
             * 2 = Intubation
             */
            Random resultat = new Random();
            return resultat.Next(3);
        }

        private int PassIntubation()
        {
            /*
             * 0 = Normal
             * 1 = Died
             */
            Random resultat = new Random();
            return resultat.Next(2);
        }

        public String DecisionControl()
        {
            int resultat = PassControl();

            if (resultat == 0)
                // Normal
                return "Normal";

            if (resultat == 1)
                // Reanimation
                return "Reanimation";

            // Positive
            return "Intubation";
        }

        public String Intubation()
        {
            int resultat = PassIntubation();

            if (resultat == 0)
                // Normal
                return "Normal";

            // Died
            return "Died";
        }
    }
}
