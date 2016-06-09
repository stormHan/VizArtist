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
       static string[] playername = new string[36];
        string[] image = new string[36];

        

        int cur_x = -1;
        int cur_y = -1;
        changeInfo CIform;

        public LineUpForm()
        {
            InitializeComponent();

            Image i;
            playername[1] = "player1";
            image[1] = "E:/Koala.jpg";
            i = Image.FromFile(image[1]);
            Pos11.BackgroundImage = i;

            playername[2] = "p2";
            image[2] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            Pos21.BackgroundImage = i;

            playername[3] = "p2";
            image[3] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            Pos31.BackgroundImage = i;

            playername[4] = "p2";
            image[4] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            Pos41.BackgroundImage = i;

            playername[5] = "p2";
            image[5] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            Pos51.BackgroundImage = i;

            playername[6] = "p2";
            image[6] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos12.BackgroundImage = i;

            playername[7] = "p2";
            image[7] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos22.BackgroundImage = i;

            playername[8] = "p2";
            image[8] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos23.BackgroundImage = i;

            playername[9] = "p2";
            image[9] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos24.BackgroundImage = i;

            playername[10] = "p2";
            image[10] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos25.BackgroundImage = i;

            playername[11] = "p2";
            image[11] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos13.BackgroundImage = i;

            playername[12] = "p2";
            image[12] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos23.BackgroundImage = i;

            playername[13] = "p2";
            image[13] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos33.BackgroundImage = i;

            playername[14] = "p2";
            image[14] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos43.BackgroundImage = i;

            playername[15] = "p2";
            image[15] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos53.BackgroundImage = i;

            playername[16] = "p2";
            image[16] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos14.BackgroundImage = i;

            playername[17] = "p2";
            image[17] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos24.BackgroundImage = i;

            playername[18] = "p2";
            image[18] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos34.BackgroundImage = i;

            playername[19] = "p2";
            image[19] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos44.BackgroundImage = i;

            playername[20] = "p2";
            image[20] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos54.BackgroundImage = i;

            playername[21] = "p2";
            image[21] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos15.BackgroundImage = i;

            playername[22] = "p2";
            image[22] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos25.BackgroundImage = i;

            playername[23] = "p2";
            image[23] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos35.BackgroundImage = i;

            playername[24] = "p2";
            image[24] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
            i = Image.FromFile(image[2]);
            pos45.BackgroundImage = i;

            playername[25] = "p2";
            image[25] = "E:/C#/VizArtist-master/LineUp/LineUp/Resourse/Penguins.jpg";
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

            }
            else if (playnb1.SelectedIndex == 1)
            {
                Pos11.Visible = false;
                Pos21.Visible = true;
                Pos31.Visible = false;
                Pos41.Visible = true;
                Pos51.Visible = false;
            }
            else if (playnb1.SelectedIndex == 2)
            {
                Pos11.Visible = true;
                Pos21.Visible = false;
                Pos31.Visible = true;
                Pos41.Visible = false;
                Pos51.Visible = true;
            }
            else if (playnb1.SelectedIndex == 3)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = false;
                Pos41.Visible = true;
                Pos51.Visible = true;
            }
            else if (playnb1.SelectedIndex == 4)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = true;
                Pos41.Visible = true;
                Pos51.Visible = true;
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

            }
            else if (playnb2.SelectedIndex == 1)
            {
                pos12.Visible = false;
                pos22.Visible = true;
                pos32.Visible = false;
                pos42.Visible = true;
                pos52.Visible = false;
            }
            else if (playnb2.SelectedIndex == 2)
            {
                pos12.Visible = true;
                pos22.Visible = false;
                pos32.Visible = true;
                pos42.Visible = false;
                pos52.Visible = true;
            }
            else if (playnb2.SelectedIndex == 3)
            {
                pos12.Visible = true;
                pos22.Visible = true;
                pos32.Visible = false;
                pos42.Visible = true;
                pos52.Visible = true;
            }
            else if (playnb2.SelectedIndex == 4)
            {
                pos12.Visible = true;
                pos22.Visible = true;
                pos32.Visible = true;
                pos42.Visible = true;
                pos52.Visible = true;
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

            }
            else if (playnb3.SelectedIndex == 1)
            {
                pos13.Visible = false;
                pos23.Visible = true;
                pos33.Visible = false;
                pos43.Visible = true;
                pos53.Visible = false;
            }
            else if (playnb3.SelectedIndex == 2)
            {
                pos13.Visible = true;
                pos23.Visible = false;
                pos33.Visible = true;
                pos43.Visible = false;
                pos53.Visible = true;
            }
            else if (playnb3.SelectedIndex == 3)
            {
                pos13.Visible = true;
                pos23.Visible = true;
                pos33.Visible = false;
                pos43.Visible = true;
                pos53.Visible = true;
            }
            else if (playnb3.SelectedIndex == 4)
            {
                pos13.Visible = true;
                pos23.Visible = true;
                pos33.Visible = true;
                pos43.Visible = true;
                pos53.Visible = true;
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

            }
            else if (playnb5.SelectedIndex == 1)
            {
                pos15.Visible = false;
                pos25.Visible = true;
                pos35.Visible = false;
                pos45.Visible = true;
                pos55.Visible = false;
            }
            else if (playnb5.SelectedIndex == 2)
            {
                pos15.Visible = true;
                pos25.Visible = false;
                pos35.Visible = true;
                pos45.Visible = false;
                pos55.Visible = true;
            }
            else if (playnb5.SelectedIndex == 3)
            {
                pos15.Visible = true;
                pos25.Visible = true;
                pos35.Visible = false;
                pos45.Visible = true;
                pos55.Visible = true;
            }
            else if (playnb5.SelectedIndex == 4)
            {
                pos15.Visible = true;
                pos25.Visible = true;
                pos35.Visible = true;
                pos45.Visible = true;
                pos55.Visible = true;
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

            }
            else if (playnb4.SelectedIndex == 1)
            {
                pos14.Visible = false;
                pos24.Visible = true;
                pos34.Visible = false;
                pos44.Visible = true;
                pos54.Visible = false;
            }
            else if (playnb4.SelectedIndex == 2)
            {
                pos14.Visible = true;
                pos24.Visible = false;
                pos34.Visible = true;
                pos44.Visible = false;
                pos54.Visible = true;
            }
            else if (playnb4.SelectedIndex == 3)
            {
                pos14.Visible = true;
                pos24.Visible = true;
                pos34.Visible = false;
                pos44.Visible = true;
                pos54.Visible = true;
            }
            else if (playnb4.SelectedIndex == 4)
            {
                pos14.Visible = true;
                pos24.Visible = true;
                pos34.Visible = true;
                pos44.Visible = true;
                pos54.Visible = true;
            }
        }

        private void Pos11_Click(object sender, EventArgs e)
        {
            CIform = new changeInfo(ref playername[1], ref image[1]);
            CIform.Show();
        }
        private void Pos21_Click(object sender, EventArgs e)
        {
            CIform = new changeInfo(ref playername[2], ref image[2]);
            CIform.Show();
        }

        private void Pos31_Click(object sender, EventArgs e)
        {
            CIform = new changeInfo(ref playername[3], ref image[3]);
            CIform.Show();
        }

        private void Pos41_Click(object sender, EventArgs e)
        {
            CIform = new changeInfo(ref playername[4], ref image[4]);
            CIform.Show();
        }

        private void Pos51_Click(object sender, EventArgs e)
        {
            CIform = new changeInfo(ref playername[5], ref image[5]);
            CIform.Show();
        }
    }
}
