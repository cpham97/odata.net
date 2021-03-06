//---------------------------------------------------------------------
// <copyright file="EdmStructuralProperty.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.Edm.Library
{
    /// <summary>
    /// Represents an EDM structural (i.e. non-navigation) property.
    /// </summary>
    public class EdmStructuralProperty : EdmProperty, IEdmStructuralProperty
    {
        private readonly string defaultValueString;
        private readonly EdmConcurrencyMode concurrencyMode;

        /// <summary>
        /// Initializes a new instance of the <see cref="EdmStructuralProperty"/> class.
        /// </summary>
        /// <param name="declaringType">The type that declares this property.</param>
        /// <param name="name">Name of the property.</param>
        /// <param name="type">The type of the property.</param>
        public EdmStructuralProperty(IEdmStructuredType declaringType, string name, IEdmTypeReference type)
            : this(declaringType, name, type, null,  EdmConcurrencyMode.None)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdmStructuralProperty"/> class.
        /// </summary>
        /// <param name="declaringType">The type that declares this property.</param>
        /// <param name="name">Name of the property.</param>
        /// <param name="type">The type of the property.</param>
        /// <param name="defaultValueString">The default value of this property.</param>
        /// <param name="concurrencyMode">The concurrency mode of this property.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "string", Justification = "defaultValue might be confused for an IEdmValue.")]
        public EdmStructuralProperty(IEdmStructuredType declaringType, string name, IEdmTypeReference type, string defaultValueString, EdmConcurrencyMode concurrencyMode)
            : base(declaringType, name, type)
        {
            this.defaultValueString = defaultValueString;
            this.concurrencyMode = concurrencyMode;
        }

        /// <summary>
        /// Gets the default value of this property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", Justification = "defaultValue might be confused for an IEdmValue.")]
        public string DefaultValueString
        {
            get { return this.defaultValueString; }
        }

        /// <summary>
        /// Gets the concurrency mode of this property.
        /// </summary>
        public EdmConcurrencyMode ConcurrencyMode
        {
            get { return this.concurrencyMode; }
        }

        /// <summary>
        /// Gets the kind of this property.
        /// </summary>
        public override EdmPropertyKind PropertyKind
        {
            get { return EdmPropertyKind.Structural; }
        }
    }
}