using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Standards("")] internal interface IStandardsExample{}
	[Standards("")] internal struct StandardsStructExample{}
	[Standards("")] internal class StandardsExample : IStandardsExample
	{
		[Standards("")] internal StandardsExample() { Variable1 = "1"; Property1 = "1"; }
		[Standards("")] private enum Enum1 {B};
		[Standards("")] private readonly string Variable1;
		[Standards("")] private string Property1 { get; set; }
		[Standards("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Standards("")] delegate bool Delegate1();
		[Standards("")]event Delegate1 Event1;
	}
}