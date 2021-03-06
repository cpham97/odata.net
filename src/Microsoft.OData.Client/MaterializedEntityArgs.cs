//---------------------------------------------------------------------
// <copyright file="MaterializedEntityArgs.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace Microsoft.OData.Client
{
    using Microsoft.OData.Core;

    /// <summary>
    /// Materialized Entity arguments
    /// </summary>
    public sealed class MaterializedEntityArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterializedEntityArgs"/> class.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <param name="entity">The entity.</param>
        public MaterializedEntityArgs(ODataEntry entry, object entity)
        {
            Util.CheckArgumentNull(entry, "entry");
            Util.CheckArgumentNull(entity, "entity");
            this.Entry = entry;
            this.Entity = entity;
        }

        /// <summary>
        /// Gets the entry.
        /// </summary>
        /// <value>
        /// The entry.
        /// </value>
        public ODataEntry Entry { get; private set; }

        /// <summary>
        /// Gets the entity.
        /// </summary>
        public object Entity { get; private set; }
    }
}
