namespace ModernCSharpFeatures
{
	internal static class Decorator
	{
		private const short WIDTH = 120;

		public static void StartSection (string title, char flower = '*')
		{
			var leftStarCount = (WIDTH - title.Length - 4) / 2;
			var rightStarCount = WIDTH - title.Length - leftStarCount - 4;

			Console.WriteLine (Enumerable.Repeat (flower, WIDTH).ToArray ());
			Console.Write ($"{ flower }{ flower }{ new string (Enumerable.Repeat (' ', leftStarCount).ToArray ()) }");
			Console.Write ($"{ title }");
			Console.WriteLine ($"{new string (Enumerable.Repeat (' ', rightStarCount).ToArray ())}{ flower }{ flower }");
			Console.WriteLine (Enumerable.Repeat (flower, WIDTH).ToArray ());
			Console.WriteLine ();
		}

		public static void CloseSection (char flower = '=')
		{
			Console.WriteLine ();
			Console.WriteLine (Enumerable.Repeat (flower, WIDTH).ToArray ());
			Console.WriteLine ("Press RETURN to continue ...");
			Console.ReadLine ();
		}
	}
}