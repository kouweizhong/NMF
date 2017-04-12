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
    /// The public interface for SamplePDF
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(SamplePDF))]
    [XmlDefaultImplementationTypeAttribute(typeof(SamplePDF))]
    public interface ISamplePDF : IModelElement, IProbabilityDensityFunction
    {
        
        /// <summary>
        /// The distance property
        /// </summary>
        Nullable<double> Distance
        {
            get;
            set;
        }
        
        /// <summary>
        /// The values property
        /// </summary>
        ICollectionExpression<IComplex> Values
        {
            get;
        }
        
        /// <summary>
        /// Gets fired before the Distance property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> DistanceChanging;
        
        /// <summary>
        /// Gets fired when the Distance property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> DistanceChanged;
    }
}

