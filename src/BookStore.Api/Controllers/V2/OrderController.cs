using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookStore.Models;


namespace BookStore.Api.Controllers.V2
{
    [RoutePrefix("api/{apiVersion:apiVersionConstraint(v2)}/orders")]
    public class OrderController : ApiController
    {
        [Route("", Name = "AddOrderRouteV2")]
        [HttpPost]
        public Order AddOrder(HttpRequestMessage requestMessage, Models.Order newOrder)
        {
            return new Order
            {
            };
        }
    }
}
