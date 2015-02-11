using System;
using CodeDocs;

namespace CodeDocs.Tests.AttributeUsage
{
	[DontRepeatYourself("")] internal interface IDontRepeatYourselfExample{}
	[DontRepeatYourself("")] internal struct DontRepeatYourselfStructExample{}
	[DontRepeatYourself("")] internal class DontRepeatYourselfExample : IDontRepeatYourselfExample
	{
		[DontRepeatYourself("")] internal DontRepeatYourselfExample() { Variable1 = "1"; Property1 = "1"; }
		[DontRepeatYourself("")] private enum Enum1 {B};
		[DontRepeatYourself("")] private readonly string Variable1;
		[DontRepeatYourself("")] private string Property1 { get; set; }
		[DontRepeatYourself("")] private Enum1 MethodParam1(Enum1 abc){return abc;}
		[DontRepeatYourself("")] delegate bool Delegate1();
		[DontRepeatYourself("")]event Delegate1 Event1;
	}
}