<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PreapprovalPayment.aspx.cs" Inherits="AdaptivePaymentsSampleApp.UseCaseSamples.PreapprovalPayment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
	<img src="https://devtools-paypal.com/image/bdg_payments_by_pp_2line.png" alt="PAYMENTS BY PayPal" />
    <div id="wrapper">
        <div id="header">
            <h3>Preapproval</h3>
			<div id="apidetails">Preapproval API operation is used to set
				up an agreement between yourself and a sender for making payments on
				the sender's behalf. You set up a preapprovals for a specific
				maximum amount over a specific period of time and, optionally, by
				any of the following constraints: the number of payments, a maximum
				per-payment amount, a specific day of the week or the month, and
				whether or not a PIN is required for each payment request.
			</div>
        </div>
        <br />
        <form id="form1" runat="server" method="post">
            <div>
                <div id="request_form">
				<div class="params">
					<div class="param_name">Currency Code*</div>
					<div class="param_value">
						<input type="text" name="currencyCode" value="USD" />
					</div>
					<table>
						<tr>
							<th class="param_name">Starting Date*</th>
							<th class="param_name">Ending Date</th>
						</tr>
						<tr>
							<td class="param_value"><input type="text" name="startingDate" id="startingDate" runat="server" /></td>
							<td class="param_value"><input type="text" name="endingDate" id="endingDate" runat="server" /></td>
						</tr>
					</table>
					<div class="input_header">URLs</div>
					<table>
						<tr>
							<th class="param_name">Cancel URL*</th>
							<th class="param_name">Return URL*</th>
							<th class="param_name">IPN Notification URL (For receiving IPN call back from PayPal)</th>
						</tr>
						<tr>
							<td class="param_value"><input type="text" name="cancelURL" id="cancelURL" runat="server" /></td>
							<td class="param_value"><input type="text" name="returnURL" id="returnURL" runat="server" /></td>
							<td class="param_value"><input type="text" name="ipnNotificationURL" /></td>
						</tr>
					</table>
					<div class="param_name">Sender Email</div>
					<div class="param_value">
						<input type="text" name="senderEmail" value="" />
					</div>
					
					<table>
						<tr>
							<th class="param_name">Date Of Month</th>
							<th class="param_name">Day Of Week</th>
						</tr>
						<tr>
							<td class="param_value"><input type="text"
								name="dateOfMonth" value="1" /></td>
							<td class="param_value"><select name="dayOfWeek">
									<option value="">--Select a value--</option>
									<option value="NO_DAY_SPECIFIED">No Day Specified</option>
									<option value="SUNDAY">Sunday</option>
									<option value="MONDAY">Monday</option>
									<option value="TUESDAY">Tuesday</option>
									<option value="WEDNESDAY">Wednesday</option>
									<option value="THURSDAY">Thursday</option>
									<option value="FRIDAY">Friday</option>
									<option value="SATURDAY">Saturday</option>
							</select></td>
						</tr>
					</table>
					
					<div class="input_header">Payment Details</div>
					<table>
						<tr>
							<th class="param_name">Maximum Amount Per Payment</th>
							<th class="param_name">Maximum Number Of Payments</th>
							<th class="param_name">Maximum Number Of Payments Per Period</th>
							<th class="param_name">Total Amount Of All Payments</th>
							<th class="param_name">Payment Period</th>
							<th class="param_name">Display Maximum Total Amount</th>
						</tr>
						<tr>
							<td class="param_value"><input type="text"
								name="maxAmountPerPayment" value="1.00" /></td>
							<td class="param_value"><input type="text"
								name="maxNumberOfPayments" value="2" /></td>
							<td class="param_value"><input type="text"
								name="maxNumberOfPaymentsPerPeriod" value="2" /></td>
							<td class="param_value"><input type="text"
								name="totalAmountOfAllPayments" value="10.00" /></td>
							<td class="param_value">
								<select name="paymentPeriod">
									<option value="">--Select a value--</option>
									<option value="NO_PERIOD_SPECIFIED">NO_PERIOD_SPECIFIED</option>
									<option value="DAILY">DAILY</option>
									<option value="WEEKLY">WEEKLY</option>
									<option value="BIWEEKLY">BIWEEKLY</option>
									<option value="SEMIMONTHLY">SEMIMONTHLY</option>
									<option value="MONTHLY">MONTHLY</option>
									<option value="ANNUALLY">ANNUALLY</option>
								</select>
								</td>
							<td class="param_value"><select name="displayMaxTotalAmount">
									<option value="">--Select a value--</option>
									<option value="true">True</option>
									<option value="false">False</option>
							</select></td>
						</tr>
					</table>
				</div>
                    <div class="submit">
                        <asp:Button ID="AdaptivePaymentsBtn" Text="PreapprovalPay" runat="server" PostBackUrl="~/AdaptivePaymentsHandler.ashx" />
                    </div>
                    <br />
                    <a href="../Default.aspx">Home</a>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
