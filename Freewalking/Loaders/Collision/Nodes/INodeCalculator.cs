﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColossalFramework.Math;
using UnityEngine;

namespace Freewalking.Loaders.Collision.Nodes
{
    public interface INodeCalculator
    {
        void GetBeziers(ushort nodeId, NetNode node, NetInfo info, Vector3 position, out Bezier3 leftBezier, out Bezier3 rightBezier);
    }
}
