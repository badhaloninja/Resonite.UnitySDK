using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrooxEngine
{
    public partial class AmbientLightSH2Wrapper : IConversionPostProcessor
    {
        public void PostProcessConversion(IConversionContext context)
        {
            if (!isActiveAndEnabled)
                return;

            // Wrapper is active, set it as the active skybox
            Task.Run(async () => await Data.SetActive(context)).Wait();
        }
    }
}
