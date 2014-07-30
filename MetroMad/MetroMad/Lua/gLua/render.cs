//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// /*  AutoGeneratedCode.cs - This class Is autogenerated.
//
//    Copyright (C) 2014  Ali Deym (https://github.com/111WARLOCK111/).
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License along
//    with this program; if not, write to the Free Software Foundation, Inc.,
//    51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
//*/
namespace MetroMad.Lua.gLua {
    using System;
    
    
    public class render {
        
        // <realm>Client</realm>
        // <summary>Adds a beam segment to the beam started by {{LibraryFunction|render|StartBeam}}.</summary>
        // <param name="startPos">Beam start position.</param>
        // <param name="width">The width of the beam.</param>
        // <param name="textureEnd">The end coordinate of the texture used.</param>
        // <param name="color">The color to be used. Uses the {{Struct|Color}}.</param>
        public static void AddBeam(Vector startPos, float width, float textureEnd, table color) {
        }
        
        // <realm>Client</realm>
        public static void BlurRenderTarget() {
        }
        
        // <realm>Client</realm>
        // <param name="mat">The material to override with.</param>
        public static void BrushMaterialOverride(IMaterial mat) {
        }
        
        // <realm>Client</realm>
        // <summary>Captures a part of the current render target and returns the data as a binary string in the given format.</summary>
        // <param name="captureData">Parameters of the capture. See {{Struct|RenderCaptureData}}.</param>
        public static void Capture(table captureData) {
        }
        
        // <realm>Client</realm>
        // <summary>Dumps the current render target and allows the pixels to be accessed by {{LibraryFunction|render|ReadPixel}}.</summary>
        public static void CapturePixels() {
        }
        
        // <realm>Client</realm>
        // <summary>Clears the current render target and the specified buffers.</summary>
        // <param name="r">Red component to clear to.</param>
        // <param name="g">Green component to clear to.</param>
        // <param name="b">Blue component to clear to.</param>
        // <param name="a">Alpha component to clear to.</param>
        // <param name="clearDepth">Clear the depth.</param>
        // <param name="clearStencil">Clear the stencil.</param>
        public static void Clear(float r, float g, float b, float a, boolean clearDepth, boolean clearStencil) {
        }
        
        // <realm>Client</realm>
        // <summary>Clears the current rendertarget for obeying the current stencil buffer conditions.</summary>
        // <param name="r">Value of the red channel to clear the current rt with.</param>
        // <param name="g">Value of the green channel to clear the current rt with.</param>
        // <param name="b">Value of the blue channel to clear the current rt with.</param>
        // <param name="a">Value of the alpha channel to clear the current rt with.</param>
        // <param name="depth">Clear the depth buffer.</param>
        public static void ClearBuffersObeyStencil(float r, float g, float b, float a, boolean depth) {
        }
        
        // <realm>Client</realm>
        // <summary>Resets the depth buffer.</summary>
        public static void ClearDepth() {
        }
        
