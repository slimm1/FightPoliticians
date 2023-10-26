using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDragons
{
    public partial class CreateCharacter : Form
    {
        public CreateCharacter()
        {
            InitializeComponent();
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(this.Form_Load);
            this.LessButtonFuerza.Click -= new System.EventHandler(this.ClickLessButton);
            this.LessButtonVida.Click -= new System.EventHandler(this.ClickLessButton);
            this.LessButtonSuerte.Click -= new System.EventHandler(this.ClickLessButton);
            this.PlusButtonFuerza.Click -= new System.EventHandler(this.ClickPlusButton);
            this.PlusButtonVida.Click -= new System.EventHandler(this.ClickPlusButton);
            this.PlusButtonSuerte.Click -= new System.EventHandler(this.ClickPlusButton);
            this.RazaComboBox.SelectedValueChanged -= new System.EventHandler(this.RazaChanged);
            this.SubmitButton.Click -= new System.EventHandler(this.ClickSubmitButton);
            this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(Kill_Form);

            this.Load += new System.EventHandler(this.Form_Load);
            this.LessButtonFuerza.Click += new System.EventHandler(this.ClickLessButton);
            this.LessButtonVida.Click += new System.EventHandler(this.ClickLessButton);
            this.LessButtonSuerte.Click += new System.EventHandler(this.ClickLessButton);
            this.PlusButtonFuerza.Click += new System.EventHandler(this.ClickPlusButton);
            this.PlusButtonVida.Click += new System.EventHandler(this.ClickPlusButton);
            this.PlusButtonSuerte.Click += new System.EventHandler(this.ClickPlusButton);
            this.RazaComboBox.SelectedValueChanged += new System.EventHandler(this.RazaChanged);
            this.SubmitButton.Click += new System.EventHandler(this.ClickSubmitButton);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Kill_Form);
        }
        private void Kill_Form(object? sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void ClickSubmitButton(object? sender, EventArgs e)
        {
            if (NameTextBox.Text.Length == 0)
            {
                MessageBox.Show("El campo nombre está sin completar", "EMPTY NAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!PointsLabel.Text.Equals("0"))
            {
                MessageBox.Show("Realiza la distribución de puntos para continuar", "AVAILABLE POINTS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                File.WriteAllText(Constant.FILE_PATH, SaveStats(NameTextBox.Text, FuerzaTextBox.Text, VidaTextBox.Text, SuerteTextBox.Text));
                this.Close();
                new StartGame().Show();
            }
        }

        private void RazaChanged(object? sender, EventArgs e)
        {
            if (RazaComboBox.SelectedItem.Equals("Orco"))
            {
                GoodRadioButton.Enabled = false;
                EvilRadioButton.Select();
                EvilRadioButton.Enabled = true;
                NeutralRadioButton.Enabled = true;
            }
            else if (RazaComboBox.SelectedItem.Equals("Elfo"))
            {
                EvilRadioButton.Enabled = false;
                GoodRadioButton.Select();
                GoodRadioButton.Enabled = true;
                NeutralRadioButton.Enabled = true;
            }
            else if (RazaComboBox.SelectedItem.Equals("Humano"))
            {
                NeutralRadioButton.Enabled = false;
                GoodRadioButton.Select();
                GoodRadioButton.Enabled = true;
                EvilRadioButton.Enabled = true;
            }
            else
            {
                NeutralRadioButton.Enabled = true;
                GoodRadioButton.Enabled = true;
                EvilRadioButton.Enabled = true;
            }
        }
        private void Form_Load(object? sender, EventArgs e)
        {
            LoadFont(new FontManager());
            this.MaximizeBox = false;
            RandomPointDistribution();
            RazaComboBox.SelectedIndex = 0;
        }
        private void ClickLessButton(object? sender, EventArgs e)
        {
            Button b = sender as Button ?? new();
            if (b.Name.Equals("LessButtonFuerza") && !FuerzaTextBox.Text.Equals("0"))
            {
                UpdateWhenLessClicked(FuerzaTextBox);
            }
            else if (b.Name.Equals("LessButtonSuerte") && !SuerteTextBox.Text.Equals("0"))
            {
                UpdateWhenLessClicked(SuerteTextBox);
            }
            else if (b.Name.Equals("LessButtonVida") && !VidaTextBox.Text.Equals("0"))
            {
                UpdateWhenLessClicked(VidaTextBox);

            }
        }
        private void ClickPlusButton(object? sender, EventArgs e)
        {
            Button b = sender as Button ?? new();
            if (b.Name.Equals("PlusButtonFuerza") && !PointsLabel.Text.Equals("0"))
            {
                UpdateWhenPlusClicked(FuerzaTextBox);
            }
            else if (b.Name.Equals("PlusButtonVida") && !PointsLabel.Text.Equals("0"))
            {
                UpdateWhenPlusClicked(VidaTextBox);
            }
            else if (b.Name.Equals("PlusButtonSuerte") && !PointsLabel.Text.Equals("0"))
            {
                UpdateWhenPlusClicked(SuerteTextBox);
            }
        }
        private void UpdateWhenLessClicked(TextBox t)
        {
            int value = int.Parse(t.Text);
            value--;
            int availablePoints = int.Parse(PointsLabel.Text);
            availablePoints++;
            PointsLabel.Text = availablePoints.ToString();
            t.Text = value.ToString();
        }
        private void UpdateWhenPlusClicked(TextBox t)
        {
            int value = int.Parse(t.Text);
            value++;
            int availablePoints = int.Parse(PointsLabel.Text);
            availablePoints--;
            PointsLabel.Text = availablePoints.ToString();
            t.Text = value.ToString();
        }
        private void RandomPointDistribution()
        {
            int buffer = 10;
            Random rnd = new Random();
            FuerzaTextBox.Text = rnd.Next(buffer).ToString();
            buffer = buffer - int.Parse(FuerzaTextBox.Text);
            VidaTextBox.Text = rnd.Next(buffer).ToString();
            buffer = buffer - int.Parse(VidaTextBox.Text);
            SuerteTextBox.Text = rnd.Next(buffer).ToString();
            buffer = int.Parse(SuerteTextBox.Text) + int.Parse(FuerzaTextBox.Text) + int.Parse(VidaTextBox.Text);
            PointsLabel.Text = $"{10 - buffer}";
        }
        private string SaveStats(string name, string fuerza, string vida, string suerte)
        {
            StringBuilder sb = new();
            sb.AppendLine($"name:{name}");
            sb.AppendLine($"fuerza:{fuerza}");
            sb.AppendLine($"vida:{vida}");
            sb.AppendLine($"suerte:{suerte}");
            return sb.ToString();
        }
        private void LoadFont(FontManager f)
        {
            DatosPersonaje.Font = f.TitleFont();
            NameLabel.Font = f.MediumFont();
            RazaLabel.Font = f.MediumFont();
            GoodRadioButton.Font = f.MediumFont();
            EvilRadioButton.Font = f.MediumFont();
            NeutralRadioButton.Font = f.MediumFont();
            TotalLabel.Font = f.TitleFont();
            PointsLabel.Font = f.TitleFont();
            FuerzaLabel.Font = f.MediumFont();
            SuerteLabel.Font = f.MediumFont();
            VidaLabel.Font = f.MediumFont();
            RazaComboBox.Font = f.SmallFont();
            SubmitButton.Font = f.SmallFont();
        }
    }
}
