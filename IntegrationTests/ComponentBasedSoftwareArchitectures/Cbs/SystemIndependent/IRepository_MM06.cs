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

namespace NMFExamples.ComponentBasedSystems.SystemIndependent
{
    
    
    /// <summary>
    /// The public interface for Repository_MM06
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Repository_MM06))]
    [XmlDefaultImplementationTypeAttribute(typeof(Repository_MM06))]
    public interface IRepository_MM06 : IModelElement
    {
        
        /// <summary>
        /// The Interfaces property
        /// </summary>
        IOrderedSetExpression<IInterface> Interfaces
        {
            get;
        }
        
        /// <summary>
        /// The Components property
        /// </summary>
        IOrderedSetExpression<IComponent_MM06> Components
        {
            get;
        }
        
        /// <summary>
        /// The AvailableSignatures property
        /// </summary>
        IOrderedSetExpression<ISignature> AvailableSignatures
        {
            get;
        }
    }
}

