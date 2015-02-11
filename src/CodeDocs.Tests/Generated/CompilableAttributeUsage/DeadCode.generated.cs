using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[DeadCode("")] internal interface IDeadCodeExample{}
	[DeadCode("")] internal struct DeadCodeStructExample{}
	[DeadCode("")] internal class DeadCodeExample : IDeadCodeExample
	{
		[DeadCode("")] internal DeadCodeExample() { Variable1 = "1"; Property1 = "1"; }
		[DeadCode("")] private enum Enum1 {B};
		[DeadCode("")] private readonly string Variable1;
		[DeadCode("")] private string Property1 { get; set; }
		[DeadCode("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[DeadCode("")] delegate bool Delegate1();
		[DeadCode("")]event Delegate1 Event1;
	}
}