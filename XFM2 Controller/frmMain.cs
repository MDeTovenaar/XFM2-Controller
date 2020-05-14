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
            if (sender is UsercontrolAlgorithm)
            {
                UsercontrolAlgorithm us = (UsercontrolAlgorithm)sender;
                MessageBox.Show(us.Patch.Parameter(Patch.ParamsEnum.PRM_ALGO0).Value.ToString());
            }
        }
    }
}
