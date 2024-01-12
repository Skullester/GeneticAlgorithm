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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            comboBoxParents = new ComboBox();
            parentChoosingLabel = new Label();
            wayOfRecombinationLabel = new Label();
            comboBoxRecombinations = new ComboBox();
            label2 = new Label();
            comboBoxCountOfGenes = new ComboBox();
            button1 = new Button();
            hintBtnGreen = new Button();
            hintBtnYellow = new Button();
            hintBtnRed = new Button();
            labelMutation = new Label();
            labelSelection = new Label();
            labelDeath = new Label();
            buttonRestart = new Button();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            LabelGeneration = new Label();
            comboBoxIndividuals = new ComboBox();
            label1 = new Label();
            comboBoxDimensions = new ComboBox();
            labelDimension = new Label();
            ListBoxArguments = new ListBox();
            Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            textBoxMutation = new TextBox();
            LabelAlgorithmTime = new Label();
            comboBoxGenerations = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Chart1).BeginInit();
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
            comboBoxCountOfGenes.Items.AddRange(new object[] { "100", "200", "500" });
            comboBoxCountOfGenes.Location = new Point(21, 129);
            comboBoxCountOfGenes.Name = "comboBoxCountOfGenes";
            comboBoxCountOfGenes.Size = new Size(210, 29);
            comboBoxCountOfGenes.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(12, 200);
            button1.Name = "button1";
            button1.Size = new Size(299, 97);
            button1.TabIndex = 10;
            button1.Text = "Начать";
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
            // buttonRestart
            // 
            buttonRestart.Font = new Font("Segoe UI", 15F);
            buttonRestart.Location = new Point(12, 673);
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
            series1.MarkerBorderWidth = 10;
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(17, 11);
            chart.TabIndex = 24;
            chart.Text = "chart";
            chart.Visible = false;
            // 
            // LabelGeneration
            // 
            LabelGeneration.AutoSize = true;
            LabelGeneration.Font = new Font("Segoe UI", 15F);
            LabelGeneration.Location = new Point(12, 408);
            LabelGeneration.Name = "LabelGeneration";
            LabelGeneration.Size = new Size(229, 28);
            LabelGeneration.TabIndex = 25;
            LabelGeneration.Text = "Поколение: 0 Оптимум:";
            // 
            // comboBoxIndividuals
            // 
            comboBoxIndividuals.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIndividuals.Font = new Font("Segoe UI", 12F);
            comboBoxIndividuals.FormattingEnabled = true;
            comboBoxIndividuals.Items.AddRange(new object[] { "1024", "2048", "4096" });
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
            // comboBoxDimensions
            // 
            comboBoxDimensions.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDimensions.Font = new Font("Segoe UI", 12F);
            comboBoxDimensions.FormattingEnabled = true;
            comboBoxDimensions.Items.AddRange(new object[] { "10", "20" });
            comboBoxDimensions.Location = new Point(336, 200);
            comboBoxDimensions.Name = "comboBoxDimensions";
            comboBoxDimensions.Size = new Size(210, 29);
            comboBoxDimensions.TabIndex = 29;
            // 
            // labelDimension
            // 
            labelDimension.AutoSize = true;
            labelDimension.Font = new Font("Segoe UI", 17F);
            labelDimension.Location = new Point(336, 166);
            labelDimension.Name = "labelDimension";
            labelDimension.Size = new Size(185, 31);
            labelDimension.TabIndex = 30;
            labelDimension.Text = "Размерность(N):";
            // 
            // ListBoxArguments
            // 
            ListBoxArguments.FormattingEnabled = true;
            ListBoxArguments.ItemHeight = 15;
            ListBoxArguments.Location = new Point(12, 455);
            ListBoxArguments.Name = "ListBoxArguments";
            ListBoxArguments.Size = new Size(534, 199);
            ListBoxArguments.TabIndex = 31;
            // 
            // Chart1
            // 
            chartArea2.Name = "ChartArea1";
            Chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            Chart1.Legends.Add(legend2);
            Chart1.Location = new Point(592, 16);
            Chart1.Name = "Chart1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            Chart1.Series.Add(series2);
            Chart1.Size = new Size(958, 597);
            Chart1.TabIndex = 32;
            Chart1.Text = "chart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F);
            label3.Location = new Point(336, 246);
            label3.Name = "label3";
            label3.Size = new Size(111, 31);
            label3.TabIndex = 33;
            label3.Text = "Мутация:";
            // 
            // textBoxMutation
            // 
            textBoxMutation.Font = new Font("Segoe UI", 12F);
            textBoxMutation.Location = new Point(336, 280);
            textBoxMutation.Name = "textBoxMutation";
            textBoxMutation.Size = new Size(100, 29);
            textBoxMutation.TabIndex = 34;
            textBoxMutation.Text = "0,01";
            // 
            // LabelAlgorithmTime
            // 
            LabelAlgorithmTime.AutoSize = true;
            LabelAlgorithmTime.Font = new Font("Segoe UI", 15F);
            LabelAlgorithmTime.Location = new Point(218, 686);
            LabelAlgorithmTime.Name = "LabelAlgorithmTime";
            LabelAlgorithmTime.Size = new Size(201, 28);
            LabelAlgorithmTime.TabIndex = 35;
            LabelAlgorithmTime.Text = "Потраченное время:";
            // 
            // comboBoxGenerations
            // 
            comboBoxGenerations.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenerations.Font = new Font("Segoe UI", 12F);
            comboBoxGenerations.FormattingEnabled = true;
            comboBoxGenerations.Items.AddRange(new object[] { "250", "300", "400", "500", "1000", "INF" });
            comboBoxGenerations.Location = new Point(338, 363);
            comboBoxGenerations.Name = "comboBoxGenerations";
            comboBoxGenerations.Size = new Size(210, 29);
            comboBoxGenerations.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 17F);
            label4.Location = new Point(336, 329);
            label4.Name = "label4";
            label4.Size = new Size(193, 31);
            label4.TabIndex = 37;
            label4.Text = "Макс. поколений";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1804, 801);
            Controls.Add(label4);
            Controls.Add(comboBoxGenerations);
            Controls.Add(LabelAlgorithmTime);
            Controls.Add(textBoxMutation);
            Controls.Add(label3);
            Controls.Add(Chart1);
            Controls.Add(ListBoxArguments);
            Controls.Add(labelDimension);
            Controls.Add(comboBoxDimensions);
            Controls.Add(label1);
            Controls.Add(comboBoxIndividuals);
            Controls.Add(LabelGeneration);
            Controls.Add(chart);
            Controls.Add(buttonRestart);
            Controls.Add(labelDeath);
            Controls.Add(labelSelection);
            Controls.Add(labelMutation);
            Controls.Add(hintBtnRed);
            Controls.Add(hintBtnYellow);
            Controls.Add(hintBtnGreen);
            Controls.Add(button1);
            Controls.Add(comboBoxCountOfGenes);
            Controls.Add(label2);
            Controls.Add(comboBoxRecombinations);
            Controls.Add(wayOfRecombinationLabel);
            Controls.Add(parentChoosingLabel);
            Controls.Add(comboBoxParents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Генетический Алгоритм";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)Chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxParents;
        private Label parentChoosingLabel;
        private Label wayOfRecombinationLabel;
        private ComboBox comboBoxRecombinations;
        private Label label2;
        private ComboBox comboBoxCountOfGenes;
        private Button button1;
        private Button hintBtnGreen;
        private Button hintBtnYellow;
        private Button hintBtnRed;
        private Label labelMutation;
        private Label labelSelection;
        private Label labelDeath;
        private Button buttonRestart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public Label LabelGeneration;
        private ComboBox comboBoxIndividuals;
        private Label label1;
        private ComboBox comboBoxDimensions;
        private Label labelDimension;
        public ListBox ListBoxArguments;
        public System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        public System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private Label label3;
        private TextBox textBoxMutation;
        public Label LabelAlgorithmTime;
        private ComboBox comboBoxGenerations;
        private Label label4;
    }
}
