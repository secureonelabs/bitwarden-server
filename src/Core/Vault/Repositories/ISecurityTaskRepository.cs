﻿using Bit.Core.Repositories;
using Bit.Core.Vault.Entities;
using Bit.Core.Vault.Enums;

namespace Bit.Core.Vault.Repositories;

public interface ISecurityTaskRepository : IRepository<SecurityTask, Guid>
{
    /// <summary>
    /// Retrieves security tasks for a user based on their organization and cipher access permissions.
    /// </summary>
    /// <param name="userId">The Id of the user retrieving tasks</param>
    /// <param name="status">Optional filter for task status. If not provided, returns tasks of all statuses</param>
    /// <returns></returns>
    Task<ICollection<SecurityTask>> GetManyByUserIdStatusAsync(Guid userId, SecurityTaskStatus? status = null);

    /// <summary>
    /// Retrieves all security tasks for an organization.
    /// </summary>
    /// <param name="organizationId">The id of the organization</param>
    /// <param name="status">Optional filter for task status. If not provided, returns tasks of all statuses</param>
    /// <returns></returns>
    Task<ICollection<SecurityTask>> GetManyByOrganizationIdStatusAsync(Guid organizationId, SecurityTaskStatus? status = null);

    /// <summary>
    ///  Creates bulk security tasks for an organization.
    /// </summary>
    /// <param name="tasks">Collection of tasks to create</param>
    /// <returns>Collection of created security tasks</returns>
    Task<ICollection<SecurityTask>> CreateManyAsync(IEnumerable<SecurityTask> tasks);
}
