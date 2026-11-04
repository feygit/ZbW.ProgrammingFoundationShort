namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

// ============================================================
// AUFTRAG 3 – SichererDateiLeser (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Liest eine Datei mit try-catch-finally ab und zeigt Zeilen an.
//
// Anforderungen:
//   - TxtPfad: Dateipfad eingeben
//   - try: File.ReadAllLines, for-Schleife mit Zeilennummer
//   - catch FileNotFoundException: eigene Meldung
//   - catch Exception: allgemeiner Fehler
//   - vor dem Lesen CmdLesen deaktivieren, im finally wieder aktivieren
// ============================================================

public partial class SichererDateiLeserForm : Form
{
  public SichererDateiLeserForm()
  {
    InitializeComponent();
  }

  private void CmdLesen_Click(object sender, EventArgs e)
  {
    LstZeilen.Items.Clear();

    // TODO 1: try-catch-finally starten
    try
    {
      CmdLesen.Enabled = false;

      // TODO 2: im try-Block:
      //         string[] zeilen = File.ReadAllLines(TxtPfad.Text);
      //         for-Schleife: LstZeilen.Items.Add($"{i+1}: {zeilen[i]}")
      string[] zeilen = File.ReadAllLines(TxtPfad.Text);
      for (int i = 0; i < zeilen.Length; i++)
      {
        LstZeilen.Items.Add($"{i + 1}: {zeilen[i]}");
      }

      // TODO 3: catch (FileNotFoundException ex):
      //         MessageBox mit Datei-nicht-gefunden-Meldung
    }
    catch (FileNotFoundException ex)
    {
      MessageBox.Show($"Die Datei wurde nicht gefunden:\n{ex.FileName}",
        "Datei nicht gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);

      // TODO 4: catch (Exception ex):
      //         MessageBox mit allgemeiner Fehlermeldung
    }
    catch (Exception ex)                           // TODO 4
    {
      MessageBox.Show($"Beim Lesen ist ein Fehler aufgetreten:\n{ex.Message}",
          "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    // TODO 5: finally (läuft immer):
    finally
    {
      CmdLesen.Enabled = true;                 
    }
  }
}
