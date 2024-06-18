# Payment Request Test Plan

tags: PaymentRequest

## Find all payment requests
* Get all payment requests
* Payment request(s) should match this data:
    |id  |expenseId|fromPersonId|toPersonId|date      |amount|isPaid|
    |----|---------|------------|----------|----------|------|------|
    |1   |1        |1           |2         |30/11/2023|100   |true  |
    |2   |1        |1           |3         |02/12/2023|100   |false |
