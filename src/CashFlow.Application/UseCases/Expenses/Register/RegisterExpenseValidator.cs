using CashFlow.Comunication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExepensesJson>
    {
        public RegisterExpenseValidator()
        {
            RuleFor(expense => expense.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("Amount must be greater than zero");
            RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("Date must be less than or equal to today");
            RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("Payment type is invalid");
        }
    }
}
