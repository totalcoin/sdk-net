#Métodos

1. GetAccessToken: Utiliza el Email y AppKey de la instancia, y retorna un Response con estas propiedades:

```
Message: ""
IsOk: true
Response: {
	TokenId: "2917A1D5-14BB-4ED2-AA1B-92733577E057"
	UserName: "usuario@dominio.com"
}
```

2. PerformCheckout: Recibe un objeto PurchaseInformation con estas propiedades:

```
"Amount" : 10,
"Quantity" : 1,
"Country" : "ARG",
"Currency" : "ARS",
"Description" : "Zapatillas adidas",
"FailureURL" : "http://totalcoin.com/failure",
"PendingURL" : "http://totalcoin.com/pending",
"SuccessURL" : "http://totalcoin.com/success",
"PaymentMethods" : "CREDITCARD|CASH|TOTALCOIN",
"Reference" : "004557898",
"Site": "WordPress",
"MerchantId": "EF0EA4C9-1C5E-41CC-8281-60BC33D4B122"
```

Retorna un objeto Response con estas propiedades:
```
Message: ""
IsOk: true
Response: {
	URL: "http://..."
}
```

3. GetMerchants: Utiliza el Email y AppKey de la instancia, y retorna un Response con estas propiedades

```
Message: ""
IsOk: true
Response: [
	{
		"Id": "8E9FC192-BB16-4948-A69F-005290591682",
		"Name": "Merchant1"
	},
	{
		"Id": "CD894EFB-BEE6-49EE-9B40-172E1210C821",
		"Name": "Merchant2"
	},
]
```

4. GetIpnInfo: Utiliza la AppKey de la instancia, y recibe como parámetro la referencia de la transacción

```
IsOk: true,
Message: null,
Response: {
	"Reference": "0000000017",
	"MerchantReference": "00010",
	"TransactionType": "Unknown",
	"Reason": "prueba",
	"Currency": "ARS",
	"PaidAmount": 5000,
	"NetAmount": 4756.18,
	"FinancingCost": 0,
	"TotalAmount": 5000,
	"TransactionHistories": [
		{
			"Date": "2015-06-23T16:04:59.09",
			"TransactionState": "InProccess"
		}
	],
	"Merchant": {
		"Id": "36102d0f-0023-429f-a125-b1ed56616c37",
		"Name": "Comercio Predefinido"
	},
	"FromUser": {
		"Phone": null,
		"FullName": "SEBASTIAN LAZARTE",
		"Email": "sebalazarte@outlook.com"
	},
	"ToUser": {
		"Phone": null,
		"FullName": "MAURO ZUCCOLO",
		"Email": "maurozuccolo@gmail.com"
	},
	"Provider": {
		"Name": "PAGO FACIL",
		"PaymentMethod": "Cash"
	}
}
```

#Ejemplos de uso

Se deberá importar la DLL de TotalCoin al proyecto realizado en .NET

1. Creación del objeto API:

```
using TotalCoin;

var api = new TotalCoin("email", "appKey");
```

2. GetToken:

```
var result = api.GetAccessToken();

```

3. GetMerchants:

```
var result = api.GetMerchants();

```

3. GetIpnInfo:

```
var result = api.GetIpnInfo("0000000017");

```

4. Checkout:

```
var info = new PurchaseInformation()
{
	Amount = new decimal(1000.50),
	Quantity = 1,
	Country = "ARG",
	Currency = "ARS",
	Description = "Zapatillas adidas",
	PaymentMethods = "CREDITCARD|CASH|TOTALCOIN",
	Reference = "004557898",
	Site = "WordPress",
	MerchantId = "EF0EA4C9-1C5E-41CC-8281-60BC33D4B122"
};

var result = api.PerformCheckout(info);

```
