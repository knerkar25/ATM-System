# ATM-System
This code implements a simple ATM system in C#. It allows users to perform basic banking operations such as depositing funds, withdrawing funds, and checking their balance. The system authenticates users based on their card number and PIN. It uses a list of pre-defined cardholders with their corresponding information to validate user input.

This code implements a simple ATM system in C#. It allows users to perform basic banking operations such as depositing funds, withdrawing funds, and checking their balance. The system authenticates users based on their card number and PIN. It uses a list of pre-defined cardholders with their corresponding information to validate user input.

Project Description:
The Simple ATM System is a command-line application written in C#. It provides users with a menu of options to interact with their bank account. The available operations include depositing funds, withdrawing funds, and checking the account balance.

The system starts by displaying a welcome message and prompting the user to insert their card number. It then validates the input against a list of pre-defined cardholders. If the card number is recognized, the user is prompted to enter their PIN for authentication.

Upon successful authentication, the system displays a welcome message and presents the user with a menu of options. The user can choose an option by entering the corresponding number. The system validates the input and performs the selected operation accordingly.

The "Deposit" option allows the user to enter an amount to deposit into their account. The system updates the user's balance accordingly and displays the new balance.

The "Withdraw" option allows the user to enter an amount to withdraw from their account. The system checks if the user has sufficient balance and processes the withdrawal if possible. Otherwise, it displays an insufficient balance message.

The "Check Balance" option displays the user's current account balance.

The "Exit" option terminates the program.

The system uses a list of Cardholder objects to store the pre-defined cardholder information. Each Cardholder object contains properties such as card number, PIN, first name, last name, and balance. The user's input is validated against these cardholders during authentication.

Overall, this Simple ATM System provides basic banking functionality through a command-line interface, allowing users to manage their account easily.
