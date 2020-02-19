namespace WFA_KararYapilari
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnek2 = new System.Windows.Forms.Button();
            this.btnOrnek3 = new System.Windows.Forms.Button();
            this.btnOrnek4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(399, 26);
            this.txtDeger.TabIndex = 0;
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek1.Location = new System.Drawing.Point(12, 44);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(399, 78);
            this.btnOrnek1.TabIndex = 1;
            this.btnOrnek1.Text = "Admin Kontrolü";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnek2
            // 
            this.btnOrnek2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek2.Location = new System.Drawing.Point(12, 128);
            this.btnOrnek2.Name = "btnOrnek2";
            this.btnOrnek2.Size = new System.Drawing.Size(399, 78);
            this.btnOrnek2.TabIndex = 1;
            this.btnOrnek2.Text = "Not Kontrolü";
            this.btnOrnek2.UseVisualStyleBackColor = true;
            this.btnOrnek2.Click += new System.EventHandler(this.btnOrnek2_Click);
            // 
            // btnOrnek3
            // 
            this.btnOrnek3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek3.Location = new System.Drawing.Point(12, 212);
            this.btnOrnek3.Name = "btnOrnek3";
            this.btnOrnek3.Size = new System.Drawing.Size(399, 78);
            this.btnOrnek3.TabIndex = 1;
            this.btnOrnek3.Text = "Çift - Tek Kontrolü";
            this.btnOrnek3.UseVisualStyleBackColor = true;
            this.btnOrnek3.Click += new System.EventHandler(this.btnOrnek3_Click);
            // 
            // btnOrnek4
            // 
            this.btnOrnek4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrnek4.Location = new System.Drawing.Point(12, 296);
            this.btnOrnek4.Name = "btnOrnek4";
            this.btnOrnek4.Size = new System.Drawing.Size(399, 78);
            this.btnOrnek4.TabIndex = 1;
            this.btnOrnek4.Text = "Değer Kontrolü";
            this.btnOrnek4.UseVisualStyleBackColor = true;
            this.btnOrnek4.Click += new System.EventHandler(this.btnOrnek4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 390);
            this.Controls.Add(this.btnOrnek4);
            this.Controls.Add(this.btnOrnek3);
            this.Controls.Add(this.btnOrnek2);
            this.Controls.Add(this.btnOrnek1);
            this.Controls.Add(this.txtDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnek2;
        private System.Windows.Forms.Button btnOrnek3;
        private System.Windows.Forms.Button btnOrnek4;
    }
}

