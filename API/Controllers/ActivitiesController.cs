using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Persistence;
using Microsoft.AspNetCore.Mvc;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;
        public ActivitiesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetAcivities() {
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //activities/id
         public async Task<ActionResult<Activity>> GetAcivitiy(Guid id) {
            return await _context.Activities.FindAsync(id);
        }
    }
}