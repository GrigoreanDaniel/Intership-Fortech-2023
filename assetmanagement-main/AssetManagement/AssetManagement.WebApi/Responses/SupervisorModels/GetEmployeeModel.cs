namespace AssetManagement.WebApi.Responses.SupervisorModels;

/// <summary>
/// An employee model with only a few properties.
/// </summary>
public class GetEmployeeModel
{
    /// <summary>
    /// Gets or sets the id of that employee.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the fist name of that employee.
    /// </summary>
    public string FirstName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the last name of that employee.
    /// </summary>
    public string LastName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the email of that employee.
    /// </summary>
    public string Email { get; set; } = string.Empty;
}