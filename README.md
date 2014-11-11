CodeDocs
========
Code-based documentation and risk management (Code-quality metadata)

Why?
----

Tokens (Code-based comments)
------
Developers frequently use code-based comments (tokens) to leave little hints about things (ex. todo, hack, undone).  Unfortunately, these little notes are 1) only comments and for the most part only available when visual studio is open and 2) restricted to only a key/value pair of "//token: message".

3rd Party
---------
With all the great tools to discuss on a per line, pull request, etc (ex github) all that information is kept in an external system.  More than that, as code versions layer on top of each other the context of the comments for a particular context (ex line of code) can become less and less trackable and relavent.  One of the results you can insist on is "from the discussion" add the code-quality metadata.  That way, it is always available for use and tracks appropriately with every version.

Code Reviews
------------
Frequently code reviews result in preventing code promotion, adding tasks in 3rd party systems, or even adding code-based comments into the code.  Each one may leave with an undesirable behavior like external tasks that are no longer relavent because the code has been refactored and is deleted now (which may result in the 3rd party system's tasks being out of sync).  With CodeDocs, just add the metadata and query it later to achieve your goals.  This also helps give an alternative means for developers might also put code based comments anyway just to keep track of things.

Risk Identification
-------------------
Oftentimes developers accept certain risks with the code/design that they have put together but due to various reasons are still required to ship.  CodeDocs allows developers to register the risk level (& assumed effort to resolve) so that it is easily queryable and decisions can then be made regarding what to do.

Self-Awareness (not AI)
-----------------------
Since developers now have a useful layer of code-quality metadata, it can be used for various purposes.  It can be used to output a risk report or make sure pending external work tracking systems have all of the pending work listed.  It can also be used to alter behavior of the code running including whether to trust (or not to trust) a particular section of code due to it's detected quality level.  An example could be adding an automated test to prevent code from going into production if unfinished work is found or if the overall risk amount is over 5000.  Another example could be in a test enviornment certain features can then be auto-disabled if their quality level is below standards.



