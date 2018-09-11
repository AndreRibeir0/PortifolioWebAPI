using BLL.Impl;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("TODO")]
    public class TodoController : ApiController
    {
        [Route("GETALL")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            try
            {
                TodoBLL todosBLL = new TodoBLL();

                IEnumerable<Todo> todos = todosBLL.GetAll();

                return Content(System.Net.HttpStatusCode.OK, todos);
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("ADD")]
        [HttpPost]
        public IHttpActionResult Add([FromBody]Todo pTodo)
        {
            try
            {
                TodoBLL todosBLL = new TodoBLL();

                todosBLL.Add(pTodo);

                return Content(System.Net.HttpStatusCode.Created, "Todo created");
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("PUT")]
        [HttpPut]
        public IHttpActionResult Put([FromBody]Todo pTodo)
        {
            try
            {
                TodoBLL todosBLL = new TodoBLL();

                todosBLL.Edit(pTodo);

                return Content(System.Net.HttpStatusCode.OK, "Todo changed");
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("DELETE")]
        [HttpDelete]
        public IHttpActionResult Delete([FromBody]Todo pTodo)
        {
            try
            {
                TodoBLL todosBLL = new TodoBLL();

                todosBLL.Delete(pTodo);

                return Content(System.Net.HttpStatusCode.OK, "Todo deleted");
            }
            catch (Exception ex)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}