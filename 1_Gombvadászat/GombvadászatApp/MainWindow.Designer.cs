namespace GombvadászatApp
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            crazyButton = new Button();
            matchCounterLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // crazyButton
            // 
            crazyButton.Location = new Point(372, 255);
            crazyButton.Name = "crazyButton";
            crazyButton.Size = new Size(100, 25);
            crazyButton.TabIndex = 0;
            crazyButton.Text = "Kezdjük!";
            crazyButton.UseVisualStyleBackColor = true;
            crazyButton.Click += CrazyButton_Click;
            // 
            // matchCounterLabel
            // 
            matchCounterLabel.AutoSize = true;
            matchCounterLabel.Location = new Point(12, 537);
            matchCounterLabel.Name = "matchCounterLabel";
            matchCounterLabel.Size = new Size(56, 15);
            matchCounterLabel.TabIndex = 1;
            matchCounterLabel.Text = "Találatok:";
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += Timer1_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(matchCounterLabel);
            Controls.Add(crazyButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            Text = "GombvadászatApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button crazyButton;
        private Label matchCounterLabel;
        private System.Windows.Forms.Timer timer1;
    }
}