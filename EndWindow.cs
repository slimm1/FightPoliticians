using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonsAndDragons
{
    public partial class EndWindow : Form
    {
        private GameStats stats;
        public EndWindow(GameStats stats)
        {
            this.stats = stats;
            InitializeComponent();
            InitializeEvents();
        }
        public void InitializeEvents()
        {
            this.Load -= new System.EventHandler(Load_Form);

            this.Load += new System.EventHandler(Load_Form);
        }
        private void Load_Form(object? sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadFont(new FontManager());
            if (stats.Win)
            {
                MainLabel.Text = "HAS GANADO!";
                LoadGameStats();
            }
            else
            {
                MainLabel.Text = "HAS PERDIDO";
                LoadGameStats();
            }
        }
        private void LoadGameStats()
        {
            TimeLabel.Text = $"Tiempo jugado: {(DateTime.Now.Subtract(stats.StartTime)).ToString("mm':'ss")}";
            MaxDamageLabel.Text = $"Máximo daño realizado: {stats.MaxDealt}";
            MinDamageLabel.Text = $"Mínimo daño realizado: {stats.MinDealt}";
            MaxDamageGetLabel.Text = $"Máximo daño recibido: {stats.MaxGot}";
            MinDamageGetLabel.Text = $"Mínimo daño recibido: {stats.MinGot}";
        }
        private void LoadFont(FontManager f)
        {
            MainLabel.Font = f.TitleFont();
            TimeLabel.Font = f.TitleFont();
            MaxDamageGetLabel.Font = f.TitleFont();
            MaxDamageLabel.Font = f.TitleFont();
            MinDamageGetLabel.Font = f.TitleFont();
            MinDamageLabel.Font = f.TitleFont();
        }
    }
}
