namespace ModernCSharpFeatures.Features.Records
{
	public record Person (string FirstName, string LastName);

	public record Teacher (short Grade, string FirstName, string LastName)
		: Person (FirstName, LastName);

	public record Student (short Grade, string FirstName, string LastName)
		: Person (FirstName, LastName);
}