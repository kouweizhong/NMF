//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Resourceenvironment;
using NMFExamples.Pcm.System;
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

namespace NMFExamples.Pcm.Allocation
{
    
    
    /// <summary>
    /// The default implementation of the Allocation class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Allocation/5.0")]
    [XmlNamespacePrefixAttribute("allocation")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//allocation/Allocation")]
    [DebuggerDisplayAttribute("Allocation {Id}")]
    public partial class Allocation : NMFExamples.Pcm.Core.Entity.Entity, IAllocation, IModelElement
    {
        
        private static Lazy<ITypedElement> _targetResourceEnvironment_AllocationReference = new Lazy<ITypedElement>(RetrieveTargetResourceEnvironment_AllocationReference);
        
        /// <summary>
        /// The backing field for the TargetResourceEnvironment_Allocation property
        /// </summary>
        private IResourceEnvironment _targetResourceEnvironment_Allocation;
        
        private static Lazy<ITypedElement> _system_AllocationReference = new Lazy<ITypedElement>(RetrieveSystem_AllocationReference);
        
        /// <summary>
        /// The backing field for the System_Allocation property
        /// </summary>
        private ISystem0 _system_Allocation;
        
        private static Lazy<ITypedElement> _allocationContexts_AllocationReference = new Lazy<ITypedElement>(RetrieveAllocationContexts_AllocationReference);
        
        /// <summary>
        /// The backing field for the AllocationContexts_Allocation property
        /// </summary>
        private AllocationAllocationContexts_AllocationCollection _allocationContexts_Allocation;
        
        private static IClass _classInstance;
        
        public Allocation()
        {
            this._allocationContexts_Allocation = new AllocationAllocationContexts_AllocationCollection(this);
            this._allocationContexts_Allocation.CollectionChanging += this.AllocationContexts_AllocationCollectionChanging;
            this._allocationContexts_Allocation.CollectionChanged += this.AllocationContexts_AllocationCollectionChanged;
        }
        
        /// <summary>
        /// The targetResourceEnvironment_Allocation property
        /// </summary>
        [XmlElementNameAttribute("targetResourceEnvironment_Allocation")]
        [XmlAttributeAttribute(true)]
        public IResourceEnvironment TargetResourceEnvironment_Allocation
        {
            get
            {
                return this._targetResourceEnvironment_Allocation;
            }
            set
            {
                if ((this._targetResourceEnvironment_Allocation != value))
                {
                    IResourceEnvironment old = this._targetResourceEnvironment_Allocation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnTargetResourceEnvironment_AllocationChanging(e);
                    this.OnPropertyChanging("TargetResourceEnvironment_Allocation", e, _targetResourceEnvironment_AllocationReference);
                    this._targetResourceEnvironment_Allocation = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetTargetResourceEnvironment_Allocation;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetTargetResourceEnvironment_Allocation;
                    }
                    this.OnTargetResourceEnvironment_AllocationChanged(e);
                    this.OnPropertyChanged("TargetResourceEnvironment_Allocation", e, _targetResourceEnvironment_AllocationReference);
                }
            }
        }
        
        /// <summary>
        /// The system_Allocation property
        /// </summary>
        [XmlElementNameAttribute("system_Allocation")]
        [XmlAttributeAttribute(true)]
        public ISystem0 System_Allocation
        {
            get
            {
                return this._system_Allocation;
            }
            set
            {
                if ((this._system_Allocation != value))
                {
                    ISystem0 old = this._system_Allocation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSystem_AllocationChanging(e);
                    this.OnPropertyChanging("System_Allocation", e, _system_AllocationReference);
                    this._system_Allocation = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSystem_Allocation;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSystem_Allocation;
                    }
                    this.OnSystem_AllocationChanged(e);
                    this.OnPropertyChanged("System_Allocation", e, _system_AllocationReference);
                }
            }
        }
        
