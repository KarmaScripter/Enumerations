﻿// <copyright file = "DataType.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System;
    using System.Threading;

    /// <summary>
    /// Defines the DataType
    /// </summary>
    public enum DataType
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the Text
        /// </summary>
        Text,

        /// <summary>
        /// Defines the Integer
        /// </summary>
        Integer,

        /// <summary>
        /// Defines the BLOB
        /// </summary>
        Blob,

        /// <summary>
        /// Defines the Decimal
        /// </summary>
        Decimal,

        /// <summary>
        /// Defines the DateTime
        /// </summary>
        DateTime,

        /// <summary>
        /// Defines the Image
        /// </summary>
        Image,

        /// <summary>
        /// Defines the Hyperlink
        /// </summary>
        Hyperlink,

        /// <summary>
        /// Defines the FileStream
        /// </summary>
        FileStream
    }
}
