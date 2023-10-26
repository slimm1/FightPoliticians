namespace DungeonsAndDragons
{
    partial class CreateCharacter
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
            TopPanel = new FlowLayoutPanel();
            DatosPersonaje = new Label();
            CharacteristicsPanel = new FlowLayoutPanel();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            RazaLabel = new Label();
            RazaComboBox = new ComboBox();
            AlineacionPanel = new FlowLayoutPanel();
            EvilRadioButton = new RadioButton();
            NeutralRadioButton = new RadioButton();
            GoodRadioButton = new RadioButton();
            BottomPanel = new FlowLayoutPanel();
            TotalLabel = new Label();
            PointsLabel = new Label();
            StatsPanel = new FlowLayoutPanel();
            FuerzaLabel = new Label();
            LessButtonFuerza = new Button();
            FuerzaTextBox = new TextBox();
            PlusButtonFuerza = new Button();
            VidaLabel = new Label();
            LessButtonVida = new Button();
            VidaTextBox = new TextBox();
            PlusButtonVida = new Button();
            SuerteLabel = new Label();
            LessButtonSuerte = new Button();
            SuerteTextBox = new TextBox();
            PlusButtonSuerte = new Button();
            SubmitButton = new Button();
            TopPanel.SuspendLayout();
            CharacteristicsPanel.SuspendLayout();
            AlineacionPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            StatsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(DatosPersonaje);
            TopPanel.Controls.Add(CharacteristicsPanel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(489, 272);
            TopPanel.TabIndex = 0;
            // 
            // DatosPersonaje
            // 
            DatosPersonaje.AutoSize = true;
            DatosPersonaje.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            DatosPersonaje.Location = new Point(10, 10);
            DatosPersonaje.Margin = new Padding(10, 10, 3, 0);
            DatosPersonaje.Name = "DatosPersonaje";
            DatosPersonaje.Size = new Size(324, 39);
            DatosPersonaje.TabIndex = 0;
            DatosPersonaje.Text = "Datos del Personaje";
            // 
            // CharacteristicsPanel
            // 
            CharacteristicsPanel.Controls.Add(NameLabel);
            CharacteristicsPanel.Controls.Add(NameTextBox);
            CharacteristicsPanel.Controls.Add(RazaLabel);
            CharacteristicsPanel.Controls.Add(RazaComboBox);
            CharacteristicsPanel.Controls.Add(AlineacionPanel);
            CharacteristicsPanel.Location = new Point(35, 64);
            CharacteristicsPanel.Margin = new Padding(35, 15, 3, 3);
            CharacteristicsPanel.Name = "CharacteristicsPanel";
            CharacteristicsPanel.Size = new Size(420, 180);
            CharacteristicsPanel.TabIndex = 1;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(10, 15);
            NameLabel.Margin = new Padding(10, 15, 3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(65, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Nombre";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(88, 15);
            NameTextBox.Margin = new Padding(10, 15, 3, 3);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(288, 23);
            NameTextBox.TabIndex = 6;
            // 
            // RazaLabel
            // 
            RazaLabel.AutoSize = true;
            RazaLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RazaLabel.Location = new Point(10, 56);
            RazaLabel.Margin = new Padding(10, 15, 3, 0);
            RazaLabel.Name = "RazaLabel";
            RazaLabel.Size = new Size(47, 20);
            RazaLabel.TabIndex = 1;
            RazaLabel.Text = "Raza";
            // 
            // RazaComboBox
            // 
            RazaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RazaComboBox.FormattingEnabled = true;
            RazaComboBox.Items.AddRange(new object[] { "Orco", "Elfo", "Humano", "Enano" });
            RazaComboBox.Location = new Point(88, 56);
            RazaComboBox.Margin = new Padding(28, 15, 3, 3);
            RazaComboBox.Name = "RazaComboBox";
            RazaComboBox.Size = new Size(121, 23);
            RazaComboBox.TabIndex = 7;
            // 
            // AlineacionPanel
            // 
            AlineacionPanel.Controls.Add(EvilRadioButton);
            AlineacionPanel.Controls.Add(NeutralRadioButton);
            AlineacionPanel.Controls.Add(GoodRadioButton);
            AlineacionPanel.Location = new Point(3, 85);
            AlineacionPanel.Name = "AlineacionPanel";
            AlineacionPanel.Size = new Size(417, 90);
            AlineacionPanel.TabIndex = 5;
            // 
            // EvilRadioButton
            // 
            EvilRadioButton.AutoSize = true;
            EvilRadioButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EvilRadioButton.Location = new Point(50, 30);
            EvilRadioButton.Margin = new Padding(50, 30, 3, 3);
            EvilRadioButton.Name = "EvilRadioButton";
            EvilRadioButton.Size = new Size(51, 24);
            EvilRadioButton.TabIndex = 0;
            EvilRadioButton.TabStop = true;
            EvilRadioButton.Text = "Evil";
            EvilRadioButton.UseVisualStyleBackColor = true;
            // 
            // NeutralRadioButton
            // 
            NeutralRadioButton.AutoSize = true;
            NeutralRadioButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NeutralRadioButton.Location = new Point(154, 30);
            NeutralRadioButton.Margin = new Padding(50, 30, 3, 3);
            NeutralRadioButton.Name = "NeutralRadioButton";
            NeutralRadioButton.Size = new Size(78, 24);
            NeutralRadioButton.TabIndex = 1;
            NeutralRadioButton.TabStop = true;
            NeutralRadioButton.Text = "Neutral";
            NeutralRadioButton.UseVisualStyleBackColor = true;
            // 
            // GoodRadioButton
            // 
            GoodRadioButton.AutoSize = true;
            GoodRadioButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GoodRadioButton.Location = new Point(285, 30);
            GoodRadioButton.Margin = new Padding(50, 30, 3, 3);
            GoodRadioButton.Name = "GoodRadioButton";
            GoodRadioButton.Size = new Size(67, 24);
            GoodRadioButton.TabIndex = 2;
            GoodRadioButton.TabStop = true;
            GoodRadioButton.Text = "Good";
            GoodRadioButton.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(TotalLabel);
            BottomPanel.Controls.Add(PointsLabel);
            BottomPanel.Controls.Add(StatsPanel);
            BottomPanel.Controls.Add(SubmitButton);
            BottomPanel.Dock = DockStyle.Fill;
            BottomPanel.Location = new Point(0, 272);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(489, 276);
            BottomPanel.TabIndex = 1;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(10, 10);
            TotalLabel.Margin = new Padding(10, 10, 3, 0);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(208, 39);
            TotalLabel.TabIndex = 1;
            TotalLabel.Text = "Total Puntos";
            // 
            // PointsLabel
            // 
            PointsLabel.AutoSize = true;
            PointsLabel.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            PointsLabel.Location = new Point(231, 10);
            PointsLabel.Margin = new Padding(10, 10, 3, 0);
            PointsLabel.Name = "PointsLabel";
            PointsLabel.Size = new Size(36, 39);
            PointsLabel.TabIndex = 4;
            PointsLabel.Text = "0";
            // 
            // StatsPanel
            // 
            StatsPanel.Controls.Add(FuerzaLabel);
            StatsPanel.Controls.Add(LessButtonFuerza);
            StatsPanel.Controls.Add(FuerzaTextBox);
            StatsPanel.Controls.Add(PlusButtonFuerza);
            StatsPanel.Controls.Add(VidaLabel);
            StatsPanel.Controls.Add(LessButtonVida);
            StatsPanel.Controls.Add(VidaTextBox);
            StatsPanel.Controls.Add(PlusButtonVida);
            StatsPanel.Controls.Add(SuerteLabel);
            StatsPanel.Controls.Add(LessButtonSuerte);
            StatsPanel.Controls.Add(SuerteTextBox);
            StatsPanel.Controls.Add(PlusButtonSuerte);
            StatsPanel.Location = new Point(75, 69);
            StatsPanel.Margin = new Padding(75, 20, 3, 3);
            StatsPanel.Name = "StatsPanel";
            StatsPanel.Size = new Size(335, 139);
            StatsPanel.TabIndex = 2;
            // 
            // FuerzaLabel
            // 
            FuerzaLabel.AutoSize = true;
            FuerzaLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FuerzaLabel.Location = new Point(10, 15);
            FuerzaLabel.Margin = new Padding(10, 15, 3, 0);
            FuerzaLabel.Name = "FuerzaLabel";
            FuerzaLabel.Size = new Size(59, 20);
            FuerzaLabel.TabIndex = 1;
            FuerzaLabel.Text = "Fuerza";
            // 
            // LessButtonFuerza
            // 
            LessButtonFuerza.Location = new Point(82, 15);
            LessButtonFuerza.Margin = new Padding(10, 15, 3, 3);
            LessButtonFuerza.Name = "LessButtonFuerza";
            LessButtonFuerza.Size = new Size(36, 23);
            LessButtonFuerza.TabIndex = 10;
            LessButtonFuerza.Text = "-";
            LessButtonFuerza.UseVisualStyleBackColor = true;
            // 
            // FuerzaTextBox
            // 
            FuerzaTextBox.Enabled = false;
            FuerzaTextBox.Location = new Point(131, 15);
            FuerzaTextBox.Margin = new Padding(10, 15, 3, 3);
            FuerzaTextBox.Name = "FuerzaTextBox";
            FuerzaTextBox.ReadOnly = true;
            FuerzaTextBox.Size = new Size(132, 23);
            FuerzaTextBox.TabIndex = 2;
            // 
            // PlusButtonFuerza
            // 
            PlusButtonFuerza.Location = new Point(276, 15);
            PlusButtonFuerza.Margin = new Padding(10, 15, 3, 3);
            PlusButtonFuerza.Name = "PlusButtonFuerza";
            PlusButtonFuerza.Size = new Size(35, 23);
            PlusButtonFuerza.TabIndex = 3;
            PlusButtonFuerza.Text = "+";
            PlusButtonFuerza.UseVisualStyleBackColor = true;
            // 
            // VidaLabel
            // 
            VidaLabel.AutoSize = true;
            VidaLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            VidaLabel.Location = new Point(10, 56);
            VidaLabel.Margin = new Padding(10, 15, 3, 0);
            VidaLabel.Name = "VidaLabel";
            VidaLabel.Size = new Size(41, 20);
            VidaLabel.TabIndex = 4;
            VidaLabel.Text = "Vida";
            // 
            // LessButtonVida
            // 
            LessButtonVida.Location = new Point(82, 56);
            LessButtonVida.Margin = new Padding(28, 15, 3, 3);
            LessButtonVida.Name = "LessButtonVida";
            LessButtonVida.Size = new Size(36, 23);
            LessButtonVida.TabIndex = 11;
            LessButtonVida.Text = "-";
            LessButtonVida.UseVisualStyleBackColor = true;
            // 
            // VidaTextBox
            // 
            VidaTextBox.Enabled = false;
            VidaTextBox.Location = new Point(131, 56);
            VidaTextBox.Margin = new Padding(10, 15, 3, 3);
            VidaTextBox.Name = "VidaTextBox";
            VidaTextBox.ReadOnly = true;
            VidaTextBox.Size = new Size(132, 23);
            VidaTextBox.TabIndex = 5;
            // 
            // PlusButtonVida
            // 
            PlusButtonVida.Location = new Point(276, 56);
            PlusButtonVida.Margin = new Padding(10, 15, 3, 3);
            PlusButtonVida.Name = "PlusButtonVida";
            PlusButtonVida.Size = new Size(36, 23);
            PlusButtonVida.TabIndex = 6;
            PlusButtonVida.Text = "+";
            PlusButtonVida.UseVisualStyleBackColor = true;
            // 
            // SuerteLabel
            // 
            SuerteLabel.AutoSize = true;
            SuerteLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SuerteLabel.Location = new Point(10, 97);
            SuerteLabel.Margin = new Padding(10, 15, 3, 0);
            SuerteLabel.Name = "SuerteLabel";
            SuerteLabel.Size = new Size(57, 20);
            SuerteLabel.TabIndex = 7;
            SuerteLabel.Text = "Suerte";
            // 
            // LessButtonSuerte
            // 
            LessButtonSuerte.Location = new Point(82, 97);
            LessButtonSuerte.Margin = new Padding(12, 15, 3, 3);
            LessButtonSuerte.Name = "LessButtonSuerte";
            LessButtonSuerte.Size = new Size(36, 23);
            LessButtonSuerte.TabIndex = 12;
            LessButtonSuerte.Text = "-";
            LessButtonSuerte.UseVisualStyleBackColor = true;
            // 
            // SuerteTextBox
            // 
            SuerteTextBox.Enabled = false;
            SuerteTextBox.Location = new Point(131, 97);
            SuerteTextBox.Margin = new Padding(10, 15, 3, 3);
            SuerteTextBox.Name = "SuerteTextBox";
            SuerteTextBox.ReadOnly = true;
            SuerteTextBox.Size = new Size(132, 23);
            SuerteTextBox.TabIndex = 8;
            // 
            // PlusButtonSuerte
            // 
            PlusButtonSuerte.Location = new Point(276, 97);
            PlusButtonSuerte.Margin = new Padding(10, 15, 3, 3);
            PlusButtonSuerte.Name = "PlusButtonSuerte";
            PlusButtonSuerte.Size = new Size(36, 23);
            PlusButtonSuerte.TabIndex = 9;
            PlusButtonSuerte.Text = "+";
            PlusButtonSuerte.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(200, 231);
            SubmitButton.Margin = new Padding(200, 20, 3, 3);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "VAMOS!";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // CreateCharacter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(489, 548);
            Controls.Add(BottomPanel);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateCharacter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateCharacter";
            Load += Form_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            CharacteristicsPanel.ResumeLayout(false);
            CharacteristicsPanel.PerformLayout();
            AlineacionPanel.ResumeLayout(false);
            AlineacionPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            BottomPanel.PerformLayout();
            StatsPanel.ResumeLayout(false);
            StatsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel TopPanel;
        private FlowLayoutPanel BottomPanel;
        private Label DatosPersonaje;
        private FlowLayoutPanel CharacteristicsPanel;
        private Label NameLabel;
        private Label RazaLabel;
        private Label NeutralLabel;
        private Label EvilPanel;
        private FlowLayoutPanel AlineacionPanel;
        public TextBox NameTextBox;
        private ComboBox RazaComboBox;
        private RadioButton EvilRadioButton;
        private RadioButton NeutralRadioButton;
        private RadioButton GoodRadioButton;
        private Label TotalLabel;
        private FlowLayoutPanel StatsPanel;
        private Label GoodLabel;
        private Label FuerzaLabel;
        public TextBox FuerzaTextBox;
        private Button PlusButtonFuerza;
        private Label VidaLabel;
        public TextBox VidaTextBox;
        private Button PlusButtonVida;
        private Label SuerteLabel;
        public TextBox SuerteTextBox;
        private Button PlusButtonSuerte;
        private Button LessButtonFuerza;
        private Button LessButtonVida;
        private Button LessButtonSuerte;
        private Button SubmitButton;
        private Label PointsLabel;
    }
}