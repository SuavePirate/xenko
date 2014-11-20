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


#line 3 "C:\Code\Paradox\sources\shaders\CubemapBlendEffect.pdxfx"
using SiliconStudio.Paradox.Effects.Data;

#line 4
using SiliconStudio.Paradox.Effects;

#line 5
using SiliconStudio.Paradox.Effects.Renderers;

#line 7
namespace CubemapBlendShader
{

    #line 9
    internal static partial class ShaderMixins
    {
        internal partial class CubemapBlendEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSourceTree mixin, ShaderMixinContext context)
            {

                #line 15
                context.Mixin(mixin, "ShaderBase");

                #line 16
                context.Mixin(mixin, "ImageEffectShader");

                #line 19
                mixin.Mixin.AddMacro("TEXTURECUBE_BLEND_COUNT", context.GetParam(CubemapBlendRenderer.CubemapCount));

                #line 21
                if (context.GetParam(CubemapBlendRenderer.UseMultipleRenderTargets))

                    #line 22
                    context.Mixin(mixin, "CubemapBlenderMRT");

                #line 24
                else

                    #line 24
                    context.Mixin(mixin, "CubemapBlender");

                #line 26
                foreach(var ____1 in context.GetParam(CubemapBlendRenderer.Cubemaps))

                {

                    #line 26
                    context.PushParameters(____1);

                    {

                        #line 28
                        var __subMixin = new ShaderMixinSourceTree() { Parent = mixin };

                        #line 28
                        context.Mixin(__subMixin, "CubemapFace", context.GetParam(CubemapBlendRenderer.CubemapKey));
                        mixin.Mixin.AddCompositionToArray("Cubemaps", __subMixin.Mixin);
                    }

                    #line 26
                    context.PopParameters();
                }
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("CubemapBlendEffect", new CubemapBlendEffect());
            }
        }
    }
}
