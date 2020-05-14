using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace XFM2_Controller
{
    public partial class UsercontrolAlgorithm : UserControl
    {
        #region Events
        public event EventHandler ValuesChanged;
        #endregion

        #region Fields
        // Int array for checkbox
        private byte[,] _algorithmMatrixArray = new byte[6, 7];
        private int[] _algorithArray = new int[6];
        private Patch _patch;
        #endregion

        #region Constructors
        public UsercontrolAlgorithm(Patch patch)
        {
            InitializeComponent();
            _patch = patch;
        }
        #endregion

        #region Methods

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }




        public Patch Patch 
        { get { return _patch; } 
        }
        private void ShowMessage(object sender, EventArgs e)
        {
            var chk = (CheckBox)sender;
            var tagArray = chk.Tag.ToString();
            var mod = 0;
            string[] stringarray = tagArray.Split(',');
            var op = int.Parse(stringarray[1]);
            if (stringarray.Length > 2)
            {
                mod = int.Parse(stringarray[2]) + 1;
            }

            switch (stringarray[0])
            {
                case "C":
                    _algorithmMatrixArray[op, 0] = chk.Checked ? (byte)1 : (byte)0;
                    break;
                case "M":
                    _algorithmMatrixArray[op, mod] = chk.Checked ? (byte)1 : (byte)0;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < 5; i++)
            {
                _algorithArray[i] = _algorithmMatrixArray[i, 0] +
                                    2 * _algorithmMatrixArray[i, 1] +
                                    4 * _algorithmMatrixArray[i, 2] +
                                    8 * _algorithmMatrixArray[i, 3] +
                                    16 * _algorithmMatrixArray[i, 4] +
                                    32 * _algorithmMatrixArray[i, 5] +
                                    64 * _algorithmMatrixArray[i, 6] ;
            }

            _patch.Parameter(Patch.ParamsEnum.PRM_ALGO0).Value = _algorithArray[0];
            _patch.Parameter(Patch.ParamsEnum.PRM_ALGO1).Value = _algorithArray[1];
            _patch.Parameter(Patch.ParamsEnum.PRM_ALGO2).Value = _algorithArray[2];
            _patch.Parameter(Patch.ParamsEnum.PRM_ALGO3).Value = _algorithArray[3];
            _patch.Parameter(Patch.ParamsEnum.PRM_ALGO4).Value = _algorithArray[4];
            _patch.Parameter(Patch.ParamsEnum.PRM_ALGO5).Value = _algorithArray[5];

            if (this.ValuesChanged != null)
            {
                ValuesChanged(this, new EventArgs());
            }

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
            var x = 150;

            this.Controls.Add(new Label { AutoSize = true, Text = "Operator", Font = new Font(this.Font, FontStyle.Bold), Location = new Point(0, 0) });
            this.Controls.Add(new Label { AutoSize = true, Text = "Carrier", Location = new Point(0, 30) });
            for (int i = 0; i < 6; i++)
            {
                this.Controls.Add(new Label { AutoSize = true, Text = $"Modulated by oparator {i + 1}", Location = new Point(0, 60 + i * 30) });
            }
            this.Controls.Add(new Label { AutoSize = true, Text = "Feedback", Location = new Point(0, 240) });

            for (int i = 0; i < 6; i++)
            {

                // Operator numbers
                var lbl = new Label
                {
                    AutoSize = true,
                    Text = $"{i + 1}",
                    Font = new Font(this.Font, FontStyle.Bold),
                    Location = new Point(x + i * 40, 0)
                };
                this.Controls.Add(lbl);

                // Carrier checkboxes
                var chk = new CheckBox
                {
                    AutoSize = true,
                    Text = "",
                    Location = new Point(x + i * 40, 30),
                    Tag = "C," + i
                };
                chk.Click += new EventHandler(ShowMessage);
                this.Controls.Add(chk);
            }

            for (int t = 0; t < 6; t++)
            {
                for (int i = 0; i < 6; i++)
                {
                    // Modulator checkboxes
                    var chk = new CheckBox
                    {
                        AutoSize = true,
                        Text = "",
                        Location = new Point(x + i * 40, 60 + t * 30),
                        Tag = "M," + i  + "," + t
                    };
                    chk.Click += new EventHandler(ShowMessage);
                    this.Controls.Add(chk);
                }
            }
            //for (int i = 0; i < 6; i++)
            //{
            //    // Feedback checkboxes
            //    var chk = new CheckBox
            //    {
            //        AutoSize = true,
            //        Text = "",
            //        Location = new Point(x + i * 40, 240)
            //    };
            //    this.Controls.Add(chk);
            //}
        }
        #endregion

    }
}
