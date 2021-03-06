// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ServiceBus.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.ServiceBus.Fluent.QueueAuthorizationRule.Update;
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Type representing authorization rule defined for queue.
    /// </summary>
    public interface IQueueAuthorizationRule  :
        IBeta,
        Microsoft.Azure.Management.ServiceBus.Fluent.IAuthorizationRule<Microsoft.Azure.Management.ServiceBus.Fluent.IQueueAuthorizationRule>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.IUpdatable<QueueAuthorizationRule.Update.IUpdate>
    {
        /// <summary>
        /// Gets the name of the namespace that the parent queue belongs to.
        /// </summary>
        string NamespaceName { get; }

        /// <summary>
        /// Gets the name of the parent queue name.
        /// </summary>
        string QueueName { get; }
    }
}