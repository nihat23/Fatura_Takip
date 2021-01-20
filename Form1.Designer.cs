
namespace Fatura_Takip
{
    partial class Form1Sil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Sil));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1Ekle = new System.Windows.Forms.Button();
            this.button3Duzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6ToplamTutar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7Bugun_Tarih = new System.Windows.Forms.Label();
            this.button1Sil = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(217, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 27);
            this.textBox1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(219, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(219, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(215, 27);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(219, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fatura Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fatura Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(21, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fatura Son Ödeme Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(107, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fatura Tutar :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 202);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1Ekle
            // 
            this.button1Ekle.BackColor = System.Drawing.Color.Crimson;
            this.button1Ekle.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1Ekle.ForeColor = System.Drawing.SystemColors.Window;
            this.button1Ekle.Location = new System.Drawing.Point(13, 193);
            this.button1Ekle.Name = "button1Ekle";
            this.button1Ekle.Size = new System.Drawing.Size(134, 32);
            this.button1Ekle.TabIndex = 9;
            this.button1Ekle.Text = "Fatura Ekle";
            this.button1Ekle.UseVisualStyleBackColor = false;
            this.button1Ekle.Click += new System.EventHandler(this.button1Ekle_Click);
            // 
            // button3Duzenle
            // 
            this.button3Duzenle.BackColor = System.Drawing.Color.Crimson;
            this.button3Duzenle.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.button3Duzenle.ForeColor = System.Drawing.SystemColors.Control;
            this.button3Duzenle.Location = new System.Drawing.Point(359, 193);
            this.button3Duzenle.Name = "button3Duzenle";
            this.button3Duzenle.Size = new System.Drawing.Size(160, 32);
            this.button3Duzenle.TabIndex = 11;
            this.button3Duzenle.Text = "Fatura Güncelle";
            this.button3Duzenle.UseVisualStyleBackColor = false;
            this.button3Duzenle.Click += new System.EventHandler(this.button3Duzenle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(14, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Toplam Fatura Tutar :";
            // 
            // label6ToplamTutar
            // 
            this.label6ToplamTutar.AutoSize = true;
            this.label6ToplamTutar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6ToplamTutar.Location = new System.Drawing.Point(182, 447);
            this.label6ToplamTutar.Name = "label6ToplamTutar";
            this.label6ToplamTutar.Size = new System.Drawing.Size(27, 19);
            this.label6ToplamTutar.TabIndex = 13;
            this.label6ToplamTutar.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(525, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bugünku Tarih";
            // 
            // label7Bugun_Tarih
            // 
            this.label7Bugun_Tarih.AutoSize = true;
            this.label7Bugun_Tarih.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7Bugun_Tarih.ForeColor = System.Drawing.Color.Crimson;
            this.label7Bugun_Tarih.Location = new System.Drawing.Point(537, 206);
            this.label7Bugun_Tarih.Name = "label7Bugun_Tarih";
            this.label7Bugun_Tarih.Size = new System.Drawing.Size(21, 19);
            this.label7Bugun_Tarih.TabIndex = 15;
            this.label7Bugun_Tarih.Text = "__";
            // 
            // button1Sil
            // 
            this.button1Sil.BackColor = System.Drawing.Color.Crimson;
            this.button1Sil.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1Sil.ForeColor = System.Drawing.SystemColors.Window;
            this.button1Sil.Location = new System.Drawing.Point(189, 193);
            this.button1Sil.Name = "button1Sil";
            this.button1Sil.Size = new System.Drawing.Size(134, 32);
            this.button1Sil.TabIndex = 16;
            this.button1Sil.Text = "Fatura Sil";
            this.button1Sil.UseVisualStyleBackColor = false;
            this.button1Sil.Click += new System.EventHandler(this.button1Sil_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(615, 450);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nihat Beyi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1Sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(699, 473);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1Sil);
            this.Controls.Add(this.label7Bugun_Tarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label6ToplamTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3Duzenle);
            this.Controls.Add(this.button1Ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1Sil";
            this.Text = "Fatuta Takip Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1Ekle;
        private System.Windows.Forms.Button button3Duzenle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6ToplamTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7Bugun_Tarih;
        private System.Windows.Forms.Button button1Sil;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

