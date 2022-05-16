# Calculator
A simple command line calculator, which implements manual syntax analysis (no parser generator).

It covers:
- integer numerals
- operators +, -, *, / (no remainder division)
- brackets

Grammar:<br />
E -> T {"+"|"-"T}<br />
T -> S {"*"|"/"S}<br />
S -> number | "("E")"
