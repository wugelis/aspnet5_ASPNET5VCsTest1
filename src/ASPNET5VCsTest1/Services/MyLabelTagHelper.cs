using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using System.Text;

namespace ASPNET5VCsTest1.Services
{
    [TargetElement("myLabel")]
    public class MyLabelTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {            
            output.TagName = "";
            
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<label id={0} name={0}>{1}</label>", "myLabel", "我的LABEL");

            //output.TagName = "label";
            output.Content.SetContent(sb.ToString());
        }
    }
}