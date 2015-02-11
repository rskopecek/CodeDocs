using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Cite("")] internal interface ICiteExample{}
	[Cite("")] internal struct CiteStructExample{}
	[Cite("")] internal class CiteExample : ICiteExample
	{
		[Cite("")] internal CiteExample() { Variable1 = "1"; Property1 = "1"; }
		[Cite("")] private enum Enum1 {B};
		[Cite("")] private readonly string Variable1;
		[Cite("")] private string Property1 { get; set; }
		[Cite("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Cite("")] delegate bool Delegate1();
		[Cite("")]event Delegate1 Event1;
	}
}