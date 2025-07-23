using Microsoft.AspNetCore.Mvc;
using GorevTakip.WebAPI.Data;
using GorevTakip.WebAPI.Models;

namespace GorevTakip.WebAPI.Controllers
{
    [ApiController]
    [Route("api/gorev")]
    public class GorevApiController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GorevApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var gorevler = _context.Gorevler.ToList();
            return Ok(gorevler);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var gorev = _context.Gorevler.Find(id);
            if (gorev == null)
                return NotFound();

            return Ok(gorev);
        }

        [HttpPost]
        public IActionResult Create(Gorev yeniGorev)
        {
            _context.Gorevler.Add(yeniGorev);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = yeniGorev.Id }, yeniGorev);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Gorev guncelGorev)
        {
            var gorev = _context.Gorevler.Find(id);
            if (gorev == null)
                return NotFound();

            gorev.Baslik = guncelGorev.Baslik;
            gorev.Aciklama = guncelGorev.Aciklama;
            gorev.Tarih = guncelGorev.Tarih;
            gorev.TamamlandiMi = guncelGorev.TamamlandiMi;

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var gorev = _context.Gorevler.Find(id);
            if (gorev == null)
                return NotFound();

            _context.Gorevler.Remove(gorev);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
