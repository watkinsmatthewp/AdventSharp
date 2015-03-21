using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventSharp.ExampleGame
{
    public partial class ExampleGameForm : Form
    {
        private ExampleGame _game;
        
        public ExampleGameForm()
        {
            InitializeComponent();
            _game = new ExampleGame();
            txtOutput.Text = _game.Start();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            SubmitCommand();
        }

        void txtCommand_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            btnEnter.Enabled = !String.IsNullOrWhiteSpace(txtCommand.Text);
            if (e.KeyCode == System.Windows.Forms.Keys.Enter && btnEnter.Enabled)
            {
                SubmitCommand();
            }
        }

        private void SubmitCommand()
        {
            txtOutput.Text = _game.EnterCommand(txtCommand.Text);
            txtCommand.Clear();
        }
    }
}
