
namespace P3_4_1204045
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.jk = new System.Windows.Forms.ComboBox();
            this.tgl = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jadwal1 = new System.Windows.Forms.RadioButton();
            this.jadwal2 = new System.Windows.Forms.RadioButton();
            this.jadwal3 = new System.Windows.Forms.RadioButton();
            this.jadwal4 = new System.Windows.Forms.RadioButton();
            this.biola = new System.Windows.Forms.CheckBox();
            this.gitar = new System.Windows.Forms.CheckBox();
            this.saxophone = new System.Windows.Forms.CheckBox();
            this.konduktor = new System.Windows.Forms.CheckBox();
            this.piano = new System.Windows.Forms.CheckBox();
            this.drum = new System.Windows.Forms.CheckBox();
            this.vokal = new System.Windows.Forms.CheckBox();
            this.komposer = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Pendaftaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama               :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir   :";
            // 
            // nama
            // 
            this.nama.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(361, 69);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(200, 27);
            this.nama.TabIndex = 4;
            // 
            // jk
            // 
            this.jk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jk.FormattingEnabled = true;
            this.jk.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.jk.Location = new System.Drawing.Point(361, 107);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(200, 27);
            this.jk.TabIndex = 5;
            // 
            // tgl
            // 
            this.tgl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgl.Location = new System.Drawing.Point(361, 148);
            this.tgl.Name = "tgl";
            this.tgl.Size = new System.Drawing.Size(240, 27);
            this.tgl.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.komposer);
            this.groupBox1.Controls.Add(this.vokal);
            this.groupBox1.Controls.Add(this.drum);
            this.groupBox1.Controls.Add(this.piano);
            this.groupBox1.Controls.Add(this.konduktor);
            this.groupBox1.Controls.Add(this.saxophone);
            this.groupBox1.Controls.Add(this.gitar);
            this.groupBox1.Controls.Add(this.biola);
            this.groupBox1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 160);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jadwal4);
            this.groupBox2.Controls.Add(this.jadwal3);
            this.groupBox2.Controls.Add(this.jadwal2);
            this.groupBox2.Controls.Add(this.jadwal1);
            this.groupBox2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(460, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 160);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(426, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Keluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // jadwal1
            // 
            this.jadwal1.AutoSize = true;
            this.jadwal1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwal1.Location = new System.Drawing.Point(16, 19);
            this.jadwal1.Name = "jadwal1";
            this.jadwal1.Size = new System.Drawing.Size(160, 24);
            this.jadwal1.TabIndex = 0;
            this.jadwal1.TabStop = true;
            this.jadwal1.Text = "Senin dan Rabu : 14.00 - 16.00";
            this.jadwal1.UseVisualStyleBackColor = true;
            this.jadwal1.CheckedChanged += new System.EventHandler(this.jadwal1_CheckedChanged);
            // 
            // jadwal2
            // 
            this.jadwal2.AutoSize = true;
            this.jadwal2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwal2.Location = new System.Drawing.Point(16, 52);
            this.jadwal2.Name = "jadwal2";
            this.jadwal2.Size = new System.Drawing.Size(170, 24);
            this.jadwal2.TabIndex = 1;
            this.jadwal2.TabStop = true;
            this.jadwal2.Text = "Selasa dan Kamis : 14.00 - 16.00";
            this.jadwal2.UseVisualStyleBackColor = true;
            this.jadwal2.CheckedChanged += new System.EventHandler(this.jadwal2_CheckedChanged);
            // 
            // jadwal3
            // 
            this.jadwal3.AutoSize = true;
            this.jadwal3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwal3.Location = new System.Drawing.Point(16, 89);
            this.jadwal3.Name = "jadwal3";
            this.jadwal3.Size = new System.Drawing.Size(170, 24);
            this.jadwal3.TabIndex = 2;
            this.jadwal3.TabStop = true;
            this.jadwal3.Text = "Sabtu dan Minggu : 09.00 - 11.00";
            this.jadwal3.UseVisualStyleBackColor = true;
            this.jadwal3.CheckedChanged += new System.EventHandler(this.jadwal3_CheckedChanged);
            // 
            // jadwal4
            // 
            this.jadwal4.AutoSize = true;
            this.jadwal4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jadwal4.Location = new System.Drawing.Point(16, 130);
            this.jadwal4.Name = "jadwal4";
            this.jadwal4.Size = new System.Drawing.Size(125, 24);
            this.jadwal4.TabIndex = 3;
            this.jadwal4.TabStop = true;
            this.jadwal4.Text = "Minggu : 13.00 - 17.00";
            this.jadwal4.UseVisualStyleBackColor = true;
            this.jadwal4.CheckedChanged += new System.EventHandler(this.jadwal4_CheckedChanged);
            // 
            // biola
            // 
            this.biola.AutoSize = true;
            this.biola.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biola.Location = new System.Drawing.Point(20, 20);
            this.biola.Name = "biola";
            this.biola.Size = new System.Drawing.Size(48, 24);
            this.biola.TabIndex = 0;
            this.biola.Text = "Biola";
            this.biola.UseVisualStyleBackColor = true;
            this.biola.CheckedChanged += new System.EventHandler(this.biola_CheckedChanged);
            // 
            // gitar
            // 
            this.gitar.AutoSize = true;
            this.gitar.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gitar.Location = new System.Drawing.Point(20, 52);
            this.gitar.Name = "gitar";
            this.gitar.Size = new System.Drawing.Size(49, 24);
            this.gitar.TabIndex = 1;
            this.gitar.Text = "Gitar";
            this.gitar.UseVisualStyleBackColor = true;
            this.gitar.CheckedChanged += new System.EventHandler(this.gitar_CheckedChanged);
            // 
            // saxophone
            // 
            this.saxophone.AutoSize = true;
            this.saxophone.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saxophone.Location = new System.Drawing.Point(20, 89);
            this.saxophone.Name = "saxophone";
            this.saxophone.Size = new System.Drawing.Size(75, 24);
            this.saxophone.TabIndex = 2;
            this.saxophone.Text = "Saxophone";
            this.saxophone.UseVisualStyleBackColor = true;
            this.saxophone.CheckedChanged += new System.EventHandler(this.saxophone_CheckedChanged);
            // 
            // konduktor
            // 
            this.konduktor.AutoSize = true;
            this.konduktor.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konduktor.Location = new System.Drawing.Point(20, 130);
            this.konduktor.Name = "konduktor";
            this.konduktor.Size = new System.Drawing.Size(72, 24);
            this.konduktor.TabIndex = 3;
            this.konduktor.Text = "Konduktor";
            this.konduktor.UseVisualStyleBackColor = true;
            this.konduktor.CheckedChanged += new System.EventHandler(this.konduktor_CheckedChanged);
            // 
            // piano
            // 
            this.piano.AutoSize = true;
            this.piano.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piano.Location = new System.Drawing.Point(147, 20);
            this.piano.Name = "piano";
            this.piano.Size = new System.Drawing.Size(51, 24);
            this.piano.TabIndex = 4;
            this.piano.Text = "Piano";
            this.piano.UseVisualStyleBackColor = true;
            this.piano.CheckedChanged += new System.EventHandler(this.piano_CheckedChanged);
            // 
            // drum
            // 
            this.drum.AutoSize = true;
            this.drum.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drum.Location = new System.Drawing.Point(147, 52);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(52, 24);
            this.drum.TabIndex = 5;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            this.drum.CheckedChanged += new System.EventHandler(this.drum_CheckedChanged);
            // 
            // vokal
            // 
            this.vokal.AutoSize = true;
            this.vokal.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vokal.Location = new System.Drawing.Point(147, 89);
            this.vokal.Name = "vokal";
            this.vokal.Size = new System.Drawing.Size(51, 24);
            this.vokal.TabIndex = 6;
            this.vokal.Text = "Vokal";
            this.vokal.UseVisualStyleBackColor = true;
            this.vokal.CheckedChanged += new System.EventHandler(this.vokal_CheckedChanged);
            // 
            // komposer
            // 
            this.komposer.AutoSize = true;
            this.komposer.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.komposer.Location = new System.Drawing.Point(147, 130);
            this.komposer.Name = "komposer";
            this.komposer.Size = new System.Drawing.Size(72, 24);
            this.komposer.TabIndex = 7;
            this.komposer.Text = "Komposer";
            this.komposer.UseVisualStyleBackColor = true;
            this.komposer.CheckedChanged += new System.EventHandler(this.komposer_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tgl);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.ComboBox jk;
        private System.Windows.Forms.DateTimePicker tgl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox komposer;
        private System.Windows.Forms.CheckBox vokal;
        private System.Windows.Forms.CheckBox drum;
        private System.Windows.Forms.CheckBox piano;
        private System.Windows.Forms.CheckBox konduktor;
        private System.Windows.Forms.CheckBox saxophone;
        private System.Windows.Forms.CheckBox gitar;
        private System.Windows.Forms.CheckBox biola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton jadwal4;
        private System.Windows.Forms.RadioButton jadwal3;
        private System.Windows.Forms.RadioButton jadwal2;
        private System.Windows.Forms.RadioButton jadwal1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

