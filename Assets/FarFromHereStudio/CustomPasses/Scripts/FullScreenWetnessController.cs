using UnityEngine;

[ExecuteAlways]
public class FullScreenWetnessController : MonoBehaviour
{
    [Header("Materials")]
    [Space]
    public Material FullScreenWetness;
    public Material RainOnCamera;
    [Space]

    [Header("Wetness Controller")]
    [Space]
    [Range(0f, 1f)]
    public float Wetness;
    [Range(0f, 20f)]
    public float RainDropStrenght;
    [Range(0f, 5f)]
    public float DetailsDistance;
    [Range(0f, 1f)]
    public float ScreenEffectWetness;
    [Space]

    [Header("RainDrop Custom RenderTexture Materials")]
    [Space]
    public Material RainDropCustomRenderTexture;
    [Header("RainDrop properties")]
    [Range(0,0.1f)]
    public float RainAmount = 0.0139f;
    [Range(0,1)]
    public float DropSize = 0.021f;
    [Range(0.9f, 0.95f)]
    public float FadeValue = 0.9036f;
    [Space]

    [Header("RainGlide Custom RenderTexture Materials")]
    [Space]
    public Material RainGlideCustomRenderTexture;
    [Range (0f, 5f)]
    public float DropletsIntensity = 0.8f;
    [Range(0f, 30f)]
    public float DropletsSize = 9.5f;
    [Range(0f, 2f)]
    public float GravityForce = 0.76f;
    [Space]

    [Header("FullScreen Debug")]
    [Space]
    public bool DebugVertexColor;
    public GameObject DebugVertexColorPass;
    public bool DebugRoughness;
    public GameObject DebugRoughnessPass;
    public bool DebugNormalMap;
    public GameObject DebugNormalPass;
    void Update()
    {
        if (DebugVertexColorPass)
        {
            DebugVertexColorPass.SetActive(DebugVertexColor);
        }
        if (DebugRoughnessPass)
        {
            DebugRoughnessPass.SetActive(DebugRoughness);
        }
        if (DebugNormalPass)
        {
            DebugNormalPass.SetActive(DebugNormalMap);
        }
        if (FullScreenWetness)
        {
            var snow = Shader.GetGlobalFloat("_SnowCover");
            FullScreenWetness.SetFloat("_WaterSmoothness", Wetness * (1-snow));
            Shader.SetGlobalFloat("_Wetness", Wetness * (1 - snow));
            FullScreenWetness.SetFloat("_DropletStrenght", RainDropStrenght * (1-snow));
            Shader.SetGlobalFloat("_RainDrops", RainDropStrenght * (1 - snow));
            FullScreenWetness.SetFloat("_DistanceView", DetailsDistance);
        }
        if(RainOnCamera)
        {
            RainOnCamera.SetFloat("_Influence", ScreenEffectWetness * Wetness);
        }  
        if(RainDropCustomRenderTexture)
        {
            RainDropCustomRenderTexture.SetFloat("_Rain_Amount", RainAmount);
            RainDropCustomRenderTexture.SetFloat("_Drop_Size", DropSize);
            RainDropCustomRenderTexture.SetFloat("_Fade_Value", FadeValue);
        }
        if (RainGlideCustomRenderTexture)
        {
            RainGlideCustomRenderTexture.SetFloat("_Droplets_Intensity", DropletsIntensity);
            RainGlideCustomRenderTexture.SetFloat("_Droplets_Size", DropletsSize);
            RainGlideCustomRenderTexture.SetFloat("_Gravity_Force", GravityForce);
        }
    }

}
