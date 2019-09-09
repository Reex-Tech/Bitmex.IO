# Bitmex.IO
Wrapper for BitMEX.com API

Requires:
Newtosoft.Json

Instalation:
PM> Install-Package BitMEX.IO -Version 1.7.1
PM> Install-Package Newtonsoft.Json -Version 12.0.3-beta1

c#
Using BitMEX.IO

// Initialize
public static string bitmexKey = "ApiKey";
public static string bitmexSecret = "SecretKey";
BitmexApi bitmex = new BitmexApi(bitmexKey, bitmexSecret,"mainnet");

//for testnet:
BitmexApi bitmex = new BitmexApi(bitmexKey, bitmexSecret,"testnet");

or

BitmexApi bitmex = new BitmexApi(bitmexKey, bitmexSecret);



//GET

var orders = bitmex.GetOrders("XBTUSD");
var positions = bitmex.GetPositions("ETHXBT");
var orderbook = bitmex.GetOrderBook("XBt", 25);
var apiKey = bitmex.GetApiKey();//RETURN JSON
var depositAddress = bitmex.MyDeopsitAddress();
var marginBalance = bitmex.MarginBalance();
var walletBalance = bitmex.WalletBalance();
var avalaibleBalance = bitmex.AvalaibleBalance();

//POST

bitmex.PostOrderLimit("XBTUSD", "Buy", "1", "5000");
bitmex.PostOrderMarket("XBTUSD", "Buy", "1");
bitmex.PostOrderStopMarket("XBTUSD", "Sell", "1", "9000");
bitmex.PostOrderStopLimit("XBTUSD", "Buy", "1", "13000", "9000");
bitmex.PostOrderTakeProfitLimit("XBTUSD", "Buy", "1", "13000", "12000");
bitmex.PostOrderTakeProfitMarket("XBTUSD", "Buy", "1", "13000");
bitmex.ClosePosition("XBTUSD", "10000");
bitmex.DeleteAllOrders();
bitmex.DeleteOrderByID("Order_id_from_GetOrders_first_columns");
bitmex.PostLeverage("XBTUSD", "20");
bitmex.TransferMargin("XBTUSD", "150000");
bitmex.Withdrawal_Request("amount_satosi", "btc_address", "google_auth_token");
bitmex.Withdrawal_Confirm("google_auth_token");

//Deserialize JSON example
var orders_ = JsonConvert.DeserializeObject<Orders[]>(orders); 
//All types are predefined in Bimex.IO class

Predefinet types:
<OrderBookItem[]>
<Positions[]>
<Orders[]>
<Wallet[]>
