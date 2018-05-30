using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSystem.HelperClasses
{
    public class TextUtils
    {
        public static string TextExcerpt(string text, int maxLength = 100)
        {
            if (text == null ||text.Length <= maxLength)
            {
                return text;
            }

            var excerpt = text.Substring(0, maxLength - 3) + "...";
            return excerpt;
        }
    }
}