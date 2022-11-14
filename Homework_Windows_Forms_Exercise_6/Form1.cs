namespace Homework_Windows_Forms_Exercise_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
            inputTextBox.BackColor = Color.White;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (inputTextBox.Text == "")
            {
                resultTextBox.Text = dateTimePicker.Value.Date.ToString("dddd").ToUpper();//ru
                inputTextBox.Text = dateTimePicker.Value.ToShortDateString();
            }
            else
            {
                try
                {
                    DateTime day = new DateTime();
                    day = DateTime.Parse(inputTextBox.Text);
                    resultTextBox.Text = day.ToString("dddd").ToUpper();
                    dateTimePicker.Value = day;
                }
                catch (Exception)
                {
                    label5.Visible = true;
                    inputTextBox.BackColor = Color.LightCoral;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputTextBox.Clear();
            resultTextBox.Clear();
            inputTextBox.BackColor = Color.White;
            label5.Visible = false;
            dateTimePicker.Value = DateTime.Now;
        }
    }
}