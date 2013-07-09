<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChainedPayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.ChainedPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <div id="wrapper">
        <img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS" />
        <div id="header">
            <h3>Chained Payment</h3>
            <div id="apidetails">
                A chained payment is a payment from a
	            sender that is indirectly split among multiple receivers. It is an
	            extension of a typical payment from a sender to a receiver, in which
	            a receiver, known as the primary receiver, passes part of the
	            payment to other receivers, who are called secondary receivers
	            Create your PayRequest message by setting the common fields. If you
	            want more than a simple payment, add fields for the specific kind of
	            request, which include parallel payments, chained payments, implicit
	            payments, and preapproved payments.
            </div>
        </div>
    </div>
    <br />
    <form id="form1" runat="server" method="post">
        <div class="params">
            <div class="params">
                <div class="param_name">Currency Code*</div>
                <div class="param_value">
                    <input type="text" name="currencyCode" value="USD" />
                </div>
                <div class="param_name">Action Type*</div>
                <div class="param_value">
                    <select name="actionType">
                        <option value="PAY">Pay</option>
                        <option value="PAY_PRIMARY">Pay Primary</option>
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
                    IPN Notification URL (For receiving
						IPN call back from PayPal)
                </div>
                <div class="param_value">
                    <input type="text" name="ipnNotificationURL" value="" />
                </div>
                <div class="param_name">Sender Email</div>
                <div class="param_value">
                    <input type="text" name="senderEmail" value="jb-us-seller2@paypal.com" />
                </div>
                <div class="section_header">ReceiverList</div>
                <div class="note">
                    <p>
                        Receiver is the party where funds are
						transferred to. A primary receiver receives a payment directly
						from the sender in a chained split payment. A primary receiver
						should not be specified when making a single or parallel split
						payment. At most one receiver can be set as primary receiver
                    </p>
                </div>
                <table>
                    <tr>
                        <th class="param_name">Amount*</th>
                        <th class="param_name">E-mail*</th>
                        <th>Primary Receiver</th>
                    </tr>
                    <tr>
                        <td class="param_value">
                            <input type="text" name="amount"
                                value="2.00" />
                        </td>
                        <td class="param_value">
                            <input type="text" name="mail"
                                value="jb-us-seller@paypal.com" />
                        </td>
                        <td>
                            <select name="primaryReceiver" id="primaryReceiver_0"
                                class="smallfield">
                                <option value="true" selected="selected">true</option>
                                <option value="false">false</option>
                            </select></td>
                    </tr>
                    <tr>
                        <td class="param_value">
                            <input type="text" name="amount"
                                value="2.00" />
                        </td>
                        <td class="param_value">
                            <input type="text" name="mail"
                                value="sdk.seller@gmail.com" />
                        </td>
                        <td>
                            <select name="primaryReceiver" id="primaryReceiver_1"
                                class="smallfield">
                                <option value="true">true</option>
                                <option value="false" selected="selected">false</option>
                            </select></td>
                    </tr>
                </table>
            </div>
            <div class="submit">
                <asp:Button ID="AdaptivePaymentsBtn" Text="ChainedPay" runat="server" PostBackUrl="~/AdaptivePaymentsHandler.ashx" />
            </div>
            <br />
            <a href="../Default.aspx">Home</a>
        </div>
    </form>
</body>
</html>
