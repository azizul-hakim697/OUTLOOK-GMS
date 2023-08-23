using BLL.DTOs;
using BLL.Services;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OUTLOOK_GMS.Controllers
{
    public class SalaryController : ApiController
    {
        [EnableCors("*")]
        [HttpPost]
        [Route("api/salary/create")]

        public HttpResponseMessage Create(SalaryDTO product) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = SalaryServices.Create(product);
                    if (data != null)
                    {
                        return Request.CreateResponse(HttpStatusCode.Created, "Product created successfully.");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpGet]
        [Route("api/salary/viewall")]
        public HttpResponseMessage Get() 
        {
            try
            {
                var data = SalaryServices.Get();
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("api/salary/view/{id}")]
        public HttpResponseMessage Get(int id) 
        {
            try
            {
                var data = SalaryServices.Get(id);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        [Route("api/salary/update")]
        public HttpResponseMessage Update(SalaryDTO salary) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isSuccess = SalaryServices.Update(salary);

                    if (isSuccess)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Salary information updated successfully.");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError);
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpDelete]
        [Route("api/salary/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var isSuccess = SalaryServices.Delete(id);



                if (isSuccess)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Salary deleted successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }

        }


    }
}
