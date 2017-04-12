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
    /// The public interface for SynchronisationPoint
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SynchronisationPoint))]
    [XmlDefaultImplementationTypeAttribute(typeof(SynchronisationPoint))]
    public interface ISynchronisationPoint : IModelElement
    {
        
        /// <summary>
        /// The outputParameterUsage_SynchronisationPoint property
        /// </summary>
        IListExpression<IVariableUsage> OutputParameterUsage_SynchronisationPoint
        {
            get;
        }
        
        /// <summary>
        /// The forkAction_SynchronisationPoint property
        /// </summary>
        IForkAction ForkAction_SynchronisationPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// The synchronousForkedBehaviours_SynchronisationPoint property
        /// </summary>
        IListExpression<IForkedBehaviour> SynchronousForkedBehaviours_SynchronisationPoint
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ForkAction_SynchronisationPoint property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ForkAction_SynchronisationPointChanging;
        
        /// <summary>
        /// Gets fired when the ForkAction_SynchronisationPoint property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ForkAction_SynchronisationPointChanged;
    }
}

