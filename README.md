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

//Using
//GET
var orders = bitmex.GetOrders("XBTUSD");//RETURN JSON - ALL TYPES ARE JUST PREDEFINED IN CLASS
var positions = bitmex.GetPositions("ETHXBT");//RETURN JSON - ALL TYPES ARE JUST PREDEFINED IN CLASS
var orderbook = bitmex.GetOrderBook("XBt", 25);//RETURN JSON - ALL TYPES ARE JUST PREDEFINED IN CLASS
var apiKey = bitmex.GetApiKey();//RETURN JSON
var depositAddress = bitmex.MyDeopsitAddress();//RETURN string BTC_ADDRESS
var marginBalance = bitmex.MarginBalance();//RETURN string BTC
var walletBalance = bitmex.WalletBalance();//RETURN string BTC
var avalaibleBalance = bitmex.AvalaibleBalance();//RETURN string BTC

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
bitmex.Withdrawal_Request("150000", "n43Ydq8NHrYVGxCk1AHP8ofFQ8j8w3LvSB", "google_auth_token");//API KEYS MUST HAVE A PERMISSION
bitmex.Withdrawal_Confirm("google_auth_token");//API KEYS MUST HAVE A PERMISSION

//Deserialize JSON example
var orders_ = JsonConvert.DeserializeObject<Orders[]>(orders); //All types are predefined in Bimex.IO class

Predefinet types:
<OrderBookItem[]>
<Positions[]>
<Orders[]>
<Wallet[]>
