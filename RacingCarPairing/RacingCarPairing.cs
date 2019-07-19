using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RacingCarPairing
{
    public partial class RacingCarPairing : Form
    {
        public RacingCarPairing()
        {
            InitializeComponent();
        }

        private void pairingButton_Click(object sender, EventArgs e)
        {
            List<string> teamNames = scanValidTexts(teamGroup.Controls);
            List<string> carNames = scanValidTexts(carGroup.Controls);
            Console.WriteLine("Totally {0} teams, {1} cars.", teamNames.Count, carNames.Count);

            Pairing pairing = new Pairing(teamNames, carNames);
            if (!pairing.RandomPair())
            {
                MessageBox.Show(pairing.ErrorMessage, "warning");
                return;
            }
            else
            {
                //TODO: pop up pair results
            }

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            cleanTextboxes(teamGroup.Controls);
            cleanTextboxes(carGroup.Controls);
        }

        private void cleanTextboxes(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
        }

        private List<string> scanValidTexts(Control.ControlCollection controls)
        {
            List<string> texts = new List<string>();

            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    if (!string.IsNullOrEmpty(c.Text))
                    {
                        texts.Add(c.Text);
                    }
                }
            }

            return texts;
        }

    }
}
