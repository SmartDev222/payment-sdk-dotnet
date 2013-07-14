<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmbeddedPayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.EmbeddedPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AdaptivePayments API - Embedded Payment</title>
    <link rel="stylesheet" type="text/css" href="../Content/sdk.css" />
    <script type="text/javascript" src="../Content/jquery-1.3.2.min.js"></script>
    <script type="text/javascript" src="../Content/sdk_functions.js"></script>
</head>
<body>
	<img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <div id="wrapper">
        <div id="header">
            <h3>Embedded Payment</h3>
            <div id="apidetails">
             <p>
                <i>                    
                    An Embedded Payment is a Payment that initiates a visual presentation of the Adaptive Payments Payment Flow in which the sender appears to never leave your checkout or Payment page. 
                    Embedded Payments make it easier for a sender to make a payment because PayPal may allow the sender to bypass the PayPal Login.
                </i>
                </p>
            </div>
        </div>
        <br />
        <form id="form1" runat="server">
            <div id="request_form">
                <div class="params">
                    <div class="param_name">Currency Code*</div>
                    <div class="param_value">
                        <input type="text" name="currencyCode" value="USD" />
                    </div>
                    <div class="param_name">Action Type*</div>
                    <div class="param_value">
                        <asp:DropDownList runat="server" ID="actionType">
                            <asp:ListItem Text="Pay" Value="PAY" Selected="True" />
                            <asp:ListItem Text="Pay Primary" Value="PAY_PRIMARY" />
                            <asp:ListItem Text="Create" Value="CREATE" />
                    </asp:DropDownList>
                    </div>
                    <div class="param_name">Cancel URL*</div>
                    <div class="param_value">
                        <asp:TextBox runat="server" ID="cancelURL" />
                    </div>
                    <div class="param_name">Return URL*</div>
                    <div class="param_value">
                        <asp:TextBox runat="server" ID="returnURL" />
                    </div>
                    <div class="param_name">
                        IPN Notification URL (For receiving IPN call back from PayPal)
                    </div>
                    <div class="param_value">
                        <asp:TextBox runat="server" ID="ipnNotificationURL" />
                    </div>
                    <div class="param_name">Sender Email</div>
                    <div class="param_value">
                        <asp:TextBox runat="server" ID="senderEmail" Text="jb-us-seller2@paypal.com" />
                    </div>
                    <div class="section_header">Receiver</div>
                    <div class="note">
                        <i>Receiver is the party to whom funds are transferred.</i>
                    </div>
                    <table>
                        <tr>
                            <th class="param_name">Amount*</th>
                            <th class="param_name">Email</th>
                        </tr>
                        <tr>
                            <td class="param_value">
                                <asp:TextBox runat="server" ID="amount" Text="1.00" />
                            </td>
                            <td class="param_value">
                                <asp:TextBox runat="server" ID="mail" Text="platfo_1255612361_per@gmail.com" Columns="35" />
                            </td>
                        </tr>

                    </table>
                    <br />
                    <div class="submit">
                        <asp:Button ID="ButtonAdaptivePayments" Text="EmbeddedPayment" runat="server" PostBackUrl="~/UseCaseSamples/RequestResponse.aspx" />
                    </div>
                    <br />
                    <asp:HyperLink runat="server" ID="HyperLinkHome" NavigateUrl="~/Default.aspx" Text="Home" />
                    <br />
                    <br />
                    <asp:HyperLink ID="HyperLinkBack" runat="server" NavigateUrl="javascript:history.back();" Text="Back" />
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
            // PayPal will decide the experience type for the buyer based on his/her 'Remember me on your computer' option.
        });
    </script>
</body>
</html>
