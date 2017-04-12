//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Probfunction;
using NMFExamples.Units;
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

namespace NMFExamples.Stoex
{
    
    
    /// <summary>
    /// The public interface for Variable
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Variable))]
    [XmlDefaultImplementationTypeAttribute(typeof(Variable))]
    public interface IVariable : IModelElement, IAtom
    {
        
        /// <summary>
        /// The id_Variable property
        /// </summary>
        IAbstractNamedReference Id_Variable
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Id_Variable property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Id_VariableChanging;
        
        /// <summary>
        /// Gets fired when the Id_Variable property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> Id_VariableChanged;
    }
}

