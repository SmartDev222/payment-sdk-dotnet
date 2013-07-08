<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ParallelPayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.ParallelPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="wrapper">
        <div id="header">
            <h3>Parallel Payment</h3>
            <div id="apidetails">
                The Pay API operation is used to transfer
				funds from a sender's PayPal account to one or more receivers'
				PayPal accounts. You can use the Pay API operation to make simple
				payments, chained payments, or parallel payments; these payments can
				be explicitly approved, preapproved, or implicitly approved.
				Parallel payments are useful in cases when a buyer intends to make a
				single payment for items from multiple sellers. Examples include the
				following scenarios: a single payment for multiple items from
				different merchants, such as a combination of items in your
				inventory and items that partners drop ship for you. purchases of
				items related to an event, such as a trip that requires airfare, car
				rental, and a hotel booking
            </div>
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
            <div class="section_header">ReceiverList</div>
            <div class="note">
                Receiver is the party where funds are
						transferred to. Each receiver receives a payment directly
						from the sender in a parallel payment.
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
                            value="pp15@paypal.com" />
                    </td>
                </tr>
                <tr>
                    <td class="param_value">
                        <input type="text" name="amount"
                            value="2.00" />
                    </td>
                    <td class="param_value">
                        <input type="text" name="mail"
                            value="pp14@paypal.com" />
                    </td>
                </tr>
            </table>
            <div class="submit">
                <asp:Button ID="AdaptivePaymentsBtn" Text="ParallelPay" runat="server" PostBackUrl="~/AdaptivePaymentsHandler.ashx" />
            </div>
            <br />
            <a href="../Default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
