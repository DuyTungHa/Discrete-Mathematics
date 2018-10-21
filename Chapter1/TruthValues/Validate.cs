using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruthValues
{
    class Validate
    {
        private bool p;
        private bool q;

        public Validate(bool p, bool q)
        {
            this.p = p;
            this.q = q;
        }

        public bool ValidateAnd()
        {
            if (p && q)
                return true;
            else
                return false;
        }

        public bool ValidateOr()
        {
            if (p || q)
                return true;
            else
                return false;
        }

        public bool ValidateXor()
        {
            if ((p && !q) || (!p && q))
                return true;
            else
                return false;

        }

        public bool ValidateImplication()
        {
            if (!p || (p && q))
                return true;
            else
                return false;
        }

        public bool ValidateIfandonlyif()
        {
            if ((p && q) || (!p && !q))
                return true;
            else
                return false;
        }
    }
}
