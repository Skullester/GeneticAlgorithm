namespace GeneticAlgorithm
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            comboBoxParents = new ComboBox();
            parentChoosingLabel = new Label();
            wayOfRecombinationLabel = new Label();
            comboBoxRecombinations = new ComboBox();
            btnConfirm = new Button();
            label2 = new Label();
            comboBoxCountOfGenes = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            comboBoxMaxMin = new ComboBox();
            hintBtnGreen = new Button();
            hintBtnYellow = new Button();
            hintBtnRed = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxSpeed = new ComboBox();
            buttonRestart = new Button();
            label7 = new Label();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // comboBoxParents
            // 
            comboBoxParents.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxParents.Font = new Font("Segoe UI", 12F);
            comboBoxParents.FormattingEnabled = true;
            comboBoxParents.Location = new Point(21, 43);
            comboBoxParents.Name = "comboBoxParents";
            comboBoxParents.Size = new Size(210, 29);
            comboBoxParents.TabIndex = 0;
            // 
            // parentChoosingLabel
            // 
            parentChoosingLabel.AutoSize = true;
            parentChoosingLabel.Font = new Font("Segoe UI", 17F);
            parentChoosingLabel.Location = new Point(12, 9);
            parentChoosingLabel.Name = "parentChoosingLabel";
            parentChoosingLabel.Size = new Size(299, 31);
            parentChoosingLabel.TabIndex = 1;
            parentChoosingLabel.Text = "Способ выбора родителей:";
            // 
            // wayOfRecombinationLabel
            // 
            wayOfRecombinationLabel.AutoSize = true;
            wayOfRecombinationLabel.Font = new Font("Segoe UI", 17F);
            wayOfRecombinationLabel.Location = new Point(327, 9);
            wayOfRecombinationLabel.Name = "wayOfRecombinationLabel";
            wayOfRecombinationLabel.Size = new Size(259, 31);
            wayOfRecombinationLabel.TabIndex = 2;
            wayOfRecombinationLabel.Text = "Способ рекомбинации:";
            // 
            // comboBoxRecombinations
            // 
            comboBoxRecombinations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRecombinations.Font = new Font("Segoe UI", 12F);
            comboBoxRecombinations.FormattingEnabled = true;
            comboBoxRecombinations.Location = new Point(336, 43);
            comboBoxRecombinations.Name = "comboBoxRecombinations";
            comboBoxRecombinations.Size = new Size(241, 29);
            comboBoxRecombinations.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 15F);
            btnConfirm.Location = new Point(21, 179);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(194, 65);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Сгенерировать популяцию";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += GeneratePopulation;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(205, 31);
            label2.TabIndex = 8;
            label2.Text = "Количество генов:";
            // 
            // comboBoxCountOfGenes
            // 
            comboBoxCountOfGenes.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCountOfGenes.Font = new Font("Segoe UI", 12F);
            comboBoxCountOfGenes.FormattingEnabled = true;
            comboBoxCountOfGenes.Items.AddRange(new object[] { "5", "10", "20" });
            comboBoxCountOfGenes.Location = new Point(21, 129);
            comboBoxCountOfGenes.Name = "comboBoxCountOfGenes";
            comboBoxCountOfGenes.Size = new Size(210, 29);
            comboBoxCountOfGenes.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(21, 349);
            button1.Name = "button1";
            button1.Size = new Size(353, 88);
            button1.TabIndex = 10;
            button1.Text = "Начать скрещивание";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StartCrossover;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 476);
            label3.Name = "label3";
            label3.Size = new Size(427, 28);
            label3.TabIndex = 11;
            label3.Text = "У каждой особи есть поле \"Fitness\".  Мы ищем:";
            // 
            // comboBoxMaxMin
            // 
            comboBoxMaxMin.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMaxMin.Font = new Font("Segoe UI", 12F);
            comboBoxMaxMin.FormattingEnabled = true;
            comboBoxMaxMin.Items.AddRange(new object[] { "Макс", "Мин" });
            comboBoxMaxMin.Location = new Point(12, 520);
            comboBoxMaxMin.Name = "comboBoxMaxMin";
            comboBoxMaxMin.Size = new Size(194, 29);
            comboBoxMaxMin.TabIndex = 12;
            // 
            // hintBtnGreen
            // 
            hintBtnGreen.BackColor = Color.ForestGreen;
            hintBtnGreen.Enabled = false;
            hintBtnGreen.ForeColor = SystemColors.ControlLightLight;
            hintBtnGreen.Location = new Point(286, 203);
            hintBtnGreen.Name = "hintBtnGreen";
            hintBtnGreen.Size = new Size(25, 25);
            hintBtnGreen.TabIndex = 14;
            hintBtnGreen.UseVisualStyleBackColor = false;
            // 
            // hintBtnYellow
            // 
            hintBtnYellow.BackColor = Color.Yellow;
            hintBtnYellow.Enabled = false;
            hintBtnYellow.ForeColor = SystemColors.ControlLightLight;
            hintBtnYellow.Location = new Point(349, 203);
            hintBtnYellow.Name = "hintBtnYellow";
            hintBtnYellow.Size = new Size(25, 25);
            hintBtnYellow.TabIndex = 15;
            hintBtnYellow.UseVisualStyleBackColor = false;
            // 
            // hintBtnRed
            // 
            hintBtnRed.BackColor = Color.Red;
            hintBtnRed.Enabled = false;
            hintBtnRed.ForeColor = SystemColors.ControlLightLight;
            hintBtnRed.Location = new Point(414, 203);
            hintBtnRed.Name = "hintBtnRed";
            hintBtnRed.Size = new Size(25, 25);
            hintBtnRed.TabIndex = 16;
            hintBtnRed.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(327, 181);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 17;
            label1.Text = "Мутация";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(271, 181);
            label4.Name = "label4";
            label4.Size = new Size(50, 19);
            label4.TabIndex = 18;
            label4.Text = "Отбор";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(398, 181);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 19;
            label5.Text = "Смерть";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(21, 305);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 20;
            label6.Text = "Скорость:";
            // 
            // comboBoxSpeed
            // 
            comboBoxSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpeed.Font = new Font("Segoe UI", 12F);
            comboBoxSpeed.FormattingEnabled = true;
            comboBoxSpeed.Items.AddRange(new object[] { "x1", "x2", "x5", "x10", "x20" });
            comboBoxSpeed.Location = new Point(128, 305);
            comboBoxSpeed.Name = "comboBoxSpeed";
            comboBoxSpeed.Size = new Size(66, 29);
            comboBoxSpeed.TabIndex = 21;
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI", 15F);
            buttonRestart.Location = new Point(12, 570);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(170, 54);
            buttonRestart.TabIndex = 22;
            buttonRestart.Text = "Перезапустить";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += Restart;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(271, 111);
            label7.Name = "label7";
            label7.Size = new Size(219, 28);
            label7.TabIndex = 23;
            label7.Text = "y = f(x) = 3x^3 - 2x + 5;";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(506, 95);
            chart.Name = "chart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(1227, 565);
            chart.TabIndex = 24;
            chart.Text = "chart";
            chart.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1804, 801);
            Controls.Add(chart);
            Controls.Add(label7);
            Controls.Add(buttonRestart);
            Controls.Add(comboBoxSpeed);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(hintBtnRed);
            Controls.Add(hintBtnYellow);
            Controls.Add(hintBtnGreen);
            Controls.Add(comboBoxMaxMin);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(comboBoxCountOfGenes);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(comboBoxRecombinations);
            Controls.Add(wayOfRecombinationLabel);
            Controls.Add(parentChoosingLabel);
            Controls.Add(comboBoxParents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Генетический Алгоритм";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxParents;
        private Label parentChoosingLabel;
        private Label wayOfRecombinationLabel;
        private ComboBox comboBoxRecombinations;
        private Button btnConfirm;
        private Label label2;
        private ComboBox comboBoxCountOfGenes;
        private Button button1;
        private Label label3;
        private ComboBox comboBoxMaxMin;
        private Button hintBtnGreen;
        private Button hintBtnYellow;
        private Button hintBtnRed;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxSpeed;
        private Button buttonRestart;
        private Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
