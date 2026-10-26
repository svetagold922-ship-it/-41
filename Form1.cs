using System;
using System.Drawing;
using System.Windows.Forms;

namespace test45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            lblResult.ForeColor = Color.White;

            bool isA = int.TryParse(txtSideA.Text, out int a);
            bool isB = int.TryParse(txtSideB.Text, out int b);
            bool isC = int.TryParse(txtSideC.Text, out int c);

            if (!isA || !isB || !isC)
            {
                lblResult.Text = "Ошибка: введите целые числа!";
                lblResult.ForeColor = Color.Red;
                btnReset.Visible = true;
                return;
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                lblResult.Text = "Ошибка: стороны должны быть > 0";
                lblResult.ForeColor = Color.Red;
                btnReset.Visible = true;
                return;
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                lblResult.Text = "Это не треугольник";
                lblResult.ForeColor = Color.Red;
                btnReset.Visible = true;
                return;
            }

            if (a == b && b == c)
            {
                lblResult.Text = "Треугольник равносторонний";
            }
            else if (a == b || a == c || b == c)
            {
                lblResult.Text = "Треугольник равнобедренный";
            }
            else
            {
                lblResult.Text = "Треугольник разносторонний";
            }

            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSideA.Clear();
            txtSideB.Clear();
            txtSideC.Clear();
            lblResult.Text = "";
            btnReset.Visible = false;
            txtSideA.Focus();
        }
    }
}