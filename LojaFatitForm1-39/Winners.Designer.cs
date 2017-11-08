namespace LojaFatitForm1_39
{
    partial class Winners
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgjiro = new System.Windows.Forms.Label();
            this.comboBoxGjiro = new System.Windows.Forms.ComboBox();
            this.comboBoxNrQellumeve = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKthehu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fituesit";
            // 
            // lblgjiro
            // 
            this.lblgjiro.AutoSize = true;
            this.lblgjiro.Location = new System.Drawing.Point(172, 142);
            this.lblgjiro.Name = "lblgjiro";
            this.lblgjiro.Size = new System.Drawing.Size(81, 13);
            this.lblgjiro.TabIndex = 2;
            this.lblgjiro.Text = " Nr i qelluareve:";
            // 
            // comboBoxGjiro
            // 
            this.comboBoxGjiro.FormattingEnabled = true;
            this.comboBoxGjiro.Location = new System.Drawing.Point(273, 105);
            this.comboBoxGjiro.Name = "comboBoxGjiro";
            this.comboBoxGjiro.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGjiro.TabIndex = 3;
            this.comboBoxGjiro.SelectedIndexChanged += new System.EventHandler(this.comboBoxGjiro_SelectedIndexChanged);
            // 
            // comboBoxNrQellumeve
            // 
            this.comboBoxNrQellumeve.FormattingEnabled = true;
            this.comboBoxNrQellumeve.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxNrQellumeve.Location = new System.Drawing.Point(273, 139);
            this.comboBoxNrQellumeve.Name = "comboBoxNrQellumeve";
            this.comboBoxNrQellumeve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNrQellumeve.TabIndex = 4;
            this.comboBoxNrQellumeve.SelectedIndexChanged += new System.EventHandler(this.comboBoxNrQellumeve_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gjiro:";
            // 
            // btnKthehu
            // 
            this.btnKthehu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKthehu.Location = new System.Drawing.Point(12, 12);
            this.btnKthehu.Name = "btnKthehu";
            this.btnKthehu.Size = new System.Drawing.Size(94, 31);
            this.btnKthehu.TabIndex = 6;
            this.btnKthehu.Text = "<--  &Kthehu";
            this.btnKthehu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKthehu.UseVisualStyleBackColor = true;
            this.btnKthehu.Click += new System.EventHandler(this.btnKthehu_Click);
            // 
            // Winners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 486);
            this.Controls.Add(this.btnKthehu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNrQellumeve);
            this.Controls.Add(this.comboBoxGjiro);
            this.Controls.Add(this.lblgjiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Winners";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Winners";
            this.Load += new System.EventHandler(this.Winners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgjiro;
        private System.Windows.Forms.ComboBox comboBoxGjiro;
        private System.Windows.Forms.ComboBox comboBoxNrQellumeve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKthehu;
    }
}