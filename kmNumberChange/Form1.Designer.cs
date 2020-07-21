namespace kmNumberChange
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excuteBtn = new System.Windows.Forms.Button();
            this.ten_million = new System.Windows.Forms.PictureBox();
            this.unit = new System.Windows.Forms.PictureBox();
            this.hundred = new System.Windows.Forms.PictureBox();
            this.ten = new System.Windows.Forms.PictureBox();
            this.million = new System.Windows.Forms.PictureBox();
            this.thousand = new System.Windows.Forms.PictureBox();
            this.main_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.image_url = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newSize = new System.Windows.Forms.TextBox();
            this.changeSizeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ten_million)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.million)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thousand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_image)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input.Location = new System.Drawing.Point(152, 475);
            this.input.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(132, 34);
            this.input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(11, 477);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入里程數";
            // 
            // excuteBtn
            // 
            this.excuteBtn.Enabled = false;
            this.excuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.excuteBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excuteBtn.Location = new System.Drawing.Point(292, 475);
            this.excuteBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.excuteBtn.Name = "excuteBtn";
            this.excuteBtn.Size = new System.Drawing.Size(100, 34);
            this.excuteBtn.TabIndex = 18;
            this.excuteBtn.Text = "執行";
            this.excuteBtn.UseVisualStyleBackColor = true;
            this.excuteBtn.Click += new System.EventHandler(this.excute);
            // 
            // ten_million
            // 
            this.ten_million.BackColor = System.Drawing.Color.SaddleBrown;
            this.ten_million.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ten_million.Location = new System.Drawing.Point(601, 505);
            this.ten_million.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ten_million.Name = "ten_million";
            this.ten_million.Size = new System.Drawing.Size(15, 19);
            this.ten_million.TabIndex = 21;
            this.ten_million.TabStop = false;
            // 
            // unit
            // 
            this.unit.BackColor = System.Drawing.Color.Black;
            this.unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unit.Location = new System.Drawing.Point(675, 505);
            this.unit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(15, 19);
            this.unit.TabIndex = 17;
            this.unit.TabStop = false;
            this.unit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number_MouseDown);
            // 
            // hundred
            // 
            this.hundred.BackColor = System.Drawing.Color.DarkGray;
            this.hundred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hundred.Location = new System.Drawing.Point(645, 505);
            this.hundred.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hundred.Name = "hundred";
            this.hundred.Size = new System.Drawing.Size(15, 19);
            this.hundred.TabIndex = 16;
            this.hundred.TabStop = false;
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.Color.Maroon;
            this.ten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ten.Location = new System.Drawing.Point(660, 505);
            this.ten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(15, 19);
            this.ten.TabIndex = 15;
            this.ten.TabStop = false;
            // 
            // million
            // 
            this.million.BackColor = System.Drawing.Color.Salmon;
            this.million.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.million.Location = new System.Drawing.Point(616, 505);
            this.million.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.million.Name = "million";
            this.million.Size = new System.Drawing.Size(15, 19);
            this.million.TabIndex = 14;
            this.million.TabStop = false;
            // 
            // thousand
            // 
            this.thousand.BackColor = System.Drawing.Color.Red;
            this.thousand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thousand.Location = new System.Drawing.Point(631, 505);
            this.thousand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thousand.Name = "thousand";
            this.thousand.Size = new System.Drawing.Size(15, 19);
            this.thousand.TabIndex = 13;
            this.thousand.TabStop = false;
            // 
            // main_image
            // 
            this.main_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_image.Location = new System.Drawing.Point(16, 15);
            this.main_image.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.main_image.Name = "main_image";
            this.main_image.Size = new System.Drawing.Size(791, 406);
            this.main_image.TabIndex = 0;
            this.main_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(11, 434);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "輸入圖片資料夾路徑";
            // 
            // image_url
            // 
            this.image_url.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.image_url.Location = new System.Drawing.Point(248, 432);
            this.image_url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.image_url.Name = "image_url";
            this.image_url.Size = new System.Drawing.Size(412, 34);
            this.image_url.TabIndex = 23;
            // 
            // loadBtn
            // 
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loadBtn.Location = new System.Drawing.Point(668, 433);
            this.loadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(100, 34);
            this.loadBtn.TabIndex = 24;
            this.loadBtn.Text = "讀取";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadFile);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearBtn.Location = new System.Drawing.Point(400, 475);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 34);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "清除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(11, 520);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "圖片縮放";
            // 
            // newSize
            // 
            this.newSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newSize.Location = new System.Drawing.Point(128, 519);
            this.newSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newSize.Name = "newSize";
            this.newSize.Size = new System.Drawing.Size(132, 34);
            this.newSize.TabIndex = 29;
            // 
            // changeSizeBtn
            // 
            this.changeSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeSizeBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeSizeBtn.Location = new System.Drawing.Point(268, 519);
            this.changeSizeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeSizeBtn.Name = "changeSizeBtn";
            this.changeSizeBtn.Size = new System.Drawing.Size(100, 34);
            this.changeSizeBtn.TabIndex = 30;
            this.changeSizeBtn.Text = "修改";
            this.changeSizeBtn.UseVisualStyleBackColor = true;
            this.changeSizeBtn.Click += new System.EventHandler(this.changeSize);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 570);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.changeSizeBtn);
            this.Controls.Add(this.thousand);
            this.Controls.Add(this.newSize);
            this.Controls.Add(this.million);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hundred);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.ten_million);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.image_url);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excuteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.main_image);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "公里數改圖";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.ten_million)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.million)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thousand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox main_image;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox thousand;
        private System.Windows.Forms.PictureBox million;
        private System.Windows.Forms.PictureBox hundred;
        private System.Windows.Forms.PictureBox ten;
        private System.Windows.Forms.PictureBox unit;
        private System.Windows.Forms.Button excuteBtn;
        private System.Windows.Forms.PictureBox ten_million;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox image_url;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newSize;
        private System.Windows.Forms.Button changeSizeBtn;
    }
}

