using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIDCOM_Tax
{
    namespace MIDCOM
    {
        public class TaxEntry
        {
            public char   taxType     = '$';    // % - Percent / $ - Per Litre       
            public short  taxRate     = 000000; // XX.XXXX
            public char   compoundTax = 'N';
            public string label       = "|             |";

            public string TaxRate
            {
                get 
                {
                    return this.taxType + this.taxRate.ToString("D6") + this.compoundTax;
                }
            }
        
            public string Label
            {
                get
                {
                    return label.Substring(0, 15);
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
            public const byte TaxEntryCount = 20;
            public const byte ProductCount = 100;

            public TaxEntry[] Taxes = new TaxEntry[TaxEntryCount];          
            public Product[] Products = new Product[ProductCount];

            private string fileName;

            public string FileName 
            { 
                get
                {
                    return this.fileName;
                }
                
                set
                {
                    var docFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    this.fileName = Path.Combine(docFolder, "MIDCOM Tax Files", value);
                }
            }

            public string DAT
            {
                get
                {
                    StringBuilder output = new();

                    // Tax Rates '$000000N' * 20
                    foreach (var t in Taxes)
                    {
                        output.AppendLine(t.TaxRate);
                    }

                    // Labels * 20
                    foreach (var t in Taxes)
                    {
                        output.AppendLine(t.Label);
                    }

                    // Combinations * 100
                    foreach (var p in Products)
                    {
                        output.AppendLine(p.TaxCode);
                    }

                    return output.ToString();
                }
            }

            public string STR
            {
                get
                {
                    StringBuilder output = new();

                    // BLOCK 0 - 512
                    // First char must be a 'T'.
                    output.Append("TAX CARD FOR MIDCOM 8000. CREATED BY ZACH MASSIA.");

                    // Pad the remaining chars of first 512 char block.
                    output.Append('+', 510 - output.Length);     
                    output.Append(Environment.NewLine);

                    // Add the 20 tax rates, no seperators or delimiters.
                    foreach (var t in Taxes)
                    {
                        output.Append(t.TaxRate);
                    }

                    // Pad remaining 352 chars.
                    output.Append('+', 350);
                    output.Append(Environment.NewLine);

                    // Add the 20 tax labels, no seperators or delimiters.
                    foreach (var t in Taxes)
                    {
                        output.Append(t.Label);
                    }

                    // Pad remaining 212 chars.
                    output.Append('+', 210);
                    output.Append(Environment.NewLine);

                    // Add the 100 tax combinations.
                    // These must be entered in multiple blocks.
                    //
                    // 12 together, no seperator, then a 32 char pad.
                    // Repeat above sequence 8 times.
                    // 
                    // Add final 4 sets with 352 char pad.

                    var productIndex = 0;
                    
                    for (var i = 0; i < 8; i++)
                    {
                        // Add the 12 combinations
                        for (var j = 0; j < 12; j++)
                        {
                            output.Append(Products[productIndex++].TaxCode);
                        }
                        // Add the 32 char pad.
                        output.Append('+', 30);
                        output.Append(Environment.NewLine);
                    }

                    // The final 4 combinations.
                    for (var i = 0; i < 4; i++)
                    {
                        output.Append(Products[productIndex++].TaxCode);
                    }
                    output.Append('+', 350);
                    output.Append(Environment.NewLine);

                    output.Append('|');
                    return output.ToString();
                }
            }

            public TaxFile()
            {
                for (var i = 0; i < this.Taxes.Length; i++)
                {
                    this.Taxes[i] = new();
                }
                for (var i = 0; i < this.Products.Length; i++)
                {
                    this.Products[i] = new();
                }
            }

            public TaxFile(string fileName) : this()
            {
                this.FileName = fileName;
            }
        }
    }
}
