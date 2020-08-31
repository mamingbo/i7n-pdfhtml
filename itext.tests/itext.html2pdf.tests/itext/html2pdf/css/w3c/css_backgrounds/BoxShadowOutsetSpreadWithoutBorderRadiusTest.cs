using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds {
    // TODO DEVSIX-4384 box-shadow is not supported
    public class BoxShadowOutsetSpreadWithoutBorderRadiusTest : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "box-shadow-outset-spread-without-border-radius.html";
        }
    }
}
