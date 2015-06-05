using ASPNET5VCsTest1.Models;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET5VCsTest1.ViewComponents
{
    public class EmpVCsViewComponent : ViewComponent
    {
        public EmpVCsViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await GetItemsAsync();

            return View("EVc", result);
        }

        private Task<IEnumerable<Employee>> GetItemsAsync()
        {
            var result = new List<Employee>(
                new Employee[] {
                    new Employee() {
                        ID = 1,
                        EmpName = "Gelis"
                    },
                    new Employee() {
                        ID = 2,
                        EmpName = "Allan"
                    }
                });

            return Task.FromResult(result.AsEnumerable());
        }
    }
}