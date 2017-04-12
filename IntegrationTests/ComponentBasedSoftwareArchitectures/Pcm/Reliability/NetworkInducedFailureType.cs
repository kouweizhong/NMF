//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Pcm.Core.Entity;
using NMFExamples.Pcm.Qosannotations.Qos_reliability;
using NMFExamples.Pcm.Repository;
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
using System.Linq;

namespace NMFExamples.Pcm.Reliability
{
    
    
    /// <summary>
    /// The default implementation of the NetworkInducedFailureType class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Reliability/5.0")]
    [XmlNamespacePrefixAttribute("reliability")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//reliability/NetworkInducedFail" +
        "ureType")]
    [DebuggerDisplayAttribute("NetworkInducedFailureType {Id}")]
    public partial class NetworkInducedFailureType : FailureType, INetworkInducedFailureType, IModelElement
    {
        
        private static Lazy<ITypedElement> _communicationLinkResourceType__NetworkInducedFailureTypeReference = new Lazy<ITypedElement>(RetrieveCommunicationLinkResourceType__NetworkInducedFailureTypeReference);
        
        /// <summary>
        /// The backing field for the CommunicationLinkResourceType__NetworkInducedFailureType property
        /// </summary>
        private ICommunicationLinkResourceType _communicationLinkResourceType__NetworkInducedFailureType;
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The communicationLinkResourceType__NetworkInducedFailureType property
        /// </summary>
        [XmlElementNameAttribute("communicationLinkResourceType__NetworkInducedFailureType")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("networkInducedFailureType__CommunicationLinkResourceType")]
        public ICommunicationLinkResourceType CommunicationLinkResourceType__NetworkInducedFailureType
        {
            get
            {
                return this._communicationLinkResourceType__NetworkInducedFailureType;
            }
            set
            {
                if ((this._communicationLinkResourceType__NetworkInducedFailureType != value))
                {
                    ICommunicationLinkResourceType old = this._communicationLinkResourceType__NetworkInducedFailureType;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnCommunicationLinkResourceType__NetworkInducedFailureTypeChanging(e);
                    this.OnPropertyChanging("CommunicationLinkResourceType__NetworkInducedFailureType", e, _communicationLinkResourceType__NetworkInducedFailureTypeReference);
                    this._communicationLinkResourceType__NetworkInducedFailureType = value;
                    if ((old != null))
                    {
                        old.NetworkInducedFailureType__CommunicationLinkResourceType = null;
                        old.Deleted -= this.OnResetCommunicationLinkResourceType__NetworkInducedFailureType;
                    }
                    if ((value != null))
                    {
                        value.NetworkInducedFailureType__CommunicationLinkResourceType = this;
                        value.Deleted += this.OnResetCommunicationLinkResourceType__NetworkInducedFailureType;
                    }
                    this.OnCommunicationLinkResourceType__NetworkInducedFailureTypeChanged(e);
                    this.OnPropertyChanged("CommunicationLinkResourceType__NetworkInducedFailureType", e, _communicationLinkResourceType__NetworkInducedFailureTypeReference);
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
                return base.ReferencedElements.Concat(new NetworkInducedFailureTypeReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//reliability/NetworkInducedFail" +
                            "ureType")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the CommunicationLinkResourceType__NetworkInducedFailureType property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> CommunicationLinkResourceType__NetworkInducedFailureTypeChanging;
        
        /// <summary>
        /// Gets fired when the CommunicationLinkResourceType__NetworkInducedFailureType property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> CommunicationLinkResourceType__NetworkInducedFailureTypeChanged;
        
        private static ITypedElement RetrieveCommunicationLinkResourceType__NetworkInducedFailureTypeReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Reliability.NetworkInducedFailureType.ClassInstance)).Resolve("communicationLinkResourceType__NetworkInducedFailureType")));
        }
        
        /// <summary>
        /// Raises the CommunicationLinkResourceType__NetworkInducedFailureTypeChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCommunicationLinkResourceType__NetworkInducedFailureTypeChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.CommunicationLinkResourceType__NetworkInducedFailureTypeChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the CommunicationLinkResourceType__NetworkInducedFailureTypeChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnCommunicationLinkResourceType__NetworkInducedFailureTypeChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.CommunicationLinkResourceType__NetworkInducedFailureTypeChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the CommunicationLinkResourceType__NetworkInducedFailureType property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetCommunicationLinkResourceType__NetworkInducedFailureType(object sender, global::System.EventArgs eventArgs)
        {
            this.CommunicationLinkResourceType__NetworkInducedFailureType = null;
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "COMMUNICATIONLINKRESOURCETYPE__NETWORKINDUCEDFAILURETYPE"))
            {
                this.CommunicationLinkResourceType__NetworkInducedFailureType = ((ICommunicationLinkResourceType)(value));
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
            if ((attribute == "CommunicationLinkResourceType__NetworkInducedFailureType"))
            {
                return new CommunicationLinkResourceType__NetworkInducedFailureTypeProxy(this);
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
            if ((reference == "CommunicationLinkResourceType__NetworkInducedFailureType"))
            {
                return new CommunicationLinkResourceType__NetworkInducedFailureTypeProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//reliability/NetworkInducedFail" +
                        "ureType")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the NetworkInducedFailureType class
        /// </summary>
        public class NetworkInducedFailureTypeReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private NetworkInducedFailureType _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public NetworkInducedFailureTypeReferencedElementsCollection(NetworkInducedFailureType parent)
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
                    if ((this._parent.CommunicationLinkResourceType__NetworkInducedFailureType != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.CommunicationLinkResourceType__NetworkInducedFailureTypeChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.CommunicationLinkResourceType__NetworkInducedFailureTypeChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.CommunicationLinkResourceType__NetworkInducedFailureType == null))
                {
                    ICommunicationLinkResourceType communicationLinkResourceType__NetworkInducedFailureTypeCasted = item.As<ICommunicationLinkResourceType>();
                    if ((communicationLinkResourceType__NetworkInducedFailureTypeCasted != null))
                    {
                        this._parent.CommunicationLinkResourceType__NetworkInducedFailureType = communicationLinkResourceType__NetworkInducedFailureTypeCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.CommunicationLinkResourceType__NetworkInducedFailureType = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.CommunicationLinkResourceType__NetworkInducedFailureType))
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
                if ((this._parent.CommunicationLinkResourceType__NetworkInducedFailureType != null))
                {
                    array[arrayIndex] = this._parent.CommunicationLinkResourceType__NetworkInducedFailureType;
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
                if ((this._parent.CommunicationLinkResourceType__NetworkInducedFailureType == item))
                {
                    this._parent.CommunicationLinkResourceType__NetworkInducedFailureType = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.CommunicationLinkResourceType__NetworkInducedFailureType).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the communicationLinkResourceType__NetworkInducedFailureType property
        /// </summary>
        private sealed class CommunicationLinkResourceType__NetworkInducedFailureTypeProxy : ModelPropertyChange<INetworkInducedFailureType, ICommunicationLinkResourceType>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public CommunicationLinkResourceType__NetworkInducedFailureTypeProxy(INetworkInducedFailureType modelElement) : 
                    base(modelElement, "communicationLinkResourceType__NetworkInducedFailureType")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ICommunicationLinkResourceType Value
            {
                get
                {
                    return this.ModelElement.CommunicationLinkResourceType__NetworkInducedFailureType;
                }
                set
                {
                    this.ModelElement.CommunicationLinkResourceType__NetworkInducedFailureType = value;
                }
            }
        }
    }
}

