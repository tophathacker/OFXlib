using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextOFX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            THH.Tools.OFX.OfxDocument document = new THH.Tools.OFX.OfxDocument(new FileStream(openFileDialog1.FileName, FileMode.Open));
            textBox1.Text += "Ofxheader: " + document.OfxHeader + Environment.NewLine;
            textBox1.Text += "data: " + document.Data + Environment.NewLine;
            foreach (THH.Tools.OFX.Transaction trans in document.Transactions)
            {
                textBox1.Text += trans.Name + Environment.NewLine;
            }
        }
    }
}
