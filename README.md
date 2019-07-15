# Getting started

By integrating Global Miles POS APIs, Merchants can offer to the Global Miles users  earn mile and shop with their miles in their in-stores.

Work Flow:
Common to dos both for Earn/Pay with miles. 

We will provide Client ID/ Secret Key.
Before using any endpoints of us, you need to authorize by using your Client ID / Client Secret to get access_token. 
During shopping cashier ask GlobalMiles user for GSM / FFP ID / Code or EMail and enter into POS. 
POS software Post this info to Global Miles Server by using the endpoint GetCustomerInfo and get unique identifier in order to use at TransactionResult endpoint if you follow EarnMiles work Flow or use at  StartMilePayment endpoint if you follow use your Miles work flow. 

Earn Mile: 
After Getting Customer Info, Cashier will finalize the payment, as the payment done at POS post TransactionResult.

Pay with Miles:
After Getting Customer Info, as all the items added to basket, Cashier ask for the payment method as the Global Miles selected as payment method, Pos software Post this info Global Miles Server by using the endpoint StartMilePayment.

An OTP code is send to the Customer mobile phone. The Customer/cashier enter this OTP into POS and this info Post to Global Miles server by the CompleteMilePayment endpoint.

Cancel Payment with Miles:
By using Get Mile Provision & CancelMilePayment endpoints  it allows to  list related sale on the POS and Cancel it .

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (GlobalMilesPos.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the GlobalMilesPos library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

### 3. Add reference of the library project

In order to use the GlobalMilesPos library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` GlobalMilesPos.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```GlobalMilesPos.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=GlobalMilesPos-CSharp&workspaceName=GlobalMilesPos&projectName=GlobalMilesPos.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthClientId | OAuth 2 Client ID |
| oAuthClientSecret | OAuth 2 Client Secret |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
string oAuthClientSecret = "oAuthClientSecret"; // OAuth 2 Client Secret

GlobalMilesPosClient client = new GlobalMilesPosClient(oAuthClientId, oAuthClientSecret);
```


You must now authorize the client.

### Authorizing your client

This SDK uses *OAuth 2.0 authorization* to authorize the client.

The `Authorize()` method will exchange the OAuth client credentials for an *access token*.
The access token is an object containing information for authorizing client requests.


```csharp
try
{
    client.Auth.Authorize();
}
catch (OAuthProviderException e)
{
    //handle exception here
}
```

The client can now make authorized endpoint calls.


### Storing an access token for reuse

It is recommended that you store the access token for reuse.

You can store the access token in a file or a database.

```csharp
// store token
SaveTokenToDatabase(Configuration.OAuthToken);
```

### Creating a client from a stored token

To authorize a client from a stored access token, just set the access token after creating the client:

```csharp
client = GlobalMilesPosClient();
Configuration.UpdateAccessToken(LoadTokenFromDatabase());
```

### Complete example
```csharp
using GlobalMiles.Pos;
using GlobalMiles.Pos.Models;
using GlobalMiles.Pos.Exceptions;
using System.Collections.Generic;

namespace OAuthTestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configuration parameters and credentials
           string oAuthClientId = "oAuthClientId"; // OAuth 2 Client ID
           string oAuthClientSecret = "oAuthClientSecret"; // OAuth 2 Client Secret
           
            GlobalMilesPosClient client = new GlobalMilesPosClient(oAuthClientId, oAuthClientSecret);

            //callback for storing token for reuse when token is updated
            Configuration.OAuthTokenUpdateCallback = SaveTokenToDatabase;

            //obtain access token, needed for client to be authorized
            OAuthToken storedToken = LoadTokenFromDatabase();
            if (storedToken != null)
            {
                Configuration.OAuthToken = storedToken;
            }
            else
            {
                try
                {
                    storedToken = client.Auth.Authorize();
                    SaveTokenToDatabase(storedToken);
                }
                catch (OAuthProviderException e)
                {
                    //Handle Exception here
                }
            }
        }

        //function for storing token to database
        static void SaveTokenToDatabase(OAuthToken token)
        {
            //Save token here
        }

        //function for loading token from database
        static OAuthToken LoadTokenFromDatabase()
        {
            OAuthToken token = null;
            //token = Get token here
            return token;
        }
    }
}

