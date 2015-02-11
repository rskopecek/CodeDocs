using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Naming("")] internal interface INamingExample{}
	[Naming("")] internal struct NamingStructExample{}
	[Naming("")] internal class NamingExample : INamingExample
	{
		[Naming("")] internal NamingExample() { Variable1 = "1"; Property1 = "1"; }
		[Naming("")] private enum Enum1 {B};
		[Naming("")] private readonly string Variable1;
		[Naming("")] private string Property1 { get; set; }
		[Naming("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Naming("")] delegate bool Delegate1();
		[Naming("")]event Delegate1 Event1;
	}
}