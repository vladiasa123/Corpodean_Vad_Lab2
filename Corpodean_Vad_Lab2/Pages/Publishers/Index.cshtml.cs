﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Corpodean_Vad_Lab2.Data;
using Corpodean_Vad_Lab2.Models;

namespace Corpodean_Vad_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Corpodean_Vad_Lab2.Data.Corpodean_Vad_Lab2Context _context;

        public IndexModel(Corpodean_Vad_Lab2.Data.Corpodean_Vad_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
