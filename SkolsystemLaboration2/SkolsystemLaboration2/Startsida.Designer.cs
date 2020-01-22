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
            this.label1 = new System.Windows.Forms.Label();
            this.KursDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.KursnamnTextbox = new System.Windows.Forms.TextBox();
            this.KursIDTextbox = new System.Windows.Forms.TextBox();
            this.StudentDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.KursDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LäggTillKurs
            // 
            this.LäggTillKurs.Location = new System.Drawing.Point(178, 221);
            this.LäggTillKurs.Name = "LäggTillKurs";
            this.LäggTillKurs.Size = new System.Drawing.Size(89, 26);
            this.LäggTillKurs.TabIndex = 1;
            this.LäggTillKurs.Text = "Lägg till kurs";
            this.LäggTillKurs.UseVisualStyleBackColor = true;
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
            this.KursDataGrid.Size = new System.Drawing.Size(255, 123);
            this.KursDataGrid.TabIndex = 2;
            this.KursDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KursDataGrid_CellContentClick);
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
            this.KursnamnTextbox.Size = new System.Drawing.Size(179, 20);
            this.KursnamnTextbox.TabIndex = 6;
            // 
            // KursIDTextbox
            // 
            this.KursIDTextbox.Location = new System.Drawing.Point(184, 18);
            this.KursIDTextbox.Name = "KursIDTextbox";
            this.KursIDTextbox.Size = new System.Drawing.Size(83, 20);
            this.KursIDTextbox.TabIndex = 7;
            // 
            // StudentDataGrid
            // 
            this.StudentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentDataGrid.Location = new System.Drawing.Point(378, 82);
            this.StudentDataGrid.Name = "StudentDataGrid";
            this.StudentDataGrid.Size = new System.Drawing.Size(255, 123);
            this.StudentDataGrid.TabIndex = 8;
            this.StudentDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDataGrid_CellContentClick);
            // 
            // Startsida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 669);
            this.Controls.Add(this.StudentDataGrid);
            this.Controls.Add(this.KursIDTextbox);
            this.Controls.Add(this.KursnamnTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KursDataGrid);
            this.Controls.Add(this.LäggTillKurs);
            this.Name = "Startsida";
            this.Text = "Välkommen";
            this.Load += new System.EventHandler(this.Startsida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KursDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LäggTillKurs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView KursDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KursnamnTextbox;
        private System.Windows.Forms.TextBox KursIDTextbox;
        private System.Windows.Forms.DataGridView StudentDataGrid;
    }
}

