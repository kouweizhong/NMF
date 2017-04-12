//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.SystemIndependent
{
    
    
    /// <summary>
    /// The default implementation of the Repository_MM06 class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/SystemIndependent/")]
    [XmlNamespacePrefixAttribute("system")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//SystemIndependent/Repository_MM06")]
    public partial class Repository_MM06 : ModelElement, IRepository_MM06, IModelElement
    {
        
        private static Lazy<ITypedElement> _interfacesReference = new Lazy<ITypedElement>(RetrieveInterfacesReference);
        
        /// <summary>
        /// The backing field for the Interfaces property
        /// </summary>
        private ObservableCompositionOrderedSet<IInterface> _interfaces;
        
        private static Lazy<ITypedElement> _componentsReference = new Lazy<ITypedElement>(RetrieveComponentsReference);
        
        /// <summary>
        /// The backing field for the Components property
        /// </summary>
        private ObservableCompositionOrderedSet<IComponent_MM06> _components;
        
        private static Lazy<ITypedElement> _availableSignaturesReference = new Lazy<ITypedElement>(RetrieveAvailableSignaturesReference);
        
        /// <summary>
        /// The backing field for the AvailableSignatures property
        /// </summary>
        private ObservableCompositionOrderedSet<ISignature> _availableSignatures;
        
        private static IClass _classInstance;
        
        public Repository_MM06()
        {
            this._interfaces = new ObservableCompositionOrderedSet<IInterface>(this);
            this._interfaces.CollectionChanging += this.InterfacesCollectionChanging;
            this._interfaces.CollectionChanged += this.InterfacesCollectionChanged;
            this._components = new ObservableCompositionOrderedSet<IComponent_MM06>(this);
            this._components.CollectionChanging += this.ComponentsCollectionChanging;
            this._components.CollectionChanged += this.ComponentsCollectionChanged;
            this._availableSignatures = new ObservableCompositionOrderedSet<ISignature>(this);
            this._availableSignatures.CollectionChanging += this.AvailableSignaturesCollectionChanging;
            this._availableSignatures.CollectionChanged += this.AvailableSignaturesCollectionChanged;
        }
        
        /// <summary>
        /// The Interfaces property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IInterface> Interfaces
        {
            get
            {
                return this._interfaces;
            }
        }
        
        /// <summary>
        /// The Components property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<IComponent_MM06> Components
        {
            get
            {
                return this._components;
            }
        }
        
        /// <summary>
        /// The AvailableSignatures property
        /// </summary>
        [LowerBoundAttribute(1)]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public virtual IOrderedSetExpression<ISignature> AvailableSignatures
        {
            get
            {
                return this._availableSignatures;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new Repository_MM06ChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new Repository_MM06ReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//SystemIndependent/Repository_MM06")));
                }
                return _classInstance;
            }
        }
        
        private static ITypedElement RetrieveInterfacesReference()
        {
            return ((ITypedElement)(((ModelElement)(Repository_MM06.ClassInstance)).Resolve("Interfaces")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Interfaces property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InterfacesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Interfaces", e, _interfacesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Interfaces property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InterfacesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Interfaces", e, _interfacesReference);
        }
        
        private static ITypedElement RetrieveComponentsReference()
        {
            return ((ITypedElement)(((ModelElement)(Repository_MM06.ClassInstance)).Resolve("Components")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the Components property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ComponentsCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("Components", e, _componentsReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the Components property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ComponentsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("Components", e, _componentsReference);
        }
        
        private static ITypedElement RetrieveAvailableSignaturesReference()
        {
            return ((ITypedElement)(((ModelElement)(Repository_MM06.ClassInstance)).Resolve("AvailableSignatures")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the AvailableSignatures property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AvailableSignaturesCollectionChanging(object sender, NMF.Collections.ObjectModel.NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("AvailableSignatures", e, _availableSignaturesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the AvailableSignatures property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void AvailableSignaturesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("AvailableSignatures", e, _availableSignaturesReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int interfacesIndex = ModelHelper.IndexOfReference(this.Interfaces, element);
            if ((interfacesIndex != -1))
            {
                return ModelHelper.CreatePath("Interfaces", interfacesIndex);
            }
            int componentsIndex = ModelHelper.IndexOfReference(this.Components, element);
            if ((componentsIndex != -1))
            {
                return ModelHelper.CreatePath("Components", componentsIndex);
            }
            int availableSignaturesIndex = ModelHelper.IndexOfReference(this.AvailableSignatures, element);
            if ((availableSignaturesIndex != -1))
            {
                return ModelHelper.CreatePath("AvailableSignatures", availableSignaturesIndex);
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
            if ((reference == "INTERFACES"))
            {
                if ((index < this.Interfaces.Count))
                {
                    return this.Interfaces[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "COMPONENTS"))
            {
                if ((index < this.Components.Count))
                {
                    return this.Components[index];
                }
                else
                {
                    return null;
                }
            }
            if ((reference == "AVAILABLESIGNATURES"))
            {
                if ((index < this.AvailableSignatures.Count))
                {
                    return this.AvailableSignatures[index];
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
            if ((feature == "INTERFACES"))
            {
                return this._interfaces;
            }
            if ((feature == "COMPONENTS"))
            {
                return this._components;
            }
            if ((feature == "AVAILABLESIGNATURES"))
            {
                return this._availableSignatures;
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
            if ((container == this._interfaces))
            {
                return "Interfaces";
            }
            if ((container == this._components))
            {
                return "Components";
            }
            if ((container == this._availableSignatures))
            {
                return "AvailableSignatures";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.kit.edu/ComponentBasedSystem/#//SystemIndependent/Repository_MM06")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Repository_MM06 class
        /// </summary>
        public class Repository_MM06ChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Repository_MM06 _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Repository_MM06ChildrenCollection(Repository_MM06 parent)
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
                    count = (count + this._parent.Interfaces.Count);
                    count = (count + this._parent.Components.Count);
                    count = (count + this._parent.AvailableSignatures.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Interfaces.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Components.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.AvailableSignatures.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Interfaces.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Components.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.AvailableSignatures.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IInterface interfacesCasted = item.As<IInterface>();
                if ((interfacesCasted != null))
                {
                    this._parent.Interfaces.Add(interfacesCasted);
                }
                IComponent_MM06 componentsCasted = item.As<IComponent_MM06>();
                if ((componentsCasted != null))
                {
                    this._parent.Components.Add(componentsCasted);
                }
                ISignature availableSignaturesCasted = item.As<ISignature>();
                if ((availableSignaturesCasted != null))
                {
                    this._parent.AvailableSignatures.Add(availableSignaturesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Interfaces.Clear();
                this._parent.Components.Clear();
                this._parent.AvailableSignatures.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Interfaces.Contains(item))
                {
                    return true;
                }
                if (this._parent.Components.Contains(item))
                {
                    return true;
                }
                if (this._parent.AvailableSignatures.Contains(item))
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
                IEnumerator<IModelElement> interfacesEnumerator = this._parent.Interfaces.GetEnumerator();
                try
                {
                    for (
                    ; interfacesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = interfacesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    interfacesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> componentsEnumerator = this._parent.Components.GetEnumerator();
                try
                {
                    for (
                    ; componentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = componentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    componentsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> availableSignaturesEnumerator = this._parent.AvailableSignatures.GetEnumerator();
                try
                {
                    for (
                    ; availableSignaturesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = availableSignaturesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    availableSignaturesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IInterface interfaceItem = item.As<IInterface>();
                if (((interfaceItem != null) 
                            && this._parent.Interfaces.Remove(interfaceItem)))
                {
                    return true;
                }
                IComponent_MM06 component_MM06Item = item.As<IComponent_MM06>();
                if (((component_MM06Item != null) 
                            && this._parent.Components.Remove(component_MM06Item)))
                {
                    return true;
                }
                ISignature signatureItem = item.As<ISignature>();
                if (((signatureItem != null) 
                            && this._parent.AvailableSignatures.Remove(signatureItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Interfaces).Concat(this._parent.Components).Concat(this._parent.AvailableSignatures).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Repository_MM06 class
        /// </summary>
        public class Repository_MM06ReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Repository_MM06 _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public Repository_MM06ReferencedElementsCollection(Repository_MM06 parent)
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
                    count = (count + this._parent.Interfaces.Count);
                    count = (count + this._parent.Components.Count);
                    count = (count + this._parent.AvailableSignatures.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Interfaces.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Components.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.AvailableSignatures.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Interfaces.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Components.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.AvailableSignatures.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IInterface interfacesCasted = item.As<IInterface>();
                if ((interfacesCasted != null))
                {
                    this._parent.Interfaces.Add(interfacesCasted);
                }
                IComponent_MM06 componentsCasted = item.As<IComponent_MM06>();
                if ((componentsCasted != null))
                {
                    this._parent.Components.Add(componentsCasted);
                }
                ISignature availableSignaturesCasted = item.As<ISignature>();
                if ((availableSignaturesCasted != null))
                {
                    this._parent.AvailableSignatures.Add(availableSignaturesCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Interfaces.Clear();
                this._parent.Components.Clear();
                this._parent.AvailableSignatures.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.Interfaces.Contains(item))
                {
                    return true;
                }
                if (this._parent.Components.Contains(item))
                {
                    return true;
                }
                if (this._parent.AvailableSignatures.Contains(item))
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
                IEnumerator<IModelElement> interfacesEnumerator = this._parent.Interfaces.GetEnumerator();
                try
                {
                    for (
                    ; interfacesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = interfacesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    interfacesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> componentsEnumerator = this._parent.Components.GetEnumerator();
                try
                {
                    for (
                    ; componentsEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = componentsEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    componentsEnumerator.Dispose();
                }
                IEnumerator<IModelElement> availableSignaturesEnumerator = this._parent.AvailableSignatures.GetEnumerator();
                try
                {
                    for (
                    ; availableSignaturesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = availableSignaturesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    availableSignaturesEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IInterface interfaceItem = item.As<IInterface>();
                if (((interfaceItem != null) 
                            && this._parent.Interfaces.Remove(interfaceItem)))
                {
                    return true;
                }
                IComponent_MM06 component_MM06Item = item.As<IComponent_MM06>();
                if (((component_MM06Item != null) 
                            && this._parent.Components.Remove(component_MM06Item)))
                {
                    return true;
                }
                ISignature signatureItem = item.As<ISignature>();
                if (((signatureItem != null) 
                            && this._parent.AvailableSignatures.Remove(signatureItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Interfaces).Concat(this._parent.Components).Concat(this._parent.AvailableSignatures).GetEnumerator();
            }
        }
    }
}

