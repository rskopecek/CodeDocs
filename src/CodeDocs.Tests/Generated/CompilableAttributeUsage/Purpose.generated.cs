using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Purpose("")] internal interface IPurposeExample{}
	[Purpose("")] internal struct PurposeStructExample{}
	[Purpose("")] internal class PurposeExample : IPurposeExample
	{
		[Purpose("")] internal PurposeExample() { Variable1 = "1"; Property1 = "1"; }
		[Purpose("")] private enum Enum1 {B};
		[Purpose("")] private readonly string Variable1;
		[Purpose("")] private string Property1 { get; set; }
		[Purpose("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Purpose("")] delegate bool Delegate1();
		[Purpose("")]event Delegate1 Event1;
	}
}