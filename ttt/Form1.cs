using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //zmienna publiczna
        public int ruch = 3;

        //Tablica przechowuje informacje , czy pole jest zajete
        Boolean[] occupited = new Boolean[9];

        //tablica przechowuje informacje, ktory gracz zaja dane pole
        //1-krzyzyk, 2- kolo
        int[] ttt = new int[9];

        //Blokowanie przyciskow
        public void blockClick()
        {
            for(int i = 0; i<9; i++)
            {
                occupited[i] = true;
            }
        }

        public void spr()
        {
            if (ttt[0] == 1 && ttt[1] == 1 && ttt[2] == 1)
            {
                b1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                b3.BackColor = Color.Red;

                blockClick();
            }
            else if(ttt[3] == 1 && ttt[4] == 1 && ttt[5] == 1)
            {
                b4.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b6.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[6] == 1 && ttt[7] == 1 && ttt[8] == 1)
            {
                b7.BackColor = Color.Red;
                b8.BackColor = Color.Red;
                b9.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[0] == 1 && ttt[3] == 1 && ttt[6] == 1)
            {
                b1.BackColor = Color.Red;
                b4.BackColor = Color.Red;
                b7.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[1] == 1 && ttt[4] == 1 && ttt[7] == 1)
            {
                b2.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b8.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[2] == 1 && ttt[5] == 1 && ttt[8] == 1)
            {
                b3.BackColor = Color.Red;
                b6.BackColor = Color.Red;
                b9.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[0] == 1 && ttt[4] == 1 && ttt[8] == 1)
            {
                b1.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b9.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[2] == 1 && ttt[4] == 1 && ttt[6] == 1)
            {
                b3.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b7.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[0] == 2 && ttt[1] == 2 && ttt[2] == 2)
            {
                b1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                b3.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[3] == 2 && ttt[4] == 2 && ttt[5] == 2)
            {
                b4.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b6.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[6] == 2 && ttt[7] == 2 && ttt[8] == 2)
            {
                b7.BackColor = Color.Red;
                b8.BackColor = Color.Red;
                b9.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[0] == 2 && ttt[3] == 2 && ttt[6] == 2)
            {
                b1.BackColor = Color.Red;
                b4.BackColor = Color.Red;
                b7.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[1] == 2 && ttt[4] == 2 && ttt[7] == 2)
            {
                b2.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b8.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[2] == 2 && ttt[5] == 2 && ttt[8] == 2)
            {
                b3.BackColor = Color.Red;
                b6.BackColor = Color.Red;
                b9.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[0] == 2 && ttt[4] == 2 && ttt[8] == 2)
            {
                b1.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b9.BackColor = Color.Red;

                blockClick();
            }
            else if (ttt[2] == 2 && ttt[4] == 2 && ttt[6] == 2)
            {
                b3.BackColor = Color.Red;
                b5.BackColor = Color.Red;
                b7.BackColor = Color.Red;

                blockClick();
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if(occupited[0] == false)
            {
                if (ruch % 2 == 1)
                {
                    b1.Text = "X";
                    ttt[0] = 1;
                }
                else
                {
                    b1.Text = "O";
                    ttt[0] = 2;
                }
                occupited[0] = true;
            }
            spr();
            ruch++;
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (occupited[1] == false)
            {
                if (ruch % 2 == 1)
                {
                    b2.Text = "X";
                    ttt[1] = 1;
                }
                else
                {
                    b2.Text = "O";
                    ttt[1] = 2;
                }
                occupited[1] = true;
            }
            spr();
            ruch++;
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (occupited[2] == false)
            {
                if (ruch % 2 == 1)
                {
                    b3.Text = "X";
                    ttt[2] = 1;
                }
                else
                {
                    b3.Text = "O";
                    ttt[2] = 2;
                }
                occupited[2] = true;
            }
            spr();
            ruch++;
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (occupited[3] == false)
            {
                if (ruch % 2 == 1)
                {
                    b4.Text = "X";
                    ttt[3] = 1;
                }
                else
                {
                    b4.Text = "O";
                    ttt[3] = 2;
                }
                occupited[3] = true;
            }
            spr();
            ruch++;
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (occupited[4] == false)
            {
                if (ruch % 2 == 1)
                {
                    b5.Text = "X";
                    ttt[4] = 1;
                }
                else
                {
                    b5.Text = "O";
                    ttt[4] = 2;
                }
                occupited[4] = true;
            }
            spr();
            ruch++;
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (occupited[5] == false)
            {
                if (ruch % 2 == 1)
                {
                    b6.Text = "X";
                    ttt[5] = 1;
                }
                else
                {
                    b6.Text = "O";
                    ttt[5] = 2;
                }
                occupited[5] = true;
            }
            spr();
            ruch++;
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (occupited[6] == false)
            {
                if (ruch % 2 == 1)
                {
                    b7.Text = "X";
                    ttt[6] = 1;
                }
                else
                {
                    b7.Text = "O";
                    ttt[6] = 2;
                }
                occupited[6] = true;
            }
            spr();
            ruch++;
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (occupited[7] == false)
            {
                if (ruch % 2 == 1)
                {
                    b8.Text = "X";
                    ttt[7] = 1;
                }
                else
                {
                    b8.Text = "O";
                    ttt[7] = 2;
                }
                occupited[7] = true;
            }
            spr();
            ruch++;
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (occupited[8] == false)
            {
                if (ruch % 2 == 1)
                {
                    b9.Text = "X";
                    ttt[8] = 1;
                }
                else
                {
                    b9.Text = "O";
                    ttt[8] = 2;
                }
                occupited[8] = true;
            }
            spr();
            ruch++;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ruch = 3;
            for(int i=0; i<9; i++)
            {
                occupited[i] = false;
                ttt[i] = 0;
                b1.Text = ""; b1.BackColor = Color.White;
                b2.Text = ""; b2.BackColor = Color.White;
                b3.Text = ""; b3.BackColor = Color.White;
                b4.Text = ""; b4.BackColor = Color.White;
                b5.Text = ""; b5.BackColor = Color.White;
                b6.Text = ""; b6.BackColor = Color.White;
                b7.Text = ""; b7.BackColor = Color.White;
                b8.Text = ""; b8.BackColor = Color.White;
                b9.Text = ""; b9.BackColor = Color.White;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
