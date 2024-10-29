//-----------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Global Logitech">
// Copyright (c) Global Logitech. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace AssetManagement.WebApi.Controllers;

using AssetManagement.Application.Services.Hardware;
using AssetManagement.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// An hardware controller that allows to do CRUD operations.
/// </summary>
[ApiController]
[Route("[controller]")]
public class HardwareController : ControllerBase
{
    private readonly IHardwareService _hardwareService;

    /// <summary>
    /// Initializes a new instance of the <see cref="HardwareController"/> class.
    /// </summary>
    /// <param name="employeeService">Interface service variable.</param>
    public HardwareController(IHardwareService employeeService)
    {
        _hardwareService = employeeService;
    }

    /// <summary>
    /// Delete method that erases an employee.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>A successful message.</returns>
    [HttpDelete("{id}")]
    /*public async Task<ActionResult<IEnumerable<EmployeeEntity>>> DeleteEmployee(int id, CancellationToken cancellationToken)
    {
        await _hardwareService.DeleteEmployee(id, cancellationToken);

        return Ok(id);
    }*/

    /// <summary>
    /// Get method to see all the employees from an supervisor.
    /// </summary>
    /// <param name="id">Id of an supervisor.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>All the employees of an supervisor.</returns>
    [HttpGet("getBelowEmployees")]
    /*public async Task<ActionResult<IEnumerable<GetSupervisorModel>>> GetBelowEmployees(int id, CancellationToken cancellationToken)
        => Ok(await _hardwareService.GetBelowEmployees(id, cancellationToken));*/

    /// <summary>
    /// Get method to see the name and email adress from an employee.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>The name and the email adress.</returns>
    [HttpGet("{id}")]
    /*public async Task<ActionResult<IEnumerable<EmployeeEntity>>> GetEmployee(int id, CancellationToken cancellationToken)
        => Ok(await _hardwareService.GetEmployee(id, cancellationToken));*/

    /// <summary>
    /// Get method to see all the hardwares.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>Hardware devices.</returns>
    [HttpGet("getHardwares")]
    public async Task<ActionResult<IEnumerable<EmployeeEntity>>> GetHardwares(int id, CancellationToken cancellationToken)
        => Ok(await _hardwareService.GetHardwares(id, cancellationToken));

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
    /*public async Task<ActionResult<IEnumerable<GetSupervisorModel>>> GetSupervisors(int id, CancellationToken cancellationToken)
        => Ok(await _hardwareService.GetSupervisors(id, cancellationToken));*/

    /// <summary>
    /// Post method to create a new employee.
    /// </summary>
    /// <param name="employeeModel">The model of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>A new employee.</returns>
    [HttpPost]
    /*public async Task<ActionResult<GetEmployeeModel>> PostEmployee(EmployeeModel employeeModel, CancellationToken cancellationToken)
    {
        var newEmployee = await _hardwareService.AddEmployee(employeeModel, cancellationToken);

        return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, employeeModel);
    }*/

    /// <summary>
    /// Put method to update an employee.
    /// </summary>
    /// <param name="id">Id of an employee.</param>
    /// <param name="employeeModel">The model of an employee.</param>
    /// <param name="cancellationToken">Token.</param>
    /// <returns>The new update employee.</returns>
    [HttpPut("{id}")]
    public async Task<ActionResult> PutEmployee(int id, CancellationToken cancellationToken)
    {
        var employee = await _hardwareService.GetHardwares(id, cancellationToken);

        if (employee == null)
        {
            return BadRequest();
        }

        return Ok(employee);
    }
}