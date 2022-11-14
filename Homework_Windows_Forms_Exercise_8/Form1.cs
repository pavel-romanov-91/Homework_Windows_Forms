namespace Homework_Windows_Forms_Exercise_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            double PayGasStation { get; set; } = 0;//сумма покупки топлива
            double PayCafe { get; set; } = 0;//сумма покупки в кафе
            double PayTotal { get; set; } = 0;//общая сумма
            double cHot, cHam, cCol, cFri = 0;//переменные для хранения кол-во товаров кафе
            double[] oil = { 32.49, 31.49, 30.49, 28.99, 12.69 };//цена топлива
            int tempTimer = 0;//итератор таймера
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFuel.SelectedIndex = 0;//выбор определенного вида горючего
            textBoxFuelPrice.Text = $"{oil[0]}";//цена на данный вид продукта

            //переключение кнопок RadioButton
            radioButtonCount.CheckedChanged += RadioButtonCheckedChanged;
            radioButtonSum.CheckedChanged += RadioButtonCheckedChanged;

            //соб. выбора топлива
            comboBoxFuel.SelectedValueChanged += ComboBoxFuel_SelectedValueChanged;

            //соб. при входе на текстовое поле и выходе из него
            textBoxRadioCount.Enter += TextBox_Enter;
            textBoxRadioCount.Leave += TextBox_Leave;
            textBoxRadioSum.Enter += TextBox_Enter;
            textBoxRadioSum.Leave += TextBox_Leave;
            HotDogCount.Enter += TextBox_Enter;
            HotDogCount.Leave += TextBox_Leave;
            FrenchFriesCount.Enter += TextBox_Enter;
            FrenchFriesCount.Leave += TextBox_Leave;
            CokoColaCount.Enter += TextBox_Enter;
            CokoColaCount.Leave += TextBox_Leave;
            HamburgerCount.Enter += TextBox_Enter;
            HamburgerCount.Leave += TextBox_Leave;

            //соб. изменения значений в полях покупки топлива и подсчет суммы
            textBoxRadioCount.TextChanged += Radio_TextChanged;
            textBoxRadioSum.TextChanged += Radio_TextChanged;

            //соб. CheckBox-сов и изменение значений полей ReadOnly
            HotDogCheckBox.CheckedChanged += HotDogCheckBox_CheckedChanged;
            CokoColaCheckBox.CheckedChanged += CokoColaCheckBox_CheckedChanged;
            FrenchFriesCheckBox.CheckedChanged += FrenchFriesCheckBox_CheckedChanged;
            HamburgerCheckBox.CheckedChanged += HamburgerCheckBox_CheckedChanged;

            //соб. изменения значений в полях покупки товаров в кафе и подсчет суммы
            HamburgerCount.TextChanged += HamburgerCount_TextChanged;
            HotDogCount.TextChanged += HotDogCount_TextChanged;
            CokoColaCount.TextChanged += CokoColaCount_TextChanged;
            FrenchFriesCount.TextChanged += FrenchFriesCount_TextChanged;

            //соб. проверка на изменения значения вывода основной суммы
            toPayCafe.TextChanged += ToPayCafe_TextChanged;

            //соб. на нажатую кнопку рассчитать
            toCount.Click += ToCount_Click;

            //соб. начало работы таймера
            Timer.Tick += Timer_Tick;

            this.FormClosing += Form1_FormClosing;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            if (radioButtonCount.Checked)
            {
                textBoxRadioCount.ReadOnly = false;
                textBoxRadioSum.ReadOnly = true;
                textBoxRadioSum.Text = "0,00";
                toPayGasStation.Text = "0,00";
                groupBoxFuel.Text = "К оплате";
                label5.Text = "грн.";
                textBoxRadioCount.Focus();
            }
            if (radioButtonSum.Checked)
            {
                textBoxRadioCount.ReadOnly = true;
                textBoxRadioSum.ReadOnly = false;
                textBoxRadioCount.Text = "0,00";
                toPayGasStation.Text = "0,00";
                groupBoxFuel.Text = "К выдаче";
                label5.Text = "л.";
                textBoxRadioSum.Focus();
            }

        }
    }
}