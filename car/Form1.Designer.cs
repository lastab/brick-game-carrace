namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.carl = new System.Windows.Forms.PictureBox();
            this.carm = new System.Windows.Forms.PictureBox();
            this.carr = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // carl
            // 
            this.carl.Image = ((System.Drawing.Image)(resources.GetObject("carl.Image")));
            this.carl.InitialImage = ((System.Drawing.Image)(resources.GetObject("carl.InitialImage")));
            this.carl.Location = new System.Drawing.Point(-3, 0);
            this.carl.Name = "carl";
            this.carl.Size = new System.Drawing.Size(149, 173);
            this.carl.TabIndex = 1;
            this.carl.TabStop = false;
            // 
            // carm
            // 
            this.carm.Image = ((System.Drawing.Image)(resources.GetObject("carm.Image")));
            this.carm.InitialImage = ((System.Drawing.Image)(resources.GetObject("carm.InitialImage")));
            this.carm.Location = new System.Drawing.Point(152, 0);
            this.carm.Name = "carm";
            this.carm.Size = new System.Drawing.Size(149, 173);
            this.carm.TabIndex = 4;
            this.carm.TabStop = false;
            // 
            // carr
            // 
            this.carr.Image = ((System.Drawing.Image)(resources.GetObject("carr.Image")));
            this.carr.InitialImage = ((System.Drawing.Image)(resources.GetObject("carr.InitialImage")));
            this.carr.Location = new System.Drawing.Point(296, 489);
            this.carr.Name = "carr";
            this.carr.Size = new System.Drawing.Size(149, 173);
            this.carr.TabIndex = 5;
            this.carr.TabStop = false;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.InitialImage = ((System.Drawing.Image)(resources.GetObject("player.InitialImage")));
            this.player.Location = new System.Drawing.Point(152, 331);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(149, 173);
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(55, 113);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(75, 38);
            this.btnleft.TabIndex = 7;
            this.btnleft.Text = "&a";
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnright
            // 
            this.btnright.Location = new System.Drawing.Point(332, 113);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(75, 38);
            this.btnright.TabIndex = 8;
            this.btnright.Text = "&s";
            this.btnright.UseVisualStyleBackColor = true;
            this.btnright.Click += new System.EventHandler(this.btnright_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnright);
            this.Controls.Add(this.btnleft);
            this.Controls.Add(this.player);
            this.Controls.Add(this.carr);
            this.Controls.Add(this.carm);
            this.Controls.Add(this.carl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carl;
        private System.Windows.Forms.PictureBox carm;
        private System.Windows.Forms.PictureBox carr;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

