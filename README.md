# ScreenSpace-Rain-Wetness-Effect
Unity Rain Effect for 2023.2+ using ShaderGraph, VFXGraph, CustomPass &amp; Custom Render Textures
Demo project is setup using DX12 and DXR

![PromotionalScreenShot](https://static.wixstatic.com/media/40e3ee_e44f9952e8894f8ba6b4e00059bafad3~mv2.png/v1/fill/w_802,h_454,al_c,q_90,usm_0.66_1.00_0.01,enc_auto/1.png)

# Description:

Create Rainy effect in a **ScreenSpace** fashion by encoding the **HDRP normal and smoothness buffer**,

Using *FullScreen Wetness Controller* in the Sample Scene, users can handle the global Wetness effect, the RainDrops custom RenderTexture and the VFXgraph ColorBuffer main properties

Users can create vertex painted mask for the Rain and Wetness effect directly in the Demo Scene using **Polybrush**, painting black or white vertex color.


**This demo showcase some central Shader** :

- ModifyNormalRoughness (fullscreen) ShaderGraph => handle the combination of all the custom buffers and create the final surface effect that apply to all object using the mask and *FullScreen Wetness Controller* properties
- Custom RenderTexture Droplets (rain/glide) Shaders => check the materials exposed on the *FullScreen Wetness Controller* to access to this advanced shaders

**CustomPass GameObjects (child of *FullScreen Wetness Controller*)**: 

- Screen Space Wetness
- Rain On Camera
- Render VFX to Custom Buffer
- Debug Vertex Color

Refer To the Documentation included in the repository for more information about how to use and included content
