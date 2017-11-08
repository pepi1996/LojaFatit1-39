namespace LojaFatitForm1_39
{
    partial class OpenGjiro
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
            this.btnHapeGjiro = new System.Windows.Forms.Button();
            this.txtEmri = new System.Windows.Forms.TextBox();
            this.Emr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGjiro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridGjirot = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGjirot)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHapeGjiro
            // 
            this.btnHapeGjiro.Location = new System.Drawing.Point(182, 194);
            this.btnHapeGjiro.Name = "btnHapeGjiro";
            this.btnHapeGjiro.Size = new System.Drawing.Size(91, 31);
            this.btnHapeGjiro.TabIndex = 2;
            this.btnHapeGjiro.Text = "Hape gjiron";
            this.btnHapeGjiro.UseVisualStyleBackColor = true;
            this.btnHapeGjiro.Click += new System.EventHandler(this.btnHapeGjiro_Click);
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(128, 94);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(200, 20);
            this.txtEmri.TabIndex = 0;
            // 
            // Emr
            // 
            this.Emr.AutoSize = true;
            this.Emr.Location = new System.Drawing.Point(50, 101);
            this.Emr.Name = "Emr";
            this.Emr.Size = new System.Drawing.Size(62, 13);
            this.Emr.TabIndex = 5;
            this.Emr.Text = "Emri i gjiros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // dataGjiro
            // 
            this.dataGjiro.Location = new System.Drawing.Point(128, 138);
            this.dataGjiro.Name = "dataGjiro";
            this.dataGjiro.Size = new System.Drawing.Size(200, 20);
            this.dataGjiro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data e gjiros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hape Gjiron";
            // 
            // dataGridGjirot
            // 
            this.dataGridGjirot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGjirot.Location = new System.Drawing.Point(12, 263);
            this.dataGridGjirot.Name = "dataGridGjirot";
            this.dataGridGjirot.Size = new System.Drawing.Size(427, 150);
            this.dataGridGjirot.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "<--  &Kthehu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HapjaGjiros
            // 
            this.AcceptButton = this.btnHapeGjiro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridGjirot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGjiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emr);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.btnHapeGjiro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HapjaGjiros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gjiro";
            this.Load += new System.EventHandler(this.Gjiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGjirot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapeGjiro;
        private System.Windows.Forms.TextBox txtEmri;
        private System.Windows.Forms.Label Emr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataGjiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridGjirot;
        private System.Windows.Forms.Button button1;
    }
}