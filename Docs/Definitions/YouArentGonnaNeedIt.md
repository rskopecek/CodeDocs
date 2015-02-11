Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

You Aren't Gonna Need It
====================

> Always implement things when you actually need them, never when you just foresee that you need them.

Defaults: Risk.Moderate and Effort.Medium

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Principles
Tags: Principles, YAGNI
Interfaces: IPrinciplesGroup, IPrinciplesTag, IYAGNITag, IModerateRiskTag, IMediumEffortTag

#### Quick Example
```csharp
using CodeDocs;

[YouArentGonnaNeedIt("comment")]
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
    [YouArentGonnaNeedIt(details)]
    [YouArentGonnaNeedIt(details, risk)]
    [YouArentGonnaNeedIt(details, effort)]
    [YouArentGonnaNeedIt(details, yyyymmdd)]
    [YouArentGonnaNeedIt(details, risk, effort)]
    [YouArentGonnaNeedIt(details, risk, yyyymmdd)]
    [YouArentGonnaNeedIt(details, effort, yyyymmdd)]
    [YouArentGonnaNeedIt(details, risk, effort, yyyymmdd)]
    [YouArentGonnaNeedIt(details, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, risk, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, effort, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, yyyymmdd, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, risk, effort, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, risk, yyyymmdd, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, effort, yyyymmdd, tagsAndReferences)]
    [YouArentGonnaNeedIt(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"