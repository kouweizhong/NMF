//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
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

namespace NMFExamples.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The default implementation of the Delay class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/UsageModel/5.0")]
    [XmlNamespacePrefixAttribute("usagemodel")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Delay")]
    [DebuggerDisplayAttribute("Delay {Id}")]
    public partial class Delay : AbstractUserAction, IDelay, IModelElement
    {
        
        private static Lazy<ITypedElement> _timeSpecification_DelayReference = new Lazy<ITypedElement>(RetrieveTimeSpecification_DelayReference);
        
        /// <summary>
        /// The backing field for the TimeSpecification_Delay property
        /// </summary>
        private IPCMRandomVariable _timeSpecification_Delay;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The timeSpecification_Delay property
        /// </summary>
        [XmlElementNameAttribute("timeSpecification_Delay")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("delay_TimeSpecification")]
        public IPCMRandomVariable TimeSpecification_Delay
        {
            get
            {
                return this._timeSpecification_Delay;
            }
            set
            {
                if ((this._timeSpecification_Delay != value))
                {
                    IPCMRandomVariable old = this._timeSpecification_Delay;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTimeSpecification_DelayChanging(e);
                    this.OnPropertyChanging("TimeSpecification_Delay", e, _timeSpecification_DelayReference);
                    this._timeSpecification_Delay = value;
                    if ((old != null))
                    {
                        old.Delay_TimeSpecification = null;
                        old.Parent = null;
                        old.Deleted -= this.OnResetTimeSpecification_Delay;
                    }
                    if ((value != null))
                    {
                        value.Delay_TimeSpecification = this;
                        value.Parent = this;
                        value.Deleted += this.OnResetTimeSpecification_Delay;
                    }
                    this.OnTimeSpecification_DelayChanged(e);
                    this.OnPropertyChanged("TimeSpecification_Delay", e, _timeSpecification_DelayReference);
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
                return base.Children.Concat(new DelayChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new DelayReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Delay")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TimeSpecification_Delay property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> TimeSpecification_DelayChanging;
        
        /// <summary>
        /// Gets fired when the TimeSpecification_Delay property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> TimeSpecification_DelayChanged;
        
        private static ITypedElement RetrieveTimeSpecification_DelayReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Usagemodel.Delay.ClassInstance)).Resolve("timeSpecification_Delay")));
        }
        
        /// <summary>
        /// Raises the TimeSpecification_DelayChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeSpecification_DelayChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.TimeSpecification_DelayChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TimeSpecification_DelayChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTimeSpecification_DelayChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.TimeSpecification_DelayChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TimeSpecification_Delay property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTimeSpecification_Delay(object sender, global::System.EventArgs eventArgs)
        {
            this.TimeSpecification_Delay = null;
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            if ((element == this.TimeSpecification_Delay))
            {
                return ModelHelper.CreatePath("TimeSpecification_Delay");
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
            if ((reference == "TIMESPECIFICATION_DELAY"))
            {
                return this.TimeSpecification_Delay;
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
            if ((feature == "TIMESPECIFICATION_DELAY"))
            {
                this.TimeSpecification_Delay = ((IPCMRandomVariable)(value));
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
            if ((attribute == "TimeSpecification_Delay"))
            {
                return new TimeSpecification_DelayProxy(this);
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
            if ((reference == "TimeSpecification_Delay"))
            {
                return new TimeSpecification_DelayProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//usagemodel/Delay")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Delay class
        /// </summary>
        public class DelayChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Delay _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DelayChildrenCollection(Delay parent)
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
                    if ((this._parent.TimeSpecification_Delay != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TimeSpecification_DelayChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TimeSpecification_DelayChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TimeSpecification_Delay == null))
                {
                    IPCMRandomVariable timeSpecification_DelayCasted = item.As<IPCMRandomVariable>();
                    if ((timeSpecification_DelayCasted != null))
                    {
                        this._parent.TimeSpecification_Delay = timeSpecification_DelayCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TimeSpecification_Delay = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TimeSpecification_Delay))
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
                if ((this._parent.TimeSpecification_Delay != null))
                {
                    array[arrayIndex] = this._parent.TimeSpecification_Delay;
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
                if ((this._parent.TimeSpecification_Delay == item))
                {
                    this._parent.TimeSpecification_Delay = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TimeSpecification_Delay).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Delay class
        /// </summary>
        public class DelayReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Delay _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public DelayReferencedElementsCollection(Delay parent)
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
                    if ((this._parent.TimeSpecification_Delay != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TimeSpecification_DelayChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TimeSpecification_DelayChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TimeSpecification_Delay == null))
                {
                    IPCMRandomVariable timeSpecification_DelayCasted = item.As<IPCMRandomVariable>();
                    if ((timeSpecification_DelayCasted != null))
                    {
                        this._parent.TimeSpecification_Delay = timeSpecification_DelayCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TimeSpecification_Delay = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TimeSpecification_Delay))
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
                if ((this._parent.TimeSpecification_Delay != null))
                {
                    array[arrayIndex] = this._parent.TimeSpecification_Delay;
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
                if ((this._parent.TimeSpecification_Delay == item))
                {
                    this._parent.TimeSpecification_Delay = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TimeSpecification_Delay).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the timeSpecification_Delay property
        /// </summary>
        private sealed class TimeSpecification_DelayProxy : ModelPropertyChange<IDelay, IPCMRandomVariable>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TimeSpecification_DelayProxy(IDelay modelElement) : 
                    base(modelElement, "timeSpecification_Delay")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IPCMRandomVariable Value
            {
                get
                {
                    return this.ModelElement.TimeSpecification_Delay;
                }
                set
                {
                    this.ModelElement.TimeSpecification_Delay = value;
                }
            }
        }
    }
}

