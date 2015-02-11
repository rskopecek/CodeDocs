using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[SeparationOfConcerns("")] internal interface ISeparationOfConcernsExample{}
	[SeparationOfConcerns("")] internal struct SeparationOfConcernsStructExample{}
	[SeparationOfConcerns("")] internal class SeparationOfConcernsExample : ISeparationOfConcernsExample
	{
		[SeparationOfConcerns("")] internal SeparationOfConcernsExample() { Variable1 = "1"; Property1 = "1"; }
		[SeparationOfConcerns("")] private enum Enum1 {B};
		[SeparationOfConcerns("")] private readonly string Variable1;
		[SeparationOfConcerns("")] private string Property1 { get; set; }
		[SeparationOfConcerns("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[SeparationOfConcerns("")] delegate bool Delegate1();
		[SeparationOfConcerns("")]event Delegate1 Event1;
	}
}