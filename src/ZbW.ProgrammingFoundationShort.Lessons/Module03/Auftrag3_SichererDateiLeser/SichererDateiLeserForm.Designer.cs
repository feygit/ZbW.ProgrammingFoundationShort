namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag3_SichererDateiLeser;

partial class SichererDateiLeserForm
{
  private System.ComponentModel.IContainer components = null;

  protected override void Dispose(bool disposing)
  {
    if (disposing && (components != null))
      components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    LblPfad = new Label();
    TxtPfad = new TextBox();
    CmdLesen = new Button();
    LstZeilen = new ListBox();
    LblStatus = new Label();
    SuspendLayout();
    // 
    // LblPfad
    // 
    LblPfad.AutoSize = true;
    LblPfad.Location = new Point(12, 20);
    LblPfad.Name = "LblPfad";
    LblPfad.Size = new Size(61, 15);
    LblPfad.TabIndex = 0;
    LblPfad.Text = "Dateipfad:";
    // 
    // TxtPfad
    // 
    TxtPfad.Location = new Point(90, 17);
    TxtPfad.Name = "TxtPfad";
    TxtPfad.Size = new Size(280, 23);
    TxtPfad.TabIndex = 1;
    // 
    // CmdLesen
    // 
    CmdLesen.Location = new Point(380, 16);
    CmdLesen.Name = "CmdLesen";
    CmdLesen.Size = new Size(80, 25);
    CmdLesen.TabIndex = 2;
    CmdLesen.Text = "Lesen";
    CmdLesen.Click += CmdLesen_Click;
    // 
    // LstZeilen
    // 
    LstZeilen.Location = new Point(12, 50);
    LstZeilen.Name = "LstZeilen";
    LstZeilen.Size = new Size(450, 199);
    LstZeilen.TabIndex = 3;
    // 
    // LblStatus
    // 
    LblStatus.AutoSize = true;
    LblStatus.Location = new Point(12, 262);
    LblStatus.Name = "LblStatus";
    LblStatus.Size = new Size(0, 15);
    LblStatus.TabIndex = 4;
    // 
    // SichererDateiLeserForm
    // 
    AutoScaleDimensions = new SizeF(7F, 15F);
    AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(480, 295);
    Controls.Add(LblPfad);
    Controls.Add(TxtPfad);
    Controls.Add(CmdLesen);
    Controls.Add(LstZeilen);
    Controls.Add(LblStatus);
    Name = "SichererDateiLeserForm";
    Text = "Sicherer Datei-Leser – Auftrag 3";
    ResumeLayout(false);
    PerformLayout();
  }

  private Label LblPfad;
  private TextBox TxtPfad;
  private Button CmdLesen;
  private ListBox LstZeilen;
  private Label LblStatus;
}
