namespace CurrencyCalculator
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      CmdToEur = new Button();
      CmdToChf = new Button();
      LblResult = new Label();
      TxtAmount = new TextBox();
      LblBetrag = new Label();
      SuspendLayout();
      // 
      // CmdToEur
      // 
      CmdToEur.Location = new Point(169, 59);
      CmdToEur.Name = "CmdToEur";
      CmdToEur.Size = new Size(110, 23);
      CmdToEur.TabIndex = 0;
      CmdToEur.Text = "CHF -> EUR";
      CmdToEur.UseVisualStyleBackColor = true;
      CmdToEur.Click += CmdToEur_Click;
      // 
      // CmdToChf
      // 
      CmdToChf.Location = new Point(169, 98);
      CmdToChf.Name = "CmdToChf";
      CmdToChf.Size = new Size(110, 23);
      CmdToChf.TabIndex = 1;
      CmdToChf.Text = "EUR -> CHF";
      CmdToChf.UseVisualStyleBackColor = true;
      CmdToChf.Click += CmdToChf_Click;
      // 
      // LblResult
      // 
      LblResult.AutoSize = true;
      LblResult.Location = new Point(169, 149);
      LblResult.Name = "LblResult";
      LblResult.Size = new Size(0, 15);
      LblResult.TabIndex = 2;
      // 
      // TxtAmount
      // 
      TxtAmount.Location = new Point(47, 59);
      TxtAmount.Name = "TxtAmount";
      TxtAmount.Size = new Size(100, 23);
      TxtAmount.TabIndex = 3;
      // 
      // LblBetrag
      // 
      LblBetrag.AutoSize = true;
      LblBetrag.Location = new Point(109, 149);
      LblBetrag.Name = "LblBetrag";
      LblBetrag.Size = new Size(44, 15);
      LblBetrag.TabIndex = 4;
      LblBetrag.Text = "Betrag:";
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(LblBetrag);
      Controls.Add(TxtAmount);
      Controls.Add(LblResult);
      Controls.Add(CmdToChf);
      Controls.Add(CmdToEur);
      Name = "Form1";
      Text = "Form1";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button CmdToEur;
    private Button CmdToChf;
    private Label LblResult;
    private TextBox TxtAmount;
    private Label LblBetrag;
  }
}
