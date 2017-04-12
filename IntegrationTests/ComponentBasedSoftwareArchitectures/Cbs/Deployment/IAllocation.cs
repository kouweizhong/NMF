//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.ComponentBasedSystems;
using NMFExamples.ComponentBasedSystems.Assembly;
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
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace NMFExamples.ComponentBasedSystems.Deployment
{
    
    
    /// <summary>
    /// The public interface for Allocation
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Allocation))]
    [XmlDefaultImplementationTypeAttribute(typeof(Allocation))]
    public interface IAllocation : IModelElement
    {
        
        /// <summary>
        /// The Contexts property
        /// </summary>
        IOrderedSetExpression<IAllocationContext> Contexts
        {
            get;
        }
        
        /// <summary>
        /// The AllocatedSystem property
        /// </summary>
        ISystem_MM06 AllocatedSystem
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the AllocatedSystem property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AllocatedSystemChanging;
        
        /// <summary>
        /// Gets fired when the AllocatedSystem property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AllocatedSystemChanged;
    }
}

