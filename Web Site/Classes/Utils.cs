using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Site.Models;

namespace Web_Site.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLenght = 25)
        {
            if (text == null || text.Length <= maxLenght)
            {
                return text;
            }

            var shorttext = text.Substring(0, maxLenght) + "...";
            return shorttext;
        }
    }

}