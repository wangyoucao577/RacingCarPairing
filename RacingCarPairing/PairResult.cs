using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RacingCarPairing
{
    public partial class PairResult : Form
    {
        public PairResult()
        {
            InitializeComponent();
        }

        public void SetPairs(List<TeamCarPair> pairs)
        {
            foreach (TeamCarPair p in pairs)
            {
                ListViewItem item = new ListViewItem();
                item.Text = p.Team;
                item.SubItems.Add(p.Car);
                pairResultListView.Items.Add(item);
            }
        }
    }
}
