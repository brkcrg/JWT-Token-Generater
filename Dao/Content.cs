using InsaatBackendAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsaatBackendAPI.Dao
{
    public class Content
    {
        InsaatContext context = new InsaatContext();//sqldeki berileri okuyabilmemiz için insaatContext dosyamıxdan bir nesne türeterek attrubütelerine ulaşıyoruz.

        public string GetCityList()//Servisimizi yazdığımız Fonksiyon.
        {
            var cities = context.Cities.ToList();//Basit bir Linq sorgusu (sql de Select * from sorugusu)
            var resultJson = JsonConvert.SerializeObject(new[] {  // Okuyacağımız datayı Ön yüzde yazmış olduğumuz JSO formatına dönüştürüyoruz.
                new{
                result= "Success.",
                    CityTable= cities,
            }
            });
            
            return resultJson;
        }
        public string GetGenderList()
        {
            var genders = context.Genders.ToList();
            var resultJson = JsonConvert.SerializeObject(new
            {
                result = "Success.",
                GenderTable = genders,
            });
            return resultJson;
        }
    }
}
