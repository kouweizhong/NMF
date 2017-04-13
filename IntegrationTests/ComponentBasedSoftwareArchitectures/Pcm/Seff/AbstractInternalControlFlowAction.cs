//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Identifier;
using NMFExamples.Pcm.Core;
using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Reliability;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.Seff.Seff_performance;
using NMFExamples.Pcm.Seff.Seff_reliability;
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

namespace NMFExamples.Pcm.Seff
{
    
    
    /// <summary>
    /// The default implementation of the AbstractInternalControlFlowAction class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/AbstractInternalControlFl" +
        "owAction")]
    [DebuggerDisplayAttribute("AbstractInternalControlFlowAction {Id}")]
    public abstract partial class AbstractInternalControlFlowAction : AbstractAction, IAbstractInternalControlFlowAction, IModelElement
    {
        
        private static Lazy<ITypedElement> _resourceDemand_ActionReference = new Lazy<ITypedElement>(RetrieveResourceDemand_ActionReference);
        
        /// <summary>
        /// The backing field for the ResourceDemand_Action property
        /// </summary>
        private AbstractInternalControlFlowActionResourceDemand_ActionCollection _resourceDemand_Action;
        
        private static Lazy<ITypedElement> _infrastructureCall__ActionReference = new Lazy<ITypedElement>(RetrieveInfrastructureCall__ActionReference);
        
        /// <summary>
        /// The backing field for the InfrastructureCall__Action property
        /// </summary>
        private AbstractInternalControlFlowActionInfrastructureCall__ActionCollection _infrastructureCall__Action;
        
        private static Lazy<ITypedElement> _resourceCall__ActionReference = new Lazy<ITypedElement>(RetrieveResourceCall__ActionReference);
        
        /// <summary>
        /// The backing field for the ResourceCall__Action property
        /// </summary>
        private AbstractInternalControlFlowActionResourceCall__ActionCollection _resourceCall__Action;
        
        private static IClass _classInstance;
        
        public AbstractInternalControlFlowAction()
        {
            this._resourceDemand_Action = new AbstractInternalControlFlowActionResourceDemand_ActionCollection(this);
            this._resourceDemand_Action.CollectionChanging += this.ResourceDemand_ActionCollectionChanging;
            this._resourceDemand_Action.CollectionChanged += this.ResourceDemand_ActionCollectionChanged;
            this._infrastructureCall__Action = new AbstractInternalControlFlowActionInfrastructureCall__ActionCollection(this);
            this._infrastructureCall__Action.CollectionChanging += this.InfrastructureCall__ActionCollectionChanging;
            this._infrastructureCall__Action.CollectionChanged += this.InfrastructureCall__ActionCollectionChanged;
            this._resourceCall__Action = new AbstractInternalControlFlowActionResourceCall__ActionCollection(this);
            this._resourceCall__Action.CollectionChanging += this.ResourceCall__ActionCollectionChanging;
            this._resourceCall__Action.CollectionChanged += this.ResourceCall__ActionCollectionChanged;
        }
        
        /// <summary>
        /// The resourceDemand_Action property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceDemand_Action")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("action_ParametricResourceDemand")]
        [ConstantAttribute()]
        public IListExpression<IParametricResourceDemand> ResourceDemand_Action
        {
            get
            {
                return this._resourceDemand_Action;
            }
        }
        
        /// <summary>
        /// The infrastructureCall__Action property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("infrastructureCall__Action")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("action__InfrastructureCall")]
        [ConstantAttribute()]
        public IListExpression<IInfrastructureCall> InfrastructureCall__Action
        {
            get
            {
                return this._infrastructureCall__Action;
            }
        }
        
        /// <summary>
        /// The resourceCall__Action property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("resourceCall__Action")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("action__ResourceCall")]
        [ConstantAttribute()]
        public IListExpression<IResourceCall> ResourceCall__Action
        {
            get
            {
                return this._resourceCall__Action;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new AbstractInternalControlFlowActionChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new AbstractInternalControlFlowActionReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/AbstractInternalControlFl" +
                            "owAction")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveResourceDemand_ActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.AbstractInternalControlFlowAction.ClassInstance)).Resolve("resourceDemand_Action")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ResourceDemand_Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceDemand_ActionCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ResourceDemand_Action", e, _resourceDemand_ActionReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ResourceDemand_Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceDemand_ActionCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceDemand_Action", e, _resourceDemand_ActionReference);
        }
        
        private static ITypedElement RetrieveInfrastructureCall__ActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.AbstractInternalControlFlowAction.ClassInstance)).Resolve("infrastructureCall__Action")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the InfrastructureCall__Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InfrastructureCall__ActionCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("InfrastructureCall__Action", e, _infrastructureCall__ActionReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the InfrastructureCall__Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InfrastructureCall__ActionCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InfrastructureCall__Action", e, _infrastructureCall__ActionReference);
        }
        
        private static ITypedElement RetrieveResourceCall__ActionReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.AbstractInternalControlFlowAction.ClassInstance)).Resolve("resourceCall__Action")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ResourceCall__Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceCall__ActionCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ResourceCall__Action", e, _resourceCall__ActionReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ResourceCall__Action property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ResourceCall__ActionCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ResourceCall__Action", e, _resourceCall__ActionReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int resourceDemand_ActionIndex = ModelHelper.IndexOfReference(this.ResourceDemand_Action, element);
            if ((resourceDemand_ActionIndex != -1))
            {
                return ModelHelper.CreatePath("resourceDemand_Action", resourceDemand_ActionIndex);
            }
            int infrastructureCall__ActionIndex = ModelHelper.IndexOfReference(this.InfrastructureCall__Action, element);
            if ((infrastructureCall__ActionIndex != -1))
            {
                return ModelHelper.CreatePath("infrastructureCall__Action", infrastructureCall__ActionIndex);
            }
            int resourceCall__ActionIndex = ModelHelper.IndexOfReference(this.ResourceCall__Action, element);
            if ((resourceCall__ActionIndex != -1))
            {
                return ModelHelper.CreatePath("resourceCall__Action", resourceCall__ActionIndex);
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
            if ((reference == "RESOURCEDEMAND_ACTION"))
            {
                if ((index < this.ResourceDemand_Action.Count))
                {
                    return this.ResourceDemand_Action[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "INFRASTRUCTURECALL__ACTION"))
            {
                if ((index < this.InfrastructureCall__Action.Count))
                {
                    return this.InfrastructureCall__Action[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "RESOURCECALL__ACTION"))
            {
                if ((index < this.ResourceCall__Action.Count))
                {
                    return this.ResourceCall__Action[index];
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
            if ((feature == "RESOURCEDEMAND_ACTION"))
            {
                return this._resourceDemand_Action;
            }
            if ((feature == "INFRASTRUCTURECALL__ACTION"))
            {
                return this._infrastructureCall__Action;
            }
            if ((feature == "RESOURCECALL__ACTION"))
            {
                return this._resourceCall__Action;
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
            if ((container == this._resourceDemand_Action))
            {
                return "resourceDemand_Action";
            }
            if ((container == this._infrastructureCall__Action))
            {
                return "infrastructureCall__Action";
            }
            if ((container == this._resourceCall__Action))
            {
                return "resourceCall__Action";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/AbstractInternalControlFl" +
                        "owAction")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AbstractInternalControlFlowAction class
        /// </summary>
        public class AbstractInternalControlFlowActionChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AbstractInternalControlFlowAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AbstractInternalControlFlowActionChildrenCollection(AbstractInternalControlFlowAction parent)
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
                    count = (count + this._parent.ResourceDemand_Action.Count);
                    count = (count + this._parent.InfrastructureCall__Action.Count);
                    count = (count + this._parent.ResourceCall__Action.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IParametricResourceDemand resourceDemand_ActionCasted = item.As<IParametricResourceDemand>();
                if ((resourceDemand_ActionCasted != null))
                {
                    this._parent.ResourceDemand_Action.Add(resourceDemand_ActionCasted);
                }
                IInfrastructureCall infrastructureCall__ActionCasted = item.As<IInfrastructureCall>();
                if ((infrastructureCall__ActionCasted != null))
                {
                    this._parent.InfrastructureCall__Action.Add(infrastructureCall__ActionCasted);
                }
                IResourceCall resourceCall__ActionCasted = item.As<IResourceCall>();
                if ((resourceCall__ActionCasted != null))
                {
                    this._parent.ResourceCall__Action.Add(resourceCall__ActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceDemand_Action.Clear();
                this._parent.InfrastructureCall__Action.Clear();
                this._parent.ResourceCall__Action.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceDemand_Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.InfrastructureCall__Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceCall__Action.Contains(item))
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
                IEnumerator<IModelElement> resourceDemand_ActionEnumerator = this._parent.ResourceDemand_Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceDemand_ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceDemand_ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceDemand_ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> infrastructureCall__ActionEnumerator = this._parent.InfrastructureCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; infrastructureCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = infrastructureCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    infrastructureCall__ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceCall__ActionEnumerator = this._parent.ResourceCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceCall__ActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IParametricResourceDemand parametricResourceDemandItem = item.As<IParametricResourceDemand>();
                if (((parametricResourceDemandItem != null) 
                            && this._parent.ResourceDemand_Action.Remove(parametricResourceDemandItem)))
                {
                    return true;
                }
                IInfrastructureCall infrastructureCallItem = item.As<IInfrastructureCall>();
                if (((infrastructureCallItem != null) 
                            && this._parent.InfrastructureCall__Action.Remove(infrastructureCallItem)))
                {
                    return true;
                }
                IResourceCall resourceCallItem = item.As<IResourceCall>();
                if (((resourceCallItem != null) 
                            && this._parent.ResourceCall__Action.Remove(resourceCallItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceDemand_Action).Concat(this._parent.InfrastructureCall__Action).Concat(this._parent.ResourceCall__Action).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the AbstractInternalControlFlowAction class
        /// </summary>
        public class AbstractInternalControlFlowActionReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private AbstractInternalControlFlowAction _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public AbstractInternalControlFlowActionReferencedElementsCollection(AbstractInternalControlFlowAction parent)
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
                    count = (count + this._parent.ResourceDemand_Action.Count);
                    count = (count + this._parent.InfrastructureCall__Action.Count);
                    count = (count + this._parent.ResourceCall__Action.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceDemand_Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.InfrastructureCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ResourceCall__Action.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IParametricResourceDemand resourceDemand_ActionCasted = item.As<IParametricResourceDemand>();
                if ((resourceDemand_ActionCasted != null))
                {
                    this._parent.ResourceDemand_Action.Add(resourceDemand_ActionCasted);
                }
                IInfrastructureCall infrastructureCall__ActionCasted = item.As<IInfrastructureCall>();
                if ((infrastructureCall__ActionCasted != null))
                {
                    this._parent.InfrastructureCall__Action.Add(infrastructureCall__ActionCasted);
                }
                IResourceCall resourceCall__ActionCasted = item.As<IResourceCall>();
                if ((resourceCall__ActionCasted != null))
                {
                    this._parent.ResourceCall__Action.Add(resourceCall__ActionCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceDemand_Action.Clear();
                this._parent.InfrastructureCall__Action.Clear();
                this._parent.ResourceCall__Action.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ResourceDemand_Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.InfrastructureCall__Action.Contains(item))
                {
                    return true;
                }
                if (this._parent.ResourceCall__Action.Contains(item))
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
                IEnumerator<IModelElement> resourceDemand_ActionEnumerator = this._parent.ResourceDemand_Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceDemand_ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceDemand_ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceDemand_ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> infrastructureCall__ActionEnumerator = this._parent.InfrastructureCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; infrastructureCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = infrastructureCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    infrastructureCall__ActionEnumerator.Dispose();
                }
                IEnumerator<IModelElement> resourceCall__ActionEnumerator = this._parent.ResourceCall__Action.GetEnumerator();
                try
                {
                    for (
                    ; resourceCall__ActionEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = resourceCall__ActionEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    resourceCall__ActionEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IParametricResourceDemand parametricResourceDemandItem = item.As<IParametricResourceDemand>();
                if (((parametricResourceDemandItem != null) 
                            && this._parent.ResourceDemand_Action.Remove(parametricResourceDemandItem)))
                {
                    return true;
                }
                IInfrastructureCall infrastructureCallItem = item.As<IInfrastructureCall>();
                if (((infrastructureCallItem != null) 
                            && this._parent.InfrastructureCall__Action.Remove(infrastructureCallItem)))
                {
                    return true;
                }
                IResourceCall resourceCallItem = item.As<IResourceCall>();
                if (((resourceCallItem != null) 
                            && this._parent.ResourceCall__Action.Remove(resourceCallItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceDemand_Action).Concat(this._parent.InfrastructureCall__Action).Concat(this._parent.ResourceCall__Action).GetEnumerator();
            }
        }
    }
}
