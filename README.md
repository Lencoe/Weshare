## Project Overview

WeShare is a web application designed to track expenses that are shared amongst friends based on social trust. The project focuses on core web development concepts and aims to provide a manageable scope to ensure successful completion.

## User Requirements

### Users
- Each user logs in with a valid email address.
- No password or token-based authentication; only an email address is needed for login.

### Expenses
- An expense is any item or service on which money was spent.
- The app records the item, the date of the expense, and the amount spent.

### Payment Requests
- Users can log expenses paid on behalf of others and create payment requests.
- A payment request specifies the amount owed by a friend.
- Example: If a user pays for a R300 lunch, they can request R80 from one friend and R120 from another.

### Payments
- A payment request is settled when the recipient pays the requester.
- The paid amount becomes an expense for the payer and reduces the expense for the requester.


## Usage

1. Open your browser and navigate to `http://localhost:3000`.
2. Log in using a valid email address.
3. Add and manage your expenses.
4. Create and track payment requests.
5. Settle payments and keep track of who owes you and whom you owe.