// the client is now authorized and you can use controllers to make endpoint calls
```


# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [PayWithMilesController](#pay_with_miles_controller)
* [AuthenticationController](#authentication_controller)
* [EarnMilesController](#earn_miles_controller)
* [CommonController](#common_controller)

## <a name="pay_with_miles_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.PayWithMilesController") PayWithMilesController

### Get singleton instance

The singleton instance of the ``` PayWithMilesController ``` class can be accessed from the API Client.

```csharp
PayWithMilesController payWithMiles = client.PayWithMiles;
```

### <a name="delete_cancel_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.PayWithMilesController.DeleteCancelMilePayment") DeleteCancelMilePayment

> In order to cancel payment with miles you can use this endpoint. It allows to cancel payment only related GSM and terminal ID numbers.
> 
> You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.CancelMilePaymentResponse> DeleteCancelMilePayment(int milesPaymentProvisionId, Models.CancelMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| milesPaymentProvisionId |  ``` Required ```  | Provision ID. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
int milesPaymentProvisionId = 241;
var body = new Models.CancelMilePaymentRequest();

Models.CancelMilePaymentResponse result = await payWithMiles.DeleteCancelMilePayment(milesPaymentProvisionId, body);

```


### <a name="update_complete_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.PayWithMilesController.UpdateCompleteMilePayment") UpdateCompleteMilePayment

