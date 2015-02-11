using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Consequence("")] internal interface IConsequenceExample{}
	[Consequence("")] internal struct ConsequenceStructExample{}
	[Consequence("")] internal class ConsequenceExample : IConsequenceExample
	{
		[Consequence("")] internal ConsequenceExample() { Variable1 = "1"; Property1 = "1"; }
		[Consequence("")] private enum Enum1 {B};
		[Consequence("")] private readonly string Variable1;
		[Consequence("")] private string Property1 { get; set; }
		[Consequence("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Consequence("")] delegate bool Delegate1();
		[Consequence("")]event Delegate1 Event1;
	}
}