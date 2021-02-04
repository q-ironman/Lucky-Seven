
namespace Lucky_Seven
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picBox_firstPic = new System.Windows.Forms.PictureBox();
            this.picBox_secondPic = new System.Windows.Forms.PictureBox();
            this.picBox_thirdPic = new System.Windows.Forms.PictureBox();
            this.picsList = new System.Windows.Forms.ImageList(this.components);
            this.button_Spin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtboxScore = new System.Windows.Forms.TextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.ımageListButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_firstPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_secondPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_thirdPic)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_firstPic
            // 
            this.picBox_firstPic.Image = ((System.Drawing.Image)(resources.GetObject("picBox_firstPic.Image")));
            this.picBox_firstPic.Location = new System.Drawing.Point(72, 12);
            this.picBox_firstPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_firstPic.Name = "picBox_firstPic";
            this.picBox_firstPic.Size = new System.Drawing.Size(171, 315);
            this.picBox_firstPic.TabIndex = 0;
            this.picBox_firstPic.TabStop = false;
            // 
            // picBox_secondPic
            // 
            this.picBox_secondPic.Image = ((System.Drawing.Image)(resources.GetObject("picBox_secondPic.Image")));
            this.picBox_secondPic.Location = new System.Drawing.Point(263, 12);
            this.picBox_secondPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_secondPic.Name = "picBox_secondPic";
            this.picBox_secondPic.Size = new System.Drawing.Size(171, 315);
            this.picBox_secondPic.TabIndex = 1;
            this.picBox_secondPic.TabStop = false;
            // 
            // picBox_thirdPic
            // 
            this.picBox_thirdPic.Image = ((System.Drawing.Image)(resources.GetObject("picBox_thirdPic.Image")));
            this.picBox_thirdPic.Location = new System.Drawing.Point(453, 12);
            this.picBox_thirdPic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox_thirdPic.Name = "picBox_thirdPic";
            this.picBox_thirdPic.Size = new System.Drawing.Size(171, 315);
            this.picBox_thirdPic.TabIndex = 2;
            this.picBox_thirdPic.TabStop = false;
            // 
            // picsList
            // 
            this.picsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("picsList.ImageStream")));
            this.picsList.TransparentColor = System.Drawing.Color.Transparent;
            this.picsList.Images.SetKeyName(0, "apple.jpg");
            this.picsList.Images.SetKeyName(1, "applegreen.jpg");
            this.picsList.Images.SetKeyName(2, "banana.jpg");
            this.picsList.Images.SetKeyName(3, "cherry.jpg");
            this.picsList.Images.SetKeyName(4, "pomegranate.jpg");
            this.picsList.Images.SetKeyName(5, "seven.png");
            this.picsList.Images.SetKeyName(6, "strawberry.jpg");
            this.picsList.Images.SetKeyName(7, "watermelon.jpg");
            // 
            // button_Spin
            // 
            this.button_Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Spin.Image = ((System.Drawing.Image)(resources.GetObject("button_Spin.Image")));
            this.button_Spin.Location = new System.Drawing.Point(652, 14);
            this.button_Spin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Spin.Name = "button_Spin";
            this.button_Spin.Size = new System.Drawing.Size(85, 315);
            this.button_Spin.TabIndex = 3;
            this.button_Spin.UseVisualStyleBackColor = true;
            this.button_Spin.Click += new System.EventHandler(this.button_Spin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtboxScore
            // 
            this.txtboxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxScore.Location = new System.Drawing.Point(352, 332);
            this.txtboxScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxScore.Name = "txtboxScore";
            this.txtboxScore.Size = new System.Drawing.Size(80, 34);
            this.txtboxScore.TabIndex = 4;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(192, 337);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(146, 29);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "Your Score: ";
            // 
            // ımageListButton
            // 
            this.ımageListButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListButton.ImageStream")));
            this.ımageListButton.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListButton.Images.SetKeyName(0, "arm.jpg");
            this.ımageListButton.Images.SetKeyName(1, "arm2.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.txtboxScore);
            this.Controls.Add(this.button_Spin);
            this.Controls.Add(this.picBox_thirdPic);
            this.Controls.Add(this.picBox_secondPic);
            this.Controls.Add(this.picBox_firstPic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Lucky Seven";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_firstPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_secondPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_thirdPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_firstPic;
        private System.Windows.Forms.PictureBox picBox_secondPic;
        private System.Windows.Forms.PictureBox picBox_thirdPic;
        private System.Windows.Forms.ImageList picsList;
        private System.Windows.Forms.Button button_Spin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtboxScore;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.ImageList ımageListButton;
    }
}

