//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMFExamples.Identifier;
using NMFExamples.Pcm.Core.Composition;
using NMFExamples.Pcm.Repository;
using NMFExamples.Pcm.Resourcetype;
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

namespace NMFExamples.Pcm.Core.Entity
{
    
    
    /// <summary>
    /// The public interface for ResourceInterfaceRequiringEntity
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ResourceInterfaceRequiringEntity))]
    [XmlDefaultImplementationTypeAttribute(typeof(ResourceInterfaceRequiringEntity))]
    public interface IResourceInterfaceRequiringEntity : IModelElement, IEntity
    {
        
        /// <summary>
        /// The resourceRequiredRoles__ResourceInterfaceRequiringEntity property
        /// </summary>
        IListExpression<IResourceRequiredRole> ResourceRequiredRoles__ResourceInterfaceRequiringEntity
        {
            get;
        }
    }
}

