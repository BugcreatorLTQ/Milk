using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class 奶牛 : Form
    {
        public 奶牛()
        {
            InitializeComponent();
        }

        private void toolboxControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string[] x = new string[7];
            x[0] = textX1.Text;
            x[1] = textX2.Text;
            x[2] = textX3.Text;
            x[3] = textX4.Text;
            x[4] = textX5.Text;
            x[5] = textX6.Text;
            x[6] = textX7.Text;
            double[] p = new double[7];
            for(int i = 0; i < 7; i++)
            {
                bool sign = true;
                bool dian = true;
                double p1 = 0;
                double p2 = 0;
                for (int j = 0; j < x[i].Length; i++)
                {
                    if (x[i][j] == '-')
                    {
                        sign = false;
                        continue;
                    }
                    if (x[i][j] == '.')
                    {
                        dian = false;
                        continue;
                    }
                    if (dian)
                        p1 = p1 * 10 + (x[i][j] - 48);
                    else
                        p2 = p2 * 10 + (x[i][j] - 48);
                }
                while (p2 > 0)
                {
                    p2 /= 10.0;
                }
                p[i] = p1 + p2;
                if (!sign)
                {
                    p[i] = -1 * p[i];
                }
            }
            double[,] w1 = new double[,] { {0.9880,-0.2664,-0.9157,0.0206,-0.5388,-0.7711,2.4399},
                                           {3.0299,2.1328,-1.6592,-0.5420,-0.1957,1.4950,-0.2351},
                                           {-2.8242,2.6297,1.6262,-3.7558,1.1221,1.9047,2.1435},
                                           {3.8358,-1.2815,1.8033,0.2173,0.5450,-2.7295,-3.7851},
                                           {-0.5137,-0.1522,3.0859,0.1586,-6.1599,0.7128,1.6133},
                                           {0.3668,-0.3663,-0.2006,0.1504,-0.4197,-0.6369,-0.3798},
                                           {-1.2396,1.1114,0.4639,0.8995,-2.2354,2.4909,0.6542},
                                           {4.7464,0.7321,1.5942,1.3091,0.6082,-0.7496,-3.0977},
                                           {2.0095,-5.0792,1.1592,-0.1637,-1.4920,-3.2722,-2.0191},
                                           {1.2481,0.4926,-2.2905,-0.7976,1.1347,-3.1781,0.2924} };
            double[,] w2 = new double[,]
            {
                {0.2839,-0.0415,-0.0610,-0.0189,0.0318,-0.5605,-0.2420,-0.0263,-0.0570,-0.2513},
                {0.1385,-0.0078,-0.5801,-0.3353,0.3067,0.5083,-0.3445,0.0714,-0.9692,0.3039},
                {0.6209,-0.5184,0.5453,0.0099,-0.2395,0.4752,0.3390,0.5302,-0.1696,-0.2205}
            };
            double[] b1 = { -0.3649, -2.5300, 2.9763, -0.1933, 0.1751, -0.1076, -0.9749, 3.1512, 4.2182, 0.5964 };
            double[] b2 = { 0.0237, 1.3018, -0.0672 };
            double [] y1 = new double [10];
            double [] y2 = new double [3];
			for(int i = 0; i<10;i++){
				y1[i]=0;
				for(int j = 0; j<7;j++)
					y1[i]+=w1[i,j]*p[j];
				y1[i]+=b1[i];
				y1[i]=1/(1+System.Math.Exp(-y1[i]));
			}
			for(int i = 0; i<3;i++){
				y2[i]=0;
				for(int j = 0; j<10;j++){	
					y2[i]+=w2[i,j]* y1[j];
				}
                y2[i]+=b2[i];
			}
            textY1.Text = y2[0].ToString();
            textY1.Text = y2[1].ToString();
            textY3.Text = y2[2].ToString();
        }
    }
}
