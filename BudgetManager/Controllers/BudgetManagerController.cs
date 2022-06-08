using BudgetManager.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BudgetManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BudgetManagerController : ControllerBase
    {
        private IUserData _userData;

        public BudgetManagerController(IUserData userData)
        {
            _userData = userData;
        }
    }
}
