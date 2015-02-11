using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[LiskovSubstitution("")] internal interface ILiskovSubstitutionExample{}
	[LiskovSubstitution("")] internal struct LiskovSubstitutionStructExample{}
	[LiskovSubstitution("")] internal class LiskovSubstitutionExample : ILiskovSubstitutionExample
	{
		[LiskovSubstitution("")] internal LiskovSubstitutionExample() { Variable1 = "1"; Property1 = "1"; }
		[LiskovSubstitution("")] private enum Enum1 {B};
		[LiskovSubstitution("")] private readonly string Variable1;
		[LiskovSubstitution("")] private string Property1 { get; set; }
		[LiskovSubstitution("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[LiskovSubstitution("")] delegate bool Delegate1();
		[LiskovSubstitution("")]event Delegate1 Event1;
	}
}