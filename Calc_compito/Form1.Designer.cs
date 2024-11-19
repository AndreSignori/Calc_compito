namespace Calc_compito
{
    partial class Calcolatrice
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.titolo = new System.Windows.Forms.Label();
            this.lb_el1 = new System.Windows.Forms.Label();
            this.lb_el2 = new System.Windows.Forms.Label();
            this.nud_el1 = new System.Windows.Forms.NumericUpDown();
            this.nud_el2 = new System.Windows.Forms.NumericUpDown();
            this.lb__ris = new System.Windows.Forms.Label();
            this.lb_op = new System.Windows.Forms.Label();
            this.cb_op = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_el1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_el2)).BeginInit();
            this.SuspendLayout();
            // 
            // titolo
            // 
            this.titolo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titolo.AutoSize = true;
            this.titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.35F);
            this.titolo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titolo.Location = new System.Drawing.Point(225, 37);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(335, 47);
            this.titolo.TabIndex = 0;
            this.titolo.Text = "CALCOLATRICE";
            // 
            // lb_el1
            // 
            this.lb_el1.AutoSize = true;
            this.lb_el1.Location = new System.Drawing.Point(359, 113);
            this.lb_el1.Name = "lb_el1";
            this.lb_el1.Size = new System.Drawing.Size(60, 13);
            this.lb_el1.TabIndex = 1;
            this.lb_el1.Text = "Elemento 1";
            // 
            // lb_el2
            // 
            this.lb_el2.AutoSize = true;
            this.lb_el2.Location = new System.Drawing.Point(359, 165);
            this.lb_el2.Name = "lb_el2";
            this.lb_el2.Size = new System.Drawing.Size(60, 13);
            this.lb_el2.TabIndex = 2;
            this.lb_el2.Text = "Elemento 2";
            this.lb_el2.Click += new System.EventHandler(this.lb_el2_Click);
            // 
            // nud_el1
            // 
            this.nud_el1.Location = new System.Drawing.Point(327, 129);
            this.nud_el1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_el1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_el1.Name = "nud_el1";
            this.nud_el1.Size = new System.Drawing.Size(120, 20);
            this.nud_el1.TabIndex = 4;
            // 
            // nud_el2
            // 
            this.nud_el2.Location = new System.Drawing.Point(327, 181);
            this.nud_el2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_el2.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nud_el2.Name = "nud_el2";
            this.nud_el2.Size = new System.Drawing.Size(120, 20);
            this.nud_el2.TabIndex = 5;
            // 
            // lb__ris
            // 
            this.lb__ris.AutoSize = true;
            this.lb__ris.Location = new System.Drawing.Point(385, 332);
            this.lb__ris.Name = "lb__ris";
            this.lb__ris.Size = new System.Drawing.Size(0, 13);
            this.lb__ris.TabIndex = 6;
            this.lb__ris.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_op
            // 
            this.lb_op.AutoSize = true;
            this.lb_op.Location = new System.Drawing.Point(359, 213);
            this.lb_op.Name = "lb_op";
            this.lb_op.Size = new System.Drawing.Size(54, 13);
            this.lb_op.TabIndex = 7;
            this.lb_op.Text = "Operatore";
            this.lb_op.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_op
            // 
            this.cb_op.FormattingEnabled = true;
            this.cb_op.Items.AddRange(new object[] {
            "somma",
            "differenza",
            "moltiplicazione",
            "divisione"});
            this.cb_op.Location = new System.Drawing.Point(327, 237);
            this.cb_op.Name = "cb_op";
            this.cb_op.Size = new System.Drawing.Size(121, 21);
            this.cb_op.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Risultato\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calcolatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_op);
            this.Controls.Add(this.lb_op);
            this.Controls.Add(this.lb__ris);
            this.Controls.Add(this.nud_el2);
            this.Controls.Add(this.nud_el1);
            this.Controls.Add(this.lb_el2);
            this.Controls.Add(this.lb_el1);
            this.Controls.Add(this.titolo);
            this.Name = "Calcolatrice";
            this.Text = "Calcolatrice";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_el1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_el2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titolo;
        private System.Windows.Forms.Label lb_el1;
        private System.Windows.Forms.Label lb_el2;
        private System.Windows.Forms.NumericUpDown nud_el1;
        private System.Windows.Forms.NumericUpDown nud_el2;
        private System.Windows.Forms.Label lb__ris;
        private System.Windows.Forms.Label lb_op;
        private System.Windows.Forms.ComboBox cb_op;
        private System.Windows.Forms.Button button1;
    }
}

