namespace SkolsystemLaboration2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.KursDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.KursnamnTextbox = new System.Windows.Forms.TextBox();
            this.KursIDTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LäggTillKurs
            // 
            this.LäggTillKurs.Location = new System.Drawing.Point(444, 39);
            this.LäggTillKurs.Name = "LäggTillKurs";
            this.LäggTillKurs.Size = new System.Drawing.Size(89, 26);
            this.LäggTillKurs.TabIndex = 1;
            this.LäggTillKurs.Text = "Lägg till kurs";
            this.LäggTillKurs.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 293);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1017, 120);
            this.dataGridView2.TabIndex = 3;
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
            // KursDataGrid
            // 
            this.KursDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KursDataGrid.Location = new System.Drawing.Point(12, 82);
            this.KursDataGrid.Name = "KursDataGrid";
            this.KursDataGrid.Size = new System.Drawing.Size(521, 123);
            this.KursDataGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "KursID:";
            // 
            // KursnamnTextbox
            // 
            this.KursnamnTextbox.Location = new System.Drawing.Point(88, 44);
            this.KursnamnTextbox.Name = "KursnamnTextbox";
            this.KursnamnTextbox.Size = new System.Drawing.Size(179, 20);
            this.KursnamnTextbox.TabIndex = 6;
            // 
            // KursIDTextbox
            // 
            this.KursIDTextbox.Location = new System.Drawing.Point(339, 44);
            this.KursIDTextbox.Name = "KursIDTextbox";
            this.KursIDTextbox.Size = new System.Drawing.Size(83, 20);
            this.KursIDTextbox.TabIndex = 7;
            // 
            // Startsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 669);
            this.Controls.Add(this.KursIDTextbox);
            this.Controls.Add(this.KursnamnTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.KursDataGrid);
            this.Controls.Add(this.LäggTillKurs);
            this.Name = "Startsida";
            this.Text = "Välkommen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LäggTillKurs;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KursDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KursnamnTextbox;
        private System.Windows.Forms.TextBox KursIDTextbox;
    }
}

