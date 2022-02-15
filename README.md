# CodingExercise for DirectID

Task Description

Coding Exercise

Overview
It’s expected the solution would be a working production ready solution. In case any external libraries or resources are used please do reference them. Also please make a note of any assumptions that were made while developing the solution. 
Please use GitHub or Gitlab to share the solution with us. The backend should be in .Net Core. You’re free to choose the frontend stack if you wish to create one, however React is desired.
What we are looking for here are the design decisions made while coming up with a solution and what best practices that you might follow while writing code.

Description
A JSON containing account data is the input. You may treat it as a Mock API
There is a request date in the input and transactions and their dates.
The goal is to calculate end of day balances for each day you have in the transactions. This will be done by using the current balance that is in input and transaction details. e.g.
If the data was requested today, then yesterday’s end of day balance would be calculated by adding/subtracting (based on whether they are credit or debit) all transactions from today to the current balance.
In addition to that the output also contains Total Amount of credits and debits. 
This should be displayed on the page along with Account details. No specific branding is required, and you can use any off the shelf library, but the page should be responsive and be useable on a mobile device.
