namespace DungeonsAndDragons
{
    partial class StartGame
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
            StartGameButton = new Button();
            SuspendLayout();
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(150, 154);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(88, 73);
            StartGameButton.TabIndex = 0;
            StartGameButton.Text = "COMENZAR";
            StartGameButton.UseVisualStyleBackColor = true;
            // 
            // StartGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(397, 441);
            Controls.Add(StartGameButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartGame";
            ResumeLayout(false);
        }

        #endregion

        private Button StartGameButton;
    }
}