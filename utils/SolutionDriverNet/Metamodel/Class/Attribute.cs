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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace HSRM.TTC2023.ClassToRelational.Class_
{
    
    
    /// <summary>
    /// The default implementation of the Attribute class
    /// </summary>
    [XmlNamespaceAttribute("Class")]
    [XmlNamespacePrefixAttribute("class_")]
    [ModelRepresentationClassAttribute("https://github.com/ATL-Research/incremental-class2relational/Class.nmeta#//Attrib" +
        "ute")]
    [DebuggerDisplayAttribute("Attribute {Name}")]
    public partial class Attribute : NamedElt, HSRM.TTC2023.ClassToRelational.Class_.IAttribute, IModelElement
    {
        
        /// <summary>
        /// The backing field for the MultiValued property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private bool _multiValued = false;
        
        private static Lazy<ITypedElement> _multiValuedAttribute = new Lazy<ITypedElement>(RetrieveMultiValuedAttribute);
        
        private static Lazy<ITypedElement> _typeReference = new Lazy<ITypedElement>(RetrieveTypeReference);
        
        /// <summary>
        /// The backing field for the Type property
        /// </summary>
        [DebuggerBrowsableAttribute(DebuggerBrowsableState.Never)]
        private IClassifier _type;
        
        private static Lazy<ITypedElement> _ownerReference = new Lazy<ITypedElement>(RetrieveOwnerReference);
        
        private static NMF.Models.Meta.IClass _classInstance;
        
        /// <summary>
        /// The multiValued property
        /// </summary>
        [DefaultValueAttribute(false)]
        [TypeConverterAttribute(typeof(LowercaseBooleanConverter))]
        [DisplayNameAttribute("multiValued")]
        [CategoryAttribute("Attribute")]
        [XmlElementNameAttribute("multiValued")]
        [XmlAttributeAttribute(true)]
        public bool MultiValued
        {
            get
            {
                return this._multiValued;
            }
            set
            {
                if ((this._multiValued != value))
                {
                    bool old = this._multiValued;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnMultiValuedChanging(e);
                    this.OnPropertyChanging("MultiValued", e, _multiValuedAttribute);
                    this._multiValued = value;
                    this.OnMultiValuedChanged(e);
                    this.OnPropertyChanged("MultiValued", e, _multiValuedAttribute);
                }
            }
        }
        
        /// <summary>
        /// The type property
        /// </summary>
        [DisplayNameAttribute("type")]
        [CategoryAttribute("Attribute")]
        [XmlElementNameAttribute("type")]
        [XmlAttributeAttribute(true)]
        public IClassifier Type
        {
            get
            {
                return this._type;
            }
            set
            {
                if ((this._type != value))
                {
                    IClassifier old = this._type;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTypeChanging(e);
                    this.OnPropertyChanging("Type", e, _typeReference);
                    this._type = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetType;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetType;
                    }
                    this.OnTypeChanged(e);
                    this.OnPropertyChanged("Type", e, _typeReference);
                }
            }
        }
        
        /// <summary>
        /// The owner property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("owner")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("attr")]
        public HSRM.TTC2023.ClassToRelational.Class_.IClass Owner
        {
            get
            {
                return ModelHelper.CastAs<HSRM.TTC2023.ClassToRelational.Class_.IClass>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AttributeReferencedElementsCollection(this));
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
                    _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://github.com/ATL-Research/incremental-class2relational/Class.nmeta#//Attrib" +
                            "ute")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the MultiValued property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MultiValuedChanging;
        
        /// <summary>
        /// Gets fired when the MultiValued property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> MultiValuedChanged;
        
        /// <summary>
        /// Gets fired before the Type property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanging;
        
        /// <summary>
        /// Gets fired when the Type property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> TypeChanged;
        
        /// <summary>
        /// Gets fired before the Owner property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerChanging;
        
        /// <summary>
        /// Gets fired when the Owner property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> OwnerChanged;
        
        private static ITypedElement RetrieveMultiValuedAttribute()
        {
            return ((ITypedElement)(((ModelElement)(HSRM.TTC2023.ClassToRelational.Class_.Attribute.ClassInstance)).Resolve("multiValued")));
        }
        
        /// <summary>
        /// Raises the MultiValuedChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMultiValuedChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MultiValuedChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the MultiValuedChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnMultiValuedChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.MultiValuedChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(HSRM.TTC2023.ClassToRelational.Class_.Attribute.ClassInstance)).Resolve("type")));
        }
        
        /// <summary>
        /// Raises the TypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTypeChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.TypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Type property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetType(object sender, System.EventArgs eventArgs)
        {
            this.Type = null;
        }
        
        private static ITypedElement RetrieveOwnerReference()
        {
            return ((ITypedElement)(((ModelElement)(HSRM.TTC2023.ClassToRelational.Class_.Attribute.ClassInstance)).Resolve("owner")));
        }
        
        /// <summary>
        /// Raises the OwnerChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            HSRM.TTC2023.ClassToRelational.Class_.IClass oldOwner = ModelHelper.CastAs<HSRM.TTC2023.ClassToRelational.Class_.IClass>(oldParent);
            HSRM.TTC2023.ClassToRelational.Class_.IClass newOwner = ModelHelper.CastAs<HSRM.TTC2023.ClassToRelational.Class_.IClass>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldOwner, newOwner);
            this.OnOwnerChanging(e);
            this.OnPropertyChanging("Owner", e, _ownerReference);
        }
        
        /// <summary>
        /// Raises the OwnerChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOwnerChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.OwnerChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element changes
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanged(IModelElement newParent, IModelElement oldParent)
        {
            HSRM.TTC2023.ClassToRelational.Class_.IClass oldOwner = ModelHelper.CastAs<HSRM.TTC2023.ClassToRelational.Class_.IClass>(oldParent);
            HSRM.TTC2023.ClassToRelational.Class_.IClass newOwner = ModelHelper.CastAs<HSRM.TTC2023.ClassToRelational.Class_.IClass>(newParent);
            if ((oldOwner != null))
            {
                oldOwner.Attr.Remove(this);
            }
            if ((newOwner != null))
            {
                newOwner.Attr.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldOwner, newOwner);
            this.OnOwnerChanged(e);
            this.OnPropertyChanged("Owner", e, _ownerReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "TYPE"))
            {
                return this.Type;
            }
            if ((reference == "OWNER"))
            {
                return this.Owner;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "MULTIVALUED"))
            {
                return this.MultiValued;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "TYPE"))
            {
                this.Type = ((IClassifier)(value));
                return;
            }
            if ((feature == "OWNER"))
            {
                this.Owner = ((HSRM.TTC2023.ClassToRelational.Class_.IClass)(value));
                return;
            }
            if ((feature == "MULTIVALUED"))
            {
                this.MultiValued = ((bool)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "MULTIVALUED"))
            {
                return Observable.Box(new MultiValuedProxy(this));
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the property expression for the given reference
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="reference">The requested reference in upper case</param>
        protected override NMF.Expressions.INotifyExpression<NMF.Models.IModelElement> GetExpressionForReference(string reference)
        {
            if ((reference == "TYPE"))
            {
                return new TypeProxy(this);
            }
            if ((reference == "OWNER"))
            {
                return new OwnerProxy(this);
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
                _classInstance = ((NMF.Models.Meta.IClass)(MetaRepository.Instance.Resolve("https://github.com/ATL-Research/incremental-class2relational/Class.nmeta#//Attrib" +
                        "ute")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Attribute class
        /// </summary>
        public class AttributeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Attribute _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AttributeReferencedElementsCollection(Attribute parent)
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
                    if ((this._parent.Type != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Owner != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TypeChanged += this.PropagateValueChanges;
                this._parent.OwnerChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TypeChanged -= this.PropagateValueChanges;
                this._parent.OwnerChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Type == null))
                {
                    IClassifier typeCasted = item.As<IClassifier>();
                    if ((typeCasted != null))
                    {
                        this._parent.Type = typeCasted;
                        return;
                    }
                }
                if ((this._parent.Owner == null))
                {
                    HSRM.TTC2023.ClassToRelational.Class_.IClass ownerCasted = item.As<HSRM.TTC2023.ClassToRelational.Class_.IClass>();
                    if ((ownerCasted != null))
                    {
                        this._parent.Owner = ownerCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Type = null;
                this._parent.Owner = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Type))
                {
                    return true;
                }
                if ((item == this._parent.Owner))
                {
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Copies the contents of the collection to the given array starting from the given array index
            /// </summary>
            /// <param name="array">The array in which the elements should be copied</param>
            /// <param name="arrayIndex">The starting index</param>
            public override void CopyTo(IModelElement[] array, int arrayIndex)
            {
                if ((this._parent.Type != null))
                {
                    array[arrayIndex] = this._parent.Type;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Owner != null))
                {
                    array[arrayIndex] = this._parent.Owner;
                    arrayIndex = (arrayIndex + 1);
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.Type == item))
                {
                    this._parent.Type = null;
                    return true;
                }
                if ((this._parent.Owner == item))
                {
                    this._parent.Owner = null;
                    return true;
                }
                return false;
            }
            
            /// <summary>
            /// Gets an enumerator that enumerates the collection
            /// </summary>
            /// <returns>A generic enumerator</returns>
            public override IEnumerator<IModelElement> GetEnumerator()
            {
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Type).Concat(this._parent.Owner).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the multiValued property
        /// </summary>
        private sealed class MultiValuedProxy : ModelPropertyChange<HSRM.TTC2023.ClassToRelational.Class_.IAttribute, bool>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public MultiValuedProxy(HSRM.TTC2023.ClassToRelational.Class_.IAttribute modelElement) : 
                    base(modelElement, "multiValued")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override bool Value
            {
                get
                {
                    return this.ModelElement.MultiValued;
                }
                set
                {
                    this.ModelElement.MultiValued = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the type property
        /// </summary>
        private sealed class TypeProxy : ModelPropertyChange<HSRM.TTC2023.ClassToRelational.Class_.IAttribute, IClassifier>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TypeProxy(HSRM.TTC2023.ClassToRelational.Class_.IAttribute modelElement) : 
                    base(modelElement, "type")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IClassifier Value
            {
                get
                {
                    return this.ModelElement.Type;
                }
                set
                {
                    this.ModelElement.Type = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the owner property
        /// </summary>
        private sealed class OwnerProxy : ModelPropertyChange<HSRM.TTC2023.ClassToRelational.Class_.IAttribute, HSRM.TTC2023.ClassToRelational.Class_.IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OwnerProxy(HSRM.TTC2023.ClassToRelational.Class_.IAttribute modelElement) : 
                    base(modelElement, "owner")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override HSRM.TTC2023.ClassToRelational.Class_.IClass Value
            {
                get
                {
                    return this.ModelElement.Owner;
                }
                set
                {
                    this.ModelElement.Owner = value;
                }
            }
        }
    }
}
