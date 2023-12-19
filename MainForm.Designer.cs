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
            timeLabel = new Label();
            hintBtnGreen = new Button();
            hintBtnYellow = new Button();
            hintBtnRed = new Button();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            label3.Text = "У каждой особи есть поле \"Value\".  Мы ищем:";
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
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 15F);
            timeLabel.Location = new Point(21, 274);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(119, 28);
            timeLabel.TabIndex = 13;
            timeLabel.Text = "Поколение:";
            timeLabel.Visible = false;
            // 
            // hintBtnGreen
            // 
            hintBtnGreen.BackColor = Color.ForestGreen;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1767, 787);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(hintBtnRed);
            Controls.Add(hintBtnYellow);
            Controls.Add(hintBtnGreen);
            Controls.Add(timeLabel);
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
            Name = "MainForm";
            Text = "MainForm";
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
        private Label timeLabel;
        private Button hintBtnGreen;
        private Button hintBtnYellow;
        private Button hintBtnRed;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}
