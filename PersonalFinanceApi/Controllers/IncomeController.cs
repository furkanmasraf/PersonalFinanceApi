using Microsoft.AspNetCore.Mvc;
using PersonalFinanceApi.Models;
using PersonalFinanceApi.DTOs;

namespace PersonalFinanceApi.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase

    {
        private static List<Income> Incomes = new List<Income>();
    }
}
