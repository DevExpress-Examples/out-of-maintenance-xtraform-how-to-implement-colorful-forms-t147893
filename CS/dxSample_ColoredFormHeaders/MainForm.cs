using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dxSample_ColoredFormHeaders {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        public MainForm() {
            InitializeComponent();
            InitColorefulForms();
        }
        private static void InitColorefulForms() {
            new ColoredHeaderForm(Color.Magenta).Show();
            new ColoredHeaderForm(Color.Yellow).Show();
            new ColoredHeaderForm(Color.DarkOrchid).Show();
        }
    }
}
