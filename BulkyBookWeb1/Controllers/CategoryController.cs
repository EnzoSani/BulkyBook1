﻿using BulkyBookWeb1.Data;
using BulkyBookWeb1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb1.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;    
        }
        public IActionResult Index()
        {
           IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }
        //Get
        public IActionResult Create()
        {
            
            return View();
        }
        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