        /// <summary>
        /// The allocationContexts_Allocation property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("allocationContexts_Allocation")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("allocation_AllocationContext")]
        [ConstantAttribute()]
        public IListExpression<IAllocationContext> AllocationContexts_Allocation
        {
            get
            {
                return this._allocationContexts_Allocation;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new AllocationChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AllocationReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//allocation/Allocation")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the TargetResourceEnvironment_Allocation property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> TargetResourceEnvironment_AllocationChanging;
        
        /// <summary>
        /// Gets fired when the TargetResourceEnvironment_Allocation property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> TargetResourceEnvironment_AllocationChanged;
        
        /// <summary>
        /// Gets fired before the System_Allocation property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> System_AllocationChanging;
        
        /// <summary>
        /// Gets fired when the System_Allocation property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> System_AllocationChanged;
        
        private static ITypedElement RetrieveTargetResourceEnvironment_AllocationReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Allocation.Allocation.ClassInstance)).Resolve("targetResourceEnvironment_Allocation")));
        }
        
        /// <summary>
        /// Raises the TargetResourceEnvironment_AllocationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTargetResourceEnvironment_AllocationChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.TargetResourceEnvironment_AllocationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the TargetResourceEnvironment_AllocationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnTargetResourceEnvironment_AllocationChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.TargetResourceEnvironment_AllocationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the TargetResourceEnvironment_Allocation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetTargetResourceEnvironment_Allocation(object sender, global::System.EventArgs eventArgs)
        {
            this.TargetResourceEnvironment_Allocation = null;
        }
        
        private static ITypedElement RetrieveSystem_AllocationReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Allocation.Allocation.ClassInstance)).Resolve("system_Allocation")));
        }
        
        /// <summary>
        /// Raises the System_AllocationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystem_AllocationChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.System_AllocationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the System_AllocationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSystem_AllocationChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.System_AllocationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the System_Allocation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSystem_Allocation(object sender, global::System.EventArgs eventArgs)
        {
            this.System_Allocation = null;
        }
        
        private static ITypedElement RetrieveAllocationContexts_AllocationReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Allocation.Allocation.ClassInstance)).Resolve("allocationContexts_Allocation")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AllocationContexts_Allocation property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AllocationContexts_AllocationCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("AllocationContexts_Allocation", e, _allocationContexts_AllocationReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AllocationContexts_Allocation property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AllocationContexts_AllocationCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AllocationContexts_Allocation", e, _allocationContexts_AllocationReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int allocationContexts_AllocationIndex = ModelHelper.IndexOfReference(this.AllocationContexts_Allocation, element);
            if ((allocationContexts_AllocationIndex != -1))
            {
                return ModelHelper.CreatePath("allocationContexts_Allocation", allocationContexts_AllocationIndex);
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
            if ((reference == "ALLOCATIONCONTEXTS_ALLOCATION"))
            {
                if ((index < this.AllocationContexts_Allocation.Count))
                {
                    return this.AllocationContexts_Allocation[index];
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
            if ((feature == "ALLOCATIONCONTEXTS_ALLOCATION"))
            {
                return this._allocationContexts_Allocation;
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
            if ((feature == "TARGETRESOURCEENVIRONMENT_ALLOCATION"))
            {
                this.TargetResourceEnvironment_Allocation = ((IResourceEnvironment)(value));
                return;
            }
            if ((feature == "SYSTEM_ALLOCATION"))
            {
                this.System_Allocation = ((ISystem0)(value));
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
            if ((attribute == "TargetResourceEnvironment_Allocation"))
            {
                return new TargetResourceEnvironment_AllocationProxy(this);
            }
            if ((attribute == "System_Allocation"))
            {
                return new System_AllocationProxy(this);
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
            if ((reference == "TargetResourceEnvironment_Allocation"))
            {
                return new TargetResourceEnvironment_AllocationProxy(this);
            }
            if ((reference == "System_Allocation"))
            {
                return new System_AllocationProxy(this);
            }
            return base.GetExpressionForReference(reference);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._allocationContexts_Allocation))
            {
                return "allocationContexts_Allocation";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//allocation/Allocation")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Allocation class
        /// </summary>
        public class AllocationChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Allocation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AllocationChildrenCollection(Allocation parent)
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
                    count = (count + this._parent.AllocationContexts_Allocation.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.AllocationContexts_Allocation.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.AllocationContexts_Allocation.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IAllocationContext allocationContexts_AllocationCasted = item.As<IAllocationContext>();
                if ((allocationContexts_AllocationCasted != null))
                {
                    this._parent.AllocationContexts_Allocation.Add(allocationContexts_AllocationCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.AllocationContexts_Allocation.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.AllocationContexts_Allocation.Contains(item))
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
                IEnumerator<IModelElement> allocationContexts_AllocationEnumerator = this._parent.AllocationContexts_Allocation.GetEnumerator();
                try
                {
                    for (
                    ; allocationContexts_AllocationEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = allocationContexts_AllocationEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    allocationContexts_AllocationEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IAllocationContext allocationContextItem = item.As<IAllocationContext>();
                if (((allocationContextItem != null) 
                            && this._parent.AllocationContexts_Allocation.Remove(allocationContextItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.AllocationContexts_Allocation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Allocation class
        /// </summary>
        public class AllocationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Allocation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AllocationReferencedElementsCollection(Allocation parent)
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
                    if ((this._parent.TargetResourceEnvironment_Allocation != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.System_Allocation != null))
                    {
                        count = (count + 1);
                    }
                    count = (count + this._parent.AllocationContexts_Allocation.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.TargetResourceEnvironment_AllocationChanged += this.PropagateValueChanges;
                this._parent.System_AllocationChanged += this.PropagateValueChanges;
                this._parent.AllocationContexts_Allocation.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.TargetResourceEnvironment_AllocationChanged -= this.PropagateValueChanges;
                this._parent.System_AllocationChanged -= this.PropagateValueChanges;
                this._parent.AllocationContexts_Allocation.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.TargetResourceEnvironment_Allocation == null))
                {
                    IResourceEnvironment targetResourceEnvironment_AllocationCasted = item.As<IResourceEnvironment>();
                    if ((targetResourceEnvironment_AllocationCasted != null))
                    {
                        this._parent.TargetResourceEnvironment_Allocation = targetResourceEnvironment_AllocationCasted;
                        return;
                    }
                }
                if ((this._parent.System_Allocation == null))
                {
                    ISystem0 system_AllocationCasted = item.As<ISystem0>();
                    if ((system_AllocationCasted != null))
                    {
                        this._parent.System_Allocation = system_AllocationCasted;
                        return;
                    }
                }
                IAllocationContext allocationContexts_AllocationCasted = item.As<IAllocationContext>();
                if ((allocationContexts_AllocationCasted != null))
                {
                    this._parent.AllocationContexts_Allocation.Add(allocationContexts_AllocationCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.TargetResourceEnvironment_Allocation = null;
                this._parent.System_Allocation = null;
                this._parent.AllocationContexts_Allocation.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.TargetResourceEnvironment_Allocation))
                {
                    return true;
                }
                if ((item == this._parent.System_Allocation))
                {
                    return true;
                }
                if (this._parent.AllocationContexts_Allocation.Contains(item))
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
                if ((this._parent.TargetResourceEnvironment_Allocation != null))
                {
                    array[arrayIndex] = this._parent.TargetResourceEnvironment_Allocation;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.System_Allocation != null))
                {
                    array[arrayIndex] = this._parent.System_Allocation;
                    arrayIndex = (arrayIndex + 1);
                }
                IEnumerator<IModelElement> allocationContexts_AllocationEnumerator = this._parent.AllocationContexts_Allocation.GetEnumerator();
                try
                {
                    for (
                    ; allocationContexts_AllocationEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = allocationContexts_AllocationEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    allocationContexts_AllocationEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                if ((this._parent.TargetResourceEnvironment_Allocation == item))
                {
                    this._parent.TargetResourceEnvironment_Allocation = null;
                    return true;
                }
                if ((this._parent.System_Allocation == item))
                {
                    this._parent.System_Allocation = null;
                    return true;
                }
                IAllocationContext allocationContextItem = item.As<IAllocationContext>();
                if (((allocationContextItem != null) 
                            && this._parent.AllocationContexts_Allocation.Remove(allocationContextItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.TargetResourceEnvironment_Allocation).Concat(this._parent.System_Allocation).Concat(this._parent.AllocationContexts_Allocation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the targetResourceEnvironment_Allocation property
        /// </summary>
        private sealed class TargetResourceEnvironment_AllocationProxy : ModelPropertyChange<IAllocation, IResourceEnvironment>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public TargetResourceEnvironment_AllocationProxy(IAllocation modelElement) : 
                    base(modelElement, "targetResourceEnvironment_Allocation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceEnvironment Value
            {
                get
                {
                    return this.ModelElement.TargetResourceEnvironment_Allocation;
                }
                set
                {
                    this.ModelElement.TargetResourceEnvironment_Allocation = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the system_Allocation property
        /// </summary>
        private sealed class System_AllocationProxy : ModelPropertyChange<IAllocation, ISystem0>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public System_AllocationProxy(IAllocation modelElement) : 
                    base(modelElement, "system_Allocation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISystem0 Value
            {
                get
                {
                    return this.ModelElement.System_Allocation;
                }
                set
                {
                    this.ModelElement.System_Allocation = value;
                }
            }
        }
    }
}

