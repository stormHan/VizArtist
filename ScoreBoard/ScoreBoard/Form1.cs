using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VizConnectC;

namespace ScoreBoard
{
    public partial class Form1 : Form
    {
        VizEnginePool m_EnginePool = new VizEnginePool();
        int g1Numcount = 0, g2Numcount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            m_EnginePool.Disconnect();
            m_EnginePool.CleanRendererList();
            m_EnginePool.AddRenderer(ConnectIp.Text, Convert.ToInt16(ConnectPort.Text));

            if (m_EnginePool.Connect()) MessageBox.Show("connect successfully!");
            else MessageBox.Show("fail to connect the Viz!");
        }

        private void A_3_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                g1Numcount += 3;
                m_EnginePool.Send("1 RENDERER*FUNCTION*DataPool*Data SET G1Number = " + g1Numcount.ToString());
                //光send命令，在很多时候你不知道这条命令的执行情况，故，可以引入request函数。

                string reqBack;
               // reqBack = m_EnginePool.Request("1 RENDERER*FUNCTION*DataPool*Data SET G1Number = " + g1Numcount.ToString());
               // MessageBox.Show(reqBack);
            }
        }

        private void A_2_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                g1Numcount += 2;
                m_EnginePool.Send("1 RENDERER*FUNCTION*DataPool*Data SET G1Number = " + g1Numcount.ToString());
            }
        }


        private void A_1_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                g1Numcount += 1;
                m_EnginePool.Send("1 RENDERER*FUNCTION*DataPool*Data SET G1Number = " + g1Numcount.ToString());
            }
        }

        private void B_1_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                g2Numcount += 1;
                m_EnginePool.Send("1 RENDERER*FUNCTION*DataPool*Data SET G2Number = " + g2Numcount.ToString());
            }
        }

        private void B_2_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                g2Numcount += 2;
                m_EnginePool.Send("1 RENDERER*FUNCTION*DataPool*Data SET G2Number = " + g2Numcount.ToString());
            }
        }

        private void B_3_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                g2Numcount += 3;
                m_EnginePool.Send("1 RENDERER*FUNCTION*DataPool*Data SET G2Number = " + g2Numcount.ToString());
            }
        }

        private void cmdLoadscene_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
               // m_EnginePool.Send("RENDERER SET_OBJECT SCENE*" + path.Text);
                m_EnginePool.LoadScene(path.Text);
            }
        }

        private void cmdLoadData_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                string strBack;
                strBack = m_EnginePool.Request("1 RENDERER*TREE*@Group1*GEOM*TEXT GET");
                if (strBack.StartsWith("ERROR"))
                    MessageBox.Show("Error get the data!");
                else
                    g1Numcount = Convert.ToInt16(strBack);

                strBack = m_EnginePool.Request("1 RENDERER*TREE*@Group2*GEOM*TEXT GET");
                if (strBack.StartsWith("ERROR"))
                    MessageBox.Show("Error get the data!");
                else
                    g2Numcount = Convert.ToInt16(strBack);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sr= m_EnginePool.Request("REND*SCRIPT INVOKE test");
            
            
        }
    }
}
