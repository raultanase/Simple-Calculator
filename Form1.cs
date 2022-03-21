using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Operatii Op = new Operatii();
        Stiintific St = new Stiintific();

        public Form1()
        {
            InitializeComponent();
            Op.ok = true;
        }

        private void btnNr_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text == "0" || Op.ok == true)
                textDisplay.Clear();
            Op.ok = false;
            
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if (!textDisplay.Text.Contains("."))
                    textDisplay.Text += button.Text;
            }
            else
                textDisplay.Text += button.Text;
        }

        private void Operatie_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (Op.Val != 0)
            {
                button14.PerformClick();
                Op.Semn = button.Text;
                Op.Val = double.Parse(textDisplay.Text);
                label_Rez.Text = Op.Val + " " + Op.Semn;
                Op.ok = true;
            }
            else
            {
                Op.Semn = button.Text;
                Op.Val = double.Parse(textDisplay.Text);
                label_Rez.Text = Op.Val + " " + Op.Semn;
                Op.ok = true;
            }
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            switch(Op.Semn)
            {
                case "+":
                    textDisplay.Text = Op.Adunare(Op.Val, double.Parse(textDisplay.Text)).ToString();
                    break;
                case "-":
                    textDisplay.Text = Op.Scadere(Op.Val, double.Parse(textDisplay.Text)).ToString();
                    break;
                case "*":
                    textDisplay.Text = Op.Inmultire(Op.Val, double.Parse(textDisplay.Text)).ToString();
                    break;
                case "/":
                    textDisplay.Text = Op.Impartire(Op.Val, double.Parse(textDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
            Op.ok = true;
            Op.Val = 0;
            label_Rez.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            Op.Val = 0;
            label_Rez.ResetText();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "0";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            int l = textDisplay.TextLength - 1;
            string t = textDisplay.Text;
            textDisplay.Clear();
            for (int i = 0; i < l; i++)
                textDisplay.Text += t[i];
        }

        private void btn_Fact(object sender, EventArgs e)
        {
            textDisplay.Text = St.Factorial(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Patrat(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnInvers_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Inverse(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnPowOf10_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.PowerOf10(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Radical(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Sinus(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Cosinus(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Tangenta(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnCub_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Cub(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.Log10(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnRadOrd3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.RadicalOrdin3(double.Parse(textDisplay.Text)).ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            textDisplay.Text = St.LogNat(double.Parse(textDisplay.Text)).ToString();
        }
    }
}
