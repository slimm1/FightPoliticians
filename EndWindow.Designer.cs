namespace DungeonsAndDragons
{
    partial class EndWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainLabel = new Label();
            TimeLabel = new Label();
            MaxDamageLabel = new Label();
            MinDamageLabel = new Label();
            MinDamageGetLabel = new Label();
            MaxDamageGetLabel = new Label();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.ForeColor = SystemColors.ButtonHighlight;
            MainLabel.Location = new Point(214, 31);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(130, 54);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "label1";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TimeLabel.ForeColor = SystemColors.Control;
            TimeLabel.Location = new Point(118, 141);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(65, 28);
            TimeLabel.TabIndex = 1;
            TimeLabel.Text = "label1";
            // 
            // MaxDamageLabel
            // 
            MaxDamageLabel.AutoSize = true;
            MaxDamageLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MaxDamageLabel.ForeColor = SystemColors.Control;
            MaxDamageLabel.Location = new Point(118, 194);
            MaxDamageLabel.Name = "MaxDamageLabel";
            MaxDamageLabel.Size = new Size(65, 28);
            MaxDamageLabel.TabIndex = 2;
            MaxDamageLabel.Text = "label1";
            // 
            // MinDamageLabel
            // 
            MinDamageLabel.AutoSize = true;
            MinDamageLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MinDamageLabel.ForeColor = SystemColors.Control;
            MinDamageLabel.Location = new Point(118, 245);
            MinDamageLabel.Name = "MinDamageLabel";
            MinDamageLabel.Size = new Size(65, 28);
            MinDamageLabel.TabIndex = 3;
            MinDamageLabel.Text = "label1";
            // 
            // MinDamageGetLabel
            // 
            MinDamageGetLabel.AutoSize = true;
            MinDamageGetLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MinDamageGetLabel.ForeColor = SystemColors.Control;
            MinDamageGetLabel.Location = new Point(118, 344);
            MinDamageGetLabel.Name = "MinDamageGetLabel";
            MinDamageGetLabel.Size = new Size(65, 28);
            MinDamageGetLabel.TabIndex = 4;
            MinDamageGetLabel.Text = "label1";
            // 
            // MaxDamageGetLabel
            // 
            MaxDamageGetLabel.AutoSize = true;
            MaxDamageGetLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            MaxDamageGetLabel.ForeColor = SystemColors.Control;
            MaxDamageGetLabel.Location = new Point(118, 295);
            MaxDamageGetLabel.Name = "MaxDamageGetLabel";
            MaxDamageGetLabel.Size = new Size(65, 28);
            MaxDamageGetLabel.TabIndex = 5;
            MaxDamageGetLabel.Text = "label1";
            // 
            // EndWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(652, 454);
            Controls.Add(MaxDamageGetLabel);
            Controls.Add(MinDamageGetLabel);
            Controls.Add(MinDamageLabel);
            Controls.Add(MaxDamageLabel);
            Controls.Add(TimeLabel);
            Controls.Add(MainLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "EndWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EndWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private Label TimeLabel;
        private Label MaxDamageLabel;
        private Label MinDamageLabel;
        private Label MinDamageGetLabel;
        private Label MaxDamageGetLabel;
    }
}