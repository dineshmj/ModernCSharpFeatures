namespace ModernCSharpFeatures.NewSyntaxes.NewKeyword
{
	internal sealed class Person
	{
		public string FirstName { get; init; }

		public string LastName { get; init; }

		public Person (string firstName, string lastName)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
		}

		public void SayHi ()
		{
			Console.WriteLine ($"Hello, I am { this.FirstName } { this.LastName }!");
		}
	}
}