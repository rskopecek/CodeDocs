using System;
using System.Diagnostics.CodeAnalysis;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Bug("")] internal interface IBugExample{}
	[Bug("")] internal struct BugStructExample{}
	[Bug("")] internal class BugExample : IBugExample
	{
		[Bug("")] internal BugExample() { Variable1 = "1"; Property1 = "1"; }
		[Bug("")] private enum Enum1 {B};
		[Bug("")] private readonly string Variable1;
		[Bug("")] private string Property1 { get; set; }
		[Bug("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Bug("")] delegate bool Delegate1();
		[Bug("")]event Delegate1 Event1;
	}
}