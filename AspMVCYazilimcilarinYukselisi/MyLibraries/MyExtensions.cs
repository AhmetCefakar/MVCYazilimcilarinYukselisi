using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationForGitSilBunu.MyLibraries
{
    // Extension method yazmak için kullanılan class
    public static class MyExtensions
    {
        #region Extension Methods
        // Bir extension method static olur ve ilk parametre olarak this anahtarı ile hangi class'ın üyesi olacağını belirler
        // Değerlere varsayılan olarak başlangıç verileri atandı
        public static MvcHtmlString Button(this HtmlHelper helper, string id = "", ButtonType type = ButtonType.button, string text = "")
        {
            string myHtml = $"<button id='{id}' name='{id}' type='{type.ToString()}'>{text}</button>";

            return MvcHtmlString.Create(myHtml);
        }

        // 'TagBuilder' kullanarak html tag oluşturmak
        public static MvcHtmlString Button(this HtmlHelper helper, string id = "", ButtonType type = ButtonType.button, string text = "", string classes = "")
        {
            TagBuilder tag = new TagBuilder("Button");

            tag.AddCssClass(classes);
            tag.GenerateId(id);
            tag.Attributes.Add("name", id);
            tag.Attributes.Add("type", type.ToString());
            tag.SetInnerText(text);

            return MvcHtmlString.Create(tag.ToString());
        }
        #endregion

    }

    #region Enums
    public enum ButtonType
    {
        button = 0,
        submit = 1,
        reset = 2
    }
    #endregion
}