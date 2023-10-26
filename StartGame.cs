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
    public partial class StartGame : Form
    {
        public StartGame()
        {
            InitializeComponent();
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            this.Load -= new System.EventHandler(this.Form_Load);
            this.StartGameButton.Click -= new System.EventHandler(this.StartGameButton_Click);

            this.Load += new System.EventHandler(this.Form_Load);
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
        }
        private void StartGameButton_Click(object? sender, EventArgs e)
        {
            this.Hide();
            new InGameForm().Show();
        }
        private void Form_Load(object? sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadFont(new FontManager());
        }
        private void LoadFont(FontManager f)
        {
            StartGameButton.Font = f.SmallFont();
        }
    }
}
