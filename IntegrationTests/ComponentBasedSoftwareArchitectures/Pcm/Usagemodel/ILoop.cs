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
    /// The public interface for Loop
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Loop))]
    [XmlDefaultImplementationTypeAttribute(typeof(Loop))]
    public interface ILoop : IModelElement, IAbstractUserAction
    {
        
        /// <summary>
        /// The loopIteration_Loop property
        /// </summary>
        IPCMRandomVariable LoopIteration_Loop
        {
            get;
            set;
        }
        
        /// <summary>
        /// The bodyBehaviour_Loop property
        /// </summary>
        IScenarioBehaviour BodyBehaviour_Loop
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the LoopIteration_Loop property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> LoopIteration_LoopChanging;
        
        /// <summary>
        /// Gets fired when the LoopIteration_Loop property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> LoopIteration_LoopChanged;
        
        /// <summary>
        /// Gets fired before the BodyBehaviour_Loop property changes its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> BodyBehaviour_LoopChanging;
        
        /// <summary>
        /// Gets fired when the BodyBehaviour_Loop property changed its value
        /// </summary>
        event global::System.EventHandler<ValueChangedEventArgs> BodyBehaviour_LoopChanged;
    }
}

