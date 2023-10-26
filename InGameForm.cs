using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DungeonsAndDragons
{
    public partial class InGameForm : Form
    {
        static int index = 0;
        static GeneratedEnemies enemies;
        private static GameStats stats;
        public InGameForm()
        {
            enemies = new GeneratedEnemies();
            InitializeComponent();
            InitializeEvents();
        }
        public void InitializeEvents()
        {
            this.Load -= new System.EventHandler(InGame_Load);
            this.LightAttackButton.Click -= new System.EventHandler(LightButtonClicked);
            this.MediumAttackButton.Click -= new System.EventHandler(MediumButtonClicked);
            this.HardAttackButton.Click -= new System.EventHandler(HardButtonClicked);
            this.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(Kill_Form);

            this.Load += new System.EventHandler(InGame_Load);
            this.LightAttackButton.Click += new System.EventHandler(LightButtonClicked);
            this.MediumAttackButton.Click += new System.EventHandler(MediumButtonClicked);
            this.HardAttackButton.Click += new System.EventHandler(HardButtonClicked);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(Kill_Form);
        }

        private void Kill_Form(object? sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void HardButtonClicked(object? sender, EventArgs e)
        {
            int damage = 5 + int.Parse(StatsManager.GetStat("fuerza"));
            if (SuccesOnAttack(int.Parse(StatsManager.GetStat("suerte")) + 50))
            {
                SetGameStats(damage, false);
                EnemyPsLabel.Text = $"{(int.Parse(EnemyPsLabel.Text.Split(" ")[0]) - damage).ToString()} PS";
                int EnemyPs = Convert.ToInt32(EnemyPsLabel.Text.Split(" ")[0]);
                if (EnemyPs > 0)
                {
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Atacó a {enemies.Enemies[index].Name} con HeavyAttack --> {damage}!");
                    EnemyAttack();
                }
                else
                {
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Atacó a {enemies.Enemies[index].Name} con HeavyAttack --> {damage}!");
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Ha derrotado a {enemies.Enemies[index].Name}");
                    index++;
                    LoadEnemy();
                }
            }
            else
            {
                HistoryList.Items.Add($"El ataque de {StatsManager.GetStat("name")} Fallo");
                EnemyAttack();
            }
        }
        private void MediumButtonClicked(object? sender, EventArgs e)
        {
            int damage = 3 + (int.Parse(StatsManager.GetStat("fuerza")) / 2);
            if (SuccesOnAttack(int.Parse(StatsManager.GetStat("suerte")) + 70))
            {
                SetGameStats(damage, false);
                EnemyPsLabel.Text = $"{(int.Parse(EnemyPsLabel.Text.Split(" ")[0]) - damage).ToString()} PS";
                int EnemyPs = Convert.ToInt32(EnemyPsLabel.Text.Split(" ")[0]);
                if (EnemyPs > 0)
                {
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Atacó a {enemies.Enemies[index].Name} con MediumAttack --> {damage}!");
                    EnemyAttack();
                }
                else
                {
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Atacó a {enemies.Enemies[index].Name} con MediumAttack --> {damage}!");
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Ha derrotado a {enemies.Enemies[index].Name}");
                    index++;
                    LoadEnemy();
                }
            }
            else
            {
                HistoryList.Items.Add($"El ataque de {StatsManager.GetStat("name")} Fallo");
                EnemyAttack();
            }
        }
        private void LightButtonClicked(object? sender, EventArgs e)
        {
            int damage = 1 + (int.Parse(StatsManager.GetStat("fuerza")) / 3);
            if (SuccesOnAttack(int.Parse(StatsManager.GetStat("suerte")) + 90))
            {
                SetGameStats(damage, false);
                EnemyPsLabel.Text = $"{(int.Parse(EnemyPsLabel.Text.Split(" ")[0]) - damage).ToString()} PS";
                int EnemyPs = Convert.ToInt32(EnemyPsLabel.Text.Split(" ")[0]);
                if (EnemyPs > 0)
                {
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Atacó a {enemies.Enemies[index].Name} con LightAttack --> {damage}!");
                    EnemyAttack();
                }
                else
                {
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Atacó a {enemies.Enemies[index].Name} con LightAttack --> {damage}!");
                    HistoryList.Items.Add($"{StatsManager.GetStat("name")} Ha derrotado a {enemies.Enemies[index].Name}");
                    index++;
                    LoadEnemy();
                }
            }
            else
            {
                HistoryList.Items.Add($"El ataque de {StatsManager.GetStat("name")} Fallo");
                EnemyAttack();
            }
        }
        private void InGame_Load(object? sender, EventArgs e)
        {
            MessageBox.Show("Lucha por tu vida!", "FIGHT!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.MaximizeBox = false;
            LoadFont(new FontManager());
            stats = new GameStats(DateTime.Now);
            LoadEnemy();
            CharacterLabel.Text = StatsManager.GetStat("name");
            YourPsLabel.Text = $"{int.Parse(StatsManager.GetStat("vida")) + 20} PS";
        }
        private bool SuccesOnAttack(int stadistic)
        {
            Random r = new Random();
            int next = r.Next(1, 101);
            return next <= stadistic;
        }
        private void EnemyAttack()
        {
            int damage = enemies.Enemies[index].Strength;
            if (SuccesOnAttack(90))
            {
                SetGameStats(damage, true);
                YourPsLabel.Text = $"{(int.Parse(YourPsLabel.Text.Split(" ")[0]) - damage).ToString()} PS";
                int CharPs = Convert.ToInt32(YourPsLabel.Text.Split(" ")[0]);
                if (CharPs <= 0)
                {
                    stats.Win = false;
                    this.Close();
                    new EndWindow(stats).Show();
                }
                HistoryList.Items.Add($"{enemies.Enemies[index].Name} devolvió el ataque a {StatsManager.GetStat("name")} con un daño de {damage}");
            }
            else
            {
                HistoryList.Items.Add($"El ataque de {enemies.Enemies[index].Name} Fallo");
            }
        }
        private void LoadEnemy()
        {
            HistoryList.Items.Clear();
            if (index < enemies.Enemies.Count)
            {
                EnemyPicture.ImageLocation = enemies.Enemies[index].Image;
                EnemyLabel.Text = enemies.Enemies[index].Name;
                EnemyPsLabel.Text = $"{enemies.Enemies[index].Life.ToString()} PS";
                HistoryList.Items.Add($"{enemies.Enemies[index].Name} TE HA DESAFIADO!");
            }
            else
            {
                stats.Win = true;
                this.Close();
                new EndWindow(stats).Show();
            }
        }
        private void SetGameStats(int damage, bool enemy)
        {
            if (enemy)
            {
                if (damage > stats.MaxGot)
                {
                    stats.MaxGot = damage;
                }
                else if (damage < stats.MinGot)
                {
                    stats.MinGot = damage;
                }
            }
            else
            {
                if (damage > stats.MaxDealt)
                {
                    stats.MaxDealt = damage;
                }
                else if (damage < stats.MinDealt)
                {
                    stats.MinDealt = damage;
                }
            }
        }
        private void LoadFont(FontManager f)
        {
            EnemyLabel.Font = f.TitleFont();
            EnemyPsLabel.Font = f.TitleFont();
            CharacterLabel.Font = f.TitleFont();
            YourPsLabel.Font = f.TitleFont();
            HistoryLabel.Font = f.TitleFont();
            LightAttackButton.Font = f.SmallFont();
            MediumAttackButton.Font = f.SmallFont();
            HardAttackButton.Font = f.SmallFont();
        }
    }
}
