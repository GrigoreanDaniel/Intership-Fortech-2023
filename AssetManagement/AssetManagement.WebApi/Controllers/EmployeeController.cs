//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Global Logitech">
// Copyright (c) Global Logitech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AssetManagement.WebApi.Controllers;

using AssetManagement.Application.Models.Requests.Employee;
using AssetManagement.Application.Models.Responses.Employee;
using AssetManagement.Application.Services.Employee;
using AssetManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// An employee controller that allows to do CRUD operations.
/// </summary>
[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeController"/> class.
    /// </summary>
    /// <param name="employeeService">Interface service variable.</param>
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    /// <summary>
    /// Delete method that erases an employee.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>A successful message.</returns>
    [HttpDelete("{id}")]
    public async Task<ActionResult<IEnumerable<EmployeeEntity>>> DeleteEmployee(int id, CancellationToken cancellationToken)
    {
        await _employeeService.DeleteEmployee(id, cancellationToken);

        return Ok(id);
    }

    /// <summary>
    /// Get method to see all the employees from an supervisor.
    /// </summary>
    /// <param name="id">Id of an supervisor.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>All the employees of an supervisor.</returns>
    [HttpGet("getBelowEmployees")]
    public async Task<ActionResult<IEnumerable<GetSupervisorModel>>> GetBelowEmployees(int id, CancellationToken cancellationToken)
        => Ok(await _employeeService.GetBelowEmployees(id, cancellationToken));

    /// <summary>
    /// Get method to see the name and email adress from an employee.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>The name and the email adress.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<EmployeeEntity>>> GetEmployee(int id, CancellationToken cancellationToken)
        => Ok(await _employeeService.GetEmployee(id, cancellationToken));

    /// <summary>
    /// Get method to see all the hardwares.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>Hardware devices.</returns>
    [HttpGet("getHardwares")]
    public async Task<ActionResult<IEnumerable<EmployeeEntity>>> GetHardwares(int id, CancellationToken cancellationToken)
        => Ok(await _employeeService.GetHardwares(id, cancellationToken));

    /*[HttpGet("getSoftwares")]
    public async Task<ActionResult<IEnumerable<EmployeeEntity>>> GetSoftwares(int id, CancellationToken cancellationToken)
        => Ok(await _employeeService.GetSoftwares(id, cancellationToken));*/

    /// <summary>
    /// Get method to see all the supervisors.
    /// </summary>
    /// <param name="id">Id of an emloyee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>All the supervisors of an employee.</returns>
    [HttpGet("getSupervisors")]
    public async Task<ActionResult<IEnumerable<GetSupervisorModel>>> GetSupervisors(int id, CancellationToken cancellationToken)
        => Ok(await _employeeService.GetSupervisors(id, cancellationToken));

    /// <summary>
    /// Post method to create a new employee.
    /// </summary>
    /// <param name="employeeModel">The model of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>A new employee.</returns>
    [HttpPost]
    public async Task<ActionResult<GetEmployeeModel>> PostEmployee(EmployeeModel employeeModel, CancellationToken cancellationToken)
    {
        var newEmployee = await _employeeService.AddEmployee(employeeModel, cancellationToken);

        return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, employeeModel);
    }

    /// <summary>
    /// Put method to update an employee.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="employeeModel">The model of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>The new update employee.</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult> PutEmployee(int id, EmployeeModel employeeModel, CancellationToken cancellationToken)
    {
        var employee = await _employeeService.UpdateEmployee(id, employeeModel, cancellationToken);

        if (employee == null)
        {
            return BadRequest();
        }

        return Ok(employee);
    }
}