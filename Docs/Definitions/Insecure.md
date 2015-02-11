Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Insecure
====================

> An identified security issue.

Defaults: Risk.Extreme and Effort.Unknown

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Safety
Tags: Security, InSecure, Degredation
Interfaces: ISafetyGroup, ISecurityTag, IInSecureTag, IDegredationTag, IExtremeRiskTag, IUnknownEffortTag

#### Quick Example
```csharp
using CodeDocs;

[Insecure("comment")]
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
    [Insecure(details)]
    [Insecure(details, risk)]
    [Insecure(details, effort)]
    [Insecure(details, yyyymmdd)]
    [Insecure(details, risk, effort)]
    [Insecure(details, risk, yyyymmdd)]
    [Insecure(details, effort, yyyymmdd)]
    [Insecure(details, risk, effort, yyyymmdd)]
    [Insecure(details, tagsAndReferences)]
    [Insecure(details, risk, tagsAndReferences)]
    [Insecure(details, effort, tagsAndReferences)]
    [Insecure(details, yyyymmdd, tagsAndReferences)]
    [Insecure(details, risk, effort, tagsAndReferences)]
    [Insecure(details, risk, yyyymmdd, tagsAndReferences)]
    [Insecure(details, effort, yyyymmdd, tagsAndReferences)]
    [Insecure(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"