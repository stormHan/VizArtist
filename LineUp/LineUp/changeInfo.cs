using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineUp;

namespace LineUp
{
    public partial class changeInfo : Form
    {
        public delegate void ListenerHandler();
        public event ListenerHandler listener = null;


        public string retPath;
        public string retName;
        Image img;
        public changeInfo(string _name, string _imagepath)
        {
            InitializeComponent();

            retName = _name;
            retPath =  _imagepath;

            Nametb.Text = retName;
            img = Image.FromFile(retPath);
            
            imagePb.Image = img;
            
        }

        private void chooseImagebtn_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();
             if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 retPath = ofd.FileName;
                 img = Image.FromFile(retPath);
                 imagePb.Image = img;
             }

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Nametb_TextChanged(object sender, EventArgs e)
        {
            retName = Nametb.Text;
        }
        
    }
}
