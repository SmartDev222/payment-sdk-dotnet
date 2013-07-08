<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimplePayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.SimplePayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="wrapper">
        <div id="header">
            <h3>Simple Payment</h3>
            <div id="apidetails">
                The Pay API operation is used to transfer
				funds from a sender's PayPal account to one or more receivers'
				PayPal accounts.
            </div>
        </div>
        <br />
        <form id="form1" runat="server" method="post">
            <div class="params">
                <div class="param_name">Currency Code*</div>
                <div class="param_value">
                    <input type="text" name="currencyCode" value="USD" />
                </div>
                <div class="param_name">Action Type*</div>
                <div class="param_value">
                    <select name="actionType">
                        <option value="PAY">Pay</option>
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
                <div class="param_name">IPN Notification URL (For receiving IPN call back from PayPal)</div>
                <div class="param_value">
                    <input type="text" name="ipnNotificationURL" value="" />
                </div>
                <div class="param_name">Sender Email</div>
                <div class="param_value">
                    <input type="text" name="senderEmail" value="jb-us-seller@paypal.com" />
                </div>
                <div class="section_header">ReceiverList:</div>
                <div class="note">Receiver is the party where funds are transferred to. </div>
                <table>
                    <tr>
                        <th class="param_name">Amount*</th>
                        <th class="param_name">E-mail</th>

                    </tr>
                    <tr>
                        <td class="param_value">
                            <input type="text" name="amount" value="2.00" />
                        </td>
                        <td class="param_value">
                            <input type="text" name="mail" value="pp15@paypal.com" />
                        </td>
                    </tr>

                </table>
                <div class="submit">
                    <asp:Button ID="AdaptivePaymentsBtn" Text="SimplePay" runat="server" PostBackUrl="~/AdaptivePaymentsHandler.ashx" />
                </div>
                <br />
                <a href="../Default.aspx">Home</a>
            </div>
        </form>
    </div>
</body>
</html>
