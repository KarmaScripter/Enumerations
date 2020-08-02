﻿// <copyright file = "BOC.cs " company = "Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;

namespace BudgetExecution
{
    using System.Threading;

    /// <summary>
    /// Defines the BOC
    /// </summary>
    public enum BOC
    {
        // ******************************************************************************************************************************
        // ******************************************************   MEMBERS   ***********************************************************
        // ******************************************************************************************************************************

        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the Payroll
        /// </summary>
        Payroll = 10,

        /// <summary>
        /// Defines the FullTimeEquivalent
        /// </summary>
        FTE = 17,

        /// <summary>
        /// The travel
        /// </summary>
        Travel = 21,

        /// <summary>
        /// The site travel
        /// </summary>
        SiteTravel = 28,

        /// <summary>
        /// Defines the Expenses
        /// </summary>
        Expenses = 36,

        /// <summary>
        /// Defines the Contracts
        /// </summary>
        Contracts = 37,

        /// <summary>
        /// Defines the WCF
        /// </summary>
        WCF = 38,

        /// <summary>
        /// Defines the Grants
        /// </summary>
        Grants = 41
    }
}