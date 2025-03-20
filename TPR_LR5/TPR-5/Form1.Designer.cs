
namespace LR5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nudAlternative = new System.Windows.Forms.NumericUpDown();
            nudCrit = new System.Windows.Forms.NumericUpDown();
            btnCalculate = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgwСrit = new System.Windows.Forms.DataGridView();
            dgwFunc = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cbCriteria = new System.Windows.Forms.ComboBox();
            cbFunction = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            btnSetCrit = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblQ = new System.Windows.Forms.Label();
            lblS = new System.Windows.Forms.Label();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            groupBox1 = new System.Windows.Forms.GroupBox();
            nudS = new System.Windows.Forms.NumericUpDown();
            nudQ = new System.Windows.Forms.NumericUpDown();
            nudWeight = new System.Windows.Forms.NumericUpDown();
            groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudAlternative).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCrit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwСrit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwFunc).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // nudAlternative
            // 
            nudAlternative.Location = new System.Drawing.Point(129, 32);
            nudAlternative.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            nudAlternative.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAlternative.Name = "nudAlternative";
            nudAlternative.Size = new System.Drawing.Size(57, 23);
            nudAlternative.TabIndex = 2;
            nudAlternative.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nudCrit
            // 
            nudCrit.Location = new System.Drawing.Point(129, 66);
            nudCrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            nudCrit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCrit.Name = "nudCrit";
            nudCrit.Size = new System.Drawing.Size(57, 23);
            nudCrit.TabIndex = 3;
            nudCrit.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new System.Drawing.Point(12, 462);
            btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new System.Drawing.Size(1115, 37);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Рассчитать альтернативы";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 15);
            label1.TabIndex = 6;
            label1.Text = "Кол-во альтернатив";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 68);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(106, 15);
            label2.TabIndex = 7;
            label2.Text = "Кол-во критериев";
            // 
            // dgwСrit
            // 
            dgwСrit.AllowUserToAddRows = false;
            dgwСrit.AllowUserToDeleteRows = false;
            dgwСrit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgwСrit.BackgroundColor = System.Drawing.Color.White;
            dgwСrit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwСrit.Location = new System.Drawing.Point(11, 162);
            dgwСrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgwСrit.Name = "dgwСrit";
            dgwСrit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwСrit.RowTemplate.Height = 29;
            dgwСrit.Size = new System.Drawing.Size(445, 284);
            dgwСrit.TabIndex = 8;
            // 
            // dgwFunc
            // 
            dgwFunc.AllowUserToAddRows = false;
            dgwFunc.AllowUserToDeleteRows = false;
            dgwFunc.BackgroundColor = System.Drawing.Color.White;
            dgwFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgwFunc.Location = new System.Drawing.Point(488, 162);
            dgwFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgwFunc.Name = "dgwFunc";
            dgwFunc.ReadOnly = true;
            dgwFunc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgwFunc.RowTemplate.Height = 29;
            dgwFunc.Size = new System.Drawing.Size(640, 284);
            dgwFunc.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Функция";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Q";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "S";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Вес критерия";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cbCriteria
            // 
            cbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCriteria.FormattingEnabled = true;
            cbCriteria.Location = new System.Drawing.Point(6, 45);
            cbCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbCriteria.Name = "cbCriteria";
            cbCriteria.Size = new System.Drawing.Size(136, 23);
            cbCriteria.TabIndex = 10;
            // 
            // cbFunction
            // 
            cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFunction.FormattingEnabled = true;
            cbFunction.Items.AddRange(new object[] { "Обычная функция", "U-образная функция", "V-образная функция", "Уровневая функция", "V-образная функция с порогами безразличия" });
            cbFunction.Location = new System.Drawing.Point(253, 44);
            cbFunction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbFunction.Name = "cbFunction";
            cbFunction.Size = new System.Drawing.Size(362, 23);
            cbFunction.TabIndex = 12;
            cbFunction.SelectedIndexChanged += cbFunction_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(224, 44);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(136, 36);
            button1.TabIndex = 15;
            button1.Text = "Создать таблицу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += onCreateTable;
            // 
            // btnSetCrit
            // 
            btnSetCrit.Location = new System.Drawing.Point(506, 91);
            btnSetCrit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSetCrit.Name = "btnSetCrit";
            btnSetCrit.Size = new System.Drawing.Size(109, 31);
            btnSetCrit.TabIndex = 16;
            btnSetCrit.Text = "Задать";
            btnSetCrit.UseVisualStyleBackColor = true;
            btnSetCrit.Click += btnSetCrit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 17;
            label3.Text = "Критерий";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(151, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(26, 15);
            label4.TabIndex = 18;
            label4.Text = "Вес";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(253, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(55, 15);
            label5.TabIndex = 19;
            label5.Text = "Функция";
            // 
            // lblQ
            // 
            lblQ.AutoSize = true;
            lblQ.Location = new System.Drawing.Point(6, 80);
            lblQ.Name = "lblQ";
            lblQ.Size = new System.Drawing.Size(16, 15);
            lblQ.TabIndex = 21;
            lblQ.Text = "Q";
            // 
            // lblS
            // 
            lblS.AutoSize = true;
            lblS.Location = new System.Drawing.Point(79, 80);
            lblS.Name = "lblS";
            lblS.Size = new System.Drawing.Size(13, 15);
            lblS.TabIndex = 23;
            lblS.Text = "S";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1139, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += Load_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += Save_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudS);
            groupBox1.Controls.Add(btnSetCrit);
            groupBox1.Controls.Add(nudQ);
            groupBox1.Controls.Add(lblS);
            groupBox1.Controls.Add(nudWeight);
            groupBox1.Controls.Add(lblQ);
            groupBox1.Controls.Add(cbCriteria);
            groupBox1.Controls.Add(cbFunction);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new System.Drawing.Point(488, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(639, 130);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задание критерия";
            // 
            // nudS
            // 
            nudS.DecimalPlaces = 2;
            nudS.Location = new System.Drawing.Point(79, 97);
            nudS.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudS.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            nudS.Name = "nudS";
            nudS.Size = new System.Drawing.Size(67, 23);
            nudS.TabIndex = 21;
            // 
            // nudQ
            // 
            nudQ.DecimalPlaces = 2;
            nudQ.Location = new System.Drawing.Point(6, 97);
            nudQ.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudQ.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            nudQ.Name = "nudQ";
            nudQ.Size = new System.Drawing.Size(67, 23);
            nudQ.TabIndex = 21;
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 2;
            nudWeight.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudWeight.Location = new System.Drawing.Point(151, 45);
            nudWeight.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new System.Drawing.Size(96, 23);
            nudWeight.TabIndex = 21;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(nudAlternative);
            groupBox2.Controls.Add(nudCrit);
            groupBox2.Location = new System.Drawing.Point(12, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(444, 121);
            groupBox2.TabIndex = 26;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задание альтернатив";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(1139, 510);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgwFunc);
            Controls.Add(dgwСrit);
            Controls.Add(btnCalculate);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Метод PROMETHEE";
            ((System.ComponentModel.ISupportInitialize)nudAlternative).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCrit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwСrit).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwFunc).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudS).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudAlternative;
        private System.Windows.Forms.NumericUpDown nudCrit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCriteria;
        //private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSetCrit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgwСrit;
        private System.Windows.Forms.DataGridView dgwFunc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.NumericUpDown nudQ;
        private System.Windows.Forms.NumericUpDown nudS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

