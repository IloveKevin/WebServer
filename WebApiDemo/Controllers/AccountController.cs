using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		public readonly AccountContext _context;
		public AccountController(AccountContext context)
		{
			_context = context;
		}
		[HttpPost("Login")]
		public string Login(string accountName, string password)
		{
			if(_context.Accounts.Where(a => a.AccountName == accountName && a.PassWord == password).Count()>0)return "Login Success";
			else return "Login Failed";	
		}

		[HttpPost("Register")]
		public string Register(string accountName, string password)
		{
			if(_context.Accounts.Where(a => a.AccountName == accountName).Count()>0)return "Register Failed";
			else
			{
				_context.Accounts.Add(new Account { AccountName = accountName, PassWord = password});
				_context.SaveChanges();
				return "Register Success";
			}
		}
	}
}
