# Qif
This is merely a clone of a random Qif api from CodePlex Archive. I'm not the original author. Just need it to parse my personal banking transactions.

### Usage
```c#
using Qif;

QifDom qifDom = new QifDom();
qifDom.Import(someFilePath);

// It should parse the file on load and following fields will be available
// qifDom.BankTransactions
// qifDom.CashTransactions
// etc...
```
Please refer to the docs in code

### Limitation
The date format of the imported .qif file is currently hard-coded to dd/MM/yyyy. Will fix if needed. Please submit an issue or PR 