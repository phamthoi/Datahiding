using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steganography
{
    public partial class Guide : Form
    {
        public Guide()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_doc_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\guide.txt", FileMode.Open);
            StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            txt.Text = rd.ReadToEnd();// ReadLine() chỉ đọc 1 dòng đầu thoy, ReadToEnd là đọc hết
  

        }
    }
}
