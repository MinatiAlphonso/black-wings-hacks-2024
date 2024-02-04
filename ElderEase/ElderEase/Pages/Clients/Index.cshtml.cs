﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ElderEase.Data;
using ElderEase.Models;

namespace ElderEase.Pages.Clients
{
    public class IndexModel : PageModel
    {
        private readonly ElderEase.Data.ElderEaseContext _context;

        public IndexModel(ElderEase.Data.ElderEaseContext context)
        {
            _context = context;
        }

        public IList<Client> Client { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Client = await _context.Client.ToListAsync();
        }
    }
}
