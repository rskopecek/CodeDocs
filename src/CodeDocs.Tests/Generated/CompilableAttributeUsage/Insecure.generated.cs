using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Insecure("")] internal interface IInsecureExample{}
	[Insecure("")] internal struct InsecureStructExample{}
	[Insecure("")] internal class InsecureExample : IInsecureExample
	{
		[Insecure("")] internal InsecureExample() { Variable1 = "1"; Property1 = "1"; }
		[Insecure("")] private enum Enum1 {B};
		[Insecure("")] private readonly string Variable1;
		[Insecure("")] private string Property1 { get; set; }
		[Insecure("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Insecure("")] delegate bool Delegate1();
		[Insecure("")]event Delegate1 Event1;
	}
}