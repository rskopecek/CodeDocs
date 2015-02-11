Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Bug
====================

> Used to acknowledge and identify code that has a live issue even though a resolution has not been identified or implemented.

Defaults: Risk.Extreme and Effort.Unknown

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Functional
Tags: Degredation
Interfaces: IFunctionalGroup, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag

#### Quick Example
```csharp
using CodeDocs;

[Bug("comment")]
public class Abc{}

public class DependantOnAbc
{
	public void DoSomething()
	{
		var docs = typeof(Abc).GetCodeDocs();

		/* do something with that knowledge */
	}
}
```

#### Variations
```csharp
    [Bug(details)]
    [Bug(details, risk)]
    [Bug(details, effort)]
    [Bug(details, yyyymmdd)]
    [Bug(details, risk, effort)]
    [Bug(details, risk, yyyymmdd)]
    [Bug(details, effort, yyyymmdd)]
    [Bug(details, risk, effort, yyyymmdd)]
    [Bug(details, tagsAndReferences)]
    [Bug(details, risk, tagsAndReferences)]
    [Bug(details, effort, tagsAndReferences)]
    [Bug(details, yyyymmdd, tagsAndReferences)]
    [Bug(details, risk, effort, tagsAndReferences)]
    [Bug(details, risk, yyyymmdd, tagsAndReferences)]
    [Bug(details, effort, yyyymmdd, tagsAndReferences)]
    [Bug(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"