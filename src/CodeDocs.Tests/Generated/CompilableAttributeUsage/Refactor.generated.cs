using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Refactor("")] internal interface IRefactorExample{}
	[Refactor("")] internal struct RefactorStructExample{}
	[Refactor("")] internal class RefactorExample : IRefactorExample
	{
		[Refactor("")] internal RefactorExample() { Variable1 = "1"; Property1 = "1"; }
		[Refactor("")] private enum Enum1 {B};
		[Refactor("")] private readonly string Variable1;
		[Refactor("")] private string Property1 { get; set; }
		[Refactor("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Refactor("")] delegate bool Delegate1();
		[Refactor("")]event Delegate1 Event1;
	}
}