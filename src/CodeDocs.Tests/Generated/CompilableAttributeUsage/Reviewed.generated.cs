using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[Reviewed("")] internal interface IReviewedExample{}
	[Reviewed("")] internal struct ReviewedStructExample{}
	[Reviewed("")] internal class ReviewedExample : IReviewedExample
	{
		[Reviewed("")] internal ReviewedExample() { Variable1 = "1"; Property1 = "1"; }
		[Reviewed("")] private enum Enum1 {B};
		[Reviewed("")] private readonly string Variable1;
		[Reviewed("")] private string Property1 { get; set; }
		[Reviewed("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[Reviewed("")] delegate bool Delegate1();
		[Reviewed("")]event Delegate1 Event1;
	}
}