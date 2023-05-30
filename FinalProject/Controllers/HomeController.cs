//using FinalProject.Models;
using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Numerics;
namespace FinalProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
		{
			List<Profession> professions = await _context.Professions.ToListAsync();

			HomeVM homeVM = new HomeVM()
			{
				Professions = professions
			};

			return View(homeVM);
		}
	}



	}


