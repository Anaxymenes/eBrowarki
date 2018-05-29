using Data.DBModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;
using Repository.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI.Controllers;
using Xunit;

namespace XUnitTest
{
    public class RoleUnitTest
    {
        [Fact]
        public void ShouldReturnAllRoles()
        {
            List<Role> roles = new List<Role>()
            {
                new Role()
                {
                    Id=1, Name="Admin"
                },
                new Role()
                {
                    Id=2, Name="User"
                }
            };

            var roleRepository = new Mock<IRoleRepository>();
            roleRepository.Setup(r => r.GetAll()).Returns(roles.AsQueryable());
            var roleService = new RoleService(roleRepository.Object);
            var roleController = new RoleController(roleService);

            //var results = roleController.GetAll() as ViewResult;

            //Assert.NotNull(results);
            //ViewDataDictionary viewData = results.ViewData;
            //Assert.Equal("GetAll", results.ViewName);

            IActionResult result = roleController.GetAll();
            var okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult);
            var resultRoles = okObjectResult.Value as List<Role>;
            Assert.NotNull(resultRoles);
            Assert.Equal(roles, resultRoles);
        }
    }
}
