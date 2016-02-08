using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelpersAndViewComponents.TagHelpers
{
	[HtmlTargetElement("p")]
	public class AutoLinkerWwwTagHelper : TagHelper
	{
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			var childContent = await output.GetChildContentAsync();
			// Find Urls in the content and replace them with their anchor tag equivalent.
			output.Content.SetHtmlContent(Regex.Replace(
				childContent.GetContent(),
				 @"\b(www\.)(\S+)\b",
				 "<a target=\"_blank\" href=\"http://$0\">$0</a>"));  // www version
		}
	}
}