using Microsoft.AspNetCore.Mvc;
using PersonalFinanceApi.Models;
using PersonalFinanceApi.DTOs;

namespace PersonalFinanceApi.Controllers

{
    [ApiController]
    [Route("api/[controller]")]
    public class IncomeController : ControllerBase
    {

        [HttpGet("{count:int}")]
        public List<UserDto> GetList(int count)
        {
            List<UserDto> incomeList = new List<UserDto>();
            //verileri aldık
            incomeList.Add(new UserDto { FullName = "Ahmet Yılmaz", Email = "" });
            //verileri işle


            return incomeList;
        }

    }
}
