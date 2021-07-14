
namespace Projekat1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.radioButtonMusko = new System.Windows.Forms.RadioButton();
            this.radioButtonZensko = new System.Windows.Forms.RadioButton();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonIzbriši = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1115, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Pol,
            this.Student});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(560, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 125;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 125;
            // 
            // Pol
            // 
            this.Pol.HeaderText = "Pol";
            this.Pol.MinimumWidth = 6;
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Width = 125;
            // 
            // Student
            // 
            this.Student.HeaderText = "Student";
            this.Student.MinimumWidth = 6;
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            this.Student.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonZensko, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxPrezime, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelIme, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIme, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonMusko, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonDodaj, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonIzbriši, 2, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.83784F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.8018F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(551, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // labelIme
            // 
            this.labelIme.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(146, 20);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(34, 17);
            this.labelIme.TabIndex = 0;
            this.labelIme.Text = "Ime:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pol:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime:";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxIme, 2);
            this.textBoxIme.Location = new System.Drawing.Point(206, 17);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(322, 22);
            this.textBoxIme.TabIndex = 4;
            this.textBoxIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBoxPrezime, 2);
            this.textBoxPrezime.Location = new System.Drawing.Point(206, 105);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(322, 22);
            this.textBoxPrezime.TabIndex = 5;
            this.textBoxPrezime.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButtonMusko
            // 
            this.radioButtonMusko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMusko.AutoSize = true;
            this.radioButtonMusko.Location = new System.Drawing.Point(239, 210);
            this.radioButtonMusko.Name = "radioButtonMusko";
            this.radioButtonMusko.Size = new System.Drawing.Size(70, 21);
            this.radioButtonMusko.TabIndex = 6;
            this.radioButtonMusko.TabStop = true;
            this.radioButtonMusko.Text = "Muško";
            this.radioButtonMusko.UseVisualStyleBackColor = true;
            // 
            // radioButtonZensko
            // 
            this.radioButtonZensko.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonZensko.AutoSize = true;
            this.radioButtonZensko.Location = new System.Drawing.Point(420, 210);
            this.radioButtonZensko.Name = "radioButtonZensko";
            this.radioButtonZensko.Size = new System.Drawing.Size(76, 21);
            this.radioButtonZensko.TabIndex = 7;
            this.radioButtonZensko.TabStop = true;
            this.radioButtonZensko.Text = "Žensko";
            this.radioButtonZensko.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(250, 299);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(49, 21);
            this.checkBox.TabIndex = 8;
            this.checkBox.Text = "DA";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDodaj.Location = new System.Drawing.Point(237, 375);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 48);
            this.buttonDodaj.TabIndex = 9;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonIzbriši
            // 
            this.buttonIzbriši.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIzbriši.Location = new System.Drawing.Point(421, 375);
            this.buttonIzbriši.Name = "buttonIzbriši";
            this.buttonIzbriši.Size = new System.Drawing.Size(75, 48);
            this.buttonIzbriši.TabIndex = 10;
            this.buttonIzbriši.Text = "Izbriši";
            this.buttonIzbriši.UseVisualStyleBackColor = true;
            this.buttonIzbriši.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Student;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.RadioButton radioButtonZensko;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.RadioButton radioButtonMusko;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonIzbriši;
    }
}

