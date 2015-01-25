using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphDrawing
{
    public partial class FormulaDialog : Form
    {
        private Color LineColor
        {
            get { return pnFormulaLine.BackColor; }
            set { pnFormulaLine.BackColor = value; }
        }
        private Single LineWidth
        {

            get { return Convert.ToSingle(tbWidth.Text); }
            set { tbWidth.Text = value.ToString(); }
        }

        private String FormulaBody
        {
            get { return tbFormula.Text; }
            set { tbFormula.Text = value; }
        }

        public Formula DialogDatum { get; set; }

        public FormulaDialog()
        {
            InitializeComponent();
            LineColor = Color.Black;
            LineWidth = 1;
            FormulaBody = "sin(x)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {               
                LineColor = colorDialog.Color;
            }
        }

        private void bnAdd_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            DialogDatum = new Formula();
            DialogDatum.ColorLine = LineColor;
            DialogDatum.WidthLine = LineWidth;
            DialogDatum.FormulaBody = FormulaBody;
            this.Close();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
