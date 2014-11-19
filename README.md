CodeDocs
========
Code-based documentation and risk management (Code-quality metadata)

Getting Started
---------------

Install from [NuGet](https://www.nuget.org/packages/CodeDocs):
```
PM> Install-Package codedocs -Pre
```

###Why?

* **Tokens (Code-based comments)**. Developers use tokens (ex "//token: message") to leave little hints about things which are only available in the IDE.  They are also restricted to only a key/message pair.
* **3rd Party**.  With all the great tools to discuss on a per line, pull request, etc (ex github) all that information is kept in an external system.  More than that, as code versions layer on top of each other the context of the comments for a particular context (ex line of code) can become less and less trackable and relavent.
* **Code Reviews**.  Frequently code reviews result in preventing code promotion, adding tasks in 3rd party systems, or even adding tokens into the code.  Each one may leave with an undesirable behavior like external tasks that are no longer relavent because the code has been refactored and is deleted now.
* **Risk Identification**.  Oftentimes developers accept certain risks with the code/design that they have put together but due to various reasons are still required to ship.  CodeDocs allows developers to register the risk level (& assumed effort to resolve) so that it is easily queryable and decisions can then be made regarding what to do.
* **Self-Awareness**.  Code quality both for runtime and deployment time can benefit from knowing little hints that developers leave.  What if a 3rd party component had a feature that was tagged experimental, but your code trusted it fully?  Another example could be in a test enviornment certain features can then be auto-disabled if their quality level is below standards.

###Available attributes

As defined in the [definitions.json](https://github.com/rskopecek/CodeDocs/blob/master/CodeDocs/CodeDocs/glossary.json)

Bug, MajorFix, MinorFix, Slow, Todo, Consequence, DeadCode,
Security, Insecure, Test, Toxic, Cite, Feature, Location,
MajorChange, MinorChange, Naming, Readability,
Reviewed, Standards, Clarification, Future,
Hack, Purpose, Refactor,
DependancyInversion, DontRepeatYourself, InterfaceSegregation,
LeastKnowledge, LiskovSubstitution, OccamsRazor, OpenClosed,
SeparationOfConcerns, SingleResponsibility, YouArentGonnaNeedIt


###Examples 
```csharp
    [Bug("comment")]
    [Bug("comment", Risk.None)]
    [Bug("comment", Effort.None)]
    [Bug("comment", 20010203)]
    [Bug("comment", Risk.None, Effort.None)]
    [Bug("comment", Risk.None, 20010203)]
    [Bug("comment", Effort.None, 20010203)]
    [Bug("comment", Risk.None, Effort.None, 20010203)]
    [Bug("comment", "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, "tag", "http://stackoverflow.com")]
    [Bug("comment", Effort.None, "tag", "http://stackoverflow.com")]
    [Bug("comment", 20010203, "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, Effort.None, "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, 20010203, "tag", "http://stackoverflow.com")]
    [Bug("comment", Effort.None, 20010203, "tag", "http://stackoverflow.com")]
    [Bug("comment", Risk.None, Effort.None, 20010203, "tag", "http://stackoverflow.com")]
    public class Example {}
```
