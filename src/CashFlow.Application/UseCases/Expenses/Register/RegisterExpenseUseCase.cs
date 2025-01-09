using CashFlow.Comunication.Enums;
using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase
    {
        public ResponseRegisteredExpenseJson Execute(RequestRegisterExepensesJson request)
        {
            Validate(request);

            return new ResponseRegisteredExpenseJson();
        }


        private void Validate(RequestRegisterExepensesJson request)
        {
            var titleIsEmpty = string.IsNullOrWhiteSpace(request.Title);
            if (titleIsEmpty)
            {
                throw new ArgumentException("Title is required");
            }

            if (request.Amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than zero");
            }

            var result = DateTime.Compare(request.Date, DateTime.Now);
            if (result > 0)
            {
                throw new ArgumentException("Date must be less than or equal to today");
            }

            var paymentTypeIsValid = Enum.IsDefined(typeof(PaymentType), request.PaymentType);
            if (!paymentTypeIsValid)
            {
                throw new ArgumentException("Payment type is invalid");
            }

        }
    }
}
