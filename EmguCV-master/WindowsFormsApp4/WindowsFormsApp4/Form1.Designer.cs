namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.OriginalImageBox = new Emgu.CV.UI.ImageBox();
            this.TriangleandRectangleImageBox = new Emgu.CV.UI.ImageBox();
            this.CircleImageBox = new Emgu.CV.UI.ImageBox();
            this.LineImageBox = new Emgu.CV.UI.ImageBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleandRectangleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LoadImageButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 57);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "File :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(83, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(334, 15);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 2;
            this.LoadImageButton.Text = "...";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // OriginalImageBox
            // 
            this.OriginalImageBox.Location = new System.Drawing.Point(12, 82);
            this.OriginalImageBox.Name = "OriginalImageBox";
            this.OriginalImageBox.Size = new System.Drawing.Size(387, 325);
            this.OriginalImageBox.TabIndex = 2;
            this.OriginalImageBox.TabStop = false;
            // 
            // TriangleandRectangleImageBox
            // 
            this.TriangleandRectangleImageBox.Location = new System.Drawing.Point(405, 82);
            this.TriangleandRectangleImageBox.Name = "TriangleandRectangleImageBox";
            this.TriangleandRectangleImageBox.Size = new System.Drawing.Size(387, 325);
            this.TriangleandRectangleImageBox.TabIndex = 3;
            this.TriangleandRectangleImageBox.TabStop = false;
            // 
            // CircleImageBox
            // 
            this.CircleImageBox.Location = new System.Drawing.Point(12, 434);
            this.CircleImageBox.Name = "CircleImageBox";
            this.CircleImageBox.Size = new System.Drawing.Size(387, 325);
            this.CircleImageBox.TabIndex = 4;
            this.CircleImageBox.TabStop = false;
            // 
            // LineImageBox
            // 
            this.LineImageBox.Location = new System.Drawing.Point(405, 434);
            this.LineImageBox.Name = "LineImageBox";
            this.LineImageBox.Size = new System.Drawing.Size(387, 325);
            this.LineImageBox.TabIndex = 5;
            this.LineImageBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Original Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Detected Triangle and Rectangle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detected Circle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Detected Lines";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 771);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LineImageBox);
            this.Controls.Add(this.CircleImageBox);
            this.Controls.Add(this.TriangleandRectangleImageBox);
            this.Controls.Add(this.OriginalImageBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TriangleandRectangleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox OriginalImageBox;
        private Emgu.CV.UI.ImageBox TriangleandRectangleImageBox;
        private Emgu.CV.UI.ImageBox CircleImageBox;
        private Emgu.CV.UI.ImageBox LineImageBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

