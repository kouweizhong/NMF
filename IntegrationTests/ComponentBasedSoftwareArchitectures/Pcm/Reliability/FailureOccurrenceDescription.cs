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
    /// The default implementation of the FailureOccurrenceDescription class
    /// </summary>
    [XmlNamespaceAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/Reliability/5.0")]
    [XmlNamespacePrefixAttribute("reliability")]
    [ModelRepresentationClassAttribute("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//reliability/FailureOccurrenceD" +
        "escription")]
    public abstract partial class FailureOccurrenceDescription : ModelElement, IFailureOccurrenceDescription, IModelElement
    {
        
        /// <summary>
        /// The backing field for the FailureProbability property
        /// </summary>
        private double _failureProbability;
        
        private static Lazy<ITypedElement> _failureProbabilityAttribute = new Lazy<ITypedElement>(RetrieveFailureProbabilityAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The failureProbability property
        /// </summary>
        [XmlElementNameAttribute("failureProbability")]
        [XmlAttributeAttribute(true)]
        public double FailureProbability
        {
            get
            {
                return this._failureProbability;
            }
            set
            {
                if ((this._failureProbability != value))
                {
                    double old = this._failureProbability;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnFailureProbabilityChanging(e);
                    this.OnPropertyChanging("FailureProbability", e, _failureProbabilityAttribute);
                    this._failureProbability = value;
                    this.OnFailureProbabilityChanged(e);
                    this.OnPropertyChanged("FailureProbability", e, _failureProbabilityAttribute);
                }
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
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//reliability/FailureOccurrenceD" +
                            "escription")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the FailureProbability property changes its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> FailureProbabilityChanging;
        
        /// <summary>
        /// Gets fired when the FailureProbability property changed its value
        /// </summary>
        public event global::System.EventHandler<ValueChangedEventArgs> FailureProbabilityChanged;
        
        private static ITypedElement RetrieveFailureProbabilityAttribute()
        {
            return ((ITypedElement)(((ModelElement)(NMFExamples.Pcm.Reliability.FailureOccurrenceDescription.ClassInstance)).Resolve("failureProbability")));
        }
        
        /// <summary>
        /// Raises the FailureProbabilityChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFailureProbabilityChanging(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.FailureProbabilityChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the FailureProbabilityChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnFailureProbabilityChanged(ValueChangedEventArgs eventArgs)
        {
            global::System.EventHandler<ValueChangedEventArgs> handler = this.FailureProbabilityChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "FAILUREPROBABILITY"))
            {
                return this.FailureProbability;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "FAILUREPROBABILITY"))
            {
                this.FailureProbability = ((double)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("http://sdq.ipd.uka.de/PalladioComponentModel/5.0#//reliability/FailureOccurrenceD" +
                        "escription")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the failureProbability property
        /// </summary>
        private sealed class FailureProbabilityProxy : ModelPropertyChange<IFailureOccurrenceDescription, double>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public FailureProbabilityProxy(IFailureOccurrenceDescription modelElement) : 
                    base(modelElement, "failureProbability")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override double Value
            {
                get
                {
                    return this.ModelElement.FailureProbability;
                }
                set
                {
                    this.ModelElement.FailureProbability = value;
                }
            }
        }
    }
}

