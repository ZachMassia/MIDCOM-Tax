using System.Text;

namespace MIDCOM_Tax
{
    namespace MIDCOM
    {
        public class Product
        {
            private int id;
            public const byte MaxTaxCount = 20;
            

            public byte[] taxes = new byte[MaxTaxCount];

            public Product(int _id)
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
    }
}
