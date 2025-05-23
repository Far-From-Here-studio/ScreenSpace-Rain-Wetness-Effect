
#ifndef WETNESSBUFFER_INCLUDED
#define WETNESSBUFFER_INCLUDED


#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/TextureXR.hlsl"
#include "Packages/com.unity.render-pipelines.high-definition/Runtime/RenderPipeline/RenderPass/CustomPass/CustomPassCommon.hlsl"


TEXTURE2D_X(_WetnessBuffer);
SAMPLER(sampler_WetnessBuffer);

void MyFunction_float(in float2 UV, out float4 Out)
{
     // When sampling RTHandle texture, always use _RTHandleScale.xy to scale your UVs first.
    float2 scaling = _RTHandleScale.xy;
    
    if (_CustomPassInjectionPoint == CUSTOMPASSINJECTIONPOINT_AFTER_POST_PROCESS)
        scaling *= rcp(_DynamicResolutionFullscreenScale.xy);
    
    Out = SAMPLE_TEXTURE2D_X(_WetnessBuffer, sampler_WetnessBuffer, UV * scaling);
}

#endif //MYHLSLINCLUDE_INCLUDED