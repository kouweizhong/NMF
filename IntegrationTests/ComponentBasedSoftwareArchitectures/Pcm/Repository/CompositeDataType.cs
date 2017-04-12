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
    /// The default implementation of the CompositeDataType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/CompositeDataType")]
    [DebuggerDisplayAttribute("CompositeDataType {Id}")]
    public partial class CompositeDataType : NMFExamples.Pcm.Core.Entity.Entity, ICompositeDataType, IModelElement
    {
        
        private static Lazy<ITypedElement> _parentType_CompositeDataTypeReference = new Lazy<ITypedElement>(RetrieveParentType_CompositeDataTypeReference);
        
        /// <summary>
        /// The backing field for the ParentType_CompositeDataType property
        /// </summary>
        private ObservableAssociationList<ICompositeDataType> _parentType_CompositeDataType;
        
        private static Lazy<ITypedElement> _innerDeclaration_CompositeDataTypeReference = new Lazy<ITypedElement>(RetrieveInnerDeclaration_CompositeDataTypeReference);
        
        /// <summary>
        /// The backing field for the InnerDeclaration_CompositeDataType property
        /// </summary>
        private CompositeDataTypeInnerDeclaration_CompositeDataTypeCollection _innerDeclaration_CompositeDataType;
        
        private static Lazy<ITypedElement> _repository__DataTypeReference = new Lazy<ITypedElement>(RetrieveRepository__DataTypeReference);
        
        private static IClass _classInstance;
        
        public CompositeDataType()
        {
            this._parentType_CompositeDataType = new ObservableAssociationList<ICompositeDataType>();
            this._parentType_CompositeDataType.CollectionChanging += this.ParentType_CompositeDataTypeCollectionChanging;
            this._parentType_CompositeDataType.CollectionChanged += this.ParentType_CompositeDataTypeCollectionChanged;
            this._innerDeclaration_CompositeDataType = new CompositeDataTypeInnerDeclaration_CompositeDataTypeCollection(this);
            this._innerDeclaration_CompositeDataType.CollectionChanging += this.InnerDeclaration_CompositeDataTypeCollectionChanging;
            this._innerDeclaration_CompositeDataType.CollectionChanged += this.InnerDeclaration_CompositeDataTypeCollectionChanged;
        }
        
        /// <summary>
        /// The parentType_CompositeDataType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("parentType_CompositeDataType")]
        [XmlAttributeAttribute(true)]
        [ConstantAttribute()]
        public ICollectionExpression<ICompositeDataType> ParentType_CompositeDataType
        {
            get
            {
                return this._parentType_CompositeDataType;
            }
        }
        
        /// <summary>
        /// The innerDeclaration_CompositeDataType property
        /// </summary>
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
        [XmlElementNameAttribute("innerDeclaration_CompositeDataType")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("compositeDataType_InnerDeclaration")]
        [ConstantAttribute()]
        public IListExpression<IInnerDeclaration> InnerDeclaration_CompositeDataType
        {
            get
            {
                return this._innerDeclaration_CompositeDataType;
            }
        }
        
        /// <summary>
        /// The repository__DataType property
        /// </summary>
        [XmlElementNameAttribute("repository__DataType")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("dataTypes__Repository")]
        public IRepository Repository__DataType
        {
            get
            {
                return ModelHelper.CastAs<IRepository>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the child model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> Children
        {
            get
            {
                return base.Children.Concat(new CompositeDataTypeChildrenCollection(this));
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new CompositeDataTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/CompositeDataType")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Repository__DataType property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Repository__DataTypeChanging;
        
        /// <summary>
        /// Gets fired when the Repository__DataType property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Repository__DataTypeChanged;
        
        private static ITypedElement RetrieveParentType_CompositeDataTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.CompositeDataType.ClassInstance)).Resolve("parentType_CompositeDataType")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the ParentType_CompositeDataType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentType_CompositeDataTypeCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("ParentType_CompositeDataType", e, _parentType_CompositeDataTypeReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the ParentType_CompositeDataType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void ParentType_CompositeDataTypeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("ParentType_CompositeDataType", e, _parentType_CompositeDataTypeReference);
        }
        
        private static ITypedElement RetrieveInnerDeclaration_CompositeDataTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.CompositeDataType.ClassInstance)).Resolve("innerDeclaration_CompositeDataType")));
        }
        
        /// <summary>
        /// Forwards CollectionChanging notifications for the InnerDeclaration_CompositeDataType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InnerDeclaration_CompositeDataTypeCollectionChanging(object sender, NotifyCollectionChangingEventArgs e)
        {
            this.OnCollectionChanging("InnerDeclaration_CompositeDataType", e, _innerDeclaration_CompositeDataTypeReference);
        }
        
        /// <summary>
        /// Forwards CollectionChanged notifications for the InnerDeclaration_CompositeDataType property to the parent model element
        /// </summary>
        /// <param name="sender">The collection that raised the change</param>
        /// <param name="e">The original event data</param>
        private void InnerDeclaration_CompositeDataTypeCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            this.OnCollectionChanged("InnerDeclaration_CompositeDataType", e, _innerDeclaration_CompositeDataTypeReference);
        }
        
        private static ITypedElement RetrieveRepository__DataTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.DataType.ClassInstance)).Resolve("repository__DataType")));
        }
        
        /// <summary>
        /// Raises the Repository__DataTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__DataTypeChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Repository__DataTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Gets called when the parent model element of the current model element is about to change
        /// </summary>
        /// <param name="oldParent">The old parent model element</param>
        /// <param name="newParent">The new parent model element</param>
        protected override void OnParentChanging(IModelElement newParent, IModelElement oldParent)
        {
            IRepository oldRepository__DataType = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__DataType = ModelHelper.CastAs<IRepository>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__DataType, newRepository__DataType);
            this.OnRepository__DataTypeChanging(e);
            this.OnPropertyChanging("Repository__DataType", e, _repository__DataTypeReference);
        }
        
        /// <summary>
        /// Raises the Repository__DataTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRepository__DataTypeChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Repository__DataTypeChanged;
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
            IRepository oldRepository__DataType = ModelHelper.CastAs<IRepository>(oldParent);
            IRepository newRepository__DataType = ModelHelper.CastAs<IRepository>(newParent);
            if ((oldRepository__DataType != null))
            {
                oldRepository__DataType.DataTypes__Repository.Remove(this);
            }
            if ((newRepository__DataType != null))
            {
                newRepository__DataType.DataTypes__Repository.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldRepository__DataType, newRepository__DataType);
            this.OnRepository__DataTypeChanged(e);
            this.OnPropertyChanged("Repository__DataType", e, _repository__DataTypeReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Gets the relative URI fragment for the given child model element
        /// </summary>
        /// <returns>A fragment of the relative URI</returns>
        /// <param name="element">The element that should be looked for</param>
        protected override string GetRelativePathForNonIdentifiedChild(IModelElement element)
        {
            int innerDeclaration_CompositeDataTypeIndex = ModelHelper.IndexOfReference(this.InnerDeclaration_CompositeDataType, element);
            if ((innerDeclaration_CompositeDataTypeIndex != -1))
            {
                return ModelHelper.CreatePath("innerDeclaration_CompositeDataType", innerDeclaration_CompositeDataTypeIndex);
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
            if ((reference == "INNERDECLARATION_COMPOSITEDATATYPE"))
            {
                if ((index < this.InnerDeclaration_CompositeDataType.Count))
                {
                    return this.InnerDeclaration_CompositeDataType[index];
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
            if ((feature == "PARENTTYPE_COMPOSITEDATATYPE"))
            {
                return this._parentType_CompositeDataType;
            }
            if ((feature == "INNERDECLARATION_COMPOSITEDATATYPE"))
            {
                return this._innerDeclaration_CompositeDataType;
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
            if ((feature == "REPOSITORY__DATATYPE"))
            {
                this.Repository__DataType = ((IRepository)(value));
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
            if ((attribute == "Repository__DataType"))
            {
                return new Repository__DataTypeProxy(this);
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
            if ((reference == "Repository__DataType"))
            {
                return new Repository__DataTypeProxy(this);
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
            if ((container == this._innerDeclaration_CompositeDataType))
            {
                return "innerDeclaration_CompositeDataType";
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/CompositeDataType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompositeDataType class
        /// </summary>
        public class CompositeDataTypeChildrenCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CompositeDataType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompositeDataTypeChildrenCollection(CompositeDataType parent)
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
                    count = (count + this._parent.InnerDeclaration_CompositeDataType.Count);
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerDeclaration_CompositeDataType.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerDeclaration_CompositeDataType.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                IInnerDeclaration innerDeclaration_CompositeDataTypeCasted = item.As<IInnerDeclaration>();
                if ((innerDeclaration_CompositeDataTypeCasted != null))
                {
                    this._parent.InnerDeclaration_CompositeDataType.Add(innerDeclaration_CompositeDataTypeCasted);
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerDeclaration_CompositeDataType.Clear();
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.InnerDeclaration_CompositeDataType.Contains(item))
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
                IEnumerator<IModelElement> innerDeclaration_CompositeDataTypeEnumerator = this._parent.InnerDeclaration_CompositeDataType.GetEnumerator();
                try
                {
                    for (
                    ; innerDeclaration_CompositeDataTypeEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = innerDeclaration_CompositeDataTypeEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    innerDeclaration_CompositeDataTypeEnumerator.Dispose();
                }
            }
            
            /// <summary>
            /// Removes the given item from the collection
            /// </summary>
            /// <returns>True, if the item was removed, otherwise False</returns>
            /// <param name="item">The item that should be removed</param>
            public override bool Remove(IModelElement item)
            {
                IInnerDeclaration innerDeclarationItem = item.As<IInnerDeclaration>();
                if (((innerDeclarationItem != null) 
                            && this._parent.InnerDeclaration_CompositeDataType.Remove(innerDeclarationItem)))
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerDeclaration_CompositeDataType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// The collection class to to represent the children of the CompositeDataType class
        /// </summary>
        public class CompositeDataTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private CompositeDataType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public CompositeDataTypeReferencedElementsCollection(CompositeDataType parent)
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
                    count = (count + this._parent.ParentType_CompositeDataType.Count);
                    count = (count + this._parent.InnerDeclaration_CompositeDataType.Count);
                    if ((this._parent.Repository__DataType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParentType_CompositeDataType.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.InnerDeclaration_CompositeDataType.AsNotifiable().CollectionChanged += this.PropagateCollectionChanges;
                this._parent.Repository__DataTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParentType_CompositeDataType.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.InnerDeclaration_CompositeDataType.AsNotifiable().CollectionChanged -= this.PropagateCollectionChanges;
                this._parent.Repository__DataTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                ICompositeDataType parentType_CompositeDataTypeCasted = item.As<ICompositeDataType>();
                if ((parentType_CompositeDataTypeCasted != null))
                {
                    this._parent.ParentType_CompositeDataType.Add(parentType_CompositeDataTypeCasted);
                }
                IInnerDeclaration innerDeclaration_CompositeDataTypeCasted = item.As<IInnerDeclaration>();
                if ((innerDeclaration_CompositeDataTypeCasted != null))
                {
                    this._parent.InnerDeclaration_CompositeDataType.Add(innerDeclaration_CompositeDataTypeCasted);
                }
                if ((this._parent.Repository__DataType == null))
                {
                    IRepository repository__DataTypeCasted = item.As<IRepository>();
                    if ((repository__DataTypeCasted != null))
                    {
                        this._parent.Repository__DataType = repository__DataTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ParentType_CompositeDataType.Clear();
                this._parent.InnerDeclaration_CompositeDataType.Clear();
                this._parent.Repository__DataType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if (this._parent.ParentType_CompositeDataType.Contains(item))
                {
                    return true;
                }
                if (this._parent.InnerDeclaration_CompositeDataType.Contains(item))
                {
                    return true;
                }
                if ((item == this._parent.Repository__DataType))
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
                IEnumerator<IModelElement> parentType_CompositeDataTypeEnumerator = this._parent.ParentType_CompositeDataType.GetEnumerator();
                try
                {
                    for (
                    ; parentType_CompositeDataTypeEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = parentType_CompositeDataTypeEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    parentType_CompositeDataTypeEnumerator.Dispose();
                }
                IEnumerator<IModelElement> innerDeclaration_CompositeDataTypeEnumerator = this._parent.InnerDeclaration_CompositeDataType.GetEnumerator();
                try
                {
                    for (
                    ; innerDeclaration_CompositeDataTypeEnumerator.MoveNext(); 
                    )
                    {
                        array[arrayIndex] = innerDeclaration_CompositeDataTypeEnumerator.Current;
                        arrayIndex = (arrayIndex + 1);
                    }
                }
                finally
                {
                    innerDeclaration_CompositeDataTypeEnumerator.Dispose();
                }
                if ((this._parent.Repository__DataType != null))
                {
                    array[arrayIndex] = this._parent.Repository__DataType;
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
                ICompositeDataType compositeDataTypeItem = item.As<ICompositeDataType>();
                if (((compositeDataTypeItem != null) 
                            && this._parent.ParentType_CompositeDataType.Remove(compositeDataTypeItem)))
                {
                    return true;
                }
                IInnerDeclaration innerDeclarationItem = item.As<IInnerDeclaration>();
                if (((innerDeclarationItem != null) 
                            && this._parent.InnerDeclaration_CompositeDataType.Remove(innerDeclarationItem)))
                {
                    return true;
                }
                if ((this._parent.Repository__DataType == item))
                {
                    this._parent.Repository__DataType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ParentType_CompositeDataType).Concat(this._parent.InnerDeclaration_CompositeDataType).Concat(this._parent.Repository__DataType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the repository__DataType property
        /// </summary>
        private sealed class Repository__DataTypeProxy : ModelPropertyChange<IDataType, IRepository>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Repository__DataTypeProxy(IDataType modelElement) : 
                    base(modelElement, "repository__DataType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRepository Value
            {
                get
                {
                    return this.ModelElement.Repository__DataType;
                }
                set
                {
                    this.ModelElement.Repository__DataType = value;
                }
            }
        }
    }
}

