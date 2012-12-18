//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace WebNoteAOP.Models.WebNoteCategory
{
    [System.CodeDom.Compiler.GeneratedCode("ADO.NET Unit Testable Repository Generator", "0.5")]
    public partial class CategoryToNode
    {
        #region Primitive Properties
    
        public virtual int CategoryId
        {
            get { return _categoryId; }
            set
            {
                if (_categoryId != value)
                {
                    if (Category != null && Category.CategoryId != value)
                    {
                        Category = null;
                    }
                    _categoryId = value;
                }
            }
        }
        private int _categoryId;
    
        public virtual int NoteId
        {
            get;
            set;
        }

        #endregion
    	
    
    	#if !DO_NOT_INCLUDE_EQUALITY_MEMBERS  
        #region Equality Members
        
        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">first object to compare</param>
        /// <param name="right">second object to compare</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(CategoryToNode left, CategoryToNode right)
        {
            return Equals(left, right);
        }
    
        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">first object to compare</param>
        /// <param name="right">second object to compare</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(CategoryToNode left, CategoryToNode right)
        {
            return !Equals(left, right);
        }	
    
        /// <summary>
        /// Determines whether the specified <see cref="CategoryToNode"/> is equal to this instance.
        /// </summary>
        /// <param name="other">The <see cref="CategoryToNode"/> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="CategoryToNode"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public bool Equals(CategoryToNode other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
    
            if (ReferenceEquals(this, other))
            {
                return true;
            }
    
            if (other.CategoryId != this.CategoryId) 
            {
                return false;
            }
    
            if (other.NoteId != this.NoteId) 
            {
                return false;
            }
    	
            return true;
        }
        
        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///     <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
    
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
    
            if (obj.GetType() != typeof(CategoryToNode))
            {
                return false;
            }
    
            return Equals((CategoryToNode)obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
    		if (this.CategoryId != 0) 
    		{
            	return CategoryId;
    		}
    		if (this.NoteId != 0) 
    		{
            	return NoteId;
    		}
    
    		List<object> entities = new List<object>();
            entities.Add(this.CategoryId);
            entities.Add(this.NoteId);
    		return CombineHashCodes(entities.ToArray());
        }
    	
        /// <summary>Computing a useful hash-code by left-shifting by 5 bits before XORing</summary>
        public static int CombineHashCodes(params object[] objects)
        {
            int hash = 0;
    
            for (int index = 0; index < objects.Length; index++)
            {
                hash = (hash << 5) + hash;
                hash ^= GetEntryHash(objects[index]);
            }
    
            return hash;
        }
    	
        private static int GetEntryHash(object entry)
        {
            int entryHash = 0x61E04917; // slurped from .Net runtime internals...
    
            if (entry != null)
            {
                object[] subObjects = entry as object[];
    
                if (subObjects != null)
                {
                    entryHash = CombineHashCodes(subObjects);
                }
                else
                {
                    entryHash = entry.GetHashCode();
                }
            }
    
            return entryHash;
        }

        #endregion
    	#endif
     
        #region Navigation Properties
    
        public virtual Category Category
        {
            get { return _category; }
            set
            {
                if (!ReferenceEquals(_category, value))
                {
                    var previousValue = _category;
                    _category = value;
                    FixupCategory(previousValue);
                }
            }
        }
        private Category _category;

        #endregion
        #region Association Fixup
    
        private void FixupCategory(Category previousValue)
        {
            if (previousValue != null && previousValue.CategoryToNodes.Contains(this))
            {
                previousValue.CategoryToNodes.Remove(this);
            }
    
            if (Category != null)
            {
                if (!Category.CategoryToNodes.Contains(this))
                {
                    Category.CategoryToNodes.Add(this);
                }
                if (CategoryId != Category.CategoryId)
                {
                    CategoryId = Category.CategoryId;
                }
            }
        }

        #endregion
    }
}