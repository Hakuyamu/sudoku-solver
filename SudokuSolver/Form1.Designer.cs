namespace SudokuSolver
{
    partial class FSudokuSolver
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSolve = new System.Windows.Forms.Button();
            this.tbImport = new System.Windows.Forms.TextBox();
            this.lImport = new System.Windows.Forms.Label();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSolve
            // 
            this.bSolve.Location = new System.Drawing.Point(462, 350);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(124, 37);
            this.bSolve.TabIndex = 81;
            this.bSolve.Text = "Solve";
            this.bSolve.UseVisualStyleBackColor = true;
            this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
            // 
            // tbImport
            // 
            this.tbImport.Location = new System.Drawing.Point(11, 421);
            this.tbImport.Name = "tbImport";
            this.tbImport.Size = new System.Drawing.Size(436, 20);
            this.tbImport.TabIndex = 82;
            // 
            // lImport
            // 
            this.lImport.AutoSize = true;
            this.lImport.Location = new System.Drawing.Point(11, 405);
            this.lImport.Name = "lImport";
            this.lImport.Size = new System.Drawing.Size(39, 13);
            this.lImport.TabIndex = 83;
            this.lImport.Text = "Import:";
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(462, 419);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(124, 23);
            this.bSubmit.TabIndex = 84;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(462, 307);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(124, 37);
            this.bReset.TabIndex = 85;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // FSudokuSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 462);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.lImport);
            this.Controls.Add(this.tbImport);
            this.Controls.Add(this.bSolve);
            this.Name = "FSudokuSolver";
            this.Text = "Sudoku Solver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSolve;
        private System.Windows.Forms.TextBox tbImport;
        private System.Windows.Forms.Label lImport;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bReset;
    }
}

