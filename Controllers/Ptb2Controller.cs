using System;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DemoMVC.Controllers
{
    public class Ptb2Controller : Controller
    {
         giaiphuongtrinh gpt= new giaiphuongtrinh();
        public IActionResult Index(){    
            return View();
        }
        [HttpPost]
        public IActionResult Index(string soA, string soB, string soC){
            // tisnh nghiem pt
            //1.Khai bao bien
           
            //2.gan gia tri gui tu view len
            double a= Convert.ToDouble(soA);
           double b= Convert.ToDouble(soB);
            double c= Convert.ToDouble(soC);
           string Thongbao = gpt.giaiphuongtrinhbachai(a,b,c);
    
                ViewBag.mess= Thongbao;
            return View();

        }
        [HttpPost]
          public IActionResult Create(DemoController std)
    {
    
        return View();
    }
    };
}

