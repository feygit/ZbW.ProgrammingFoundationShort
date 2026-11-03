using System.DirectoryServices;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);
    string password;
    bool gueltig;
    do
    {
      Console.WriteLine("Bitte Passwort zum prüfen eingeben");
      password = Console.ReadLine() ?? "";

      bool zifferEnthalten = false;
      foreach (char zeichen in password)
      {
        if (char.IsDigit(zeichen))
        {
          zifferEnthalten = true;
        }
      }
    }
  }
}
