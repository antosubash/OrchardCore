using Microsoft.AspNetCore.Mvc.ModelBinding;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.Html.Models;

namespace OrchardCore.Html.ViewModels
{
    public class HtmlBodyPartViewModel
    {
        public string Source { get; set; }
        public string Html { get; set; }
        public string Options { get; set; }

        [BindNever]
        public ContentItem ContentItem { get; set; } 

        [BindNever]
        public HtmlBodyPart HtmlBodyPart { get; set; }

        [BindNever]
        public ContentTypePartDefinition TypePartDefinition { get; set; }
    }
}
