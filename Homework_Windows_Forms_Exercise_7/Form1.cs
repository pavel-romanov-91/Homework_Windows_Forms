namespace Homework_Windows_Forms_Exercise_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            label.Visible = false;
            textInput.BackColor = Color.Wheat;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dayT = new DateTime();
                dayT = DateTime.Parse(textInput.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan tempDay = dayT - dayNow;
                if (dayT > dayNow)
                {
                    if (YearRadio.Checked)
                    {
                        textOutput.Text = (tempDay.TotalDays / 365).ToString();
                    }
                    if (MonthRadio.Checked)
                    {
                        textOutput.Text = (tempDay.TotalDays / 30).ToString();
                    }
                    if (DayRadio.Checked)
                    {
                        textOutput.Text = ((int)tempDay.TotalDays).ToString();
                    }
                    if (minutesRadio.Checked)
                    {
                        textOutput.Text = ((int)tempDay.TotalMinutes).ToString();
                    }
                    if (secondsRadio.Checked)
                    {
                        textOutput.Text = ((int)tempDay.TotalSeconds).ToString();
                    }
                }
                else
                {
                    textOutput.Text = "Эта дата уже прошла!";
                }
            }
            catch (Exception)
            {
                label.Visible = true;
                textInput.BackColor = Color.LightCoral;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            textInput.Clear();
            textOutput.Clear();
            label.Visible = false;
            textInput.BackColor = Color.White;
            YearRadio.Checked = true;
        }
    }
}