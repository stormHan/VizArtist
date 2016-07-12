using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LineUp
{
    public partial class LineUpForm : Form
    {
        public string[] playername = new string[36];
        public string[] image = new string[36];

        

        int cur_x = -1;
        int cur_y = -1;

        int cur_num = -1;
        changeInfo CIform;

        public LineUpForm()
        {
            InitializeComponent();

            Image i;
            playername[1] = "player";
            image[1] = "E:/Koala.jpg";
            i = Image.FromFile(image[1]);
            Pos11.BackgroundImage = i;

            playername[2] = "player";
            image[2] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            Pos21.BackgroundImage = i;

            playername[3] = "player";
            image[3] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            Pos31.BackgroundImage = i;

            playername[4] = "player";
            image[4] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            Pos41.BackgroundImage = i;

            playername[5] = "player";
            image[5] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            Pos51.BackgroundImage = i;

            playername[6] = "player";
            image[6] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos12.BackgroundImage = i;

            playername[7] = "player";
            image[7] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos22.BackgroundImage = i;

            playername[8] = "player";
            image[8] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos23.BackgroundImage = i;

            playername[9] = "player";
            image[9] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos24.BackgroundImage = i;

            playername[10] = "player";
            image[10] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos25.BackgroundImage = i;

            playername[11] = "player";
            image[11] = "E:/Koala.jpg"; 
            i = Image.FromFile(image[2]);
            pos13.BackgroundImage = i;

            playername[12] = "player";
            image[12] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos23.BackgroundImage = i;

            playername[13] = "player";
            image[13] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos33.BackgroundImage = i;

            playername[14] = "player";
            image[14] = "E:/Koala.jpg"; 
            i = Image.FromFile(image[2]);
            pos43.BackgroundImage = i;

            playername[15] = "player";
            image[15] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos53.BackgroundImage = i;

            playername[16] = "player";
            image[16] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos14.BackgroundImage = i;

            playername[17] = "player";
            image[17] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos24.BackgroundImage = i;

            playername[18] = "player";
            image[18] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos34.BackgroundImage = i;

            playername[19] = "player";
            image[19] = "E:/Koala.jpg"; ;
            i = Image.FromFile(image[2]);
            pos44.BackgroundImage = i;

            playername[20] = "player";
            image[20] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos54.BackgroundImage = i;

            playername[21] = "player";
            image[21] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos15.BackgroundImage = i;

            playername[22] = "p2";
            image[22] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos25.BackgroundImage = i;

            playername[23] = "player";
            image[23] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos35.BackgroundImage = i;

            playername[24] = "player";
            image[24] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos45.BackgroundImage = i;

            playername[25] = "player";
            image[25] = "E:/Koala.jpg";
            i = Image.FromFile(image[2]);
            pos55.BackgroundImage = i;
        }

        private void ZhukeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ZhukeCb.SelectedIndex == 0)
            {
                label1.Text = "前锋";
                label2.Text = "aaa";
                label3.Text = "中场";
                label4.Text = "后卫";
                label5.Text = "门将";
            }
            if(ZhukeCb.SelectedIndex == 1)
            {
                label5.Text = "前锋";
                label4.Text = "aaa";
                label3.Text = "中场";
                label2.Text = "后卫";
                label1.Text = "门将";
            }
        }

        private void playnb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playnb1.SelectedIndex == 0)
            {
                Pos11.Visible = false;
                Pos21.Visible = false;
                Pos31.Visible = true;
                Pos41.Visible = false;
                Pos51.Visible = false;

                label11.Visible = false;
                label21.Visible = false;
                label31.Visible = true;
                label41.Visible = false;
                label51.Visible = false;
            }
            else if (playnb1.SelectedIndex == 1)
            {
                Pos11.Visible = false;
                Pos21.Visible = true;
                Pos31.Visible = false;
                Pos41.Visible = true;
                Pos51.Visible = false;

                label11.Visible = false;
                label21.Visible = true;
                label31.Visible = false;
                label41.Visible = true;
                label51.Visible = false;

            }
            else if (playnb1.SelectedIndex == 2)
            {
                Pos11.Visible = true;
                Pos21.Visible = false;
                Pos31.Visible = true;
                Pos41.Visible = false;
                Pos51.Visible = true;

                label11.Visible = true;
                label21.Visible = false;
                label31.Visible = true;
                label41.Visible = false;
                label51.Visible = true;
            }
            else if (playnb1.SelectedIndex == 3)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = false;
                Pos41.Visible = true;
                Pos51.Visible = true;

                label11.Visible = true;
                label21.Visible = true;
                label31.Visible = false;
                label41.Visible = true;
                label51.Visible = true;
            }
            else if (playnb1.SelectedIndex == 4)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = true;
                Pos41.Visible = true;
                Pos51.Visible = true;

                label11.Visible = true;
                label21.Visible = true;
                label31.Visible = true;
                label41.Visible = true;
                label51.Visible = true;
            }
        }

        private void playnb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playnb2.SelectedIndex == 0)
            {
                pos12.Visible = false;
                pos22.Visible = false;
                pos32.Visible = true;
                pos42.Visible = false;
                pos52.Visible = false;

                label12.Visible = false;
                label22.Visible = false;
                label32.Visible = true;
                label42.Visible = false;
                label52.Visible = false;
            }
            else if (playnb2.SelectedIndex == 1)
            {
                pos12.Visible = false;
                pos22.Visible = true;
                pos32.Visible = false;
                pos42.Visible = true;
                pos52.Visible = false;

                label12.Visible = false;
                label22.Visible = true;
                label32.Visible = false;
                label42.Visible = true;
                label52.Visible = false;
            }
            else if (playnb2.SelectedIndex == 2)
            {
                pos12.Visible = true;
                pos22.Visible = false;
                pos32.Visible = true;
                pos42.Visible = false;
                pos52.Visible = true;

                label12.Visible = true;
                label22.Visible = false;
                label32.Visible = true;
                label42.Visible = false;
                label52.Visible = true;
            }
            else if (playnb2.SelectedIndex == 3)
            {
                pos12.Visible = true;
                pos22.Visible = true;
                pos32.Visible = false;
                pos42.Visible = true;
                pos52.Visible = true;

                label12.Visible = true;
                label22.Visible = true;
                label32.Visible = false;
                label42.Visible = true;
                label52.Visible = true;
            }
            else if (playnb2.SelectedIndex == 4)
            {
                pos12.Visible = true;
                pos22.Visible = true;
                pos32.Visible = true;
                pos42.Visible = true;
                pos52.Visible = true;

                label12.Visible = true;
                label22.Visible = true;
                label32.Visible = true;
                label42.Visible = true;
                label52.Visible = true;
            }
        }

        private void playnb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playnb3.SelectedIndex == 0)
            {
                pos13.Visible = false;
                pos23.Visible = false;
                pos33.Visible = true;
                pos43.Visible = false;
                pos53.Visible = false;

                label13.Visible = false;
                label23.Visible = false;
                label33.Visible = true;
                label43.Visible = false;
                label53.Visible = false;

            }
            else if (playnb3.SelectedIndex == 1)
            {
                pos13.Visible = false;
                pos23.Visible = true;
                pos33.Visible = false;
                pos43.Visible = true;
                pos53.Visible = false;

                label13.Visible = false;
                label23.Visible = true;
                label33.Visible = false;
                label43.Visible = true;
                label53.Visible = false;
            }
            else if (playnb3.SelectedIndex == 2)
            {
                pos13.Visible = true;
                pos23.Visible = false;
                pos33.Visible = true;
                pos43.Visible = false;
                pos53.Visible = true;

                label13.Visible = true;
                label23.Visible = false;
                label33.Visible = true;
                label43.Visible = false;
                label53.Visible = true;
            }
            else if (playnb3.SelectedIndex == 3)
            {
                pos13.Visible = true;
                pos23.Visible = true;
                pos33.Visible = false;
                pos43.Visible = true;
                pos53.Visible = true;

                label13.Visible = true;
                label23.Visible = true;
                label33.Visible = false;
                label43.Visible = true;
                label53.Visible = true;
            }
            else if (playnb3.SelectedIndex == 4)
            {
                pos13.Visible = true;
                pos23.Visible = true;
                pos33.Visible = true;
                pos43.Visible = true;
                pos53.Visible = true;

                label13.Visible = true;
                label23.Visible = true;
                label33.Visible = true;
                label43.Visible = true;
                label53.Visible = true;
            }
        }

        private void playnb5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playnb5.SelectedIndex == 0)
            {
                pos15.Visible = false;
                pos25.Visible = false;
                pos35.Visible = true;
                pos45.Visible = false;
                pos55.Visible = false;

                label15.Visible = false;
                label25.Visible = false;
                label35.Visible = true;
                label45.Visible = false;
                label55.Visible = false;

            }
            else if (playnb5.SelectedIndex == 1)
            {
                pos15.Visible = false;
                pos25.Visible = true;
                pos35.Visible = false;
                pos45.Visible = true;
                pos55.Visible = false;

                label15.Visible = false;
                label25.Visible = true;
                label35.Visible = false;
                label45.Visible = true;
                label55.Visible = false;
            }
            else if (playnb5.SelectedIndex == 2)
            {
                pos15.Visible = true;
                pos25.Visible = false;
                pos35.Visible = true;
                pos45.Visible = false;
                pos55.Visible = true;

                label15.Visible = true;
                label25.Visible = false;
                label35.Visible = true;
                label45.Visible = false;
                label55.Visible = true;
            }
            else if (playnb5.SelectedIndex == 3)
            {
                pos15.Visible = true;
                pos25.Visible = true;
                pos35.Visible = false;
                pos45.Visible = true;
                pos55.Visible = true;

                label15.Visible = true;
                label25.Visible = true;
                label35.Visible = false;
                label45.Visible = true;
                label55.Visible = true;
            }
            else if (playnb5.SelectedIndex == 4)
            {
                pos15.Visible = true;
                pos25.Visible = true;
                pos35.Visible = true;
                pos45.Visible = true;
                pos55.Visible = true;

                label15.Visible = true;
                label25.Visible = true;
                label35.Visible = true;
                label45.Visible = true;
                label55.Visible = true;
            }
        }

        private void playnb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playnb4.SelectedIndex == 0)
            {
                pos14.Visible = false;
                pos24.Visible = false;
                pos34.Visible = true;
                pos44.Visible = false;
                pos54.Visible = false;

                label14.Visible = false;
                label24.Visible = false;
                label34.Visible = true;
                label44.Visible = false;
                label54.Visible = false;

            }
            else if (playnb4.SelectedIndex == 1)
            {
                pos14.Visible = false;
                pos24.Visible = true;
                pos34.Visible = false;
                pos44.Visible = true;
                pos54.Visible = false;

                label14.Visible = false;
                label24.Visible = true;
                label34.Visible = false;
                label44.Visible = true;
                label54.Visible = false;
            }
            else if (playnb4.SelectedIndex == 2)
            {
                pos14.Visible = true;
                pos24.Visible = false;
                pos34.Visible = true;
                pos44.Visible = false;
                pos54.Visible = true;

                label14.Visible = true;
                label24.Visible = false;
                label34.Visible = true;
                label44.Visible = false;
                label54.Visible = true;
            }
            else if (playnb4.SelectedIndex == 3)
            {
                pos14.Visible = true;
                pos24.Visible = true;
                pos34.Visible = false;
                pos44.Visible = true;
                pos54.Visible = true;

                label14.Visible = true;
                label24.Visible = true;
                label34.Visible = false;
                label44.Visible = true;
                label54.Visible = true;
            }
            else if (playnb4.SelectedIndex == 4)
            {
                pos14.Visible = true;
                pos24.Visible = true;
                pos34.Visible = true;
                pos44.Visible = true;
                pos54.Visible = true;

                label14.Visible = true;
                label24.Visible = true;
                label34.Visible = true;
                label44.Visible = true;
                label54.Visible = true;
            }
        }

        private void Pos11_Click(object sender, EventArgs e)
        {
            cur_num = 1;
            CIform = new changeInfo(cur_num, ref playername[1], ref image[1], this);
            CIform.Show();
        }
        private void Pos21_Click(object sender, EventArgs e)
        {
            cur_num = 2;
            CIform = new changeInfo(cur_num, ref playername[2], ref image[2], this);
            CIform.Show();
        }

        private void Pos31_Click(object sender, EventArgs e)
        {
            cur_num = 3;
            CIform = new changeInfo(cur_num, ref playername[3], ref image[3], this);
            CIform.Show();
        }

        private void Pos41_Click(object sender, EventArgs e)
        {
            cur_num = 4;
            CIform = new changeInfo(cur_num, ref playername[4], ref image[4], this);
            CIform.Show();
        }

        private void Pos51_Click(object sender, EventArgs e)
        {
            CIform = new changeInfo(5, ref playername[5], ref image[5], this);
            CIform.Show();
        }

        private void pos12_Click(object sender, EventArgs e)
        {
            cur_num = 6;
            CIform = new changeInfo(cur_num, ref playername[6], ref image[6], this);
            CIform.Show();
        }

        private void pos22_Click(object sender, EventArgs e)
        {
            cur_num = 7;
            CIform = new changeInfo(cur_num, ref playername[7], ref image[7], this);
            CIform.Show();
        }

        private void pos32_Click(object sender, EventArgs e)
        {
            cur_num = 8;
            CIform = new changeInfo(cur_num, ref playername[8], ref image[8], this);
            CIform.Show();
        }

        private void pos42_Click(object sender, EventArgs e)
        {
            cur_num = 9;
            CIform = new changeInfo(cur_num, ref playername[9], ref image[9], this);
            CIform.Show();
        }

        private void pos52_Click(object sender, EventArgs e)
        {
            cur_num = 10;
            CIform = new changeInfo(cur_num, ref playername[10], ref image[10], this);
            CIform.Show();
        }

        private void pos13_Click(object sender, EventArgs e)
        {
            cur_num = 11;
            CIform = new changeInfo(cur_num, ref playername[11], ref image[11], this
                );
            CIform.Show();
        }

        private void pos23_Click(object sender, EventArgs e)
        {
            cur_num = 12;
            CIform = new changeInfo(cur_num, ref playername[12], ref image[12], this);
            CIform.Show();
        }

        private void pos33_Click(object sender, EventArgs e)
        {
            cur_num = 13;
            CIform = new changeInfo(cur_num, ref playername[13], ref image[13], this);
            CIform.Show();
        }

        private void pos43_Click(object sender, EventArgs e)
        {
            cur_num = 14;
            CIform = new changeInfo(cur_num, ref playername[14], ref image[14], this);
            CIform.Show();
        }

        private void pos53_Click(object sender, EventArgs e)
        {
            cur_num = 15;
            CIform = new changeInfo(cur_num, ref playername[15], ref image[15], this);
            CIform.Show();
        }

        private void pos14_Click(object sender, EventArgs e)
        {
            cur_num = 16;
            CIform = new changeInfo(cur_num, ref playername[16], ref image[16], this);
            CIform.Show();
        }

        private void pos24_Click(object sender, EventArgs e)
        {
            cur_num = 17;
            CIform = new changeInfo(cur_num, ref playername[17], ref image[17], this);
            CIform.Show();
        }

        private void pos34_Click(object sender, EventArgs e)
        {
            cur_num = 18;
            CIform = new changeInfo(cur_num, ref playername[18], ref image[18], this);
            CIform.Show();
        }

        private void pos44_Click(object sender, EventArgs e)
        {
            cur_num = 19;
            CIform = new changeInfo(cur_num, ref playername[19], ref image[19], this);
            CIform.Show();
        }

        private void pos54_Click(object sender, EventArgs e)
        {
            cur_num = 20;
            CIform = new changeInfo(cur_num, ref playername[20], ref image[20], this);
            CIform.Show();
        }

        private void pos15_Click(object sender, EventArgs e)
        {
            cur_num = 21;
            CIform = new changeInfo(cur_num, ref playername[21], ref image[21], this);
            CIform.Show();
        }

        private void pos25_Click(object sender, EventArgs e)
        {
            cur_num = 22;
            CIform = new changeInfo(cur_num, ref playername[22], ref image[22], this);
            CIform.Show();
        }

        private void pos35_Click(object sender, EventArgs e)
        {
            cur_num = 23;
            CIform = new changeInfo(cur_num, ref playername[23], ref image[23], this);
            CIform.Show();
        }

        private void pos45_Click(object sender, EventArgs e)
        {
            cur_num = 24;
            CIform = new changeInfo(cur_num, ref playername[24], ref image[24], this);
            CIform.Show();
        }

        private void pos55_Click(object sender, EventArgs e)
        {
            cur_num = 25;
            CIform = new changeInfo(cur_num, ref playername[25], ref image[25], this);
            CIform.Show();
        }

        public void update( int number)
        {
       
            switch (number)
            {
                case 1:
                    Pos11.BackgroundImageLayout = ImageLayout.Stretch;
                    Pos11.BackgroundImage = Image.FromFile(image[1]);

                    label11.Text = playername[1];
                    break;
                case 2:
                    Pos21.BackgroundImageLayout = ImageLayout.Stretch;
                    Pos21.BackgroundImage = Image.FromFile(image[2]);

                    label21.Text = playername[2];
                    break;
                case 3:
                    Pos31.BackgroundImageLayout = ImageLayout.Stretch;
                    Pos31.BackgroundImage = Image.FromFile(image[3]);

                    label31.Text = playername[3];
                    break;

                case 4:
                    Pos41.BackgroundImageLayout = ImageLayout.Stretch;
                    Pos41.BackgroundImage = Image.FromFile(image[4]);

                    label41.Text = playername[4];
                    break;

                case 5:
                    Pos51.BackgroundImageLayout = ImageLayout.Stretch;
                    Pos51.BackgroundImage = Image.FromFile(image[5]);

                    label51.Text = playername[5];
                    break;

                case 6:
                    pos12.BackgroundImageLayout = ImageLayout.Stretch;
                    pos12.BackgroundImage = Image.FromFile(image[6]);

                    label12.Text = playername[6];
                    break;

                case 7:
                    pos22.BackgroundImageLayout = ImageLayout.Stretch;
                    pos22.BackgroundImage = Image.FromFile(image[7]);

                    label22.Text = playername[7];
                    break;

                case 8:
                    pos32.BackgroundImageLayout = ImageLayout.Stretch;
                    pos32.BackgroundImage = Image.FromFile(image[8]);

                    label32.Text = playername[8];
                    break;

                case 9:
                    pos42.BackgroundImageLayout = ImageLayout.Stretch;
                    pos42.BackgroundImage = Image.FromFile(image[9]);

                    label42.Text = playername[9];
                    break;

                case 10:
                    pos52.BackgroundImageLayout = ImageLayout.Stretch;
                    pos52.BackgroundImage = Image.FromFile(image[10]);

                    label52.Text = playername[10];
                    break;

                case 11:
                    pos13.BackgroundImageLayout = ImageLayout.Stretch;
                    pos13.BackgroundImage = Image.FromFile(image[11]);

                    label13.Text = playername[11];
                    break;

                case 12:
                    pos23.BackgroundImageLayout = ImageLayout.Stretch;
                    pos23.BackgroundImage = Image.FromFile(image[12]);

                    label23.Text = playername[12];
                    break;

                case 13:
                    pos33.BackgroundImageLayout = ImageLayout.Stretch;
                    pos33.BackgroundImage = Image.FromFile(image[13]);

                    label33.Text = playername[13];
                    break;

                case 14:
                    pos43.BackgroundImageLayout = ImageLayout.Stretch;
                    pos43.BackgroundImage = Image.FromFile(image[14]);

                    label43.Text = playername[14];
                    break;

                case 15:
                    pos53.BackgroundImageLayout = ImageLayout.Stretch;
                    pos53.BackgroundImage = Image.FromFile(image[15]);

                    label53.Text = playername[15];
                    break;

                case 16:
                    pos14.BackgroundImageLayout = ImageLayout.Stretch;
                    pos14.BackgroundImage = Image.FromFile(image[16]);

                    label14.Text = playername[16];
                    break;

                case 17:
                    pos24.BackgroundImageLayout = ImageLayout.Stretch;
                    pos24.BackgroundImage = Image.FromFile(image[17]);

                    label24.Text = playername[17];
                    break;

                case 18:
                    pos34.BackgroundImageLayout = ImageLayout.Stretch;
                    pos34.BackgroundImage = Image.FromFile(image[18]);

                    label34.Text = playername[18];
                    break;
                case 19:
                    pos44.BackgroundImageLayout = ImageLayout.Stretch;
                    pos44.BackgroundImage = Image.FromFile(image[19]);

                    label44.Text = playername[19];
                    break;

                case 20:
                    pos54.BackgroundImageLayout = ImageLayout.Stretch;
                    pos54.BackgroundImage = Image.FromFile(image[20]);

                    label54.Text = playername[20];
                    break;

                case 21:
                    pos15.BackgroundImageLayout = ImageLayout.Stretch;
                    pos15.BackgroundImage = Image.FromFile(image[21]);

                    label15.Text = playername[21];
                    break;

                case 22:
                    pos25.BackgroundImageLayout = ImageLayout.Stretch;
                    pos25.BackgroundImage = Image.FromFile(image[22]);

                    label25.Text = playername[22];
                    break;

                case 23:
                    pos35.BackgroundImageLayout = ImageLayout.Stretch;
                    pos35.BackgroundImage = Image.FromFile(image[23]);

                    label35.Text = playername[23];
                    break;

                case 24:
                    pos45.BackgroundImageLayout = ImageLayout.Stretch;
                    pos45.BackgroundImage = Image.FromFile(image[24]);

                    label45.Text = playername[24];
                    break;

                case 25:
                    pos55.BackgroundImageLayout = ImageLayout.Stretch;
                    pos55.BackgroundImage = Image.FromFile(image[25]);

                    label55.Text = playername[25];
                    break;
                }
            
         
        }

        private void sndDataBtn_Click(object sender, EventArgs e)
        {
            if(ZhukeCb.SelectedIndex == 0)
            {

            }
            else
            {

            }

            switch(playnb1.SelectedIndex)
            {
                case 0: break;
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
            }
        }
    }
}
