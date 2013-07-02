<%@ Page Language="C#" AutoEventWireup="true" Codebehind="GetShippingAddresses.aspx.cs"
    Inherits="AdaptivePaymentsSampleApp.GetShippingAddresses" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>PayPal Adaptive Payments - Get Shipping Addresses</title>
    <link rel="stylesheet" type="text/css" href="Content/sdk.css" />

    <script type="text/javascript" src="Content/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" src="Content/sdk_functions.js"></script>

</head>
<body>
    <div id="wrapper">
        <div id="header">
            <h3>
                Get Shipping Addresses</h3>
            <div id="apidetails">
                Use the GetShippingAddresses API operation to obtain the selected shipping address.
                You must have created the payment payKey that identifies the account holder whose
                shipping address you want to obtain, or be the primary receiver of the payment or
                one of the parallel receivers of the payment. The shipping address is available
                only if it was provided during the embedded payment flow.</div>
        </div>
        <div id="request_form">
            <form id="Form1" method="post" action="AdaptivePaymentsHandler.ashx" runat="server">
                <div class="params">
                    <div class="param_name">
                        Key (Pay key or preapproval key) *</div>
                    <div class="param_value">
                        <input name="key" id="key" value="AP-23119815K9918782X" />
                    </div>
                </div>
                <div class="submit">
                    <asp:Button ID="AdaptivePaymentsBtn" Text="GetShippingAddresses" runat="server" PostBackUrl="AdaptivePaymentsHandler.ashx" />
                </div>
            </form>
        </div>
        <a href="Default.aspx">Home</a>
    </div>
</body>
</html>
