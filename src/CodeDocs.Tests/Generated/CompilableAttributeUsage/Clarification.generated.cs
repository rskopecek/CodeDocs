using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Clarification("")] internal interface IClarificationExample{}
	[Clarification("")] internal struct ClarificationStructExample{}
	[Clarification("")] internal class ClarificationExample : IClarificationExample
	{
		[Clarification("")] internal ClarificationExample() { Variable1 = "1"; Property1 = "1"; }
		[Clarification("")] private enum Enum1 {B};
		[Clarification("")] private readonly string Variable1;
		[Clarification("")] private string Property1 { get; set; }
		[Clarification("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Clarification("")] delegate bool Delegate1();
		[Clarification("")]event Delegate1 Event1;
	}
}