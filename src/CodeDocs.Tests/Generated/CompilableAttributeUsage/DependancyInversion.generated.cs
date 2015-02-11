using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[DependancyInversion("")] internal interface IDependancyInversionExample{}
	[DependancyInversion("")] internal struct DependancyInversionStructExample{}
	[DependancyInversion("")] internal class DependancyInversionExample : IDependancyInversionExample
	{
		[DependancyInversion("")] internal DependancyInversionExample() { Variable1 = "1"; Property1 = "1"; }
		[DependancyInversion("")] private enum Enum1 {B};
		[DependancyInversion("")] private readonly string Variable1;
		[DependancyInversion("")] private string Property1 { get; set; }
		[DependancyInversion("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[DependancyInversion("")] delegate bool Delegate1();
		[DependancyInversion("")]event Delegate1 Event1;
	}
}