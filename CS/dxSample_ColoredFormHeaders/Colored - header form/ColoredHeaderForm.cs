using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace dxSample_ColoredFormHeaders {
    public partial class ColoredHeaderForm : DevExpress.XtraEditors.XtraForm {
        public ColoredHeaderForm() {
            InitializeComponent();
        }
        public ColoredHeaderForm(Color formBorderColor) {
            FormBorderColor = formBorderColor;
            InitializeComponent();
        }
        private Color _FormBorderColor = Color.Yellow;
        public Color FormBorderColor {
            get {
                return _FormBorderColor;
            }
            set {
                _FormBorderColor = value;
            }
        }
        protected override DevExpress.Skins.XtraForm.FormPainter CreateFormBorderPainter() {
            return new CustomFormPainter(this, LookAndFeel);
        }
    }
}
