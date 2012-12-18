//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
// Name: Microsoft.VisualStudio.QualityTools.UnitTestFramework
// Path: %ProgramFiles(x86)%\Microsoft Visual Studio 10.0\Common7\IDE\PublicAssemblies\Microsoft.VisualStudio.QualityTools.UnitTestFramework.dll
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebNoteAOP.Models.WebNote.WebNoteUnitTest
{
    /// <summary>Unit test for Repository - to be inherited!</summary>
    [System.CodeDom.Compiler.GeneratedCode("ADO.NET Unit Testable Repository Generator", "0.5")]
    [TestClass]
    public abstract class WebNoteBaseRepositoryTest
    {
        /// <summary>
        /// Gets the mocked context
        /// </summary>
        /// <value>mocked context</value>	
        public WebNoteMock Context { get; set; }
        
        /// <summary>
        /// Gets the repository to test
        /// </summary>
        /// <value>initialized repository.</value>
        public WebNoteRepository Repository  { get; set; }
    
        /// <summary>
        /// Set up mocks
        /// </summary>
        [TestInitialize]
        public void InitializeRepository()
        {
            
            Context = new WebNoteMock();
            Context.Notes = new MockObjectSet<Note>(CreateNotesList());
            
            Repository = new WebNoteRepository { Context = Context };
    
        }
    
        /// <summary>
        /// Remove mocks
        /// </summary>
        [TestCleanup]
        public void CleanupRepository()
        {
            Context = null;
            Repository = null;
        }
        
        /// <summary>
        /// Method should return a collection for the MockObjectSet - to be implemented!
        /// </summary>
        public abstract List<Note> CreateNotesList();		
    
    	
    }
}
