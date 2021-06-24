﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevEngine.UI.Controls
{
    public partial class GraphNodeParameter : ComponentBase
    {
        [Parameter]
        public DevEngine.Core.Graph.IDevGraphNodeParameter DevGraphNodeParameter { get; set; }

        [Parameter]
        public GraphNode ParentGraphNode { get; set; }

        private void OnMouseDown(MouseEventArgs args)
        {
            ParentGraphNode.OnNodeParameterMouseDown(this);
        }
    }
}