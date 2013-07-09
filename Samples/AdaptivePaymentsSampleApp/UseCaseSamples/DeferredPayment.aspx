<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeferredPayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.DeferredPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="wrapper">
        <div id="header">
            <h3>Deferred Payment</h3>
            <div id="apidetails">
                <p>
                    Deferred payment is about  Creating a Payment (Using  Pay api with [actionType:create]) 
			        and Executing a Payment later(using ExecutingPayment api) . Here the sender Email should be the email of api caller(whose credential are used for api call),
			        the payment needs to be approved for a deferred payment.
                </p>
            </div>
        </div>
    </div>
    <br />
    <form id="form1" runat="server" method="post">
        <div id="request_form">
            <div class="params">
                <div class="param_name">Currency Code*</div>
                <div class="param_value">
                    <input type="text" name="currencyCode" value="USD" />
                </div>

                <div class="param_name">Action Type*</div>
                <div class="param_value">
                    <select name="actionType">
                        <option value="CREATE">Create</option>
                    </select>
                </div>
                <div class="param_name">Cancel URL*</div>
                <div class="param_value">
                    <input type="text" name="cancelURL" id="cancelURL" runat="server" />
                </div>
                <div class="param_name">Return URL*</div>
                <div class="param_value">
                    <input type="text" name="returnURL" id="returnURL" runat="server" />
                </div>
                <div class="param_name">
                    IPN Notification URL (For receiving IPN call back from PayPal)
                </div>
                <div class="param_value">
                    <input type="text" name="ipnNotificationURL" value="" />
                </div>

                <div class="param_name">Sender Email*</div>
                <div class="param_value">
                    <input type="text" name="senderEmail" value="jb-us-seller2@paypal.com" />
                </div>

                <div class="section_header">ReceiverList</div>
                <div class="note">
                    Receiver is the party where funds are
					transferred to.
                </div>
                <table>
                    <tr>
                        <th class="param_name">Amount*</th>
                        <th class="param_name">E-mail*</th>

                    </tr>
                    <tr>
                        <td class="param_value">
                            <input type="text" name="amount"
                                value="2.00" />
                        </td>
                        <td class="param_value">
                            <input type="text" name="mail"
                                value="platfo_1255612361_per@gmail.com" />
                        </td>
                    </tr>

                </table>
                <div class="submit">
                    <asp:Button ID="AdaptivePaymentsBtn" Text="DeferredPay" runat="server" PostBackUrl="~/AdaptivePaymentsHandler.ashx" />
                </div>
                <br />
                <a href="../Default.aspx">Home</a>
            </div>
        </div>
    </form>
    <br />
    <b>Note:</b>
    <div id="relatedcalls">
        The payment will be created with <b><i>Pay</i></b> API request, with the request parameter actionType as 'CREATE'. To complete the 
		Payment at a later date, you have to execute the payment using <i><b>ExecutePayment</b></i> API. If you have to set payment Option, 
		you need to call the optional API <i><b>SetPaymentOptions</b></i> before <i><b>ExecutePayment</b></i> API.			
    </div>
</body>
</html>
