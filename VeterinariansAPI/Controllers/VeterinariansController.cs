using _301290835_Maria_Josue_3013473439_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VeterinariansAPI.Services;

namespace VeterinariansAPI.Controllers
{
    [Route("api/[controller]")]
    public class VeterinariansController : Controller
    {

        private IVeterinariansRepository _veterinariansRepository;

        public VeterinariansController(IVeterinariansRepository veterinariansRepository)
        {
            _veterinariansRepository = veterinariansRepository;
        }


        // GET: Veterinarians
        [HttpGet]
        [Route("/api/AllVeterinarians")]
        public async Task<ActionResult<Veterinarian>> GetAllVeterinarians()
        {
            var veterinarians = await _veterinariansRepository.GetAllVeterinarians();
            return Ok(veterinarians);
        }

        //// GET: VeterinariansController/Details/5
        //[HttpGet]
        //[Route("/api/Veterinarians/:id")]
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: VeterinariansController/Create
        //[HttpGet]
        //[Route("/api/AllVeterinarians")]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: VeterinariansController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: VeterinariansController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: VeterinariansController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: VeterinariansController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: VeterinariansController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
