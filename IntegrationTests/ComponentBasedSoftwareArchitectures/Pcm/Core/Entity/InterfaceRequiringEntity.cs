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
using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.Resourcetype;
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

namespace NMFExamples.Pcm.Core.Entity
{
    
    
    /// <summary>
    /// The default implementation of the InterfaceRequiringEntity class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Entity/5.0")]
    [XmlNamespacePrefixAttribute("entity")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/entity/InterfaceRequiring" +
        "Entity")]
    [DebuggerDisplayAttribute("InterfaceRequiringEntity {Id}")]
    public abstract partial class InterfaceRequiringEntity : ResourceInterfaceRequiringEntity, IInterfaceRequiringEntity, IModelElement
    {
        
        private static Lazy<ITypedElement> _requiredRoles_InterfaceRequiringEntityReference = new Lazy<ITypedElement>(RetrieveRequiredRoles_InterfaceRequiringEntityReference);
        
        /// <summary>
        /// The backing field for the RequiredRoles_InterfaceRequiringEntity property
        /// </summary>
        private InterfaceRequiringEntityRequiredRoles_InterfaceRequiringEntityCollection _requiredRoles_InterfaceRequiringEntity;
        
        private static IClass _classInstance;
        
        public InterfaceRequiringEntity()
        {
            this._requiredRoles_InterfaceRequiringEntity = new InterfaceRequiringEntityRequiredRoles_InterfaceRequiringEntityCollection(this);
            this._requiredRoles_InterfaceRequiringEntity.CollectionChanging += this.RequiredRoles_InterfaceRequiringEntityCollectionChanging;
            this._requiredRoles_InterfaceRequiringEntity.CollectionChanged += this.RequiredRoles_InterfaceRequiringEntityCollectionChanged;
        }
        
        /// <summary>
        /// The requiredRoles_InterfaceRequiringEntity property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("requiredRoles_InterfaceRequiringEntity")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("requiringEntity_RequiredRole")]
        [ConstantAttribute()]
        public IListExpression<IRequiredRole> RequiredRoles_InterfaceRequiringEntity
        {
            get
            {
                return this._requiredRoles_InterfaceRequiringEntity;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new InterfaceRequiringEntityChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new InterfaceRequiringEntityReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/entity/InterfaceRequiring" +
                            "Entity")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveRequiredRoles_InterfaceRequiringEntityReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Entity.InterfaceRequiringEntity.ClassInstance)).Resolve("requiredRoles_InterfaceRequiringEntity")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the RequiredRoles_InterfaceRequiringEntity property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RequiredRoles_InterfaceRequiringEntityCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("RequiredRoles_InterfaceRequiringEntity", e, _requiredRoles_InterfaceRequiringEntityReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the RequiredRoles_InterfaceRequiringEntity property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void RequiredRoles_InterfaceRequiringEntityCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("RequiredRoles_InterfaceRequiringEntity", e, _requiredRoles_InterfaceRequiringEntityReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int requiredRoles_InterfaceRequiringEntityIndex = ModelHelper.IndexOfReference(this.RequiredRoles_InterfaceRequiringEntity, element);
            if ((requiredRoles_InterfaceRequiringEntityIndex != -1))
            {
                return ModelHelper.CreatePath("requiredRoles_InterfaceRequiringEntity", requiredRoles_InterfaceRequiringEntityIndex);
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
            if ((reference == "REQUIREDROLES_INTERFACEREQUIRINGENTITY"))
            {
                if ((index < this.RequiredRoles_InterfaceRequiringEntity.Count))
                {
                    return this.RequiredRoles_InterfaceRequiringEntity[index];
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
            if ((feature == "REQUIREDROLES_INTERFACEREQUIRINGENTITY"))
            {
                return this._requiredRoles_InterfaceRequiringEntity;
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
            if ((container == this._requiredRoles_InterfaceRequiringEntity))
            {
                return "requiredRoles_InterfaceRequiringEntity";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/entity/InterfaceRequiring" +
                        "Entity")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the InterfaceRequiringEntity class
        /// </summary>
        public class InterfaceRequiringEntityChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private InterfaceRequiringEntity _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InterfaceRequiringEntityChildrenCollection(InterfaceRequiringEntity parent)
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
                    count = (count + this._parent.RequiredRoles_InterfaceRequiringEntity.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRequiredRole requiredRoles_InterfaceRequiringEntityCasted = item.As<IRequiredRole>();
                if ((requiredRoles_InterfaceRequiringEntityCasted != null))
                {
                    this._parent.RequiredRoles_InterfaceRequiringEntity.Add(requiredRoles_InterfaceRequiringEntityCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RequiredRoles_InterfaceRequiringEntity.Contains(item))
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
                IEnumerator<IModelElement> requiredRoles_InterfaceRequiringEntityEnumerator = this._parent.RequiredRoles_InterfaceRequiringEntity.GetEnumerator();
                try
                {
                    for (
                    ; requiredRoles_InterfaceRequiringEntityEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = requiredRoles_InterfaceRequiringEntityEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    requiredRoles_InterfaceRequiringEntityEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRequiredRole requiredRoleItem = item.As<IRequiredRole>();
                if (((requiredRoleItem != null) 
                            && this._parent.RequiredRoles_InterfaceRequiringEntity.Remove(requiredRoleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RequiredRoles_InterfaceRequiringEntity).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the InterfaceRequiringEntity class
        /// </summary>
        public class InterfaceRequiringEntityReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private InterfaceRequiringEntity _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public InterfaceRequiringEntityReferencedElementsCollection(InterfaceRequiringEntity parent)
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
                    count = (count + this._parent.RequiredRoles_InterfaceRequiringEntity.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IRequiredRole requiredRoles_InterfaceRequiringEntityCasted = item.As<IRequiredRole>();
                if ((requiredRoles_InterfaceRequiringEntityCasted != null))
                {
                    this._parent.RequiredRoles_InterfaceRequiringEntity.Add(requiredRoles_InterfaceRequiringEntityCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.RequiredRoles_InterfaceRequiringEntity.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.RequiredRoles_InterfaceRequiringEntity.Contains(item))
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
                IEnumerator<IModelElement> requiredRoles_InterfaceRequiringEntityEnumerator = this._parent.RequiredRoles_InterfaceRequiringEntity.GetEnumerator();
                try
                {
                    for (
                    ; requiredRoles_InterfaceRequiringEntityEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = requiredRoles_InterfaceRequiringEntityEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    requiredRoles_InterfaceRequiringEntityEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IRequiredRole requiredRoleItem = item.As<IRequiredRole>();
                if (((requiredRoleItem != null) 
                            && this._parent.RequiredRoles_InterfaceRequiringEntity.Remove(requiredRoleItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.RequiredRoles_InterfaceRequiringEntity).GetEnumerator();
            }
        }
    }
}

