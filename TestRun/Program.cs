using System.Diagnostics;

namespace TestRun
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			Console.WriteLine("start reduced3");
			PerfIssueTest.PerfIssueReduced();
			sw.Stop();
			Console.WriteLine($"Took {sw.Elapsed.TotalSeconds}");
			Console.ReadLine();
		}
	}
}
