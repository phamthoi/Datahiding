using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace steganography
{
    public partial class Form1 : Form
    {
        private Bitmap bmp = null;
        private string extractedText = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // hiding text inside file image
        private void hide_buttoon_Click(object sender, EventArgs e)
        {
            //use bitmap to hide data because bitmap is format mesh image consisting of rows of dotted pixels
            bmp = (Bitmap)imagePictureBox.Image;

            //Convert the text in the table to a string for execution
            string text = dataTextBox.Text;

            //if string == 0 then cann't write file
            if (text.Equals(""))
            {
                MessageBox.Show("dữ liệu trống không thể ghi vào file");

                return;
            }

            //add encrypt password for more secure photos
            if (encryptCheckBox.Checked)
            {
                if (passwordTextBox.Text.Length < 4)
                {
                    MessageBox.Show("tối thiếu pass 4 kí tự trở lên");

                    return;
                }
                else
                {
                    //encrypt between the file inside crypto and the password we just entered
                    text = Crypto.EncryptStringAES(text, passwordTextBox.Text);
                }
            }

            bmp = SteganographyHelper.embedText(text, bmp);

            MessageBox.Show("dữ liệu ghi hoàn thành");
            dataTextBox.Clear();
            passwordTextBox.Clear();
        }

        //check password
        private void load_button_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)imagePictureBox.Image;

            string extractedText = SteganographyHelper.extractText(bmp);
            if (encryptCheckBox.Checked)
            {
                try
                {
                    //If it is correct, the file description screen will be displayed
                    extractedText = Crypto.DecryptStringAES(extractedText, passwordTextBox.Text);
                }
                catch
                {
                    //If it is wrong, the screen will ask you to re-enter it
                    MessageBox.Show("sai rồi!! thử lại một đáp án khác nào");

                    return;
                }
            }

            dataTextBox.Text = extractedText;

        }

        //function to open image file for execution
        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files (*.jpeg; *.png; *.bmp)|*.jpg; *.png; *.bmp";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                imagePictureBox.Image = Image.FromFile(open_dialog.FileName);
            }
        }

        //function save file image has been executed

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Png Image|*.png|Bitmap Image|*.bmp";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                switch (save_dialog.FilterIndex)
                {
                    case 0:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Png);
                        }
                        break;
                    case 1:
                        {
                            bmp.Save(save_dialog.FileName, ImageFormat.Bmp);
                        }
                        break;
                }
            }
            imagePictureBox.Image = null;
            imagePictureBox.Invalidate();
        }


        //function to open text file for execution
        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Text Files|*.txt";

            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                dataTextBox.Text = File.ReadAllText(open_dialog.FileName);
            }

        }

        //function save file image has been executed
        private void textToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Filter = "Text Files|*.txt";

            if (save_dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save_dialog.FileName, dataTextBox.Text);
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guide form = new Guide();
            form.Show();
        }

        private void GroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phạm Văn Thời: 20521977\nVũ Cảnh Bình Minh: 20521620\nDương Đỗ Khoa: 20521465");
        }
    }
}
