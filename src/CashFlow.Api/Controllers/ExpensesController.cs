using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Comunication.Requests;
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
                return BadRequest(ex.Message);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Unknow Error");
            }
        }
    }
}