        // <realm>Client</realm>
        // <summary>Clears a render target</summary>
        // <param name="color">The color, see {{Struct|Color}}.</param>
        public static void ClearRenderTarget(table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Resets all values in the stencil buffer to zero.</summary>
        public static void ClearStencil() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the stencil value in a specified rect.</summary>
        // <param name="originX">X origin of the rectangle.</param>
        // <param name="originY">Y origin of the rectangle.</param>
        // <param name="endX">The end X coordinate of the rectangle.</param>
        // <param name="endY">The end Y coordinate of the rectangle.</param>
        // <param name="stencilValue">Value to set cleared stencil buffer to.</param>
        public static void ClearStencilBufferRectangle(float originX, float originY, float endX, float endY, float stencilValue) {
        }
        
        // <realm>Client</realm>
        // <summary>Calculates the lighting caused by dynamic lights for the specified surface.</summary>
        // <param name="position">The position to sample from.</param>
        // <param name="normal">The normal of the surface.</param>
        public static void ComputeDynamicLighting(Vector position, Vector normal) {
        }
        
        // <realm>Client</realm>
        // <summary>Calculates the light color of a certain surface.</summary>
        // <param name="position">The position of the surface to get the light from.</param>
        // <param name="normal">The normal of the surface to get the light from.</param>
        public static void ComputeLighting(Vector position, Vector normal) {
        }
        
        // <realm>Client</realm>
        public static void CopyRenderTargetToTexture() {
        }
        
        // <realm>Client</realm>
        // <summary>Copies the contents of one texture to another</summary>
        public static void CopyTexture() {
        }
        
        // <realm>Client</realm>
        // <summary>Changes the cull mode.</summary>
        // <param name="cullMode">Cullmode, see {{Enum|MATERIAL_CULLMODE}}.</param>
        public static void CullMode(float cullMode) {
        }
        
        // <realm>Client</realm>
        public static void DepthRange() {
        }
        
        // <realm>Client</realm>
        // <summary>Draws textured beam.</summary>
        // <param name="startPos">Beam start position.</param>
        // <param name="endPos">Beam end position.</param>
        // <param name="width">The width of the beam.</param>
        // <param name="textureStart">The start coordinate of the texture used.</param>
        // <param name="textureEnd">The end coordinate of the texture used.</param>
        // <param name="color">The color to be used. Uses the {{Struct|Color}}.</param>
        public static void DrawBeam(Vector startPos, Vector endPos, float width, float textureStart, float textureEnd, table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a rotated box in 3d space.</summary>
        // <param name="position">Position of the sprite.</param>
        // <param name="angles">Orientation of the box.</param>
        // <param name="mins">Start position of the box.</param>
        // <param name="maxs">End position of the box.</param>
        // <param name="color">The color of the box. Uses the {{Struct|Color}}.</param>
        // <param name="writeZ">End position of the box.</param>
        public static void DrawBox(Vector position, Angle angles, Vector mins, Vector maxs, table color, boolean writeZ) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a line in 3d space.</summary>
        // <param name="startPos">Line start position.</param>
        // <param name="endPos">Line end position.</param>
        // <param name="color">The color to be used. Uses the {{Struct|Color}}.</param>
        // <param name="writeZ">Sets whenever to write to the zBuffer.</param>
        public static void DrawLine(Vector startPos, Vector endPos, table color, boolean writeZ) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws 2 connected triangles.</summary>
        // <param name="vert1">First vertec.</param>
        // <param name="vert2">The second vertex.</param>
        // <param name="vert3">The third vertex.</param>
        // <param name="ver4">The fourth vertex.</param>
        // <param name="color">The color of the quad. See {{GlobalFunction|Color}}.</param>
        public static void DrawQuad(Vector vert1, Vector vert2, Vector vert3, Vector ver4, table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a quad.</summary>
        // <param name="position">Origin of the sprite.</param>
        // <param name="normal">The face direction of the quad.</param>
        // <param name="width">The width of the quad.</param>
        // <param name="height">The height of the quad.</param>
        // <param name="color">The color of the quad. Uses the {{Struct|Color}}.</param>
        // <param name="rotation">The rotation of the quad in degrees.</param>
        public static void DrawQuadEasy(Vector position, Vector normal, float width, float height, table color, float rotation) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws the the current material to the whole screen.</summary>
        public static void DrawScreenQuad() {
        }
        
        // <realm>Client</realm>
        // <summary>Draws the the current material to the area specified.</summary>
        // <param name="startX">X start position of the rect.</param>
        // <param name="startY">Y start position of the rect.</param>
        // <param name="width">Width of the rect.</param>
        // <param name="height">Height of the rect.</param>
        public static void DrawScreenQuadEx(float startX, float startY, float width, float height) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a sphere in 3d space.</summary>
        // <param name="position">Position of the sprite.</param>
        // <param name="radius">Radius of the sphere.</param>
        // <param name="longitudeSteps">The amount of longitude steps.</param>
        // <param name="latitudeSteps">The amount of latitude steps.</param>
        // <param name="color">The color of the sphere. Uses the {{Struct|Color}}.</param>
        public static void DrawSphere(Vector position, float radius, float longitudeSteps, float latitudeSteps, table color) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a sprite in 3d space.</summary>
        // <param name="position">Position of the sprite.</param>
        // <param name="width">Width of the sprite.</param>
        // <param name="height">Height of the sprite.</param>
        // <param name="color">Color of the sprite. Uses the {{Struct|Color}}.</param>
        public static void DrawSprite(Vector position, float width, float height, table color) {
        }
        
        // <realm>Client</realm>
        public static void DrawTextureToScreen() {
        }
        
        // <realm>Client</realm>
        public static void DrawTextureToScreenRect() {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a wireframe box in 3d space.</summary>
        // <param name="position">Position of the box.</param>
        // <param name="angle">Angles of the box.</param>
        // <param name="mins">The lowest corner of the box.</param>
        // <param name="maxs">The highest corner of the box.</param>
        // <param name="color">The color of the box. Uses the {{Struct|Color}}.</param>
        // <param name="writeZ">Sets whenever to write to the zBuffer.</param>
        public static void DrawWireframeBox(Vector position, Angle angle, Vector mins, Vector maxs, table color, boolean writeZ) {
        }
        
        // <realm>Client</realm>
        // <summary>Draws a rotated wireframe box in 3d space.</summary>
        // <param name="position">Position of the sprite.</param>
        // <param name="size">The size of the sphere.</param>
        // <param name="sectors">Number of sectors in the circle.</param>
        // <param name="segments">The number of segments.</param>
        // <param name="[color]">The color of the box.</param>
        // <param name="[writeZ]">End position of the box.</param>
        public static void DrawWireframeSphere(Vector position, float size, float sectors, float segments, table [color], boolean [writeZ]) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the status of the clip renderer, returns previous state.</summary>
        // <param name="state">New clipping state.</param>
        public static void EnableClipping(boolean state) {
        }
        
        // <realm>Client</realm>
        // <summary>Ends the beam mesh of a beam started with {{LibraryFunction|render|StartBeam}}.</summary>
        public static void EndBeam() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the color of the fog.</summary>
        // <param name="red">Red channel of the fog color.</param>
        // <param name="green">Green channel of the fog color.</param>
        // <param name="blue">Blue channel of the fog color.</param>
        public static void FogColor(float red, float green, float blue) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the at which the fog reaches its max density.</summary>
        // <param name="distance">The distance at which the fog reaches its max density.</param>
        public static void FogEnd(float distance) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the maximum density of the fog.</summary>
        // <param name="maxDensity">The maximum density of the fog.</param>
        public static void FogMaxDensity(float maxDensity) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the mode of fog.</summary>
        // <param name="fogMode">Fog mode, see {{Enum|MATERIAL_FOG}}.</param>
        public static void FogMode(float fogMode) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the distance at which the fog starts showing up.</summary>
        // <param name="fogStart">The distance at which the fog starts showing up.</param>
        public static void FogStart(float fogStart) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the ambient color of the map.</summary>
        public static void GetAmbientLightColor() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the current alpha blending.</summary>
        public static void GetBlend() {
        }
        
        // <realm>Client</realm>
        public static void GetBloomTex0() {
        }
        
        // <realm>Client</realm>
        public static void GetBloomTex1() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the current color modulation values as normals.</summary>
        public static void GetColorModulation() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the maximum available directX version.</summary>
        public static void GetDXLevel() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the current fog color.</summary>
        public static void GetFogColor() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the fog start and end distance.</summary>
        public static void GetFogDistances() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the fog mode.</summary>
        public static void GetFogMode() {
        }
        
        // <realm>Client</realm>
        public static void GetFullScreenDepthTexture() {
        }
        
        // <realm>Client</realm>
        // <summary>Gets the light exposure on the specified position.</summary>
        // <param name="position">The position of the surface to get the light from.</param>
        public static void GetLightColor(Vector position) {
        }
        
        // <realm>Client</realm>
        public static void GetMoBlurTex0() {
        }
        
        // <realm>Client</realm>
        public static void GetMoBlurTex1() {
        }
        
        // <realm>Client</realm>
        public static void GetMorphTex0() {
        }
        
        // <realm>Client</realm>
        public static void GetMorphTex1() {
        }
        
        // <realm>Client</realm>
        public static void GetPowerOfTwoTexture() {
        }
        
        // <realm>Client</realm>
        public static void GetRefractTexture() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the currently active render target.</summary>
        public static void GetRenderTarget() {
        }
        
        // <realm>Client</realm>
        public static void GetResolvedFullFrameDepth() {
        }
        
        // <realm>Client</realm>
        public static void GetScreenEffectTexture() {
        }
        
        // <realm>Client</realm>
        public static void GetSmallTex0() {
        }
        
        // <realm>Client</realm>
        public static void GetSmallTex1() {
        }
        
        // <realm>Client</realm>
        public static void GetSuperFPTex() {
        }
        
        // <realm>Client</realm>
        public static void GetSuperFPTex2() {
        }
        
        // <realm>Client</realm>
        // <summary>Performs a render trace and returns the color of the surface hit, this uses a low res version of the texture.</summary>
        // <param name="startPos">The start position to trace from.</param>
        // <param name="endPos">The end position of the trace.</param>
        public static void GetSurfaceColor(Vector startPos, Vector endPos) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns a vector representing linear tone mapping scale.</summary>
        public static void GetToneMappingScaleLinear() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the render material override.</summary>
        // <param name="material">The material to use as override, use nil to disable.</param>
        public static void MaterialOverride(IMaterial material) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the maximum texture height the renderer can handle.</summary>
        public static void MaxTextureHeight() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the maximum texture width the renderer can handle.</summary>
        public static void MaxTextureWidth() {
        }
        
        // <realm>Client</realm>
        // <summary>Creates a new ClientsideModel, renders it at the specified pos/ang, and removes it</summary>
        // <param name="settings">Requires:.</param>
        public static void Model(table settings) {
        }
        
        // <realm>Client</realm>
        public static void ModelMaterialOverride() {
        }
        
        // <realm>Client</realm>
        // <summary>Overrides the write behaviour of all next rendering operations towards the alpha channel of the current render target.</summary>
        // <param name="enable">Enable or disable the override.</param>
        // <param name="shouldWrite">If the previous argument is true, sets whether the next rendering operations should write to the alpha channel or not. Has no effect if the previous argument is false.</param>
        public static void OverrideAlphaWriteEnable(boolean enable, boolean shouldWrite) {
        }
        
        // <realm>Client</realm>
        // <summary>Overrides the write behaviour of all next rendering operations towards the color channel of the current render target.</summary>
        // <param name="enable">Enable or disable the override.</param>
        // <param name="shouldWrite">If the previous argument is true, sets whether the next rendering operations should write to the color channel or not. Has no effect if the previous argument is false.</param>
        public static void OverrideColorWriteEnable(boolean enable, boolean shouldWrite) {
        }
        
        // <realm>Client</realm>
        // <summary>Overrides the write behaviour of all next rendering operations towards the depth buffer.</summary>
        // <param name="enable">Enable or disable the override.</param>
        // <param name="shouldWrite">If the previous argument is true, sets whether the next rendering operations should write to the depth buffer or not. Has no effect if the previous argument is false.</param>
        public static void OverrideDepthEnable(boolean enable, boolean shouldWrite) {
        }
        
        // <realm>Client</realm>
        public static void PerformFullScreenStencilOperation() {
        }
        
        // <realm>Client</realm>
        // <summary>Removes the current active clipping plane from the clip plane stack.</summary>
        public static void PopCustomClipPlane() {
        }
        
        // <realm>Client</realm>
        // <summary>Pops the current texture mag filter from the filter stack.</summary>
        public static void PopFilterMag() {
        }
        
        // <realm>Client</realm>
        // <summary>Pops the current texture min filter from the filter stack.</summary>
        public static void PopFilterMin() {
        }
        
        // <realm>Client</realm>
        // <summary>Pops the current flashlight mode from the flashlight mode stack.</summary>
        public static void PopFlashlightMode() {
        }
        
        // <realm>Client</realm>
        // <summary>Pops the last render target and viewport from the RT stack and sets them as the current render target and viewport.</summary>
        public static void PopRenderTarget() {
        }
        
        // <realm>Client</realm>
        // <summary>Pushes a new clipping plane of the clip plane stack and sets it as active.</summary>
        // <param name="normal">The normal of the clipping plane.</param>
        // <param name="distance">The distance of the plane.</param>
        public static void PushCustomClipPlane(Vector normal, float distance) {
        }
        
        // <realm>Client</realm>
        // <summary>Pushes a texture filter onto the mag texture filter stack.</summary>
        // <param name="texFilterType">The texture filter type, see {{Enum|TEXFILTER}}.</param>
        public static void PushFilterMag(float texFilterType) {
        }
        
        // <realm>Client</realm>
        // <summary>Pushes a texture filter onto the min texture filter stack.</summary>
        // <param name="texFilterType">The texture filter type, see {{Enum|TEXFILTER}}.</param>
        public static void PushFilterMin(float texFilterType) {
        }
        
        // <realm>Client</realm>
        // <summary>Enables the flashlight projection for the upcoming rendering.</summary>
        // <param name="enable">Whether the flashlight mode should be enabled or disabled.</param>
        public static void PushFlashlightMode(boolean enable) {
        }
        
        // <realm>Client</realm>
        // <summary>Pushes the current render target and viewport to the RT stack then sets a new current render target and viewport. If the viewport is not specified, the dimensions of the render target are used instead.</summary>
        // <param name="texture">The new render target to be used.</param>
        // <param name="x">X origin of the viewport.</param>
        // <param name="y">Y origin of the viewport.</param>
        // <param name="w">Width of the viewport.</param>
        // <param name="h">Height of the viewport.</param>
        public static void PushRenderTarget(ITexture texture, float x, float y, float w, float h) {
        }
        
        // <realm>Client</realm>
        // <summary>Reads the color of the specified pixel.</summary>
        // <param name="x">The x coordinate.</param>
        // <param name="y">The y coordinate.</param>
        public static void ReadPixel(float x, float y) {
        }
        
        // <realm>Client</realm>
        // <summary>This applies the changes made to map lighting using {{LibraryFunction|engine|LightStyle}}.</summary>
        public static void RedownloadAllLightmaps() {
        }
        
        // <realm>Client</realm>
        // <summary>Renders the HUD on the screen.</summary>
        // <param name="x">X position for the HUD draw origin.</param>
        // <param name="y">Y position for the HUD draw origin.</param>
        // <param name="w">Width of the HUD draw.</param>
        // <param name="h">Height of the HUD draw.</param>
        public static void RenderHUD(float x, float y, float w, float h) {
        }
        
        // <realm>Client</realm>
        // <summary>Renders the scene with the specified viewData to the current active render target.</summary>
        // <param name="view">The view data to be used in the rendering. See {{Struct|ViewData}}.</param>
        public static void RenderView(table view) {
        }
        
        // <realm>Client</realm>
        // <summary>Resets the model lighting to the specified color.</summary>
        // <param name="r">The red part of the color, 0-1.</param>
        // <param name="g">The green part of the color, 0-1.</param>
        // <param name="b">The blue part of the color, 0-1.</param>
        public static void ResetModelLighting(float r, float g, float b) {
        }
        
        // <realm>Client</realm>
        // <summary>Resets the HDR tone multiplier to the specified value.</summary>
        // <param name="scale">The value which should be used as multiplier.</param>
        public static void ResetToneMappingScale(float scale) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the ambient lighting for any upcoming render operation.</summary>
        // <param name="r">The red part of the color, 0-1.</param>
        // <param name="g">The green part of the color, 0-1.</param>
        // <param name="b">The blue part of the color, 0-1.</param>
        public static void SetAmbientLight(float r, float g, float b) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the alpha blending for every upcoming render operation.</summary>
        // <param name="blending">Blending value from 0-1.</param>
        public static void SetBlend(float blending) {
        }
        
        // <realm>Client</realm>
        public static void SetColorMaterial() {
        }
        
        // <realm>Client</realm>
        public static void SetColorMaterialIgnoreZ() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the color modulation.</summary>
        // <param name="r">The red channel multiplier normal ranging from 0-1.</param>
        // <param name="g">The green channel multiplier normal ranging from 0-1.</param>
        // <param name="b">The blue channel multiplier normal ranging from 0-1.</param>
        public static void SetColorModulation(float r, float g, float b) {
        }
        
        // <realm>Client</realm>
        // <summary>If the fog mode is set to MATERIAL_FOG_LINEAR_BELOW_FOG_Z, the fog will only be rendered below the specified distance.</summary>
        // <param name="fogZ">The fogZ.</param>
        public static void SetFogZ(float fogZ) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the goal HDR tone mapping scale.</summary>
        // <param name="scale">The target scale.</param>
        public static void SetGoalToneMappingScale(float scale) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets lighting mode when rendering something.</summary>
        // <param name="Mode">Lighting render mode.</param>
        public static void SetLightingMode(float Mode) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the lighting origin.</summary>
        // <param name="lightingOrigin">The position from which the light should be "emitted".</param>
        public static void SetLightingOrigin(Vector lightingOrigin) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the texture to be used as the lightmap in upcoming rendering operations. This is required when rendering meshes using a material with a lightmapped shader such as LightmappedGeneric.</summary>
        // <param name="tex">The texture to be used as the lightmap.</param>
        public static void SetLightmapTexture(ITexture tex) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the material to be used in any upcoming render operation.</summary>
        // <param name="texture">The material to be used.</param>
        public static void SetMaterial(IMaterial texture) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets up the directional lighting for any upcoming render operation.</summary>
        // <param name="lightDirection">The direction of the lighting, see {{Enum|BOX}}.</param>
        // <param name="red">The red color channel ranging from 0-1.</param>
        // <param name="green">The green color channel ranging from 0-1.</param>
        // <param name="blue">The blue color channel ranging from 0-1.</param>
        public static void SetModelLighting(float lightDirection, float red, float green, float blue) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the render target to the specified rt.</summary>
        // <param name="texture">The new render target to be used.</param>
        public static void SetRenderTarget(ITexture texture) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the render target with the specified index to the specified rt.</summary>
        // <param name="rtIndex">The index of the rt to set.</param>
        // <param name="texture">The new render target to be used.</param>
        public static void SetRenderTargetEx(float rtIndex, ITexture texture) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets a scissoring rect which limits the drawing area.</summary>
        // <param name="startX">X start coordinate of the scissor rect.</param>
        // <param name="startY">Y start coordinate of the scissor rect.</param>
        // <param name="endX">X end coordinate of the scissor rect.</param>
        // <param name="endY">Y end coordinate of the scissor rect.</param>
        // <param name="enable">Enable or disable the scissor rect.</param>
        public static void SetScissorRect(float startX, float startY, float endX, float endY, boolean enable) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the shadow color.</summary>
        // <param name="red">The red channel of the shadow color.</param>
        // <param name="green">The green channel of the shadow color.</param>
        // <param name="blue">The blue channel of the shadow color.</param>
        public static void SetShadowColor(float red, float green, float blue) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the shadow projection direction.</summary>
        // <param name="shadowDirections">The new shadow direction.</param>
        public static void SetShadowDirection(Vector shadowDirections) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the maximum shadow projection range.</summary>
        // <param name="shadowDistance">The new maximum shadow distance.</param>
        public static void SetShadowDistance(float shadowDistance) {
        }
        
        // <realm>Client</realm>
        public static void SetShadowsDisabled() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the compare function of the stencil.</summary>
        // <param name="compareFunction">Compare function, see {{Enum|STENCIL}}.</param>
        public static void SetStencilCompareFunction(float compareFunction) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the state of the stencil buffer.</summary>
        // <param name="newState">The new state.</param>
        public static void SetStencilEnable(boolean newState) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets what the stencil should do if the compare function was not successful.</summary>
        // <param name="failOperation">Fail operation function, see {{Enum|STENCIL}}.</param>
        public static void SetStencilFailOperation(float failOperation) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets what the stencil should do if the compare function was successful.</summary>
        // <param name="passOperation">Pass operation function, see {{Enum|STENCIL}}.</param>
        public static void SetStencilPassOperation(float passOperation) {
        }
        
        // <realm>Client</realm>
        // <summary>Sets the reference value which will be used for all stencil operations.</summary>
        // <param name="referenceValue">Reference value.</param>
        public static void SetStencilReferenceValue(float referenceValue) {
        }
        
        // <realm>Client</realm>
        public static void SetStencilTestMask() {
        }
        
        // <realm>Client</realm>
        public static void SetStencilWriteMask() {
        }
        
        // <realm>Client</realm>
        // <summary>Sets what the stencil should do if the compare function was not successful due to the zBuffer.</summary>
        // <param name="zFailOperation">Z fail operation function, see {{Enum|STENCIL}}.</param>
        public static void SetStencilZFailOperation(float zFailOperation) {
        }
        
        // <realm>Client</realm>
        public static void SetToneMappingScaleLinear() {
        }
        
        // <realm>Client</realm>
        // <summary>Changes the view port position and size.</summary>
        // <param name="x">X origin of the view port.</param>
        // <param name="y">Y origin of the view port.</param>
        // <param name="w">Width of the view port.</param>
        // <param name="h">Height of the view port.</param>
        public static void SetViewPort(float x, float y, float w, float h) {
        }
        
        // <realm>Client</realm>
        public static void SetWriteDepthToDestAlpha() {
        }
        
        // <realm>Client</realm>
        // <summary>Swaps the frame buffers/cycles the frame.</summary>
        public static void Spin() {
        }
        
        // <realm>Client</realm>
        // <summary>Start a new beam draw operation.</summary>
        // <param name="segmentCount">Amount of beam segments that are about to be drawn.</param>
        public static void StartBeam(float segmentCount) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the game supports HDR eg. if the directX level is higher or equal 8.</summary>
        public static void SupportsHDR() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns if the current settings and the system allow the usage of pixel shaders 1.4.</summary>
        public static void SupportsPixelShaders_1_4() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns if the current settings and the system allow the usage of pixel shaders 2.0.</summary>
        public static void SupportsPixelShaders_2_0() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns if the current settings and the system allow the usage of vertex shaders 2.0.</summary>
        public static void SupportsVertexShaders_2_0() {
        }
        
        // <realm>Client</realm>
        // <summary>Suppresses or enables any engine lighting for any upcoming render operation.</summary>
        // <param name="suppressLighting">True to suppress false to enable.</param>
        public static void SuppressEngineLighting(boolean suppressLighting) {
        }
        
        // <realm>Client</realm>
        // <summary>Enables HDR tone mapping which influences the brightness.</summary>
        public static void TurnOnToneMapping() {
        }
        
        // <realm>Client</realm>
        public static void UpdateFullScreenDepthTexture() {
        }
        
        // <realm>Client</realm>
        // <summary>Updates the power of two texture.</summary>
        public static void UpdatePowerOfTwoTexture() {
        }
        
        // <realm>Client</realm>
        public static void UpdateRefractTexture() {
        }
        
        // <realm>Client</realm>
        public static void UpdateScreenEffectTexture() {
        }
    }
}