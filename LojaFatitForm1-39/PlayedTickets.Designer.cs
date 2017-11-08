namespace LojaFatitForm1_39
{
    partial class PlayedTickets
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
            this.comboBoxGjiro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridTiketatLuajtura = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiketatLuajtura)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGjiro
            // 
            this.comboBoxGjiro.FormattingEnabled = true;
            this.comboBoxGjiro.Location = new System.Drawing.Point(89, 92);
            this.comboBoxGjiro.Name = "comboBoxGjiro";
            this.comboBoxGjiro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGjiro.TabIndex = 0;
            this.comboBoxGjiro.SelectedIndexChanged += new System.EventHandler(this.comboBoxGjiro_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gjiro: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiketat e Luajtura";
            // 
            // dataGridTiketatLuajtura
            // 
            this.dataGridTiketatLuajtura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTiketatLuajtura.Location = new System.Drawing.Point(12, 138);
            this.dataGridTiketatLuajtura.Name = "dataGridTiketatLuajtura";
            this.dataGridTiketatLuajtura.Size = new System.Drawing.Size(934, 261);
            this.dataGridTiketatLuajtura.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 41;
            this.button1.Text = "<--  Kthehu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 411);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridTiketatLuajtura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGjiro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayedTickets";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiketatLuajtura";
            this.Load += new System.EventHandler(this.TiketatLuajtura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTiketatLuajtura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGjiro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridTiketatLuajtura;
        private System.Windows.Forms.Button button1;
    }
}