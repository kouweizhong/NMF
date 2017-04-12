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
using NMFExamples.Pcm.Qosannotations;
using NMFExamples.Pcm.Seff;
using NMFExamples.Pcm.Usagemodel;
using NMFExamples.Stoex;
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

namespace NMFExamples.Pcm.Parameter
{
    
    
    /// <summary>
    /// The public interface for CharacterisedVariable
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(CharacterisedVariable))]
    [XmlDefaultImplementationTypeAttribute(typeof(CharacterisedVariable))]
    public interface ICharacterisedVariable : IModelElement, IVariable
    {
        
        /// <summary>
        /// The characterisationType property
        /// </summary>
        VariableCharacterisationType CharacterisationType
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the CharacterisationType property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> CharacterisationTypeChanging;
        
        /// <summary>
        /// Gets fired when the CharacterisationType property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> CharacterisationTypeChanged;
    }
}

