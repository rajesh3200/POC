using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Helpers
{
    public static class HeaderlHelper
    {
        public static MvcHtmlString Header(this HtmlHelper helper, string content)
        {
            var tagBuilder = new TagBuilder("header");
            tagBuilder.InnerHtml = content;
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}