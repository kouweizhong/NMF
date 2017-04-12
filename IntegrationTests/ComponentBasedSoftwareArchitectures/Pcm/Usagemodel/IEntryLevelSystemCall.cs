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
    /// The public interface for EntryLevelSystemCall
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(EntryLevelSystemCall))]
    [XmlDefaultImplementationTypeAttribute(typeof(EntryLevelSystemCall))]
    public interface IEntryLevelSystemCall : IModelElement, IAbstractUserAction
    {
        
        /// <summary>
        /// The priority property
        /// </summary>
        Nullable<int> Priority
        {
            get;
            set;
        }
        
        /// <summary>
        /// The providedRole_EntryLevelSystemCall property
        /// </summary>
        IOperationProvidedRole ProvidedRole_EntryLevelSystemCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The operationSignature__EntryLevelSystemCall property
        /// </summary>
        IOperationSignature OperationSignature__EntryLevelSystemCall
        {
            get;
            set;
        }
        
        /// <summary>
        /// The outputParameterUsages_EntryLevelSystemCall property
        /// </summary>
        IListExpression<IVariableUsage> OutputParameterUsages_EntryLevelSystemCall
        {
            get;
        }
        
        /// <summary>
        /// The inputParameterUsages_EntryLevelSystemCall property
        /// </summary>
        IListExpression<IVariableUsage> InputParameterUsages_EntryLevelSystemCall
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Priority property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> PriorityChanging;
        
        /// <summary>
        /// Gets fired when the Priority property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> PriorityChanged;
        
        /// <summary>
        /// Gets fired before the ProvidedRole_EntryLevelSystemCall property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProvidedRole_EntryLevelSystemCallChanging;
        
        /// <summary>
        /// Gets fired when the ProvidedRole_EntryLevelSystemCall property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ProvidedRole_EntryLevelSystemCallChanged;
        
        /// <summary>
        /// Gets fired before the OperationSignature__EntryLevelSystemCall property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> OperationSignature__EntryLevelSystemCallChanging;
        
        /// <summary>
        /// Gets fired when the OperationSignature__EntryLevelSystemCall property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> OperationSignature__EntryLevelSystemCallChanged;
    }
}

