using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http.Controllers;
using System.Web.Http.Routing;

namespace MFD.Common.Api.Infrastructure.Attributes
{
    /// <summary>
    /// Class <see cref="InheritedControllerRouteAttributesProvider"/> allows for controllers to inherit routing attributes.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class InheritedControllerRouteAttributesProvider : DefaultDirectRouteProvider
    {
        /// <summary>
        /// Gets a set of route factories for the given action descriptor.
        /// </summary>
        /// <returns>
        /// A set of route factories.
        /// </returns>
        /// <param name="actionDescriptor">The action descriptor.</param>
        protected override IReadOnlyList<IDirectRouteFactory> GetActionRouteFactories(HttpActionDescriptor actionDescriptor)
        {
            return actionDescriptor.GetCustomAttributes<IDirectRouteFactory>(true);
        }
    }
}