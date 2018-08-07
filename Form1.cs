using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asul_de_pica
{
    public partial class Form1 : Form
    {
        int start = 1,placement,level=0,index,aux,timer=0,layer;
        int[] card=new int[3];
        int[] avanable = new int[3];
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (start == 1)
            {
                pictureBox1.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                Restart.Visible = true;
                level = 0;
                layer = 1;
                C1.Image = Properties.Resources.Fund;
                C3.Image = Properties.Resources.Fund;
                C2.Image = Properties.Resources.Fund;
                avanable[0] = 0;
                avanable[1] = 0;
                avanable[2] = 0;
                C1.Visible = true;
                C1.Enabled = true;
                C2.Visible = true;
                C2.Enabled = true;
                C3.Visible = true;
                C3.Enabled = true;
                placement = rand.Next(1, 7);
                if (placement == 1)
                {
                    card[0] = 1;
                    card[1] = 2;
                    card[2] = 3;
                }
                if (placement == 2)
                {
                    card[0] = 2;
                    card[1] = 1;
                    card[2] = 3;
                }
                if (placement == 3)
                {
                    card[0] = 1;
                    card[1] = 3;
                    card[2] = 2;
                }
                if (placement == 4)
                {
                    card[0] = 3;
                    card[1] = 2;
                    card[2] = 1;
                }
                if (placement == 5)
                {
                    card[0] = 3;
                    card[1] = 1;
                    card[2] = 2;
                }
                if (placement == 6)
                {
                    card[0] = 2;
                    card[1] = 3;
                    card[2] = 1;
                }
                AsWatch.Enabled = true;
                start = 0;
            }
        }

        private void AsWatch_Tick(object sender, EventArgs e)
        {
            avanable[0] = 0;
            avanable[1] = 0;
            avanable[2] = 0;
            if (card[0] == 2)
            {
                C1.Image = Properties.Resources.As_f;
            }
            if (card[1] == 2)
            {
                C2.Image = Properties.Resources.As_f;
            }
            if (card[2] == 2)
            {
                C3.Image = Properties.Resources.As_f;
            }
            AsWatch.Enabled = false;
            SecondAS.Enabled = true;
        }

        private void SecondAS_Tick(object sender, EventArgs e)
        {
            level++;
            if (level < 11)
            {
                layer = level;
            }
            if (level > 10 && level < 21)
            {
                layer = 12;
            }
            if (level > 20 && level < 31)
            {
                layer = 16;
            }
            if (level > 30)
            {
                layer = 19;
            }
            index = 0;
            C1.Image = Properties.Resources.Fund;
            C2.Image = Properties.Resources.Fund;
            C3.Image = Properties.Resources.Fund;
            timer = 0;
            if (level < 11)
            {
                CardFlip.Enabled = true;
            }
            if (level > 10 && level < 21)
            {
                CF2.Enabled = true;
            }
            if (level > 20 && level < 31)
            {
                CF3.Enabled = true;
            }
            if (level > 30)
            {
                CfEnd.Enabled = true;
            }

            SecondAS.Enabled = false;
        }

        private void CardFlip_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer % 2 == 1)
            {
                index++;
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
                if (index > layer)
                {
                    CardFlip.Enabled = false;
                    avanable[0] = 1;
                    avanable[1] = 1;
                    avanable[2] = 1;
                }
                else
                {
                    placement = rand.Next(1, 7);
                    if (placement == 1)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;
                    }
                    if (placement == 2)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 3)
                    {
                        ArrowUpLong.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 4)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;

                    }
                    if (placement == 5)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 6)
                    {
                        ArrowUpLong.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }

                }
            }
            else
            {
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
            }
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (avanable[0] == 1)
            {
                if (card[0] == 2)
                {
                    AsWatch.Enabled = true;
                }
                else
                {
                    if (card[0] == 1)
                    {
                        C1.Image = Properties.Resources.J_t;
                    }
                    if (card[0] == 3)
                    {
                        C1.Image = Properties.Resources.K_i;
                    }
                    END.Enabled = true;
                    
                }
            }
        }

        private void END_Tick(object sender, EventArgs e)
        {
            label3.Visible = true;
            C1.Image = Properties.Resources.Fund;
            C3.Image = Properties.Resources.Fund;
            C2.Image = Properties.Resources.Fund;
            C1.Visible = false;
            C1.Enabled = false;
            C2.Visible = false;
            C2.Enabled = false;
            C3.Visible = false;
            C3.Enabled = false;
            ArrowDownLong.Visible = false;
            ArrowDownShort.Visible = false;
            ArrowUpLong.Visible = false;
            ArrowUpShort.Visible = false;
            if (level < 6)
            {
                label3.Text = "Doar atat poti?";
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.BadCat;
            }
            if (level < 11 && level > 5)
            {
                label3.Text = "Se poate mult mai bine....";
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.PrettyGood;
            }
            if (level < 16 && level > 10)
            {
                label3.Text = "Destul de bine...";
                pictureBox1.Image = Properties.Resources.PrettyGood;
                pictureBox1.Visible = true;
            }
            if (level < 21 && level > 15)
            {
                label3.Text = "Esti foarte atent!";
                pictureBox1.Image = Properties.Resources.Good;
                pictureBox1.Visible = true;
            }
            if (level < 26 && level > 20)
            {
                label3.Text = "Se pare ca ai talent!";
                pictureBox1.Image = Properties.Resources.Good;
                pictureBox1.Visible = true;
            }
            if (level < 31 && level > 25)
            {
                label3.Text = "Aproape la fel de bun ca Issac Newton!";
                pictureBox1.Image = Properties.Resources.Issac;
                pictureBox1.Visible = true;
            }
            if (level < 36 && level > 30)
            {
                label3.Text = "Issac Newton nu e nimic pe langa tine!";
                pictureBox1.Image = Properties.Resources.AppleNewton;
                pictureBox1.Visible = true;
            }
            if (level < 41 && level > 35)
            {
                label3.Text = "Aproape la fel de bun ca Albert Einstein!";
                pictureBox1.Image = Properties.Resources.BabyEinstein;
                pictureBox1.Visible = true;
            }
            if (level < 46 && level > 40)
            {
                label3.Text = "Esti un nou Einstein!";
                pictureBox1.Image = Properties.Resources.AlmostEinstein;
                pictureBox1.Visible = true;
            }
            if (level > 45)
            {
                label3.Text = "Esti un geniu!";
                pictureBox1.Image = Properties.Resources.Genius;
                pictureBox1.Visible = true;
            }
            END.Enabled = false;
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (avanable[1] == 1)
            {
                if (card[1] == 2)
                {
                    AsWatch.Enabled = true;
                }
                else
                {
                    if (card[1] == 1)
                    {
                        C2.Image = Properties.Resources.J_t;
                    }
                    if (card[1] == 3)
                    {
                        C2.Image = Properties.Resources.K_i;
                    }
                    END.Enabled = true;

                }
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (avanable[2] == 1)
            {
                if (card[2] == 2)
                {
                    AsWatch.Enabled = true;
                }
                else
                {
                    if (card[2] == 1)
                    {
                        C3.Image = Properties.Resources.J_t;
                    }
                    if (card[2] == 3)
                    {
                        C3.Image = Properties.Resources.K_i;
                    }
                    END.Enabled = true;

                }
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            pictureBox1.Visible = false;
            label2.Visible = true;
            C1.Enabled = false;
            C1.Visible = false;
            C2.Enabled = false;
            C2.Visible = false;
            C3.Enabled = false;
            C3.Visible = false;
            ArrowDownLong.Visible = false;
            ArrowDownShort.Visible = false;
            ArrowUpLong.Visible = false;
            ArrowUpShort.Visible = false;
            AsWatch.Enabled = false;
            SecondAS.Enabled = false;
            END.Enabled = false;
            CardFlip.Enabled = false;
            CF2.Enabled = false;
            CF3.Enabled = false;
            CfEnd.Enabled = false;
            start = 1;
        }

        private void CF2_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer % 2 == 1)
            {
                index++;
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
                if (index > layer)
                {
                    CardFlip.Enabled = false;
                    avanable[0] = 1;
                    avanable[1] = 1;
                    avanable[2] = 1;
                }
                else
                {
                    placement = rand.Next(1, 7);
                    if (placement == 1)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;
                    }
                    if (placement == 2)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 3)
                    {
                        ArrowUpLong.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 4)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;

                    }
                    if (placement == 5)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 6)
                    {
                        ArrowUpLong.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }

                }
            }
            else
            {
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
            }
        }

        private void CF3_Tick(object sender, EventArgs e)
        {
             timer++;
            if (timer % 2 == 1)
            {
                index++;
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
                if (index > layer)
                {
                    CardFlip.Enabled = false;
                    avanable[0] = 1;
                    avanable[1] = 1;
                    avanable[2] = 1;
                }
                else
                {
                    placement = rand.Next(1, 7);
                    if (placement == 1)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;
                    }
                    if (placement == 2)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 3)
                    {
                        ArrowUpLong.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 4)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;

                    }
                    if (placement == 5)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 6)
                    {
                        ArrowUpLong.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }

                }
            }
            else
            {
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
            }
        
        }

        private void CfEnd_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer % 2 == 1)
            {
                index++;
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
                if (index > level)
                {
                    CardFlip.Enabled = false;
                    avanable[0] = 1;
                    avanable[1] = 1;
                    avanable[2] = 1;
                }
                else
                {
                    placement = rand.Next(1, 7);
                    if (placement == 1)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;
                    }
                    if (placement == 2)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 3)
                    {
                        ArrowUpLong.Image = Properties.Resources.Left_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Right_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 4)
                    {
                        ArrowUpShort.Location = new Point(88, 86);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(88, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[0];
                        card[0] = card[1];
                        card[1] = aux;

                    }
                    if (placement == 5)
                    {
                        ArrowUpShort.Location = new Point(320, 85);
                        ArrowUpShort.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpShort.Visible = true;
                        ArrowDownShort.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownShort.Location = new Point(322, 383);
                        ArrowDownShort.Visible = true;
                        aux = card[1];
                        card[1] = card[2];
                        card[2] = aux;
                    }
                    if (placement == 6)
                    {
                        ArrowUpLong.Image = Properties.Resources.Right_up_Arrow;
                        ArrowUpLong.Visible = true;
                        ArrowDownLong.Image = Properties.Resources.Leftt_down_Arrow;
                        ArrowDownLong.Visible = true;
                        aux = card[0];
                        card[0] = card[2];
                        card[2] = aux;
                    }

                }
            }
            else
            {
                ArrowDownLong.Visible = false;
                ArrowDownShort.Visible = false;
                ArrowUpLong.Visible = false;
                ArrowUpShort.Visible = false;
            }
        }
        
        

      
    }
}

