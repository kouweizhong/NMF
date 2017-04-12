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

namespace NMFExamples.Pcm.Core.Composition
{
    
    
    /// <summary>
    /// The default implementation of the Connector class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/Connector")]
    [DebuggerDisplayAttribute("Connector {Id}")]
    public abstract partial class Connector : NMFExamples.Pcm.Core.Entity.Entity, IConnector, IModelElement
    {
        
        private static Lazy<ITypedElement> _parentStructure__ConnectorReference = new Lazy<ITypedElement>(RetrieveParentStructure__ConnectorReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The parentStructure__Connector property
        /// </summary>
        [XmlElementNameAttribute("parentStructure__Connector")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("connectors__ComposedStructure")]
        public IComposedStructure ParentStructure__Connector
        {
            get
            {
                return ModelHelper.CastAs<IComposedStructure>(this.Parent);
            }
            set
            {
                this.Parent = value;
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ConnectorReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/Connector")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ParentStructure__Connector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ParentStructure__ConnectorChanging;
        
        /// <summary>
        /// Gets fired when the ParentStructure__Connector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ParentStructure__ConnectorChanged;
        
        private static ITypedElement RetrieveParentStructure__ConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.Connector.ClassInstance)).Resolve("parentStructure__Connector")));
        }
        
        /// <summary>
        /// Raises the ParentStructure__ConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure__ConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ParentStructure__ConnectorChanging;
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
            IComposedStructure oldParentStructure__Connector = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure__Connector = ModelHelper.CastAs<IComposedStructure>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure__Connector, newParentStructure__Connector);
            this.OnParentStructure__ConnectorChanging(e);
            this.OnPropertyChanging("ParentStructure__Connector", e, _parentStructure__ConnectorReference);
        }
        
        /// <summary>
        /// Raises the ParentStructure__ConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnParentStructure__ConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ParentStructure__ConnectorChanged;
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
            IComposedStructure oldParentStructure__Connector = ModelHelper.CastAs<IComposedStructure>(oldParent);
            IComposedStructure newParentStructure__Connector = ModelHelper.CastAs<IComposedStructure>(newParent);
            if ((oldParentStructure__Connector != null))
            {
                oldParentStructure__Connector.Connectors__ComposedStructure.Remove(this);
            }
            if ((newParentStructure__Connector != null))
            {
                newParentStructure__Connector.Connectors__ComposedStructure.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldParentStructure__Connector, newParentStructure__Connector);
            this.OnParentStructure__ConnectorChanged(e);
            this.OnPropertyChanged("ParentStructure__Connector", e, _parentStructure__ConnectorReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PARENTSTRUCTURE__CONNECTOR"))
            {
                this.ParentStructure__Connector = ((IComposedStructure)(value));
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
            if ((attribute == "ParentStructure__Connector"))
            {
                return new ParentStructure__ConnectorProxy(this);
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
            if ((reference == "ParentStructure__Connector"))
            {
                return new ParentStructure__ConnectorProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/Connector")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the Connector class
        /// </summary>
        public class ConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private Connector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ConnectorReferencedElementsCollection(Connector parent)
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
                    if ((this._parent.ParentStructure__Connector != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ParentStructure__ConnectorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ParentStructure__ConnectorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ParentStructure__Connector == null))
                {
                    IComposedStructure parentStructure__ConnectorCasted = item.As<IComposedStructure>();
                    if ((parentStructure__ConnectorCasted != null))
                    {
                        this._parent.ParentStructure__Connector = parentStructure__ConnectorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ParentStructure__Connector = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ParentStructure__Connector))
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
                if ((this._parent.ParentStructure__Connector != null))
                {
                    array[arrayIndex] = this._parent.ParentStructure__Connector;
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
                if ((this._parent.ParentStructure__Connector == item))
                {
                    this._parent.ParentStructure__Connector = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ParentStructure__Connector).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the parentStructure__Connector property
        /// </summary>
        private sealed class ParentStructure__ConnectorProxy : ModelPropertyChange<IConnector, IComposedStructure>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ParentStructure__ConnectorProxy(IConnector modelElement) : 
                    base(modelElement, "parentStructure__Connector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IComposedStructure Value
            {
                get
                {
                    return this.ModelElement.ParentStructure__Connector;
                }
                set
                {
                    this.ModelElement.ParentStructure__Connector = value;
                }
            }
        }
    }
}

