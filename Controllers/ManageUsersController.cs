﻿using AspNetCoreTodo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTodo.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ManageUsersController : Controller
    {
            private readonly UserManager<ApplicationUser> _userManager;

            public ManageUsersController(UserManager<ApplicationUser> userManager)
            {
                _userManager = userManager;
            }

            public async Task<IActionResult> Index()
            {
                var admins = await _userManager
                    .GetUsersInRoleAsync("Administrator");

                var everyone = await _userManager.Users
                    .ToArrayAsync();

                var model = new ManageUsersViewModel
                {
                    Administrators = admins,
                    Everyone = everyone
                };

                return View(model);

            }

        }
    }
