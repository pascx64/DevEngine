using DevEngine.FakeTypes.Class;
using DevEngine.Core;
using DevEngine.Core.Class;
using DevEngine.Core.Project;
using DevEngine.RealTypes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DevEngine.Core.Graph;

namespace DevEngine.FakeTypes.Project
{
    public class DevProject : IDevProject
    {
        private IServiceProvider ServiceProvider { get; }

        public IDevClassCollection Classes { get; } = new DevClassCollection();

        public DevProject(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

        public IDevType GetRealType(Type type)
        {
            return ServiceProvider.GetRequiredService<IRealTypesProviderService>().GetDevType(this, type);
        }

        public IDevType GetRealType<T>()
        {
            return GetRealType(typeof(T));
        }

        public IDevType GetVoidType()
        {
            return GetRealType(typeof(void));
        }

        public IDevGraphNodeParameter CreateGraphNodeParameter(string name, IDevType devType, bool isInput, IDevGraphNode owner)
        {
            return new Graph.DevGraphNodeParameter(isInput, devType, name, owner);
        }
    }
}
