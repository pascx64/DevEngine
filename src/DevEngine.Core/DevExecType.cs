﻿using DevEngine.Core;
using DevEngine.Core.Project;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEngine.Core
{
    public class DevExecType : IDevType
    {
        public static readonly IDevType ExecType = new DevExecType(null);

        public DevExecType(IDevProject project)
        {
            Project = project;
        }

        public IDevProject Project { get; }

        public string TypeName => "Exec";

        public string TypeNamespace => "System";

        public bool IsClass => false;


        public bool CanBeAssignedTo(IDevType type)
        {
            return type is DevExecType;
        }
    }
}
