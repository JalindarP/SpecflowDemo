Feature: Being PO I want application to perform basic math operation

@Service
Scenario: Add two numbers
Given 200 is first number
And 300 is second number
When asked for addition
Then result should be 500