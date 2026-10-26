namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            // Gewicht einlesen und prüfen
            if (!double.TryParse(TxtWeight.Text, out double weight) || double.IsNaN(weight) || weight <= 0 || weight > 500)
            {
                MessageBox.Show("Bitte ein gültiges Gewicht in kg eingeben (z. B. 75, höchstens 500).",
                  "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Groesse einlesen und Prüfen
            if (!double.TryParse(TxtHeight.Text, out double height) || double.IsNaN(height) || height <= 0 || height > 3)
            {
                MessageBox.Show("Bitte eine gültige Grösse in Metern eingeben (z. B. 1.78, höchstens 3).",
                  "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // BMI berechnen
            double bmi = weight / (height * height);

            LblResult.Text = $"Ihr BMI beträgt: {bmi:F2}";

        }
    }
}
