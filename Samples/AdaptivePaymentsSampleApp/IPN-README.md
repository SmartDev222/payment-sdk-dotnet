IPN Overview:
------------
* PayPal Instant Payment Notification is a call back system that is initiated when a transaction is completed 
  (Example: On successful payment transaction)
* The transaction related IPN variables will be received on the call back URL specified in the request
* The IPN variables have to be sent back to the PayPal system for validation, 
  upon validation PayPal will send a response string "VERIFIED" or "INVALID"
* PayPal would continuously resend IPN if a wrong IPN is sent


IPN Configuration:
-----------------
* IPN endpoint URL is specified in 'Web.config' as 'IPNEndpoint'. This will be used for the IPN post back
* A utility class 'IPNMessage.cs' is provided in sdk-core-dotnet for IPN message validation


IPN How to run?
--------------
* IPN Listener sample provided under the adaptivepayments-sdk-dotnet/Samples/AdaptivePaymentsSampleApp/IPNListener.aspx
* Deploy IPN Listener sample in IIS and expose your server port using any third party 
  LocalTunneling software, so that the PayPal IPN call back can be received
* Make a PayPal API call (Example: Pay request), setting the IPNNotificationUrl field of the API request class
  to the URL of deployed IPNListener sample (Example: http://DNS-Name/IPNListener.aspx)
* The IPN call back from PayPal would be logged in the log file of the IPN sample


IPN variables:
--------------

[Transaction]
-------------
* transaction_type
* action_type
* transaction[n].amount
* transaction[n].id
* transaction[n].id_for_sender
* transaction[n].invoiceId
* transaction[n].is_primary_receiver
* transaction[n].receiver
* transaction[n].refund_account_charged
* transaction[n].refund_amount
* transaction[n].refund_id
* transaction[n].status
* transaction[n].status_for _sender_txn,
* transaction[n].id_for_sender_txn 
* transaction[n].pending_reason 
* IPN_notification_URL
* verify_sign
* notify_version          
* test_IPN                
* reverse_all_parallel_payments_on_error 
* log_default_shipping_address_in_transaction

[BuyerInfo]
-----------
* sender_email
* fees_payer
* pin_type

[DisputeResolution]
-------------------
* reason_code

[RecurringPayment]
------------------
* current_number_of_payments
* current_period_attempts
* current_total_amount_of_all_payments
* date_of_month
* day_of_week
* ending_date
* max_amount_per_payment
* max_number_of_payments
* max_total_amount_of_all_payments
* payment_period
* starting_date
* payment_period

[Paymentinfo]
-------------
* pay_key
* payment_request_date
* preapproval_key
* memo
* payment_request_date    
* preapproval_key
* currencyCode
* status
* return_URL              
* cancel_URL
* approved
* charset
* trackingId


* For a full list of IPN variables you need to check the log file that the IPN Listener logs.    

IPN Reference :
--------------
* You can refer IPN getting started guide at [https://www.x.com/developers/paypal/documentation-tools/IPN/gs_IPN]