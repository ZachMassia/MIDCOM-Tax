using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDCOM_Tax
{
    namespace MIDCOM
    {
        public enum TaxType { Percent, PerLitre };

        public class TaxEntry
        {
            public const byte LabelLenght = 15;

            public TaxType taxType;        
            public short taxRate;
            public bool compoundTax;
            public string label;

            public string TaxRate
            {
                get 
                {
                    StringBuilder tax = new(8);

                    // Add the tax type character.
                    switch (this.taxType)
                    {
                        case TaxType.Percent:
                            tax.Append('%');
                            break;
                        case TaxType.PerLitre:
                            tax.Append('$');
                            break;
                    }

                    // Add the tax rate.
                    tax.Append(this.taxRate.ToString("D6"));

                    // Add the tax modifier.
                    if (this.compoundTax)
                    {
                        tax.Append('Y');
                    }
                    else
                    {
                        tax.Append('N');
                    }

                    return tax.ToString();
                }
            }
        
            public string Label
            {
                get
                {
                    return label.Substring(0, LabelLenght);
                }
            }
        }

        public class Product
        {
            public const byte MaxTaxCount = 20;

            public byte[] taxes = new byte[MaxTaxCount];

            public string TaxCode
            {
                get
                {
                    StringBuilder tax = new(MaxTaxCount * 2); // 2 digits per tax rate. 

                    foreach (byte t in taxes)
                    {
                        tax.Append(t.ToString("D2"));
                    }
                    return tax.ToString();
                }
            }
        }
    
        public class TaxFile
        {

        }
    }
}
