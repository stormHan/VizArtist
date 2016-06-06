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

namespace LineUp
{
    public partial class Form1 : Form
    {
        VizEnginePool m_EnginePool = new VizEnginePool();
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

        private void ConnectIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConnectPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            if (m_EnginePool.IsConnected)
            {
                // m_EnginePool.Send("RENDERER SET_OBJECT SCENE*" + path.Text);
                m_EnginePool.LoadScene(Pathtb.Text);
            }

            LineUpForm lineup = new LineUpForm();
            lineup.Show();
        }
    }
}
