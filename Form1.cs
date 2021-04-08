using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MIDCOM_Tax;

namespace MIDCOM_Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var x = new MIDCOM.TaxFile("test.STR");

            using (StreamWriter outputFile = new StreamWriter(x.FileName))
            {
                outputFile.Write(x.STR);
            }


        }

    }
}
