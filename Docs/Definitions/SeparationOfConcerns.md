Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Separation Of Concerns
====================

> The design should divide areas of concern into their own distinct sections.

Defaults: Risk.Moderate and Effort.Medium

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Principles
Tags: Principles, SoC
Interfaces: IPrinciplesGroup, IPrinciplesTag, ISoCTag, IModerateRiskTag, IMediumEffortTag

#### Quick Example
```csharp
using CodeDocs;

[SeparationOfConcerns("comment")]
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
    [SeparationOfConcerns(details)]
    [SeparationOfConcerns(details, risk)]
    [SeparationOfConcerns(details, effort)]
    [SeparationOfConcerns(details, yyyymmdd)]
    [SeparationOfConcerns(details, risk, effort)]
    [SeparationOfConcerns(details, risk, yyyymmdd)]
    [SeparationOfConcerns(details, effort, yyyymmdd)]
    [SeparationOfConcerns(details, risk, effort, yyyymmdd)]
    [SeparationOfConcerns(details, tagsAndReferences)]
    [SeparationOfConcerns(details, risk, tagsAndReferences)]
    [SeparationOfConcerns(details, effort, tagsAndReferences)]
    [SeparationOfConcerns(details, yyyymmdd, tagsAndReferences)]
    [SeparationOfConcerns(details, risk, effort, tagsAndReferences)]
    [SeparationOfConcerns(details, risk, yyyymmdd, tagsAndReferences)]
    [SeparationOfConcerns(details, effort, yyyymmdd, tagsAndReferences)]
    [SeparationOfConcerns(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"