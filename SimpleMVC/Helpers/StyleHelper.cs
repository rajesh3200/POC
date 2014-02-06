using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Helpers
{
    public static class StyleHelper
    {
        public static MvcHtmlString Span(this HtmlHelper helper, string style, string text)
        {
            string tag = String.Format("<span style='{0}'>{1}</span>", style, text);
            return new MvcHtmlString(tag);
        }
    }
}