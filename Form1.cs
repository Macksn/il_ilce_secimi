using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace combobax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.Text == "HATAY")
            {

                comboBox2.Items.Add("İSKENDURUN");
                comboBox2.Items.Add("ERZİN ");
                comboBox2.Items.Add("DÖRTYOL");
                comboBox2.Items.Add("AJBUGDCU");
                comboBox2.Items.Add("BNABHIBC");
            }


            if (comboBox1.Text == "ORDU")
            {

                comboBox2.Items.Add("ÜNYE");
                comboBox2.Items.Add("İKİZCE");
                comboBox2.Items.Add("KORGAN");
                comboBox2.Items.Add("PERŞEMBE");
                comboBox2.Items.Add("KARLITEPE");
            }
            if (comboBox1.Text == "İSTANBUL")
            {

                comboBox2.Items.Add("KÜÇÜKÇEKMECE");
                comboBox2.Items.Add("SEFAKÖY ");
                comboBox2.Items.Add("YENİBOSNA");
                comboBox2.Items.Add("DUDULU");
                comboBox2.Items.Add("BAYRAMPAŞA");
            }
            if (comboBox1.Text == "GÜMÜŞHANE")
            {

                comboBox2.Items.Add("KERKİL");
                comboBox2.Items.Add("KÖSELE");
                comboBox2.Items.Add("GADY8Y8");
                comboBox2.Items.Add("SENDILLİ");
                comboBox2.Items.Add("ZUBALA");
            }












        
            }   
        }
    }

