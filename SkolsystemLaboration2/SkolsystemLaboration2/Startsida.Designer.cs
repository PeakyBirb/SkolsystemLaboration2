﻿namespace SkolsystemLaboration2
{
    partial class Startsida
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
            this.LäggTillKurs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KursnamnTextbox = new System.Windows.Forms.TextBox();
            this.KursIDTextbox = new System.Windows.Forms.TextBox();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LärareDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.LabDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.KursListBox = new System.Windows.Forms.ListBox();
            this.LärareComboBox = new System.Windows.Forms.ComboBox();
            this.LäggTillStudent = new System.Windows.Forms.Button();
            this.LäggTillLärare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LabIDTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.LäggTillLabb = new System.Windows.Forms.Button();
            this.LabNamnTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LaborationComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OkBetygButton = new System.Windows.Forms.Button();
            this.betygLabel = new System.Windows.Forms.Label();
            this.NyttBetygComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LärareDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LäggTillKurs
            // 
            this.LäggTillKurs.Location = new System.Drawing.Point(131, 235);
            this.LäggTillKurs.Name = "LäggTillKurs";
            this.LäggTillKurs.Size = new System.Drawing.Size(89, 26);
            this.LäggTillKurs.TabIndex = 1;
            this.LäggTillKurs.Text = "Lägg till kurs";
            this.LäggTillKurs.UseVisualStyleBackColor = true;
            this.LäggTillKurs.Click += new System.EventHandler(this.LäggTillKurs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kursnamn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "KursID:";
            // 
            // KursnamnTextbox
            // 
            this.KursnamnTextbox.Location = new System.Drawing.Point(88, 44);
            this.KursnamnTextbox.Name = "KursnamnTextbox";
            this.KursnamnTextbox.Size = new System.Drawing.Size(132, 20);
            this.KursnamnTextbox.TabIndex = 6;
            this.KursnamnTextbox.TextChanged += new System.EventHandler(this.KursnamnTextbox_TextChanged);
            // 
            // KursIDTextbox
            // 
            this.KursIDTextbox.Location = new System.Drawing.Point(137, 18);
            this.KursIDTextbox.Name = "KursIDTextbox";
            this.KursIDTextbox.Size = new System.Drawing.Size(83, 20);
            this.KursIDTextbox.TabIndex = 7;
            this.KursIDTextbox.TextChanged += new System.EventHandler(this.KursIDTextbox_TextChanged);
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(251, 96);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.Size = new System.Drawing.Size(391, 114);
            this.StudentDataGrid.TabIndex = 8;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Studenter på kurs";
            // 
            // LärareDataGrid
            // 
            this.LärareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LärareDataGrid.Location = new System.Drawing.Point(680, 96);
            this.LärareDataGrid.Name = "LärareDataGrid";
            this.LärareDataGrid.Size = new System.Drawing.Size(561, 114);
            this.LärareDataGrid.TabIndex = 10;
            this.LärareDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LärareDataGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lärare på kurs";
            // 
            // LabDataGrid
            // 
            this.LabDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LabDataGrid.Location = new System.Drawing.Point(15, 452);
            this.LabDataGrid.Name = "LabDataGrid";
            this.LabDataGrid.Size = new System.Drawing.Size(334, 175);
            this.LabDataGrid.TabIndex = 12;
            this.LabDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LabDataGrid_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Skapa laborationsuppgift till vald kurs ovan";
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(412, 239);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentComboBox.TabIndex = 16;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // KursListBox
            // 
            this.KursListBox.FormattingEnabled = true;
            this.KursListBox.Location = new System.Drawing.Point(15, 102);
            this.KursListBox.Name = "KursListBox";
            this.KursListBox.Size = new System.Drawing.Size(205, 108);
            this.KursListBox.TabIndex = 18;
            this.KursListBox.SelectedIndexChanged += new System.EventHandler(this.KursListBox_SelectedIndexChanged);
            // 
            // LärareComboBox
            // 
            this.LärareComboBox.FormattingEnabled = true;
            this.LärareComboBox.Location = new System.Drawing.Point(1013, 234);
            this.LärareComboBox.Name = "LärareComboBox";
            this.LärareComboBox.Size = new System.Drawing.Size(121, 21);
            this.LärareComboBox.TabIndex = 19;
            this.LärareComboBox.SelectedIndexChanged += new System.EventHandler(this.LärareComboBox_SelectedIndexChanged);
            // 
            // LäggTillStudent
            // 
            this.LäggTillStudent.Location = new System.Drawing.Point(551, 235);
            this.LäggTillStudent.Name = "LäggTillStudent";
            this.LäggTillStudent.Size = new System.Drawing.Size(89, 26);
            this.LäggTillStudent.TabIndex = 20;
            this.LäggTillStudent.Text = "Lägg till";
            this.LäggTillStudent.UseVisualStyleBackColor = true;
            this.LäggTillStudent.Click += new System.EventHandler(this.LäggTillStudent_Click);
            // 
            // LäggTillLärare
            // 
            this.LäggTillLärare.Location = new System.Drawing.Point(1152, 230);
            this.LäggTillLärare.Name = "LäggTillLärare";
            this.LäggTillLärare.Size = new System.Drawing.Size(89, 26);
            this.LäggTillLärare.TabIndex = 21;
            this.LäggTillLärare.Text = "Lägg till";
            this.LäggTillLärare.UseVisualStyleBackColor = true;
            this.LäggTillLärare.Click += new System.EventHandler(this.LäggTillLärare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "LaborationsID:";
            // 
            // LabIDTextbox
            // 
            this.LabIDTextbox.Location = new System.Drawing.Point(266, 349);
            this.LabIDTextbox.Name = "LabIDTextbox";
            this.LabIDTextbox.Size = new System.Drawing.Size(83, 20);
            this.LabIDTextbox.TabIndex = 23;
            this.LabIDTextbox.TextChanged += new System.EventHandler(this.LabIDTextbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Laborationsnamn:";
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.Location = new System.Drawing.Point(584, 452);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(187, 173);
            this.StudentListBox.TabIndex = 26;
            this.StudentListBox.SelectedIndexChanged += new System.EventHandler(this.StudentListBox_SelectedIndexChanged);
            // 
            // LäggTillLabb
            // 
            this.LäggTillLabb.Location = new System.Drawing.Point(260, 407);
            this.LäggTillLabb.Name = "LäggTillLabb";
            this.LäggTillLabb.Size = new System.Drawing.Size(89, 26);
            this.LäggTillLabb.TabIndex = 27;
            this.LäggTillLabb.Text = "Lägg till labb";
            this.LäggTillLabb.UseVisualStyleBackColor = true;
            this.LäggTillLabb.Click += new System.EventHandler(this.LäggTillLabb_Click);
            // 
            // LabNamnTextbox
            // 
            this.LabNamnTextbox.Location = new System.Drawing.Point(217, 381);
            this.LabNamnTextbox.Name = "LabNamnTextbox";
            this.LabNamnTextbox.Size = new System.Drawing.Size(132, 20);
            this.LabNamnTextbox.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(581, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Studenter";
            // 
            // LaborationComboBox
            // 
            this.LaborationComboBox.FormattingEnabled = true;
            this.LaborationComboBox.Location = new System.Drawing.Point(584, 367);
            this.LaborationComboBox.Name = "LaborationComboBox";
            this.LaborationComboBox.Size = new System.Drawing.Size(187, 21);
            this.LaborationComboBox.TabIndex = 30;
            this.LaborationComboBox.SelectedIndexChanged += new System.EventHandler(this.LaborationComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(581, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Välj laborationsuppgift";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(850, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nuvarande betyg:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(871, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Välj nytt betyg:";
            // 
            // OkBetygButton
            // 
            this.OkBetygButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBetygButton.Location = new System.Drawing.Point(975, 531);
            this.OkBetygButton.Name = "OkBetygButton";
            this.OkBetygButton.Size = new System.Drawing.Size(56, 23);
            this.OkBetygButton.TabIndex = 35;
            this.OkBetygButton.Text = "Ok";
            this.OkBetygButton.UseVisualStyleBackColor = true;
            this.OkBetygButton.Click += new System.EventHandler(this.OkBetygButton_Click);
            // 
            // betygLabel
            // 
            this.betygLabel.AutoSize = true;
            this.betygLabel.ForeColor = System.Drawing.Color.Crimson;
            this.betygLabel.Location = new System.Drawing.Point(972, 388);
            this.betygLabel.Name = "betygLabel";
            this.betygLabel.Size = new System.Drawing.Size(59, 13);
            this.betygLabel.TabIndex = 33;
            this.betygLabel.Text = "betygLabel";
            this.betygLabel.Click += new System.EventHandler(this.betygLabel_Click);
            // 
            // NyttBetygComboBox
            // 
            this.NyttBetygComboBox.FormattingEnabled = true;
            this.NyttBetygComboBox.Items.AddRange(new object[] {
            "U",
            "G",
            "VG"});
            this.NyttBetygComboBox.Location = new System.Drawing.Point(971, 492);
            this.NyttBetygComboBox.Name = "NyttBetygComboBox";
            this.NyttBetygComboBox.Size = new System.Drawing.Size(60, 21);
            this.NyttBetygComboBox.TabIndex = 36;
            // 
            // Startsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 647);
            this.Controls.Add(this.NyttBetygComboBox);
            this.Controls.Add(this.OkBetygButton);
            this.Controls.Add(this.betygLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LaborationComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LabNamnTextbox);
            this.Controls.Add(this.LäggTillLabb);
            this.Controls.Add(this.StudentListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LabIDTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LäggTillLärare);
            this.Controls.Add(this.LäggTillStudent);
            this.Controls.Add(this.LärareComboBox);
            this.Controls.Add(this.KursListBox);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabDataGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LärareDataGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.KursIDTextbox);
            this.Controls.Add(this.KursnamnTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LäggTillKurs);
            this.Name = "Startsida";
            this.Text = "Välkommen";
            this.Load += new System.EventHandler(this.Startsida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LärareDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LäggTillKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KursnamnTextbox;
        private System.Windows.Forms.TextBox KursIDTextbox;
        private System.Windows.Forms.DataGridView StudentDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LärareDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView LabDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.ListBox KursListBox;
        private System.Windows.Forms.ComboBox LärareComboBox;
        private System.Windows.Forms.Button LäggTillStudent;
        private System.Windows.Forms.Button LäggTillLärare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LabIDTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Button LäggTillLabb;
        private System.Windows.Forms.TextBox LabNamnTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox LaborationComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OkBetygButton;
        private System.Windows.Forms.Label betygLabel;
        private System.Windows.Forms.ComboBox NyttBetygComboBox;
    }
}

