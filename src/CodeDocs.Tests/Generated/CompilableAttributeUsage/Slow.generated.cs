using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Slow("")] internal interface ISlowExample{}
	[Slow("")] internal struct SlowStructExample{}
	[Slow("")] internal class SlowExample : ISlowExample
	{
		[Slow("")] internal SlowExample() { Variable1 = "1"; Property1 = "1"; }
		[Slow("")] private enum Enum1 {B};
		[Slow("")] private readonly string Variable1;
		[Slow("")] private string Property1 { get; set; }
		[Slow("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Slow("")] delegate bool Delegate1();
		[Slow("")]event Delegate1 Event1;
	}
}