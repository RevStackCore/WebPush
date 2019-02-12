using Newtonsoft.Json;

namespace RevStackCore.WebPush
{
    public static class Extensions
	{
		public static OsType ToOsType(this string src)
		{
			if (src.Contains("Android"))
			{
				return OsType.Android;
			}
			else if (src.Contains("Macintosh"))
			{
				return OsType.MacOS;
			}
			else if (src.Contains("iPad") || src.Contains("iPhone"))
			{
				return OsType.iOS;
			}
			else if (src.Contains("Windows"))
			{
				return OsType.Windows;
			}
			else if (src.Contains("Linux"))
			{
				return OsType.Linux;
			}
			else
			{
				return OsType.Other;
			}
		}
		public static BrowserType ToBrowserType(this string src)
		{
			if (src.Contains("Edge"))
			{
				return BrowserType.Edge;
			}
			else if (src.Contains("OPR"))
			{
				return BrowserType.Opera;
			}
			else if (src.Contains("Chrome"))
			{
				return BrowserType.Chrome;
			}
			else if (src.Contains("Safari"))
			{
				return BrowserType.Safari;
			}
			else if (src.Contains("Firefox"))
			{
				return BrowserType.Firefox;
			}
			else
			{
				return BrowserType.Other;
			}

		}

        public static int ToByteCount(this NotificationPayload src)
        {
            string json = JsonConvert.SerializeObject(src);
            int length= System.Text.Encoding.Unicode.GetByteCount(json);
            return length;
        }

        public static bool IsValidPayload(this NotificationPayload src)
        {
            string json = JsonConvert.SerializeObject(src);
            int length = System.Text.Encoding.Unicode.GetByteCount(json);
            return (length < 4096);
        }

    }
}
