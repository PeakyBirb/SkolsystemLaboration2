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
            this.BetygDataGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentComboBox = new System.Windows.Forms.ComboBox();
            this.LäggTillStudentKnapp = new System.Windows.Forms.Button();
            this.KursListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LärareDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetygDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LäggTillKurs
            // 
            this.LäggTillKurs.Location = new System.Drawing.Point(46, 182);
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
            this.StudentDataGrid.Location = new System.Drawing.Point(229, 28);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.Size = new System.Drawing.Size(391, 123);
            this.StudentDataGrid.TabIndex = 8;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Studenter på kurs";
            // 
            // LärareDataGrid
            // 
            this.LärareDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LärareDataGrid.Location = new System.Drawing.Point(643, 28);
            this.LärareDataGrid.Name = "LärareDataGrid";
            this.LärareDataGrid.Size = new System.Drawing.Size(370, 123);
            this.LärareDataGrid.TabIndex = 10;
            this.LärareDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LärareDataGrid_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lärare på kurs";
            // 
            // LabDataGrid
            // 
            this.LabDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LabDataGrid.Location = new System.Drawing.Point(15, 329);
            this.LabDataGrid.Name = "LabDataGrid";
            this.LabDataGrid.Size = new System.Drawing.Size(380, 150);
            this.LabDataGrid.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Laborationsuppgift";
            // 
            // BetygDataGrid
            // 
            this.BetygDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BetygDataGrid.Location = new System.Drawing.Point(525, 329);
            this.BetygDataGrid.Name = "BetygDataGrid";
            this.BetygDataGrid.Size = new System.Drawing.Size(366, 150);
            this.BetygDataGrid.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(522, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Alla betyg för Studenten";
            // 
            // StudentComboBox
            // 
            this.StudentComboBox.FormattingEnabled = true;
            this.StudentComboBox.Location = new System.Drawing.Point(341, 226);
            this.StudentComboBox.Name = "StudentComboBox";
            this.StudentComboBox.Size = new System.Drawing.Size(121, 21);
            this.StudentComboBox.TabIndex = 16;
            this.StudentComboBox.SelectedIndexChanged += new System.EventHandler(this.StudentComboBox_SelectedIndexChanged);
            // 
            // LäggTillStudentKnapp
            // 
            this.LäggTillStudentKnapp.Location = new System.Drawing.Point(500, 222);
            this.LäggTillStudentKnapp.Name = "LäggTillStudentKnapp";
            this.LäggTillStudentKnapp.Size = new System.Drawing.Size(89, 26);
            this.LäggTillStudentKnapp.TabIndex = 17;
            this.LäggTillStudentKnapp.Text = "Lägg till student";
            this.LäggTillStudentKnapp.UseVisualStyleBackColor = true;
            this.LäggTillStudentKnapp.Click += new System.EventHandler(this.LäggTillStudentKnapp_Click);
            // 
            // KursListBox
            // 
            this.KursListBox.FormattingEnabled = true;
            this.KursListBox.Location = new System.Drawing.Point(15, 81);
            this.KursListBox.Name = "KursListBox";
            this.KursListBox.Size = new System.Drawing.Size(120, 95);
            this.KursListBox.TabIndex = 18;
            this.KursListBox.SelectedIndexChanged += new System.EventHandler(this.KursListBox_SelectedIndexChanged);
            // 
            // Startsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 518);
            this.Controls.Add(this.KursListBox);
            this.Controls.Add(this.LäggTillStudentKnapp);
            this.Controls.Add(this.StudentComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BetygDataGrid);
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
            ((System.ComponentModel.ISupportInitialize)(this.BetygDataGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView BetygDataGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StudentComboBox;
        private System.Windows.Forms.Button LäggTillStudentKnapp;
        private System.Windows.Forms.ListBox KursListBox;
    }
}

