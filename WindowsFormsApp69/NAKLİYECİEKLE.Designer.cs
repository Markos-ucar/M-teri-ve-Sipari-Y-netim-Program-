namespace WindowsFormsApp69
{
    partial class NAKLİYECİEKLE
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
            this.SİRKETADİBTN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NAKLİYECİEKLEBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SİRKETADİBTN
            // 
            this.SİRKETADİBTN.AutoSize = true;
            this.SİRKETADİBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SİRKETADİBTN.Location = new System.Drawing.Point(40, 60);
            this.SİRKETADİBTN.Name = "SİRKETADİBTN";
            this.SİRKETADİBTN.Size = new System.Drawing.Size(117, 20);
            this.SİRKETADİBTN.TabIndex = 0;
            this.SİRKETADİBTN.Text = "ŞİRKET ADİ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TELEFON ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 22);
            this.textBox2.TabIndex = 3;
            // 
            // NAKLİYECİEKLEBTN
            // 
            this.NAKLİYECİEKLEBTN.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NAKLİYECİEKLEBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NAKLİYECİEKLEBTN.Location = new System.Drawing.Point(92, 158);
            this.NAKLİYECİEKLEBTN.Name = "NAKLİYECİEKLEBTN";
            this.NAKLİYECİEKLEBTN.Size = new System.Drawing.Size(226, 50);
            this.NAKLİYECİEKLEBTN.TabIndex = 4;
            this.NAKLİYECİEKLEBTN.Text = "NAKLİYECİ EKLE";
            this.NAKLİYECİEKLEBTN.UseVisualStyleBackColor = false;
            this.NAKLİYECİEKLEBTN.Click += new System.EventHandler(this.NAKLİYECİEKLEBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(485, 202);
            this.dataGridView1.TabIndex = 5;
            // 
            // NAKLİYECİEKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NAKLİYECİEKLEBTN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SİRKETADİBTN);
            this.Name = "NAKLİYECİEKLE";
            this.Text = "NAKLİYECİEKLE";
            this.Load += new System.EventHandler(this.NAKLİYECİEKLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SİRKETADİBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button NAKLİYECİEKLEBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}