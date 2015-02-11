using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[SingleResponsibility("")] internal interface ISingleResponsibilityExample{}
	[SingleResponsibility("")] internal struct SingleResponsibilityStructExample{}
	[SingleResponsibility("")] internal class SingleResponsibilityExample : ISingleResponsibilityExample
	{
		[SingleResponsibility("")] internal SingleResponsibilityExample() { Variable1 = "1"; Property1 = "1"; }
		[SingleResponsibility("")] private enum Enum1 {B};
		[SingleResponsibility("")] private readonly string Variable1;
		[SingleResponsibility("")] private string Property1 { get; set; }
		[SingleResponsibility("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[SingleResponsibility("")] delegate bool Delegate1();
		[SingleResponsibility("")]event Delegate1 Event1;
	}
}