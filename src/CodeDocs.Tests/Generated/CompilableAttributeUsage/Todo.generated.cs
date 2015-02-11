using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Todo("")] internal interface ITodoExample{}
	[Todo("")] internal struct TodoStructExample{}
	[Todo("")] internal class TodoExample : ITodoExample
	{
		[Todo("")] internal TodoExample() { Variable1 = "1"; Property1 = "1"; }
		[Todo("")] private enum Enum1 {B};
		[Todo("")] private readonly string Variable1;
		[Todo("")] private string Property1 { get; set; }
		[Todo("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Todo("")] delegate bool Delegate1();
		[Todo("")]event Delegate1 Event1;
	}
}