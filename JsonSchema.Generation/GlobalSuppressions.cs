﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "<Pending>", Scope = "member", Target = "~M:Json.Schema.Generation.SchemaGenerationContextBase.GetComparer(System.Type)~System.Collections.Generic.IComparer{System.Reflection.MemberInfo}")]
[assembly: SuppressMessage("Trimming", "IL2075:'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The return value of the source method does not have matching annotations.", Justification = "<Pending>", Scope = "member", Target = "~M:Json.Schema.Generation.Generators.ArraySchemaGenerator.AddConstraints(Json.Schema.Generation.SchemaGenerationContextBase)")]
[assembly: SuppressMessage("Trimming", "IL2075:'this' argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The return value of the source method does not have matching annotations.", Justification = "<Pending>", Scope = "member", Target = "~M:Json.Schema.Generation.Generators.ObjectSchemaGenerator.AddConstraints(Json.Schema.Generation.SchemaGenerationContextBase)")]
[assembly: SuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "<Pending>", Scope = "member", Target = "~M:Json.Schema.Generation.Generators.ObjectSchemaGenerator.ExpandEnumConditions(Json.Schema.Generation.IConditionAttribute,System.Collections.Generic.IEnumerable{System.Reflection.MemberInfo})~System.Collections.Generic.IEnumerable{System.ValueTuple{Json.Schema.Generation.IConditionAttribute,System.Reflection.MemberInfo}}")]
