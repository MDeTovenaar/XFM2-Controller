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
        #endregion

        #region Constructors
        public UsercontrolOperator(Patch patch)
        {
            InitializeComponent();
            _patch = patch;
        }
        #endregion
    }
}
