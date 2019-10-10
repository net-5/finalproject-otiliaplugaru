using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference1.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoferenceMVC.Areas.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("tag-name")]
    public class SpeakerTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";
        private readonly ISpeakerService speakerService;

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }




        public SpeakerTagHelper(ISpeakerService speakerService)
        {
            this.speakerService = speakerService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSpeakers = speakerService.GetAllSpeakers();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);

            output.Attributes.Add("class", "form-control");

            foreach (var speaker in allSpeakers)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", speaker.Id.ToString());                //acesta este atributul care este returnat de output-ul din TagHelper
                myOption.InnerHtml.Append(speaker.FirstName + " " + speaker.LastName);  //acesta este atributul care se afiseaza in elementul "option"
                output.Content.AppendHtml(myOption);
            }
        }
    }
}