using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WordApi.Data;
using WordApi.Models;

namespace WordApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordController : ControllerBase
    {
        WordContext db;
        public WordController(WordContext context)
        {
            this.db = context;
        }

        // GET api/word
        [HttpGet]
        public ActionResult<IEnumerable<Word>> Get()
        {
            return db.Words;
        }

        // GET api/word/5
        [HttpGet("{id}")]
        public ActionResult<Word> Get(int id)
        {
            return db.Words.FirstOrDefault(t => t.Id == id);
        }

        // POST api/word
        [HttpPost]
        public void Post(Word value)
        {
            db.Words.Add(value);
            db.SaveChanges();
        }



        // DELETE api/word/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Words.Remove(db.Words.FirstOrDefault(t => t.Id == id));
        }
    }
}
