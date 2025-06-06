//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:6.0.16
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Changes;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace HSRM.TTC2023.ClassToRelational.Changes
{
    
    
    /// <summary>
    /// The default implementation of the AddToRoot class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/changes")]
    [XmlNamespacePrefixAttribute("changes")]
    [ModelRepresentationClassAttribute("https://github.com/ATL-Research/incremental-class2relational/Changes.nmeta#//AddToRoot")]
    public partial class AddToRoot : NMF.Models.Changes.ElementaryChange, IAddToRoot, NMF.Models.IModelElement
    {
        
        private static Lazy <NMF.Models.Meta.ITypedElement> _newObjectReference = new Lazy <NMF.Models.Meta.ITypedElement>(RetrieveNewObjectReference);
        
        /// <summary>
        /// The backing field for the NewObject property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private NMF.Models.IModelElement _newObject;
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The newObject property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("newObject")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public NMF.Models.IModelElement NewObject
        {
            get
            {
                return this._newObject;
            }
            set
            {
                if ((this._newObject != value))
                {
                    NMF.Models.IModelElement old = this._newObject;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnNewObjectChanging(e);
                    this.OnPropertyChanging("NewObject", e, _newObjectReference);
                    this._newObject = value;
                    if ((old != null))
                    {
                        if ((old.Parent == this))
                        {
                            old.Parent = null;
                        }
                        old.ParentChanged -= this.OnResetNewObject;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.ParentChanged += this.OnResetNewObject;
                    }
                    this.OnNewObjectChanged(e);
                    this.OnPropertyChanged("NewObject", e, _newObjectReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression <NMF.Models.IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new AddToRootChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression <NMF.Models.IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AddToRootReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AddToRoot")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the NewObject property changes its value
        /// </summary>
        public event System.EventHandler <ValueChangedEventArgs> NewObjectChanging;
        
        /// <summary>
        /// Gets fired when the NewObject property changed its value
        /// </summary>
        public event System.EventHandler <ValueChangedEventArgs> NewObjectChanged;
        
        private static NMF.Models.Meta.ITypedElement RetrieveNewObjectReference()
        {
            return ((NMF.Models.Meta.ITypedElement)(((NMF.Models.ModelElement)(HSRM.TTC2023.ClassToRelational.Changes.AddToRoot.ClassInstance)).Resolve("newObject")));
        }
        
        /// <summary>
        /// Raises the NewObjectChanging event
        /// </summary>
        /// <param name="eventArgs">The event data </param>
        protected virtual void OnNewObjectChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler <ValueChangedEventArgs> handler = this.NewObjectChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the NewObjectChanged event
        /// </summary>
        /// <param name="eventArgs">The event data </param>
        protected virtual void OnNewObjectChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler <ValueChangedEventArgs> handler = this.NewObjectChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the NewObject property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request </param>
        /// <param name="eventArgs">The event data for the reset event </param>
        private void OnResetNewObject(object sender, System.EventArgs eventArgs)
        {
            this.NewObject = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI </returns>
        /// <param name="element">The element that should be looked for </param>
        protected override string GetRelativePathForNonIdentifiedChild(NMF.Models.IModelElement element)
        {
            if ((element == this.NewObject))
            {
                return ModelHelper.CreatePath("NewObject");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found </returns>
        /// <param name="reference">The requested reference name </param>
        /// <param name="index">The index of this reference </param>
        protected override NMF.Models.IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "NEWOBJECT"))
            {
                return this.NewObject;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature </param>
        /// <param name="value">The value that should be set to that feature </param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "NEWOBJECT"))
            {
                this.NewObject = ((NMF.Models.IModelElement)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression </returns>
        /// <param name="reference">The requested reference in upper case </param>
        protected override NMF.Expressions.INotifyExpression <NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "NEWOBJECT"))
            {
                return new NewObjectProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("http://nmf.codeplex.com/changes#//AddToRoot")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AddToRoot class
        /// </summary>
        public class AddToRootChildrenCollection : ReferenceCollection, ICollectionExpression <NMF.Models.IModelElement>, ICollection <NMF.Models.IModelElement>
        {
            
            private AddToRoot _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AddToRootChildrenCollection(AddToRoot parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.NewObject != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.NewObjectChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.NewObjectChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add </param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.NewObject == null))
                {
                    this._parent.NewObject = item;
                    return;
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.NewObject = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False </returns>
            /// <param name="item">The item that should be looked out for </param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.NewObject))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied </param>
            /// <param name="arrayIndex">The starting index </param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.NewObject != null))
                {
                    array[arrayIndex] = this._parent.NewObject;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False </returns>
            /// <param name="item">The item that should be removed </param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.NewObject == item))
                {
                    this._parent.NewObject = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator </returns>
            public override IEnumerator <NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty <NMF.Models.IModelElement>().Concat(this._parent.NewObject).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AddToRoot class
        /// </summary>
        public class AddToRootReferencedElementsCollection : ReferenceCollection, ICollectionExpression <NMF.Models.IModelElement>, ICollection <NMF.Models.IModelElement>
        {
            
            private AddToRoot _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AddToRootReferencedElementsCollection(AddToRoot parent)
            {
                this._parent = parent;
            }
            
            /// <summary>
            /// Gets the amount of elements contained in this collection
            /// </summary>
            public override int Count
            {
                get
                {
                    int count = 0;
                    if ((this._parent.NewObject != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.NewObjectChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.NewObjectChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add </param>
            public override void Add(NMF.Models.IModelElement item)
            {
                if ((this._parent.NewObject == null))
                {
                    this._parent.NewObject = item;
                    return;
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.NewObject = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False </returns>
            /// <param name="item">The item that should be looked out for </param>
            public override bool Contains(NMF.Models.IModelElement item)
            {
                if ((item == this._parent.NewObject))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied </param>
            /// <param name="arrayIndex">The starting index </param>
            public override void CopyTo(NMF.Models.IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.NewObject != null))
                {
                    array[arrayIndex] = this._parent.NewObject;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False </returns>
            /// <param name="item">The item that should be removed </param>
            public override bool Remove(NMF.Models.IModelElement item)
            {
                if ((this._parent.NewObject == item))
                {
                    this._parent.NewObject = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator </returns>
            public override IEnumerator <NMF.Models.IModelElement> GetEnumerator()
            {
                return Enumerable.Empty <NMF.Models.IModelElement>().Concat(this._parent.NewObject).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the newObject property
        /// </summary>
        private sealed class NewObjectProxy : ModelPropertyChange <IAddToRoot, NMF.Models.IModelElement>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy </param>
            public NewObjectProxy(IAddToRoot modelElement) : 
                    base(modelElement, "newObject")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override NMF.Models.IModelElement Value
            {
                get
                {
                    return this.ModelElement.NewObject;
                }
                set
                {
                    this.ModelElement.NewObject = value;
                }
            }
        }
    }
}

