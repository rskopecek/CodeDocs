# CodeDocs

Code Quality Metadata.  Filling the gap of known areas of improvement that still have to ship, or already did.

Code-based conversation around the quality and design of the code.

## v0.1.x Conversation

* [What attributes should be included?](https://github.com/rskopecek/CodeDocs/issues/1)
* [What patterns & principles should be included?](https://github.com/rskopecek/CodeDocs/issues/2)
* [What attribute arguments should be included?](https://github.com/rskopecek/CodeDocs/issues/3)

## Versions

*Pre 1.0, code is strictly considered usable development regardless of version stability.*

Goals:
- [x] Release [0.1.0](https://www.nuget.org/packages/codedocs/0.1.0)
- [ ] [0.1.x](https://github.com/rskopecek/CodeDocs/milestone/1) = [Attributes](https://github.com/rskopecek/CodeDocs/issues/1), [Patterns & Principles](https://github.com/rskopecek/CodeDocs/issues/2), and [attribute args](https://github.com/rskopecek/CodeDocs/issues/3)
- [ ] [0.2.x](https://github.com/rskopecek/CodeDocs/milestone/2) = [Detection functionality](https://github.com/rskopecek/CodeDocs/issues/4), [naming](https://github.com/rskopecek/CodeDocs/issues/5), and [scoping](https://github.com/rskopecek/CodeDocs/issues/6)
- [ ] [0.3.x](https://github.com/rskopecek/CodeDocs/milestone/3) = [.Net version multi-targeting](https://github.com/rskopecek/CodeDocs/issues/7), [CI](https://github.com/rskopecek/CodeDocs/issues/8), and [runtime reporting](https://github.com/rskopecek/CodeDocs/issues/9)
- [ ] 0.4+.x = TBD (ex. hardening, documentation, in-code versioning)
- [ ] 1.0

*Bugs are no fun.  If you find one feel free to add an issue.  Just keep in mind bugs will only be addressed for the existing scope.*

*Historical: If you used the nuget prerelease versions (CI00002) from 2014, while the changes are breaking, most of the capabilities translate into a different representation.  If there is a particular item not migrated, please comment as such and your use case in the above listed area.  To prevent potential confusion for the project direction, the 3 original prerelase versions (1.0.0-CI00002, 2.0.0-CI00002, 2.0.1-CI00002) are being unlisted.  However, they can still be accessed by their specific version number on nuget.*

## Rules & Goals

* Don't break production (runtime, not compiletime)
* Allow a code-based conversation around the quality and design of the code
* Enable simple usage and detection
* No dependancies outside of targeted .net frameworks
* Detection performance is important, be less important than readability
* Enable CI systems to generate useful informationa nd even stop the build if deteced quality concerns reach an unreasonable level
* Positive growth of developers and reviewers

## Getting Started

### 1) Install Quickly ([NuGet](https://www.nuget.org/packages/CodeDocs)):
```
PM> Install-Package codedocs
```

### 2) Use Freely (Add "Using CodeDocs", [List of attributes](https://github.com/rskopecek/CodeDocs/tree/master/src/CodeDocs/Generated))

```csharp
    using CodeDocs;

    [Naming("Class2 doesn't provided any meaning to the functionality provided")]
    public class Class2
    {
       [SideEffects(solid: Solid.SingleResponsibility, id: "external id")]
        public int Add(int x, int y)
        {
            // ...Code that updates a database/etc

            return x + y;
        }
        
        [Toxic("Can't touch this", see: "Mc Hammer", risk: Level.Massive)]
        public void SomethingTerrible()
        { 
            // cryptic code that nightmares are made of
            // nothing makes sense, but if you do anything here
            // something breaks and no one knows why
        }       
        
        [Insecure("Needs to be changed to Sha512", see: "https://troyhunt.com/#sha512"), Standards(see: "InternalStandardsDoc")]
        public string Hasher(string value, byte[] salt)
        {
            return Sha1.Hash(value, salt);
        }      
        [Docs("Very cool.  Needs to be added to the core documentation please.", see: "Arch.visio", effortAmount: 3)]
        public void AwesomeCode()
        {
            // beautifully crafted code with a purpose
        }       
        
    }
```

### 3) Consume Easily

*"using CodeDocs.Detection;" decorates app domains, assemblies, types, or instances with ".GetCodeDocs()"*

Docs are item level (domain, assembly, type, or member) with potentially multiple attributes.

```csharp
    using CodeDocs;
    using CodeDocs.Detection;

    void DoSomething(Abc abc)
    {
        var docs = abc.GetCodeDocs();
        
        // or typeof(this).GetCodeDocs();
        // or typeof(abc).Assembly.GetCodeDocs();
        // or typeof(this).Assembly.GetCodeDocs(type => type.Namespace.Contains("MyStuff.SectionA"))
        // or AppDomain.CurrentDomain.GetCodeDocs(assembly => assembly.Name.Contains("MyStuff"));
        
        // Extensions for individual and IEnumerable app domain, assembly, type, and member, instance object are available
        
        var csv = docs.ToCsv();

        // See CodeDocs.Examples console app for runnable samples of 3k+ docs
    }
```

### Some reasons why

Subject | Description
------- | -----------
Tokens | Developers use tokens (ex "//token: message") to leave little hints about things which are only available in the IDE.  They are also restricted to only a key/message pair.
3rd Party | With all the great tools to discuss on a per line, pull request, etc (ex github) all that information is kept in an external system.  More than that, as code versions layer on top of each other the context of the comments for a particular context (ex line of code) can become less and less trackable and relavent.
Code Reviews | Code reviews are both for the benefit of code quality and learning experience for the reviewers and developers.  Code-based docs allow for another level of conversation.
Tech Debt | Oftentimes developers accept certain risks with the code/design that they have put together but due to various reasons are still required to ship.  CodeDocs allows developers to register the risk level (& assumed effort to resolve) so that it is easily queryable and decisions can then be made regarding what to do.  This comes in handy when inheriting a code base.
Self-Awareness | Code quality both for runtime and deployment time can benefit from knowing little hints that developers leave.  What if your component or a 3rd party component had a feature that was considered very risky, but your code trusted it fully?  Another example could be in a test enviornment certain features can then be auto-disabled if their quality level is below standards.  Or simply used in a CI system.


## Preventing Breakage for Developers

While part of the goal of this solution v1+ surrounds stability, the concern is always around preventing breaking others' code.

While the code sharing and distribution system of packages (ex. nuget) are used from a technical sense, those types of systems are not good at collaboration and communication.  Even version numbering is or can be highly subjective.  As a balance, changes including their positive/negative effects as well as the meaning surrounding versioning will be maintained by following this repo.  If a potential change could result in breaking systems for you, please speak up on the appropriate work item.  It may not guarantee your need can be rectified due to conflicting interests, but it will help prevent avoidable situations or provide leadtime for reasonable actions on your part.
