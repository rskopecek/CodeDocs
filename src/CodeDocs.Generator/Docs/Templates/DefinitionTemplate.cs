﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeDocs.Generator.Docs.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class DefinitionTemplate : DefinitionTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 6 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"

	var tags = Definition.Tags.ToList();

	

            
            #line default
            #line hidden
            this.Write("Action: [Glossary]() [Getting Started]()\r\n\r\nFound an issue or want another defini" +
                    "tion added? [Submit it](https://github.com/rskopecek/CodeDocs/issues/new)\r\n\r\n\r\n-" +
                    "--\r\n\r\n");
            
            #line 18 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Name));
            
            #line default
            #line hidden
            this.Write("\r\n====================\r\n\r\n> ");
            
            #line 21 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Description));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nAttaches To: ");
            
            #line 23 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", Glossary.Scope)));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nTags: ");
            
            #line 25 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", Definition.Tags)));
            
            #line default
            #line hidden
            this.Write("\r\nInterfaces: ");
            
            #line 26 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", Definition.InterfaceNames())));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n#### Quick Example\r\n```csharp\r\nusing CodeDocs;\r\n\r\n[");
            
            #line 32 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(\"comment\")]\r\npublic class Abc{}\r\n\r\npublic class DependantOnAbc\r\n{\r\n\tpublic void " +
                    "DoSomething()\r\n\t{\r\n\t\tvar docs = typeof(Abc).GetCodeDocs();\r\n\r\n\t\t/* do something " +
                    "with that knowledge */\r\n\t}\r\n}\r\n```\r\n\r\n#### Variations\r\n```csharp\r\n    [");
            
            #line 48 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details)]\r\n    [");
            
            #line 49 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk)]\r\n    [");
            
            #line 50 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, effort)]\r\n    [");
            
            #line 51 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, yyyymmdd)]\r\n    [");
            
            #line 52 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk, effort)]\r\n    [");
            
            #line 53 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk, yyyymmdd)]\r\n    [");
            
            #line 54 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, effort, yyyymmdd)]\r\n    [");
            
            #line 55 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk, effort, yyyymmdd)]\r\n    [");
            
            #line 56 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, tagsAndReferences)]\r\n    [");
            
            #line 57 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk, tagsAndReferences)]\r\n    [");
            
            #line 58 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, effort, tagsAndReferences)]\r\n    [");
            
            #line 59 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, yyyymmdd, tagsAndReferences)]\r\n    [");
            
            #line 60 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk, effort, tagsAndReferences)]\r\n    [");
            
            #line 61 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, risk, yyyymmdd, tagsAndReferences)]\r\n    [");
            
            #line 62 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write("(details, effort, yyyymmdd, tagsAndReferences)]\r\n    [");
            
            #line 63 "C:\Users\Randy\Documents\GitHub\CodeDocs\src\CodeDocs.Generator\Docs\Templates\DefinitionTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Definition.Id));
            
            #line default
            #line hidden
            this.Write(@"(details, risk, effort, yyyymmdd, tagsAndReferences)]
```

###General Usage Structure
Type | Name | Description
--- | --- | ---
string | details | What needs to be conveyed given the context/attribute used. (required)
Risk | risk | Enum expression of the risk associated with the context/attribute.  Values are None[0], Low[3], Moderate[21], High[89], Extreme[144]
Effort | effort | Enum expression of the effort required to address given the context/attribute.  Values are None[0], VerySmall[1], Small[8], Medium[34], Large[55], VeryLarge[89], Unknown[144]
int | yyyymmdd | Date to attach to the context/attribute.  .Net Attributes don't allow DateTime so it is expressed as an int in one field and converted to DateTime for your use.
params string[] | tagsAndReferences | Tags or Uris/Urls. Order doesn't matter and no limit.  Detected Uris will be available via "".References"" and tags at "".Tags""");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class DefinitionTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
