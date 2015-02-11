using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Feature("")] internal interface IFeatureExample{}
	[Feature("")] internal struct FeatureStructExample{}
	[Feature("")] internal class FeatureExample : IFeatureExample
	{
		[Feature("")] internal FeatureExample() { Variable1 = "1"; Property1 = "1"; }
		[Feature("")] private enum Enum1 {B};
		[Feature("")] private readonly string Variable1;
		[Feature("")] private string Property1 { get; set; }
		[Feature("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Feature("")] delegate bool Delegate1();
		[Feature("")]event Delegate1 Event1;
	}
}