namespace Homework_Windows_Forms_Exercise_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            double PayGasStation { get; set; } = 0;//����� ������� �������
            double PayCafe { get; set; } = 0;//����� ������� � ����
            double PayTotal { get; set; } = 0;//����� �����
            double cHot, cHam, cCol, cFri = 0;//���������� ��� �������� ���-�� ������� ����
            double[] oil = { 32.49, 31.49, 30.49, 28.99, 12.69 };//���� �������
            int tempTimer = 0;//�������� �������
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFuel.SelectedIndex = 0;//����� ������������� ���� ��������
            textBoxFuelPrice.Text = $"{oil[0]}";//���� �� ������ ��� ��������

            //������������ ������ RadioButton
            radioButtonCount.CheckedChanged += RadioButtonCheckedChanged;
            radioButtonSum.CheckedChanged += RadioButtonCheckedChanged;

            //���. ������ �������
            comboBoxFuel.SelectedValueChanged += ComboBoxFuel_SelectedValueChanged;

            //���. ��� ����� �� ��������� ���� � ������ �� ����
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

            //���. ��������� �������� � ����� ������� ������� � ������� �����
            textBoxRadioCount.TextChanged += Radio_TextChanged;
            textBoxRadioSum.TextChanged += Radio_TextChanged;

            //���. CheckBox-��� � ��������� �������� ����� ReadOnly
            HotDogCheckBox.CheckedChanged += HotDogCheckBox_CheckedChanged;
            CokoColaCheckBox.CheckedChanged += CokoColaCheckBox_CheckedChanged;
            FrenchFriesCheckBox.CheckedChanged += FrenchFriesCheckBox_CheckedChanged;
            HamburgerCheckBox.CheckedChanged += HamburgerCheckBox_CheckedChanged;

            //���. ��������� �������� � ����� ������� ������� � ���� � ������� �����
            HamburgerCount.TextChanged += HamburgerCount_TextChanged;
            HotDogCount.TextChanged += HotDogCount_TextChanged;
            CokoColaCount.TextChanged += CokoColaCount_TextChanged;
            FrenchFriesCount.TextChanged += FrenchFriesCount_TextChanged;

            //���. �������� �� ��������� �������� ������ �������� �����
            toPayCafe.TextChanged += ToPayCafe_TextChanged;

            //���. �� ������� ������ ����������
            toCount.Click += ToCount_Click;

            //���. ������ ������ �������
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
                groupBoxFuel.Text = "� ������";
                label5.Text = "���.";
                textBoxRadioCount.Focus();
            }
            if (radioButtonSum.Checked)
            {
                textBoxRadioCount.ReadOnly = true;
                textBoxRadioSum.ReadOnly = false;
                textBoxRadioCount.Text = "0,00";
                toPayGasStation.Text = "0,00";
                groupBoxFuel.Text = "� ������";
                label5.Text = "�.";
                textBoxRadioSum.Focus();
            }

        }
    }
}