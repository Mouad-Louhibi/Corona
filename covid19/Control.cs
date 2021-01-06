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
    }
}
