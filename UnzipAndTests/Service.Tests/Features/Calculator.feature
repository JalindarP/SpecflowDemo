 Feature: Being PO I want application to perform basic math operation

@Service
Scenario Outline: Add two numbers
Given <firstNumber> is first number
And <secondNumber> is second number
When asked for addition
Then result should be <result>
Examples: 
| firstNumber | secondNumber | result |
| 100         | 200          | 300    |
| -100        | 200          | 100    |
| 100         | 0            | 100    |