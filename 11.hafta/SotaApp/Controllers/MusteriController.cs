using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SotaApp.Data;
namespace SotaApp.Controllers{
    public class MusteriController:Controller{
        private readonly DataContext _context;
        public MusteriController(DataContext context){
            _context = context;
        }
        [HttpGet]
        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create (Musteri model){
            _context.Musteriler.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction ("Index");
        }
        public async Task<IActionResult> Index(){
            var Musteriler = await _context.Musteriler.ToListAsync();
            return View(Musteriler);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id){
            if(id==null){
                return NotFound();
            }
            var urn = await _context.Musteriler.Include(x=>x.Satis ).ThenInclude(x=>x.Urun ).FirstOrDefaultAsync(Musteri=> Musteri.MusteriId == id);
            if(urn==null){
                return NotFound();
            }
            return View(urn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id, Musteri model){
            if(id !=model.MusteriId){
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
                    if(! _context.Musteriler.Any(u=>u.MusteriId ==model.MusteriId)){
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
            var Musteri = await _context.Musteriler.FindAsync(id);
            if(Musteri==null){
                return NotFound();
            }
            return View(Musteri);
        }
        [HttpPost]
        public async Task<IActionResult>Delete(int id){
            var Musteri = await _context.Musteriler.FindAsync(id);
            if(Musteri==null){
                return NotFound();
            }
            _context.Musteriler.Remove(Musteri);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}