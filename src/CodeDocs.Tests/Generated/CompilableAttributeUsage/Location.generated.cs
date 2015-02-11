using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Location("")] internal interface ILocationExample{}
	[Location("")] internal struct LocationStructExample{}
	[Location("")] internal class LocationExample : ILocationExample
	{
		[Location("")] internal LocationExample() { Variable1 = "1"; Property1 = "1"; }
		[Location("")] private enum Enum1 {B};
		[Location("")] private readonly string Variable1;
		[Location("")] private string Property1 { get; set; }
		[Location("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Location("")] delegate bool Delegate1();
		[Location("")]event Delegate1 Event1;
	}
}