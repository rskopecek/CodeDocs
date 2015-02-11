using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Hack("")] internal interface IHackExample{}
	[Hack("")] internal struct HackStructExample{}
	[Hack("")] internal class HackExample : IHackExample
	{
		[Hack("")] internal HackExample() { Variable1 = "1"; Property1 = "1"; }
		[Hack("")] private enum Enum1 {B};
		[Hack("")] private readonly string Variable1;
		[Hack("")] private string Property1 { get; set; }
		[Hack("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Hack("")] delegate bool Delegate1();
		[Hack("")]event Delegate1 Event1;
	}
}