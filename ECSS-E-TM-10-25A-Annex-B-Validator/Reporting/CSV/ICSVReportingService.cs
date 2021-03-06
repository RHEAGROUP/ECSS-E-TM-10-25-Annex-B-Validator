﻿// -------------------------------------------------------------------------------------------------
// <copyright file="ICsvReportingService.cs" company="RHEA System S.A.">
//   Copyright (c) 2019 RHEA System S.A.
//
//   This file is part of ECSS-E-TM-10-25A Annex B Validator
//
//   The ECSS-E-TM-10-25A Annex B Validator is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//   
//   ECSS-E-TM-10-25A Annex B Validator is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with ECSS-E-TM-10-25A Annex B Validator. If not, see<http://www.gnu.org/licenses/>.
// </copyright>
// -------------------------------------------------------------------------------------------------

namespace com.rheagroup.validator.Reporting
{
    using System.Collections.Generic;
    using CDP4Rules.Common;

    /// <summary>
    /// Definition of the <see cref="ICsvReportingService"/> used to generate
    /// an CSV report of the <see cref="RuleCheckResult"/>s
    /// </summary>
    public interface ICsvReportingService
    {
        /// <summary>
        /// Generates an CSV report with the results of a validation run.
        /// </summary>
        /// <param name="target">
        /// the target path
        /// </param>
        /// <param name="results">
        /// The <see cref="RuleCheckResult"/> from which a report is to be generated
        /// </param>
        void Generate(string target, IEnumerable<RuleCheckResult> results);
    }
}