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
    public partial class UsercontrolOperator : UserControl
    {

        #region Events
        public event EventHandler ValuesChanged;
        #endregion

        #region Fields
        private Patch _patch;
        private int _activeOperator = 0;
        #endregion

        #region Constructors
        public UsercontrolOperator(Patch patch)
        {
            InitializeComponent();
            _patch = patch;
        }
        #endregion

        public Patch Patch
        {
            get { return _patch; }
        }

        private void UsercontrolOperator_Load(object sender, EventArgs e)
        {
            // Operator radiobuttons
            for (int i = 0; i < 6; i++)
            {
                var rbn = new RadioButton
                {
                    Location = new Point(0, i * 30),
                    Size = new Size(30, 30),
                    Text = (i + 1).ToString(),
                    Appearance = Appearance.Button,
                    Checked = i == 0,
                    Tag = i
                };
                rbn.Click += SwitchOperatorEventhandler;
                this.Controls.Add(rbn);
            }

            // Levels
            for (int i = 0; i < 3; i++)
            {
                // Level Trackbar
                var trb = new TrackBar
                {
                    Minimum = 0,
                    Maximum = 255,
                    LargeChange = 10,
                    SmallChange = 1,
                    Orientation = Orientation.Vertical,
                    Location = new Point(120 + i * 40, 10),
                    Tag = i
                };
                trb.ValueChanged += new EventHandler(ShowMessage);
                this.Controls.Add(trb);

                // Level Label
                var lbl = new Label
                {
                    AutoSize= true,
                    Location = new Point(120 + i * 40, 60),
                };
                switch (i)
                {
                    case 0:
                        lbl.Text = "Level";
                        break;
                    case 1:
                        lbl.Text = "Mix Left";
                        break;
                    case 2:
                        lbl.Text = "Mix Right";
                        break;
                    default:
                        break;
                }
                this.Controls.Add(lbl);
            }
        }

        private void ShowMessage(object sender, EventArgs e)
        {
            if (sender is TrackBar)
            {
                var trk = (TrackBar)sender;
                switch (trk.Tag.ToString())
                {
                    case "0":
                        switch (_activeOperator)
                        {
                            case 0:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL0).Value = trk.Value;
                                break;
                            case 1:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL1).Value = trk.Value;
                                break;
                            case 2:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL2).Value = trk.Value;
                                break;
                            case 3:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL3).Value = trk.Value;
                                break;
                            case 4:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL4).Value = trk.Value;
                                break;
                            case 5:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL5).Value = trk.Value;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "1":
                        switch (_activeOperator)
                        {
                            case 0:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL0_L).Value = trk.Value;
                                break;
                            case 1:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL1_L).Value = trk.Value;
                                break;
                            case 2:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL2_L).Value = trk.Value;
                                break;
                            case 3:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL3_L).Value = trk.Value;
                                break;
                            case 4:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL4_L).Value = trk.Value;
                                break;
                            case 5:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL5_L).Value = trk.Value;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        switch (_activeOperator)
                        {
                            case 0:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL0_R).Value = trk.Value;
                                break;
                            case 1:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL1_R).Value = trk.Value;
                                break;
                            case 2:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL2_R).Value = trk.Value;
                                break;
                            case 3:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL3_R).Value = trk.Value;
                                break;
                            case 4:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL4_R).Value = trk.Value;
                                break;
                            case 5:
                                _patch.Parameter(Patch.ParamsEnum.PRM_LEVEL5_R).Value = trk.Value;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                if (this.ValuesChanged != null)
                {
                    ValuesChanged(this, new EventArgs());
                }
            }
        }

        private void SwitchOperatorEventhandler(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                var rbn = (RadioButton)sender;
                _activeOperator = (int)rbn.Tag;
            }
        }
    }
}
