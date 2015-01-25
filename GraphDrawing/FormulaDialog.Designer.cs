namespace GraphDrawing
{
    partial class FormulaDialog
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
            this.tbFormula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnFormulaLine = new System.Windows.Forms.Panel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFormula
            // 
            this.tbFormula.Location = new System.Drawing.Point(23, 27);
            this.tbFormula.Name = "tbFormula";
            this.tbFormula.Size = new System.Drawing.Size(191, 31);
            this.tbFormula.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Wingdings 3", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(153, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = ",";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnFormulaLine
            // 
            this.pnFormulaLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFormulaLine.Location = new System.Drawing.Point(39, 101);
            this.pnFormulaLine.Name = "pnFormulaLine";
            this.pnFormulaLine.Size = new System.Drawing.Size(112, 68);
            this.pnFormulaLine.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Line Width";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(178, 225);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(36, 31);
            this.tbWidth.TabIndex = 4;
            // 
            // bnAdd
            // 
            this.bnAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.bnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAdd.Location = new System.Drawing.Point(12, 300);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(109, 51);
            this.bnAdd.TabIndex = 5;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = false;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.Color.OrangeRed;
            this.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(127, 300);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(106, 51);
            this.bnCancel.TabIndex = 6;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = false;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // FormulaDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(248, 382);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.tbWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnFormulaLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFormula);
            this.Name = "FormulaDialog";
            this.Text = "FormulaDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnFormulaLine;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnCancel;
    }
}