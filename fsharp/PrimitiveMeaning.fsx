type Money = Money of decimal

type IncomeSource =
    | Salary
    | Royalty

type ExpenseCategory =
    | Food
    | Entertainment

type Income = {
    Aount: Money
    Category: ExpenseCategory
}

type Expense = {
    Aount: Money
    Category: ExpenseCategory
}

type Transaction =
    | Credit of Income
    | Debit of Expense
