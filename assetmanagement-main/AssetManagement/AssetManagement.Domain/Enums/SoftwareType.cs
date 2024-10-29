namespace AssetManagement.Domain.Enums;

/// <summary>
/// Defines a list of acceptable software types, like Pro or Enterprise.
/// Replaces the database table SoftwareTypes, because this approach is simpler.
/// In 2023-09-27 it was decided to take this approach so the database structure is simpler and to eliminate the need for repositories.
/// </summary>
internal enum SoftwareTypes
{
    /// <summary>
    /// Default value, when software type is not yet set.
    /// </summary>
    NotSet = 0,

    Pro = 1,

    Enterprise = 2,

    Home = 3,

    Business = 4,

    Family = 5,

    Personal = 6,
}