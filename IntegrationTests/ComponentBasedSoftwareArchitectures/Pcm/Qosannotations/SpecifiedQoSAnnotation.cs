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
using NMFExamples.Pcm.Parameter;
using NMFExamples.Pcm.Repository;
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

namespace NMFExamples.Pcm.Qosannotations
{
    
    
    /// <summary>
    /// The default implementation of the SpecifiedQoSAnnotation class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/QoSAnnotations/5.0")]
    [XmlNamespacePrefixAttribute("qosannotations")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//qosannotations/SpecifiedQoSAnn" +
        "otation")]
    public abstract partial class SpecifiedQoSAnnotation : ModelElement, ISpecifiedQoSAnnotation, IModelElement
    {
        
        private static Lazy<ITypedElement> _signature_SpecifiedQoSAnnationReference = new Lazy<ITypedElement>(RetrieveSignature_SpecifiedQoSAnnationReference);
        
        /// <summary>
        /// The backing field for the Signature_SpecifiedQoSAnnation property
        /// </summary>
        private ISignature _signature_SpecifiedQoSAnnation;
        
        private static Lazy<ITypedElement> _role_SpecifiedQoSAnnotationReference = new Lazy<ITypedElement>(RetrieveRole_SpecifiedQoSAnnotationReference);
        
        /// <summary>
        /// The backing field for the Role_SpecifiedQoSAnnotation property
        /// </summary>
        private IRole _role_SpecifiedQoSAnnotation;
        
        private static Lazy<ITypedElement> _qosAnnotations_SpecifiedQoSAnnotationReference = new Lazy<ITypedElement>(RetrieveQosAnnotations_SpecifiedQoSAnnotationReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The signature_SpecifiedQoSAnnation property
        /// </summary>
        [XmlElementNameAttribute("signature_SpecifiedQoSAnnation")]
        [XmlAttributeAttribute(true)]
        public ISignature Signature_SpecifiedQoSAnnation
        {
            get
            {
                return this._signature_SpecifiedQoSAnnation;
            }
            set
            {
                if ((this._signature_SpecifiedQoSAnnation != value))
                {
                    ISignature old = this._signature_SpecifiedQoSAnnation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnSignature_SpecifiedQoSAnnationChanging(e);
                    this.OnPropertyChanging("Signature_SpecifiedQoSAnnation", e, _signature_SpecifiedQoSAnnationReference);
                    this._signature_SpecifiedQoSAnnation = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetSignature_SpecifiedQoSAnnation;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetSignature_SpecifiedQoSAnnation;
                    }
                    this.OnSignature_SpecifiedQoSAnnationChanged(e);
                    this.OnPropertyChanged("Signature_SpecifiedQoSAnnation", e, _signature_SpecifiedQoSAnnationReference);
                }
            }
        }
        
        /// <summary>
        /// The role_SpecifiedQoSAnnotation property
        /// </summary>
        [XmlElementNameAttribute("role_SpecifiedQoSAnnotation")]
        [XmlAttributeAttribute(true)]
        public IRole Role_SpecifiedQoSAnnotation
        {
            get
            {
                return this._role_SpecifiedQoSAnnotation;
            }
            set
            {
                if ((this._role_SpecifiedQoSAnnotation != value))
                {
                    IRole old = this._role_SpecifiedQoSAnnotation;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnRole_SpecifiedQoSAnnotationChanging(e);
                    this.OnPropertyChanging("Role_SpecifiedQoSAnnotation", e, _role_SpecifiedQoSAnnotationReference);
                    this._role_SpecifiedQoSAnnotation = value;
                    if ((old != null))
                    {
                        old.Deleted -= this.OnResetRole_SpecifiedQoSAnnotation;
                    }
                    if ((value != null))
                    {
                        value.Deleted += this.OnResetRole_SpecifiedQoSAnnotation;
                    }
                    this.OnRole_SpecifiedQoSAnnotationChanged(e);
                    this.OnPropertyChanged("Role_SpecifiedQoSAnnotation", e, _role_SpecifiedQoSAnnotationReference);
                }
            }
        }
        
        /// <summary>
        /// The qosAnnotations_SpecifiedQoSAnnotation property
        /// </summary>
        [XmlElementNameAttribute("qosAnnotations_SpecifiedQoSAnnotation")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("specifiedQoSAnnotations_QoSAnnotations")]
        public IQoSAnnotations QosAnnotations_SpecifiedQoSAnnotation
        {
            get
            {
                return ModelHelper.CastAs<IQoSAnnotations>(this.Parent);
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
                return base.ReferencedElements.Concat(new SpecifiedQoSAnnotationReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//qosannotations/SpecifiedQoSAnn" +
                            "otation")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Signature_SpecifiedQoSAnnation property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Signature_SpecifiedQoSAnnationChanging;
        
        /// <summary>
        /// Gets fired when the Signature_SpecifiedQoSAnnation property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Signature_SpecifiedQoSAnnationChanged;
        
        /// <summary>
        /// Gets fired before the Role_SpecifiedQoSAnnotation property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Role_SpecifiedQoSAnnotationChanging;
        
        /// <summary>
        /// Gets fired when the Role_SpecifiedQoSAnnotation property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> Role_SpecifiedQoSAnnotationChanged;
        
        /// <summary>
        /// Gets fired before the QosAnnotations_SpecifiedQoSAnnotation property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> QosAnnotations_SpecifiedQoSAnnotationChanging;
        
        /// <summary>
        /// Gets fired when the QosAnnotations_SpecifiedQoSAnnotation property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> QosAnnotations_SpecifiedQoSAnnotationChanged;
        
        private static ITypedElement RetrieveSignature_SpecifiedQoSAnnationReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Qosannotations.SpecifiedQoSAnnotation.ClassInstance)).Resolve("signature_SpecifiedQoSAnnation")));
        }
        
        /// <summary>
        /// Raises the Signature_SpecifiedQoSAnnationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSignature_SpecifiedQoSAnnationChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Signature_SpecifiedQoSAnnationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Signature_SpecifiedQoSAnnationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnSignature_SpecifiedQoSAnnationChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Signature_SpecifiedQoSAnnationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Signature_SpecifiedQoSAnnation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetSignature_SpecifiedQoSAnnation(object sender, global::System.EventArgs eventArgs)
        {
            this.Signature_SpecifiedQoSAnnation = null;
        }
        
        private static ITypedElement RetrieveRole_SpecifiedQoSAnnotationReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Qosannotations.SpecifiedQoSAnnotation.ClassInstance)).Resolve("role_SpecifiedQoSAnnotation")));
        }
        
        /// <summary>
        /// Raises the Role_SpecifiedQoSAnnotationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRole_SpecifiedQoSAnnotationChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Role_SpecifiedQoSAnnotationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the Role_SpecifiedQoSAnnotationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnRole_SpecifiedQoSAnnotationChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.Role_SpecifiedQoSAnnotationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Handles the event that the Role_SpecifiedQoSAnnotation property must reset
        /// </summary>
        /// <param name="sender">The object that sent this reset request</param>
        /// <param name="eventArgs">The event data for the reset event</param>
        private void OnResetRole_SpecifiedQoSAnnotation(object sender, global::System.EventArgs eventArgs)
        {
            this.Role_SpecifiedQoSAnnotation = null;
        }
        
        private static ITypedElement RetrieveQosAnnotations_SpecifiedQoSAnnotationReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Qosannotations.SpecifiedQoSAnnotation.ClassInstance)).Resolve("qosAnnotations_SpecifiedQoSAnnotation")));
        }
        
        /// <summary>
        /// Raises the QosAnnotations_SpecifiedQoSAnnotationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQosAnnotations_SpecifiedQoSAnnotationChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.QosAnnotations_SpecifiedQoSAnnotationChanging;
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
            IQoSAnnotations oldQosAnnotations_SpecifiedQoSAnnotation = ModelHelper.CastAs<IQoSAnnotations>(oldParent);
            IQoSAnnotations newQosAnnotations_SpecifiedQoSAnnotation = ModelHelper.CastAs<IQoSAnnotations>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldQosAnnotations_SpecifiedQoSAnnotation, newQosAnnotations_SpecifiedQoSAnnotation);
            this.OnQosAnnotations_SpecifiedQoSAnnotationChanging(e);
            this.OnPropertyChanging("QosAnnotations_SpecifiedQoSAnnotation", e, _qosAnnotations_SpecifiedQoSAnnotationReference);
        }
        
        /// <summary>
        /// Raises the QosAnnotations_SpecifiedQoSAnnotationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnQosAnnotations_SpecifiedQoSAnnotationChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.QosAnnotations_SpecifiedQoSAnnotationChanged;
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
            IQoSAnnotations oldQosAnnotations_SpecifiedQoSAnnotation = ModelHelper.CastAs<IQoSAnnotations>(oldParent);
            IQoSAnnotations newQosAnnotations_SpecifiedQoSAnnotation = ModelHelper.CastAs<IQoSAnnotations>(newParent);
            if ((oldQosAnnotations_SpecifiedQoSAnnotation != null))
            {
                oldQosAnnotations_SpecifiedQoSAnnotation.SpecifiedQoSAnnotations_QoSAnnotations.Remove(this);
            }
            if ((newQosAnnotations_SpecifiedQoSAnnotation != null))
            {
                newQosAnnotations_SpecifiedQoSAnnotation.SpecifiedQoSAnnotations_QoSAnnotations.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldQosAnnotations_SpecifiedQoSAnnotation, newQosAnnotations_SpecifiedQoSAnnotation);
            this.OnQosAnnotations_SpecifiedQoSAnnotationChanged(e);
            this.OnPropertyChanged("QosAnnotations_SpecifiedQoSAnnotation", e, _qosAnnotations_SpecifiedQoSAnnotationReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "SIGNATURE_SPECIFIEDQOSANNATION"))
            {
                this.Signature_SpecifiedQoSAnnation = ((ISignature)(value));
                return;
            }
            if ((feature == "ROLE_SPECIFIEDQOSANNOTATION"))
            {
                this.Role_SpecifiedQoSAnnotation = ((IRole)(value));
                return;
            }
            if ((feature == "QOSANNOTATIONS_SPECIFIEDQOSANNOTATION"))
            {
                this.QosAnnotations_SpecifiedQoSAnnotation = ((IQoSAnnotations)(value));
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
            if ((attribute == "Signature_SpecifiedQoSAnnation"))
            {
                return new Signature_SpecifiedQoSAnnationProxy(this);
            }
            if ((attribute == "Role_SpecifiedQoSAnnotation"))
            {
                return new Role_SpecifiedQoSAnnotationProxy(this);
            }
            if ((attribute == "QosAnnotations_SpecifiedQoSAnnotation"))
            {
                return new QosAnnotations_SpecifiedQoSAnnotationProxy(this);
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
            if ((reference == "Signature_SpecifiedQoSAnnation"))
            {
                return new Signature_SpecifiedQoSAnnationProxy(this);
            }
            if ((reference == "Role_SpecifiedQoSAnnotation"))
            {
                return new Role_SpecifiedQoSAnnotationProxy(this);
            }
            if ((reference == "QosAnnotations_SpecifiedQoSAnnotation"))
            {
                return new QosAnnotations_SpecifiedQoSAnnotationProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//qosannotations/SpecifiedQoSAnn" +
                        "otation")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the SpecifiedQoSAnnotation class
        /// </summary>
        public class SpecifiedQoSAnnotationReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private SpecifiedQoSAnnotation _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public SpecifiedQoSAnnotationReferencedElementsCollection(SpecifiedQoSAnnotation parent)
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
                    if ((this._parent.Signature_SpecifiedQoSAnnation != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.Role_SpecifiedQoSAnnotation != null))
                    {
                        count = (count + 1);
                    }
                    if ((this._parent.QosAnnotations_SpecifiedQoSAnnotation != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.Signature_SpecifiedQoSAnnationChanged += this.PropagateValueChanges;
                this._parent.Role_SpecifiedQoSAnnotationChanged += this.PropagateValueChanges;
                this._parent.QosAnnotations_SpecifiedQoSAnnotationChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.Signature_SpecifiedQoSAnnationChanged -= this.PropagateValueChanges;
                this._parent.Role_SpecifiedQoSAnnotationChanged -= this.PropagateValueChanges;
                this._parent.QosAnnotations_SpecifiedQoSAnnotationChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.Signature_SpecifiedQoSAnnation == null))
                {
                    ISignature signature_SpecifiedQoSAnnationCasted = item.As<ISignature>();
                    if ((signature_SpecifiedQoSAnnationCasted != null))
                    {
                        this._parent.Signature_SpecifiedQoSAnnation = signature_SpecifiedQoSAnnationCasted;
                        return;
                    }
                }
                if ((this._parent.Role_SpecifiedQoSAnnotation == null))
                {
                    IRole role_SpecifiedQoSAnnotationCasted = item.As<IRole>();
                    if ((role_SpecifiedQoSAnnotationCasted != null))
                    {
                        this._parent.Role_SpecifiedQoSAnnotation = role_SpecifiedQoSAnnotationCasted;
                        return;
                    }
                }
                if ((this._parent.QosAnnotations_SpecifiedQoSAnnotation == null))
                {
                    IQoSAnnotations qosAnnotations_SpecifiedQoSAnnotationCasted = item.As<IQoSAnnotations>();
                    if ((qosAnnotations_SpecifiedQoSAnnotationCasted != null))
                    {
                        this._parent.QosAnnotations_SpecifiedQoSAnnotation = qosAnnotations_SpecifiedQoSAnnotationCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.Signature_SpecifiedQoSAnnation = null;
                this._parent.Role_SpecifiedQoSAnnotation = null;
                this._parent.QosAnnotations_SpecifiedQoSAnnotation = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.Signature_SpecifiedQoSAnnation))
                {
                    return true;
                }
                if ((item == this._parent.Role_SpecifiedQoSAnnotation))
                {
                    return true;
                }
                if ((item == this._parent.QosAnnotations_SpecifiedQoSAnnotation))
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
                if ((this._parent.Signature_SpecifiedQoSAnnation != null))
                {
                    array[arrayIndex] = this._parent.Signature_SpecifiedQoSAnnation;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.Role_SpecifiedQoSAnnotation != null))
                {
                    array[arrayIndex] = this._parent.Role_SpecifiedQoSAnnotation;
                    arrayIndex = (arrayIndex + 1);
                }
                if ((this._parent.QosAnnotations_SpecifiedQoSAnnotation != null))
                {
                    array[arrayIndex] = this._parent.QosAnnotations_SpecifiedQoSAnnotation;
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
                if ((this._parent.Signature_SpecifiedQoSAnnation == item))
                {
                    this._parent.Signature_SpecifiedQoSAnnation = null;
                    return true;
                }
                if ((this._parent.Role_SpecifiedQoSAnnotation == item))
                {
                    this._parent.Role_SpecifiedQoSAnnotation = null;
                    return true;
                }
                if ((this._parent.QosAnnotations_SpecifiedQoSAnnotation == item))
                {
                    this._parent.QosAnnotations_SpecifiedQoSAnnotation = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.Signature_SpecifiedQoSAnnation).Concat(this._parent.Role_SpecifiedQoSAnnotation).Concat(this._parent.QosAnnotations_SpecifiedQoSAnnotation).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the signature_SpecifiedQoSAnnation property
        /// </summary>
        private sealed class Signature_SpecifiedQoSAnnationProxy : ModelPropertyChange<ISpecifiedQoSAnnotation, ISignature>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Signature_SpecifiedQoSAnnationProxy(ISpecifiedQoSAnnotation modelElement) : 
                    base(modelElement, "signature_SpecifiedQoSAnnation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override ISignature Value
            {
                get
                {
                    return this.ModelElement.Signature_SpecifiedQoSAnnation;
                }
                set
                {
                    this.ModelElement.Signature_SpecifiedQoSAnnation = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the role_SpecifiedQoSAnnotation property
        /// </summary>
        private sealed class Role_SpecifiedQoSAnnotationProxy : ModelPropertyChange<ISpecifiedQoSAnnotation, IRole>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public Role_SpecifiedQoSAnnotationProxy(ISpecifiedQoSAnnotation modelElement) : 
                    base(modelElement, "role_SpecifiedQoSAnnotation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IRole Value
            {
                get
                {
                    return this.ModelElement.Role_SpecifiedQoSAnnotation;
                }
                set
                {
                    this.ModelElement.Role_SpecifiedQoSAnnotation = value;
                }
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the qosAnnotations_SpecifiedQoSAnnotation property
        /// </summary>
        private sealed class QosAnnotations_SpecifiedQoSAnnotationProxy : ModelPropertyChange<ISpecifiedQoSAnnotation, IQoSAnnotations>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public QosAnnotations_SpecifiedQoSAnnotationProxy(ISpecifiedQoSAnnotation modelElement) : 
                    base(modelElement, "qosAnnotations_SpecifiedQoSAnnotation")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IQoSAnnotations Value
            {
                get
                {
                    return this.ModelElement.QosAnnotations_SpecifiedQoSAnnotation;
                }
                set
                {
                    this.ModelElement.QosAnnotations_SpecifiedQoSAnnotation = value;
                }
            }
        }
    }
}
