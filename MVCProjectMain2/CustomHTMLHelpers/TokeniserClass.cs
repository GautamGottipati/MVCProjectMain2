using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjectMain2.CustomHTMLHelpers
{
    public static class TokeniserClass
    {
        public static IHtmlString Tokenize(this HtmlHelper helper,string myid,string tags)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type","text");
            tb.Attributes.Add("class", "form-control");
            tb.Attributes.Add("id", myid);
            tb.Attributes.Add("value", tags);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        }
    }
}