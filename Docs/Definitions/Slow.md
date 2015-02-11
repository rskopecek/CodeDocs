Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Slow
====================

> A piece of code that is slower than desired and need refactored.

Defaults: Risk.Moderate and Effort.Medium

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Functional
Tags: Performance, Degredation
Interfaces: IFunctionalGroup, IPerformanceTag, IDegredationTag, IModerateRiskTag, IMediumEffortTag, IOnePerContextTag

#### Quick Example
```csharp
using CodeDocs;

[Slow("comment")]
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
    [Slow(details)]
    [Slow(details, risk)]
    [Slow(details, effort)]
    [Slow(details, yyyymmdd)]
    [Slow(details, risk, effort)]
    [Slow(details, risk, yyyymmdd)]
    [Slow(details, effort, yyyymmdd)]
    [Slow(details, risk, effort, yyyymmdd)]
    [Slow(details, tagsAndReferences)]
    [Slow(details, risk, tagsAndReferences)]
    [Slow(details, effort, tagsAndReferences)]
    [Slow(details, yyyymmdd, tagsAndReferences)]
    [Slow(details, risk, effort, tagsAndReferences)]
    [Slow(details, risk, yyyymmdd, tagsAndReferences)]
    [Slow(details, effort, yyyymmdd, tagsAndReferences)]
    [Slow(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"