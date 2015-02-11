Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Standards
====================

> A piece of code that needs refactored to adhere to code/design standards.

Defaults: Risk.Low and Effort.VerySmall

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Belonging
Tags: Standards
Interfaces: IBelongingGroup, IStandardsTag, ILowRiskTag, IVerySmallEffortTag, IOnePerContextTag

#### Quick Example
```csharp
using CodeDocs;

[Standards("comment")]
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
    [Standards(details)]
    [Standards(details, risk)]
    [Standards(details, effort)]
    [Standards(details, yyyymmdd)]
    [Standards(details, risk, effort)]
    [Standards(details, risk, yyyymmdd)]
    [Standards(details, effort, yyyymmdd)]
    [Standards(details, risk, effort, yyyymmdd)]
    [Standards(details, tagsAndReferences)]
    [Standards(details, risk, tagsAndReferences)]
    [Standards(details, effort, tagsAndReferences)]
    [Standards(details, yyyymmdd, tagsAndReferences)]
    [Standards(details, risk, effort, tagsAndReferences)]
    [Standards(details, risk, yyyymmdd, tagsAndReferences)]
    [Standards(details, effort, yyyymmdd, tagsAndReferences)]
    [Standards(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"