using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_Miejsc_Zerowych
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int a = (int)aInput.Value;
            int b = (int)bInput.Value;
            int c = (int)cInput.Value;

            int delta = b * b - 4 * a * c;

            if (a == 0 || b == 0 || c == 0)
            {
                outcomeLabel.Text = "Błąd podane wartości są błędne.";
            }
            else
            {
                if (delta > 0)
                {
                    double firstX = (-b + Math.Sqrt(delta)) / 2 * a;
                    double secondX = (-b - Math.Sqrt(delta)) / 2 * a;

                    functionLabel.Text = "Funkcja f(x) = " + a.ToString() + "x² + " + b.ToString() + "x + " + c.ToString() + ".";
                    outcomeLabel.Text = "Posiada dwa miejsca zerowe: x1 = " + Math.Round(firstX, 2).ToString() + " oraz x2 = " + Math.Round(secondX, 2).ToString() + ".";

                    if (a < 0)
                    {
                        intervalLabel.Text = "f(x) > 0 <=> x ∈ (" + Math.Round(firstX, 2).ToString() + ", " + Math.Round(secondX, 2).ToString() + "). f(x) < 0 <=> x ∈ (-∞, " + Math.Round(firstX, 2).ToString() + ") ∪ (" + Math.Round(secondX, 2).ToString() + ", +∞).";
                        functionPictureBox.Image = Properties.Resources.firstTwoX;
                    }
                    else if (a > 0)
                    {
                        intervalLabel.Text = "f(x) > 0 <=> x ∈ (-∞, " + Math.Round(secondX, 2).ToString() + ") ∪ (" + Math.Round(firstX, 2).ToString() + ", +∞). f(x) < 0 <=> x ∈ (" + Math.Round(secondX, 2).ToString() + ", " + Math.Round(firstX, 2).ToString() + ").";
                        functionPictureBox.Image = Properties.Resources.secondTwoX;
                    }
                }
                else if (delta == 0)
                {
                    int x = -b / 2 * a;
                    functionLabel.Text = "Funkcja f(x) = " + a.ToString() + "x² + " + b.ToString() + "x + " + c.ToString() + ".";
                    outcomeLabel.Text = "Posiada jedno miejsce zerowe: x0 = " + x.ToString() + ".";

                    if (a < 0)
                    {
                        intervalLabel.Text = "f(x) ≤ 0 <=> x ∈ R";
                        functionPictureBox.Image = Properties.Resources.firstOneX;
                    }
                    else if (a > 0)
                    {
                        intervalLabel.Text = "f(x) ≥ 0 <=> x ∈ R";
                        functionPictureBox.Image = Properties.Resources.secondOneX;
                    }
                }
                else if (delta < 0)
                {
                    functionLabel.Text = "Funkcja f(x) = " + a.ToString() + "x² + " + b.ToString() + "x + " + c.ToString() + ".";
                    outcomeLabel.Text = "Nie posiada miejsc zerowych.";

                    if (a < 0)
                    {
                        intervalLabel.Text = "f(x) < 0 <=> x ∈ R";
                        functionPictureBox.Image = Properties.Resources.firstNoX;
                    }
                    else if (a > 0)
                    {
                        intervalLabel.Text = "f(x) > 0 <=> x ∈ R";
                        functionPictureBox.Image = Properties.Resources.secondNoX;
                    }
                }
            }

            
        }
    }
}
