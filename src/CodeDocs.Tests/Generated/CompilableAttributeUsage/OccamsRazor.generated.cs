using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[OccamsRazor("")] internal interface IOccamsRazorExample{}
	[OccamsRazor("")] internal struct OccamsRazorStructExample{}
	[OccamsRazor("")] internal class OccamsRazorExample : IOccamsRazorExample
	{
		[OccamsRazor("")] internal OccamsRazorExample() { Variable1 = "1"; Property1 = "1"; }
		[OccamsRazor("")] private enum Enum1 {B};
		[OccamsRazor("")] private readonly string Variable1;
		[OccamsRazor("")] private string Property1 { get; set; }
		[OccamsRazor("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[OccamsRazor("")] delegate bool Delegate1();
		[OccamsRazor("")]event Delegate1 Event1;
	}
}