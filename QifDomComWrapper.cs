using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using Qif.Transactions;

namespace Qif
{
    /// <summary>
    /// The QIF DOM COM interface.
    /// </summary>
    public interface IQifDomComWrapper
    {
        /// <summary>
        /// Gets or sets the QIF DOM.
        /// </summary>
        /// <value>The QIF DOM.</value>
        QifDom QifDom
        {
            get;
            set;
        }
        /// <summary>
        /// Imports the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void Import(string fileName);
        /// <summary>
        /// Exports the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void Export(string fileName);
        /// <summary>
        /// Gets the bank transactions.
        /// </summary>
        /// <value>The bank transactions.</value>
        ArrayList BankTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the cash transactions.
        /// </summary>
        /// <value>The cash transactions.</value>
        ArrayList CashTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the credit card transactions.
        /// </summary>
        /// <value>The credit card transactions.</value>
        ArrayList CreditCardTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the investment transactions.
        /// </summary>
        /// <value>The investment transactions.</value>
        ArrayList InvestmentTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the asset transactions.
        /// </summary>
        /// <value>The asset transactions.</value>
        ArrayList AssetTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the liability transactions.
        /// </summary>
        /// <value>The liability transactions.</value>
        ArrayList LiabilityTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the account list transactions.
        /// </summary>
        /// <value>The account list transactions.</value>
        ArrayList AccountListTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the category list transactions.
        /// </summary>
        /// <value>The category list transactions.</value>
        ArrayList CategoryListTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the class list transactions.
        /// </summary>
        /// <value>The class list transactions.</value>
        ArrayList ClassListTransactions
        {
            get;
        }
        /// <summary>
        /// Gets the memorized transaction list transactions.
        /// </summary>
        /// <value>The memorized transaction list transactions.</value>
        ArrayList MemorizedTransactionListTransactions
        {
            get;
        }
    }
}
