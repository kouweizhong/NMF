//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMF.Models.Meta
{
    
    
    /// <summary>
    /// The default implementation of the AttributeConstraint class
    /// </summary>
    [XmlNamespaceAttribute("http://nmf.codeplex.com/nmeta/")]
    [XmlNamespacePrefixAttribute("nmeta")]
    [ModelRepresentationClassAttribute("http://nmf.codeplex.com/nmeta/#//AttributeConstraint/")]
    public class AttributeConstraint : ModelElement, IAttributeConstraint, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Values property
        /// </summary>
        private ObservableList<string> _values;
        
        /// <summary>
        /// The backing field for the Constrains property
        /// </summary>
        private IAttribute _constrains;
        
        public AttributeConstraint()
        {
            this._values = new ObservableList<string>();
        }
        
        /// <summary>
        /// The Values property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public virtual IListExpression<string> Values
        {
            get
            {
                return this._values;
            }
        }
        
        /// <summary>
        /// The DeclaringType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("AttributeConstraints")]
        public virtual IClass DeclaringType
        {
            get
            {
                return ModelHelper.CastAs<IClass>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// The Constrains property
        /// </summary>
        [XmlAttributeAttribute(true)]
        public virtual IAttribute Constrains
        {
            get
            {
                return this._constrains;
            }
            set
            {
                if ((this._constrains != value))
                {
                    IAttribute old = this._constrains;
                    this._constrains = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetConstrains;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetConstrains;
                    }
                    this.OnPropertyChanged("Constrains");
                    this.OnConstrainsChanged(new ValueChangedEventArgs(old, value));
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AttributeConstraintReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of this type
        /// </summary>
        public new static NMF.Models.Meta.IClass ClassInstance
        {
            get
            {
                return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://nmf.codeplex.com/nmeta/#//AttributeConstraint/");
            }
        }
        
        /// <summary>
        /// Gets fired when the DeclaringType property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> DeclaringTypeChanged;
        
        /// <summary>
        /// Gets fired when the Constrains property changed its value
        /// </summary>
        public event EventHandler<ValueChangedEventArgs> ConstrainsChanged;
        
        /// <summary>
        /// Raises the DeclaringTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnDeclaringTypeChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.DeclaringTypeChanged;
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
            IClass oldDeclaringType = ModelHelper.CastAs<IClass>(oldParent);
            IClass newDeclaringType = ModelHelper.CastAs<IClass>(newParent);
            if ((oldDeclaringType != null))
            {
                oldDeclaringType.AttributeConstraints.Remove(this);
            }
            if ((newDeclaringType != null))
            {
                newDeclaringType.AttributeConstraints.Add(this);
            }
            this.OnPropertyChanged("DeclaringType");
            this.OnDeclaringTypeChanged(new ValueChangedEventArgs(oldDeclaringType, newDeclaringType));
        }
        
        /// <summary>
        /// Raises the ConstrainsChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConstrainsChanged(ValueChangedEventArgs eventArgs)
        {
            EventHandler<ValueChangedEventArgs> handler = this.ConstrainsChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Constrains property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConstrains(object sender, EventArgs eventArgs)
        {
            this.Constrains = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.DeclaringType))
            {
                return ModelHelper.CreatePath("DeclaringType");
            }
            if ((element == this.Constrains))
            {
                return ModelHelper.CreatePath("Constrains");
            }
            return base.GetRelativePathForNonIdentifiedChild(element);
        }
        
        /// <summary>
        /// Resolves the given URI to a child model element
        /// </summary>
        /// <returns>The model element or null if it could not be found</returns>
        /// <param name="reference">The requested reference name</param>
        /// <param name="index">The index of this reference</param>
        protected override IModelElement GetModelElementForReference(string reference, int index)
        {
            if ((reference == "DECLARINGTYPE"))
            {
                return this.DeclaringType;
            }
            if ((reference == "CONSTRAINS"))
            {
                return this.Constrains;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Class element that describes the structure of the current model element
        /// </summary>
        public override NMF.Models.Meta.IClass GetClass()
        {
            return NMF.Models.Repository.MetaRepository.Instance.ResolveClass("http://nmf.codeplex.com/nmeta/#//AttributeConstraint/");
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "VALUES"))
            {
                if ((index < this.Values.Count))
                {
                    return this.Values[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "VALUES"))
            {
                return this._values;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "DECLARINGTYPE"))
            {
                this.DeclaringType = ((IClass)(value));
                return;
            }
            if ((feature == "CONSTRAINS"))
            {
                this.Constrains = ((IAttribute)(value));
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
            if ((attribute == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
            }
            if ((attribute == "CONSTRAINS"))
            {
                return new ConstrainsProxy(this);
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
            if ((reference == "DECLARINGTYPE"))
            {
                return new DeclaringTypeProxy(this);
            }
            if ((reference == "CONSTRAINS"))
            {
                return new ConstrainsProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AttributeConstraint class
        /// </summary>
        public class AttributeConstraintReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AttributeConstraint _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AttributeConstraintReferencedElementsCollection(AttributeConstraint parent)
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
                    if ((this._parent.DeclaringType != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Constrains != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.DeclaringTypeChanged += this.PropagateValueChanges;
                this._parent.ConstrainsChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.DeclaringTypeChanged -= this.PropagateValueChanges;
                this._parent.ConstrainsChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.DeclaringType == null))
                {
                    IClass declaringTypeCasted = item.As<IClass>();
                    if ((declaringTypeCasted != null))
                    {
                        this._parent.DeclaringType = declaringTypeCasted;
                        return;
                    }
                }
                if ((this._parent.Constrains == null))
                {
                    IAttribute constrainsCasted = item.As<IAttribute>();
                    if ((constrainsCasted != null))
                    {
                        this._parent.Constrains = constrainsCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.DeclaringType = null;
                this._parent.Constrains = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.DeclaringType))
                {
                    return true;
                }
                if ((item == this._parent.Constrains))
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
                if ((this._parent.DeclaringType != null))
                {
                    array[arrayIndex] = this._parent.DeclaringType;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Constrains != null))
                {
                    array[arrayIndex] = this._parent.Constrains;
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
                if ((this._parent.DeclaringType == item))
                {
                    this._parent.DeclaringType = null;
                    return true;
                }
                if ((this._parent.Constrains == item))
                {
                    this._parent.Constrains = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.DeclaringType).Concat(this._parent.Constrains).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the DeclaringType property
        /// </summary>
        private sealed class DeclaringTypeProxy : ModelPropertyChange<IAttributeConstraint, IClass>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public DeclaringTypeProxy(IAttributeConstraint modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IClass Value
            {
                get
                {
                    return this.ModelElement.DeclaringType;
                }
                set
                {
                    this.ModelElement.DeclaringType = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.DeclaringTypeChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.DeclaringTypeChanged -= handler;
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the Constrains property
        /// </summary>
        private sealed class ConstrainsProxy : ModelPropertyChange<IAttributeConstraint, IAttribute>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConstrainsProxy(IAttributeConstraint modelElement) : 
                    base(modelElement)
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAttribute Value
            {
                get
                {
                    return this.ModelElement.Constrains;
                }
                set
                {
                    this.ModelElement.Constrains = value;
                }
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be subscribed to the property change event</param>
            protected override void RegisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConstrainsChanged += handler;
            }
            
            /// <summary>
            /// Registers an event handler to subscribe specifically on the changed event for this property
            /// </summary>
            /// <param name="handler">The handler that should be unsubscribed from the property change event</param>
            protected override void UnregisterChangeEventHandler(System.EventHandler<NMF.Expressions.ValueChangedEventArgs> handler)
            {
                this.ModelElement.ConstrainsChanged -= handler;
            }
        }
    }
}

