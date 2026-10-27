namespace WinFormsApp1
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
            TxtHeight = new TextBox();
            TxtWeight = new TextBox();
            calculate = new Button();
            LblHeight = new Label();
            LblWeight = new Label();
            LblResult = new Label();
            SuspendLayout();
            // 
            // TxtHeight
            // 
            TxtHeight.Location = new Point(96, 63);
            TxtHeight.Name = "TxtHeight";
            TxtHeight.Size = new Size(100, 23);
            TxtHeight.TabIndex = 0;
            // 
            // TxtWeight
            // 
            TxtWeight.Location = new Point(96, 92);
            TxtWeight.Name = "TxtWeight";
            TxtWeight.Size = new Size(100, 23);
            TxtWeight.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.Location = new Point(96, 133);
            calculate.Name = "calculate";
            calculate.Size = new Size(75, 23);
            calculate.TabIndex = 2;
            calculate.Text = "berechnen";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // LblHeight
            // 
            LblHeight.AutoSize = true;
            LblHeight.Location = new Point(15, 63);
            LblHeight.Name = "LblHeight";
            LblHeight.Size = new Size(69, 15);
            LblHeight.TabIndex = 3;
            LblHeight.Text = "Grösse in M";
            LblHeight.UseWaitCursor = true;
            LblHeight.Click += label1_Click;
            // 
            // LblWeight
            // 
            LblWeight.AutoSize = true;
            LblWeight.Location = new Point(15, 92);
            LblWeight.Name = "LblWeight";
            LblWeight.Size = new Size(79, 15);
            LblWeight.TabIndex = 4;
            LblWeight.Text = "Gewicht in kg";
            LblWeight.UseMnemonic = false;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(96, 171);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(31, 15);
            LblResult.TabIndex = 5;
            LblResult.Text = "BMI:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResult);
            Controls.Add(LblWeight);
            Controls.Add(LblHeight);
            Controls.Add(calculate);
            Controls.Add(TxtWeight);
            Controls.Add(TxtHeight);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "BMI:";
            UseWaitCursor = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtHeight;
        private TextBox TxtWeight;
        private Button calculate;
        private Label LblHeight;
        private Label LblWeight;
        private Label LblResult;
    }
}
