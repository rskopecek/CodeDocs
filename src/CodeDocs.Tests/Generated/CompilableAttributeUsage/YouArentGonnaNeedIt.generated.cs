using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[YouArentGonnaNeedIt("")] internal interface IYouArentGonnaNeedItExample{}
	[YouArentGonnaNeedIt("")] internal struct YouArentGonnaNeedItStructExample{}
	[YouArentGonnaNeedIt("")] internal class YouArentGonnaNeedItExample : IYouArentGonnaNeedItExample
	{
		[YouArentGonnaNeedIt("")] internal YouArentGonnaNeedItExample() { Variable1 = "1"; Property1 = "1"; }
		[YouArentGonnaNeedIt("")] private enum Enum1 {B};
		[YouArentGonnaNeedIt("")] private readonly string Variable1;
		[YouArentGonnaNeedIt("")] private string Property1 { get; set; }
		[YouArentGonnaNeedIt("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[YouArentGonnaNeedIt("")] delegate bool Delegate1();
		[YouArentGonnaNeedIt("")]event Delegate1 Event1;
	}
}