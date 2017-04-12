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
    /// The public interface for FailureOccurrenceDescription
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FailureOccurrenceDescription))]
    [XmlDefaultImplementationTypeAttribute(typeof(FailureOccurrenceDescription))]
    public interface IFailureOccurrenceDescription : IModelElement
    {
        
        /// <summary>
        /// The failureProbability property
        /// </summary>
        double FailureProbability
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the FailureProbability property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> FailureProbabilityChanging;
        
        /// <summary>
        /// Gets fired when the FailureProbability property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> FailureProbabilityChanged;
    }
}

