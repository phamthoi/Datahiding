using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Media;

namespace steganography
{
    public partial class game : Form
    {
        private Bitmap bmp = null;
        private string extractedText = string.Empty;
        SoundPlayer _soundPlayer = new SoundPlayer(soundLocation: @"E:\nam3\crypto\datahidingC#\data_hiding\project\cau4\TetNayConSeVe-BuiCongNam-7126439.wav");

        public game()
        {
            InitializeComponent();
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string extractedText = SteganographyHelper.extractText(bmp);

           
                try
                {
                    extractedText = Crypto.DecryptStringAES(extractedText, passwordTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("sai rồi!! thử lại một đáp án khác nào");

                    return;
                }

            dataTextBox.Text = extractedText;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau1\\cau1.png");
            MessageBox.Show("câu lạc bộ bóng đá nào nhiều fan nhất");

        }

        private void cau2_button_Click(object sender, EventArgs e)
        {

            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau2\\cau2.png");
            MessageBox.Show("quãng đường từ trái đất lên mặt trăng là bao nhiêu km");
        }

        private void cau3_button_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau3\\cau3.png");
            MessageBox.Show("Giải PTHH sau: Cr(OH)3 + Cl2 + NaOH -> ");
        }

        private void cau4_button_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            _soundPlayer.Play();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau4\\cau4.png");
            MessageBox.Show("bài hát này là gì??");
        }


        private void game_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            imagePictureBox.Image = null;
            dataTextBox.Clear();
            passwordTextBox.Clear();
            _soundPlayer.Stop();
        }

        private void button_cau5_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau5\\cau5.png");
            MessageBox.Show("cùng đến với chủ đề thơ văn nha!!!");
            MessageBox.Show("người trong hình là ai");

        }

        private void button_cau6_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau6\\cau6.png");
            MessageBox.Show("liệu bạn còn nhớ bài thơ mà bạn đọc ở câu 5 là bài gì hông ha");
        }

        private void button_cau7_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau7\\cau7.png");
            MessageBox.Show("Cây khô một lá bốn năm cành\nĐường đi khúc khuỷu nhọc tay anh\nGặp kẻ tiểu nhân buồn chẳng nói\nChờ người quân tử mới dương danh");
            MessageBox.Show("đố bạn biết đó là cái gì kkk");
        }

        private void button_cau8_Click(object sender, EventArgs e)
        {
            dataTextBox.Clear();
            passwordTextBox.Clear();
            imagePictureBox.Image = Image.FromFile("E:\\nam3\\crypto\\datahidingC#\\data_hiding\\project\\cau8\\cau8.png");
            MessageBox.Show("chiếc đồng hồ ở trên năm ở đâu");
        }
    }
}
