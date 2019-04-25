﻿using UnityEngine; // For PropertyAttribute
using Cinemachine;

namespace Unity.Cinemachine3
{
    public sealed class CM_PipelineAttribute : System.Attribute
    {
        public CinemachineCore.Stage Stage { get; private set; }
        public CM_PipelineAttribute(CinemachineCore.Stage stage) { Stage = stage; }
    }

    public sealed class CM_RangePropertyAttribute : PropertyAttribute {}
}
