using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds {
    // TODO DEVSIX-4436 support border-image-repeat
    public class BorderImageRepeat005Test : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "border-image-repeat-005.html";
        }
    }
}
