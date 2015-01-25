using Evaluation;
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
    public partial class MainForm : Form
    {
        private Color AxesColor { get; set; }
        private Color GridColor { get; set; }
        private List<Formula> Formulae { get; set; }
        private Graphics FormGraphics { get; set; }

        public MainForm()
        {
            InitializeComponent();
            AxesColor = Color.Green;
            GridColor = Color.LightGray;
            pnAxes.BackColor = AxesColor;
            pnGrid.BackColor = GridColor;
            Formulae = new List<Formula>();
            FormGraphics = drawingArea.CreateGraphics();
        }

        private void bnRun_Click(object sender, EventArgs e)
        {
            DrawGrid();
            DrawLine();
        }

        private void DrawGrid()
        {
            double x1 = Convert.ToDouble(tbX1.Text);
            double x2 = Convert.ToDouble(tbX2.Text);
            double y1 = Convert.ToDouble(tbY1.Text);
            double y2 = Convert.ToDouble(tbY2.Text);
            Int32 W = drawingArea.Size.Width;
            Int32 H = drawingArea.Size.Height;

            System.Drawing.Pen gridPen = new System.Drawing.Pen(GridColor);
            System.Drawing.Pen zeroPen = new System.Drawing.Pen(AxesColor);
            System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(0, 0, W - 1, H - 1);
            FormGraphics.FillRectangle(brush, rectangle);

            Double xStep = DrawingHelper.GetGridStep(x2 - x1);
            for (double x = DrawingHelper.GetGridFirstPoint(x1, xStep); x <= x2; x += xStep)
            {
                Point p1 = new Point(DrawingHelper.ValueToPoint(x1, x2, x, W), 0);
                Point p2 = new Point(p1.X, H);

                FormGraphics.DrawLine(x == 0 ? zeroPen : gridPen, p1, p2);
            }

            Double yStep = DrawingHelper.GetGridStep(y2 - y1);
            for (double y = DrawingHelper.GetGridFirstPoint(y2, yStep); y <= y1; y += yStep)
            {
                Point p1 = new Point(0, DrawingHelper.ValueToPoint(y1, y2, y, H));
                Point p2 = new Point(W, p1.Y);

                FormGraphics.DrawLine(y == 0 ? zeroPen : gridPen, p1, p2);
            }

            FormGraphics.DrawRectangle(System.Drawing.Pens.Black, rectangle);
        }

        private void DrawLine()
        {
            Int32 W = drawingArea.Size.Width;
            Int32 H = drawingArea.Size.Height;
            Double x1 = Convert.ToDouble(tbX1.Text);
            Double x2 = Convert.ToDouble(tbX2.Text);
            Double y1 = Convert.ToDouble(tbY1.Text);
            Double y2 = Convert.ToDouble(tbY2.Text);
            Double h = Math.Abs((x1 - x2) / W);

            foreach (Formula item in Formulae)
            {
                Evaluator val = new Evaluator(item.FormulaBody);
                Evaluation.Point<Double>[] pointsVal = val.Evaluate(x1, x2, h).ToArray();
                Evaluation.Point<Int32>[] graphVal = DrawingHelper.ValuesToPoints(pointsVal, W, H, y1, y2);
                System.Drawing.Pen myPen = new System.Drawing.Pen(item.ColorLine);
                myPen.Width = item.WidthLine;
                Point[] apt = graphVal.Select(x => new Point(x.X, x.Y)).ToArray();
                FormGraphics.DrawCurve(myPen, apt);
            }
        }

        private void bnAxes_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pnAxes.BackColor = colorDialog.Color;
                AxesColor = colorDialog.Color;
            }
        }

        private void bnGrid_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pnGrid.BackColor = colorDialog.Color;
                GridColor = colorDialog.Color;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormulaDialog fmDialog = new FormulaDialog();
            DialogResult result = fmDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                Formulae.Add(fmDialog.DialogDatum);
            dgvFormulae.DataSource = null;
            dgvFormulae.DataSource = Formulae;
            fmDialog.Dispose();
        }

    }
}