> In order to finalize payment with miles use this endpoint. Use the OTP number which is send to user GSM on the Request body.
> 
> You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.CompleteMilePaymentResponse> UpdateCompleteMilePayment(int milesPaymentProvisionId, Models.CompleteMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| milesPaymentProvisionId |  ``` Required ```  | Provision ID. |
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
int milesPaymentProvisionId = 241;
var body = new Models.CompleteMilePaymentRequest();

Models.CompleteMilePaymentResponse result = await payWithMiles.UpdateCompleteMilePayment(milesPaymentProvisionId, body);

```


### <a name="create_start_mile_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.PayWithMilesController.CreateStartMilePayment") CreateStartMilePayment

> After getting customer info's and RecognitionID to start Payment with Miles Use this endpoint.
> After calling this endpoint successfully OTP code send to customer GSM number. This OTP must be used with Complete endpoint in order to complete payment.
> 
> You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.StartMilePaymentResponse> CreateStartMilePayment(Models.StartMilePaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.StartMilePaymentRequest();

Models.StartMilePaymentResponse result = await payWithMiles.CreateStartMilePayment(body);

```


### <a name="get_mile_provisions"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.PayWithMilesController.GetMileProvisions") GetMileProvisions

> Before cancelling the payment with miles this endpoint is used to list the related sale.
> 
> You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.GetMileProvisionsResponse> GetMileProvisions(string readCode, string readCodeType, string terminalId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| readCode |  ``` Required ```  | Customer Identification Method; GSM, FFP ID, CODE or EMAIL. |
| readCodeType |  ``` Required ```  | 1: GSM, 2: FFP ID, 3: CODE, 4: EMAIL |
| terminalId |  ``` Required ```  | Terminal ID. |


#### Example Usage

```csharp
string readCode = "read_code";
string readCodeType = "read_code_type";
string terminalId = "terminal_id";

Models.GetMileProvisionsResponse result = await payWithMiles.GetMileProvisions(readCode, readCodeType, terminalId);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="authentication_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.AuthenticationController") AuthenticationController

### Get singleton instance

The singleton instance of the ``` AuthenticationController ``` class can be accessed from the API Client.

```csharp
AuthenticationController authentication = client.Authentication;
```

### <a name="create_authentication"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.AuthenticationController.CreateAuthentication") CreateAuthentication

> *Tags:*  ``` Skips Authentication ``` 

> An access token will allow you to make requests for the system. We support only one type of token: client_credentials


```csharp
Task<Models.OAuthResponse> CreateAuthentication(Models.OAuthRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.OAuthRequest();

Models.OAuthResponse result = await authentication.CreateAuthentication(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="earn_miles_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.EarnMilesController") EarnMilesController

### Get singleton instance

The singleton instance of the ``` EarnMilesController ``` class can be accessed from the API Client.

```csharp
EarnMilesController earnMiles = client.EarnMiles;
```

### <a name="create_transaction_result"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.EarnMilesController.CreateTransactionResult") CreateTransactionResult

> After getting customer info by Get Customer Info endpoint and finished the shopping procedure in POS terminal, use this endpoint to complete transaction.
> 
> You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.TransactionResultResponse> CreateTransactionResult(Models.TransactionResultRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.TransactionResultRequest();

Models.TransactionResultResponse result = await earnMiles.CreateTransactionResult(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="common_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.CommonController") CommonController

### Get singleton instance

The singleton instance of the ``` CommonController ``` class can be accessed from the API Client.

```csharp
CommonController common = client.Common;
```

### <a name="get_terminal_info"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.CommonController.GetTerminalInfo") GetTerminalInfo

> This endpoint will help you to get terminal settings in order to use internal operations.
> 
> You can try this endpoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.GetTerminalInfoResponse> GetTerminalInfo(string terminalId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| terminalId |  ``` Required ```  | Terminal ID. |


#### Example Usage

```csharp
string terminalId = "terminal_id";

Models.GetTerminalInfoResponse result = await common.GetTerminalInfo(terminalId);

```


### <a name="get_customer_info"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.CommonController.GetCustomerInfo") GetCustomerInfo

> This endpoint will help you to get customer's miles amount as a currency and unique identifier value. Unique identifier value must be used by Transaction Result endpint in order to complete shopping.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.GetCustomerInfoResponse> GetCustomerInfo(
        string readCode,
        string readCodeType,
        double totalAmount,
        double totalVatAmount,
        string currency,
        int partnerId,
        int branchId,
        string terminalId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| readCode |  ``` Required ```  | Customer Identification Method; GSM, FFP ID, CODE or EMAIL |
| readCodeType |  ``` Required ```  | 1: GSM, 2: FFP ID, 3: CODE, 4: EMAIL |
| totalAmount |  ``` Required ```  | Total receipt amount. |
| totalVatAmount |  ``` Required ```  | Total tax value. |
| currency |  ``` Required ```  | ISO-4217 3-letter currency code. |
| partnerId |  ``` Required ```  | Partner ID. |
| branchId |  ``` Required ```  | Branch ID. |
| terminalId |  ``` Required ```  | Terminal ID. |


#### Example Usage

```csharp
string readCode = "read_code";
string readCodeType = "read_code_type";
double totalAmount = 241.640897237994;
double totalVatAmount = 241.640897237994;
string currency = "currency";
int partnerId = 241;
int branchId = 241;
string terminalId = "terminal_id";

Models.GetCustomerInfoResponse result = await common.GetCustomerInfo(readCode, readCodeType, totalAmount, totalVatAmount, currency, partnerId, branchId, terminalId);

```


### <a name="upload_receipt_pictures"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.CommonController.UploadReceiptPictures") UploadReceiptPictures

> This endpoint will help you to upload receipt pictures which is related with a recognition ID and a transaction result.
> 
> You can try this endoint with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is b30359c21700fd6f2b91154adcb7b37bab3e7e0a33e22682e5dd149d7a6ac4df
> and OAuthClientSecret is 4bc4335faad41d6a23cd059e495005f00496a64e34e6187b1d72695a8debd28c


```csharp
Task<Models.ReceiptPictureResponse> UploadReceiptPictures(Models.ReceiptPictureRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.ReceiptPictureRequest();

Models.ReceiptPictureResponse result = await common.UploadReceiptPictures(body);

```


[Back to List of Controllers](#list_of_controllers)



