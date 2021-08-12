using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verificadorcpfform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificar_Click(object sender, EventArgs e)
        {
            verificador a = new verificador();
            mskedTxtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string cepefe = mskedTxtCpf.Text;
            txtConfirmador.Text = a.Verifica(cepefe);
        }
    }
}
