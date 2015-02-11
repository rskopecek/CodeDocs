using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[MajorChange("")] internal interface IMajorChangeExample{}
	[MajorChange("")] internal struct MajorChangeStructExample{}
	[MajorChange("")] internal class MajorChangeExample : IMajorChangeExample
	{
		[MajorChange("")] internal MajorChangeExample() { Variable1 = "1"; Property1 = "1"; }
		[MajorChange("")] private enum Enum1 {B};
		[MajorChange("")] private readonly string Variable1;
		[MajorChange("")] private string Property1 { get; set; }
		[MajorChange("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[MajorChange("")] delegate bool Delegate1();
		[MajorChange("")]event Delegate1 Event1;
	}
}