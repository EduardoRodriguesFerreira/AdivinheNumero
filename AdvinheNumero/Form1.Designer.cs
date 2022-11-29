namespace AdvinheNumero
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTela = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblten = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTela
            // 
            this.lblTela.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTela.Location = new System.Drawing.Point(41, 136);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(367, 58);
            this.lblTela.TabIndex = 0;
            this.lblTela.Text = "ghfg";
            this.lblTela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTela.Visible = false;
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnum.Location = new System.Drawing.Point(54, 197);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(329, 50);
            this.txtnum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(148, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Iniciar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblten
            // 
            this.lblten.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblten.Location = new System.Drawing.Point(12, 394);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(425, 47);
            this.lblten.TabIndex = 3;
            this.lblten.Text = "Numero de tentativas ";
            this.lblten.Visible = false;
            // 
            // lblP
            // 
            this.lblP.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblP.Location = new System.Drawing.Point(41, 78);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(367, 58);
            this.lblP.TabIndex = 4;
            this.lblP.Text = "ghfgh";
            this.lblP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblP.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adivinhe o Número";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.lblTela);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTela;
        private TextBox txtnum;
        private Button button1;
        private Label lblten;
        private Label lblP;
        private Label label1;
    }
}