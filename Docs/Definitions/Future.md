Action: [Glossary]() [Getting Started]()

Found an issue or want another definition added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)


---

Future
====================

> A potential future scenario, in which this will need to be changed or these are some insights about the change.

Defaults: Risk.Low and Effort.None

Attaches To: Assembly, Class, Struct, Interface, Enum, Field, Property, Delegate, Event, Constructor, Method

Group: Confidence
Tags: Work, Future, YAGNI
Interfaces: IConfidenceGroup, IWorkTag, IFutureTag, IYAGNITag, ILowRiskTag, INoneEffortTag

#### Quick Example
```csharp
using CodeDocs;

[Future("comment")]
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
    [Future(details)]
    [Future(details, risk)]
    [Future(details, effort)]
    [Future(details, yyyymmdd)]
    [Future(details, risk, effort)]
    [Future(details, risk, yyyymmdd)]
    [Future(details, effort, yyyymmdd)]
    [Future(details, risk, effort, yyyymmdd)]
    [Future(details, tagsAndReferences)]
    [Future(details, risk, tagsAndReferences)]
    [Future(details, effort, tagsAndReferences)]
    [Future(details, yyyymmdd, tagsAndReferences)]
    [Future(details, risk, effort, tagsAndReferences)]
    [Future(details, risk, yyyymmdd, tagsAndReferences)]
    [Future(details, effort, yyyymmdd, tagsAndReferences)]
    [Future(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"