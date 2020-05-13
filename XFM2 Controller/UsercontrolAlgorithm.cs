using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFM2_Controller
{
    public partial class UsercontrolAlgorithm : UserControl
    {
        public UsercontrolAlgorithm()
        {
            InitializeComponent();
        }

        private void ShowMessage(object sender, EventArgs e)
        {

            var chk = (CheckBox)sender;
            if (chk.Checked)
            {
                lblEvent.Text = chk.Tag.ToString() + " checked";
            }
            else
            {
                lblEvent.Text = chk.Tag.ToString() + " unchecked";
            }
        }

        private void UsercontrolAlgorithm_Load(object sender, EventArgs e)
        {
            var x = 80;

            this.Controls.Add(new Label { AutoSize = true, Text = "Operator", Location = new Point(0, 0) });
            this.Controls.Add(new Label { AutoSize = true, Text = "Carrier", Location = new Point(0, 30) });
            for (int i = 0; i < 6; i++)
            {
                this.Controls.Add(new Label { AutoSize = true, Text = $"Modulate {i+1}", Location = new Point(0, 60 + i * 30) });
            }
            this.Controls.Add(new Label { AutoSize = true, Text = "Feedback", Location = new Point(0, 240) });

            for (int i = 0; i < 6; i++)
            {

                // Operator numbers
                var lbl = new Label
                {
                    AutoSize = true,
                    Text = $"{i+1}",
                    Location = new Point(x + i * 40, 0)
                };
                this.Controls.Add(lbl);

                // Carrier checkboxes
                var chk = new CheckBox
                {
                    AutoSize = true,
                    Text = "",
                    Location = new Point(x + i * 40, 30),
                    Tag = "Carrier: " + (i + 1)
                };
                chk.Click += new EventHandler(ShowMessage);
                 this.Controls.Add(chk);
            }

            for (int t = 0; t < 7; t++)
            {
                for (int i = 0; i < 6; i++)
                {
                    // Modulator checkboxes
                    var chk = new CheckBox
                    {
                        AutoSize = true,
                        Text = "",
                        Location = new Point(x + i * 40, 30 + t * 30)
                    };
                    this.Controls.Add(chk);
                }
            }
            for (int i = 0; i < 6; i++)
            {
                // Feedback checkboxes
                var chk = new CheckBox
                {
                    AutoSize = true,
                    Text = "",
                    Location = new Point(x + i * 40, 240)
                };
                this.Controls.Add(chk);
            }

        }
    }
}
