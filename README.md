CodeDocs
========
Code-based documentation and risk management (Code-quality metadata)

Feel free to chat on twitter if you've got questions & such. [@rskopecek](https://twitter.com/rskopecek)

Getting Started
---------------

1) Install Quickly ([NuGet](https://www.nuget.org/packages/CodeDocs)):
```
PM> Install-Package codedocs -Pre
```

2) Use Freely
```csharp
    using CodeDocs;

    [Feature("Class2 brings awesome functionality you can't live without")]
    [Naming("Class 2 doesn't provided any meaning to the functionality provided")]
    class Class2
    {
        [Insecure("Oh no", 
            "encryption", "http://www.troyhunt.com/2013/07/how-to-build-and-how-not-to-build.html")]
        private string Encrypt(byte[] data)
        {
            return Convert.ToBase64String(data);
        }
        
        [Toxic("Whatever you do don't change below or the whole system state will crash")]
        private class abc { /* code horror movies are made of...be advised O.O */ }
        
        [Bug("Divide by 0?", Risk.High, Effort.VerySmall)]
        public double CalculateStuff(int x, int y)
        {
            return x / y;
        }
    }
```

3) Consume Easily
```csharp
    using CodeDocs;

    void DoSomething(Abc abc)
    {
        var docs = abc.GetCodeDocs();
        // or
        var docs = typeof(this).GetCodeDocs();
        // or
        var docs = typeof(abc).Assembly.GetCodeDocs();
    }
```




###Why?

* **Tokens (Code-based comments)**. Developers use tokens (ex "//token: message") to leave little hints about things which are only available in the IDE.  They are also restricted to only a key/message pair.
* **3rd Party**.  With all the great tools to discuss on a per line, pull request, etc (ex github) all that information is kept in an external system.  More than that, as code versions layer on top of each other the context of the comments for a particular context (ex line of code) can become less and less trackable and relavent.
* **Code Reviews**.  Frequently code reviews result in preventing code promotion, adding tasks in 3rd party systems, or even adding tokens into the code.  Each one may leave with an undesirable behavior like external tasks that are no longer relavent because the code has been refactored and is deleted now.
* **Risk Identification**.  Oftentimes developers accept certain risks with the code/design that they have put together but due to various reasons are still required to ship.  CodeDocs allows developers to register the risk level (& assumed effort to resolve) so that it is easily queryable and decisions can then be made regarding what to do.
* **Self-Awareness**.  Code quality both for runtime and deployment time can benefit from knowing little hints that developers leave.  What if a 3rd party component had a feature that was tagged experimental, but your code trusted it fully?  Another example could be in a test enviornment certain features can then be auto-disabled if their quality level is below standards.

###Available attributes

As defined in the [glossary.json](https://github.com/rskopecek/CodeDocs/blob/master/CodeDocs/CodeDocs/glossary.json)

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

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via ".References" and tags at ".Tags"

####Variations
```csharp
    [Attribute(details)]
    [Attribute(details, risk)]
    [Attribute(details, effort)]
    [Attribute(details, yyyymmdd)]
    [Attribute(details, risk, effort)]
    [Attribute(details, risk, yyyymmdd)]
    [Attribute(details, effort, yyyymmdd)]
    [Attribute(details, risk, effort, yyyymmdd)]
    [Attribute(details, tagsAndReferences)]
    [Attribute(details, risk, tagsAndReferences)]
    [Attribute(details, effort, tagsAndReferences)]
    [Attribute(details, yyyymmdd, tagsAndReferences)]
    [Attribute(details, risk, effort, tagsAndReferences)]
    [Attribute(details, risk, yyyymmdd, tagsAndReferences)]
    [Attribute(details, effort, yyyymmdd, tagsAndReferences)]
    [Attribute(details, risk, effort, yyyymmdd, tagsAndReferences)]
```
