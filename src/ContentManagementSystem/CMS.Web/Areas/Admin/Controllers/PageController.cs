using CMS.Data.Repositories.Interface.IEntityTypeRepositories;
using CMS.Entity.Entities.Concrete;
using CMS.Entity.Enums;
using CMS.Web.Areas.Admin.Models.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CMS.Web.Areas.Admin.Controllers
{
    [Area("Admin")]

    
    public class PageController : Controller
    {
        private readonly IPageRepository _pageRepository;

        public PageController(IPageRepository pageRepository) => _pageRepository = pageRepository;

        public IActionResult Create() => View();


        [HttpPost]
        public async Task<IActionResult> Create(CreatePageDTO model) 
        {
            if (ModelState.IsValid)
            {
                var slug = await _pageRepository.GetByDefault(x => x.Slug == model.Slug);

                if (slug != null)
                {
                    ModelState.AddModelError("", "The page is already exsits!");
                    TempData["Warning"] = "The page is already exsits!";
                    return View(model);
                }
                else
                {
                    Page page = new Page();
                    page.Title = model.Title;
                    page.Content = model.Content;
                    page.Slug = model.Slug;
                    page.Sorting = model.Sorting;

                    await _pageRepository.Add(page);
                    TempData["Success"] = "The page has been added.";
                    return RedirectToAction("List");
                }
            }
            else
            {
                TempData["Error"] = "The page hasn't been added !!";
                return View(model);
            }
        }

        public async Task<IActionResult> List() => View(await _pageRepository.GetAll());

        public async Task<IActionResult> Edit(int id)
        {
            Page page = await _pageRepository.GetById(id);
            UpdatePageDTO model = new UpdatePageDTO();
            model.Id = page.PageId;
            model.Title = page.Title;
            model.Content = page.Content;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdatePageDTO model) 
        {
            if (ModelState.IsValid)
            {
                var slug = await _pageRepository.GetByDefault(x => x.Slug == model.Slug);

                if (slug != null)
                {
                    ModelState.AddModelError("", "The page is already exsist!");
                    TempData["Warning"] = "The page is already exsist!";
                    return View(model);
                }
                else
                {
                    Page page = await _pageRepository.GetById(model.Id);

                    page.Title = model.Title;
                    page.Content = model.Content;
                    page.Slug = model.Slug;
                    page.UpdateDate = DateTime.Now;
                    page.Status = Status.Modified;

                    await _pageRepository.Update(page);
                    TempData["Success"] = "The page has been updated. :)";
                    return RedirectToAction("List");
                }
            }
            else
            {
                TempData["Error"] = "The page hasn't been updated!";
                return View(model);
            }
            
        }

        public async Task<IActionResult> Remove(int id) 
        {
            Page page = await _pageRepository.GetById(id);

            if (page != null)
            {
                await _pageRepository.Delete(page);
                TempData["Success"] = "The page has been removed.";
                return RedirectToAction("List");
            }
            else
            {
                TempData["Error"] = "The page hasn't been removed!";
                return RedirectToAction("List");
            }
        }
    }
}

