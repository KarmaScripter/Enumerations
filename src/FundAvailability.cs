﻿// <copyright file = "FundAvailability.cs" company = "Terry D. Eppler">
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
    /// Defines the Fiscal Year Availability of Appropriated Funds
    /// </summary>
    public enum FundAvailability
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// The none
        /// </summary>
        NS = 0,

        /// <summary>
        /// The expirirng
        /// </summary>
        Expiring = 1,

        /// <summary>
        /// The mulit year
        /// </summary>
        MultiYear = 2,

        /// <summary>
        /// The no year
        /// </summary>
        NoYear
    }
}
