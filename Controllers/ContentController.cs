using InsaatBackendAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;
using InsaatBackendAPI.Dao;

namespace InsaatBackendAPI.Controllers
{
    [Route("/")]
    public class ContentController : ControllerBase
    {
        Content content = new Content();//Content sınıfımızdan yeni bir nesne türetiyoruz

        [HttpGet]//prosedürün servis türünü belirtiyoruz
        [Route("getcitylist")]//servisi çağıracağımız adresi tanımlıyoruz
        public string GetCityList()//
        {
            return content.GetCityList();
        }
        [HttpGet]
        [Route("getgenderlist")]

        public string GetGenderList()
        {
            return content.GetGenderList();
        }
    }
}
