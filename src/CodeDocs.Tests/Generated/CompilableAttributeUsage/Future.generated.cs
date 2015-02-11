using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Future("")] internal interface IFutureExample{}
	[Future("")] internal struct FutureStructExample{}
	[Future("")] internal class FutureExample : IFutureExample
	{
		[Future("")] internal FutureExample() { Variable1 = "1"; Property1 = "1"; }
		[Future("")] private enum Enum1 {B};
		[Future("")] private readonly string Variable1;
		[Future("")] private string Property1 { get; set; }
		[Future("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Future("")] delegate bool Delegate1();
		[Future("")]event Delegate1 Event1;
	}
}