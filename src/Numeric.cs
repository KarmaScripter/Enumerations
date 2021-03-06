﻿// <copyright file = "Numeric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    // ********************************************************************************************************************************
    // *********************************************************  ASSEMBLIES   ********************************************************
    // ********************************************************************************************************************************

    using System.Threading;
    using System;

    // ******************************************************************************************************************************
    // ******************************************************  MEMEBERS      ********************************************************
    // ******************************************************************************************************************************

    /// <summary>
    /// 
    /// </summary>
    public enum Numeric
    {
        //************************************************************************************ */
        //*******************          Program Elements           **************************** */
        //************************************************************************************ */
        NS = 0,

        /// <summary>
        /// The identifier
        /// </summary>
        Id,

        // *************************************************************
        // **************    LEAVE PROJECTION  FIELDS ******************
        // *************************************************************

        /// <summary>
        /// The year to date earned
        /// </summary>
        YearToDateEarned,

        /// <summary>
        /// The year to date used
        /// </summary>
        YearToDateUsed,

        /// <summary>
        /// The maximum leave carryover
        /// </summary>
        MaxLeaveCarryover,

        /// <summary>
        /// The maximum carryover excess
        /// </summary>
        MaxCarryoverExcess,

        /// <summary>
        /// The projected pay period
        /// </summary>
        ProjectedPayPeriod,

        /// <summary>
        /// The projected annual
        /// </summary>
        ProjectedAnnual,

        /// <summary>
        /// The use or lose
        /// </summary>
        UseOrLose,

        /// <summary>
        /// The available hours
        /// </summary>
        AvailableHours,

        /// <summary>
        /// The annual base hours
        /// </summary>
        AnnualBaseHours,

        /// <summary>
        /// The cumulative benefits
        /// </summary>
        CumulativeBenefits,

        /// <summary>
        /// The annual other paid
        /// </summary>
        AnnualOtherPaid,

        /// <summary>
        /// The annual overtime hours
        /// </summary>
        AnnualOvertimeHours,

        /// <summary>
        /// The expended
        /// </summary>
        Expended,

        //************************************************************* */
        //**************       ProgramResultsCode-   ****************** */
        //************************************************************* */

        /// <summary>
        /// The amount
        /// </summary>
        Amount,

        //************************************************************* */
        //**************        OUTLAY  FIELDS       ****************** */
        //************************************************************* */

        /// <summary>
        /// The rate
        /// </summary>
        Rate,

        /// <summary>
        /// The obligations
        /// </summary>
        Obligations,

        /// <summary>
        /// The unliquidated obligations
        /// </summary>
        UnliquidatedObligations,

        /// <summary>
        /// The deobligations
        /// </summary>
        Deobligations,

        /// <summary>
        /// The commitments
        /// </summary>
        Commitments,

        /// <summary>
        /// The open commitments
        /// </summary>
        OpenCommitments,

        /// <summary>
        /// The ulo
        /// </summary>
        ULO,

        /// <summary>
        /// The expenditures
        /// </summary>
        Expenditures,

        /// <summary>
        /// The authority
        /// </summary>
        Authority,

        /// <summary>
        /// The budgeted
        /// </summary>
        Budgeted,

        /// <summary>
        /// The posted
        /// </summary>
        Posted,

        /// <summary>
        /// The balance
        /// </summary>
        Balance,

        /// <summary>
        /// The hours
        /// </summary>
        Hours,

        /// <summary>
        /// The carry in
        /// </summary>
        CarryIn,

        /// <summary>
        /// The carry out
        /// </summary>
        CarryOut,

        /// <summary>
        /// The available
        /// </summary>
        Available,

        //************************************************************* */
        //**************  PAYROLL OBLIGATION FIELDS  ****************** */
        //************************************************************* */

        /// <summary>
        /// The annual overtime paid
        /// </summary>
        AnnualOvertimePaid,

        /// <summary>
        /// The annual base paid
        /// </summary>
        AnnualBasePaid,

        /// <summary>
        /// The annual other hours
        /// </summary>
        AnnualOtherHours,

        /// <summary>
        /// The allocation percentage
        /// </summary>
        AllocationPercentage,

        /// <summary>
        /// The compensation rate
        /// </summary>
        CompensationRate,

        //************************************************************************************ */
        //*******************              Procurements             ************************** */
        //************************************************************************************ */

        /// <summary>
        /// The ordered
        /// </summary>
        Ordered,

        //************************************************************************************ */
        //*******************              Requisitions             ************************** */
        //************************************************************************************ */   

        /// <summary>
        /// The requested
        /// </summary>
        Requested,

        /// <summary>
        /// The closed
        /// </summary>
        Closed,

        /// <summary>
        /// The outstanding
        /// </summary>
        Outstanding,

        /// <summary>
        /// The reversed
        /// </summary>
        Reversed,

        //************************************************************************************ */
        //*******************              Payments              **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The payment
        /// </summary>
        Payment,

        /// <summary>
        /// The disbursed
        /// </summary>
        Disbursed
    }
}
