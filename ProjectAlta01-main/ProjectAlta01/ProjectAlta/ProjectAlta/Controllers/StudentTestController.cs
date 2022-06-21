﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.EntityFrameworkCore;
using ProjectAlta.Data;
using ProjectAlta.DBContext;
using ProjectAlta.Entity;
using ProjectAlta.Respository;
using AutoMapper;
using ProjectAlta.DTO;
namespace ProjectAlta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentTestController : ControllerBase
    {
        private IEStudentTest _stuTest;
        private IMapper map;

        public StudentTestController(IEStudentTest stutest, IMapper mapper)
        {
            map = mapper;
            _stuTest = stutest;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentTestDTO>>> getStuTest()
        {
            var model = _stuTest.GetAll();
            if (model == null)
            {
                return new List<StudentTestDTO>();
            }
            return model.ToList();
        }

        [HttpPost]
        public ActionResult<bool> AddStuTest(StudentTestDTO model)
        {
            var check = _stuTest.Insert(model);
            _stuTest.Save();
            return check;

        }


        [HttpPut]
        public ActionResult<bool> UpdateStuTest(StudentTestDTO model)
        {
            var check = _stuTest.Update(model);
            _stuTest.Save();
            return check;

        }
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTest(int id)
        {
            var check = _stuTest.Delete(id);

            _stuTest.Save();
            return check;

        }
    }
}
