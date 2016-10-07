// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Network.Fluent.TcpProbe.Update
{

    using Microsoft.Azure.Management.Resource.Fluent.Core.ChildResourceActions;
    using Microsoft.Azure.Management.Network.Fluent.LoadBalancer.Update;
    /// <summary>
    /// The stage of the TCP probe update allowing to modify the probe interval.
    /// </summary>
    public interface IWithIntervalInSeconds 
    {
        /// <summary>
        /// Specifies the interval between probes, in seconds.
        /// </summary>
        /// <param name="seconds">seconds number of seconds</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.Network.Fluent.TcpProbe.Update.IUpdate WithIntervalInSeconds(int seconds);

    }
    /// <summary>
    /// The stage of the TCP probe update allowing to modify the port number to monitor.
    /// </summary>
    public interface IWithPort 
    {
        /// <summary>
        /// Specifies the port number to call for health monitoring.
        /// </summary>
        /// <param name="port">port a port number</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.Network.Fluent.TcpProbe.Update.IUpdate WithPort(int port);

    }
    /// <summary>
    /// The stage of the TCP probe update allowing to modify the number of unsuccessful probes before failure is determined.
    /// </summary>
    public interface IWithNumberOfProbes 
    {
        /// <summary>
        /// Specifies the number of unsuccessful probes before failure is determined.
        /// </summary>
        /// <param name="probes">probes number of probes</param>
        /// <returns>the next stage of the update</returns>
        Microsoft.Azure.Management.Network.Fluent.TcpProbe.Update.IUpdate WithNumberOfProbes(int probes);

    }
    /// <summary>
    /// The entirety of a probe update as part of a load balancer update.
    /// </summary>
    public interface IUpdate  :
        ISettable<Microsoft.Azure.Management.Network.Fluent.LoadBalancer.Update.IUpdate>,
        IWithPort,
        IWithIntervalInSeconds,
        IWithNumberOfProbes
    {
    }
}