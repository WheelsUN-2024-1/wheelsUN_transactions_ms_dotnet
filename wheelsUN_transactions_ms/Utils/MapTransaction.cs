using System.Transactions;
using wheelsUN_transaction_db.DTOs;
using wheelsUN_transactions_ms.Models;

namespace wheelsUN_transactions_ms.Utils
{
    public class MapTransaction
    {
        private readonly TransactionDTO _transaction;
        public MapTransaction(TransactionDTO transaction)
        {
            _transaction = transaction;
        }
        public TransactionDTO MapTransactions(RequestPayment transaction,string state,string transactionIdPay,string orderId) {
            _transaction.referenceCode = transaction.transaction.order.referenceCode;
            _transaction.description = transaction.transaction.order.description;
            _transaction.value = transaction.transaction.order.additionalValues.TX_VALUE.value;
            _transaction.paymentMethod = transaction.transaction.paymentMethod;
            _transaction.state = state;
            _transaction.transactionIdPay = transactionIdPay;
            _transaction.orderId = int.Parse(orderId);
            _transaction.tripId = 0;
            _transaction.creditCardId = 0;
            return _transaction;


        }
    }
}
