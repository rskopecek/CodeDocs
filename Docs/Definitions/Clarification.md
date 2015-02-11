Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Clarification
====================

> Readable, but missing a 'good to know' for people trying to understand.

Defaults: Risk.Low and Effort.VerySmall

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Confidence
Tags: Meaning
Interfaces: IConfidenceGroup, IMeaningTag, ILowRiskTag, IVerySmallEffortTag

#### Quick Example
```csharp
using CodeDocs;

[Clarification("comment")]
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
    [Clarification(details)]
    [Clarification(details, risk)]
    [Clarification(details, effort)]
    [Clarification(details, yyyymmdd)]
    [Clarification(details, risk, effort)]
    [Clarification(details, risk, yyyymmdd)]
    [Clarification(details, effort, yyyymmdd)]
    [Clarification(details, risk, effort, yyyymmdd)]
    [Clarification(details, tagsAndReferences)]
    [Clarification(details, risk, tagsAndReferences)]
    [Clarification(details, effort, tagsAndReferences)]
    [Clarification(details, yyyymmdd, tagsAndReferences)]
    [Clarification(details, risk, effort, tagsAndReferences)]
    [Clarification(details, risk, yyyymmdd, tagsAndReferences)]
    [Clarification(details, effort, yyyymmdd, tagsAndReferences)]
    [Clarification(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"