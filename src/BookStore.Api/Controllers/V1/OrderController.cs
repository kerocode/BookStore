using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookStore.Common.Routing;
using BookStore.Models;


namespace BookStore.Api.Controllers.V1
{
    [ApiVersion1RoutePrefix("Order")]
    public class OrderController : ApiController
    {
        [Route("", Name = "AddOrderRoute")]
        [HttpPost]
        public Order AddTask(HttpRequestMessage requestMessage, Order newOrder)
        {
            return new Order
            {
                D = "In v1, newTask.Subject = " + newTask.Subject
            };
        }
    }
}
