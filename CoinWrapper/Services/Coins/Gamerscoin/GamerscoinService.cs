// Copyright (c) 2014 George Kimionis
// Distributed under the GPLv3 software license, see the accompanying file LICENSE or http://opensource.org/licenses/GPL-3.0

using System;
using BitcoinLib.CoinParameters.Gamerscoin;

namespace BitcoinLib.Services.Coins.Gamerscoin
{
    public class GamerscoinService : CoinService, IGamerscoinService
    {
        public GamerscoinService(Boolean useTestnet = false) : base(useTestnet)
        {
        }

        public GamerscoinService(String daemonUrl, String rpcUsername, String rpcPassword, String walletPassword = null) : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public GamerscoinConstants.Constants Constants
        {
            get
            {
                return GamerscoinConstants.Constants.Instance;
            }
        }
    }
}