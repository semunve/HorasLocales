namespace QueHoraEs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime1.Text = DateTime.Now.ToString("HH:mm");
            second1.Text = DateTime.Now.ToString("ss");
            labelDate1.Text = DateTime.Now.ToString("dd MMM yy");
            labelDay1.Text = DateTime.Now.ToString("ddd");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var timezone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            var inTime = TimeZoneInfo.ConvertTime(DateTime.Now, timezone);

            hora2.Text = inTime.ToString("HH:mm");
            segundos2.Text = inTime.ToString("ss");
            fecha2.Text = inTime.ToString("yy MMM dd");
            dia2.Text = inTime.ToString("ddd");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var zonaLondres = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");

            var time = TimeZoneInfo.ConvertTime(DateTime.Now, zonaLondres);

            hora3.Text = time.ToString("HH:mm");
            segundos3.Text = time.ToString("ss");
            fecha3.Text = time.ToString("dd MMM yy");
            dia3.Text = time.ToString("ddd");

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var time = TimeZoneInfo.FindSystemTimeZoneById("AUS Eastern Standard Time");
            var australia = TimeZoneInfo.ConvertTime(DateTime.Now, time);

            hora4.Text = australia.ToString("HH:mm");
            segundos4.Text = australia.ToString("ss");
            fecha4.Text = australia.ToString(" dd MMM yy");
            dia4.Text = australia.ToString("ddd");
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            var time = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            var china = TimeZoneInfo.ConvertTime(DateTime.Now, time);

            hora5.Text = china.ToString("HH:mm");
            segundos5.Text = china.ToString("ss");
            fecha5.Text = china.ToString("dd MMM yy");
            dia5.Text = china.ToString("ddd");
        }

        private void timer6_Tick(object sender, EventArgs e)
        {

            var time = TimeZoneInfo.FindSystemTimeZoneById("Hawaiian Standard Time");
            var hawai=TimeZoneInfo.ConvertTime(DateTime.Now, time);

            hora6.Text = hawai.ToString("HH:mm");
            segundos6.Text = hawai.ToString("ss");
            fecha6.Text = hawai.ToString("dd MMM yy");
            dia6.Text = hawai.ToString("ddd");

        }
    }
}
