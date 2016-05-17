using Microsoft.AspNet.Razor.TagHelpers;

namespace TagHelpersAndViewComponents.TagHelpers
{
	//[HtmlTargetElement("condition", Attributes = "asp-display")]
	//[HtmlTargetElement(Attributes = "asp-condition")]
	public class ConditionTagHelper : TagHelper
	{
		[HtmlAttributeName("asp-condition")]
		public bool Condition { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			if (!Condition)
			{
				output.SuppressOutput();
			}
		}

	}
}