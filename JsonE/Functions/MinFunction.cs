﻿using System.Linq;
using System.Text.Json.Nodes;
using Json.JsonE.Operators;
using Json.More;

namespace Json.JsonE.Functions;

internal class MinFunction : FunctionDefinition
{
	public override string Name => "min";
	public override int[] ParameterCounts { get; } = { 1 };
	public override bool AcceptsParamsList => true;

	internal override JsonNode? Invoke(JsonNode?[] arguments, EvaluationContext context)
	{
		var nums = arguments.Select(x => (x as JsonValue)?.GetNumber()).ToArray();
		if (nums.Any(x => !x.HasValue))
			throw new InterpreterException(CommonErrors.IncorrectArgType(Name));

		return nums.Min();
	}
}