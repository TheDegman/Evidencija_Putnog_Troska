
namespace Evidencija_Putnog_Troska
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UNOS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MJESEC = new System.Windows.Forms.NumericUpDown();
            this.GODINA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.KM_Dolazak = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.KM_Odlazak = new System.Windows.Forms.NumericUpDown();
            this.d = new System.Windows.Forms.Label();
            this.PrijevoznoSredtsvo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DATUM = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Naknada = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.BrDana = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MJESEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GODINA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KM_Dolazak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KM_Odlazak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Naknada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrDana)).BeginInit();
            this.SuspendLayout();
            // 
            // UNOS
            // 
            this.UNOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNOS.Location = new System.Drawing.Point(209, 216);
            this.UNOS.Name = "UNOS";
            this.UNOS.Size = new System.Drawing.Size(161, 43);
            this.UNOS.TabIndex = 0;
            this.UNOS.Text = "Unos u tablicu";
            this.UNOS.UseVisualStyleBackColor = true;
            this.UNOS.Click += new System.EventHandler(this.UNOS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime i prezime zaposlenika";
            // 
            // IME
            // 
            this.IME.Location = new System.Drawing.Point(14, 35);
            this.IME.Name = "IME";
            this.IME.Size = new System.Drawing.Size(124, 20);
            this.IME.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mjesec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Godina";
            // 
            // MJESEC
            // 
            this.MJESEC.Location = new System.Drawing.Point(14, 93);
            this.MJESEC.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.MJESEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MJESEC.Name = "MJESEC";
            this.MJESEC.Size = new System.Drawing.Size(85, 20);
            this.MJESEC.TabIndex = 5;
            this.MJESEC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GODINA
            // 
            this.GODINA.Location = new System.Drawing.Point(112, 93);
            this.GODINA.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.GODINA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GODINA.Name = "GODINA";
            this.GODINA.Size = new System.Drawing.Size(85, 20);
            this.GODINA.TabIndex = 6;
            this.GODINA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Broj prijeđenih kilometara pri dolasku\r\n\r\n\r\n";
            // 
            // KM_Dolazak
            // 
            this.KM_Dolazak.Location = new System.Drawing.Point(321, 93);
            this.KM_Dolazak.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.KM_Dolazak.Name = "KM_Dolazak";
            this.KM_Dolazak.Size = new System.Drawing.Size(112, 20);
            this.KM_Dolazak.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Broj prijeđenih kilometara pri odlasku";
            // 
            // KM_Odlazak
            // 
            this.KM_Odlazak.Location = new System.Drawing.Point(509, 93);
            this.KM_Odlazak.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.KM_Odlazak.Name = "KM_Odlazak";
            this.KM_Odlazak.Size = new System.Drawing.Size(120, 20);
            this.KM_Odlazak.TabIndex = 10;
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(664, 74);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(99, 13);
            this.d.TabIndex = 11;
            this.d.Text = "Prijevozno sredstvo";
            // 
            // PrijevoznoSredtsvo
            // 
            this.PrijevoznoSredtsvo.Location = new System.Drawing.Point(667, 92);
            this.PrijevoznoSredtsvo.Name = "PrijevoznoSredtsvo";
            this.PrijevoznoSredtsvo.Size = new System.Drawing.Size(120, 20);
            this.PrijevoznoSredtsvo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Datum podnošenja izvješća";
            // 
            // DATUM
            // 
            this.DATUM.Location = new System.Drawing.Point(14, 160);
            this.DATUM.Name = "DATUM";
            this.DATUM.Size = new System.Drawing.Size(138, 20);
            this.DATUM.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Naknada po prijeđenom kilometru";
            // 
            // Naknada
            // 
            this.Naknada.Location = new System.Drawing.Point(158, 160);
            this.Naknada.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Naknada.Name = "Naknada";
            this.Naknada.Size = new System.Drawing.Size(131, 20);
            this.Naknada.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(403, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Brisanje unesenog";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Broj dana";
            // 
            // BrDana
            // 
            this.BrDana.Location = new System.Drawing.Point(205, 93);
            this.BrDana.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.BrDana.Name = "BrDana";
            this.BrDana.Size = new System.Drawing.Size(83, 20);
            this.BrDana.TabIndex = 19;
            this.BrDana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.BrDana);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Naknada);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DATUM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrijevoznoSredtsvo);
            this.Controls.Add(this.d);
            this.Controls.Add(this.KM_Odlazak);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KM_Dolazak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GODINA);
            this.Controls.Add(this.MJESEC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UNOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Evidencija o putnom trošku";
            ((System.ComponentModel.ISupportInitialize)(this.MJESEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GODINA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KM_Dolazak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KM_Odlazak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Naknada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrDana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UNOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown MJESEC;
        private System.Windows.Forms.NumericUpDown GODINA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown KM_Dolazak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown KM_Odlazak;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox PrijevoznoSredtsvo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DATUM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Naknada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown BrDana;
    }
}

