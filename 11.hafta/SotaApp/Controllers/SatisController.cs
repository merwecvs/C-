using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SotaApp.Data;
namespace SotaApp.Controllers{
    public class SatisController:Controller{
        private readonly DataContext _context;
        public SatisController(DataContext context){
            _context = context;
        }

        public async Task<IActionResult> Index(){
            var Satis = await _context.Satislar.Include(x=>x.Musteri).Include(x=>x.Urun).ToListAsync();
            return View(Satis);
        } 
        
        [HttpGet]
        public async Task<IActionResult> Create(){
            ViewBag.Urunler = new SelectList(await _context.Urunler.ToListAsync(),"UrunId", "UrunAdi");
            ViewBag.Musteriler = new SelectList(await _context.Musteriler.ToListAsync(),"MusteriId", "AdSoyad");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Satis model){
            _context.Satislar.Add(model);
            await _context.SaveChangesAsync(); 
            model.SatisTarihi = DateTime.Now;
            ViewBag.Urunler = new SelectList(await _context.Urunler.ToListAsync(),"UrunId", "UrunAdi");
            ViewBag.Musteriler = new SelectList(await _context.Musteriler.ToListAsync(),"MusteriId", "AdSoyad");
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id){
            if(id==null){
                return NotFound();
            }
            var urn = await _context.Satislar.Include(x=>x.Musteri ).Include(x=>x.Urun ).FirstOrDefaultAsync(Satis=> Satis.SatisId == id);
            if(urn==null){
                return NotFound();
            }
            return View(urn);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int id, Satis model){
            if(id !=model.SatisId){
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
                    if(! _context.Satislar.Any(u=>u.SatisId ==model.SatisId)){
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
            var Satis = await _context.Satislar.FindAsync(id);
            if(Satis==null){
                return NotFound();
            }
            return View(Satis);
        }
        [HttpPost]
        public async Task<IActionResult>Delete(int id){
            var Satis = await _context.Satislar.FindAsync(id);
            if(Satis==null){
                return NotFound();
            }
            _context.Satislar.Remove(Satis);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }

}