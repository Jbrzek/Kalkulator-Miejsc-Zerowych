namespace Kalkulator_Miejsc_Zerowych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aInput = new System.Windows.Forms.NumericUpDown();
            this.bInput = new System.Windows.Forms.NumericUpDown();
            this.cInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.functionLabel = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.functionPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aInput
            // 
            this.aInput.Location = new System.Drawing.Point(80, 60);
            this.aInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.aInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.aInput.Name = "aInput";
            this.aInput.Size = new System.Drawing.Size(120, 20);
            this.aInput.TabIndex = 0;
            // 
            // bInput
            // 
            this.bInput.Location = new System.Drawing.Point(80, 90);
            this.bInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.bInput.Name = "bInput";
            this.bInput.Size = new System.Drawing.Size(120, 20);
            this.bInput.TabIndex = 1;
            // 
            // cInput
            // 
            this.cInput.Location = new System.Drawing.Point(80, 120);
            this.cInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cInput.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.cInput.Name = "cInput";
            this.cInput.Size = new System.Drawing.Size(120, 20);
            this.cInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Podaj a, b, c. Funkcji o wzorze f(x) = ax² + bx + c. Następnie aplikacja wyliczy " +
    "miejsca zerowe tej funkcji.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "c:";
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(54, 160);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(146, 31);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Oblicz";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(708, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Program nie przyjmuje liczb zmiennoprzecinkowych oraz 0 jako wartości. Liczby mus" +
    "zą być z zakresu od -1000 do 1000.";
            // 
            // functionLabel
            // 
            this.functionLabel.AutoSize = true;
            this.functionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionLabel.Location = new System.Drawing.Point(284, 56);
            this.functionLabel.Name = "functionLabel";
            this.functionLabel.Size = new System.Drawing.Size(0, 18);
            this.functionLabel.TabIndex = 9;
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outcomeLabel.Location = new System.Drawing.Point(284, 88);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(0, 18);
            this.outcomeLabel.TabIndex = 10;
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalLabel.Location = new System.Drawing.Point(284, 122);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(0, 18);
            this.intervalLabel.TabIndex = 11;
            // 
            // functionPictureBox
            // 
            this.functionPictureBox.Location = new System.Drawing.Point(287, 177);
            this.functionPictureBox.Name = "functionPictureBox";
            this.functionPictureBox.Size = new System.Drawing.Size(250, 150);
            this.functionPictureBox.TabIndex = 12;
            this.functionPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(890, 379);
            this.Controls.Add(this.functionPictureBox);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.functionLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cInput);
            this.Controls.Add(this.bInput);
            this.Controls.Add(this.aInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator Miejsc Zerowych";
            ((System.ComponentModel.ISupportInitialize)(this.aInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown aInput;
        private System.Windows.Forms.NumericUpDown bInput;
        private System.Windows.Forms.NumericUpDown cInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label functionLabel;
        private System.Windows.Forms.Label outcomeLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.PictureBox functionPictureBox;
    }
}

