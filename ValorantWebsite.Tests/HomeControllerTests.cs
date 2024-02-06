using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Moq;
using ValorantWebsite.Controllers;
using ValorantWebsite.Models;
using ValorantWebsite.Models.ViewModels;
using Xunit;

namespace ValorantWebsite.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Can_Use_Repository()
        {
            // Arrange
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[]
                {
                new Agent {AgentID = 1, Name = "A1"},
                new Agent {AgentID = 2, Name = "A2"}
                }).AsQueryable<Agent>());

            HomeController controller = new HomeController(mock.Object);

            // Act
            AgentsListViewModel result = controller.Index(null)?.ViewData.Model as AgentsListViewModel ?? new();

            // Assert
            Agent[] agentArray = result.Agents.ToArray();
            Assert.True(agentArray.Length == 2);
            Assert.Equal("A1", agentArray[0].Name);
            Assert.Equal("A2", agentArray[1].Name);
        }

        [Fact]
        public void Can_Paginate() {
            // Arrange
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[] {
                new Agent {AgentID = 1, Name = "A1"},
                new Agent {AgentID = 2, Name = "A2"},
                new Agent {AgentID = 3, Name = "A3"},
                new Agent {AgentID = 4, Name = "A4"},
                new Agent {AgentID = 5, Name = "A5"}
            }).AsQueryable<Agent>());
                        
            HomeController controller = new HomeController(mock.Object);
            controller.PageSize = 3;

            // Act
            AgentsListViewModel result = controller.Index(null, 2)?.ViewData.Model as AgentsListViewModel
            ?? new();



            // Assert
            Agent[] agentArray = result.Agents.ToArray();
            Assert.True(agentArray.Length == 2);
            Assert.Equal("A4", agentArray[0].Name);
            Assert.Equal("A5", agentArray[1].Name);
        }

        [Fact]
        public void Can_Send_Pagination_View_Model()
        {

            // Arrange
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[] 
            {
                new Agent {AgentID = 1, Name = "A1"},
                new Agent {AgentID = 2, Name = "A2"},
                new Agent {AgentID = 3, Name = "A3"},
                new Agent {AgentID = 4, Name = "A4"},
                new Agent {AgentID = 5, Name = "A5"}
            }).AsQueryable<Agent>());

            // Arrange
            HomeController controller =
                new HomeController(mock.Object) { PageSize = 3 };

            // Act
            AgentsListViewModel result =
                controller.Index(null,2)?.ViewData.Model as AgentsListViewModel
                    ?? new();

            // Assert
            PagingInfo pageInfo = result.PagingInfo;
            Assert.Equal(2, pageInfo.CurrentPage);
            Assert.Equal(3, pageInfo.ItemsPerPage);
            Assert.Equal(5, pageInfo.TotalItems);
            Assert.Equal(2, pageInfo.TotalPages);
        }

        [Fact]
        public void Can_Filter_Agents()
        {
            // Arrange
            // - create the mock repository
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[] {
            new Agent {AgentID = 1, Name = "A1", Role = "Role1"},
            new Agent {AgentID = 2, Name = "A2", Role = "Role2"},
            new Agent {AgentID = 3, Name = "A3", Role = "Role1"},
            new Agent {AgentID = 4, Name = "A4", Role = "Role2"},
            new Agent {AgentID = 5, Name = "A5", Role = "Role3"}
        }).AsQueryable<Agent>());

            // Arrange - create a controller and make the page size 3 items
            HomeController controller = new HomeController(mock.Object);
            controller.PageSize = 3;

            // Action
            Agent[] result = (controller.Index("Role2", 1)?.ViewData.Model
                as AgentsListViewModel ?? new()).Agents.ToArray();

            // Assert
            Assert.Equal(2, result.Length);
            Assert.True(result[0].Name == "A2" && result[0].Role == "Role2");
            Assert.True(result[1].Name == "A4" && result[1].Role == "Role2");
        }

        [Fact]
        public void Generate_Role_Specific_Agent_Count()
        {
            // Arrange
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[] {
        new Agent {AgentID = 1, Name = "A1", Role = "Role1"},
        new Agent {AgentID = 2, Name = "A2", Role = "Role2"},
        new Agent {AgentID = 3, Name = "A3", Role = "Role1"},
        new Agent {AgentID = 4, Name = "A4", Role = "Role2"},
        new Agent {AgentID = 5, Name = "A5", Role = "Role3"}
    }).AsQueryable<Agent>());

            HomeController target = new HomeController(mock.Object);
            target.PageSize = 3;

            Func<ViewResult, AgentsListViewModel?> GetModel = result
                => result?.ViewData?.Model as AgentsListViewModel;

            // Action
            int? res1 = GetModel(target.Index("Role1"))?.PagingInfo.TotalItems;
            int? res2 = GetModel(target.Index("Role2"))?.PagingInfo.TotalItems;
            int? res3 = GetModel(target.Index("Role3"))?.PagingInfo.TotalItems;
            int? resAll = GetModel(target.Index(null))?.PagingInfo.TotalItems;

            // Assert
            Assert.Equal(2, res1);
            Assert.Equal(2, res2);
            Assert.Equal(1, res3);
            Assert.Equal(5, resAll);
        }
    }
}
