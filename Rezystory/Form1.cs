using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezystory
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        double third;
        double fourth;
        double res;
        double val;
        double tol;
        

        public Form1()
        {
            InitializeComponent();
            this.first = first; // wartość odczytywana z pierwszego paska
            this.second = second; // wartość odczytywana z drugiego paska
            this.third = third; // wartosć paska trzeciego wskazująca na mnożnik
            this.fourth = fourth; // wartosc paska czwartego będąca tolerancją +- (w tej zmiennej nie wyrażona w procentach) 
            this.res = res; // mnożnik
            this.val = val; //wartość liczbowa wyrażana przez dwa pierwsze paski
            this.tol = tol; // tolerancja
            


            

        }

        




        
        private void colorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (colorBox.SelectedIndex)
            {
                case 0:
                    panel1.BackColor = Color.Black;
                    val = 0;
                    res = 1;
                    
                    break;
                case 1:
                    panel1.BackColor = Color.Brown;
                    val = 10;
                    res = 10;
                    tol = 0.01;
                    break;
                case 2:
                    panel1.BackColor = Color.Red;
                    val = 20;
                    res = 100;
                    tol = 0.02;
                    break;
                case 3:
                    panel1.BackColor = Color.Orange;
                    val = 30;
                    res = 1000;
                    tol = 0;
                    break;
                case 4:
                    panel1.BackColor = Color.Yellow;
                    val = 40;
                    res = 10000;
                    tol = 0;
                    break;
                case 5:
                    panel1.BackColor = Color.Green;
                    val = 50;
                    res = 100000;
                    tol = 0.005;
                    break;
                case 6:
                    panel1.BackColor = Color.Blue;
                    val = 60;
                    res = 1000000;
                    tol = 0.0025;
                    break;
                case 7:
                    panel1.BackColor = Color.Violet;
                    val = 70;
                    res = 10000000;
                    tol = 0.001;
                    break;
                case 8:
                    panel1.BackColor = Color.Gray;
                    val = 80;
                    res = 0;
                    tol = 0.0005;
                    break;
                case 9:
                    panel1.BackColor = Color.AntiqueWhite;
                    val = 90;
                    res = 0;
                    tol = 0;
                    break;
                case 10:
                    panel1.BackColor = Color.Gold;
                    val = 0; // nie ma wartości w tabeli - do ustawienia
                    res = 0.1;
                    tol = 0.05;
                    break;
                case 11:
                    panel1.BackColor = Color.Silver;
                    val = 0; // nie ma wartości w tabeli - do ustawienia
                    res = 0.01;
                    tol = 0.1;
                    break;
                default:
                    break;
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butSet_Click(object sender, EventArgs e)
        {
            

            if(pan1.BackColor == Color.White)
            {
                pan1.BackColor = panel1.BackColor;
                first = val;
                

            }
            else if(pan2.BackColor == Color.White)
            {
                pan2.BackColor = panel1.BackColor;
                second = val / 10;

            }
            else if(pan3.BackColor == Color.White)
            {
                pan3.BackColor = panel1.BackColor;
                third = res;

            }else if(pan4.BackColor == Color.White)
            {
                pan4.BackColor = panel1.BackColor;
                fourth = tol;
            }
        }

        private void SetRes()
        {
            double res1 = ((first + second) *third)/1000;
            //string endRes = Convert.ToString(res1);
            label1.Text = String.Format("wartość rezystencji to: {0}kΩ, a z uwzględnieniem tolerancji {1}% daje dokładnie wartość od {2}kΩ do {3}kΩ", res1, fourth*100,res1-(res1*fourth), res1+(res1*fourth) );
        }

        private void butRes_Click(object sender, EventArgs e)
        {
            SetRes();
        }
    }
        
}
