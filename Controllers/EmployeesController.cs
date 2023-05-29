using AutoMapper;
using LeaveManagement.Common.Constanst;
using first_asp_app.Contracts;
using LeaveManagement.Data;
using first_asp_app.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace first_asp_app.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly ILeaveTypeRepository leaveTypeRepository;

        // GET: EmployeesController
        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository, ILeaveTypeRepository leaveTypeRepository) {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var employeesVM = mapper.Map<List<EmployeeVM>>(employees);
            return View(employeesVM);
        }

        // GET: EmployeesController/ViewAllocations/5
        public async Task<IActionResult> ViewAllocations(string id)
        {

            var model = await leaveAllocationRepository.GetEmployeeAllocations(id);
          
            return View(model);
        }

      

        // GET: EmployeesController/EditAllocation/5
        public async Task<IActionResult> EditAllocation(int id)
        {
            var leaveAllocation = await leaveAllocationRepository.GetAsync(id);
            if (leaveAllocation == null) {
                return NotFound();
            }
           
            var leaveAllocationVM = mapper.Map<LeaveAllocationEditVM>(leaveAllocation);
            leaveAllocationVM.Employee = mapper.Map<EmployeeVM>(await userManager.FindByIdAsync(leaveAllocation.EmployeeId));
            leaveAllocationVM.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(leaveAllocation.LeaveTypeId));
            return View(leaveAllocationVM);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var leaveAllocation = await leaveAllocationRepository.GetAsync(model.Id);
                    if(leaveAllocation == null)
                    {
                        return NotFound();
                    }
                    leaveAllocation.Period = model.Period;
                    leaveAllocation.NumberOfDays = model.NumberOfDays;
                    await leaveAllocationRepository.UpdateAsync(leaveAllocation);

                return RedirectToAction(nameof(ViewAllocations),new { id = model.EmployeeId});

                }
                throw new Exception("Error");
            }
            catch (Exception e)
            {
                ModelState.AddModelError(string.Empty, "An error has Occurred. Pleas try again later");
            }
            model.Employee = mapper.Map<EmployeeVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.LeaveType = mapper.Map<LeaveTypeVM>(await leaveTypeRepository.GetAsync(model.Id));
            return View(model);
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
