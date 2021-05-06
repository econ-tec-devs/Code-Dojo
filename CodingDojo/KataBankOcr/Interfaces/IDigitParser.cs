﻿// -----------------------------------------------------------------------
// <copyright file="IDigitParser.cs" company="econ-tec GmbH">
//     Copyright (c) econ-tec GmbH. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
namespace KataBankOcr.Interfaces
{
    public interface IDigitParser
    {
        void Parse(RawDigit rawDigit);
    }
}
