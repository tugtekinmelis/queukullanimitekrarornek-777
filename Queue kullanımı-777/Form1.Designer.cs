namespace Queue_kullanımı_777
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnAl = new System.Windows.Forms.Button();
            this.btnGetir = new System.Windows.Forms.Button();
            this.lblSira1 = new System.Windows.Forms.Label();
            this.btnGetir2 = new System.Windows.Forms.Button();
            this.btnGetir3 = new System.Windows.Forms.Button();
            this.lblSira2 = new System.Windows.Forms.Label();
            this.lblSira3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(65, 237);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(569, 24);
            this.txtAd.TabIndex = 0;
            // 
            // btnAl
            // 
            this.btnAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAl.Location = new System.Drawing.Point(65, 284);
            this.btnAl.Name = "btnAl";
            this.btnAl.Size = new System.Drawing.Size(569, 107);
            this.btnAl.TabIndex = 1;
            this.btnAl.Text = "Sıra Al";
            this.btnAl.UseVisualStyleBackColor = true;
            this.btnAl.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(115, 157);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(127, 51);
            this.btnGetir.TabIndex = 2;
            this.btnGetir.Text = "GİŞE 1";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lblSira1
            // 
            this.lblSira1.AutoSize = true;
            this.lblSira1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira1.Location = new System.Drawing.Point(112, 92);
            this.lblSira1.Name = "lblSira1";
            this.lblSira1.Size = new System.Drawing.Size(52, 18);
            this.lblSira1.TabIndex = 3;
            this.lblSira1.Text = "label1";
            // 
            // btnGetir2
            // 
            this.btnGetir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir2.Location = new System.Drawing.Point(277, 157);
            this.btnGetir2.Name = "btnGetir2";
            this.btnGetir2.Size = new System.Drawing.Size(127, 51);
            this.btnGetir2.TabIndex = 4;
            this.btnGetir2.Text = "GİŞE 2";
            this.btnGetir2.UseVisualStyleBackColor = true;
            this.btnGetir2.Click += new System.EventHandler(this.btnGetir2_Click);
            // 
            // btnGetir3
            // 
            this.btnGetir3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir3.Location = new System.Drawing.Point(440, 157);
            this.btnGetir3.Name = "btnGetir3";
            this.btnGetir3.Size = new System.Drawing.Size(127, 51);
            this.btnGetir3.TabIndex = 5;
            this.btnGetir3.Text = "GİŞE 3";
            this.btnGetir3.UseVisualStyleBackColor = true;
            this.btnGetir3.Click += new System.EventHandler(this.btnGetir3_Click);
            // 
            // lblSira2
            // 
            this.lblSira2.AutoSize = true;
            this.lblSira2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira2.Location = new System.Drawing.Point(274, 92);
            this.lblSira2.Name = "lblSira2";
            this.lblSira2.Size = new System.Drawing.Size(52, 18);
            this.lblSira2.TabIndex = 6;
            this.lblSira2.Text = "label1";
            // 
            // lblSira3
            // 
            this.lblSira3.AutoSize = true;
            this.lblSira3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSira3.Location = new System.Drawing.Point(437, 92);
            this.lblSira3.Name = "lblSira3";
            this.lblSira3.Size = new System.Drawing.Size(52, 18);
            this.lblSira3.TabIndex = 7;
            this.lblSira3.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSira3);
            this.Controls.Add(this.lblSira2);
            this.Controls.Add(this.btnGetir3);
            this.Controls.Add(this.btnGetir2);
            this.Controls.Add(this.lblSira1);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.btnAl);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnAl;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label lblSira1;
        private System.Windows.Forms.Button btnGetir2;
        private System.Windows.Forms.Button btnGetir3;
        private System.Windows.Forms.Label lblSira2;
        private System.Windows.Forms.Label lblSira3;
    }
}

