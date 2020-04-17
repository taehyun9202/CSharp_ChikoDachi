using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Dojodachi.Models;


namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        public static Dojodachi Chikorita = new Dojodachi();
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(Chikorita);
        }
        [HttpGet("play")]
        public IActionResult Play()
        {
            Chikorita.Play();
            return View("Index",Chikorita);
        }
        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Chikorita.Feed();
            if(Chikorita.isWin() == true)
            {
                return View("Index",Chikorita);
            }
            else if(Chikorita.isLost() == true)
            {
                return View("Index",Chikorita);
            }
            return View("Index",Chikorita);
        }
        [HttpGet("work")]
        public IActionResult Work()
        {
            Chikorita.Work();
            if(Chikorita.isWin() == true)
            {
                return View("Index",Chikorita);
            }
            else if(Chikorita.isLost() == true)
            {
                return View("Index",Chikorita);
            }
            return View("Index",Chikorita);
        }
        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            Chikorita.Sleep();
            if(Chikorita.isWin() == true)
            {
                return View("Index",Chikorita);
            }
            else if(Chikorita.isLost() == true)
            {
                return View("Index",Chikorita);
            }
            return View("Index",Chikorita);
        }

        [HttpGet("restart")]
        public IActionResult Restart()
        {
            Chikorita.Reset();
            return View("Index",Chikorita);
        }
    }
}
