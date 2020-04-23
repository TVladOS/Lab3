using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная 3 CSharp
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void clea_r_Click(object sender, EventArgs e)
        {
            numerator1.Clear();
            numerator2.Clear(); 
            numerator3.Clear(); 
            numerator4.Clear();
            denominator1.Clear();
            denominator2.Clear();
            denominator3.Clear();
            denominator4.Clear();
            label10.Visible = r_numerator.Visible = r_denominator.Visible = label15.Visible = label11.Visible = label12.Visible =
                    label13.Visible = label14.Visible = label16.Visible = _r_numerator.Visible = _r_denominator.Visible = label22.Visible = false;
        }

        private void solute_Click(object sender, EventArgs e)
        {

            Fraction[] fractions = new Fraction[4];
            for (int i = 0; i < 4; i++)
            {

                fractions[i] = new Fraction();
            }

            if (!Int32.TryParse(numerator1.Text, out fractions[0].numerator) ||
        !Int32.TryParse(denominator1.Text, out fractions[0].denominator) ||
        !Int32.TryParse(numerator2.Text, out fractions[1].numerator) ||
        !Int32.TryParse(denominator2.Text, out fractions[1].denominator) ||
        !Int32.TryParse(numerator3.Text, out fractions[2].numerator) ||
        !Int32.TryParse(denominator3.Text, out fractions[2].denominator) ||
        !Int32.TryParse(numerator4.Text, out fractions[3].numerator) ||
        !Int32.TryParse(denominator4.Text, out fractions[3].denominator))
                MessageBox.Show("Введите данные корректно"); //Индусская проверка корректности ввода(другой не придумал)
            for (int i = 0; i < 4; i++)
            {
                if (fractions[i].CheckFraction(fractions[i].numerator, fractions[i].denominator) == true)
                { label22.Visible = true; break; }
            }
            if (fractions[3].denominator == 0 || fractions[2].denominator == 0 || fractions[1].denominator == 0 || fractions[0].denominator == 0)
            {
                MessageBox.Show("В знаменателе не должно быть 0");
                clea_r_Click(sender, e);
                
                
            }
            else
            {
                Fraction result = (fractions[0] + fractions[1]) * (fractions[2] - fractions[3]);
                result = Fraction.Reduction(result);
                r_numerator.Text = Convert.ToString(result.numerator);
                r_denominator.Text = Convert.ToString(result.denominator);
                Fraction turnOv = result;
                turnOv = Fraction.Turn_over(turnOv);
                _r_numerator.Text = Convert.ToString(turnOv.numerator);
                _r_denominator.Text = Convert.ToString(turnOv.denominator);
                label10.Visible = r_numerator.Visible = r_denominator.Visible = label15.Visible = label11.Visible = label12.Visible =
                    label13.Visible = label14.Visible = label16.Visible = _r_numerator.Visible = _r_denominator.Visible= true;
            }
        }

    }

    }

