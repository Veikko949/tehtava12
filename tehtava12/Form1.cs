using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tehtava12
{
    public partial class Form1 : Form
    {
        string[] oikeatVastaukser = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        int laskuri = 0;
        int oikein = 0;

        public Form1()
        {
            InitializeComponent();
            A_radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            B_radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            C_radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            D_radioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButto = (RadioButton)sender;
                vastaukset[laskuri] = radioButto.Text;
                laskuri++;
                kysymys_label.Text = "Vastaus" + (laskuri) + ". kysymykseen";
            }
            else
            {
                vastaus_label.Text = "";
                A_radioButton.Enabled = false;
                B_radioButton.Enabled = false;
                C_radioButton.Enabled = false;
                D_radioButton.Enabled = false;
                for(int j = 0; j < 10; j++)
                {
                    if(vastaukset[j] == oikeatVastaukser[j])
                    {
                        oikein++;
                    }
                }
                vastaus_label.Text = "Oikeita vastauksia oli " + oikein;
                vastaus_label.Visible = true;
            }
            TyhjaaVastaus();
            }

        private void TyhjaaVastaus()
        {
            if(A_radioButton.Checked == true)
            {
                A_radioButton.Checked = false;
                laskuri--;
            }
            if (B_radioButton.Checked == true)
            {
                B_radioButton.Checked = false;
                laskuri--;
            }
            if (C_radioButton.Checked == true)
            {
                C_radioButton.Checked = false;
                laskuri--;
            }
            if (D_radioButton.Checked == true)
            {
                D_radioButton.Checked = false;
                laskuri--;
            }
        }

        
    }
}
