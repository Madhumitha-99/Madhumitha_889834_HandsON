using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureUpload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String imageLocation="";
        private void button1_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpeg; *.gif; *.png; *.jpg;)| *.jpeg; *.gif; *.png; *.jpg; ";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
