using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebApi
{
    [ApiController]
    [Route("[Controller]")]
    public class ItemsController:ControllerBase
    {
        private static List<string> mItemsData = new List<string>();

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetItems() 
        {
            return mItemsData;
        
        }

        [HttpPost]
        public ActionResult AddItem([FromBody] string item)
        {
            mItemsData.Add(item);
            return Ok();
        }
    }
}
