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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void excute(object sender, EventArgs e)
        {
            if (checkImageExist())
            {
                String inputText = input.Text;
                char[] inputArray = inputText.ToCharArray(0, inputText.Length);
                Array.Reverse(inputArray);

                int lns = inputArray.Length;
                /* String log = "";
                 for (int i=0; i<lns; i++)
                 {
                     log = log + "-" + inputArray[i];
                 }*/
                LogTest.Text = "LOG : " + lns;

                for (int i = 0; i < lns; i++)
                {
                    switch (i)
                    {
                        case 0:
                            //unit.BackgroundImage = changeBackground(inputArray[i] - '0');
                            unit.Image = Image.FromFile(url + "/0.jpg");

                            break;
                        case 1:
                            ten.BackgroundImage = changeBackground(inputArray[i] - '0');
                            break;
                        case 2:
                            hundred.BackgroundImage = changeBackground(inputArray[i] - '0');
                            break;
                        case 3:
                            thousand.BackgroundImage = changeBackground(inputArray[i] - '0');
                            break;
                        case 4:
                            million.BackgroundImage = changeBackground(inputArray[i] - '0');
                            break;
                        case 5:
                            ten_million.BackgroundImage = changeBackground(inputArray[i] - '0');
                            break;
                    }
                }
            }
        }

        public Boolean checkImageExist()
        {
            Boolean exist = true;
            

            for (int i=0; i<10; i++)
            {
                String fileName = "/" + i + ".jpg";
                if (!File.Exists(url + fileName))
                {
                    exist = false;
                    break;
                }
            }

            return exist;
        }

        public Image changeBackground (int num)
        {
            Image temp = null;
            switch (num)
            {
                case 0:
                    temp = Properties.Resources._0;
                    break;
                case 1:
                    temp = Properties.Resources._1;
                    break;
                /*case 2:
                    temp = Properties.Resources._2;
                    break;*/
                case 3:
                    temp = Properties.Resources._3;
                    break;
                /*case 4:
                    temp = Properties.Resources._4;
                    break;
                case 5:
                    temp = Properties.Resources._5;
                    break;*/
                case 6:
                    temp = Properties.Resources._6;
                    break;
               /* case 7:
                    temp = Properties.Resources._7;
                    break;
                case 8:
                    temp = Properties.Resources._8;
                    break;
                case 9:
                    temp = Properties.Resources._9;
                    break;*/
            }

            return temp;
        }

        private void loadFile(object sender, EventArgs e)
        {
            url = image_url.Text;
            url = url.Replace("\\", "/");
            main_image.Load(url+"/main.jpg");
            main_image.SizeMode = PictureBoxSizeMode.StretchImage;
            //main_image.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void clear(object sender, EventArgs e)
        {
            unit.Load(url + "/empty.jpg");
            ten.Load(url + "/empty.jpg");
            hundred.Load(url + "/empty.jpg");
            thousand.Load(url + "/empty.jpg");
            million.Load(url + "/empty.jpg");
            ten_million.Load(url + "/empty.jpg");
        }
    }
}
