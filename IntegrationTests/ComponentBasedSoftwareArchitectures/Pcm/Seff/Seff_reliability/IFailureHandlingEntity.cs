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
using NMFExamples.Pcm.Reliability;
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

namespace NMFExamples.Pcm.Seff.Seff_reliability
{
    
    
    /// <summary>
    /// The public interface for FailureHandlingEntity
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FailureHandlingEntity))]
    [XmlDefaultImplementationTypeAttribute(typeof(FailureHandlingEntity))]
    public interface IFailureHandlingEntity : IModelElement, IEntity
    {
        
        /// <summary>
        /// The failureTypes_FailureHandlingEntity property
        /// </summary>
        ICollectionExpression<IFailureType> FailureTypes_FailureHandlingEntity
        {
            get;
        }
    }
}

