namespace ModernCSharpFeatures.NewSyntaxes.NewKeyword
{
	internal sealed class QuoteDTO
	{
		public int Id { get; init; }

		public DateTime ValidFrom { get; init; }

		public DateTime ValidTill { get; init; }

		public double Premium { get; init; }

		public override string ToString ()
		{
			return $"Insurance Quote ID = { this.Id }, valid from = { this.ValidFrom }, valid till = { this.ValidTill }, premium = $ { this.Premium }";
		}
	}
}