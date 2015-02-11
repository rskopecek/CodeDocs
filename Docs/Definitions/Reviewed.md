Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Reviewed
====================

> Used to tag that an area of code has been reviewed by one or more people.

Defaults: Risk.None and Effort.None

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Belonging
Tags: Review
Interfaces: IBelongingGroup, IReviewTag, INoneRiskTag, INoneEffortTag

#### Quick Example
```csharp
using CodeDocs;

[Reviewed("comment")]
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
    [Reviewed(details)]
    [Reviewed(details, risk)]
    [Reviewed(details, effort)]
    [Reviewed(details, yyyymmdd)]
    [Reviewed(details, risk, effort)]
    [Reviewed(details, risk, yyyymmdd)]
    [Reviewed(details, effort, yyyymmdd)]
    [Reviewed(details, risk, effort, yyyymmdd)]
    [Reviewed(details, tagsAndReferences)]
    [Reviewed(details, risk, tagsAndReferences)]
    [Reviewed(details, effort, tagsAndReferences)]
    [Reviewed(details, yyyymmdd, tagsAndReferences)]
    [Reviewed(details, risk, effort, tagsAndReferences)]
    [Reviewed(details, risk, yyyymmdd, tagsAndReferences)]
    [Reviewed(details, effort, yyyymmdd, tagsAndReferences)]
    [Reviewed(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"