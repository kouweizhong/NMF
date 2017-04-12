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
    /// The public interface for Signature
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Signature))]
    [XmlDefaultImplementationTypeAttribute(typeof(Signature))]
    public interface ISignature : IModelElement, INamedElement
    {
        
        /// <summary>
        /// The ReturnType property
        /// </summary>
        Nullable<Type> ReturnType
        {
            get;
            set;
        }
        
        /// <summary>
        /// The Parameter property
        /// </summary>
        IOrderedSetExpression<IParameter> Parameter
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the ReturnType property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ReturnTypeChanging;
        
        /// <summary>
        /// Gets fired when the ReturnType property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ReturnTypeChanged;
    }
}

