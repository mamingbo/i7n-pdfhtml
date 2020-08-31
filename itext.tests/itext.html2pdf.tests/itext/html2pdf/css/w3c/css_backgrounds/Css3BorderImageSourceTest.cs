using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds {
    // TODO DEVSIX-4382 border-image-source is not supported
    public class Css3BorderImageSourceTest : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "css3-border-image-source.html";
        }
    }
}
