using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System;

namespace core3Demo
{
    public class FeatureCollection : Dictionary<Type, object>, IFeatureCollection { }

    public interface IFeatureCollection : IDictionary<Type, object> { }
}
