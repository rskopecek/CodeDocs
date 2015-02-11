Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Single Responsibility
====================

> [The S in SOLID] Each context of code should do one thing and thus have only one reason to change.

Defaults: Risk.Moderate and Effort.Medium

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Principles
Tags: Principles, SOLID, SRP
Interfaces: IPrinciplesGroup, IPrinciplesTag, ISOLIDTag, ISRPTag, IModerateRiskTag, IMediumEffortTag

#### Quick Example
```csharp
using CodeDocs;

[SingleResponsibility("comment")]
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
    [SingleResponsibility(details)]
    [SingleResponsibility(details, risk)]
    [SingleResponsibility(details, effort)]
    [SingleResponsibility(details, yyyymmdd)]
    [SingleResponsibility(details, risk, effort)]
    [SingleResponsibility(details, risk, yyyymmdd)]
    [SingleResponsibility(details, effort, yyyymmdd)]
    [SingleResponsibility(details, risk, effort, yyyymmdd)]
    [SingleResponsibility(details, tagsAndReferences)]
    [SingleResponsibility(details, risk, tagsAndReferences)]
    [SingleResponsibility(details, effort, tagsAndReferences)]
    [SingleResponsibility(details, yyyymmdd, tagsAndReferences)]
    [SingleResponsibility(details, risk, effort, tagsAndReferences)]
    [SingleResponsibility(details, risk, yyyymmdd, tagsAndReferences)]
    [SingleResponsibility(details, effort, yyyymmdd, tagsAndReferences)]
    [SingleResponsibility(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"