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

        LineUpForm parent;
        string retPath;
        string retName;
        Image img;
        int number;
        
        public changeInfo(int _number, ref string _name, ref string _imagepath, LineUpForm _parent)
        {
            InitializeComponent();

            retName = _name;
            retPath =  _imagepath;

            Nametb.Text = retName;
            img = Image.FromFile(retPath);
            imagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagePb.Image = img;
            parent = _parent;

            number = _number;
        }

        private void chooseImagebtn_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();
             if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 retPath = ofd.FileName;
                 img = Image.FromFile(retPath);
                 imagePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                 imagePb.Image = img;
             }
             parent.image[number] = retPath;
             
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            parent.update(number);
            this.Close();
        }

        private void Nametb_TextChanged(object sender, EventArgs e)
        {
            retName = Nametb.Text;
            if(parent != null)
                parent.playername[number] = retName;
        }
        
    }
}
