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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.excuteBtn = new System.Windows.Forms.Button();
            this.image_url_label = new System.Windows.Forms.Label();
            this.image_url = new System.Windows.Forms.TextBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.newSize_label = new System.Windows.Forms.Label();
            this.newSize = new System.Windows.Forms.TextBox();
            this.changeSizeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.closeFormBtn = new System.Windows.Forms.Button();
            this.hideFormBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.main_image = new System.Windows.Forms.PictureBox();
            this.hundred = new System.Windows.Forms.PictureBox();
            this.unit = new System.Windows.Forms.PictureBox();
            this.ten_million = new System.Windows.Forms.PictureBox();
            this.thousand = new System.Windows.Forms.PictureBox();
            this.million = new System.Windows.Forms.PictureBox();
            this.ten = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.main_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_million)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thousand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.million)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten)).BeginInit();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input.Location = new System.Drawing.Point(128, 555);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 29);
            this.input.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 557);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入里程數";
            // 
            // excuteBtn
            // 
            this.excuteBtn.Enabled = false;
            this.excuteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excuteBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.excuteBtn.ForeColor = System.Drawing.Color.White;
            this.excuteBtn.Location = new System.Drawing.Point(233, 555);
            this.excuteBtn.Name = "excuteBtn";
            this.excuteBtn.Size = new System.Drawing.Size(75, 27);
            this.excuteBtn.TabIndex = 18;
            this.excuteBtn.Text = "執行";
            this.excuteBtn.UseVisualStyleBackColor = true;
            this.excuteBtn.Click += new System.EventHandler(this.excute);
            // 
            // image_url_label
            // 
            this.image_url_label.AutoSize = true;
            this.image_url_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.image_url_label.ForeColor = System.Drawing.Color.White;
            this.image_url_label.Location = new System.Drawing.Point(22, 518);
            this.image_url_label.Name = "image_url_label";
            this.image_url_label.Size = new System.Drawing.Size(181, 24);
            this.image_url_label.TabIndex = 22;
            this.image_url_label.Text = "輸入圖片資料夾路徑";
            // 
            // image_url
            // 
            this.image_url.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.image_url.Location = new System.Drawing.Point(209, 516);
            this.image_url.Name = "image_url";
            this.image_url.Size = new System.Drawing.Size(473, 29);
            this.image_url.TabIndex = 23;
            // 
            // loadBtn
            // 
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.Location = new System.Drawing.Point(687, 516);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 27);
            this.loadBtn.TabIndex = 24;
            this.loadBtn.Text = "讀取";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadFile);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(314, 555);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 27);
            this.clearBtn.TabIndex = 25;
            this.clearBtn.Text = "清除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clear);
            // 
            // newSize_label
            // 
            this.newSize_label.AutoSize = true;
            this.newSize_label.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newSize_label.ForeColor = System.Drawing.Color.White;
            this.newSize_label.Location = new System.Drawing.Point(22, 594);
            this.newSize_label.Name = "newSize_label";
            this.newSize_label.Size = new System.Drawing.Size(86, 24);
            this.newSize_label.TabIndex = 28;
            this.newSize_label.Text = "圖片縮放";
            // 
            // newSize
            // 
            this.newSize.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.newSize.Location = new System.Drawing.Point(110, 593);
            this.newSize.Name = "newSize";
            this.newSize.Size = new System.Drawing.Size(100, 29);
            this.newSize.TabIndex = 29;
            // 
            // changeSizeBtn
            // 
            this.changeSizeBtn.Enabled = false;
            this.changeSizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSizeBtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.changeSizeBtn.ForeColor = System.Drawing.Color.White;
            this.changeSizeBtn.Location = new System.Drawing.Point(215, 594);
            this.changeSizeBtn.Name = "changeSizeBtn";
            this.changeSizeBtn.Size = new System.Drawing.Size(75, 27);
            this.changeSizeBtn.TabIndex = 30;
            this.changeSizeBtn.Text = "修改";
            this.changeSizeBtn.UseVisualStyleBackColor = true;
            this.changeSizeBtn.Click += new System.EventHandler(this.changeSize);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(697, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "↑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.numberMoveUp);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(697, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 32;
            this.button2.Text = "↓";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.numberMoveDown);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(661, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 33;
            this.button3.Text = "←";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.numberMoveLeft);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(733, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 34;
            this.button4.Text = "→";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.numberMoveRight);
            // 
            // closeFormBtn
            // 
            this.closeFormBtn.BackColor = System.Drawing.Color.DimGray;
            this.closeFormBtn.FlatAppearance.BorderSize = 0;
            this.closeFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFormBtn.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeFormBtn.ForeColor = System.Drawing.Color.White;
            this.closeFormBtn.Location = new System.Drawing.Point(743, 6);
            this.closeFormBtn.Name = "closeFormBtn";
            this.closeFormBtn.Size = new System.Drawing.Size(25, 30);
            this.closeFormBtn.TabIndex = 35;
            this.closeFormBtn.Text = "╳";
            this.closeFormBtn.UseVisualStyleBackColor = false;
            this.closeFormBtn.Click += new System.EventHandler(this.closeFormBtn_Click);
            // 
            // hideFormBtn
            // 
            this.hideFormBtn.BackColor = System.Drawing.Color.DimGray;
            this.hideFormBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hideFormBtn.FlatAppearance.BorderSize = 0;
            this.hideFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideFormBtn.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hideFormBtn.ForeColor = System.Drawing.Color.White;
            this.hideFormBtn.Location = new System.Drawing.Point(712, 6);
            this.hideFormBtn.Name = "hideFormBtn";
            this.hideFormBtn.Size = new System.Drawing.Size(25, 30);
            this.hideFormBtn.TabIndex = 36;
            this.hideFormBtn.Text = "─";
            this.hideFormBtn.UseVisualStyleBackColor = false;
            this.hideFormBtn.Click += new System.EventHandler(this.hideFormBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon2";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "公里數改圖工具";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 39);
            this.panel1.TabIndex = 38;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.form_MouseUp);
            // 
            // main_image
            // 
            this.main_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.main_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_image.Location = new System.Drawing.Point(12, 44);
            this.main_image.Name = "main_image";
            this.main_image.Size = new System.Drawing.Size(751, 465);
            this.main_image.TabIndex = 0;
            this.main_image.TabStop = false;
            // 
            // hundred
            // 
            this.hundred.BackColor = System.Drawing.Color.Transparent;
            this.hundred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hundred.Location = new System.Drawing.Point(506, 555);
            this.hundred.Margin = new System.Windows.Forms.Padding(0);
            this.hundred.Name = "hundred";
            this.hundred.Size = new System.Drawing.Size(19, 26);
            this.hundred.TabIndex = 16;
            this.hundred.TabStop = false;
            // 
            // unit
            // 
            this.unit.BackColor = System.Drawing.Color.Transparent;
            this.unit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.unit.Location = new System.Drawing.Point(542, 555);
            this.unit.Margin = new System.Windows.Forms.Padding(0);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(19, 26);
            this.unit.TabIndex = 17;
            this.unit.TabStop = false;
            this.unit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.number_MouseDown);
            // 
            // ten_million
            // 
            this.ten_million.BackColor = System.Drawing.Color.Transparent;
            this.ten_million.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ten_million.Location = new System.Drawing.Point(452, 555);
            this.ten_million.Margin = new System.Windows.Forms.Padding(0);
            this.ten_million.Name = "ten_million";
            this.ten_million.Size = new System.Drawing.Size(19, 26);
            this.ten_million.TabIndex = 21;
            this.ten_million.TabStop = false;
            // 
            // thousand
            // 
            this.thousand.BackColor = System.Drawing.Color.Transparent;
            this.thousand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thousand.Location = new System.Drawing.Point(488, 555);
            this.thousand.Margin = new System.Windows.Forms.Padding(0);
            this.thousand.Name = "thousand";
            this.thousand.Size = new System.Drawing.Size(19, 26);
            this.thousand.TabIndex = 13;
            this.thousand.TabStop = false;
            // 
            // million
            // 
            this.million.BackColor = System.Drawing.Color.Transparent;
            this.million.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.million.Location = new System.Drawing.Point(470, 555);
            this.million.Margin = new System.Windows.Forms.Padding(0);
            this.million.Name = "million";
            this.million.Size = new System.Drawing.Size(19, 26);
            this.million.TabIndex = 14;
            this.million.TabStop = false;
            // 
            // ten
            // 
            this.ten.BackColor = System.Drawing.Color.Transparent;
            this.ten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ten.Location = new System.Drawing.Point(524, 555);
            this.ten.Margin = new System.Windows.Forms.Padding(0);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(19, 26);
            this.ten.TabIndex = 15;
            this.ten.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(775, 634);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.million);
            this.Controls.Add(this.hideFormBtn);
            this.Controls.Add(this.thousand);
            this.Controls.Add(this.closeFormBtn);
            this.Controls.Add(this.ten_million);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.hundred);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeSizeBtn);
            this.Controls.Add(this.newSize);
            this.Controls.Add(this.newSize_label);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.image_url);
            this.Controls.Add(this.image_url_label);
            this.Controls.Add(this.excuteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.main_image);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "公里數改圖";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.main_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hundred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_million)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thousand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.million)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox main_image;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excuteBtn;
        private System.Windows.Forms.Label image_url_label;
        private System.Windows.Forms.TextBox image_url;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label newSize_label;
        private System.Windows.Forms.TextBox newSize;
        private System.Windows.Forms.Button changeSizeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button closeFormBtn;
        private System.Windows.Forms.Button hideFormBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox hundred;
        private System.Windows.Forms.PictureBox unit;
        private System.Windows.Forms.PictureBox ten_million;
        private System.Windows.Forms.PictureBox thousand;
        private System.Windows.Forms.PictureBox million;
        private System.Windows.Forms.PictureBox ten;
    }
}

