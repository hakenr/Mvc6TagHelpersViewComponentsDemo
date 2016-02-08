using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelpersAndViewComponents.TagHelpers
{
	[HtmlTargetElement("email2")]
	public class EmailMailToTagHelper : TagHelper
	{
		private const string EmailDomain = "contoso.com";

		// Can be passed via <email mail-to="..." />. 
		// Pascal case gets translated into lower-kebab-case.
		public string MailTo { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "a";    // Replaces <email> with <a> tag

			var address = MailTo + "@" + EmailDomain;

			output.Attributes["href"] = "mailto:" + address;
			output.Content.SetContent(address);

			output.TagMode = TagMode.StartTagAndEndTag; // <email /> => <a>...</a>
		}
	}
}