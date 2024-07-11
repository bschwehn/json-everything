using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Json.Schema;

namespace TestRun;

public static class PerfIssueTest
{
	private static string GetFile(string issue, string name)
	{
		return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", $"Issue{issue}_{name}.json");
	}

	private static string GetResource(string issue, string name)
	{
		return File.ReadAllText(GetFile(issue, name));
	}

	public static void PerfIssueReduced()
	{
		var schemaText = GetResource("Perf", "schemareduced4");
		var data = GetResource("Perf", "datareduced4");

		var schema = JsonSchema.FromText(schemaText);

		// SchemaRegistry.Global.Fetch = RegistryFetch;
		JsonDocumentOptions options = new()
		{
			AllowTrailingCommas = true,
			CommentHandling = JsonCommentHandling.Skip
		};

		var testDoc = JsonDocument.Parse(data, options);
		var validationResult = schema.Evaluate(testDoc, new EvaluationOptions()
		{
			OutputFormat = OutputFormat.Flag
		});

		if (!validationResult.IsValid)
		{
			Console.WriteLine("Schema validation failed.");
		}
	}
}
