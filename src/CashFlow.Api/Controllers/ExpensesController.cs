using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Comunication.Requests;
using CashFlow.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterExepensesJson request)
        {
            try
            {
                var useCase = new RegisterExpenseUseCase();

                var response = useCase.Execute(request);

                return Created(string.Empty, request);

            }
            catch (ArgumentException ex)
            {
                var errorMessage = new ResponseErrorJson(ex.Message);

                return BadRequest(errorMessage);
            }
            catch
            {
                var errorMessage = new ResponseErrorJson("Unknown Error");

                return StatusCode(StatusCodes.Status500InternalServerError, errorMessage);
            }
        }
    }
}
