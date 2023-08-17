namespace ModernCSharpFeatures.NewSyntaxes.NewKeyword
{
	internal static class DemonstrateNewKeyword
	{
		public static void Run ()
		{
			Person milkMan = new ("John", "Smith");
			milkMan.SayHi ();

			Console.WriteLine ();

			QuoteDTO insuranceQuoteOne = new ()
				{
					Id = 10,
					ValidFrom = DateTime.Today,
					ValidTill = DateTime.Today.AddMonths (3),
					Premium = 650
				};

			var insuranceQuoteTwo = new QuoteDTO
				{
					Id = 12,
					ValidFrom = DateTime.Today,
					ValidTill = DateTime.Today.AddMonths (3),
					Premium = 850
				};

			Console.WriteLine (insuranceQuoteOne);
			Console.WriteLine (insuranceQuoteTwo);

			Console.WriteLine ();
		}
	}
}