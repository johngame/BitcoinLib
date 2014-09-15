BitcoinLib
==========

[![tip for next commit](http://game4commit.gamers-coin.org/projects/20.svg)](http://game4commit.gamers-coin.org/projects/20)

![Gamerscoin](https://raw.githubusercontent.com/gamers-coin/gamers-coinv3/01d1ca6d63b565ea46dcee3b6552b030d57d1187/src/qt/res/icons/bitcoin.png)![Gamerscoin](http://i.imgur.com/Nfb8DQx.png)

**C# Bitcoin, Litecoin, Gamerscoin, Dogecoin and Bitcoin-Clones Library & RPC Wrapper**

Features
--------

- Design-by-contract, service-oriented architecture.
- Strongly-typed structures for complex RPC requests and responses.
- Implicit JSON casting for all RPC messages.
- Extended methods for every-day scenarios where the built-in methods fall short.
- Exposure of all RPC API's functionality as well as the extended methods through a single interface.
- Fallback mechanism for timed-out RPC requests.
- Custom RPC exceptions.
- Supports all Bitcoin clones.
- Can operate on unlimited daemons with a single library reference.
- Litecoin and Dogecoin integrations included.
- Each coin instance can be fully parametrized at run-time and implement its own constants.
- Console test client with demo methods implemented in it.
- Disconnected raw RPC connector included for quick'n'dirty debugging.
- Testnet ready.
- MONO compatible.
- Blockchain.info compatible.
- Fully configurable.


Instructions for Gamerscoin
------------------------

- Locate your `gamerscoin.conf` file (in Windows it's under: `%AppData%\Roaming\gamerscoin`, if it's not there just go ahead and create it) and add these lines:
	- rpcuser = MyRpcUsername
	- rpcpassword = MyRpcPassword
	- server=1
	- txindex=1

- Call `gamerscoind -reindex -txindex -debug=net -printtoconsole` and wait until it's finished re-indexing (it might take a while). Append `-testnet` if you want to run it for Testnet. You need to do this just once.

- Shut down gamerscoind and run it again with these arguments: `gamerscoind -daemon -debug=net -printtoconsole`. Append `-testnet` if you want to run it for Testnet. Wait until it is fully synchronized. 

- Edit the `app.config` file in the Console test client to best fit your needs. Make sure you also update the `gamerscoin.conf` when you alter the `Gamerscoin_RpcUsername` and `Gamerscoin_RpcPassword` parameters.

- You're good to go.


License
-------

BitcoinLib is released under the terms of the GPLv3 license. See [LICENSE](LICENSE) for more information or see http://opensource.org/licenses/GPL-3.0.


Support
-------

Please use GitHub's `Issues`. Premium support is also available [here](mailto:mcaizgk2+bitcoinlib@gmail.com).


Pull Requests
-------------

Please contact [the repository owner](mailto:mcaizgk2+bitcoinlib@gmail.com) via e-mail before submitting your first pull request.


Donations
---------

If you use BitcoinLib for a commercial project you are expected to make a donation. BTC: [1GeorgeKZn9SaTmGsuRQRasvoJS3YWzQ5a](https://blockchain.info/address/1GeorgeKZn9SaTmGsuRQRasvoJS3YWzQ5a)


Influenced by
-------------

- [Bitnet](http://bitnet.sourceforge.net), by Konstantin Ineshin
- [BitcoinRpcSharp](https://github.com/BitKoot/BitcoinRpcSharp), by BitKoot 
- [Bitcoin-wrapper](https://github.com/LarsHoldgaard/bitcoin-wrapper), by Lars Holdgaard 


Credits
-------

Thanks to everyone who contributed to making this library better: [@OperatorOverload](https://github.com/OperatorOverload), Angelos Leoussis, everyone who reported any issues, et al.
