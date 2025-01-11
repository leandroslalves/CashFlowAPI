﻿using CashFlow.Comunication.Enums;
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
           var validator = new RegisterExpenseValidator();
           var result = validator.Validate(request);

        }
    }
}
