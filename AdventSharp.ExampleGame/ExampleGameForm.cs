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
            _game = new ExampleGame();
            InitializeComponent();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            SubmitCommand();
        }

        void txtCommand_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                SubmitCommand();
            }
        }

        private void txtCommand_TextChanged(object sender, EventArgs e)
        {
            btnEnter.Enabled = !String.IsNullOrWhiteSpace(txtCommand.Text);
        }

        private void SubmitCommand()
        {
            txtOutput.Text = _game.EnterCommand(txtCommand.Text);
            txtCommand.Clear();
        }
    }
}
