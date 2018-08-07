namespace Asul_de_pica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.AsWatch = new System.Windows.Forms.Timer(this.components);
            this.SecondAS = new System.Windows.Forms.Timer(this.components);
            this.CardFlip = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.END = new System.Windows.Forms.Timer(this.components);
            this.CF2 = new System.Windows.Forms.Timer(this.components);
            this.CF3 = new System.Windows.Forms.Timer(this.components);
            this.CfEnd = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ArrowDownShort = new System.Windows.Forms.PictureBox();
            this.ArrowUpShort = new System.Windows.Forms.PictureBox();
            this.ArrowDownLong = new System.Windows.Forms.PictureBox();
            this.ArrowUpLong = new System.Windows.Forms.PictureBox();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDownShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowUpShort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDownLong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowUpLong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gaseste Asul de pica!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apasa oriunde pentru a incepe!";
            // 
            // Restart
            // 
            this.Restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restart.Location = new System.Drawing.Point(88, 515);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(571, 38);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Visible = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // AsWatch
            // 
            this.AsWatch.Tick += new System.EventHandler(this.AsWatch_Tick);
            // 
            // SecondAS
            // 
            this.SecondAS.Interval = 2000;
            this.SecondAS.Tick += new System.EventHandler(this.SecondAS_Tick);
            // 
            // CardFlip
            // 
            this.CardFlip.Interval = 1000;
            this.CardFlip.Tick += new System.EventHandler(this.CardFlip_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // END
            // 
            this.END.Interval = 1000;
            this.END.Tick += new System.EventHandler(this.END_Tick);
            // 
            // CF2
            // 
            this.CF2.Interval = 900;
            this.CF2.Tick += new System.EventHandler(this.CF2_Tick);
            // 
            // CF3
            // 
            this.CF3.Interval = 800;
            this.CF3.Tick += new System.EventHandler(this.CF3_Tick);
            // 
            // CfEnd
            // 
            this.CfEnd.Interval = 700;
            this.CfEnd.Tick += new System.EventHandler(this.CfEnd_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ArrowDownShort
            // 
            this.ArrowDownShort.Location = new System.Drawing.Point(322, 383);
            this.ArrowDownShort.Name = "ArrowDownShort";
            this.ArrowDownShort.Size = new System.Drawing.Size(341, 112);
            this.ArrowDownShort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowDownShort.TabIndex = 8;
            this.ArrowDownShort.TabStop = false;
            this.ArrowDownShort.Visible = false;
            // 
            // ArrowUpShort
            // 
            this.ArrowUpShort.Location = new System.Drawing.Point(88, 85);
            this.ArrowUpShort.Name = "ArrowUpShort";
            this.ArrowUpShort.Size = new System.Drawing.Size(341, 112);
            this.ArrowUpShort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowUpShort.TabIndex = 7;
            this.ArrowUpShort.TabStop = false;
            this.ArrowUpShort.Visible = false;
            // 
            // ArrowDownLong
            // 
            this.ArrowDownLong.Location = new System.Drawing.Point(88, 383);
            this.ArrowDownLong.Name = "ArrowDownLong";
            this.ArrowDownLong.Size = new System.Drawing.Size(571, 112);
            this.ArrowDownLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowDownLong.TabIndex = 6;
            this.ArrowDownLong.TabStop = false;
            this.ArrowDownLong.Visible = false;
            // 
            // ArrowUpLong
            // 
            this.ArrowUpLong.Location = new System.Drawing.Point(88, 86);
            this.ArrowUpLong.Name = "ArrowUpLong";
            this.ArrowUpLong.Size = new System.Drawing.Size(571, 112);
            this.ArrowUpLong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ArrowUpLong.TabIndex = 5;
            this.ArrowUpLong.TabStop = false;
            this.ArrowUpLong.Visible = false;
            // 
            // C3
            // 
            this.C3.Enabled = false;
            this.C3.Image = global::Asul_de_pica.Properties.Resources.Fund;
            this.C3.Location = new System.Drawing.Point(558, 217);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(101, 147);
            this.C3.TabIndex = 4;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Visible = false;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // C2
            // 
            this.C2.Enabled = false;
            this.C2.Image = global::Asul_de_pica.Properties.Resources.Fund;
            this.C2.Location = new System.Drawing.Point(328, 217);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(101, 147);
            this.C2.TabIndex = 3;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Visible = false;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C1
            // 
            this.C1.Enabled = false;
            this.C1.Image = global::Asul_de_pica.Properties.Resources.Fund;
            this.C1.Location = new System.Drawing.Point(88, 217);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(101, 147);
            this.C1.TabIndex = 2;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Visible = false;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(746, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.ArrowDownShort);
            this.Controls.Add(this.ArrowUpShort);
            this.Controls.Add(this.ArrowDownLong);
            this.Controls.Add(this.ArrowUpLong);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Asul de pica";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDownShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowUpShort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowDownLong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowUpLong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.PictureBox ArrowUpLong;
        private System.Windows.Forms.PictureBox ArrowDownLong;
        private System.Windows.Forms.PictureBox ArrowUpShort;
        private System.Windows.Forms.PictureBox ArrowDownShort;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Timer AsWatch;
        private System.Windows.Forms.Timer SecondAS;
        private System.Windows.Forms.Timer CardFlip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer END;
        private System.Windows.Forms.Timer CF2;
        private System.Windows.Forms.Timer CF3;
        private System.Windows.Forms.Timer CfEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

