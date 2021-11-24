using Stubble.Core.Contexts;
using Stubble.Core.Renderers.StringRenderer;
using Stubble.Core.Tokens;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Stubble.Extensions.StringFormatter
{
    public class FormattedInterpolationTokenRenderer : StringObjectRenderer<InterpolationToken>
    {
        protected override void Write(StringRender renderer, InterpolationToken obj, Context context)
        {
			var content = obj.Content.ToString();
			string format = null;

			var pos = content.IndexOf(':');
			if (pos > 0)
			{
				format = content.Substring(pos + 1);
				content = content.Substring(0, pos);
			}

			var value = context.Lookup(content);

			var functionValueDynamic = value as Func<dynamic, object>;
			var functionValue = value as Func<object>;

			if (functionValueDynamic != null || functionValue != null)
			{
				object functionResult = functionValueDynamic != null ? functionValueDynamic.Invoke(context.View) : functionValue.Invoke();
				var resultString = functionResult.ToString();
				if (resultString.Contains("{{"))
				{
					renderer.Render(context.RendererSettings.Parser.Parse(resultString), context);
					return;
				}

				value = resultString;
			}

			var formattedValue = ApplyFormat(value, format);

			if (!context.RenderSettings.SkipHtmlEncoding && obj.EscapeResult && value != null)
			{
				formattedValue = WebUtility.HtmlEncode(formattedValue);
			}

			if (obj.Indent > 0)
			{
				renderer.Write(' ', obj.Indent);
			}

			renderer.Write(formattedValue);
		}

		private string ApplyFormat(object value, string format)
		{
			if (format == null)
				return value?.ToString();

			if (format.Contains('C') && !format.Contains(','))
				return String.Format("{0:" + format + "}", value);

			if (!format.Contains(','))
				return value.ToString().PadRight(Convert.ToInt32(format));			

			var pos = format.IndexOf(',');
			string formatCurrency = null;
			if (pos > 0)
			{
				formatCurrency = format.Substring(pos + 1);
				format = format.Substring(0, pos);
			}

			
			string result = String.Format("{0:" + formatCurrency + "}", value);

			//return String.Format("{"+format + "}", value);
			return result.ToString().PadRight(Convert.ToInt32(format));
			//return String.Format("{"+format + "}", value);
			//return String.Format("{0:" + format + "}", value);
		}

		protected override async Task WriteAsync(StringRender renderer, InterpolationToken obj, Context context)
        {
			var value = context.Lookup(obj.Content.ToString());

			var functionValueDynamic = value as Func<dynamic, object>;
			var functionValue = value as Func<object>;

			if (functionValueDynamic != null || functionValue != null)
			{
				object functionResult = functionValueDynamic != null ? functionValueDynamic.Invoke(context.View) : functionValue.Invoke();
				var resultString = functionResult.ToString();
				if (resultString.Contains("{{"))
				{
					await renderer.RenderAsync(context.RendererSettings.Parser.Parse(resultString), context);
					return;
				}

				value = resultString;
			}

			if (!context.RenderSettings.SkipHtmlEncoding && obj.EscapeResult && value != null)
			{
				value = WebUtility.HtmlEncode(value.ToString());
			}

			if (obj.Indent > 0)
			{
				renderer.Write(' ', obj.Indent);
			}

			renderer.Write(value?.ToString());
		}
    }
}
