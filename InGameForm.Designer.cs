namespace DungeonsAndDragons
{
    partial class InGameForm
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
            MainPanel = new FlowLayoutPanel();
            FightPanel = new FlowLayoutPanel();
            EnemyLabel = new Label();
            EnemyPsLabel = new Label();
            EnemyPicture = new PictureBox();
            FightButtonsPanel = new FlowLayoutPanel();
            LightAttackButton = new Button();
            MediumAttackButton = new Button();
            HardAttackButton = new Button();
            CharacterLabel = new Label();
            YourPsLabel = new Label();
            HistoryPanel = new FlowLayoutPanel();
            HistoryLabel = new Label();
            HistoryList = new ListBox();
            MainPanel.SuspendLayout();
            FightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).BeginInit();
            FightButtonsPanel.SuspendLayout();
            HistoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(FightPanel);
            MainPanel.Controls.Add(HistoryPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1046, 529);
            MainPanel.TabIndex = 0;
            // 
            // FightPanel
            // 
            FightPanel.Controls.Add(EnemyLabel);
            FightPanel.Controls.Add(EnemyPsLabel);
            FightPanel.Controls.Add(EnemyPicture);
            FightPanel.Controls.Add(FightButtonsPanel);
            FightPanel.Controls.Add(CharacterLabel);
            FightPanel.Controls.Add(YourPsLabel);
            FightPanel.Location = new Point(70, 50);
            FightPanel.Margin = new Padding(70, 50, 3, 3);
            FightPanel.Name = "FightPanel";
            FightPanel.Size = new Size(510, 417);
            FightPanel.TabIndex = 0;
            // 
            // EnemyLabel
            // 
            EnemyLabel.AutoSize = true;
            EnemyLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EnemyLabel.Location = new Point(140, 20);
            EnemyLabel.Margin = new Padding(140, 20, 3, 10);
            EnemyLabel.Name = "EnemyLabel";
            EnemyLabel.Size = new Size(164, 31);
            EnemyLabel.TabIndex = 1;
            EnemyLabel.Text = "EnemyLabel";
            // 
            // EnemyPsLabel
            // 
            EnemyPsLabel.AutoSize = true;
            EnemyPsLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EnemyPsLabel.Location = new Point(310, 20);
            EnemyPsLabel.Margin = new Padding(3, 20, 3, 0);
            EnemyPsLabel.Name = "EnemyPsLabel";
            EnemyPsLabel.Size = new Size(72, 31);
            EnemyPsLabel.TabIndex = 4;
            EnemyPsLabel.Text = "0 PS";
            // 
            // EnemyPicture
            // 
            EnemyPicture.BackColor = Color.Black;
            EnemyPicture.Location = new Point(110, 64);
            EnemyPicture.Margin = new Padding(110, 3, 3, 3);
            EnemyPicture.Name = "EnemyPicture";
            EnemyPicture.Size = new Size(289, 225);
            EnemyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            EnemyPicture.TabIndex = 0;
            EnemyPicture.TabStop = false;
            // 
            // FightButtonsPanel
            // 
            FightButtonsPanel.Controls.Add(LightAttackButton);
            FightButtonsPanel.Controls.Add(MediumAttackButton);
            FightButtonsPanel.Controls.Add(HardAttackButton);
            FightButtonsPanel.Location = new Point(50, 302);
            FightButtonsPanel.Margin = new Padding(50, 10, 3, 3);
            FightButtonsPanel.Name = "FightButtonsPanel";
            FightButtonsPanel.Size = new Size(417, 57);
            FightButtonsPanel.TabIndex = 2;
            // 
            // LightAttackButton
            // 
            LightAttackButton.Location = new Point(30, 3);
            LightAttackButton.Margin = new Padding(30, 3, 3, 3);
            LightAttackButton.Name = "LightAttackButton";
            LightAttackButton.Size = new Size(91, 40);
            LightAttackButton.TabIndex = 0;
            LightAttackButton.Text = "Light Attack";
            LightAttackButton.UseVisualStyleBackColor = true;
            // 
            // MediumAttackButton
            // 
            MediumAttackButton.Location = new Point(154, 3);
            MediumAttackButton.Margin = new Padding(30, 3, 3, 3);
            MediumAttackButton.Name = "MediumAttackButton";
            MediumAttackButton.Size = new Size(102, 40);
            MediumAttackButton.TabIndex = 1;
            MediumAttackButton.Text = "Normal Attack";
            MediumAttackButton.UseVisualStyleBackColor = true;
            // 
            // HardAttackButton
            // 
            HardAttackButton.Location = new Point(289, 3);
            HardAttackButton.Margin = new Padding(30, 3, 3, 3);
            HardAttackButton.Name = "HardAttackButton";
            HardAttackButton.Size = new Size(91, 40);
            HardAttackButton.TabIndex = 2;
            HardAttackButton.Text = "Heavy Attack";
            HardAttackButton.UseVisualStyleBackColor = true;
            // 
            // CharacterLabel
            // 
            CharacterLabel.AutoSize = true;
            CharacterLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            CharacterLabel.Location = new Point(140, 372);
            CharacterLabel.Margin = new Padding(140, 10, 3, 0);
            CharacterLabel.Name = "CharacterLabel";
            CharacterLabel.Size = new Size(122, 31);
            CharacterLabel.TabIndex = 3;
            CharacterLabel.Text = "TU VIDA";
            // 
            // YourPsLabel
            // 
            YourPsLabel.AutoSize = true;
            YourPsLabel.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            YourPsLabel.Location = new Point(268, 372);
            YourPsLabel.Margin = new Padding(3, 10, 3, 0);
            YourPsLabel.Name = "YourPsLabel";
            YourPsLabel.Size = new Size(72, 31);
            YourPsLabel.TabIndex = 5;
            YourPsLabel.Text = "0 PS";
            // 
            // HistoryPanel
            // 
            HistoryPanel.Controls.Add(HistoryLabel);
            HistoryPanel.Controls.Add(HistoryList);
            HistoryPanel.Location = new Point(603, 50);
            HistoryPanel.Margin = new Padding(20, 50, 3, 3);
            HistoryPanel.Name = "HistoryPanel";
            HistoryPanel.Size = new Size(353, 417);
            HistoryPanel.TabIndex = 1;
            // 
            // HistoryLabel
            // 
            HistoryLabel.AutoSize = true;
            HistoryLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            HistoryLabel.Location = new Point(3, 20);
            HistoryLabel.Margin = new Padding(3, 20, 3, 0);
            HistoryLabel.Name = "HistoryLabel";
            HistoryLabel.Size = new Size(181, 24);
            HistoryLabel.TabIndex = 1;
            HistoryLabel.Text = "Historial de combate";
            // 
            // HistoryList
            // 
            HistoryList.FormattingEnabled = true;
            HistoryList.ItemHeight = 15;
            HistoryList.Location = new Point(20, 54);
            HistoryList.Margin = new Padding(20, 10, 3, 3);
            HistoryList.Name = "HistoryList";
            HistoryList.Size = new Size(317, 304);
            HistoryList.TabIndex = 0;
            // 
            // InGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1046, 529);
            Controls.Add(MainPanel);
            Name = "InGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InGameForm";
            MainPanel.ResumeLayout(false);
            FightPanel.ResumeLayout(false);
            FightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).EndInit();
            FightButtonsPanel.ResumeLayout(false);
            HistoryPanel.ResumeLayout(false);
            HistoryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel MainPanel;
        private FlowLayoutPanel FightPanel;
        private Label EnemyLabel;
        private PictureBox EnemyPicture;
        private FlowLayoutPanel HistoryPanel;
        private FlowLayoutPanel FightButtonsPanel;
        private Button LightAttackButton;
        private Button MediumAttackButton;
        private Button HardAttackButton;
        private Label CharacterLabel;
        private Label HistoryLabel;
        private ListBox HistoryList;
        private Label EnemyPsLabel;
        private Label YourPsLabel;
    }
}