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
    /// The default implementation of the Parenthesis class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0")]
    [XmlNamespacePrefixAttribute("stoex")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//Parenthesis")]
    public partial class Parenthesis : Atom, IParenthesis, IModelElement
    {
        
        private static Lazy<ITypedElement> _innerExpressionReference = new Lazy<ITypedElement>(RetrieveInnerExpressionReference);
        
        /// <summary>
        /// The backing field for the InnerExpression property
        /// </summary>
        private IExpression _innerExpression;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The innerExpression property
        /// </summary>
        [XmlElementNameAttribute("innerExpression")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        public IExpression InnerExpression
        {
            get
            {
                return this._innerExpression;
            }
            set
            {
                if ((this._innerExpression != value))
                {
                    IExpression old = this._innerExpression;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInnerExpressionChanging(e);
                    this.OnPropertyChanging("InnerExpression", e, _innerExpressionReference);
                    this._innerExpression = value;
                    if ((old != null))
                    {
                        old.Parent = null;
                        old.Deleted -= this.OnResetInnerExpression;
                    }
                    if ((value != null))
                    {
                        value.Parent = this;
                        value.Deleted += this.OnResetInnerExpression;
                    }
                    this.OnInnerExpressionChanged(e);
                    this.OnPropertyChanged("InnerExpression", e, _innerExpressionReference);
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
                return base.Children.Concat(new ParenthesisChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ParenthesisReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//Parenthesis")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the InnerExpression property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerExpressionChanging;
        
        /// <summary>
        /// Gets fired when the InnerExpression property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerExpressionChanged;
        
        private static ITypedElement RetrieveInnerExpressionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Stoex.Parenthesis.ClassInstance)).Resolve("innerExpression")));
        }
        
        /// <summary>
        /// Raises the InnerExpressionChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerExpressionChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerExpressionChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InnerExpressionChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerExpressionChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerExpressionChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InnerExpression property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInnerExpression(object sender, global::System.EventArgs eventArgs)
        {
            this.InnerExpression = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.InnerExpression))
            {
                return ModelHelper.CreatePath("InnerExpression");
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
            if ((reference == "INNEREXPRESSION"))
            {
                return this.InnerExpression;
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
            if ((feature == "INNEREXPRESSION"))
            {
                this.InnerExpression = ((IExpression)(value));
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
            if ((attribute == "InnerExpression"))
            {
                return new InnerExpressionProxy(this);
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
            if ((reference == "InnerExpression"))
            {
                return new InnerExpressionProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/StochasticExpressions/1.0#//Parenthesis")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Parenthesis class
        /// </summary>
        public class ParenthesisChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Parenthesis _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ParenthesisChildrenCollection(Parenthesis parent)
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
                    if ((this._parent.InnerExpression != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerExpressionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerExpression == null))
                {
                    IExpression innerExpressionCasted = item.As<IExpression>();
                    if ((innerExpressionCasted != null))
                    {
                        this._parent.InnerExpression = innerExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerExpression))
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
                if ((this._parent.InnerExpression != null))
                {
                    array[arrayIndex] = this._parent.InnerExpression;
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
                if ((this._parent.InnerExpression == item))
                {
                    this._parent.InnerExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Parenthesis class
        /// </summary>
        public class ParenthesisReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Parenthesis _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ParenthesisReferencedElementsCollection(Parenthesis parent)
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
                    if ((this._parent.InnerExpression != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerExpressionChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerExpressionChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerExpression == null))
                {
                    IExpression innerExpressionCasted = item.As<IExpression>();
                    if ((innerExpressionCasted != null))
                    {
                        this._parent.InnerExpression = innerExpressionCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerExpression = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerExpression))
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
                if ((this._parent.InnerExpression != null))
                {
                    array[arrayIndex] = this._parent.InnerExpression;
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
                if ((this._parent.InnerExpression == item))
                {
                    this._parent.InnerExpression = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerExpression).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the innerExpression property
        /// </summary>
        private sealed class InnerExpressionProxy : ModelPropertyChange<IParenthesis, IExpression>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InnerExpressionProxy(IParenthesis modelElement) : 
                    base(modelElement, "innerExpression")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IExpression Value
            {
                get
                {
                    return this.ModelElement.InnerExpression;
                }
                set
                {
                    this.ModelElement.InnerExpression = value;
                }
            }
        }
    }
}

