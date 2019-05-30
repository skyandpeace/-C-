namespace WindowsFormsApp4
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
            this.picboxplayer = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picboxcom = new System.Windows.Forms.PictureBox();
            this.msktext = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.listresult = new System.Windows.Forms.ListBox();
            this.picpusheen = new System.Windows.Forms.PictureBox();
            this.pusheen = new System.Windows.Forms.ImageList(this.components);
            this.piclbl = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpusheen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclbl)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxplayer
            // 
            this.picboxplayer.Location = new System.Drawing.Point(78, 84);
            this.picboxplayer.Name = "picboxplayer";
            this.picboxplayer.Size = new System.Drawing.Size(144, 118);
            this.picboxplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxplayer.TabIndex = 0;
            this.picboxplayer.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "下載 (2).jpg");
            this.imageList1.Images.SetKeyName(1, "下載.jpg");
            this.imageList1.Images.SetKeyName(2, "下載 (1).jpg");
            // 
            // picboxcom
            // 
            this.picboxcom.Location = new System.Drawing.Point(516, 84);
            this.picboxcom.Name = "picboxcom";
            this.picboxcom.Size = new System.Drawing.Size(144, 118);
            this.picboxcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxcom.TabIndex = 1;
            this.picboxcom.TabStop = false;
            // 
            // msktext
            // 
            this.msktext.Location = new System.Drawing.Point(188, 225);
            this.msktext.Mask = "0";
            this.msktext.Name = "msktext";
            this.msktext.PasswordChar = '*';
            this.msktext.Size = new System.Drawing.Size(30, 22);
            this.msktext.TabIndex = 2;
            this.msktext.TextChanged += new System.EventHandler(this.msktext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "請輸入數字(0,1,2)";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(325, 132);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(33, 12);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "label2";
            this.lbltime.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(121, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "玩家";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(567, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "電腦";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(327, 289);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "確定";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // listresult
            // 
            this.listresult.FormattingEnabled = true;
            this.listresult.ItemHeight = 12;
            this.listresult.Location = new System.Drawing.Point(516, 249);
            this.listresult.Name = "listresult";
            this.listresult.Size = new System.Drawing.Size(144, 124);
            this.listresult.TabIndex = 8;
            // 
            // picpusheen
            // 
            this.picpusheen.Location = new System.Drawing.Point(58, 262);
            this.picpusheen.Name = "picpusheen";
            this.picpusheen.Size = new System.Drawing.Size(202, 159);
            this.picpusheen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpusheen.TabIndex = 9;
            this.picpusheen.TabStop = false;
            // 
            // pusheen
            // 
            this.pusheen.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pusheen.ImageStream")));
            this.pusheen.TransparentColor = System.Drawing.Color.Transparent;
            this.pusheen.Images.SetKeyName(0, "tenor (1).gif");
            this.pusheen.Images.SetKeyName(1, "tenor.gif");
            this.pusheen.Images.SetKeyName(2, "CoolBigheartedHen-size_restricted.gif");
            this.pusheen.Images.SetKeyName(3, "giphy.gif");
            // 
            // piclbl
            // 
            this.piclbl.Location = new System.Drawing.Point(272, 88);
            this.piclbl.Name = "piclbl";
            this.piclbl.Size = new System.Drawing.Size(202, 159);
            this.piclbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclbl.TabIndex = 10;
            this.piclbl.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picpusheen);
            this.Controls.Add(this.listresult);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msktext);
            this.Controls.Add(this.picboxcom);
            this.Controls.Add(this.picboxplayer);
            this.Controls.Add(this.piclbl);
            this.Name = "Form1";
            this.Text = "剪刀、石頭、布互動遊戲";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxcom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpusheen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piclbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxplayer;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picboxcom;
        private System.Windows.Forms.MaskedTextBox msktext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.ListBox listresult;
        private System.Windows.Forms.PictureBox picpusheen;
        private System.Windows.Forms.ImageList pusheen;
        private System.Windows.Forms.PictureBox piclbl;
    }
}

