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
    /// The public interface for BranchTransition
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(BranchTransition))]
    [XmlDefaultImplementationTypeAttribute(typeof(BranchTransition))]
    public interface IBranchTransition : IModelElement
    {
        
        /// <summary>
        /// The branchProbability property
        /// </summary>
        double BranchProbability
        {
            get;
            set;
        }
        
        /// <summary>
        /// The branch_BranchTransition property
        /// </summary>
        IBranch Branch_BranchTransition
        {
            get;
            set;
        }
        
        /// <summary>
        /// The branchedBehaviour_BranchTransition property
        /// </summary>
        IScenarioBehaviour BranchedBehaviour_BranchTransition
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the BranchProbability property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> BranchProbabilityChanging;
        
        /// <summary>
        /// Gets fired when the BranchProbability property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> BranchProbabilityChanged;
        
        /// <summary>
        /// Gets fired before the Branch_BranchTransition property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Branch_BranchTransitionChanging;
        
        /// <summary>
        /// Gets fired when the Branch_BranchTransition property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Branch_BranchTransitionChanged;
        
        /// <summary>
        /// Gets fired before the BranchedBehaviour_BranchTransition property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> BranchedBehaviour_BranchTransitionChanging;
        
        /// <summary>
        /// Gets fired when the BranchedBehaviour_BranchTransition property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> BranchedBehaviour_BranchTransitionChanged;
    }
}

