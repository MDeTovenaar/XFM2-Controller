using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XFM2_Controller
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ToolstripButtonAlgorithm_Click(object sender, EventArgs e)
        {

            PanelContainer.Controls.Clear();
            var us = new UsercontrolAlgorithm(new Patch())
            {
                BackColor = Color.AliceBlue
            };
            us.ValuesChanged += UpdateSynth;
            PanelContainer.Controls.Add(us);
            
        }

        private void UpdateSynth(object sender, EventArgs e)
        {
            if (sender is UsercontrolAlgorithm us)
            {
                Patch patch = us.Patch;
                string message = "";
                int teller = 0;
                foreach (Patch.ParamsEnum item in Enum.GetValues(typeof(Patch.ParamsEnum)))
                {
                    message += $"Parameter: {patch.Parameter(item).Name} = {patch.Parameter(item).Value}" + System.Environment.NewLine;

                    teller++;

                    if (teller == 6)
                    {
                        break;
                    }
                }
                MessageBox.Show(message);
            }
        }
    }
}
