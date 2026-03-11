using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FrooxEngine;
using Elements.Core;

namespace FrooxEngine
{
    // This variant is needed to copy SH2 values for skybox and ambient lighting
    [AddComponentMenu("FrooxEngine/Transform/Drivers/ValueCopy<SphericalHarmonicsL2<colorX>>")]
    public class ValueCopySH_L2_Wrapper : ValueCopyWrapper<UnityEngine.Rendering.SphericalHarmonicsL2>
    {
        // Manually override the typename
        public override string TypeName => "[FrooxEngine]FrooxEngine.ValueCopy<[Elements.Core]Elements.Core.SphericalHarmonicsL2<[Elements.Core]Elements.Core.colorX>>";
    }
}
