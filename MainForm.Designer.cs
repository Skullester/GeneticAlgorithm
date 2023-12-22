﻿namespace GeneticAlgorithm
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
            hintBtnGreen = new Button();
            hintBtnYellow = new Button();
            hintBtnRed = new Button();
            labelMutation = new Label();
            labelSelection = new Label();
            labelDeath = new Label();
            labelSpeed = new Label();
            comboBoxSpeed = new ComboBox();
            buttonRestart = new Button();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelGeneration = new Label();
            comboBoxIndividuals = new ComboBox();
            label1 = new Label();
            checkBoxAccelerated = new CheckBox();
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
            // hintBtnGreen
            // 
            hintBtnGreen.BackColor = Color.ForestGreen;
            hintBtnGreen.Enabled = false;
            hintBtnGreen.ForeColor = SystemColors.ControlLightLight;
            hintBtnGreen.Location = new Point(629, 38);
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
            hintBtnYellow.Location = new Point(692, 38);
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
            hintBtnRed.Location = new Point(757, 38);
            hintBtnRed.Name = "hintBtnRed";
            hintBtnRed.Size = new Size(25, 25);
            hintBtnRed.TabIndex = 16;
            hintBtnRed.UseVisualStyleBackColor = false;
            // 
            // labelMutation
            // 
            labelMutation.AutoSize = true;
            labelMutation.Font = new Font("Segoe UI", 12F);
            labelMutation.Location = new Point(670, 16);
            labelMutation.Name = "labelMutation";
            labelMutation.Size = new Size(74, 21);
            labelMutation.TabIndex = 17;
            labelMutation.Text = "Мутация";
            // 
            // labelSelection
            // 
            labelSelection.AutoSize = true;
            labelSelection.Font = new Font("Segoe UI", 12F);
            labelSelection.Location = new Point(608, 16);
            labelSelection.Name = "labelSelection";
            labelSelection.Size = new Size(56, 21);
            labelSelection.TabIndex = 18;
            labelSelection.Text = "Отбор";
            // 
            // labelDeath
            // 
            labelDeath.AutoSize = true;
            labelDeath.Font = new Font("Segoe UI", 12F);
            labelDeath.Location = new Point(741, 16);
            labelDeath.Name = "labelDeath";
            labelDeath.Size = new Size(63, 21);
            labelDeath.TabIndex = 19;
            labelDeath.Text = "Смерть";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Font = new Font("Segoe UI", 15F);
            labelSpeed.Location = new Point(12, 261);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(101, 28);
            labelSpeed.TabIndex = 20;
            labelSpeed.Text = "Скорость:";
            // 
            // comboBoxSpeed
            // 
            comboBoxSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpeed.Font = new Font("Segoe UI", 12F);
            comboBoxSpeed.FormattingEnabled = true;
            comboBoxSpeed.Items.AddRange(new object[] { "x1", "x2", "x5", "x10", "x20" });
            comboBoxSpeed.Location = new Point(119, 261);
            comboBoxSpeed.Name = "comboBoxSpeed";
            comboBoxSpeed.Size = new Size(66, 29);
            comboBoxSpeed.TabIndex = 21;
            // 
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI", 15F);
            buttonRestart.Location = new Point(12, 464);
            buttonRestart.Name = "buttonRestart";
            buttonRestart.Size = new Size(170, 54);
            buttonRestart.TabIndex = 22;
            buttonRestart.Text = "Перезапустить";
            buttonRestart.UseVisualStyleBackColor = true;
            buttonRestart.Click += Restart;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(1775, 29);
            chart.Name = "chart";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(17, 11);
            chart.TabIndex = 24;
            chart.Text = "chart";
            chart.Visible = false;
            // 
            // labelGeneration
            // 
            labelGeneration.AutoSize = true;
            labelGeneration.Font = new Font("Segoe UI", 15F);
            labelGeneration.Location = new Point(582, 78);
            labelGeneration.Name = "labelGeneration";
            labelGeneration.Size = new Size(234, 28);
            labelGeneration.TabIndex = 25;
            labelGeneration.Text = "Поколение: 0 Оптимум: \r\n";
            // 
            // comboBoxIndividuals
            // 
            comboBoxIndividuals.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIndividuals.Font = new Font("Segoe UI", 12F);
            comboBoxIndividuals.FormattingEnabled = true;
            comboBoxIndividuals.Items.AddRange(new object[] { "32", "64", "128", "256", "512", "1024" });
            comboBoxIndividuals.Location = new Point(336, 129);
            comboBoxIndividuals.Name = "comboBoxIndividuals";
            comboBoxIndividuals.Size = new Size(210, 29);
            comboBoxIndividuals.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.Location = new Point(327, 95);
            label1.Name = "label1";
            label1.Size = new Size(221, 31);
            label1.TabIndex = 27;
            label1.Text = "Количество особей:";
            // 
            // checkBoxAccelerated
            // 
            checkBoxAccelerated.AutoSize = true;
            checkBoxAccelerated.Font = new Font("Segoe UI", 15F);
            checkBoxAccelerated.Location = new Point(21, 311);
            checkBoxAccelerated.Name = "checkBoxAccelerated";
            checkBoxAccelerated.Size = new Size(153, 32);
            checkBoxAccelerated.TabIndex = 28;
            checkBoxAccelerated.Text = "Без задержек";
            checkBoxAccelerated.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1804, 801);
            Controls.Add(checkBoxAccelerated);
            Controls.Add(label1);
            Controls.Add(comboBoxIndividuals);
            Controls.Add(labelGeneration);
            Controls.Add(chart);
            Controls.Add(buttonRestart);
            Controls.Add(comboBoxSpeed);
            Controls.Add(labelSpeed);
            Controls.Add(labelDeath);
            Controls.Add(labelSelection);
            Controls.Add(labelMutation);
            Controls.Add(hintBtnRed);
            Controls.Add(hintBtnYellow);
            Controls.Add(hintBtnGreen);
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
        private Button hintBtnGreen;
        private Button hintBtnYellow;
        private Button hintBtnRed;
        private Label labelMutation;
        private Label labelSelection;
        private Label labelDeath;
        private Label labelSpeed;
        private ComboBox comboBoxSpeed;
        private Button buttonRestart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label labelGeneration;
        private ComboBox comboBoxIndividuals;
        private Label label1;
        public CheckBox checkBoxAccelerated;
    }
}
