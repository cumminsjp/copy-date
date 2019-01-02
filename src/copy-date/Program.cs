using System;

namespace CopyDate
{
	class Program
	{
		static void Main() // don't need string[] args
		{
			var d = DateTime.Now;

			// yyyy-MM-ddTHH\\:mm\\:ss.fffffffzzz = full iso (same as ToString("o")).
			var s = d.ToString("yyyy-MM-ddTHH\\:mm\\:sszzz");
			
			if (Environment.CommandLine.IndexOf("--utc", StringComparison.CurrentCultureIgnoreCase) > 0)
			{
				// ReSharper disable once StringLiteralTypo
				s = d.ToUniversalTime().ToString("yyyy-MM-ddTHH\\:mm\\:sszzz");
			}
			
			TextCopy.Clipboard.SetText(s);

			Console.WriteLine(s);
		}
	}
}
