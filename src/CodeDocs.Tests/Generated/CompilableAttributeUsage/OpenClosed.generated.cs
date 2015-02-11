using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[OpenClosed("")] internal interface IOpenClosedExample{}
	[OpenClosed("")] internal struct OpenClosedStructExample{}
	[OpenClosed("")] internal class OpenClosedExample : IOpenClosedExample
	{
		[OpenClosed("")] internal OpenClosedExample() { Variable1 = "1"; Property1 = "1"; }
		[OpenClosed("")] private enum Enum1 {B};
		[OpenClosed("")] private readonly string Variable1;
		[OpenClosed("")] private string Property1 { get; set; }
		[OpenClosed("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[OpenClosed("")] delegate bool Delegate1();
		[OpenClosed("")]event Delegate1 Event1;
	}
}