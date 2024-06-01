using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Entity.Contexts;
using API_Entity.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace API_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public AccountsController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("{accountId:int}")]
        public async Task<ActionResult<Account>> GetAccount(int accountId)
        {
            var account = await _context.Accounts
                .Include(a => a.Cart)
                .FirstOrDefaultAsync(a => a.AccountId == accountId);

            if (account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }
    }

}