using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZSK.Client.View
{
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void buttonAddAuto_Click(object sender, EventArgs e)
        {
            using var form = new AutoView(true);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var form = new AutoView(false);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            using var form = new DriverView(true);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var form = new DriverView(false);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void buttonAddCarrier_Click(object sender, EventArgs e)
        {
            using var form = new CarrierView(true);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using var form = new CarrierView(false);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using var form = new MainView();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
            }
        }
    }
}
