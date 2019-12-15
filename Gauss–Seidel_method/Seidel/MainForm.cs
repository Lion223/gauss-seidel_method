using System;
using System.Drawing;
using System.Windows.Forms;

namespace Seidel
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private double[] a;
        private double[] b;
        private double[] x;
        private double[] res;
        private int iterations;
        private double eps;
        private SLE sle = null;
        private SeidelMethod sMethod = null;

        public MainForm()
        {
            InitializeComponent();
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            iterRb.Checked = true;
            resIterLbl.Visible = false;
            iterLbl.Visible = false;
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            if (checkTextBoxes())
            {
                Solve();
                displayResults();
            }
        }

        private bool checkTextBoxes()
        {
            try
            {
                a = new double[9] { Double.Parse(a11Tb.Text), Double.Parse(a12Tb.Text), Double.Parse(a13Tb.Text),
                    Double.Parse(a21Tb.Text), Double.Parse(a22Tb.Text), Double.Parse(a23Tb.Text),
                    Double.Parse(a31Tb.Text), Double.Parse(a32Tb.Text), Double.Parse(a33Tb.Text)
                };
                b = new double[3] { Double.Parse(b1Tb.Text), Double.Parse(b2Tb.Text), Double.Parse(b3Tb.Text) };
                x = new double[3] { Double.Parse(x1Tb.Text), Double.Parse(x2Tb.Text), Double.Parse(x3Tb.Text) };
                iterations = int.Parse(iterTb.Text);
                eps = Double.Parse(epsTb.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Дані введено неправильно!");
                return false;
            }
            return true;
        }

        public void Solve()
        {
            sle = new SLE(a, b, x);
            if (epsRb.Checked)
            {
                sMethod = new SeidelMethod(sle);
                res = sMethod.Solve(eps);
            }
            else
            {
                sMethod = new SeidelMethod(sle);
                res = sMethod.Solve(iterations);
            }

        }

        public void displayResults()
        {
            res1Tb.Text = res[0].ToString();
            res2Tb.Text = res[1].ToString();
            res3Tb.Text = res[2].ToString();

            iterLbl.Text = sMethod.getIterationCount().ToString();
            resIterLbl.Visible = true;
            iterLbl.Visible = true;
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            a11Tb.Text = "13,2";
            a12Tb.Text = "1,9";
            a13Tb.Text = "2,3";

            a21Tb.Text = "0,8";
            a22Tb.Text = "-7,3";
            a23Tb.Text = "-0,7";

            a31Tb.Text = "0,5";
            a32Tb.Text = "-1,4";
            a33Tb.Text = "-9,6";

            b1Tb.Text = "5,12";
            b2Tb.Text = "5,2";
            b3Tb.Text = "1,5";

            x1Tb.Text = "0";
            x2Tb.Text = "0";
            x3Tb.Text = "0";

            epsTb.Text = "0,001";
            iterTb.Text = "0";

            epsRb.Checked = true;
        }

        private void iterRb_CheckedChanged(object sender, EventArgs e)
        {
            if (iterRb.Checked)
            {
                iterTb.Enabled = true;
                epsTb.Enabled = false;
                iterTb.BackColor = Color.FromArgb(255, 255, 255);
                epsTb.BackColor = Color.Gray;
            }
        }

        private void epsRb_CheckedChanged(object sender, EventArgs e)
        {
            if (epsRb.Checked)
            {
                iterTb.Enabled = false;
                epsTb.Enabled = true;
                epsTb.BackColor = Color.FromArgb(255, 255, 255);
                iterTb.BackColor = Color.Gray;
            }
        }

        private void resGridBtn_Click(object sender, EventArgs e)
        {
            if (sMethod != null)
                sMethod.showResultsGrid();
        }
    }
}
