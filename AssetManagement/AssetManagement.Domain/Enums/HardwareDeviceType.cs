namespace AssetManagement.Domain.Enums;

/// <summary>
/// Defines a list of acceptable hardware types, like laptop or PC.
/// Replaces the database table HardwareDeviceTypes, because this approach is simpler.
/// In 2023-09-27 it was decided to take this approach so the database structure is simpler and to eliminate the need for repositories.
/// </summary>
internal enum HardwareDeviceTypes
{
    /// <summary>
    /// Default value, when hardware type is not yet set.
    /// </summary>
    NotSet = 0,

    /// <summary>
    /// Laptop, including foldables.
    /// </summary>
    Laptop = 1,

    /// <summary>
    /// Monitor type hardware.
    /// </summary>
    Monitor = 2,

    /// <summary>
    /// Mouse, wireless ones.
    /// </summary>
    Mouse = 3,

    /// <summary>
    /// One pair of headphones.
    /// </summary>
    Headphones = 4,

    /// <summary>
    /// Charger for the laptop.
    /// </summary>
    Charger = 5,

    Keyboard = 6,
}