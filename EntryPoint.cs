namespace PizzaBar
{
	internal class EntryPoint
	{
		private static void Main(string[] args)
		{
			if (args.Length == 0) {
				Console.WriteLine("PizzaBar need path to target folder");
				return;
			}

			string pathToSource = "D:\\Books";
			if (!Directory.Exists(pathToSource)) {
				Console.WriteLine("Source folder doesn't exist");
				return;
			}

			string pathToTarget = args[0];
			if (!Directory.Exists(pathToTarget)) {
				Console.WriteLine("Target folder doesn't exist");
				return;
			}

			new Provider().Provide(pathToSource, pathToTarget);
		}
	}
}
