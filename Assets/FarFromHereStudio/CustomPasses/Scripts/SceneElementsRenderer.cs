using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine;

class VFXElementsRenderer : CustomPass
{

    public LayerMask DefaultLayerMask = 1;
    public RenderTexture VFXBufferRT;
    public Camera VFXOrthoCamera;
    RTHandle VFXBuffer;

    protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
    {
        if (VFXBufferRT) VFXBuffer = RTHandles.Alloc(VFXBufferRT);
    }
    protected override void Execute(CustomPassContext ctx)
    {
        if (VFXOrthoCamera && VFXBufferRT)
        {

            ctx.cmd.SetRenderTarget(VFXBuffer);
            ctx.cmd.ClearRenderTarget(true, true, Color.black);

            CustomPassUtils.RenderFromCamera(ctx, VFXOrthoCamera, 0);
            VFXOrthoCamera.TryGetCullingParameters(out var cullingParams);
            cullingParams.cullingOptions = CullingOptions.None;
            ctx.cullingResults = ctx.renderContext.Cull(ref cullingParams);

            ShaderTagId[] VFXElementshaderPasses = new ShaderTagId[]
            {
                HDShaderPassNames.s_ForwardName,
                HDShaderPassNames.s_SRPDefaultUnlitName,
            };

            CustomPassUtils.RenderFromCamera(ctx, VFXOrthoCamera, DefaultLayerMask);
        }
    }
}