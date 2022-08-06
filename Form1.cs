using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Input;

namespace NumberToText
{
    public partial class Form1 : Form
    {
        readonly Algo NTT = new Algo();
        private string Lan = "es";

        public Form1()
        {
            InitializeComponent();
        }

        private PreviewKeyDownEventHandler tb_KeyDown()
        {
            throw new NotImplementedException();
        }

        private void RbEsp_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Numeros a palabras";
            Lan = "es";
            lblNro.Text = "Número #";
            btnTransc.Text = "&Transcribir";
            ToText();
        }

        private void RbEng_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Numbers to words";
            Lan = "en";
            lblNro.Text = "Number #";
            btnTransc.Text = "&Transcribe";
            ToText();
        }

        private void ToText()
        {
            if (double.TryParse(tbNro.Value.ToString(), out double d))
                tbText.Text = NTT.Numero_a_Texto(d, Lan);
        }

        private void TbNro_ValueChanged(object sender, EventArgs e)
        {
            ToText();
        }
        
        private void BtnTransc_Click(object sender, EventArgs e)
        {
            ToText();
        }
    }
}
