using System.Security.Cryptography.X509Certificates;

namespace ModernCSharpFeatures.Features.Records
{
	internal static class DemonstrateRecords
	{
		//
		// Take-aways:
		//      1) Easy to define in just one line.
		//      2) Inheritance is supported.
		//      3) Default behavior is 'immutable' - if you want to set properties, you have to explicitly define the property to be settable.
		//      4) If properties of two records match, the equality operator (==) returns true.
		//      5) Polymorphism is supported (i.e., Parent record type variable can point to a child type record instance).
		//      6) Two different child type records are comparable (i.e., the == operator works), but results in 'false'.
		//

		public static void Run ()
		{
			var personOne = new Person ("John", "Smith");
			Console.WriteLine ($"Person 1 is { personOne }");

			Person personTwo = new ("John", "Smith");
			Console.WriteLine ($"Person 1 and Person 2 are {(personOne == personTwo ? "same" : "not same")}.");

			Person personThree = new ("Chuck", "Lee");
			Console.WriteLine ($"Person 3 is { personThree }");

			Teacher teacherOne = new (2, "Chris", "Nolan");
			Console.WriteLine ($"Teacher 1 is { teacherOne }");

			Teacher teacherTwo = teacherOne with { Grade = 4 };
			Console.WriteLine ($"Teacher 2 is { teacherTwo }");

			Console.WriteLine ($"Teacher 1 and Teacher 2 are {(teacherOne == teacherTwo ? "same" : "not same")}.");

			Student studentThree = new (3, "Julia", "Dunham");
			Teacher teacherThree = new (3, "Julia", "Dunham");

			Console.WriteLine ($"Teacher 3 and Student 3 are {(studentThree == teacherThree ? "same" : "not same")}.");
		}
	}
}