using Microsoft.AspNetCore.Razor.TagHelpers;
using TagHelpers.Models;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("CompanyAddress")]
    public class CompanyAddressTagHelper : TagHelper
    {
        public Address Address { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "address";
            output.Content.SetHtmlContent(
                $@"{Address.Street}<br />
                        {Address.City}, {Address.PostalCode}<br />
                        <abbr title=""Phone"">P:</abbr>
                                {Address.Phone}");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}