﻿using Anpero.PaymentHelper.Control.QR;
using Anpero.PaymentHelper.Model;
using Anpero.PaymentHelper.Model.Alepay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Anpero.PaymentHelper
{
    public interface IAllPayment
    {

        ///<summary>
        /// ID/BNB ID
        /// </summary>
        /// <param name="bankAccountNumber">Merchant ID/ Consumer ID</param>
        /// <param name="bankId">ID/BNB ID </param>
        /// <param name="message"></param>
        /// <param name="amount">money</param>
        /// <returns></returns>
        CheckOutResultModel? GetQRCodeData(string bankAccountNumber, string bankId,string message,string amount, CurrencyCode currency);
        CheckOutResultModel? GetCheckoutUrl(OrderModel data);
        TransactionDetailModel ProcessCallBackData(string token);
    }
}
