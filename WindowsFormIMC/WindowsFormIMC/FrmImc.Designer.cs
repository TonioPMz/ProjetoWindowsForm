namespace WindowsFormIMC
{
    partial class FrmImc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImc));
            btnImc = new Button();
            lbPeso = new Label();
            txtPeso = new TextBox();
            lbAltura = new Label();
            txtAltura = new TextBox();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnImc
            // 
            btnImc.Location = new Point(195, 84);
            btnImc.Name = "btnImc";
            btnImc.Size = new Size(86, 21);
            btnImc.TabIndex = 0;
            btnImc.Text = "Calcular";
            btnImc.UseVisualStyleBackColor = true;
            btnImc.Click += btnImc_Click;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(123, 14);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(39, 14);
            lbPeso.TabIndex = 1;
            lbPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(167, 12);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Informe o Peso";
            txtPeso.Size = new Size(114, 22);
            txtPeso.TabIndex = 2;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(115, 41);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(47, 14);
            lbAltura.TabIndex = 3;
            lbAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(167, 41);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "Informe a Altura";
            txtAltura.Size = new Size(114, 22);
            txtAltura.TabIndex = 4;
            // 
            // pbLogo
            // 
            pbLogo.BorderStyle = BorderStyle.FixedSingle;
            pbLogo.Image = Properties.Resources.add;
            pbLogo.Location = new Point(14, 11);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(93, 94);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // FrmImc
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(302, 123);
            Controls.Add(pbLogo);
            Controls.Add(txtAltura);
            Controls.Add(lbAltura);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            Controls.Add(btnImc);
            DoubleBuffered = true;
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmImc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImc;
        private Label lbPeso;
        private TextBox txtPeso;
        private Label lbAltura;
        private TextBox txtAltura;
        private PictureBox pbLogo;
    }
}
