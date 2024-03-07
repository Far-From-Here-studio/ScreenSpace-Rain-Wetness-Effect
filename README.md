# ScreenSpace-Rain-Wetness-Effect

**Unity Rain Effect for 2023.2+ using ShaderGraph, VFXGraph, CustomPass &amp; Custom Render Textures**
Demo project is setup using **DX12** and **DXR**

![PromotionalScreenShot](https://static.wixstatic.com/media/40e3ee_c7794ec59296402bae56c951d422d258~mv2.png/v1/fill/w_712,h_402,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/Capture%20d'%C3%A9cran%202024-03-07%20163209.png)

![PromotionalScreenShot](https://static.wixstatic.com/media/40e3ee_53f8959f3a5b45c4801b5741f1b833f9~mv2.png/v1/fill/w_712,h_402,al_c,q_85,usm_0.66_1.00_0.01,enc_auto/Capture%20d'%C3%A9cran%202024-03-07%20163242.png)

# Description:

Create Rainy effect in a **ScreenSpace** fashion by encoding the **HDRP normal and smoothness buffer**,

Using ***FullScreen Wetness Controller*** in the Sample Scene, users can handle the global Wetness effect, the RainDrops custom RenderTexture and the VFXgraph ColorBuffer main properties

Users can create vertex painted mask for the Rain and Wetness effect directly in the Demo Scene using ***Polybrush***, painting black or white vertex color.


**This demo showcase some central Shader** :

- **ModifyNormalRoughness** (fullscreen) **ShaderGraph** => handle the combination of all the custom buffers and create the final surface effect that apply to all object using the mask and *FullScreen Wetness Controller* properties
- **Custom RenderTexture Droplets** (rain/glide) **Shaders** => check the materials exposed on the *FullScreen Wetness Controller* to access to this advanced shaders

**CustomPass GameObjects (child of *FullScreen Wetness Controller*)**: 

- **Screen Space Wetness Pass**
- **Rain On Camera Pass**
- **Render VFX to Custom Buffer Pass**
- **Debug Vertex Color Pass**
- **Debug Roughness Pass**

Refer To the Documentation included in the repository for more information about how to use and included content

Look in Scene View and Game View can differ a little bit, since lastest unity updates Custom RenderTextures don't update syncronouly in scene view.

Enjoy!
