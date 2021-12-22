namespace KatzeMaus1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Mauseloch = new System.Windows.Forms.PictureBox();
            this.Katze = new System.Windows.Forms.PictureBox();
            this.Maus = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Mauseloch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Katze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maus)).BeginInit();
            this.SuspendLayout();
            // 
            // Mauseloch
            // 
            this.Mauseloch.Image = ((System.Drawing.Image)(resources.GetObject("Mauseloch.Image")));
            this.Mauseloch.Location = new System.Drawing.Point(12, 12);
            this.Mauseloch.Name = "Mauseloch";
            this.Mauseloch.Size = new System.Drawing.Size(160, 153);
            this.Mauseloch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Mauseloch.TabIndex = 0;
            this.Mauseloch.TabStop = false;
            // 
            // Katze
            // 
            this.Katze.Image = ((System.Drawing.Image)(resources.GetObject("Katze.Image")));
            this.Katze.InitialImage = ((System.Drawing.Image)(resources.GetObject("Katze.InitialImage")));
            this.Katze.Location = new System.Drawing.Point(12, 12);
            this.Katze.Name = "Katze";
            this.Katze.Size = new System.Drawing.Size(138, 113);
            this.Katze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Katze.TabIndex = 1;
            this.Katze.TabStop = false;
            // 
            // Maus
            // 
            this.Maus.Image = ((System.Drawing.Image)(resources.GetObject("Maus.Image")));
            this.Maus.Location = new System.Drawing.Point(673, 324);
            this.Maus.Name = "Maus";
            this.Maus.Size = new System.Drawing.Size(115, 114);
            this.Maus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maus.TabIndex = 2;
            this.Maus.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Katze:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Maus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(713, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(274, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maus);
            this.Controls.Add(this.Katze);
            this.Controls.Add(this.Mauseloch);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Mauseloch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Katze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Mauseloch;
        private System.Windows.Forms.PictureBox Katze;
        private System.Windows.Forms.PictureBox Maus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}