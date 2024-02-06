using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore.Migrations;
using Moq;
using ValorantWebsite.Components;
using ValorantWebsite.Models;
using Xunit;

namespace ValorantWebsite.Tests
{
    public class NavigationMenuViewComponentTests
    {

        [Fact]
        public void Can_Select_Categories()
        {
            // Arrange
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[] {
                new Agent {AgentID = 1, Name = "A1",
                    Role = "Apples"},
                new Agent {AgentID = 2, Name = "A2",
                    Role = "Apples"},
                new Agent {AgentID = 3, Name = "A3",
                    Role = "Plums"},
                new Agent {AgentID = 4, Name = "A4",
                    Role = "Oranges"},
            }).AsQueryable<Agent>());

            NavigationMenuViewComponent target =
                new NavigationMenuViewComponent(mock.Object);

            // Act = get the set of roles
            string[] results = ((IEnumerable<string>?)(target.Invoke()
               as ViewViewComponentResult)?.ViewData?.Model
                 ?? Enumerable.Empty<string>()).ToArray();

            // Assert
            Assert.True(Enumerable.SequenceEqual(new string[] { "Apples",
                "Oranges", "Plums" }, results));
        }

        [Fact]
        public void Indicates_Selected_Role()
        {

            // Arrange
            string roleToSelect = "Apples";
            Mock<IValorantRepository> mock = new Mock<IValorantRepository>();
            mock.Setup(m => m.Agents).Returns((new Agent[] {
                new Agent {AgentID = 1, Name = "A1", Role = "Apples"},
                new Agent {AgentID = 4, Name = "A2", Role = "Oranges"},
            }).AsQueryable<Agent>());

            NavigationMenuViewComponent target =
                new NavigationMenuViewComponent(mock.Object);
            target.ViewComponentContext = new ViewComponentContext
            {
                ViewContext = new ViewContext
                {
                    RouteData = new Microsoft.AspNetCore.Routing.RouteData()
                }
            };
            target.RouteData.Values["role"] = roleToSelect;

            // Action
            string? result = (string?)(target.Invoke()
                as ViewViewComponentResult)?.ViewData?["SelectedRole"];

            // Assert
            Assert.Equal(roleToSelect, result);
        }
    }
}