using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelpersAndViewComponents.TagHelpers
{
	public class EmailTagHelper : TagHelper
	{
		private const string EmailDomain = "contoso.com";
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "a";    // Replaces <email> with <a> tag

			var content = await output.GetChildContentAsync();
			var target = content.GetContent() + "@" + EmailDomain;

			output.Attributes["href"] = "mailto:" + target;
			output.Content.SetContent(target);
		}
	}
}