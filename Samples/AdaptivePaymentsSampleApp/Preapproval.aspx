<%@ Page Language="C#" AutoEventWireup="true" Codebehind="Preapproval.aspx.cs" Inherits="AdaptivePaymentsSampleApp.Preapproval" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Untitled Page</title>
</head>
<body>
    <h2>
        Pay API</h2>
    <form id="form1" runat="server" action="AdaptivePaymentsHandler.ashx">
        <div>
            <div class="param_name">
                StartingDate</div>
            <div class="param_value">
                <input type="text" name="startDate" size="50" maxlength="260" id="startDate" value="2011-11-30" /><br />
            </div>
            <div class="param_name">
                CurrencyCode</div>
            <div class="param_value">
                <input type="text" name="currencyCode" size="50" maxlength="260" id="currencyCode"
                    value="USD" /><br />
            </div>
            <%string url = Request.Url.Scheme + "://" + Request.Url.Host + ":" + Request.Url.Port;
              string returnURL = url + "/Default.aspx"; %>
            <div class="param_name">
                CancelUrl</div>
            <div class="param_value">
                <input type="text" name="cancelUrl" size="50" maxlength="260" id="cancelUrl" value="<%=returnURL%>" /><br />
            </div>
            <div class="param_name">
                ReturnUrl</div>
            <div class="param_value">
                <input type="text" name="returnUrl" size="50" maxlength="260" id="returnUrl" value="<%=returnURL%>" /><br />
            </div>
            <input name="AdaptivePaymentsBtn" type="submit" value="Preapproval" /><br />
            &nbsp;
        </div>
    </form>
</body>
</html>
