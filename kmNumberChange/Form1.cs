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
        int standard_width = 19;
        int standard_height = 26;

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

            for (int i = 0; i < lns; i++)
            {
                switch (i)
                {
                    case 0:
                        unit.Image = Image.FromFile(url + "/"+ inputArray[i] + ".jpg");
                        unit.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 1:
                        ten.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        ten.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2:
                        hundred.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        hundred.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3:
                        thousand.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        thousand.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4:
                        million.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        million.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5:
                        ten_million.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                        ten_million.SizeMode = PictureBoxSizeMode.StretchImage;
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

                unit.Image = Image.FromFile(url + "/empty.jpg");
                ten.Image = Image.FromFile(url + "/empty.jpg");
                hundred.Image = Image.FromFile(url + "/empty.jpg");
                thousand.Image = Image.FromFile(url + "/empty.jpg");
                million.Image = Image.FromFile(url + "/empty.jpg");
                ten_million.Image = Image.FromFile(url + "/empty.jpg");

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

        private void number_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
                DoDragDrop(unit, DragDropEffects.Move);

                int unit_x = unit.Location.X;
                int unit_y = unit.Location.Y;
                int unit_width = unit.Width;

                // ten
                ten.Location = new Point(unit_x - unit_width, unit_y);
                // hundred
                hundred.Location = new Point(unit_x - (unit_width * 2), unit_y);
                // thousand
                thousand.Location = new Point(unit_x - (unit_width * 3), unit_y);
                // million
                million.Location = new Point(unit_x - (unit_width * 4), unit_y);
                // ten_million
                ten_million.Location = new Point(unit_x - (unit_width * 5), unit_y);

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
            unit.SetBounds(p.X - x, p.Y - y, unit.Width, unit.Height);
        }
        // ===========================================================================================================
        // 圖片縮放

        private void changeSize(object sender, EventArgs e)
        {

            int change_width = 0;
            int change_height = 0;

            if ("" != newSize.Text)
            {
                change_width = int.Parse(newSize.Text);
                change_height = int.Parse(newSize.Text);
            }

            // 公式 : ten_million的X座標 + (標準寬度+改變寬度) * 等比例
            unit.Location = new Point(ten_million.Location.X + (standard_width + change_width) * 5, unit.Location.Y);
            unit.Width = standard_width + change_width;
            unit.Height = standard_height + change_height;

            ten.Location = new Point(ten_million.Location.X + (standard_width + change_width)  * 4, ten.Location.Y);
            ten.Width = standard_width + change_width;
            ten.Height = standard_height + change_height;

            hundred.Location = new Point(ten_million.Location.X + (standard_width + change_width) * 3, hundred.Location.Y);
            hundred.Width = standard_width + change_width;
            hundred.Height = standard_height + change_height;

            thousand.Location = new Point(ten_million.Location.X + (standard_width + change_width) * 2, thousand.Location.Y);
            thousand.Width = standard_width + change_width;
            thousand.Height = standard_height + change_height;

            million.Location = new Point(ten_million.Location.X + (standard_width + change_width), ten_million.Location.Y);
            million.Width = standard_width + change_width;
            million.Height = standard_height + change_height;

            ten_million.Width = standard_width + change_width;
            ten_million.Height = standard_height + change_height;

        }
    }
}
