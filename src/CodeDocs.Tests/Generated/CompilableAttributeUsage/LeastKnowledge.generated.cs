using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[LeastKnowledge("")] internal interface ILeastKnowledgeExample{}
	[LeastKnowledge("")] internal struct LeastKnowledgeStructExample{}
	[LeastKnowledge("")] internal class LeastKnowledgeExample : ILeastKnowledgeExample
	{
		[LeastKnowledge("")] internal LeastKnowledgeExample() { Variable1 = "1"; Property1 = "1"; }
		[LeastKnowledge("")] private enum Enum1 {B};
		[LeastKnowledge("")] private readonly string Variable1;
		[LeastKnowledge("")] private string Property1 { get; set; }
		[LeastKnowledge("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[LeastKnowledge("")] delegate bool Delegate1();
		[LeastKnowledge("")]event Delegate1 Event1;
	}
}