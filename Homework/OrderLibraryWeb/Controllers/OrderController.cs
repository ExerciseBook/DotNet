using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using OrderLibrary_EF.Models;

namespace OrderLibraryWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private Database db = new Database();

        [HttpGet]
        public ActionResult<List<Order>> Get(int offset = 0, int limit = 10)
        {
            return db.Orders.Skip(offset).Take(limit).ToList();
        }

        [HttpDelete]
        public ActionResult<Order> Delete(int id)
        {
            var ret = db.Orders.Find(id);
            if (ret == null) return null;
            db.Orders.Remove(ret);
            return ret;
        }

        [HttpPost]
        public ActionResult<Order> Add(string itemName, string custom, decimal blance)
        {
            var ret = db.Add(new Order() { ItemName = itemName, Custom = custom, Balance = blance });
            db.SaveChanges();
            return ret.Entity;
        }
    }
}