using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace ContactManager.Authorization;

public static class ContactOperations
{
    public static readonly OperationAuthorizationRequirement Create =
      new() { Name=Constants.CreateOperationName };
    public static readonly OperationAuthorizationRequirement Read =
      new() { Name=Constants.ReadOperationName };
    public static readonly OperationAuthorizationRequirement Update =
      new() { Name=Constants.UpdateOperationName };
    public static readonly OperationAuthorizationRequirement Delete =
      new() { Name=Constants.DeleteOperationName };
    public static readonly OperationAuthorizationRequirement Approve =
      new() { Name=Constants.ApproveOperationName };
    public static readonly OperationAuthorizationRequirement Reject =
      new() { Name=Constants.RejectOperationName };
}

public class Constants
{
    public const string CreateOperationName = "Create";
    public const string ReadOperationName = "Read";
    public const string UpdateOperationName = "Update";
    public const string DeleteOperationName = "Delete";
    public const string ApproveOperationName = "Approve";
    public const string RejectOperationName = "Reject";

    public const string ContactAdministratorsRole = "ContactAdministrators";
    public const string ContactManagersRole = "ContactManagers";
}