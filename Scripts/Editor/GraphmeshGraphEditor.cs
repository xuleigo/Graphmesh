﻿using System.Collections;
using System.Collections.Generic;
using Graphmesh;
using UnityEngine;
using XNodeEditor;

namespace GraphmeshEditor {
	[CustomNodeGraphEditor(typeof(GraphmeshGraph))]
	public class GraphmeshGraphEditor : NodeGraphEditor {

		public override string GetNodeMenuName(System.Type type) {
			if (type.Namespace == "Graphmesh") return base.GetNodeMenuName(type).Replace("Graphmesh/", "");
			else return null;
		}
	}
}