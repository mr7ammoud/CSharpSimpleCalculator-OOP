# CSharpSimpleCalculator-OOP
Overview
This project demonstrates object‑oriented programming in C# through a Calculator class that maintains internal state and provides safe arithmetic operations.
The Program class showcases usage by performing a sequence of operations and printing the results.

📸 Console Output Example
Below is an example of what the program prints during execution:
Result after Adding 10 is: 10
Result after Adding 100 is: 110
Result after Subtracting 20 is: 90
Result after Dividing 0 is: 90
Result after Dividing 2 is: 45
Result after Multiplying 3 is: 135
Result after Clear 0 is: 0



🚀 Features
- Add numbers
- Subtract numbers
- Multiply numbers
- Divide numbers with zero‑division handling
- Track the last operation performed
- Print results after each operation
- Reset calculator state using Clear()

🧩 Code Architecture
🔹 Calculator.cs
Contains the core logic:
- Private fields: _Result, _LastNumber, _FinalOperation
- Methods: Add, Subtract, Multiply, Divide, Clear, PrintResult, GetFinalResult
🔹 Program.cs
Runs a sequence of operations to demonstrate the calculator’s behavior.


This project demonstrates object‑oriented programming in C# through a Calculator class that maintains internal state and provides safe arithmetic operations. The Program class showcases usage by performing a sequence of operations and printing the results.
