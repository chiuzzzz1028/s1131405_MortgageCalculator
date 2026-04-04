namespace _1131405_邱懷萱_房貸計算器
{
    partial class frmHouse
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtDownPaymentPercent = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.cmbLoanTerm = new System.Windows.Forms.ComboBox();
            this.numGracePeriod = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblTotalLoan = new System.Windows.Forms.Label();
            this.lblMonthlyPay = new System.Windows.Forms.Label();
            this.lblFirstInterest = new System.Windows.Forms.Label();
            this.lblFirstPrincipal = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblResultTotalLoan = new System.Windows.Forms.Label();
            this.lblResultMonthlyPay = new System.Windows.Forms.Label();
            this.lblResultFirstInterest = new System.Windows.Forms.Label();
            this.lblResultFirstPrincipal = new System.Windows.Forms.Label();
            this.lblResultTotalInterest = new System.Windows.Forms.Label();
            this.lblResultTotalAmount = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGracePeriod)).BeginInit();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(25, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 496);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.grpInput);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(875, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "請輸入";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSlateGray;
            this.tabPage2.Controls.Add(this.btnClose);
            this.tabPage2.Controls.Add(this.grpOutput);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage2.Size = new System.Drawing.Size(875, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "結果";
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpInput.Controls.Add(this.label10);
            this.grpInput.Controls.Add(this.label9);
            this.grpInput.Controls.Add(this.label8);
            this.grpInput.Controls.Add(this.label7);
            this.grpInput.Controls.Add(this.label6);
            this.grpInput.Controls.Add(this.numGracePeriod);
            this.grpInput.Controls.Add(this.cmbLoanTerm);
            this.grpInput.Controls.Add(this.txtInterestRate);
            this.grpInput.Controls.Add(this.txtDownPaymentPercent);
            this.grpInput.Controls.Add(this.txtTotalPrice);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpInput.Location = new System.Drawing.Point(28, 35);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(654, 385);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "使用者資訊：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "房屋總價：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(19, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "自備款比例：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "貸款利率：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(19, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "貸款年限：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "寬限期：";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(157, 46);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(165, 37);
            this.txtTotalPrice.TabIndex = 5;
            // 
            // txtDownPaymentPercent
            // 
            this.txtDownPaymentPercent.Location = new System.Drawing.Point(157, 108);
            this.txtDownPaymentPercent.Name = "txtDownPaymentPercent";
            this.txtDownPaymentPercent.Size = new System.Drawing.Size(165, 37);
            this.txtDownPaymentPercent.TabIndex = 6;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(157, 173);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(165, 37);
            this.txtInterestRate.TabIndex = 7;
            // 
            // cmbLoanTerm
            // 
            this.cmbLoanTerm.FormattingEnabled = true;
            this.cmbLoanTerm.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.cmbLoanTerm.Location = new System.Drawing.Point(157, 238);
            this.cmbLoanTerm.Name = "cmbLoanTerm";
            this.cmbLoanTerm.Size = new System.Drawing.Size(165, 36);
            this.cmbLoanTerm.TabIndex = 8;
            // 
            // numGracePeriod
            // 
            this.numGracePeriod.Location = new System.Drawing.Point(157, 310);
            this.numGracePeriod.Name = "numGracePeriod";
            this.numGracePeriod.Size = new System.Drawing.Size(165, 37);
            this.numGracePeriod.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(347, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "萬元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(347, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "百分比(%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(347, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "百分比(%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(347, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "年";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(347, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 25);
            this.label10.TabIndex = 14;
            this.label10.Text = "年";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightBlue;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalculate.Location = new System.Drawing.Point(714, 372);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 48);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "計算";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(714, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 48);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpOutput.Controls.Add(this.label16);
            this.grpOutput.Controls.Add(this.label15);
            this.grpOutput.Controls.Add(this.label14);
            this.grpOutput.Controls.Add(this.label13);
            this.grpOutput.Controls.Add(this.label12);
            this.grpOutput.Controls.Add(this.label11);
            this.grpOutput.Controls.Add(this.lblResultTotalAmount);
            this.grpOutput.Controls.Add(this.lblResultTotalInterest);
            this.grpOutput.Controls.Add(this.lblResultFirstPrincipal);
            this.grpOutput.Controls.Add(this.lblResultFirstInterest);
            this.grpOutput.Controls.Add(this.lblResultMonthlyPay);
            this.grpOutput.Controls.Add(this.lblResultTotalLoan);
            this.grpOutput.Controls.Add(this.lblTotalAmount);
            this.grpOutput.Controls.Add(this.lblTotalInterest);
            this.grpOutput.Controls.Add(this.lblFirstPrincipal);
            this.grpOutput.Controls.Add(this.lblFirstInterest);
            this.grpOutput.Controls.Add(this.lblMonthlyPay);
            this.grpOutput.Controls.Add(this.lblTotalLoan);
            this.grpOutput.Location = new System.Drawing.Point(20, 19);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(637, 413);
            this.grpOutput.TabIndex = 0;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "試算結果：";
            // 
            // lblTotalLoan
            // 
            this.lblTotalLoan.AutoSize = true;
            this.lblTotalLoan.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalLoan.Location = new System.Drawing.Point(17, 49);
            this.lblTotalLoan.Name = "lblTotalLoan";
            this.lblTotalLoan.Size = new System.Drawing.Size(132, 25);
            this.lblTotalLoan.TabIndex = 0;
            this.lblTotalLoan.Text = "貸款總金額：";
            // 
            // lblMonthlyPay
            // 
            this.lblMonthlyPay.AutoSize = true;
            this.lblMonthlyPay.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonthlyPay.Location = new System.Drawing.Point(17, 107);
            this.lblMonthlyPay.Name = "lblMonthlyPay";
            this.lblMonthlyPay.Size = new System.Drawing.Size(152, 25);
            this.lblMonthlyPay.TabIndex = 1;
            this.lblMonthlyPay.Text = "每月應繳金額：";
            // 
            // lblFirstInterest
            // 
            this.lblFirstInterest.AutoSize = true;
            this.lblFirstInterest.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstInterest.Location = new System.Drawing.Point(17, 166);
            this.lblFirstInterest.Name = "lblFirstInterest";
            this.lblFirstInterest.Size = new System.Drawing.Size(112, 25);
            this.lblFirstInterest.TabIndex = 2;
            this.lblFirstInterest.Text = "首期利息：";
            // 
            // lblFirstPrincipal
            // 
            this.lblFirstPrincipal.AutoSize = true;
            this.lblFirstPrincipal.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstPrincipal.Location = new System.Drawing.Point(17, 228);
            this.lblFirstPrincipal.Name = "lblFirstPrincipal";
            this.lblFirstPrincipal.Size = new System.Drawing.Size(112, 25);
            this.lblFirstPrincipal.TabIndex = 3;
            this.lblFirstPrincipal.Text = "首期本金：";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalInterest.Location = new System.Drawing.Point(17, 294);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(132, 25);
            this.lblTotalInterest.TabIndex = 4;
            this.lblTotalInterest.Text = "總利息支出：";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalAmount.Location = new System.Drawing.Point(17, 358);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(132, 25);
            this.lblTotalAmount.TabIndex = 5;
            this.lblTotalAmount.Text = "總還款金額：";
            // 
            // lblResultTotalLoan
            // 
            this.lblResultTotalLoan.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultTotalLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultTotalLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultTotalLoan.Location = new System.Drawing.Point(175, 46);
            this.lblResultTotalLoan.Name = "lblResultTotalLoan";
            this.lblResultTotalLoan.Size = new System.Drawing.Size(198, 31);
            this.lblResultTotalLoan.TabIndex = 6;
            this.lblResultTotalLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultMonthlyPay
            // 
            this.lblResultMonthlyPay.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultMonthlyPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultMonthlyPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultMonthlyPay.Location = new System.Drawing.Point(175, 104);
            this.lblResultMonthlyPay.Name = "lblResultMonthlyPay";
            this.lblResultMonthlyPay.Size = new System.Drawing.Size(198, 31);
            this.lblResultMonthlyPay.TabIndex = 7;
            this.lblResultMonthlyPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultFirstInterest
            // 
            this.lblResultFirstInterest.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultFirstInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFirstInterest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultFirstInterest.Location = new System.Drawing.Point(175, 166);
            this.lblResultFirstInterest.Name = "lblResultFirstInterest";
            this.lblResultFirstInterest.Size = new System.Drawing.Size(198, 31);
            this.lblResultFirstInterest.TabIndex = 8;
            this.lblResultFirstInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultFirstPrincipal
            // 
            this.lblResultFirstPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultFirstPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFirstPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultFirstPrincipal.Location = new System.Drawing.Point(175, 225);
            this.lblResultFirstPrincipal.Name = "lblResultFirstPrincipal";
            this.lblResultFirstPrincipal.Size = new System.Drawing.Size(198, 31);
            this.lblResultFirstPrincipal.TabIndex = 9;
            this.lblResultFirstPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultTotalInterest
            // 
            this.lblResultTotalInterest.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultTotalInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultTotalInterest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultTotalInterest.Location = new System.Drawing.Point(175, 291);
            this.lblResultTotalInterest.Name = "lblResultTotalInterest";
            this.lblResultTotalInterest.Size = new System.Drawing.Size(198, 31);
            this.lblResultTotalInterest.TabIndex = 10;
            this.lblResultTotalInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResultTotalAmount
            // 
            this.lblResultTotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblResultTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultTotalAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResultTotalAmount.Location = new System.Drawing.Point(175, 355);
            this.lblResultTotalAmount.Name = "lblResultTotalAmount";
            this.lblResultTotalAmount.Size = new System.Drawing.Size(198, 31);
            this.lblResultTotalAmount.TabIndex = 11;
            this.lblResultTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(392, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "萬元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(392, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "萬元";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(392, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "萬元";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(392, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "萬元";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(392, 294);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "萬元";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(392, 358);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "萬元";
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Location = new System.Drawing.Point(698, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 54);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmHouse
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 544);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "房貸計算器";
            this.Load += new System.EventHandler(this.frmHouse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGracePeriod)).EndInit();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownPaymentPercent;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numGracePeriod;
        private System.Windows.Forms.ComboBox cmbLoanTerm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label lblFirstPrincipal;
        private System.Windows.Forms.Label lblFirstInterest;
        private System.Windows.Forms.Label lblMonthlyPay;
        private System.Windows.Forms.Label lblTotalLoan;
        private System.Windows.Forms.Label lblResultTotalLoan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblResultTotalAmount;
        private System.Windows.Forms.Label lblResultTotalInterest;
        private System.Windows.Forms.Label lblResultFirstPrincipal;
        private System.Windows.Forms.Label lblResultFirstInterest;
        private System.Windows.Forms.Label lblResultMonthlyPay;
    }
}

