using System;
using System.Drawing;
using System.Windows.Forms;
using StepLib;

namespace StepWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đặt font Unicode đẹp, tránh lỗi hiển thị
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.Text = "Số Bước — by Học";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            StepCalculator sc = new StepCalculator();
            sc.DistanceKm = SafeParse.PositiveDouble(txtKm.Text);
            sc.WeightKg = SafeParse.PositiveDouble(txtKg.Text);
            sc.StepLengthM = SafeParse.PositiveDouble(txtStep.Text);
            sc.HocFactor = 1.0;
            sc.Signature = "by Học";

            txtResult.Text = sc.FormatResult();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
