namespace Training3
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
            StartButton = new Button();
            OutputTextBox = new RichTextBox();
            ProgressBar = new ProgressBar();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(36, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(217, 29);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start her";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(36, 64);
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.Size = new Size(709, 577);
            OutputTextBox.TabIndex = 1;
            OutputTextBox.Text = "";
            OutputTextBox.ZoomFactor = 1.5F;
            // 
            // ProgressBar
            // 
            ProgressBar.Location = new Point(307, 12);
            ProgressBar.Name = "ProgressBar";
            ProgressBar.Size = new Size(438, 29);
            ProgressBar.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 653);
            Controls.Add(ProgressBar);
            Controls.Add(OutputTextBox);
            Controls.Add(StartButton);
            Name = "Form1";
            Text = "Programmering er som...";
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private RichTextBox OutputTextBox;
        private ProgressBar ProgressBar;
    }
}