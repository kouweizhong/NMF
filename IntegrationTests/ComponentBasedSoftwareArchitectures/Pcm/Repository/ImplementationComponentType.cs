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
    /// The default implementation of the ImplementationComponentType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/ImplementationCompo" +
        "nentType")]
    [DebuggerDisplayAttribute("ImplementationComponentType {Id}")]
    public abstract partial class ImplementationComponentType : RepositoryComponent, IImplementationComponentType, IModelElement
    {
        
        /// <summary>
        /// The backing field for the ComponentType property
        /// </summary>
        private ComponentType _componentType = ComponentType.BUSINESS_COMPONENT;
        
        private static Lazy<ITypedElement> _componentTypeAttribute = new Lazy<ITypedElement>(RetrieveComponentTypeAttribute);
        
        private static Lazy<ITypedElement> _parentCompleteComponentTypesReference = new Lazy<ITypedElement>(RetrieveParentCompleteComponentTypesReference);
        
        /// <summary>
        /// The backing field for the ParentCompleteComponentTypes property
        /// </summary>
        private ObservableAssociationList<ICompleteComponentType> _parentCompleteComponentTypes;
        
        private static Lazy<ITypedElement> _componentParameterUsage_ImplementationComponentTypeReference = new Lazy<ITypedElement>(RetrieveComponentParameterUsage_ImplementationComponentTypeReference);
        
        /// <summary>
        /// The backing field for the ComponentParameterUsage_ImplementationComponentType property
        /// </summary>
        private ObservableCompositionList<IVariableUsage> _componentParameterUsage_ImplementationComponentType;
        
        private static IClass _classInstance;
        
        public ImplementationComponentType()
        {
            this._parentCompleteComponentTypes = new ObservableAssociationList<ICompleteComponentType>();
            this._parentCompleteComponentTypes.CollectionChanging += this.ParentCompleteComponentTypesCollectionChanging;
            this._parentCompleteComponentTypes.CollectionChanged += this.ParentCompleteComponentTypesCollectionChanged;
            this._componentParameterUsage_ImplementationComponentType = new ObservableCompositionList<IVariableUsage>(this);
            this._componentParameterUsage_ImplementationComponentType.CollectionChanging += this.ComponentParameterUsage_ImplementationComponentTypeCollectionChanging;
            this._componentParameterUsage_ImplementationComponentType.CollectionChanged += this.ComponentParameterUsage_ImplementationComponentTypeCollectionChanged;
        }
        
        /// <summary>
        /// The componentType property
        /// </summary>
        [DefaultValueAttribute(ComponentType.BUSINESS_COMPONENT)]
        [XmlElementNameAttribute("componentType")]
        [XmlAttributeAttribute(true)]
        public ComponentType ComponentType
        {
            get
            {
                return this._componentType;
            }
            set
            {
                if ((this._componentType != value))
                {
                    ComponentType old = this._componentType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnComponentTypeChanging(e);
                    this.OnPropertyChanging("ComponentType", e, _componentTypeAttribute);
                    this._componentType = value;
                    this.OnComponentTypeChanged(e);
                    this.OnPropertyChanged("ComponentType", e, _componentTypeAttribute);
                }
            }
        }
        
        /// <summary>
        /// The parentCompleteComponentTypes property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("parentCompleteComponentTypes")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public ICollectionExpression<ICompleteComponentType> ParentCompleteComponentTypes
        {
            get
            {
                return this._parentCompleteComponentTypes;
            }
        }
        
        /// <summary>
        /// The componentParameterUsage_ImplementationComponentType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("componentParameterUsage_ImplementationComponentType")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [ConstantAttribute()]
        public IListExpression<IVariableUsage> ComponentParameterUsage_ImplementationComponentType
        {
            get
            {
                return this._componentParameterUsage_ImplementationComponentType;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new ImplementationComponentTypeChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ImplementationComponentTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/ImplementationCompo" +
                            "nentType")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ComponentType property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ComponentTypeChanging;
        
        /// <summary>
        /// Gets fired when the ComponentType property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ComponentTypeChanged;
        
        private static ITypedElement RetrieveComponentTypeAttribute()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.ImplementationComponentType.ClassInstance)).Resolve("componentType")));
        }
        
        /// <summary>
        /// Raises the ComponentTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnComponentTypeChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ComponentTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the ComponentTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnComponentTypeChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ComponentTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        private static ITypedElement RetrieveParentCompleteComponentTypesReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.ImplementationComponentType.ClassInstance)).Resolve("parentCompleteComponentTypes")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ParentCompleteComponentTypes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentCompleteComponentTypesCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ParentCompleteComponentTypes", e, _parentCompleteComponentTypesReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ParentCompleteComponentTypes property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentCompleteComponentTypesCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ParentCompleteComponentTypes", e, _parentCompleteComponentTypesReference);
        }
        
        private static ITypedElement RetrieveComponentParameterUsage_ImplementationComponentTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.ImplementationComponentType.ClassInstance)).Resolve("componentParameterUsage_ImplementationComponentType")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ComponentParameterUsage_ImplementationComponentType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ComponentParameterUsage_ImplementationComponentTypeCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ComponentParameterUsage_ImplementationComponentType", e, _componentParameterUsage_ImplementationComponentTypeReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ComponentParameterUsage_ImplementationComponentType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ComponentParameterUsage_ImplementationComponentTypeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ComponentParameterUsage_ImplementationComponentType", e, _componentParameterUsage_ImplementationComponentTypeReference);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int componentParameterUsage_ImplementationComponentTypeIndex = ModelHelper.IndexOfReference(this.ComponentParameterUsage_ImplementationComponentType, element);
            if ((componentParameterUsage_ImplementationComponentTypeIndex != -1))
            {
                return ModelHelper.CreatePath("componentParameterUsage_ImplementationComponentType", componentParameterUsage_ImplementationComponentTypeIndex);
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
            if ((reference == "COMPONENTPARAMETERUSAGE_IMPLEMENTATIONCOMPONENTTYPE"))
            {
                if ((index < this.ComponentParameterUsage_ImplementationComponentType.Count))
                {
                    return this.ComponentParameterUsage_ImplementationComponentType[index];
                }
                else
                {
                    return null;
                }
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
            if ((attribute == "COMPONENTTYPE"))
            {
                return this.ComponentType;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Gets the Model element collection for the given feature
        /// </summary>
        /// <returns>A non-generic list of elements</returns>
        /// <param name="feature">The requested feature</param>
        protected override global::System.Collections.IList GetCollectionForFeature(string feature)
        {
            if ((feature == "PARENTCOMPLETECOMPONENTTYPES"))
            {
                return this._parentCompleteComponentTypes;
            }
            if ((feature == "COMPONENTPARAMETERUSAGE_IMPLEMENTATIONCOMPONENTTYPE"))
            {
                return this._componentParameterUsage_ImplementationComponentType;
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
            if ((feature == "COMPONENTTYPE"))
            {
                this.ComponentType = ((ComponentType)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property name for the given container
        /// </summary>
        /// <returns>The name of the respective container reference</returns>
        /// <param name="container">The container object</param>
        protected override string GetCompositionName(object container)
        {
            if ((container == this._componentParameterUsage_ImplementationComponentType))
            {
                return "componentParameterUsage_ImplementationComponentType";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/ImplementationCompo" +
                        "nentType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ImplementationComponentType class
        /// </summary>
        public class ImplementationComponentTypeChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ImplementationComponentType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ImplementationComponentTypeChildrenCollection(ImplementationComponentType parent)
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
                    count = (count + this._parent.ComponentParameterUsage_ImplementationComponentType.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ComponentParameterUsage_ImplementationComponentType.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ComponentParameterUsage_ImplementationComponentType.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IVariableUsage componentParameterUsage_ImplementationComponentTypeCasted = item.As<IVariableUsage>();
                if ((componentParameterUsage_ImplementationComponentTypeCasted != null))
                {
                    this._parent.ComponentParameterUsage_ImplementationComponentType.Add(componentParameterUsage_ImplementationComponentTypeCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ComponentParameterUsage_ImplementationComponentType.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ComponentParameterUsage_ImplementationComponentType.Contains(item))
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
                IEnumerator<IModelElement> componentParameterUsage_ImplementationComponentTypeEnumerator = this._parent.ComponentParameterUsage_ImplementationComponentType.GetEnumerator();
                try
                {
                    for (
                    ; componentParameterUsage_ImplementationComponentTypeEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = componentParameterUsage_ImplementationComponentTypeEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    componentParameterUsage_ImplementationComponentTypeEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ComponentParameterUsage_ImplementationComponentType.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ComponentParameterUsage_ImplementationComponentType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ImplementationComponentType class
        /// </summary>
        public class ImplementationComponentTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ImplementationComponentType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ImplementationComponentTypeReferencedElementsCollection(ImplementationComponentType parent)
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
                    count = (count + this._parent.ParentCompleteComponentTypes.Count);
                    count = (count + this._parent.ComponentParameterUsage_ImplementationComponentType.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParentCompleteComponentTypes.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.ComponentParameterUsage_ImplementationComponentType.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParentCompleteComponentTypes.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.ComponentParameterUsage_ImplementationComponentType.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICompleteComponentType parentCompleteComponentTypesCasted = item.As<ICompleteComponentType>();
                if ((parentCompleteComponentTypesCasted != null))
                {
                    this._parent.ParentCompleteComponentTypes.Add(parentCompleteComponentTypesCasted);
                }
                IVariableUsage componentParameterUsage_ImplementationComponentTypeCasted = item.As<IVariableUsage>();
                if ((componentParameterUsage_ImplementationComponentTypeCasted != null))
                {
                    this._parent.ComponentParameterUsage_ImplementationComponentType.Add(componentParameterUsage_ImplementationComponentTypeCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ParentCompleteComponentTypes.Clear();
                this._parent.ComponentParameterUsage_ImplementationComponentType.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ParentCompleteComponentTypes.Contains(item))
                {
                    return true;
                }
                if (this._parent.ComponentParameterUsage_ImplementationComponentType.Contains(item))
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
                IEnumerator<IModelElement> parentCompleteComponentTypesEnumerator = this._parent.ParentCompleteComponentTypes.GetEnumerator();
                try
                {
                    for (
                    ; parentCompleteComponentTypesEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parentCompleteComponentTypesEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parentCompleteComponentTypesEnumerator.Dispose();
                }
                IEnumerator<IModelElement> componentParameterUsage_ImplementationComponentTypeEnumerator = this._parent.ComponentParameterUsage_ImplementationComponentType.GetEnumerator();
                try
                {
                    for (
                    ; componentParameterUsage_ImplementationComponentTypeEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = componentParameterUsage_ImplementationComponentTypeEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    componentParameterUsage_ImplementationComponentTypeEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                ICompleteComponentType completeComponentTypeItem = item.As<ICompleteComponentType>();
                if (((completeComponentTypeItem != null) 
                            && this._parent.ParentCompleteComponentTypes.Remove(completeComponentTypeItem)))
                {
                    return true;
                }
                IVariableUsage variableUsageItem = item.As<IVariableUsage>();
                if (((variableUsageItem != null) 
                            && this._parent.ComponentParameterUsage_ImplementationComponentType.Remove(variableUsageItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ParentCompleteComponentTypes).Concat(this._parent.ComponentParameterUsage_ImplementationComponentType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the componentType property
        /// </summary>
        private sealed class ComponentTypeProxy : ModelPropertyChange<IImplementationComponentType, ComponentType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ComponentTypeProxy(IImplementationComponentType modelElement) : 
                    base(modelElement, "componentType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ComponentType Value
            {
                get
                {
                    return this.ModelElement.ComponentType;
                }
                set
                {
                    this.ModelElement.ComponentType = value;
                }
            }
        }
    }
}

