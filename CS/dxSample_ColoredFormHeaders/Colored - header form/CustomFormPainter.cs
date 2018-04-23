using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Skins;
using DevExpress.Skins.XtraForm;
using DevExpress.Utils.Drawing;

namespace dxSample_ColoredFormHeaders {
    public class CustomFormPainter : FormPainter {
        public CustomFormPainter(System.Windows.Forms.Control owner, DevExpress.Skins.ISkinProvider provider)
            : base(owner, provider) {
        }
        private Color GetFormBorderColor() {
            var formBorderColor = (Owner as ColoredHeaderForm).FormBorderColor;
            return formBorderColor;
        }
        protected override void DrawBackground(GraphicsCache cache) {
            var info = GetCaptionInfo();
            var ee = info as ObjectInfoArgs;
            var formBorderColor = GetFormBorderColor();
            cache.FillRectangle(new SolidBrush(formBorderColor), ee.Bounds);
        }
        protected override void DrawFrameCore(GraphicsCache cache, SkinElementInfo info, FrameKind kind) {
            var formBorderColor = GetFormBorderColor();
            cache.FillRectangle(formBorderColor, info.Bounds);
        }
    }
}
