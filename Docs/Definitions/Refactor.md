Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Refactor
====================

> Working feature that needs improvement

Defaults: Risk.Low and Effort.Unknown

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Confidence
Tags: Degredation
Interfaces: IConfidenceGroup, IDegredationTag, ILowRiskTag, IUnknownEffortTag, IOnePerContextTag

#### Quick Example
```csharp
using CodeDocs;

[Refactor("comment")]
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
    [Refactor(details)]
    [Refactor(details, risk)]
    [Refactor(details, effort)]
    [Refactor(details, yyyymmdd)]
    [Refactor(details, risk, effort)]
    [Refactor(details, risk, yyyymmdd)]
    [Refactor(details, effort, yyyymmdd)]
    [Refactor(details, risk, effort, yyyymmdd)]
    [Refactor(details, tagsAndReferences)]
    [Refactor(details, risk, tagsAndReferences)]
    [Refactor(details, effort, tagsAndReferences)]
    [Refactor(details, yyyymmdd, tagsAndReferences)]
    [Refactor(details, risk, effort, tagsAndReferences)]
    [Refactor(details, risk, yyyymmdd, tagsAndReferences)]
    [Refactor(details, effort, yyyymmdd, tagsAndReferences)]
    [Refactor(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"