// Copyright (c) 2014 George Kimionis
// Distributed under the GPLv3 software license, see the accompanying file LICENSE or http://opensource.org/licenses/GPL-3.0

using System;
using BitcoinLib.CoinParameters.Base;

namespace BitcoinLib.CoinParameters.Gamerscoin
{
    public static class GamerscoinConstants
    {
        public sealed class Constants : CoinConstants<Constants>
        {
            public readonly UInt16 CoinReleaseHalfsEveryXInYears = 1;
            public readonly UInt16 DifficultyIncreasesEveryXInBlocks = 1;
            public readonly UInt32 OneGamerscoinInLitetoshis = 100000000;
            public readonly Decimal OneGamerstoshiInGMC = 0.00000001M;
            public readonly Decimal OneMicrocoinInGMC = 0.000001M;
            public readonly Decimal OneMillicoinInGMC = 0.001M;
            public readonly String Symbol = "G";
        }
    }
}