﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Diagnostics;
using BikeWatcher.Models;

namespace BikeWatcher.Controllers
{
    public class APIController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IActionResult> Index()
        {
            var stations = await ProcessRepositories();
            stations = stations.OrderBy(s => s.name).ToList();
            return View(stations);
        }

        private static async Task<List<BikeStation>> ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var streamTask = client.GetStreamAsync("https://download.data.grandlyon.com/ws/rdata/jcd_jcdecaux.jcdvelov/all.json");
            var repositories = await JsonSerializer.DeserializeAsync<RootObject>(await streamTask);
            return repositories.values;
        }
    }
}