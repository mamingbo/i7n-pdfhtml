using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds {
    // TODO DEVSIX-2105 support background-clip: content-box
    public class BackgroundClipContentBox001Test : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "background-clip-content-box-001.html";
        }
    }
}
