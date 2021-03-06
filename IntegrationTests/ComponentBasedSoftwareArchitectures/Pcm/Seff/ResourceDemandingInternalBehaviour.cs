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
    /// The default implementation of the ResourceDemandingInternalBehaviour class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/SEFF/5.0")]
    [XmlNamespacePrefixAttribute("seff")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/ResourceDemandingInternal" +
        "Behaviour")]
    [DebuggerDisplayAttribute("ResourceDemandingInternalBehaviour {Id}")]
    public partial class ResourceDemandingInternalBehaviour : ResourceDemandingBehaviour, IResourceDemandingInternalBehaviour, IModelElement
    {
        
        private static Lazy<ITypedElement> _resourceDemandingSEFF_ResourceDemandingInternalBehaviourReference = new Lazy<ITypedElement>(RetrieveResourceDemandingSEFF_ResourceDemandingInternalBehaviourReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The resourceDemandingSEFF_ResourceDemandingInternalBehaviour property
        /// </summary>
        [XmlElementNameAttribute("resourceDemandingSEFF_ResourceDemandingInternalBehaviour")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("resourceDemandingInternalBehaviours")]
        public IResourceDemandingSEFF ResourceDemandingSEFF_ResourceDemandingInternalBehaviour
        {
            get
            {
                return ModelHelper.CastAs<IResourceDemandingSEFF>(this.Parent);
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
                return base.ReferencedElements.Concat(new ResourceDemandingInternalBehaviourReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/ResourceDemandingInternal" +
                            "Behaviour")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ResourceDemandingSEFF_ResourceDemandingInternalBehaviour property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanging;
        
        /// <summary>
        /// Gets fired when the ResourceDemandingSEFF_ResourceDemandingInternalBehaviour property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged;
        
        private static ITypedElement RetrieveResourceDemandingSEFF_ResourceDemandingInternalBehaviourReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Seff.ResourceDemandingInternalBehaviour.ClassInstance)).Resolve("resourceDemandingSEFF_ResourceDemandingInternalBehaviour")));
        }
        
        /// <summary>
        /// Raises the ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanging;
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
            IResourceDemandingSEFF oldResourceDemandingSEFF_ResourceDemandingInternalBehaviour = ModelHelper.CastAs<IResourceDemandingSEFF>(oldParent);
            IResourceDemandingSEFF newResourceDemandingSEFF_ResourceDemandingInternalBehaviour = ModelHelper.CastAs<IResourceDemandingSEFF>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceDemandingSEFF_ResourceDemandingInternalBehaviour, newResourceDemandingSEFF_ResourceDemandingInternalBehaviour);
            this.OnResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanging(e);
            this.OnPropertyChanging("ResourceDemandingSEFF_ResourceDemandingInternalBehaviour", e, _resourceDemandingSEFF_ResourceDemandingInternalBehaviourReference);
        }
        
        /// <summary>
        /// Raises the ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged;
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
            IResourceDemandingSEFF oldResourceDemandingSEFF_ResourceDemandingInternalBehaviour = ModelHelper.CastAs<IResourceDemandingSEFF>(oldParent);
            IResourceDemandingSEFF newResourceDemandingSEFF_ResourceDemandingInternalBehaviour = ModelHelper.CastAs<IResourceDemandingSEFF>(newParent);
            if ((oldResourceDemandingSEFF_ResourceDemandingInternalBehaviour != null))
            {
                oldResourceDemandingSEFF_ResourceDemandingInternalBehaviour.ResourceDemandingInternalBehaviours.Remove(this);
            }
            if ((newResourceDemandingSEFF_ResourceDemandingInternalBehaviour != null))
            {
                newResourceDemandingSEFF_ResourceDemandingInternalBehaviour.ResourceDemandingInternalBehaviours.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldResourceDemandingSEFF_ResourceDemandingInternalBehaviour, newResourceDemandingSEFF_ResourceDemandingInternalBehaviour);
            this.OnResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged(e);
            this.OnPropertyChanged("ResourceDemandingSEFF_ResourceDemandingInternalBehaviour", e, _resourceDemandingSEFF_ResourceDemandingInternalBehaviourReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "RESOURCEDEMANDINGSEFF_RESOURCEDEMANDINGINTERNALBEHAVIOUR"))
            {
                this.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour = ((IResourceDemandingSEFF)(value));
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
            if ((attribute == "ResourceDemandingSEFF_ResourceDemandingInternalBehaviour"))
            {
                return new ResourceDemandingSEFF_ResourceDemandingInternalBehaviourProxy(this);
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
            if ((reference == "ResourceDemandingSEFF_ResourceDemandingInternalBehaviour"))
            {
                return new ResourceDemandingSEFF_ResourceDemandingInternalBehaviourProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//seff/ResourceDemandingInternal" +
                        "Behaviour")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ResourceDemandingInternalBehaviour class
        /// </summary>
        public class ResourceDemandingInternalBehaviourReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ResourceDemandingInternalBehaviour _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ResourceDemandingInternalBehaviourReferencedElementsCollection(ResourceDemandingInternalBehaviour parent)
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
                    if ((this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviourChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour == null))
                {
                    IResourceDemandingSEFF resourceDemandingSEFF_ResourceDemandingInternalBehaviourCasted = item.As<IResourceDemandingSEFF>();
                    if ((resourceDemandingSEFF_ResourceDemandingInternalBehaviourCasted != null))
                    {
                        this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour = resourceDemandingSEFF_ResourceDemandingInternalBehaviourCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour))
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
                if ((this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour != null))
                {
                    array[arrayIndex] = this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour;
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
                if ((this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour == item))
                {
                    this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the resourceDemandingSEFF_ResourceDemandingInternalBehaviour property
        /// </summary>
        private sealed class ResourceDemandingSEFF_ResourceDemandingInternalBehaviourProxy : ModelPropertyChange<IResourceDemandingInternalBehaviour, IResourceDemandingSEFF>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ResourceDemandingSEFF_ResourceDemandingInternalBehaviourProxy(IResourceDemandingInternalBehaviour modelElement) : 
                    base(modelElement, "resourceDemandingSEFF_ResourceDemandingInternalBehaviour")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IResourceDemandingSEFF Value
            {
                get
                {
                    return this.ModelElement.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour;
                }
                set
                {
                    this.ModelElement.ResourceDemandingSEFF_ResourceDemandingInternalBehaviour = value;
                }
            }
        }
    }
}

