namespace HR_Managment
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usertxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passtxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "تسجيل دخول ادارة موارد بشرية";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // usertxt
            // 
            this.usertxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usertxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.usertxt.HintForeColor = System.Drawing.Color.Empty;
            this.usertxt.HintText = "";
            this.usertxt.isPassword = false;
            this.usertxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.usertxt.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.usertxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.usertxt.LineThickness = 3;
            this.usertxt.Location = new System.Drawing.Point(309, 119);
            this.usertxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(383, 70);
            this.usertxt.TabIndex = 4;
            this.usertxt.Text = " ";
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(146, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "أسم ألمستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(146, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "الرقم السري";
            // 
            // passtxt
            // 
            this.passtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passtxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtxt.ForeColor = System.Drawing.Color.DodgerBlue;
            this.passtxt.HintForeColor = System.Drawing.Color.Empty;
            this.passtxt.HintText = "";
            this.passtxt.isPassword = true;
            this.passtxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.passtxt.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.passtxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passtxt.LineThickness = 3;
            this.passtxt.Location = new System.Drawing.Point(309, 197);
            this.passtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(383, 70);
            this.passtxt.TabIndex = 6;
            this.passtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passtxt.OnValueChanged += new System.EventHandler(this.passtxt_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 89);
            this.button1.TabIndex = 8;
            this.button1.Text = "تسجيل الدخول";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 89);
            this.button2.TabIndex = 9;
            this.button2.Text = "مسح الكتابة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(631, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 52);
            this.label10.TabIndex = 10;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 455);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passtxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
    }
}