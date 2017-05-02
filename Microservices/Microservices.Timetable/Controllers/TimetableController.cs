using System;
using System.Net;
using System.Web.Http;
using System.Web.Script.Serialization;
using Microservices.Timetable.Services;

namespace Microservices.Timetable.Controllers
{
    public class TimetableController : ApiController
    {
        private readonly TimetableService _timetableService;

        public TimetableController()
        {
            _timetableService = new TimetableService();
        }

        [Route("api/v1/timetables")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            try
            {
                var timetables = _timetableService.GetTimeTables();
                var result = new JavaScriptSerializer().Serialize(timetables);
                return this.JsonString(result);
            }
            catch (Exception)
            {
                var message = "";
                return this.JsonString(message, HttpStatusCode.BadRequest);
            }
        }

        [Route("api/v1/timetable/{id}")]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            try
            {
                var timetable = _timetableService.GetById(id);
                var result = new JavaScriptSerializer().Serialize(timetable);
                return this.JsonString(result);
            }
            catch (Exception)
            {
                var message = "";
                return this.JsonString(message, HttpStatusCode.BadRequest);
            }
        }
    }
}