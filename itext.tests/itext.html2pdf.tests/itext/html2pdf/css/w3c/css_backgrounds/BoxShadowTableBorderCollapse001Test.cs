using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds {
    // TODO DEVSIX-4384 box-shadow is not supported
    public class BoxShadowTableBorderCollapse001Test : W3CCssAhemFontTest {
        protected internal override String GetHtmlFileName() {
            return "box-shadow-table-border-collapse-001.html";
        }
    }
}
