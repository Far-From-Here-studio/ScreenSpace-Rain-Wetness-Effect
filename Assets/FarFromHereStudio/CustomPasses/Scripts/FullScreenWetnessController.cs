using UnityEngine;

[ExecuteAlways]
public class FullScreenWetnessController : MonoBehaviour
{
    [Header("Materials")]
    public Material FullScreenWetness;
    public Material RainOnCamera;


    [Header("Wetness Controller")]
    [Range(0f, 1f)]
    public float Wetness;
    [Range(0f, 20f)]
    public float RainDropStrenght;
    [Range(0f, 5f)]
    public float DetailsDistance;
    [Range(0f, 1f)]
    public float ScreenEffectWetness;


    [Header("RainDrop Custom RenderTexture Materials")]
    public Material RainDropCustomRenderTexture;
    [Header("RainDrop properties")]
    [Range(0,0.1f)]
    public float RainAmount = 0.0139f;
    [Range(0,1)]
    public float DropSize = 0.021f;
    [Range(0.9f, 0.95f)]
    public float FadeValue = 0.9036f;

    [Header("RainGlide Custom RenderTexture Materials")]
    public Material RainGlideCustomRenderTexture;
    [Range (0f, 5f)]
    public float DropletsIntensity = 0.8f;
    [Range(0f, 30f)]
    public float DropletsSize = 9.5f;
    [Range(0f, 2f)]
    public float GravityForce = 0.76f;

    [Header("FullScreen Debug")]
    public bool DebugVertexColor;
    public GameObject DebugVertexColorPass;
    void Update()
    {
        if (DebugVertexColorPass)
        {
            DebugVertexColorPass.SetActive(DebugVertexColor);
        }
        if(FullScreenWetness)
        {
            FullScreenWetness.SetFloat("_WaterSmoothness", Wetness);
            FullScreenWetness.SetFloat("_DropletStrenght", RainDropStrenght);
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
