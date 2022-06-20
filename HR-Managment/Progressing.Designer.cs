namespace HR_Managment
{
    partial class Progressing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Progressing));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.thecircporgrs = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.thecircporgrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "تصميم وتنفيذ مشروع ادارة موارد بشرية";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(186, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project By : Ali Muhsan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(96, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supervisor : Assist.Prof. Imad Matti Bakko";
            // 
            // thecircporgrs
            // 
            this.thecircporgrs.Controls.Add(this.guna2CirclePictureBox2);
            this.thecircporgrs.FillThickness = 10;
            this.thecircporgrs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.thecircporgrs.ForeColor = System.Drawing.Color.White;
            this.thecircporgrs.InnerColor = System.Drawing.Color.White;
            this.thecircporgrs.Location = new System.Drawing.Point(211, 58);
            this.thecircporgrs.Minimum = 0;
            this.thecircporgrs.Name = "thecircporgrs";
            this.thecircporgrs.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.thecircporgrs.ProgressColor2 = System.Drawing.Color.LightSkyBlue;
            this.thecircporgrs.ProgressThickness = 12;
            this.thecircporgrs.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.thecircporgrs.ShadowDecoration.Parent = this.thecircporgrs;
            this.thecircporgrs.Size = new System.Drawing.Size(210, 210);
            this.thecircporgrs.TabIndex = 3;
            this.thecircporgrs.Text = "guna2CircleProgressBar1";
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(41, 49);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.ShadowDecoration.Parent = this.guna2CirclePictureBox2;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(125, 111);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox2.TabIndex = 4;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Progressing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 354);
            this.Controls.Add(this.thecircporgrs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Progressing";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Progressing_Load);
            this.thecircporgrs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar thecircporgrs;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

