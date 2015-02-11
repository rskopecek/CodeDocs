using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Security("")] internal interface ISecurityExample{}
	[Security("")] internal struct SecurityStructExample{}
	[Security("")] internal class SecurityExample : ISecurityExample
	{
		[Security("")] internal SecurityExample() { Variable1 = "1"; Property1 = "1"; }
		[Security("")] private enum Enum1 {B};
		[Security("")] private readonly string Variable1;
		[Security("")] private string Property1 { get; set; }
		[Security("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Security("")] delegate bool Delegate1();
		[Security("")]event Delegate1 Event1;
	}
}