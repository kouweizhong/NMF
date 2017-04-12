//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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

namespace NMFExamples.Probfunction
{
    
    
    /// <summary>
    /// The public interface for GammaDistribution
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(GammaDistribution))]
    [XmlDefaultImplementationTypeAttribute(typeof(GammaDistribution))]
    public interface IGammaDistribution : IModelElement, IContinuousPDF
    {
        
        /// <summary>
        /// The alpha property
        /// </summary>
        double Alpha
        {
            get;
            set;
        }
        
        /// <summary>
        /// The theta property
        /// </summary>
        double Theta
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Alpha property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AlphaChanging;
        
        /// <summary>
        /// Gets fired when the Alpha property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> AlphaChanged;
        
        /// <summary>
        /// Gets fired before the Theta property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ThetaChanging;
        
        /// <summary>
        /// Gets fired when the Theta property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> ThetaChanged;
    }
}

