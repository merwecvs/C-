using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SotaApp.Data;
namespace SotaApp.Controllers{
    public class UrunController:Controller{
        private readonly DataContext _context;
        public UrunController(DataContext context){
            _context = context;
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create (Urun model){
            _context.Urunler.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction ("Index");
        }
        public async Task<IActionResult> Index(){
            var urunler = await _context.Urunler.ToListAsync();
            return View(urunler);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id){
            if(id==null){
                return NotFound();
            }
            var urn = await _context.Urunler.FindAsync(id);
            if(urn==null){
                return NotFound();
            }
            return View(urn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id, Urun model){
            if(id !=model.UrunId){
                return NotFound();
            }
            if(ModelState.IsValid){
                try
                {
                    _context.Update(model);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(! _context.Urunler.Any(u=>u.UrunId ==model.UrunId)){
                        return NotFound();
                    }
                    else{
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult>Delete(int? id){
            if(id==null){
                return NotFound();
            }
            var urun = await _context.Urunler.FindAsync(id);
            if(urun==null){
                return NotFound();
            }
            return View(urun);
        }
        [HttpPost]
        public async Task<IActionResult>Delete(int id){
            var urun = await _context.Urunler.FindAsync(id);
            if(urun==null){
                return NotFound();
            }
            _context.Urunler.Remove(urun);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}