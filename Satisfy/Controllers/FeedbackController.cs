using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Satisfy.Models;

[ApiController]
[Route("api/[controller]")]
public class FeedbackController : ControllerBase
{
    // Lista temporária antes de EntityFramework
    private static List<Feedback> Feedbacks = new List<Feedback>();
    private static int nextId = 1;


    // GET: api/feedback
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Feedbacks);
    }


    // GET: api/feedback/5
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var feedback = Feedbacks.FirstOrDefault(f => f.Id == id);
        if (feedback == null) return NotFound();
        return Ok(feedback);
    }


    // POST: api/feedback
    [HttpPost]
    public IActionResult Create([FromBody] Feedback feedback)
    {
        feedback.Id = nextId++;
        feedback.DataEnvio = System.DateTime.UtcNow;
        Feedbacks.Add(feedback);
        return CreatedAtAction(nameof(GetById), new { id = feedback.Id }, feedback);
    }


    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Feedback feedback)
    {
        var existing = Feedbacks.FirstOrDefault(f => f.Id == id);
        if (existing == null) return NotFound();

        existing.Nome = feedback.Nome;
        existing.Email = feedback.Email;
        existing.Nota = feedback.Nota;
        existing.Comentario = feedback.Comentario;

        return NoContent();
    }


    // DELETE: api/feedback/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var feedback = Feedbacks.FirstOrDefault(f => f.Id == id);
        if (feedback == null) return NotFound();

        Feedbacks.Remove(feedback);
        return NoContent();
    }

}