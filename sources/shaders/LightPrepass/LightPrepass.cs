﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Paradox.Effects;
using SiliconStudio.Paradox.Graphics;
using SiliconStudio.Paradox.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Paradox.Graphics.Buffer;

namespace SiliconStudio.Paradox.Effects
{
    public static partial class LightPrepassKeys
    {
        public static readonly ParameterKey<int> LightCount = ParameterKeys.New<int>(64);
        public static readonly ParameterKey<int> TileIndex = ParameterKeys.New<int>(0);
        public static readonly ParameterKey<float> LightAttenuationCutoff = LightKeys.LightAttenuationCutoff;
    }
}
