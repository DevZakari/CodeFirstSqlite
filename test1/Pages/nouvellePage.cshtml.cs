using test1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLitePCL;
using System;
using System.Collections.Generic;
using test1.Model;
using System.Linq;

namespace test1.Pages
{

    public class nouvellePageModel : PageModel
    {
        public List<Etudiant> Etudiants { get; set; }

        private readonly DataContext _context;

        public nouvellePageModel(DataContext context)
        {
            _context = context; 
        }
        public void OnGet()
        {
            Etudiants = _context.Etudiant.ToList();
        }
    }
}
