using wheelsUN_transaction_ms.Models;
using wheelsUN_transaction_ms.wheelsUN_transaction_db.DTO;

namespace wheelsUN_transaction_ms.Utils
{
    public class MapTransaction
    {
            private readonly TransactionDTO _transaction;
            public MapTransaction(TransactionDTO transaction)
            {
                _transaction = transaction;
            }
            public TransactionDTO MapTransactions(RequestPayment transaction, string state, string transactionIdPay, string orderId)
            {
                _transaction.referenceCode = transaction.transaction.order.referenceCode;
                _transaction.description = transaction.transaction.order.description;
                _transaction.value = transaction.transaction.order.additionalValues.TX_VALUE.value;
                _transaction.paymentMethod = transaction.transaction.paymentMethod;
                _transaction.state = state;
                _transaction.transactionIdPay = transactionIdPay;
                _transaction.orderId = orderId;
                _transaction.tripId = 1;
                _transaction.creditCardId = 2;
                return _transaction;


            }
        
    }
}
