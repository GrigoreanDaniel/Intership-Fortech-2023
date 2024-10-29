// <copyright file="GetSupervisorModel.cs" company="Global Logitech">
// Copyright (c) Global Logitech. All rights reserved.
// </copyright>

namespace AssetManagement.WebApi.Responses.SupervisorModels
{
    /// <summary>
    /// Supervisor model.
    /// </summary>
    public class GetSupervisorModel
    {
        /// <summary>
        /// Gets or sets the index of the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a collection of employees that are supervised.
        /// </summary>
        public ICollection<GetEmployeeModel>? BelowEmployees { get; set; }
    }
}