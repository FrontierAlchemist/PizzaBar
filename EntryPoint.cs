namespace PizzaBar
{
	internal class EntryPoint
	{
		internal enum ProviderType
		{
			LocalProvider,
			GoogleDriveProvider,
		}

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

			var providerType = ProviderType.LocalProvider;
			switch (providerType) {
				case ProviderType.LocalProvider:
					string pathToTarget = args[0];
					if (!Directory.Exists(pathToTarget)) {
						Console.WriteLine("Target folder doesn't exist");
						return;
					}
					new LocalProvider().Provide(pathToSource, pathToTarget);
					break;
				case ProviderType.GoogleDriveProvider:
					string targetURL = args[0];

					break;
			}
		}
	}
}
