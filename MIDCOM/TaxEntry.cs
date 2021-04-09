using System;
using System.Linq;

namespace MIDCOM_Tax
{
    namespace MIDCOM
    {
        public class TaxEntry
        {
            private int id;
            private char   taxType     = '$';    // % - Percent / $ - Per Litre       
            private int    taxRate     = 000000; // XX.XXXX
            private char   compoundTax = 'N';
            private string label       = "|             |";

            public TaxEntry(int _id)
            {
                id = _id;
            }

            public int ID
            {
                get
                {
                    return id;
                }
            }
            public string Label
            {
                set
                {
                    label = new String(value.Take(15).ToArray());
                }
                get
                {
                    return new String(label.Take(15).ToArray());
                }
            }

            public string TaxRate
            {
                get 
                {
                    return this.taxType + this.taxRate.ToString("D6") + this.compoundTax;
                }
            }        

            public char TaxType
            {
                set 
                {
                    if (value == '$' || value == '%')
                    {
                        taxType = value;
                    }                   
                }
                get
                {
                    return taxType;
                }
            }
            public char CompoundTax
            {
                set
                {
                    if (value == 'Y' || value == 'N')
                    {
                        compoundTax = value;
                    }
                }

                get
                {
                    return compoundTax;
                }
            }

            public int TaxRateDecimal
            {
                set
                {
                    taxRate = value;
                }
                get
                {
                    return taxRate;
                }
            }

            

        }
    }
}
