using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Readability("")] internal interface IReadabilityExample{}
	[Readability("")] internal struct ReadabilityStructExample{}
	[Readability("")] internal class ReadabilityExample : IReadabilityExample
	{
		[Readability("")] internal ReadabilityExample() { Variable1 = "1"; Property1 = "1"; }
		[Readability("")] private enum Enum1 {B};
		[Readability("")] private readonly string Variable1;
		[Readability("")] private string Property1 { get; set; }
		[Readability("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Readability("")] delegate bool Delegate1();
		[Readability("")]event Delegate1 Event1;
	}
}