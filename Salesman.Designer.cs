namespace lab1
{
    partial class Salesman
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pan_count = new System.Windows.Forms.Panel();
            this.num_count = new System.Windows.Forms.NumericUpDown();
            this.lab_count = new System.Windows.Forms.Label();
            this.but_countOK = new System.Windows.Forms.Button();
            this.radBut_hand = new System.Windows.Forms.RadioButton();
            this.pan_select = new System.Windows.Forms.Panel();
            this.grи_select = new System.Windows.Forms.GroupBox();
            this.radBut_rand = new System.Windows.Forms.RadioButton();
            this.lab_choose = new System.Windows.Forms.Label();
            this.but_selectOK = new System.Windows.Forms.Button();
            this.pan_way = new System.Windows.Forms.Panel();
            this.but_wayOK = new System.Windows.Forms.Button();
            this.pan_alg = new System.Windows.Forms.Panel();
            this.but_alg = new System.Windows.Forms.Button();
            this.GrVw = new System.Windows.Forms.DataGridView();
            this.pan_count.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).BeginInit();
            this.pan_select.SuspendLayout();
            this.grи_select.SuspendLayout();
            this.pan_way.SuspendLayout();
            this.pan_alg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrVw)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_count
            // 
            this.pan_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_count.Controls.Add(this.num_count);
            this.pan_count.Controls.Add(this.lab_count);
            this.pan_count.Controls.Add(this.but_countOK);
            this.pan_count.Location = new System.Drawing.Point(1, 3);
            this.pan_count.Name = "pan_count";
            this.pan_count.Size = new System.Drawing.Size(180, 83);
            this.pan_count.TabIndex = 0;
            // 
            // num_count
            // 
            this.num_count.Location = new System.Drawing.Point(25, 22);
            this.num_count.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_count.Name = "num_count";
            this.num_count.Size = new System.Drawing.Size(120, 20);
            this.num_count.TabIndex = 8;
            this.num_count.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_count.ValueChanged += new System.EventHandler(this.num_count_ValueChanged);
            // 
            // lab_count
            // 
            this.lab_count.AutoSize = true;
            this.lab_count.Location = new System.Drawing.Point(22, 6);
            this.lab_count.Name = "lab_count";
            this.lab_count.Size = new System.Drawing.Size(134, 13);
            this.lab_count.TabIndex = 1;
            this.lab_count.Text = "Количество городов (>1):";
            this.lab_count.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // but_countOK
            // 
            this.but_countOK.Location = new System.Drawing.Point(44, 48);
            this.but_countOK.Name = "but_countOK";
            this.but_countOK.Size = new System.Drawing.Size(79, 28);
            this.but_countOK.TabIndex = 2;
            this.but_countOK.Text = "OK";
            this.but_countOK.UseVisualStyleBackColor = true;
            this.but_countOK.Click += new System.EventHandler(this.but_countOK_Click);
            // 
            // radBut_hand
            // 
            this.radBut_hand.AutoSize = true;
            this.radBut_hand.Location = new System.Drawing.Point(6, 19);
            this.radBut_hand.Name = "radBut_hand";
            this.radBut_hand.Size = new System.Drawing.Size(66, 17);
            this.radBut_hand.TabIndex = 3;
            this.radBut_hand.TabStop = true;
            this.radBut_hand.Text = "вручную";
            this.radBut_hand.UseVisualStyleBackColor = true;
            this.radBut_hand.CheckedChanged += new System.EventHandler(this.radBut_hand_CheckedChanged);
            // 
            // pan_select
            // 
            this.pan_select.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_select.Controls.Add(this.grи_select);
            this.pan_select.Controls.Add(this.lab_choose);
            this.pan_select.Controls.Add(this.but_selectOK);
            this.pan_select.Enabled = false;
            this.pan_select.Location = new System.Drawing.Point(1, 92);
            this.pan_select.Name = "pan_select";
            this.pan_select.Size = new System.Drawing.Size(180, 147);
            this.pan_select.TabIndex = 2;
            // 
            // grи_select
            // 
            this.grи_select.Controls.Add(this.radBut_hand);
            this.grи_select.Controls.Add(this.radBut_rand);
            this.grи_select.Location = new System.Drawing.Point(6, 37);
            this.grи_select.Name = "grи_select";
            this.grи_select.Size = new System.Drawing.Size(158, 62);
            this.grи_select.TabIndex = 7;
            this.grи_select.TabStop = false;
            // 
            // radBut_rand
            // 
            this.radBut_rand.AutoSize = true;
            this.radBut_rand.Location = new System.Drawing.Point(6, 38);
            this.radBut_rand.Name = "radBut_rand";
            this.radBut_rand.Size = new System.Drawing.Size(115, 17);
            this.radBut_rand.TabIndex = 4;
            this.radBut_rand.TabStop = true;
            this.radBut_rand.Text = "случайно (random)";
            this.radBut_rand.UseVisualStyleBackColor = true;
            this.radBut_rand.CheckedChanged += new System.EventHandler(this.radRand_hand_CheckedChanged);
            // 
            // lab_choose
            // 
            this.lab_choose.AutoSize = true;
            this.lab_choose.Location = new System.Drawing.Point(10, 8);
            this.lab_choose.Name = "lab_choose";
            this.lab_choose.Size = new System.Drawing.Size(159, 26);
            this.lab_choose.TabIndex = 1;
            this.lab_choose.Text = "Как заполненить расстояния \r\nмежду городами?";
            this.lab_choose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // but_selectOK
            // 
            this.but_selectOK.Location = new System.Drawing.Point(43, 105);
            this.but_selectOK.Name = "but_selectOK";
            this.but_selectOK.Size = new System.Drawing.Size(82, 28);
            this.but_selectOK.TabIndex = 3;
            this.but_selectOK.Text = "OK";
            this.but_selectOK.UseVisualStyleBackColor = true;
            this.but_selectOK.Click += new System.EventHandler(this.but_selectOK_Click);
            // 
            // pan_way
            // 
            this.pan_way.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_way.Controls.Add(this.but_wayOK);
            this.pan_way.Location = new System.Drawing.Point(1, 245);
            this.pan_way.Name = "pan_way";
            this.pan_way.Size = new System.Drawing.Size(180, 65);
            this.pan_way.TabIndex = 5;
            // 
            // but_wayOK
            // 
            this.but_wayOK.Location = new System.Drawing.Point(18, 17);
            this.but_wayOK.Name = "but_wayOK";
            this.but_wayOK.Size = new System.Drawing.Size(151, 28);
            this.but_wayOK.TabIndex = 3;
            this.but_wayOK.Text = "Найти кратчайший путь\r\n";
            this.but_wayOK.UseVisualStyleBackColor = true;
            this.but_wayOK.Click += new System.EventHandler(this.but_wayOK_Click);
            // 
            // pan_alg
            // 
            this.pan_alg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_alg.Controls.Add(this.but_alg);
            this.pan_alg.Location = new System.Drawing.Point(1, 316);
            this.pan_alg.Name = "pan_alg";
            this.pan_alg.Size = new System.Drawing.Size(180, 74);
            this.pan_alg.TabIndex = 3;
            // 
            // but_alg
            // 
            this.but_alg.Location = new System.Drawing.Point(23, 16);
            this.but_alg.Name = "but_alg";
            this.but_alg.Size = new System.Drawing.Size(133, 39);
            this.but_alg.TabIndex = 7;
            this.but_alg.Text = "Сравнить скорости \r\nработы алгоритмов";
            this.but_alg.UseVisualStyleBackColor = true;
            this.but_alg.Click += new System.EventHandler(this.but_alg_Click);
            // 
            // GrVw
            // 
            this.GrVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrVw.Location = new System.Drawing.Point(187, 3);
            this.GrVw.Name = "GrVw";
            this.GrVw.RowHeadersWidth = 20;
            this.GrVw.Size = new System.Drawing.Size(444, 387);
            this.GrVw.TabIndex = 6;
            // 
            // Salesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 392);
            this.Controls.Add(this.GrVw);
            this.Controls.Add(this.pan_alg);
            this.Controls.Add(this.pan_way);
            this.Controls.Add(this.pan_select);
            this.Controls.Add(this.pan_count);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(649, 431);
            this.MinimumSize = new System.Drawing.Size(649, 431);
            this.Name = "Salesman";
            this.Text = "Коммивояжёр";
            this.pan_count.ResumeLayout(false);
            this.pan_count.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_count)).EndInit();
            this.pan_select.ResumeLayout(false);
            this.pan_select.PerformLayout();
            this.grи_select.ResumeLayout(false);
            this.grи_select.PerformLayout();
            this.pan_way.ResumeLayout(false);
            this.pan_alg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrVw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_count;
        private System.Windows.Forms.RadioButton radBut_hand;
        private System.Windows.Forms.Button but_countOK;
        private System.Windows.Forms.Label lab_count;
        private System.Windows.Forms.Panel pan_select;
        private System.Windows.Forms.Button but_selectOK;
        private System.Windows.Forms.RadioButton radBut_rand;
        private System.Windows.Forms.Panel pan_way;
        private System.Windows.Forms.Button but_wayOK;
        private System.Windows.Forms.Panel pan_alg;
        private System.Windows.Forms.Button but_alg;
        private System.Windows.Forms.GroupBox grи_select;
        private System.Windows.Forms.Label lab_choose;
        private System.Windows.Forms.DataGridView GrVw;
        private System.Windows.Forms.NumericUpDown num_count;
    }
}

