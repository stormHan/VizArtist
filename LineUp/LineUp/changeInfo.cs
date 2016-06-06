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
    public partial class changeInfo : Form
    {
        string filename;
        public changeInfo(string _name, string _imagepath)
        {
            InitializeComponent();

            
            Nametb.Text = _name;
            filename = _imagepath;
            Image img = Image.FromFile("D:\\Koala.jpg");
            imagePb.Image = img;
        }
        
    }
}
