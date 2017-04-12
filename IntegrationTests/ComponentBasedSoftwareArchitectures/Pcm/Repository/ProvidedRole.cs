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
    /// The default implementation of the ProvidedRole class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Repository/5.0")]
    [XmlNamespacePrefixAttribute("repository")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/ProvidedRole")]
    [DebuggerDisplayAttribute("ProvidedRole {Id}")]
    public abstract partial class ProvidedRole : Role, IProvidedRole, IModelElement
    {
        
        private static Lazy<ITypedElement> _providingEntity_ProvidedRoleReference = new Lazy<ITypedElement>(RetrieveProvidingEntity_ProvidedRoleReference);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The providingEntity_ProvidedRole property
        /// </summary>
        [XmlElementNameAttribute("providingEntity_ProvidedRole")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("providedRoles_InterfaceProvidingEntity")]
        public IInterfaceProvidingEntity ProvidingEntity_ProvidedRole
        {
            get
            {
                return ModelHelper.CastAs<IInterfaceProvidingEntity>(this.Parent);
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
                return base.ReferencedElements.Concat(new ProvidedRoleReferencedElementsCollection(this));
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/ProvidedRole")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the ProvidingEntity_ProvidedRole property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ProvidingEntity_ProvidedRoleChanging;
        
        /// <summary>
        /// Gets fired when the ProvidingEntity_ProvidedRole property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> ProvidingEntity_ProvidedRoleChanged;
        
        private static ITypedElement RetrieveProvidingEntity_ProvidedRoleReference()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Repository.ProvidedRole.ClassInstance)).Resolve("providingEntity_ProvidedRole")));
        }
        
        /// <summary>
        /// Raises the ProvidingEntity_ProvidedRoleChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProvidingEntity_ProvidedRoleChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ProvidingEntity_ProvidedRoleChanging;
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
            IInterfaceProvidingEntity oldProvidingEntity_ProvidedRole = ModelHelper.CastAs<IInterfaceProvidingEntity>(oldParent);
            IInterfaceProvidingEntity newProvidingEntity_ProvidedRole = ModelHelper.CastAs<IInterfaceProvidingEntity>(newParent);
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldProvidingEntity_ProvidedRole, newProvidingEntity_ProvidedRole);
            this.OnProvidingEntity_ProvidedRoleChanging(e);
            this.OnPropertyChanging("ProvidingEntity_ProvidedRole", e, _providingEntity_ProvidedRoleReference);
        }
        
        /// <summary>
        /// Raises the ProvidingEntity_ProvidedRoleChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnProvidingEntity_ProvidedRoleChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.ProvidingEntity_ProvidedRoleChanged;
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
            IInterfaceProvidingEntity oldProvidingEntity_ProvidedRole = ModelHelper.CastAs<IInterfaceProvidingEntity>(oldParent);
            IInterfaceProvidingEntity newProvidingEntity_ProvidedRole = ModelHelper.CastAs<IInterfaceProvidingEntity>(newParent);
            if ((oldProvidingEntity_ProvidedRole != null))
            {
                oldProvidingEntity_ProvidedRole.ProvidedRoles_InterfaceProvidingEntity.Remove(this);
            }
            if ((newProvidingEntity_ProvidedRole != null))
            {
                newProvidingEntity_ProvidedRole.ProvidedRoles_InterfaceProvidingEntity.Add(this);
            }
            ValueChangedEventArgs e = new ValueChangedEventArgs(oldProvidingEntity_ProvidedRole, newProvidingEntity_ProvidedRole);
            this.OnProvidingEntity_ProvidedRoleChanged(e);
            this.OnPropertyChanged("ProvidingEntity_ProvidedRole", e, _providingEntity_ProvidedRoleReference);
            base.OnParentChanged(newParent, oldParent);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "PROVIDINGENTITY_PROVIDEDROLE"))
            {
                this.ProvidingEntity_ProvidedRole = ((IInterfaceProvidingEntity)(value));
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
            if ((attribute == "ProvidingEntity_ProvidedRole"))
            {
                return new ProvidingEntity_ProvidedRoleProxy(this);
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
            if ((reference == "ProvidingEntity_ProvidedRole"))
            {
                return new ProvidingEntity_ProvidedRoleProxy(this);
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
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//repository/ProvidedRole")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// The collection class to to represent the children of the ProvidedRole class
        /// </summary>
        public class ProvidedRoleReferencedElementsCollection : ReferenceCollection, ICollectionExpression<IModelElement>, ICollection<IModelElement>
        {
            
            private ProvidedRole _parent;
            
            /// <summary>
            /// Creates a new instance
            /// </summary>
            public ProvidedRoleReferencedElementsCollection(ProvidedRole parent)
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
                    if ((this._parent.ProvidingEntity_ProvidedRole != null))
                    {
                        count = (count + 1);
                    }
                    return count;
                }
            }
            
            protected override void AttachCore()
            {
                this._parent.ProvidingEntity_ProvidedRoleChanged += this.PropagateValueChanges;
            }
            
            protected override void DetachCore()
            {
                this._parent.ProvidingEntity_ProvidedRoleChanged -= this.PropagateValueChanges;
            }
            
            /// <summary>
            /// Adds the given element to the collection
            /// </summary>
            /// <param name="item">The item to add</param>
            public override void Add(IModelElement item)
            {
                if ((this._parent.ProvidingEntity_ProvidedRole == null))
                {
                    IInterfaceProvidingEntity providingEntity_ProvidedRoleCasted = item.As<IInterfaceProvidingEntity>();
                    if ((providingEntity_ProvidedRoleCasted != null))
                    {
                        this._parent.ProvidingEntity_ProvidedRole = providingEntity_ProvidedRoleCasted;
                        return;
                    }
                }
            }
            
            /// <summary>
            /// Clears the collection and resets all references that implement it.
            /// </summary>
            public override void Clear()
            {
                this._parent.ProvidingEntity_ProvidedRole = null;
            }
            
            /// <summary>
            /// Gets a value indicating whether the given element is contained in the collection
            /// </summary>
            /// <returns>True, if it is contained, otherwise False</returns>
            /// <param name="item">The item that should be looked out for</param>
            public override bool Contains(IModelElement item)
            {
                if ((item == this._parent.ProvidingEntity_ProvidedRole))
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
                if ((this._parent.ProvidingEntity_ProvidedRole != null))
                {
                    array[arrayIndex] = this._parent.ProvidingEntity_ProvidedRole;
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
                if ((this._parent.ProvidingEntity_ProvidedRole == item))
                {
                    this._parent.ProvidingEntity_ProvidedRole = null;
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
                return Enumerable.Empty<IModelElement>().Concat(this._parent.ProvidingEntity_ProvidedRole).GetEnumerator();
            }
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the providingEntity_ProvidedRole property
        /// </summary>
        private sealed class ProvidingEntity_ProvidedRoleProxy : ModelPropertyChange<IProvidedRole, IInterfaceProvidingEntity>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public ProvidingEntity_ProvidedRoleProxy(IProvidedRole modelElement) : 
                    base(modelElement, "providingEntity_ProvidedRole")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override IInterfaceProvidingEntity Value
            {
                get
                {
                    return this.ModelElement.ProvidingEntity_ProvidedRole;
                }
                set
                {
                    this.ModelElement.ProvidingEntity_ProvidedRole = value;
                }
            }
        }
    }
}

