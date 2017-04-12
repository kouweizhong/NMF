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
using NMFExamples.Pcm.Core.Composition;
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

namespace NMFExamples.Pcm.Usagemodel
{
    
    
    /// <summary>
    /// The public interface for ClosedWorkload
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ClosedWorkload))]
    [XmlDefaultImplementationTypeAttribute(typeof(ClosedWorkload))]
    public interface IClosedWorkload : IModelElement, IWorkload
    {
        
        /// <summary>
        /// The population property
        /// </summary>
        int Population
        {
            get;
            set;
        }
        
        /// <summary>
        /// The thinkTime_ClosedWorkload property
        /// </summary>
        IPCMRandomVariable ThinkTime_ClosedWorkload
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Population property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> PopulationChanging;
        
        /// <summary>
        /// Gets fired when the Population property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> PopulationChanged;
        
        /// <summary>
        /// Gets fired before the ThinkTime_ClosedWorkload property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ThinkTime_ClosedWorkloadChanging;
        
        /// <summary>
        /// Gets fired when the ThinkTime_ClosedWorkload property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ThinkTime_ClosedWorkloadChanged;
    }
}

