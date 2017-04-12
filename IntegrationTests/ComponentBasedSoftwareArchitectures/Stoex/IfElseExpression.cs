//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Probfunction;
using NMFExamples.Units;
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
using global::System.Collections;
using global::System.Collections.Generic;
using global::System.Collections.ObjectModel;
using global::System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.Stoex
{
    
    
    /// <summary>
    /// The default implementation of the IfElseExpression class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0")]
    [XmlNamespacePrefixAttribute("stoex")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//IfElseExpression")]
    public partial class IfElseExpression : IfElse, IIfElseExpression, IModelElement
    {
        
        private static Lazy<ITypedElement> _ifExpressionReference = new Lazy<ITypedElement>(RetrieveIfExpressionReference);
        
        /// <summary>
        /// The backing field for the IfExpression property
        /// </summary>
        private IBooleanExpression _ifExpression;
        
        private static Lazy<ITypedElement> _elseExpressionReference = new Lazy<ITypedElement>(RetrieveElseExpressionReference);
        
        /// <summary>
        /// The backing field for the ElseExpression property
        /// </summary>
        private IBooleanExpression _elseExpression;
        
        private static Lazy<ITypedElement> _conditionExpressionReference = new Lazy<ITypedElement>(RetrieveConditionExpressionReference);
        
        /// <summary>
        /// The backing field for the ConditionExpression property
        /// </summary>
        private IBooleanExpression _conditionExpression;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The ifExpression property
        /// </summary>
        [XmlElementNameAttribute("ifExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IBooleanExpression IfExpression
        {
            get
            {
                return this._ifExpression;
            }
            set
            {
                if ((this._ifExpression != value))
                {
                    IBooleanExpression old = this._ifExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnIfExpressionChanging(e);
                    this.OnPropertyChanging("IfExpression", e, _ifExpressionReference);
                    this._ifExpression = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.Deleted -= this.OnResetIfExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.Deleted += this.OnResetIfExpression;
                    }
                    this.OnIfExpressionChanged(e);
                    this.OnPropertyChanged("IfExpression", e, _ifExpressionReference);
                }
            }
        }
        
        /// <summary>
        /// The elseExpression property
        /// </summary>
        [XmlElementNameAttribute("elseExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IBooleanExpression ElseExpression
        {
            get
            {
                return this._elseExpression;
            }
            set
            {
                if ((this._elseExpression != value))
                {
                    IBooleanExpression old = this._elseExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnElseExpressionChanging(e);
                    this.OnPropertyChanging("ElseExpression", e, _elseExpressionReference);
                    this._elseExpression = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.Deleted -= this.OnResetElseExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.Deleted += this.OnResetElseExpression;
                    }
                    this.OnElseExpressionChanged(e);
                    this.OnPropertyChanged("ElseExpression", e, _elseExpressionReference);
                }
            }
        }
        
        /// <summary>
        /// The conditionExpression property
        /// </summary>
        [XmlElementNameAttribute("conditionExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IBooleanExpression ConditionExpression
        {
            get
            {
                return this._conditionExpression;
            }
            set
            {
                if ((this._conditionExpression != value))
                {
                    IBooleanExpression old = this._conditionExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnConditionExpressionChanging(e);
                    this.OnPropertyChanging("ConditionExpression", e, _conditionExpressionReference);
                    this._conditionExpression = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.Deleted -= this.OnResetConditionExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.Deleted += this.OnResetConditionExpression;
                    }
                    this.OnConditionExpressionChanged(e);
                    this.OnPropertyChanged("ConditionExpression", e, _conditionExpressionReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new IfElseExpressionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new IfElseExpressionReferencedElementsCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//IfElseExpression")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the IfExpression property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> IfExpressionChanging;
        
        /// <summary>
        /// Gets fired when the IfExpression property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> IfExpressionChanged;
        
        /// <summary>
        /// Gets fired before the ElseExpression property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ElseExpressionChanging;
        
        /// <summary>
        /// Gets fired when the ElseExpression property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ElseExpressionChanged;
        
        /// <summary>
        /// Gets fired before the ConditionExpression property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ConditionExpressionChanging;
        
        /// <summary>
        /// Gets fired when the ConditionExpression property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ConditionExpressionChanged;
        
        private static ITypedElement RetrieveIfExpressionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Stoex.IfElseExpression.ClassInstance)).Resolve("ifExpression")));
        }
        
        /// <summary>
        /// Raises the IfExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIfExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.IfExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the IfExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnIfExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.IfExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the IfExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetIfExpression(object sender, global::System.EventArgs eventArgs)
        {
            this.IfExpression = null;
        }
        
        private static ITypedElement RetrieveElseExpressionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Stoex.IfElseExpression.ClassInstance)).Resolve("elseExpression")));
        }
        
        /// <summary>
        /// Raises the ElseExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElseExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ElseExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ElseExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnElseExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ElseExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ElseExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetElseExpression(object sender, global::System.EventArgs eventArgs)
        {
            this.ElseExpression = null;
        }
        
        private static ITypedElement RetrieveConditionExpressionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Stoex.IfElseExpression.ClassInstance)).Resolve("conditionExpression")));
        }
        
        /// <summary>
        /// Raises the ConditionExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConditionExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ConditionExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ConditionExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnConditionExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ConditionExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the ConditionExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetConditionExpression(object sender, global::System.EventArgs eventArgs)
        {
            this.ConditionExpression = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.IfExpression))
            {
                return ModelHelper.CreatePath("IfExpression");
            }
            if ((element == this.ElseExpression))
            {
                return ModelHelper.CreatePath("ElseExpression");
            }
            if ((element == this.ConditionExpression))
            {
                return ModelHelper.CreatePath("ConditionExpression");
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
            if ((reference == "IFEXPRESSION"))
            {
                return this.IfExpression;
            }
            if ((reference == "ELSEEXPRESSION"))
            {
                return this.ElseExpression;
            }
            if ((reference == "CONDITIONEXPRESSION"))
            {
                return this.ConditionExpression;
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "IFEXPRESSION"))
            {
                this.IfExpression = ((IBooleanExpression)(value));
                return;
            }
            if ((feature == "ELSEEXPRESSION"))
            {
                this.ElseExpression = ((IBooleanExpression)(value));
                return;
            }
            if ((feature == "CONDITIONEXPRESSION"))
            {
                this.ConditionExpression = ((IBooleanExpression)(value));
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
            if ((attribute == "IfExpression"))
            {
                return new IfExpressionProxy(this);
            }
            if ((attribute == "ElseExpression"))
            {
                return new ElseExpressionProxy(this);
            }
            if ((attribute == "ConditionExpression"))
            {
                return new ConditionExpressionProxy(this);
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
            if ((reference == "IfExpression"))
            {
                return new IfExpressionProxy(this);
            }
            if ((reference == "ElseExpression"))
            {
                return new ElseExpressionProxy(this);
            }
            if ((reference == "ConditionExpression"))
            {
                return new ConditionExpressionProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//IfElseExpression")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the IfElseExpression class
        /// </summary>
        public class IfElseExpressionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private IfElseExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public IfElseExpressionChildrenCollection(IfElseExpression parent)
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
                    if ((this._parent.IfExpression != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ElseExpression != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ConditionExpression != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.IfExpressionChanged += this.PropagateValueChanges;
                this._parent.ElseExpressionChanged += this.PropagateValueChanges;
                this._parent.ConditionExpressionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.IfExpressionChanged -= this.PropagateValueChanges;
                this._parent.ElseExpressionChanged -= this.PropagateValueChanges;
                this._parent.ConditionExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.IfExpression == null))
                {
                    IBooleanExpression ifExpressionCasted = item.As<IBooleanExpression>();
                    if ((ifExpressionCasted != null))
                    {
                        this._parent.IfExpression = ifExpressionCasted;
                        return;
                    }
                }
                if ((this._parent.ElseExpression == null))
                {
                    IBooleanExpression elseExpressionCasted = item.As<IBooleanExpression>();
                    if ((elseExpressionCasted != null))
                    {
                        this._parent.ElseExpression = elseExpressionCasted;
                        return;
                    }
                }
                if ((this._parent.ConditionExpression == null))
                {
                    IBooleanExpression conditionExpressionCasted = item.As<IBooleanExpression>();
                    if ((conditionExpressionCasted != null))
                    {
                        this._parent.ConditionExpression = conditionExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.IfExpression = null;
                this._parent.ElseExpression = null;
                this._parent.ConditionExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.IfExpression))
                {
                    return true;
                }
                if ((item == this._parent.ElseExpression))
                {
                    return true;
                }
                if ((item == this._parent.ConditionExpression))
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
                if ((this._parent.IfExpression != null))
                {
                    array[arrayIndex] = this._parent.IfExpression;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ElseExpression != null))
                {
                    array[arrayIndex] = this._parent.ElseExpression;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ConditionExpression != null))
                {
                    array[arrayIndex] = this._parent.ConditionExpression;
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
                if ((this._parent.IfExpression == item))
                {
                    this._parent.IfExpression = null;
                    return true;
                }
                if ((this._parent.ElseExpression == item))
                {
                    this._parent.ElseExpression = null;
                    return true;
                }
                if ((this._parent.ConditionExpression == item))
                {
                    this._parent.ConditionExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.IfExpression).Concat(this._parent.ElseExpression).Concat(this._parent.ConditionExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the IfElseExpression class
        /// </summary>
        public class IfElseExpressionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private IfElseExpression _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public IfElseExpressionReferencedElementsCollection(IfElseExpression parent)
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
                    if ((this._parent.IfExpression != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ElseExpression != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.ConditionExpression != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.IfExpressionChanged += this.PropagateValueChanges;
                this._parent.ElseExpressionChanged += this.PropagateValueChanges;
                this._parent.ConditionExpressionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.IfExpressionChanged -= this.PropagateValueChanges;
                this._parent.ElseExpressionChanged -= this.PropagateValueChanges;
                this._parent.ConditionExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.IfExpression == null))
                {
                    IBooleanExpression ifExpressionCasted = item.As<IBooleanExpression>();
                    if ((ifExpressionCasted != null))
                    {
                        this._parent.IfExpression = ifExpressionCasted;
                        return;
                    }
                }
                if ((this._parent.ElseExpression == null))
                {
                    IBooleanExpression elseExpressionCasted = item.As<IBooleanExpression>();
                    if ((elseExpressionCasted != null))
                    {
                        this._parent.ElseExpression = elseExpressionCasted;
                        return;
                    }
                }
                if ((this._parent.ConditionExpression == null))
                {
                    IBooleanExpression conditionExpressionCasted = item.As<IBooleanExpression>();
                    if ((conditionExpressionCasted != null))
                    {
                        this._parent.ConditionExpression = conditionExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.IfExpression = null;
                this._parent.ElseExpression = null;
                this._parent.ConditionExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.IfExpression))
                {
                    return true;
                }
                if ((item == this._parent.ElseExpression))
                {
                    return true;
                }
                if ((item == this._parent.ConditionExpression))
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
                if ((this._parent.IfExpression != null))
                {
                    array[arrayIndex] = this._parent.IfExpression;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ElseExpression != null))
                {
                    array[arrayIndex] = this._parent.ElseExpression;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.ConditionExpression != null))
                {
                    array[arrayIndex] = this._parent.ConditionExpression;
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
                if ((this._parent.IfExpression == item))
                {
                    this._parent.IfExpression = null;
                    return true;
                }
                if ((this._parent.ElseExpression == item))
                {
                    this._parent.ElseExpression = null;
                    return true;
                }
                if ((this._parent.ConditionExpression == item))
                {
                    this._parent.ConditionExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.IfExpression).Concat(this._parent.ElseExpression).Concat(this._parent.ConditionExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the ifExpression property
        /// </summary>
        private sealed class IfExpressionProxy : ModelPropertyChange<IIfElseExpression, IBooleanExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public IfExpressionProxy(IIfElseExpression modelElement) : 
                    base(modelElement, "ifExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBooleanExpression Value
            {
                get
                {
                    return this.ModelElement.IfExpression;
                }
                set
                {
                    this.ModelElement.IfExpression = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the elseExpression property
        /// </summary>
        private sealed class ElseExpressionProxy : ModelPropertyChange<IIfElseExpression, IBooleanExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ElseExpressionProxy(IIfElseExpression modelElement) : 
                    base(modelElement, "elseExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBooleanExpression Value
            {
                get
                {
                    return this.ModelElement.ElseExpression;
                }
                set
                {
                    this.ModelElement.ElseExpression = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the conditionExpression property
        /// </summary>
        private sealed class ConditionExpressionProxy : ModelPropertyChange<IIfElseExpression, IBooleanExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ConditionExpressionProxy(IIfElseExpression modelElement) : 
                    base(modelElement, "conditionExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IBooleanExpression Value
            {
                get
                {
                    return this.ModelElement.ConditionExpression;
                }
                set
                {
                    this.ModelElement.ConditionExpression = value;
                }
            }
        }
    }
}

