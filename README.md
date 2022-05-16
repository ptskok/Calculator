# Calculator
A simple command line calculator, which implements manual syntax analysis (no parser generator).

It covers:
- integer numerals
- operators +, -, *, / (no remainder division)
- brackets

Grammar:<br />
Expr -> Mul {"+"|"-"Mul}<br />
Mul -> Term {"*"|"/"Term}<br />
Term -> number | "("Expr")"
