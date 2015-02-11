using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[MinorFix("")] internal interface IMinorFixExample{}
	[MinorFix("")] internal struct MinorFixStructExample{}
	[MinorFix("")] internal class MinorFixExample : IMinorFixExample
	{
		[MinorFix("")] internal MinorFixExample() { Variable1 = "1"; Property1 = "1"; }
		[MinorFix("")] private enum Enum1 {B};
		[MinorFix("")] private readonly string Variable1;
		[MinorFix("")] private string Property1 { get; set; }
		[MinorFix("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[MinorFix("")] delegate bool Delegate1();
		[MinorFix("")]event Delegate1 Event1;
	}
}