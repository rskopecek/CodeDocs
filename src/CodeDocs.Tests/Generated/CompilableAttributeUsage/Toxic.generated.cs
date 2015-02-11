using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Toxic("")] internal interface IToxicExample{}
	[Toxic("")] internal struct ToxicStructExample{}
	[Toxic("")] internal class ToxicExample : IToxicExample
	{
		[Toxic("")] internal ToxicExample() { Variable1 = "1"; Property1 = "1"; }
		[Toxic("")] private enum Enum1 {B};
		[Toxic("")] private readonly string Variable1;
		[Toxic("")] private string Property1 { get; set; }
		[Toxic("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Toxic("")] delegate bool Delegate1();
		[Toxic("")]event Delegate1 Event1;
	}
}