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
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Protocol;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Resourcetype;
using NMFExamples.Pcm.Seff;
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
using System.Globalization;
using System.Linq;

namespace NMFExamples.Pcm.Repository
{
    
    
    /// <summary>
    /// The default implementation of the EventGroup class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/EventGroup")]
    [DebuggerDisplayAttribute("EventGroup {Id}")]
    public partial class EventGroup : Interface, IEventGroup, IModelElement
    {
        
        private static Lazy<ITypedElement> _eventTypes__EventGroupReference = new Lazy<ITypedElement>(RetrieveEventTypes__EventGroupReference);
        
        /// <summary>
        /// The backing field for the EventTypes__EventGroup property
        /// </summary>
        private EventGroupEventTypes__EventGroupCollection _eventTypes__EventGroup;
        
        private static IClass _classInstance;
        
        public EventGroup()
        {
            this._eventTypes__EventGroup = new EventGroupEventTypes__EventGroupCollection(this);
            this._eventTypes__EventGroup.CollectionChanging += this.EventTypes__EventGroupCollectionChanging;
            this._eventTypes__EventGroup.CollectionChanged += this.EventTypes__EventGroupCollectionChanged;
        }
        
        /// <summary>
        /// The eventTypes__EventGroup property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("eventTypes__EventGroup")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("eventGroup__EventType")]
        [ConstantAttribute()]
        public IListExpression<IEventType> EventTypes__EventGroup
        {
            get
            {
                return this._eventTypes__EventGroup;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new EventGroupChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new EventGroupReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/EventGroup")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveEventTypes__EventGroupReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.EventGroup.ClassInstance)).Resolve("eventTypes__EventGroup")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the EventTypes__EventGroup property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventTypes__EventGroupCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("EventTypes__EventGroup", e, _eventTypes__EventGroupReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the EventTypes__EventGroup property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void EventTypes__EventGroupCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("EventTypes__EventGroup", e, _eventTypes__EventGroupReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int eventTypes__EventGroupIndex = ModelHelper.IndexOfReference(this.EventTypes__EventGroup, element);
            if ((eventTypes__EventGroupIndex != -1))
            {
                return ModelHelper.CreatePath("eventTypes__EventGroup", eventTypes__EventGroupIndex);
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
            if ((reference == "EVENTTYPES__EVENTGROUP"))
            {
                if ((index < this.EventTypes__EventGroup.Count))
                {
                    return this.EventTypes__EventGroup[index];
                }
                else
                {
                    return null;
                }
            }
            return base.GetModelElementForReference(reference, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "EVENTTYPES__EVENTGROUP"))
            {
                return this._eventTypes__EventGroup;
            }
            return base.GetCollectionForFeature(feature);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._eventTypes__EventGroup))
            {
                return "eventTypes__EventGroup";
            }
            return base.GetCompositionName(container);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/EventGroup")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventGroup class
        /// </summary>
        public class EventGroupChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventGroup _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventGroupChildrenCollection(EventGroup parent)
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
                    count = (count + this._parent.EventTypes__EventGroup.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EventTypes__EventGroup.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EventTypes__EventGroup.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEventType eventTypes__EventGroupCasted = item.As<IEventType>();
                if ((eventTypes__EventGroupCasted != null))
                {
                    this._parent.EventTypes__EventGroup.Add(eventTypes__EventGroupCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EventTypes__EventGroup.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EventTypes__EventGroup.Contains(item))
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
                IEnumerator<IModelElement> eventTypes__EventGroupEnumerator = this._parent.EventTypes__EventGroup.GetEnumerator();
                try
                {
                    for (
                    ; eventTypes__EventGroupEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eventTypes__EventGroupEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eventTypes__EventGroupEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEventType eventTypeItem = item.As<IEventType>();
                if (((eventTypeItem != null) 
                            && this._parent.EventTypes__EventGroup.Remove(eventTypeItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EventTypes__EventGroup).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the EventGroup class
        /// </summary>
        public class EventGroupReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private EventGroup _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public EventGroupReferencedElementsCollection(EventGroup parent)
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
                    count = (count + this._parent.EventTypes__EventGroup.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.EventTypes__EventGroup.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.EventTypes__EventGroup.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IEventType eventTypes__EventGroupCasted = item.As<IEventType>();
                if ((eventTypes__EventGroupCasted != null))
                {
                    this._parent.EventTypes__EventGroup.Add(eventTypes__EventGroupCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.EventTypes__EventGroup.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.EventTypes__EventGroup.Contains(item))
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
                IEnumerator<IModelElement> eventTypes__EventGroupEnumerator = this._parent.EventTypes__EventGroup.GetEnumerator();
                try
                {
                    for (
                    ; eventTypes__EventGroupEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = eventTypes__EventGroupEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    eventTypes__EventGroupEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IEventType eventTypeItem = item.As<IEventType>();
                if (((eventTypeItem != null) 
                            && this._parent.EventTypes__EventGroup.Remove(eventTypeItem)))
                {
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.EventTypes__EventGroup).GetEnumerator();
            }
        }
    }
}

