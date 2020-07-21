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

namespace kmNumberChange
{
    public partial class Form1 : Form
    {
        String url = "";
        private int x;
        private int y;
        int standard_width = 11;
        int standard_height = 15;
        int old_position_x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void excute(object sender, EventArgs e)
        {
            String inputText = input.Text;
            char[] inputArray = inputText.ToCharArray(0, inputText.Length);
            Array.Reverse(inputArray);

            int lns = inputArray.Length;
            LogTest.Text = "LOG : " + lns;

            for (int i = 0; i < lns; i++)
            {
                switch (i)
                {
                    case 0:
                        unit.Image = Image.FromFile(url + "/"+ inputArray[i] + ".jpg");
                        unit.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 1:
                        ten.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        ten.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        hundred.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        hundred.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        thousand.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        thousand.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 4:
                        million.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        million.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 5:
                        ten_million.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        ten_million.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
            }
        }

        public Boolean checkImageExist()
        {
            Boolean exist = true;
            if ("" != image_url.Text)
            {
                url = image_url.Text;
                url = url.Replace("\\", "/");

                // Check number
                for (int i = 0; i < 10; i++)
                {
                    String fileName = "/" + i + ".jpg";
                    if (!File.Exists(url + fileName))
                    {
                        exist = false;
                        break;
                    }
                }
                // Check main
                if (!File.Exists(url + "/main.jpg"))
                {
                    exist = false;
                }
                // Check empty
                if (!File.Exists(url + "/empty.jpg"))
                {
                    exist = false;
                }

            } else
            {
                exist = false;
            }

            if (!exist)
            {
                string message = "請確認來源資料夾是否有存在且圖片是否齊全";
                string caption = "圖片來源有問題";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                /* if (result == System.Windows.Forms.DialogResult.Yes)
                 {
                     // Closes the parent form.
                     this.Close();
                 }*/
            }
            else
            {
                excuteBtn.Enabled = true;
                clearBtn.Enabled = true;
            }

            return exist;
        }

        private void loadFile(object sender, EventArgs e)
        {
            if (checkImageExist())
            {
                
                main_image.Load(url + "/main.jpg");
                main_image.SizeMode = PictureBoxSizeMode.Zoom;

                model_0.Image = Image.FromFile(url + "/0.jpg");
                model_0.SizeMode = PictureBoxSizeMode.Zoom;
                model_1.Image = Image.FromFile(url + "/1.jpg");
                model_1.SizeMode = PictureBoxSizeMode.Zoom;
                model_2.Image = Image.FromFile(url + "/2.jpg");
                model_2.SizeMode = PictureBoxSizeMode.Zoom;
                model_3.Image = Image.FromFile(url + "/3.jpg");
                model_3.SizeMode = PictureBoxSizeMode.Zoom;
                model_4.Image = Image.FromFile(url + "/4.jpg");
                model_4.SizeMode = PictureBoxSizeMode.Zoom;
                model_5.Image = Image.FromFile(url + "/5.jpg");
                model_5.SizeMode = PictureBoxSizeMode.Zoom;
                model_6.Image = Image.FromFile(url + "/6.jpg");
                model_6.SizeMode = PictureBoxSizeMode.Zoom;
                model_7.Image = Image.FromFile(url + "/7.jpg");
                model_7.SizeMode = PictureBoxSizeMode.Zoom;
                model_8.Image = Image.FromFile(url + "/8.jpg");
                model_8.SizeMode = PictureBoxSizeMode.Zoom;
                model_9.Image = Image.FromFile(url + "/9.jpg");
                model_9.SizeMode = PictureBoxSizeMode.Zoom;

                unit.Image = Image.FromFile(url + "/empty.jpg");
                ten.Image = Image.FromFile(url + "/empty.jpg");
                hundred.Image = Image.FromFile(url + "/empty.jpg");
                thousand.Image = Image.FromFile(url + "/empty.jpg");
                million.Image = Image.FromFile(url + "/empty.jpg");
                ten_million.Image = Image.FromFile(url + "/empty.jpg");

                emptyImg.Image = Image.FromFile(url + "/empty.jpg");
            }
        }

        private void clear(object sender, EventArgs e)
        {
            unit.Load(url + "/empty.jpg");
            ten.Load(url + "/empty.jpg");
            hundred.Load(url + "/empty.jpg");
            thousand.Load(url + "/empty.jpg");
            million.Load(url + "/empty.jpg");
            ten_million.Load(url + "/empty.jpg");
            input.Text = "";
        }

        // ===========================================================================================================
        /* 讓物件可以拖移 */
        // 要移動的物件設定
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                DoDragDrop(emptyImg, DragDropEffects.Move);
            }
        }
        // Form設定
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Point p = PointToClient(new Point(e.X, e.Y));
            emptyImg.SetBounds(p.X - x, p.Y - y, emptyImg.Width, emptyImg.Height);
        }
        // ===========================================================================================================
        // 圖片縮放

        private void changeSize(object sender, EventArgs e)
        {
            if (0 == old_position_x)
            {
                old_position_x = pictureBox1.Location.X;
            }

            int change_width = 0;
            int change_height = 0;

            if ("" != newSize.Text)
            {
                change_width = int.Parse(newSize.Text);
                change_height = int.Parse(newSize.Text);
            }

            // Unit
            /*unit.Location = new Point(unit.Location.X + change_width, unit.Location.Y);
            unit.Width = standard_width + change_width;
            unit.Height = standard_height + change_height;*/

            pictureBox1.Location = new Point(old_position_x + change_width, pictureBox1.Location.Y);
            pictureBox1.Width = standard_width + change_width;
            pictureBox1.Height = standard_height + change_height;

            test123.Width = standard_width + change_width;
            test123.Height = standard_height + change_height;
        }
    }
}
