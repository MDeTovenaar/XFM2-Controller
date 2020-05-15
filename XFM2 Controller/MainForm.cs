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
    public partial class MainForm : Form
    {

        private Patch _patch;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolstripButtonAlgorithm_Click(object sender, EventArgs e)
        {            
            foreach (Control uc in PanelContainer.Controls )
            {
                if (uc is UserControl)
                {
                    uc.Dispose();
                }                
            }
           //PanelContainer.Controls.Clear();
            var us = new UsercontrolAlgorithm(_patch)
            {
                BackColor = Color.AliceBlue
            };
            us.ValuesChanged += UpdateSynth;
            PanelContainer.Controls.Add(us);
            
        }

        private void ToolstripButtonOperator_Click(object sender, EventArgs e)
        {
            foreach (Control uc in PanelContainer.Controls)
            {
                if (uc is UserControl)
                {
                    uc.Dispose();
                }
            }
            // PanelContainer.Controls.Clear();
            var us = new UsercontrolOperator(_patch)
            {
                BackColor = Color.AntiqueWhite
            };
            us.ValuesChanged += UpdateSynth;
            PanelContainer.Controls.Add(us);
        }

        private void UpdateSynth(object sender, EventArgs e)
        {
            if (sender is UsercontrolAlgorithm usAlg)
            {
                Patch patch = usAlg.Patch;
                string message = "";
                int teller = 0;
                foreach (Patch.ParamsEnum item in Enum.GetValues(typeof(Patch.ParamsEnum)))
                {
                    message += $"Parameter: {patch.Parameter(item).Name} = {patch.Parameter(item).Value}" + System.Environment.NewLine;

                    teller++;

                    if (teller == 100)
                    {
                        break;
                    }
                }
                textBox1.Text = message;
                //MessageBox.Show(message);
            }
            else if (sender is UsercontrolOperator usOp)
            {
                Patch patch = usOp.Patch;
                string message = "";
                int teller = 0;
                foreach (Patch.ParamsEnum item in Enum.GetValues(typeof(Patch.ParamsEnum)))
                {
                    message += $"Parameter: {patch.Parameter(item).Name} = {patch.Parameter(item).Value}" + System.Environment.NewLine;

                    teller++;

                    if (teller == 100)
                    {
                        break;
                    }
                }
                textBox1.Text = message;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _patch = new Patch();
        }
    }
}
