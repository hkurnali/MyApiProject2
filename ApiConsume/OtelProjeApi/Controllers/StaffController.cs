﻿using HotelProject.EntityLayer.Concrate;
using HotelProjectBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OtelProjeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        { 
            _staffService = staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult StaffAdd(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult StaffDelete(int id)
        { var values=_staffService.TGetByID(id);
            _staffService.TDelete(values);
           return Ok();
        }

        [HttpPut]
        public IActionResult UpdateStaff(Staff staff)
        { _staffService.TUpdate(staff);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var values = _staffService.TGetByID(id);

            return Ok(values);
        }
    }
}
