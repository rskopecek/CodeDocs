using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[MajorFix("")] internal interface IMajorFixExample{}
	[MajorFix("")] internal struct MajorFixStructExample{}
	[MajorFix("")] internal class MajorFixExample : IMajorFixExample
	{
		[MajorFix("")] internal MajorFixExample() { Variable1 = "1"; Property1 = "1"; }
		[MajorFix("")] private enum Enum1 {B};
		[MajorFix("")] private readonly string Variable1;
		[MajorFix("")] private string Property1 { get; set; }
		[MajorFix("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[MajorFix("")] delegate bool Delegate1();
		[MajorFix("")]event Delegate1 Event1;
	}
}