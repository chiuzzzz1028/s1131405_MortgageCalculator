using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1131405_邱懷萱_房貸計算器
{
    public partial class frmHouse : Form
    {
        public frmHouse()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. 專業防呆：檢查是否輸入數字
            bool p1 = double.TryParse(txtTotalPrice.Text, out double totalPrice);
            bool p2 = double.TryParse(txtDownPaymentPercent.Text, out double downPaymentRateValue);
            bool p3 = double.TryParse(txtInterestRate.Text, out double annualRateValue);

            if (!p1 || !p2 || !p3 || cmbLoanTerm.SelectedItem == null)
            {
                MessageBox.Show("請填寫所有欄位並確保輸入的是數字喔！", "提示");
                return;
            }

            try
            {
                // 2. 取得數值
                double downPaymentRate = downPaymentRateValue / 100;
                double annualRate = annualRateValue / 100;
                int loanYears = int.Parse(cmbLoanTerm.SelectedItem.ToString());
                int graceYears = (int)numGracePeriod.Value;

                // 3. 核心計算邏輯 (本息平均攤還)
                double loanAmount = totalPrice * (1 - downPaymentRate);
                double monthlyRate = annualRate / 12;
                int totalMonths = loanYears * 12;
                int graceMonths = graceYears * 12;
                int repayMonths = totalMonths - graceMonths;

                double monthlyPayment = 0;
                if (repayMonths > 0)
                {
                    monthlyPayment = loanAmount * (Math.Pow(1 + monthlyRate, repayMonths) * monthlyRate)
                                     / (Math.Pow(1 + monthlyRate, repayMonths) - 1);
                }

                double firstInterest = loanAmount * monthlyRate;
                double firstPrincipal = (graceMonths > 0) ? 0 : (monthlyPayment - firstInterest);
                double totalRepay = (firstInterest * graceMonths) + (monthlyPayment * repayMonths);
                double totalInt = totalRepay - loanAmount;

                // 4. 直接更新「結果」分頁的 Label (不需跨視窗)
                lblResultTotalLoan.Text = loanAmount.ToString("N2");
                lblResultMonthlyPay.Text = monthlyPayment.ToString("N2");
                lblResultFirstInterest.Text = firstInterest.ToString("N2");
                lblResultFirstPrincipal.Text = firstPrincipal.ToString("N2");
                lblResultTotalInterest.Text = totalInt.ToString("N2");
                lblResultTotalAmount.Text = totalRepay.ToString("N2");

                // 5. 【關鍵加分點】自動切換到第二個分頁 (Index 從 0 開始，所以 1 是結果頁)
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("計算發生意外錯誤：" + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. 清除輸入區
            txtTotalPrice.Clear();
            txtDownPaymentPercent.Text = "20"; // 維持老師建議的引導數值
            txtInterestRate.Text = "2.15";
            numGracePeriod.Value = 0;

            // 2. 清除結果區 (這很重要，不然第二頁會留著舊資料)
            lblResultTotalLoan.Text = "0.00";
            lblResultMonthlyPay.Text = "0.00";
            lblResultFirstInterest.Text = "0.00";
            lblResultFirstPrincipal.Text = "0.00";
            lblResultTotalInterest.Text = "0.00";
            lblResultTotalAmount.Text = "0.00";

            // 3. 回到第一個分頁並聚焦總價
            tabControl1.SelectedIndex = 0;
            txtTotalPrice.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmHouse_Load(object sender, EventArgs e)
        {
            // 程式啟動時自動填入預設值，這就是老師要的「貼心輔助」
            txtDownPaymentPercent.Text = "20"; // 預設自備款 20%
            txtInterestRate.Text = "2.15";     // 預設利率 2.15%

            if (cmbLoanTerm.Items.Count > 1)
            {
                cmbLoanTerm.SelectedIndex = 1; // 預設選擇 30 年 (假設 index 1 是 30 年)
            }

            numGracePeriod.Value = 0; // 預設無寬限期
        }
    }
}
