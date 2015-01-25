namespace GraphDrawing
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnGrid = new System.Windows.Forms.Panel();
            this.bnGrid = new System.Windows.Forms.Button();
            this.pnAxes = new System.Windows.Forms.Panel();
            this.bnAxes = new System.Windows.Forms.Button();
            this.bnRun = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.drawingArea = new System.Windows.Forms.Panel();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.dgvFormulae = new System.Windows.Forms.DataGridView();
            this.formulaBodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthLineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formulaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbX1
            // 
            this.tbX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbX1.Location = new System.Drawing.Point(6, 696);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(50, 40);
            this.tbX1.TabIndex = 1;
            this.tbX1.Text = "-5";
            // 
            // tbX2
            // 
            this.tbX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbX2.Location = new System.Drawing.Point(716, 697);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(50, 40);
            this.tbX2.TabIndex = 3;
            this.tbX2.Text = "5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Formula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFormulae);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pnGrid);
            this.groupBox1.Controls.Add(this.bnGrid);
            this.groupBox1.Controls.Add(this.pnAxes);
            this.groupBox1.Controls.Add(this.bnAxes);
            this.groupBox1.Controls.Add(this.bnRun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 749);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Arial Unicode MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 69);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add new formula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnGrid
            // 
            this.pnGrid.Location = new System.Drawing.Point(136, 654);
            this.pnGrid.Name = "pnGrid";
            this.pnGrid.Size = new System.Drawing.Size(63, 45);
            this.pnGrid.TabIndex = 12;
            this.pnGrid.DoubleClick += new System.EventHandler(this.bnGrid_Click);
            // 
            // bnGrid
            // 
            this.bnGrid.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnGrid.Location = new System.Drawing.Point(22, 654);
            this.bnGrid.Name = "bnGrid";
            this.bnGrid.Size = new System.Drawing.Size(75, 45);
            this.bnGrid.TabIndex = 11;
            this.bnGrid.Text = "Grid";
            this.bnGrid.UseVisualStyleBackColor = true;
            this.bnGrid.Click += new System.EventHandler(this.bnGrid_Click);
            // 
            // pnAxes
            // 
            this.pnAxes.Location = new System.Drawing.Point(136, 578);
            this.pnAxes.Name = "pnAxes";
            this.pnAxes.Size = new System.Drawing.Size(63, 45);
            this.pnAxes.TabIndex = 10;
            this.pnAxes.DoubleClick += new System.EventHandler(this.bnAxes_Click);
            // 
            // bnAxes
            // 
            this.bnAxes.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnAxes.Location = new System.Drawing.Point(22, 578);
            this.bnAxes.Name = "bnAxes";
            this.bnAxes.Size = new System.Drawing.Size(75, 45);
            this.bnAxes.TabIndex = 9;
            this.bnAxes.Text = "Axes";
            this.bnAxes.UseVisualStyleBackColor = true;
            this.bnAxes.Click += new System.EventHandler(this.bnAxes_Click);
            // 
            // bnRun
            // 
            this.bnRun.BackColor = System.Drawing.Color.OrangeRed;
            this.bnRun.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnRun.ForeColor = System.Drawing.Color.White;
            this.bnRun.Location = new System.Drawing.Point(22, 473);
            this.bnRun.Name = "bnRun";
            this.bnRun.Size = new System.Drawing.Size(166, 52);
            this.bnRun.TabIndex = 8;
            this.bnRun.Text = "Run";
            this.bnRun.UseVisualStyleBackColor = false;
            this.bnRun.Click += new System.EventHandler(this.bnRun_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.tbY2);
            this.groupBox2.Controls.Add(this.drawingArea);
            this.groupBox2.Controls.Add(this.tbY1);
            this.groupBox2.Controls.Add(this.tbX1);
            this.groupBox2.Controls.Add(this.tbX2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(219, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 749);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            // 
            // tbY2
            // 
            this.tbY2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbY2.Location = new System.Drawing.Point(772, 650);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(50, 40);
            this.tbY2.TabIndex = 4;
            this.tbY2.Text = "-5";
            // 
            // drawingArea
            // 
            this.drawingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingArea.Location = new System.Drawing.Point(6, 27);
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.Size = new System.Drawing.Size(760, 663);
            this.drawingArea.TabIndex = 0;
            // 
            // tbY1
            // 
            this.tbY1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbY1.Location = new System.Drawing.Point(772, 27);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(50, 40);
            this.tbY1.TabIndex = 5;
            this.tbY1.Text = "5";
            // 
            // dgvFormulae
            // 
            this.dgvFormulae.AutoGenerateColumns = false;
            this.dgvFormulae.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulae.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.formulaBodyDataGridViewTextBoxColumn,
            this.colorLineDataGridViewTextBoxColumn,
            this.widthLineDataGridViewTextBoxColumn});
            this.dgvFormulae.DataSource = this.formulaBindingSource;
            this.dgvFormulae.Location = new System.Drawing.Point(14, 103);
            this.dgvFormulae.MultiSelect = false;
            this.dgvFormulae.Name = "dgvFormulae";
            this.dgvFormulae.ReadOnly = true;
            this.dgvFormulae.Size = new System.Drawing.Size(180, 150);
            this.dgvFormulae.TabIndex = 18;
            // 
            // formulaBodyDataGridViewTextBoxColumn
            // 
            this.formulaBodyDataGridViewTextBoxColumn.DataPropertyName = "FormulaBody";
            this.formulaBodyDataGridViewTextBoxColumn.HeaderText = "Formula";
            this.formulaBodyDataGridViewTextBoxColumn.Name = "formulaBodyDataGridViewTextBoxColumn";
            this.formulaBodyDataGridViewTextBoxColumn.ReadOnly = true;
            this.formulaBodyDataGridViewTextBoxColumn.Width = 60;
            // 
            // colorLineDataGridViewTextBoxColumn
            // 
            this.colorLineDataGridViewTextBoxColumn.DataPropertyName = "ColorLine";
            this.colorLineDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorLineDataGridViewTextBoxColumn.Name = "colorLineDataGridViewTextBoxColumn";
            this.colorLineDataGridViewTextBoxColumn.ReadOnly = true;
            this.colorLineDataGridViewTextBoxColumn.Width = 50;
            // 
            // widthLineDataGridViewTextBoxColumn
            // 
            this.widthLineDataGridViewTextBoxColumn.DataPropertyName = "WidthLine";
            this.widthLineDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthLineDataGridViewTextBoxColumn.Name = "widthLineDataGridViewTextBoxColumn";
            this.widthLineDataGridViewTextBoxColumn.ReadOnly = true;
            this.widthLineDataGridViewTextBoxColumn.Width = 50;
            // 
            // formulaBindingSource
            // 
            this.formulaBindingSource.DataSource = typeof(GraphDrawing.Formula);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1047, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Drawing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formulaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bnRun;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel drawingArea;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.Panel pnAxes;
        private System.Windows.Forms.Button bnAxes;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel pnGrid;
        private System.Windows.Forms.Button bnGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvFormulae;
        private System.Windows.Forms.BindingSource formulaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn formulaBodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthLineDataGridViewTextBoxColumn;
    }
}

