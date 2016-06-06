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
       static string[] playername = new string[25];
        string[] image = new string[25];

        

        int cur_x = -1;
        int cur_y = -1;
        changeInfo CIform;

        public LineUpForm()
        {
            InitializeComponent();
            playername[1] = "player1";
           
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
            if(playnb1.SelectedIndex == 0)
            {
                Pos11.Visible = true;
                Pos21.Visible = false;
                Pos31.Visible = false;
                Pos41.Visible = false;
                Pos51.Visible = false;
            
            }
            else if (playnb1.SelectedIndex == 1)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = false;
                Pos41.Visible = false;
                Pos51.Visible = false;
            }
            else if (playnb1.SelectedIndex == 2)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = true;
                Pos41.Visible = false;
                Pos51.Visible = false;
            }
            else if (playnb1.SelectedIndex == 3)
            {
                Pos11.Visible = true;
                Pos21.Visible = true;
                Pos31.Visible = true;
                Pos41.Visible = true;
                Pos51.Visible = false;
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

        private void Pos11_Click(object sender, EventArgs e)
        {
            cur_x = 1;
            cur_y = 1;

            CIform = new changeInfo(playername[1], image[1]);
            CIform.Show();
        }
    }
}
