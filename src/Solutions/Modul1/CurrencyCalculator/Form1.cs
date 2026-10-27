namespace CurrencyCalculator
{
  public partial class Form1 : Form
  {
    const decimal ChfPerEur = 1.05m;
    public Form1()
    {
      InitializeComponent();
    }

    private void CmdToEur_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(TxtAmount.Text, out decimal amount) || amount < 0)
      {
        MessageBox.Show("Bitte Betrag >= 0 CHF/EUR eingeben.",
          "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      decimal result = amount / ChfPerEur;
    
      LblResult.Text = $"{result:F2} EUR";
    }

    private void CmdToChf_Click(object sender, EventArgs e)
    {
      if (!decimal.TryParse(TxtAmount.Text, out decimal amount) || amount < 0)
      {
        MessageBox.Show("Bitte Betrag >= 0 CHF/EUR eingeben.",
          "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }
      decimal result = amount * ChfPerEur;

      LblResult.Text = $"{result:F2} CHF";

    }
  }
}
