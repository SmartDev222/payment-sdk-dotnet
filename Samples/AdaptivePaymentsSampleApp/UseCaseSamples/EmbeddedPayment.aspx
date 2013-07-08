<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmbeddedPayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.EmbeddedPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div id="wrapper">
        <div id="header">
            <h3>Embedded Payment</h3>
            <div id="apidetails">
                An embedded payment is a payment that
				initiates a visual presentation of the Adaptive Payments payment
				flow in which the sender appears to never leave your checkout or
				payment page. Embedded payments make it easier for a sender to make
				a payment because PayPal may allow the sender to bypass the PayPal
				login step.
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
                    <div class="param_name">
                        IPN Notification URL (For receiving IPN call back from PayPal)
                    </div>
                    <div class="param_value">
                        <input type="text" name="ipnNotificationURL" value="" />
                    </div>
                    <div class="param_name">Sender Email</div>
                    <div class="param_value">
                        <input type="text" name="senderEmail"
                            value="jb-us-seller@paypal.com" />
                    </div>
                    <div class="section_header">ReceiverList:</div>
                    <div class="note">
                        Receiver is the party where funds are
						transferred to.
                    </div>
                    <table>
                        <tr>
                            <th class="param_name">Amount*</th>
                            <th class="param_name">E-mail</th>

                        </tr>
                        <tr>
                            <td class="param_value">
                                <input type="text" name="amount"
                                    value="2.00" /></td>
                            <td class="param_value">
                                <input type="text" name="mail"
                                    value="pp15@paypal.com" /></td>
                        </tr>

                    </table>
                    <div class="submit">
                        <asp:Button ID="AdaptivePaymentsBtn" Text="EmbeddedPay" runat="server" PostBackUrl="~/AdaptivePaymentsHandler.ashx" />
                    </div>
                    <br />
                    <a href="../Default.aspx">Home</a>
                </div>
            </div>
        </form>
    </div>

    <script src='https://www.paypalobjects.com/js/external/dg.js' type='text/javascript'></script>
    <script type="text/javascript">

        var dg = new PAYPAL.apps.DGFlow(
        {
            trigger: 'paypal_submit',
            expType: 'instant'
            //PayPal will decide the experience type for the buyer based on his/her 'Remember me on your computer' option.
        });

    </script>

</body>
</html>
