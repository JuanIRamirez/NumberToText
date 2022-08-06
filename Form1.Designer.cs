
namespace NumberToText
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNro = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.rbEsp = new System.Windows.Forms.RadioButton();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.tbNro = new System.Windows.Forms.NumericUpDown();
            this.btnTransc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbNro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(87, 67);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(54, 13);
            this.lblNro.TabIndex = 0;
            this.lblNro.Text = "Número #";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(172, 111);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.Size = new System.Drawing.Size(502, 185);
            this.tbText.TabIndex = 4;
            // 
            // rbEsp
            // 
            this.rbEsp.AutoSize = true;
            this.rbEsp.Checked = true;
            this.rbEsp.Location = new System.Drawing.Point(348, 67);
            this.rbEsp.Name = "rbEsp";
            this.rbEsp.Size = new System.Drawing.Size(63, 17);
            this.rbEsp.TabIndex = 1;
            this.rbEsp.TabStop = true;
            this.rbEsp.Text = "&Español";
            this.rbEsp.UseVisualStyleBackColor = true;
            this.rbEsp.CheckedChanged += new System.EventHandler(this.RbEsp_CheckedChanged);
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Location = new System.Drawing.Point(455, 67);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(59, 17);
            this.rbEng.TabIndex = 2;
            this.rbEng.Text = "E&nglish";
            this.rbEng.UseVisualStyleBackColor = true;
            this.rbEng.CheckedChanged += new System.EventHandler(this.RbEng_CheckedChanged);
            // 
            // tbNro
            // 
            this.tbNro.Location = new System.Drawing.Point(172, 64);
            this.tbNro.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.tbNro.Name = "tbNro";
            this.tbNro.Size = new System.Drawing.Size(120, 20);
            this.tbNro.TabIndex = 0;
            this.tbNro.ValueChanged += new System.EventHandler(this.TbNro_ValueChanged);
            // 
            // btnTransc
            // 
            this.btnTransc.Location = new System.Drawing.Point(599, 67);
            this.btnTransc.Name = "btnTransc";
            this.btnTransc.Size = new System.Drawing.Size(75, 23);
            this.btnTransc.TabIndex = 3;
            this.btnTransc.Text = "&Transcribir";
            this.btnTransc.UseVisualStyleBackColor = true;
            this.btnTransc.Click += new System.EventHandler(this.BtnTransc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 320);
            this.Controls.Add(this.btnTransc);
            this.Controls.Add(this.tbNro);
            this.Controls.Add(this.rbEng);
            this.Controls.Add(this.rbEsp);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblNro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Number to Text";
            ((System.ComponentModel.ISupportInitialize)(this.tbNro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNro;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.RadioButton rbEsp;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.NumericUpDown tbNro;
        private System.Windows.Forms.Button btnTransc;
    }
}

