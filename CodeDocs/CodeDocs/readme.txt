
***Important: If 1st public NuGet version (1.0.0-CI00002) was used, 
				all code for that is now under the namespace "CodeDocs.v1" and tagged [obsolete]


Getting Started:

	https://github.com/rskopecek/CodeDocs/GettingStarted.md

	Questions, problems, features? Hit me up on Twitter @rskopecek

	Thanks for using CodeDocs & would love to know how you are using it!

Components:

	CodeDocs(.dll):				Base project with all of the attributes and functionality.
	CodeDocs.Definitions(.dll):	Code-based definitions for CodeDocs to run T4 reliably against.


Versioning:

	Major Version - changes

		1. NuGet/Assembly version numbers will be updated (x.0.0)
		2. New code will be grouped into the "vX" folder.
		3. Immediate prior major versions will be left in their "vX-1" folder with [obsolete] tags added

		When major versions are added, this should allow you to update via NuGet and migrate on your schedule.

	Minor Version - changes

		1. NuGet/Assembly version numbers will be updated (0.x.0)
		2. Code will remain in the same "vX" folder
		3. Breaking changes may occur but are considered small enough in scope that should be managable

	Incr Version - changes

		1. NuGet/Assembly version numbers will be updated (0.0.x)
		2. Changes will be considered non-breaking fixes or improvements
