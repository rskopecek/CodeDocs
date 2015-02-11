using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[InterfaceSegregation("")] internal interface IInterfaceSegregationExample{}
	[InterfaceSegregation("")] internal struct InterfaceSegregationStructExample{}
	[InterfaceSegregation("")] internal class InterfaceSegregationExample : IInterfaceSegregationExample
	{
		[InterfaceSegregation("")] internal InterfaceSegregationExample() { Variable1 = "1"; Property1 = "1"; }
		[InterfaceSegregation("")] private enum Enum1 {B};
		[InterfaceSegregation("")] private readonly string Variable1;
		[InterfaceSegregation("")] private string Property1 { get; set; }
		[InterfaceSegregation("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[InterfaceSegregation("")] delegate bool Delegate1();
		[InterfaceSegregation("")]event Delegate1 Event1;
	}
}