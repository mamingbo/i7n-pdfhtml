using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds {
    // TODO DEVSIX-4434 support border-image-slice
    public class BorderImageSlicePercentageTest : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "border-image-slice-percentage.html";
        }
    }
}
