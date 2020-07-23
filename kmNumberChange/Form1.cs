using System;
using System.Drawing;
using System.IO;
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
        // For Form 移動
        bool beginMove = false;//初始化滑鼠位置
        int currentXPosition;
        int currentYPosition;

        public Form1()
        {
            InitializeComponent();

            ToolTip toolTip_newSize_label = new ToolTip();
            toolTip_newSize_label.SetToolTip(newSize_label, "正整數是放大，負數是縮小\n空值或是0則是回復預設大小");

            /* 
            // 使圖片重疊且顯示透明背景的做法
            unit.BackColor = Color.Transparent;
            unit.Parent = main_image;
            ten.BackColor = Color.Transparent;
            ten.Parent = main_image;
            hundred.BackColor = Color.Transparent;
            hundred.Parent = main_image;
            thousand.BackColor = Color.Transparent;
            thousand.Parent = main_image;
            million.BackColor = Color.Transparent;
            million.Parent = main_image;
            ten_million.BackColor = Color.Transparent;
            ten_million.Parent = main_image;
            */
        }

        private void excute(object sender, EventArgs e)
        {
            Boolean isNumber = true;
            String inputText = input.Text;
            char[] inputArray = inputText.ToCharArray(0, inputText.Length);

            for (int i = 0; i < inputArray.Length; i++) 
            {
                char number = inputArray[i];
                String numberString = number.ToString();
                int temp = 0;
                if ('-' == number || !int.TryParse(numberString, out temp))
                {
                    isNumber = false;
                    string message = "請輸入正整數";
                    string caption = "輸入錯誤";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    break;
                }
            }

            if (isNumber)
            {
                Array.Reverse(inputArray);

                int lns = inputArray.Length;

                if (6 < lns)
                {
                    string message = "最多輸入6位數";
                    string caption = "輸入錯誤";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);

                }
                else
                {
                    for (int i = 0; i < lns; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                unit.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                                unit.SizeMode = PictureBoxSizeMode.StretchImage;
                                unit.Visible = true;
                                break;
                            case 1:
                                ten.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                                ten.SizeMode = PictureBoxSizeMode.StretchImage;
                                ten.Visible = true;
                                break;
                            case 2:
                                hundred.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                                hundred.SizeMode = PictureBoxSizeMode.StretchImage;
                                hundred.Visible = true;
                                break;
                            case 3:
                                thousand.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                                thousand.SizeMode = PictureBoxSizeMode.StretchImage;
                                thousand.Visible = true;
                                break;
                            case 4:
                                million.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                                million.SizeMode = PictureBoxSizeMode.StretchImage;
                                million.Visible = true;
                                break;
                            case 5:
                                ten_million.Image = Image.FromFile(url + "/" + inputArray[i] + ".jpg");
                                ten_million.SizeMode = PictureBoxSizeMode.StretchImage;
                                ten_million.Visible = true;
                                break;
                        }
                    }
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
                changeSizeBtn.Enabled = true;
            }

            return exist;
        }

        private void loadFile(object sender, EventArgs e)
        {
            if (checkImageExist())
            {
                main_image.Load(url + "/main.jpg");
                main_image.SizeMode = PictureBoxSizeMode.Zoom;

                /*unit.Image = Image.FromFile(url + "/empty.jpg");
                ten.Image = Image.FromFile(url + "/empty.jpg");
                hundred.Image = Image.FromFile(url + "/empty.jpg");
                thousand.Image = Image.FromFile(url + "/empty.jpg");
                million.Image = Image.FromFile(url + "/empty.jpg");
                ten_million.Image = Image.FromFile(url + "/empty.jpg");*/

            }
        }

        private void clear(object sender, EventArgs e)
        {
            unit.Image = null;
            ten.Image = null;
            hundred.Image = null;
            thousand.Image = null;
            million.Image = null;
            ten_million.Image = null;

            unit.Visible = false;
            ten.Visible = false;
            hundred.Visible = false;
            thousand.Visible = false;
            million.Visible = false;
            ten_million.Visible = false;

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
        // 按鈕移動位置
        // UP
        private void numberMoveUp(object sender, EventArgs e)
        {
            int unit_x = unit.Location.X;
            int unit_y = unit.Location.Y - 1;
            
            // unit
            unit.Location = new Point(unit_x, unit_y);
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
        // DOWN
        private void numberMoveDown(object sender, EventArgs e)
        {
            int unit_x = unit.Location.X;
            int unit_y = unit.Location.Y + 1;

            // unit
            unit.Location = new Point(unit_x, unit_y);
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
        // RIGHT
        private void numberMoveRight(object sender, EventArgs e)
        {
            int unit_x = unit.Location.X + 1;
            int unit_y = unit.Location.Y;

            // unit
            unit.Location = new Point(unit_x, unit_y);
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
        // LEFT
        private void numberMoveLeft(object sender, EventArgs e)
        {
            int unit_x = unit.Location.X - 1;
            int unit_y = unit.Location.Y;

            // unit
            unit.Location = new Point(unit_x, unit_y);
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

        // ===========================================================================================================
        // 圖片縮放
        private void changeSize(object sender, EventArgs e)
        {

            int change_width = 0;
            int change_height = 0;

            int temp = 0;
            if (!int.TryParse(newSize.Text, out temp))
            {
                string message = "請輸入整數";
                string caption = "輸入錯誤";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            } else
            {
                if ("" != newSize.Text)
                {
                    change_width = int.Parse(newSize.Text);
                    change_height = int.Parse(newSize.Text);
                }

                // 公式 : ten_million的X座標 + (標準寬度+改變寬度) * 等比例
                unit.Location = new Point(ten_million.Location.X + (standard_width + change_width) * 5, unit.Location.Y);
                unit.Width = standard_width + change_width;
                unit.Height = standard_height + change_height;

                ten.Location = new Point(ten_million.Location.X + (standard_width + change_width) * 4, ten.Location.Y);
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

        // ===========================================================================================================
        // 關閉視窗
        private void closeFormBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        // 縮小視窗
        private void hideFormBtn_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Text = "公里數改圖";                 //欲顯示的文字
            this.WindowState = FormWindowState.Minimized;        //決定視窗大小
            this.ShowInTaskbar = true;                           //決定是否出現在工作列
            this.notifyIcon.Visible = true;
        }

        // 開啟縮小視窗
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //在工具列點擊兩下，回復視窗
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.notifyIcon.Visible = false;
            }
        }

        // ===========================================================================================================
        //獲取滑鼠按下時的位置
        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//滑鼠的x座標為當前窗體左上角x座標
                currentYPosition = MousePosition.Y;//滑鼠的y座標為當前窗體左上角y座標
            }
        }

        //獲取滑鼠移動到的位置
        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根據滑鼠x座標確定窗體的左邊座標x
                this.Top += MousePosition.Y - currentYPosition;//根據滑鼠的y座標窗體的頂部，即Y座標
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        //釋放滑鼠時的位置
        private void form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //設定初始狀態
                currentYPosition = 0;
                beginMove = false;
            }
        }
    }
}
