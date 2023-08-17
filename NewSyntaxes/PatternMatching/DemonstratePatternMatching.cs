namespace ModernCSharpFeatures.NewSyntaxes.PatternMatching
{
	internal static class DemonstratePatternMatching
	{
		public const string NORTH = "North";
		public const string EAST = "East";
		public const string SOUTH = "South";
		public const string WEST = "West";

		public static bool IsADirection (this string direction)
			=> direction is NORTH or EAST or SOUTH or WEST;

		public static bool IsLetter (this char c)
			=> c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

		public static bool IsPrimaryColor (this string color)
			=> color is "Red" or "Blue" or "Green";

		public static bool IsPercent (this int percentValue)
			=> percentValue is >= 0 and <= 100;

		public static bool IsNotNull (this string text)
			=> text is not null;

		public static string GetOrdinal (this int number)
			=> number.ToString ()
				+ int.Parse ($"{number.ToString () [number.ToString ().Length - 1]}")
					switch
					{
						1 => (number is 11) ? "th" : "st",
						2 => (number is 12) ? "th" : "nd",
						3 => (number is 13) ? "th" : "rd",
						_ => "th"
					};

		public static void Run ()
		{
			var color = "Yellow";

			Console.WriteLine ($"The color '{ color }' is { (color.IsPrimaryColor () ? "a" : "not a") } primary color.");

			var pmRank = 12;
			Console.WriteLine ($"Mr. Inder Kumar Gujral was the { pmRank.GetOrdinal () } Prime Minister of India.");
		}
	}
}