namespace PizzaBar
{
	public class GoogleDriveProvider
	{
		public void Provide(string pathToSource, string pathToTarget)
		{
			ProvideThroughDirectories(pathToSource, pathToTarget);
			ProvideFiles(pathToSource, pathToTarget);
		}

		private void ProvideThroughDirectories(string pathToSource, string pathToTarget)
		{
			foreach (var sourceDirectoryName in Directory.GetDirectories(pathToSource)) {
				var sourceDirectoryInfo = new DirectoryInfo(sourceDirectoryName);
				string directoryShortName = sourceDirectoryInfo.Name;
				string targetDirectoryName = Path.Combine(pathToTarget, directoryShortName);
				//if (!Directory.Exists(targetDirectoryName)) {
				//	Directory.CreateDirectory(targetDirectoryName);
				//}
				//Provide(sourceDirectoryName, targetDirectoryName);
			}
		}

		private void ProvideFiles(string pathToSource, string pathToTarget)
		{
			var currentDirectoryInfo = new DirectoryInfo(pathToSource);
			foreach (var sourceFile in currentDirectoryInfo.GetFiles()) {
				string fileName = sourceFile.Name;
				//string targetFileName = Path.Combine(pathToTarget, fileName);
				//if (!File.Exists(targetFileName))
				//{
				//	File.Copy(sourceFile.FullName, targetFileName);
				//}
			}
		}
	}
}
