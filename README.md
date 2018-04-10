# Getting started

By integrating GlobalMiles POS APIs, Merchants can offer to the GlobalMiles users  earn mile and shop with their miles in their in-stores.

Work Flow:
Common to dos both for Earn/Pay with miles. 

We will provide Client ID/ Secret Key. Ask us Please.
Before using any APIS of us, you need to authorise by using your Client ID / Secret Key  to get access_token.  
During shopping cashier ask GlobalMiles user  for  GSM No or QR code and enter into POS. 
POS software Post this info to GlobalMiles Server by using the API  GetCustomerInfo and get uniq identifier in order to  use at TransactionResult API  if you follow EarnMiles work Flow or  use at  StartBonusPayment API if you follow Use your Miles work flow. 

Earn Mile: 
After Getting Customer Info, Cashier will finalise the payment, as the payment done at POS post TransactionResult .

Use Your Mile(Bonus):

After Getting Customer Info, As all the items added to basket, Cashier ask for the payment method as the Globalmiles selected as payment method, Pos software Post this info GlobalMiles Server by using the API  StartBonusPayment .

An OTP code is send to the Customer mobile phone. The Customer/cashier enter this OTP into POS and this info Post to Globalmiles server by the BonusComplete API.

Cancel Payment with Miles:
By using Get Bonus Provision & CancelBonusPayment APIs  it allows to  list related sale on the POS and Cancel it .

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

* [PaymentSystemsController](#payment_systems_controller)
* [AuthenticationController](#authentication_controller)
* [CommonController](#common_controller)
* [BonusPaymentsController](#bonus_payments_controller)

## <a name="payment_systems_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.PaymentSystemsController") PaymentSystemsController

### Get singleton instance

The singleton instance of the ``` PaymentSystemsController ``` class can be accessed from the API Client.

```csharp
PaymentSystemsController paymentSystems = client.PaymentSystems;
```

### <a name="create_transaction_result"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.PaymentSystemsController.CreateTransactionResult") CreateTransactionResult

> After getting customer info by Get customer Info API and finished the shopping procedure in POS terminal, use this API to complete transaction.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
> and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b


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

Models.TransactionResultResponse result = await paymentSystems.CreateTransactionResult(body);

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

## <a name="common_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.CommonController") CommonController

### Get singleton instance

The singleton instance of the ``` CommonController ``` class can be accessed from the API Client.

```csharp
CommonController common = client.Common;
```

### <a name="create_get_customer_info"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.CommonController.CreateGetCustomerInfo") CreateGetCustomerInfo

> This API will help you to retrieve customer's mil quantity and unique identifier value.Unique identifier value must be used by Transaction Result API in order to complete shopping.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
> and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b


```csharp
Task<Models.GetCustomerInfoResponse> CreateGetCustomerInfo(Models.GetCustomerInfoRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.GetCustomerInfoRequest();

Models.GetCustomerInfoResponse result = await common.CreateGetCustomerInfo(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="bonus_payments_controller"></a>![Class: ](https://apidocs.io/img/class.png "GlobalMiles.Pos.Controllers.BonusPaymentsController") BonusPaymentsController

### Get singleton instance

The singleton instance of the ``` BonusPaymentsController ``` class can be accessed from the API Client.

```csharp
BonusPaymentsController bonusPayments = client.BonusPayments;
```

### <a name="create_start_bonus_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.BonusPaymentsController.CreateStartBonusPayment") CreateStartBonusPayment

> After getting customer info's and RecognitionID to start Payment with Miles Use this API.
> After calling this API successfully OTP code send to customer GSM number. This OTP must be used with Complete API in order to complete sale.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
> and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b


```csharp
Task<Models.StartBonusPaymentResponse> CreateStartBonusPayment(Models.StartBonusPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.StartBonusPaymentRequest();

Models.StartBonusPaymentResponse result = await bonusPayments.CreateStartBonusPayment(body);

```


### <a name="create_complete_bonus_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.BonusPaymentsController.CreateCompleteBonusPayment") CreateCompleteBonusPayment

> In order to finalize payment with Miles use this API. Use the OTP number  which is send to user GSM on the Request body.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
> and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b


```csharp
Task<Models.CompleteBonusPaymentResponse> CreateCompleteBonusPayment(Models.CompleteBonusPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CompleteBonusPaymentRequest();

Models.CompleteBonusPaymentResponse result = await bonusPayments.CreateCompleteBonusPayment(body);

```


### <a name="create_cancel_bonus_payment"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.BonusPaymentsController.CreateCancelBonusPayment") CreateCancelBonusPayment

> In order to cancel payment with miles you can use this API. It allows to cancel payment only related GSM and terminal ID numbers.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
> and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b


```csharp
Task<Models.CancelBonusPaymentResponse> CreateCancelBonusPayment(Models.CancelBonusPaymentRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.CancelBonusPaymentRequest();

Models.CancelBonusPaymentResponse result = await bonusPayments.CreateCancelBonusPayment(body);

```


### <a name="create_get_bonus_provisions"></a>![Method: ](https://apidocs.io/img/method.png "GlobalMiles.Pos.Controllers.BonusPaymentsController.CreateGetBonusProvisions") CreateGetBonusProvisions

> Before cancelling the payment with Miles this API is used to list the related sale.
> 
> You can try this API with configuring client parameters in Console Tab below. Test OAuthClientId is 552698b91cae424b9b3ddee14eea6faf564f1b5fb7764854b73b2763e0e68c66
> and OAuthClientSecret is d0a8b00a3d754ea5a013465bcc23f6efa89e9dfb080a4f4eb460e3306653d92b


```csharp
Task<Models.GetBonusProvisionsResponse> CreateGetBonusProvisions(Models.GetBonusProvisionsRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | The body of the request. |


#### Example Usage

```csharp
var body = new Models.GetBonusProvisionsRequest();

Models.GetBonusProvisionsResponse result = await bonusPayments.CreateGetBonusProvisions(body);

```


[Back to List of Controllers](#list_of_controllers)



