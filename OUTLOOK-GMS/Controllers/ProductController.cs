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
    public class ProductController : ApiController
    {
        [EnableCors("*")]
        [HttpPost]
        [Route("api/product/create")]
        public HttpResponseMessage Create(ProductDTO product) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = ProductServices.Create(product);
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
        [Route("api/product/viewall")]
        public HttpResponseMessage Get()
        {
            {
                try
                {
                    var data = ProductServices.Get();
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
        }
        [HttpGet]
        [Route("api/product/view/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ProductServices.Get(id);
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
        [Route("api/product/update")]
        public HttpResponseMessage Update( ProductDTO product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var isSuccess = ProductServices.Update(product);

                    if (isSuccess)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Product information updated successfully.");
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
        [Route("api/product/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var isSuccess = ProductServices.Delete(id);



                if (isSuccess)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Product deleted successfully.");
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
