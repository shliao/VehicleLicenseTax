
namespace VehicleLicenseTax
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbPerior1 = new System.Windows.Forms.RadioButton();
            this.rbPerior2 = new System.Windows.Forms.RadioButton();
            this.dtpPeriorStart = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriorEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCarType = new System.Windows.Forms.ComboBox();
            this.cbbDisplacement = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxTotalResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(140, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(188, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "用途";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數／馬達馬力";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(140, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "試算結果";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(267, 622);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 41);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "確定送出";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(468, 622);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 41);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "取消重填";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbPerior1
            // 
            this.rbPerior1.AutoSize = true;
            this.rbPerior1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPerior1.Location = new System.Drawing.Point(267, 36);
            this.rbPerior1.Name = "rbPerior1";
            this.rbPerior1.Size = new System.Drawing.Size(110, 34);
            this.rbPerior1.TabIndex = 9;
            this.rbPerior1.TabStop = true;
            this.rbPerior1.Text = "全年度";
            this.rbPerior1.UseVisualStyleBackColor = true;
            this.rbPerior1.CheckedChanged += new System.EventHandler(this.rbPerior1_CheckedChanged);
            // 
            // rbPerior2
            // 
            this.rbPerior2.AutoSize = true;
            this.rbPerior2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbPerior2.Location = new System.Drawing.Point(413, 36);
            this.rbPerior2.Name = "rbPerior2";
            this.rbPerior2.Size = new System.Drawing.Size(110, 34);
            this.rbPerior2.TabIndex = 10;
            this.rbPerior2.TabStop = true;
            this.rbPerior2.Text = "依期間";
            this.rbPerior2.UseVisualStyleBackColor = true;
            this.rbPerior2.CheckedChanged += new System.EventHandler(this.rbPerior2_CheckedChanged);
            // 
            // dtpPeriorStart
            // 
            this.dtpPeriorStart.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpPeriorStart.Location = new System.Drawing.Point(10, 72);
            this.dtpPeriorStart.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpPeriorStart.MinDate = new System.DateTime(1922, 1, 1, 0, 0, 0, 0);
            this.dtpPeriorStart.Name = "dtpPeriorStart";
            this.dtpPeriorStart.Size = new System.Drawing.Size(240, 39);
            this.dtpPeriorStart.TabIndex = 11;
            // 
            // dtpPeriorEnd
            // 
            this.dtpPeriorEnd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpPeriorEnd.Location = new System.Drawing.Point(10, 192);
            this.dtpPeriorEnd.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpPeriorEnd.MinDate = new System.DateTime(1922, 1, 1, 0, 0, 0, 0);
            this.dtpPeriorEnd.Name = "dtpPeriorEnd";
            this.dtpPeriorEnd.Size = new System.Drawing.Size(240, 39);
            this.dtpPeriorEnd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(117, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "從";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(117, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "至";
            // 
            // cbbCarType
            // 
            this.cbbCarType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbCarType.FormattingEnabled = true;
            this.cbbCarType.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbbCarType.Location = new System.Drawing.Point(267, 100);
            this.cbbCarType.Name = "cbbCarType";
            this.cbbCarType.Size = new System.Drawing.Size(256, 38);
            this.cbbCarType.TabIndex = 15;
            this.cbbCarType.SelectedIndexChanged += new System.EventHandler(this.cbbCarType_SelectedIndexChanged);
            // 
            // cbbDisplacement
            // 
            this.cbbDisplacement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDisplacement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbDisplacement.FormattingEnabled = true;
            this.cbbDisplacement.Location = new System.Drawing.Point(267, 155);
            this.cbbDisplacement.Name = "cbbDisplacement";
            this.cbbDisplacement.Size = new System.Drawing.Size(485, 38);
            this.cbbDisplacement.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxTotalResult);
            this.panel1.Location = new System.Drawing.Point(255, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 401);
            this.panel1.TabIndex = 17;
            // 
            // txtBoxTotalResult
            // 
            this.txtBoxTotalResult.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxTotalResult.Location = new System.Drawing.Point(3, 3);
            this.txtBoxTotalResult.Multiline = true;
            this.txtBoxTotalResult.Name = "txtBoxTotalResult";
            this.txtBoxTotalResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxTotalResult.Size = new System.Drawing.Size(557, 395);
            this.txtBoxTotalResult.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpPeriorStart);
            this.panel2.Controls.Add(this.dtpPeriorEnd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(821, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 242);
            this.panel2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(826, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "總金額為:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 679);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbDisplacement);
            this.Controls.Add(this.cbbCarType);
            this.Controls.Add(this.rbPerior2);
            this.Controls.Add(this.rbPerior1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VehicleLicenseTax";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbPerior1;
        private System.Windows.Forms.RadioButton rbPerior2;
        private System.Windows.Forms.DateTimePicker dtpPeriorStart;
        private System.Windows.Forms.DateTimePicker dtpPeriorEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCarType;
        private System.Windows.Forms.ComboBox cbbDisplacement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxTotalResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}

