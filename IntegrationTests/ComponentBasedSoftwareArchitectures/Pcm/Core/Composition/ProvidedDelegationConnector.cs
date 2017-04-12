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
    /// The default implementation of the ProvidedDelegationConnector class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Core/Composition/5.0")]
    [XmlNamespacePrefixAttribute("composition")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/ProvidedDeleg" +
        "ationConnector")]
    [DebuggerDisplayAttribute("ProvidedDelegationConnector {Id}")]
    public partial class ProvidedDelegationConnector : DelegationConnector, IProvidedDelegationConnector, IModelElement
    {
        
        private static Lazy<ITypedElement> _innerProvidedRole_ProvidedDelegationConnectorReference = new Lazy<ITypedElement>(RetrieveInnerProvidedRole_ProvidedDelegationConnectorReference);
        
        /// <summary>
        /// The backing field for the InnerProvidedRole_ProvidedDelegationConnector property
        /// </summary>
        private IOperationProvidedRole _innerProvidedRole_ProvidedDelegationConnector;
        
        private static Lazy<ITypedElement> _outerProvidedRole_ProvidedDelegationConnectorReference = new Lazy<ITypedElement>(RetrieveOuterProvidedRole_ProvidedDelegationConnectorReference);
        
        /// <summary>
        /// The backing field for the OuterProvidedRole_ProvidedDelegationConnector property
        /// </summary>
        private IOperationProvidedRole _outerProvidedRole_ProvidedDelegationConnector;
        
        private static Lazy<ITypedElement> _assemblyContext_ProvidedDelegationConnectorReference = new Lazy<ITypedElement>(RetrieveAssemblyContext_ProvidedDelegationConnectorReference);
        
        /// <summary>
        /// The backing field for the AssemblyContext_ProvidedDelegationConnector property
        /// </summary>
        private IAssemblyContext _assemblyContext_ProvidedDelegationConnector;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The innerProvidedRole_ProvidedDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("innerProvidedRole_ProvidedDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public IOperationProvidedRole InnerProvidedRole_ProvidedDelegationConnector
        {
            get
            {
                return this._innerProvidedRole_ProvidedDelegationConnector;
            }
            set
            {
                if ((this._innerProvidedRole_ProvidedDelegationConnector != value))
                {
                    IOperationProvidedRole old = this._innerProvidedRole_ProvidedDelegationConnector;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnInnerProvidedRole_ProvidedDelegationConnectorChanging(e);
                    this.OnPropertyChanging("InnerProvidedRole_ProvidedDelegationConnector", e, _innerProvidedRole_ProvidedDelegationConnectorReference);
                    this._innerProvidedRole_ProvidedDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetInnerProvidedRole_ProvidedDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetInnerProvidedRole_ProvidedDelegationConnector;
                    }
                    this.OnInnerProvidedRole_ProvidedDelegationConnectorChanged(e);
                    this.OnPropertyChanged("InnerProvidedRole_ProvidedDelegationConnector", e, _innerProvidedRole_ProvidedDelegationConnectorReference);
                }
            }
        }
        
        /// <summary>
        /// The outerProvidedRole_ProvidedDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("outerProvidedRole_ProvidedDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public IOperationProvidedRole OuterProvidedRole_ProvidedDelegationConnector
        {
            get
            {
                return this._outerProvidedRole_ProvidedDelegationConnector;
            }
            set
            {
                if ((this._outerProvidedRole_ProvidedDelegationConnector != value))
                {
                    IOperationProvidedRole old = this._outerProvidedRole_ProvidedDelegationConnector;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnOuterProvidedRole_ProvidedDelegationConnectorChanging(e);
                    this.OnPropertyChanging("OuterProvidedRole_ProvidedDelegationConnector", e, _outerProvidedRole_ProvidedDelegationConnectorReference);
                    this._outerProvidedRole_ProvidedDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetOuterProvidedRole_ProvidedDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetOuterProvidedRole_ProvidedDelegationConnector;
                    }
                    this.OnOuterProvidedRole_ProvidedDelegationConnectorChanged(e);
                    this.OnPropertyChanged("OuterProvidedRole_ProvidedDelegationConnector", e, _outerProvidedRole_ProvidedDelegationConnectorReference);
                }
            }
        }
        
        /// <summary>
        /// The assemblyContext_ProvidedDelegationConnector property
        /// </summary>
        [XmlElementNameAttribute("assemblyContext_ProvidedDelegationConnector")]
        [XmlAttributeAttribute(true)]
        public IAssemblyContext AssemblyContext_ProvidedDelegationConnector
        {
            get
            {
                return this._assemblyContext_ProvidedDelegationConnector;
            }
            set
            {
                if ((this._assemblyContext_ProvidedDelegationConnector != value))
                {
                    IAssemblyContext old = this._assemblyContext_ProvidedDelegationConnector;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnAssemblyContext_ProvidedDelegationConnectorChanging(e);
                    this.OnPropertyChanging("AssemblyContext_ProvidedDelegationConnector", e, _assemblyContext_ProvidedDelegationConnectorReference);
                    this._assemblyContext_ProvidedDelegationConnector = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetAssemblyContext_ProvidedDelegationConnector;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetAssemblyContext_ProvidedDelegationConnector;
                    }
                    this.OnAssemblyContext_ProvidedDelegationConnectorChanged(e);
                    this.OnPropertyChanged("AssemblyContext_ProvidedDelegationConnector", e, _assemblyContext_ProvidedDelegationConnectorReference);
                }
            }
        }
        
        /// <summary>
        /// Gets the referenced model elements of this model element
        /// </summary>
        public override IEnumerableExpression<IModelElement> ReferencedElements
        {
            get
            {
                return base.ReferencedElements.Concat(new ProvidedDelegationConnectorReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/ProvidedDeleg" +
                            "ationConnector")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the InnerProvidedRole_ProvidedDelegationConnector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerProvidedRole_ProvidedDelegationConnectorChanging;
        
        /// <summary>
        /// Gets fired when the InnerProvidedRole_ProvidedDelegationConnector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> InnerProvidedRole_ProvidedDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired before the OuterProvidedRole_ProvidedDelegationConnector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> OuterProvidedRole_ProvidedDelegationConnectorChanging;
        
        /// <summary>
        /// Gets fired when the OuterProvidedRole_ProvidedDelegationConnector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> OuterProvidedRole_ProvidedDelegationConnectorChanged;
        
        /// <summary>
        /// Gets fired before the AssemblyContext_ProvidedDelegationConnector property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> AssemblyContext_ProvidedDelegationConnectorChanging;
        
        /// <summary>
        /// Gets fired when the AssemblyContext_ProvidedDelegationConnector property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> AssemblyContext_ProvidedDelegationConnectorChanged;
        
        private static ITypedElement RetrieveInnerProvidedRole_ProvidedDelegationConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.ProvidedDelegationConnector.ClassInstance)).Resolve("innerProvidedRole_ProvidedDelegationConnector")));
        }
        
        /// <summary>
        /// Raises the InnerProvidedRole_ProvidedDelegationConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerProvidedRole_ProvidedDelegationConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerProvidedRole_ProvidedDelegationConnectorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the InnerProvidedRole_ProvidedDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnInnerProvidedRole_ProvidedDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.InnerProvidedRole_ProvidedDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the InnerProvidedRole_ProvidedDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetInnerProvidedRole_ProvidedDelegationConnector(object sender, global::System.EventArgs eventArgs)
        {
            this.InnerProvidedRole_ProvidedDelegationConnector = null;
        }
        
        private static ITypedElement RetrieveOuterProvidedRole_ProvidedDelegationConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.ProvidedDelegationConnector.ClassInstance)).Resolve("outerProvidedRole_ProvidedDelegationConnector")));
        }
        
        /// <summary>
        /// Raises the OuterProvidedRole_ProvidedDelegationConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOuterProvidedRole_ProvidedDelegationConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.OuterProvidedRole_ProvidedDelegationConnectorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the OuterProvidedRole_ProvidedDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnOuterProvidedRole_ProvidedDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.OuterProvidedRole_ProvidedDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the OuterProvidedRole_ProvidedDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetOuterProvidedRole_ProvidedDelegationConnector(object sender, global::System.EventArgs eventArgs)
        {
            this.OuterProvidedRole_ProvidedDelegationConnector = null;
        }
        
        private static ITypedElement RetrieveAssemblyContext_ProvidedDelegationConnectorReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Core.Composition.ProvidedDelegationConnector.ClassInstance)).Resolve("assemblyContext_ProvidedDelegationConnector")));
        }
        
        /// <summary>
        /// Raises the AssemblyContext_ProvidedDelegationConnectorChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext_ProvidedDelegationConnectorChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext_ProvidedDelegationConnectorChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the AssemblyContext_ProvidedDelegationConnectorChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnAssemblyContext_ProvidedDelegationConnectorChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.AssemblyContext_ProvidedDelegationConnectorChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the AssemblyContext_ProvidedDelegationConnector property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetAssemblyContext_ProvidedDelegationConnector(object sender, global::System.EventArgs eventArgs)
        {
            this.AssemblyContext_ProvidedDelegationConnector = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "INNERPROVIDEDROLE_PROVIDEDDELEGATIONCONNECTOR"))
            {
                this.InnerProvidedRole_ProvidedDelegationConnector = ((IOperationProvidedRole)(value));
                return;
            }
            if ((feature == "OUTERPROVIDEDROLE_PROVIDEDDELEGATIONCONNECTOR"))
            {
                this.OuterProvidedRole_ProvidedDelegationConnector = ((IOperationProvidedRole)(value));
                return;
            }
            if ((feature == "ASSEMBLYCONTEXT_PROVIDEDDELEGATIONCONNECTOR"))
            {
                this.AssemblyContext_ProvidedDelegationConnector = ((IAssemblyContext)(value));
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
            if ((attribute == "InnerProvidedRole_ProvidedDelegationConnector"))
            {
                return new InnerProvidedRole_ProvidedDelegationConnectorProxy(this);
            }
            if ((attribute == "OuterProvidedRole_ProvidedDelegationConnector"))
            {
                return new OuterProvidedRole_ProvidedDelegationConnectorProxy(this);
            }
            if ((attribute == "AssemblyContext_ProvidedDelegationConnector"))
            {
                return new AssemblyContext_ProvidedDelegationConnectorProxy(this);
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
            if ((reference == "InnerProvidedRole_ProvidedDelegationConnector"))
            {
                return new InnerProvidedRole_ProvidedDelegationConnectorProxy(this);
            }
            if ((reference == "OuterProvidedRole_ProvidedDelegationConnector"))
            {
                return new OuterProvidedRole_ProvidedDelegationConnectorProxy(this);
            }
            if ((reference == "AssemblyContext_ProvidedDelegationConnector"))
            {
                return new AssemblyContext_ProvidedDelegationConnectorProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//core/composition/ProvidedDeleg" +
                        "ationConnector")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProvidedDelegationConnector class
        /// </summary>
        public class ProvidedDelegationConnectorReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProvidedDelegationConnector _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProvidedDelegationConnectorReferencedElementsCollection(ProvidedDelegationConnector parent)
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
                    if ((this._parent.InnerProvidedRole_ProvidedDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.OuterProvidedRole_ProvidedDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.AssemblyContext_ProvidedDelegationConnector != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.InnerProvidedRole_ProvidedDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.OuterProvidedRole_ProvidedDelegationConnectorChanged += this.PropagateValueChanges;
                this._parent.AssemblyContext_ProvidedDelegationConnectorChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.InnerProvidedRole_ProvidedDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.OuterProvidedRole_ProvidedDelegationConnectorChanged -= this.PropagateValueChanges;
                this._parent.AssemblyContext_ProvidedDelegationConnectorChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.InnerProvidedRole_ProvidedDelegationConnector == null))
                {
                    IOperationProvidedRole innerProvidedRole_ProvidedDelegationConnectorCasted = item.As<IOperationProvidedRole>();
                    if ((innerProvidedRole_ProvidedDelegationConnectorCasted != null))
                    {
                        this._parent.InnerProvidedRole_ProvidedDelegationConnector = innerProvidedRole_ProvidedDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.OuterProvidedRole_ProvidedDelegationConnector == null))
                {
                    IOperationProvidedRole outerProvidedRole_ProvidedDelegationConnectorCasted = item.As<IOperationProvidedRole>();
                    if ((outerProvidedRole_ProvidedDelegationConnectorCasted != null))
                    {
                        this._parent.OuterProvidedRole_ProvidedDelegationConnector = outerProvidedRole_ProvidedDelegationConnectorCasted;
                        return;
                    }
                }
                if ((this._parent.AssemblyContext_ProvidedDelegationConnector == null))
                {
                    IAssemblyContext assemblyContext_ProvidedDelegationConnectorCasted = item.As<IAssemblyContext>();
                    if ((assemblyContext_ProvidedDelegationConnectorCasted != null))
                    {
                        this._parent.AssemblyContext_ProvidedDelegationConnector = assemblyContext_ProvidedDelegationConnectorCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.InnerProvidedRole_ProvidedDelegationConnector = null;
                this._parent.OuterProvidedRole_ProvidedDelegationConnector = null;
                this._parent.AssemblyContext_ProvidedDelegationConnector = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.InnerProvidedRole_ProvidedDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.OuterProvidedRole_ProvidedDelegationConnector))
                {
                    return true;
                }
                if ((item == this._parent.AssemblyContext_ProvidedDelegationConnector))
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
                if ((this._parent.InnerProvidedRole_ProvidedDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.InnerProvidedRole_ProvidedDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.OuterProvidedRole_ProvidedDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.OuterProvidedRole_ProvidedDelegationConnector;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.AssemblyContext_ProvidedDelegationConnector != null))
                {
                    array[arrayIndex] = this._parent.AssemblyContext_ProvidedDelegationConnector;
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
                if ((this._parent.InnerProvidedRole_ProvidedDelegationConnector == item))
                {
                    this._parent.InnerProvidedRole_ProvidedDelegationConnector = null;
                    return true;
                }
                if ((this._parent.OuterProvidedRole_ProvidedDelegationConnector == item))
                {
                    this._parent.OuterProvidedRole_ProvidedDelegationConnector = null;
                    return true;
                }
                if ((this._parent.AssemblyContext_ProvidedDelegationConnector == item))
                {
                    this._parent.AssemblyContext_ProvidedDelegationConnector = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.InnerProvidedRole_ProvidedDelegationConnector).Concat(this._parent.OuterProvidedRole_ProvidedDelegationConnector).Concat(this._parent.AssemblyContext_ProvidedDelegationConnector).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the innerProvidedRole_ProvidedDelegationConnector property
        /// </summary>
        private sealed class InnerProvidedRole_ProvidedDelegationConnectorProxy : ModelPropertyChange<IProvidedDelegationConnector, IOperationProvidedRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public InnerProvidedRole_ProvidedDelegationConnectorProxy(IProvidedDelegationConnector modelElement) : 
                    base(modelElement, "innerProvidedRole_ProvidedDelegationConnector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperationProvidedRole Value
            {
                get
                {
                    return this.ModelElement.InnerProvidedRole_ProvidedDelegationConnector;
                }
                set
                {
                    this.ModelElement.InnerProvidedRole_ProvidedDelegationConnector = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the outerProvidedRole_ProvidedDelegationConnector property
        /// </summary>
        private sealed class OuterProvidedRole_ProvidedDelegationConnectorProxy : ModelPropertyChange<IProvidedDelegationConnector, IOperationProvidedRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public OuterProvidedRole_ProvidedDelegationConnectorProxy(IProvidedDelegationConnector modelElement) : 
                    base(modelElement, "outerProvidedRole_ProvidedDelegationConnector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IOperationProvidedRole Value
            {
                get
                {
                    return this.ModelElement.OuterProvidedRole_ProvidedDelegationConnector;
                }
                set
                {
                    this.ModelElement.OuterProvidedRole_ProvidedDelegationConnector = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the assemblyContext_ProvidedDelegationConnector property
        /// </summary>
        private sealed class AssemblyContext_ProvidedDelegationConnectorProxy : ModelPropertyChange<IProvidedDelegationConnector, IAssemblyContext>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public AssemblyContext_ProvidedDelegationConnectorProxy(IProvidedDelegationConnector modelElement) : 
                    base(modelElement, "assemblyContext_ProvidedDelegationConnector")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IAssemblyContext Value
            {
                get
                {
                    return this.ModelElement.AssemblyContext_ProvidedDelegationConnector;
                }
                set
                {
                    this.ModelElement.AssemblyContext_ProvidedDelegationConnector = value;
                }
            }
        }
    }
}

