using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLicenseTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary> 根據選擇不同車型類別，變更內容清單選項 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region (Car Type)
        private void cbbCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbCarType.SelectedIndex == 0)
            {
                this.cbbDisplacement.Items.Clear();
                this.cbbDisplacement.Items.Add("150以下 / 12HP以下(12.2PS以下)");
                this.cbbDisplacement.Items.Add("151-250 / 12.1-20HP(12.3-20.3PS)");
                this.cbbDisplacement.Items.Add("251-500 / 20.1HP以上(20.4PS以上)");
                this.cbbDisplacement.Items.Add("501-600");
                this.cbbDisplacement.Items.Add("601-1200");
                this.cbbDisplacement.Items.Add("1201-1800");
                this.cbbDisplacement.Items.Add("1801或以上");
            }

            if (this.cbbCarType.SelectedIndex == 1)
            {
                this.cbbDisplacement.Items.Clear();
                this.cbbDisplacement.Items.Add("500以下");
                this.cbbDisplacement.Items.Add("501-600");
                this.cbbDisplacement.Items.Add("601-1200");
                this.cbbDisplacement.Items.Add("1201-1800");
                this.cbbDisplacement.Items.Add("1801-2400");
                this.cbbDisplacement.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.cbbDisplacement.Items.Add("3001-3600");
                this.cbbDisplacement.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.cbbDisplacement.Items.Add("4201-4800");
                this.cbbDisplacement.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.cbbDisplacement.Items.Add("5401-6000");
                this.cbbDisplacement.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.cbbDisplacement.Items.Add("6601-7200");
                this.cbbDisplacement.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                this.cbbDisplacement.Items.Add("7801-8400");
                this.cbbDisplacement.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.cbbDisplacement.Items.Add("9001-9600");
                this.cbbDisplacement.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.cbbDisplacement.Items.Add("10201以上");
            }

            if (this.cbbCarType.SelectedIndex == 2)
            {
                this.cbbDisplacement.Items.Clear();
                this.cbbDisplacement.Items.Add("600以下");
                this.cbbDisplacement.Items.Add("601-1200");
                this.cbbDisplacement.Items.Add("1201-1800");
                this.cbbDisplacement.Items.Add("1801-2400");
                this.cbbDisplacement.Items.Add("2401-3000 / 138HP以下(140.1PS以下)");
                this.cbbDisplacement.Items.Add("3001-3600");
                this.cbbDisplacement.Items.Add("3601-4200 / 138.1-200HP(140.2-203.0PS)");
                this.cbbDisplacement.Items.Add("4201-4800");
                this.cbbDisplacement.Items.Add("4801-5400 / 200.1-247HP(203.1-250.7PS)");
                this.cbbDisplacement.Items.Add("5401-6000");
                this.cbbDisplacement.Items.Add("6001-6600 / 247.1-286HP(250.8-290.3PS)");
                this.cbbDisplacement.Items.Add("6601-7200");
                this.cbbDisplacement.Items.Add("7201-7800 / 286.1-336HP(290.4-341.0PS)");
                this.cbbDisplacement.Items.Add("7801-8400");
                this.cbbDisplacement.Items.Add("8401-9000 / 336.1-361HP(341.1-366.4PS)");
                this.cbbDisplacement.Items.Add("9001-9600");
                this.cbbDisplacement.Items.Add("9601-10200 / 361.1HP以上(366.5PS以上)");
                this.cbbDisplacement.Items.Add("10201以上");
            }

            if (this.cbbCarType.SelectedIndex == 3)
            {
                this.cbbDisplacement.Items.Clear();
                this.cbbDisplacement.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.cbbDisplacement.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.cbbDisplacement.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.cbbDisplacement.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.cbbDisplacement.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.cbbDisplacement.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.cbbDisplacement.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS");
                this.cbbDisplacement.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.cbbDisplacement.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.cbbDisplacement.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.cbbDisplacement.Items.Add("7801以上");
            }

            if (this.cbbCarType.SelectedIndex == 4)
            {
                this.cbbDisplacement.Items.Clear();
                this.cbbDisplacement.Items.Add("500以下 / 38HP以下(38.6PS以下)");
                this.cbbDisplacement.Items.Add("501~600 / 38.1-56HP(38.7-56.8PS)");
                this.cbbDisplacement.Items.Add("601~1200 / 56.1-83HP(56.9-84.2PS)");
                this.cbbDisplacement.Items.Add("1201~1800 / 83.1-182HP(84.3-184.7PS)");
                this.cbbDisplacement.Items.Add("1801~2400 / 182.1-262HP(184.8-265.9PS)");
                this.cbbDisplacement.Items.Add("2401~3000 / 262.1-322HP(266-326.8PS)");
                this.cbbDisplacement.Items.Add("3001-4200 / 322.1-414HP(326.9-420.2PS)");
                this.cbbDisplacement.Items.Add("4201-5400 / 414.1-469HP(420.3-476.0PS)");
                this.cbbDisplacement.Items.Add("5401-6600 / 469.1-509HP(476.1-516.6PS)");
                this.cbbDisplacement.Items.Add("6601-7800 / 509.1HP以上(516.7PS以上)");
                this.cbbDisplacement.Items.Add("7801以上");
            }
        }
        #endregion

        /// <summary> 依照選取類型，顯示或關閉日曆 </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region (Perior Type)
        private void rbPerior2_CheckedChanged(object sender, EventArgs e)
        {
            //選擇依期間，開放日期區間
            this.panel2.Visible = true;
            this.label7.Visible = true;
            this.cbbCarType.SelectedIndex = 0;
            this.cbbDisplacement.SelectedIndex = 0;
            this.txtBoxTotalResult.Text = "";
            this.label7.Text = "總金額為:";
        }

        private void rbPerior1_CheckedChanged(object sender, EventArgs e)
        {
            //選擇全年度，隱藏日期區間
            this.panel2.Visible = false;
            this.label7.Visible = false;
            this.cbbCarType.SelectedIndex = 0;
            this.cbbDisplacement.SelectedIndex = 0;
            this.txtBoxTotalResult.Text = "";
            this.label7.Text = "總金額為:";
        }
        #endregion

        //載入初始值
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        //恢復初始值
        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //選擇全年度
            if (rbPerior1.Checked)
            {
                DateTime thisYear = new DateTime(DateTime.Now.Ticks);

                //選擇車型，建立 List 內容
                if (this.cbbCarType.SelectedIndex == 0)
                {
                    decimal perc = (decimal)this.GetTaxMotorcycle();

                    decimal total = perc * isLeapYear() / isLeapYear();

                    this.txtBoxTotalResult.Text =
                        $"使用期間: {thisYear.Year} - 01 - 01 ~ {thisYear.Year} - 12 - 31" +
                        Environment.NewLine +
                        $"計算天數: {isLeapYear()}天" +
                        Environment.NewLine +
                        $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                        Environment.NewLine +
                        $"用途: {this.cbbCarType.SelectedItem}" +
                        Environment.NewLine +
                        $"計算公式: {perc} * {isLeapYear()} / {isLeapYear()} = {total}元" +
                        Environment.NewLine +
                        $"應納稅額: 共 {total} 元";
                }

                if (this.cbbCarType.SelectedIndex == 1)
                {
                    decimal perc = (decimal)this.GetTaxTruck();

                    decimal total = perc * isLeapYear() / isLeapYear();

                    this.txtBoxTotalResult.Text =
                        $"使用期間: {thisYear.Year} - 01 - 01 ~ {thisYear.Year} - 12 - 31" +
                        Environment.NewLine +
                        $"計算天數: {isLeapYear()}天" +
                        Environment.NewLine +
                        $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                        Environment.NewLine +
                        $"用途: {this.cbbCarType.SelectedItem}" +
                        Environment.NewLine +
                        $"計算公式: {perc} * {isLeapYear()} / {isLeapYear()} = {total}元" +
                        Environment.NewLine +
                        $"應納稅額: 共 {total} 元";
                }

                if (this.cbbCarType.SelectedIndex == 2)
                {
                    decimal perc = (decimal)this.GetTaxCoach();

                    decimal total = perc * isLeapYear() / isLeapYear();

                    this.txtBoxTotalResult.Text =
                        $"使用期間: {thisYear.Year} - 01 - 01 ~ {thisYear.Year} - 12 - 31" +
                        Environment.NewLine +
                        $"計算天數: {isLeapYear()}天" +
                        Environment.NewLine +
                        $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                        Environment.NewLine +
                        $"用途: {this.cbbCarType.SelectedItem}" +
                        Environment.NewLine +
                        $"計算公式: {perc} * {isLeapYear()} / {isLeapYear()} = {total}元" +
                        Environment.NewLine +
                        $"應納稅額: 共 {total} 元";
                }

                if (this.cbbCarType.SelectedIndex == 3)
                {
                    decimal perc = (decimal)this.GetTaxPrivatePassengerCar();

                    decimal total = perc * isLeapYear() / isLeapYear();

                    this.txtBoxTotalResult.Text =
                        $"使用期間: {thisYear.Year} - 01 - 01 ~ {thisYear.Year} - 12 - 31" +
                        Environment.NewLine +
                        $"計算天數: {isLeapYear()}天" +
                        Environment.NewLine +
                        $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                        Environment.NewLine +
                        $"用途: {this.cbbCarType.SelectedItem}" +
                        Environment.NewLine +
                        $"計算公式: {perc} * {isLeapYear()} / {isLeapYear()} = {total}元" +
                        Environment.NewLine +
                        $"應納稅額: 共 {total} 元";
                }

                if (this.cbbCarType.SelectedIndex == 4)
                {
                    decimal perc = (decimal)this.GetTaxCommercialPassengerCar();

                    decimal total = perc * isLeapYear() / isLeapYear();

                    this.txtBoxTotalResult.Text =
                        $"使用期間: {thisYear.Year} - 01 - 01 ~ {thisYear.Year} - 12 - 31" +
                        Environment.NewLine +
                        $"計算天數: {isLeapYear()}天" +
                        Environment.NewLine +
                        $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                        Environment.NewLine +
                        $"用途: {this.cbbCarType.SelectedItem}" +
                        Environment.NewLine +
                        $"計算公式: {perc} * {isLeapYear()} / {isLeapYear()} = {total}元" +
                        Environment.NewLine +
                        $"應納稅額: 共 {total} 元";
                }
            }
            //選擇依期間
            if (rbPerior2.Checked)
            {
                String dtpPS = this.dtpPeriorStart.Value.ToString("yyyy/MM/dd");
                String dtpPE = this.dtpPeriorEnd.Value.ToString("yyyy/MM/dd");
                DateTime dateStart = Convert.ToDateTime(dtpPS);
                DateTime dateEnd = Convert.ToDateTime(dtpPE);

                //判斷結束日期是否小於起始日期
                if (dateEnd >= dateStart)
                {
                    //選擇車型，建立 List 內容
                    if (this.cbbCarType.SelectedIndex == 0)
                    {
                        int total = 0;
                        this.txtBoxTotalResult.Clear();
                        for (var i = dateStart.Year; i <= dateEnd.Year; i++)
                        {
                            String dtpPS2 = this.dtpPeriorStart.Value.ToString("yyyy/1/1");
                            String dtpPE2 = this.dtpPeriorEnd.Value.ToString("yyyy/12/31");
                            DateTime dateStart2 = Convert.ToDateTime(dtpPS2);
                            DateTime dateEnd2 = Convert.ToDateTime(dtpPE2);
                            int perc = (int)this.GetTaxMotorcycle();//帶入金額

                            //判斷是否為閏年
                            int timeSpan2 = (dateEnd2.DayOfYear - dateStart2.DayOfYear + 1);
                            int timeSpan3 = 0;

                            if (timeSpan2 == 365)
                            {
                                timeSpan3 = 365;
                            }
                            else if (timeSpan2 == 366)
                            {
                                timeSpan3 = 366;
                            }
                            total += perc * Convert.ToInt32(dateEnd2.DayOfYear - dateStart2.DayOfYear + 1) / timeSpan3;

                            this.txtBoxTotalResult.Text +=
                            $"使用期間: {i}/1/1 ~ {i}/12/31" +
                            Environment.NewLine +
                            $"計算天數: {timeSpan2}天" +
                            Environment.NewLine +
                            $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                            Environment.NewLine +
                            $"用途: {this.cbbCarType.SelectedItem}" +
                            Environment.NewLine +
                            $"計算公式: {perc} * {timeSpan2} / {timeSpan3} = {perc * timeSpan2 / timeSpan3}元" +
                            Environment.NewLine +
                            $"應納稅額: 共 {perc * timeSpan2 / timeSpan3} 元" +
                            Environment.NewLine +
                            $"---------------------------------------------" +
                            Environment.NewLine;
                        }
                        this.label7.Text = $"總金額為: {total}元";
                    }

                    if (this.cbbCarType.SelectedIndex == 1)
                    {
                        int total = 0;
                        this.txtBoxTotalResult.Clear();
                        for (var i = dateStart.Year; i <= dateEnd.Year; i++)
                        {
                            String dtpPS2 = this.dtpPeriorStart.Value.ToString("yyyy/1/1");
                            String dtpPE2 = this.dtpPeriorEnd.Value.ToString("yyyy/12/31");
                            DateTime dateStart2 = Convert.ToDateTime(dtpPS2);
                            DateTime dateEnd2 = Convert.ToDateTime(dtpPE2);
                            int perc = (int)this.GetTaxTruck();//帶入金額

                            //判斷是否為閏年
                            int timeSpan2 = (dateEnd2.DayOfYear - dateStart2.DayOfYear + 1);
                            int timeSpan3 = 0;

                            if (timeSpan2 == 365)
                            {
                                timeSpan3 = 365;
                            }
                            else if (timeSpan2 == 366)
                            {
                                timeSpan3 = 366;
                            }
                            total += perc * Convert.ToInt32(dateEnd2.DayOfYear - dateStart2.DayOfYear + 1) / timeSpan3;

                            this.txtBoxTotalResult.Text +=
                            $"使用期間: {i}/1/1 ~ {i}/12/31" +
                            Environment.NewLine +
                            $"計算天數: {timeSpan2}天" +
                            Environment.NewLine +
                            $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                            Environment.NewLine +
                            $"用途: {this.cbbCarType.SelectedItem}" +
                            Environment.NewLine +
                            $"計算公式: {perc} * {timeSpan2} / {timeSpan3} = {perc * timeSpan2 / timeSpan3}元" +
                            Environment.NewLine +
                            $"應納稅額: 共 {perc * timeSpan2 / timeSpan3} 元" +
                            Environment.NewLine +
                            $"---------------------------------------------" +
                            Environment.NewLine;
                        }
                        this.label7.Text = $"總金額為: {total}元";
                    }

                    if (this.cbbCarType.SelectedIndex == 2)
                    {
                        int total = 0;
                        this.txtBoxTotalResult.Clear();
                        for (var i = dateStart.Year; i <= dateEnd.Year; i++)
                        {
                            String dtpPS2 = this.dtpPeriorStart.Value.ToString("yyyy/1/1");
                            String dtpPE2 = this.dtpPeriorEnd.Value.ToString("yyyy/12/31");
                            DateTime dateStart2 = Convert.ToDateTime(dtpPS2);
                            DateTime dateEnd2 = Convert.ToDateTime(dtpPE2);
                            int perc = (int)this.GetTaxCoach();//帶入金額

                            //判斷是否為閏年
                            int timeSpan2 = (dateEnd2.DayOfYear - dateStart2.DayOfYear + 1);
                            int timeSpan3 = 0;

                            if (timeSpan2 == 365)
                            {
                                timeSpan3 = 365;
                            }
                            else if (timeSpan2 == 366)
                            {
                                timeSpan3 = 366;
                            }
                            total += perc * Convert.ToInt32(dateEnd2.DayOfYear - dateStart2.DayOfYear + 1) / timeSpan3;

                            this.txtBoxTotalResult.Text +=
                            $"使用期間: {i}/1/1 ~ {i}/12/31" +
                            Environment.NewLine +
                            $"計算天數: {timeSpan2}天" +
                            Environment.NewLine +
                            $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                            Environment.NewLine +
                            $"用途: {this.cbbCarType.SelectedItem}" +
                            Environment.NewLine +
                            $"計算公式: {perc} * {timeSpan2} / {timeSpan3} = {perc * timeSpan2 / timeSpan3}元" +
                            Environment.NewLine +
                            $"應納稅額: 共 {perc * timeSpan2 / timeSpan3} 元" +
                            Environment.NewLine +
                            $"---------------------------------------------" +
                            Environment.NewLine;
                        }
                        this.label7.Text = $"總金額為: {total}元";
                    }

                    if (this.cbbCarType.SelectedIndex == 3)
                    {
                        int total = 0;
                        this.txtBoxTotalResult.Clear();
                        for (var i = dateStart.Year; i <= dateEnd.Year; i++)
                        {
                            String dtpPS2 = this.dtpPeriorStart.Value.ToString("yyyy/1/1");
                            String dtpPE2 = this.dtpPeriorEnd.Value.ToString("yyyy/12/31");
                            DateTime dateStart2 = Convert.ToDateTime(dtpPS2);
                            DateTime dateEnd2 = Convert.ToDateTime(dtpPE2);
                            int perc = (int)this.GetTaxPrivatePassengerCar();//帶入金額

                            //判斷是否為閏年
                            int timeSpan2 = (dateEnd2.DayOfYear - dateStart2.DayOfYear + 1);
                            int timeSpan3 = 0;

                            if (timeSpan2 == 365)
                            {
                                timeSpan3 = 365;
                            }
                            else if (timeSpan2 == 366)
                            {
                                timeSpan3 = 366;
                            }
                            total += perc * Convert.ToInt32(dateEnd2.DayOfYear - dateStart2.DayOfYear + 1) / timeSpan3;

                            this.txtBoxTotalResult.Text +=
                            $"使用期間: {i}/1/1 ~ {i}/12/31" +
                            Environment.NewLine +
                            $"計算天數: {timeSpan2}天" +
                            Environment.NewLine +
                            $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                            Environment.NewLine +
                            $"用途: {this.cbbCarType.SelectedItem}" +
                            Environment.NewLine +
                            $"計算公式: {perc} * {timeSpan2} / {timeSpan3} = {perc * timeSpan2 / timeSpan3}元" +
                            Environment.NewLine +
                            $"應納稅額: 共 {perc * timeSpan2 / timeSpan3} 元" +
                            Environment.NewLine +
                            $"---------------------------------------------" +
                            Environment.NewLine;
                        }
                        this.label7.Text = $"總金額為: {total}元";
                    }

                    if (this.cbbCarType.SelectedIndex == 4)
                    {
                        int total = 0;
                        this.txtBoxTotalResult.Clear();
                        for (var i = dateStart.Year; i <= dateEnd.Year; i++)
                        {
                            String dtpPS2 = this.dtpPeriorStart.Value.ToString("yyyy/1/1");
                            String dtpPE2 = this.dtpPeriorEnd.Value.ToString("yyyy/12/31");
                            DateTime dateStart2 = Convert.ToDateTime(dtpPS2);
                            DateTime dateEnd2 = Convert.ToDateTime(dtpPE2);
                            int perc = (int)this.GetTaxCommercialPassengerCar();//帶入金額

                            //判斷是否為閏年
                            int timeSpan2 = (dateEnd2.DayOfYear - dateStart2.DayOfYear + 1);
                            int timeSpan3 = 0;

                            if (timeSpan2 == 365)
                            {
                                timeSpan3 = 365;
                            }
                            else if (timeSpan2 == 366)
                            {
                                timeSpan3 = 366;
                            }
                            total += perc * Convert.ToInt32(dateEnd2.DayOfYear - dateStart2.DayOfYear + 1) / timeSpan3;

                            this.txtBoxTotalResult.Text +=
                            $"使用期間: {i}/1/1 ~ {i}/12/31" +
                            Environment.NewLine +
                            $"計算天數: {timeSpan2}天" +
                            Environment.NewLine +
                            $"汽缸CC數: {this.cbbDisplacement.SelectedItem}" +
                            Environment.NewLine +
                            $"用途: {this.cbbCarType.SelectedItem}" +
                            Environment.NewLine +
                            $"計算公式: {perc} * {timeSpan2} / {timeSpan3} = {perc * timeSpan2 / timeSpan3}元" +
                            Environment.NewLine +
                            $"應納稅額: 共 {perc * timeSpan2 / timeSpan3} 元" +
                            Environment.NewLine +
                            $"---------------------------------------------" +
                            Environment.NewLine;
                        }
                        this.label7.Text = $"總金額為: {total}元";
                    }
                }
                else
                {
                    MessageBox.Show(
                        "結束日期小於起始日期了 !!!",
                        "Error Message",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        #region (Coustom Method)
        private void Init()
        {
            this.rbPerior1.Checked = true;
            this.panel2.Visible = false;
            this.label7.Visible = false;
            this.cbbCarType.SelectedIndex = 0;
            this.cbbDisplacement.SelectedIndex = 0;
            this.txtBoxTotalResult.Text = "";
            this.label7.Text = "總金額為:";
        }

        /// <summary> 判斷今年是否為閏年，是:回傳 366 天，否:回傳 365 天 </summary>
        /// <returns></returns>
        private int isLeapYear()
        {
            bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            if (isLeapYear)
            {
                return 366;
            }
            else
            {
                return 365;
            }
        }

        /// <summary> 為不同車型裡的不同 CC 數，加入值
        private double GetTaxMotorcycle()
        {
            if (this.cbbDisplacement.SelectedIndex == -1)
            {
                return 0;
            }

            string motorcycle = this.cbbDisplacement.Text;

            switch (motorcycle)
            {
                case "150以下 / 12HP以下(12.2PS以下)":
                    return 0;

                case "151-250 / 12.1-20HP(12.3-20.3PS)":
                    return 800;

                case "251-500 / 20.1HP以上(20.4PS以上)":
                    return 1620;

                case "501-600":
                    return 2160;

                case "601-1200":
                    return 4320;

                case "1201-1800":
                    return 7120;

                case "1801或以上":
                    return 11230;

                default:
                    return 0;
            }
        }

        private double GetTaxTruck()
        {
            if (this.cbbDisplacement.SelectedIndex == -1)
            {
                return 0;
            }

            string truck = this.cbbDisplacement.Text;

            switch (truck)
            {
                case "500以下":
                    return 0;

                case "151-250 / 12.1-20HP(12.3-20.3PS)":
                    return 900;

                case "501-600":
                    return 1080;

                case "601-1200":
                    return 1800;

                case "1201-1800":
                    return 2700;

                case "1801-2400":
                    return 3600;

                case "2401-3000 / 138HP以下(140.1PS以下)":
                    return 4500;

                case "3001-3600":
                    return 5400;

                case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                    return 6300;

                case "4201-4800":
                    return 7200;

                case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                    return 8100;

                case "5401-6000":
                    return 9000;

                case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                    return 9900;

                case "6601-7200":
                    return 10800;

                case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                    return 11700;

                case "7801-8400":
                    return 12600;

                case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                    return 13500;

                case "9001-9600":
                    return 14400;

                case "9601-10200 / 361.1HP以上(366.5PS以上)":
                    return 15300;

                case "10201以上":
                    return 16200;

                default:
                    return 0;
            }
        }

        private double GetTaxCoach()
        {
            if (this.cbbDisplacement.SelectedIndex == -1)
            {
                return 0;
            }

            string coach = this.cbbDisplacement.Text;

            switch (coach)
            {
                case "600以下":
                    return 1080;

                case "601-1200":
                    return 1800;

                case "1201-1800":
                    return 2700;

                case "1801-2400":
                    return 3600;

                case "2401-3000 / 138HP以下(140.1PS以下)":
                    return 4500;

                case "3001-3600":
                    return 5400;

                case "3601-4200 / 138.1-200HP(140.2-203.0PS)":
                    return 6300;

                case "4201-4800":
                    return 7200;

                case "4801-5400 / 200.1-247HP(203.1-250.7PS)":
                    return 8100;

                case "5401-6000":
                    return 9000;

                case "6001-6600 / 247.1-286HP(250.8-290.3PS)":
                    return 9900;

                case "6601-7200":
                    return 10800;

                case "7201-7800 / 286.1-336HP(290.4-341.0PS)":
                    return 11700;

                case "7801-8400":
                    return 12600;

                case "8401-9000 / 336.1-361HP(341.1-366.4PS)":
                    return 13500;

                case "9001-9600":
                    return 14400;

                case "9601-10200 / 361.1HP以上(366.5PS以上)":
                    return 15300;

                case "10201以上":
                    return 16200;

                default:
                    return 0;
            }
        }

        private double GetTaxPrivatePassengerCar()
        {
            if (this.cbbDisplacement.SelectedIndex == -1)
            {
                return 0;
            }

            string privatePassengerCar = this.cbbDisplacement.Text;

            switch (privatePassengerCar)
            {
                case "500以下 / 38HP以下(38.6PS以下)":
                    return 1620;

                case "501~600 / 38.1-56HP(38.7-56.8PS)":
                    return 2160;

                case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                    return 4320;

                case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                    return 7120;

                case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                    return 11230;

                case "2401~3000 / 262.1-322HP(266-326.8PS)":
                    return 15210;

                case "3001-4200 / 322.1-414HP(326.9-420.2PS":
                    return 28220;

                case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                    return 46170;

                case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                    return 69690;

                case "6601-7800 / 509.1HP以上(516.7PS以上)":
                    return 117000;

                case "7801以上":
                    return 151200;

                default:
                    return 0;
            }
        }

        private double GetTaxCommercialPassengerCar()
        {
            if (this.cbbDisplacement.SelectedIndex == -1)
            {
                return 0;
            }

            string commercialPassengerCar = this.cbbDisplacement.Text;

            switch (commercialPassengerCar)
            {
                case "500以下 / 38HP以下(38.6PS以下)":
                    return 900;

                case "501~600 / 38.1-56HP(38.7-56.8PS)":
                    return 1260;

                case "601~1200 / 56.1-83HP(56.9-84.2PS)":
                    return 2160;

                case "1201~1800 / 83.1-182HP(84.3-184.7PS)":
                    return 3060;

                case "1801~2400 / 182.1-262HP(184.8-265.9PS)":
                    return 6480;

                case "2401~3000 / 262.1-322HP(266-326.8PS)":
                    return 9900;

                case "3001-4200 / 322.1-414HP(326.9-420.2PS)":
                    return 16380;

                case "4201-5400 / 414.1-469HP(420.3-476.0PS)":
                    return 24300;

                case "5401-6600 / 469.1-509HP(476.1-516.6PS)":
                    return 33660;

                case "6601-7800 / 509.1HP以上(516.7PS以上)":
                    return 44460;

                case "7801以上":
                    return 56700;

                default:
                    return 0;
            }
        }
        /// </summary>
        /// <returns></returns>
        #endregion
    }
}
