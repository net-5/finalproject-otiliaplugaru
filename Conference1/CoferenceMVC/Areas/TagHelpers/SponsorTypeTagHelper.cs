﻿using System;
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
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("sponsorType", Attributes = ForAttributeName)]
    public class SponsorTypeTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        private readonly ISponsorTypesService sponsorTypesService;

        public SponsorTypeTagHelper(ISponsorTypesService sponsorTypesService)
        {
            this.sponsorTypesService = sponsorTypesService;
        }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allSponsorTypes = sponsorTypesService.GetAllSponsorTypes();
            output.TagName = "select";
            output.Attributes.SetAttribute("id", For.Name);
            output.Attributes.SetAttribute("name", For.Name);

            output.Attributes.Add("class", "form-control");

            foreach (var sponsorType in allSponsorTypes)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", sponsorType.Id.ToString());     //acesta este atributul care este returnat de output-ul din TagHelper
                myOption.InnerHtml.Append(sponsorType.Name);                     //acesta este atributul care se afiseaza in elementul "option"
                output.Content.AppendHtml(myOption);
            }
        }
    }
}

