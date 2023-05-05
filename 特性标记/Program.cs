//https://docs.microsoft.com/en-us/dotnet/standard/attributes/writing-custom-attributes
//
namespace MyPrograme
{

	[System.AttributeUsage(System.AttributeTargets.Class |
											 System.AttributeTargets.Struct,
											 AllowMultiple = true)]
	class Log : Attribute
	{
		public String message = "";
		public Log(String message)
		{
			this.message = message;
		}
	}

	[Log("class name")]
	class Car
	{

		public Car() { }
		public String _Color = "";

		void Go()
		{

		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Car car = new Car();
			Type type = car.GetType();

			var MyAttributes = type.GetCustomAttributes(false);

			if (MyAttributes.Length == 0)
			{
				Console.WriteLine("The attribute was not found.");
			}
			else
			{
				for (int i = 0; i < MyAttributes?.Length; i++)
				{
					if (MyAttributes == null) continue;
					// Get the Name value.
					Console.WriteLine("The Name Attribute is: {0}.", (MyAttributes[i] as Log)?.message);
				}
			}
		}
	}
}
