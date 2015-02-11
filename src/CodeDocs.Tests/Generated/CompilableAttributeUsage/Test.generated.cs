using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Test("")] internal interface ITestExample{}
	[Test("")] internal struct TestStructExample{}
	[Test("")] internal class TestExample : ITestExample
	{
		[Test("")] internal TestExample() { Variable1 = "1"; Property1 = "1"; }
		[Test("")] private enum Enum1 {B};
		[Test("")] private readonly string Variable1;
		[Test("")] private string Property1 { get; set; }
		[Test("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Test("")] delegate bool Delegate1();
		[Test("")]event Delegate1 Event1;
	}
}