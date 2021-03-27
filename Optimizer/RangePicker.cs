using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizer {
    public partial class RangePicker : UserControl {
        public event EventHandler ValueChanged;

        public decimal Min {
            get {
                return nudMin.Value;
            }
            set {
                nudMin.Value = value;
            }
        }

        public decimal Max {
            get {
                return nudMax.Value;
            }
            set {
                nudMax.Value = value;
            }
        }

        public RangePicker() {
            InitializeComponent();
            nudMin.ValueChanged += Nud_ValueChanged;
            nudMax.ValueChanged += Nud_ValueChanged;
        }

        private void Nud_ValueChanged(object sender, EventArgs e) {
            nudMax.Minimum = nudMin.Value;
            ValueChanged?.Invoke(this, e);
        }
    }
}
