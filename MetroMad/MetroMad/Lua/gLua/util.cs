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
    
    
    public class util {
        
        // <realm>Server</realm>
        // <summary>Precaches the string for networking. Whenever you want to create a net message, you must add the name of that message as a networked string via this function.</summary>
        // <param name="str">Adds the specified string to the string table.</param>
        public static void AddNetworkString(string str) {
        }
        
        // <realm>Shared</realm>
        // <summary>Function used to calculate aim vector from 2D screen position. It is used in SuperDOF calculate Distance.</summary>
        // <param name="ViewAngles">View angles.</param>
        // <param name="ViewFOV">View Field of View.</param>
        // <param name="x">Mouse X position.</param>
        // <param name="y">Mouse Y position.</param>
        // <param name="scrWidth">Screen width.</param>
        // <param name="scrHeight">Screen height.</param>
        public static void AimVector(Angle ViewAngles, float ViewFOV, float x, float y, float scrWidth, float scrHeight) {
        }
        
        // <realm>Shared</realm>
        // <summary>Encodes the specified string to base64.</summary>
        // <param name="str">String to encode.</param>
        public static void Base64Encode(string str) {
        }
        
        // <realm>Server</realm>
        // <summary>Applies explosion damage to all entities in the specified radius.</summary>
        // <param name="inflictor">The entity that caused the damage.</param>
        // <param name="attacker">The entity that attacked.</param>
        // <param name="damageOrigin">The center of the explosion.</param>
        // <param name="damageRadius">The radius in which entities will be damaged.</param>
        // <param name="damage">The amount of damage to be applied.</param>
        public static void BlastDamage(Entity inflictor, Entity attacker, Vector damageOrigin, float damageRadius, float damage) {
        }
        
        // <realm>Server</realm>
        // <summary>Applies spherical damage based on damage info to all entities in the specified radius.</summary>
        // <param name="dmg">The information about the damage.</param>
        // <param name="damageOrigin">Center of the spherical damage.</param>
        // <param name="damageRadius">The radius in which entities will be damaged.</param>
        public static void BlastDamageInfo(CTakeDamageInfo dmg, Vector damageOrigin, float damageRadius) {
        }
        
        // <realm>Shared</realm>
        // <summary>Compresses the given string using [http://fastlz.org/ FastLZ].</summary>
        // <param name="str">String to compress.</param>
        public static void Compress(string str) {
        }
        
        // <realm>Shared</realm>
        // <summary>Generates the hash of the specified string, up to the first null character ('\0').</summary>
        // <param name="stringToHash">The string to hash.</param>
        public static void CRC(string stringToHash) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the current date formatted like '2012-10-31 18-00-00'</summary>
        public static void DateStamp() {
        }
        
        // <realm>Shared</realm>
        // <summary>Performs a trace and paints a decal to the surface hit.</summary>
        // <param name="decalName">The name of the decal to paint.</param>
        // <param name="traceStart">The start of the trace.</param>
        // <param name="traceEnd">The end of the trace.</param>
        public static void Decal(string decalName, Vector traceStart, Vector traceEnd) {
        }
        
        // <realm>Client</realm>
        // <summary>Performs a trace and paints a decal to the surface hit.</summary>
        // <param name="material">The name of the decal to paint.</param>
        // <param name="ent">The start of the trace.</param>
        // <param name="position">The position of the decal.</param>
        // <param name="normal">The normal of the decal.</param>
        // <param name="color">The color of the decal. Uses the {{Struct|Color}}.</param>
        // <param name="w">The width of the decal.</param>
        // <param name="h">The height of the decal.</param>
        public static void DecalEx(IMaterial material, Entity ent, Vector position, Vector normal, table color, float w, float h) {
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the full material path by the decal name.</summary>
        // <param name="decalName">Name of the decal.</param>
        public static void DecalMaterial(string decalName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Decompresses the given string using [http://fastlz.org/ FastLZ].</summary>
        // <param name="compressedString">String to decompress.</param>
        public static void Decompress(string compressedString) {
        }
        
        // <realm>Shared</realm>
        // <summary>Gets the distance between a line and a point in 3d space.</summary>
        // <param name="lineStart">Start of the line.</param>
        // <param name="lineEnd">End of the line.</param>
        // <param name="pointPos">The position of the point.</param>
        public static void DistanceToLine(Vector lineStart, Vector lineEnd, Vector pointPos) {
        }
        
        // <realm>Shared</realm>
        // <summary>Creates a effect with the specified data. You can find a list of default effects [http://maurits.tv/data/garrysmod/wiki/wiki.garrysmod.com/indexe14a.html here].</summary>
        // <param name="effectName">The name of the effect to create.</param>
        // <param name="effectData">The effect data describing the effect.</param>
        // <param name="allowOverride">Allow override.</param>
        // <param name="ignorePredictionOrRecipientFilter">Ignore predicition or recipient filter.</param>
        public static void Effect(string effectName, CEffectData effectData, bool allowOverride, float ignorePredictionOrRecipientFilter) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a table containing the info about the model. It seems to be not working serverside, but still exists serverside.</summary>
        // <param name="mdl">Model path.</param>
        public static void GetModelInfo(string mdl) {
        }
        
        // <realm>Shared</realm>
        // <summary>Gets PData of offline player using his SteamID</summary>
        // <param name="steamID">SteamID of the player.</param>
        // <param name="name">Variable name to get value of.</param>
        // <param name="default">The default value in case there's nothing stored.</param>
        public static void GetPData(string steamID, string name, string @default) {
        }
        
        // <realm>Client</realm>
        // <summary>Creates a new PixVis handle.</summary>
        public static void GetPixelVisibleHandle() {
        }
        
        // <realm>Shared</realm>
        // <summary>Utility function to quickly generate a trace table that starts at the players view position, and ends 16384 units along a specified direction</summary>
        // <param name="ply">The player the trace should be based on.</param>
        // <param name="dir">The direction of the trace.</param>
        public static void GetPlayerTrace(Player ply, Vector dir) {
        }
        
        // <realm>Client</realm>
        // <summary>Gets information about the sun position and obstruction or nil if there is no sun.</summary>
        public static void GetSunInfo() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the matching surface index for the surface name.</summary>
        // <param name="surfaceName">The name of the surface.</param>
        public static void GetSurfaceIndex(string surfaceName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a name of surfaceproperties ID.</summary>
        // <param name="id">Surface properties ID. You can get it from {{Struct|TraceResult}}.</param>
        public static void GetSurfacePropName(float id) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns a table of all SteamIDs that have a usergroup.</summary>
        public static void GetUserGroups() {
        }
        
        // <realm>Shared</realm>
        // <summary>Performs a ray box intersection and returns position, normal and the fraction.</summary>
        // <param name="rayStart">Any position on the ray.</param>
        // <param name="rayDirection">The direction of the ray. Note that this is not a true ray: the trace is only as long as the length.</param>
        // <param name="boxOrigin">The center of the box.</param>
        // <param name="boxAngles">The angles of the box.</param>
        // <param name="boxMins">The min position of the box.</param>
        // <param name="boxMaxs">The max position of the box.</param>
        public static void IntersectRayWithOBB(Vector rayStart, Vector rayDirection, Vector boxOrigin, Angle boxAngles, Vector boxMins, Vector boxMaxs) {
        }
        
        // <realm>Shared</realm>
        // <summary>Performs a ray plane intersection and returns the hit position or nil.</summary>
        // <param name="rayOrigin">Any position of the ray.</param>
        // <param name="rayDirection">The direction of the ray.</param>
        // <param name="planePosition">Any position on the plane.</param>
        // <param name="planeNormal">The normal vector of the plane.</param>
        public static void IntersectRayWithPlane(Vector rayOrigin, Vector rayDirection, Vector planePosition, Vector planeNormal) {
        }
        
        // <realm>Server</realm>
        // <summary>Checks if a certain position in within the world bounds.</summary>
        // <param name="position">Position to check.</param>
        public static void IsInWorld(Vector position) {
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the model is loaded in the game.</summary>
        // <param name="modelName">Name/Path of the model to check.</param>
        public static void IsModelLoaded(string modelName) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns whenever the skybox is visibile from the point specified.</summary>
        // <param name="position">The position to check the skybox visibility from.</param>
        public static void IsSkyboxVisibleFromPoint(Vector position) {
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the specified model is valid.</summary>
        // <param name="modelName">Name/Path of the model to check.</param>
        public static void IsValidModel(string modelName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if given numbered physics object of given entity is valid or not. Most useful for ragdolls.</summary>
        // <param name="ent">The entity.</param>
        // <param name="physobj">Number of the physics object to test.</param>
        public static void IsValidPhysicsObject(Entity ent, float physobj) {
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the specified prop is valid.</summary>
        // <param name="modelName">Name/Path of the model to check.</param>
        public static void IsValidProp(string modelName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Checks if the specified model name points to a valid ragdoll.</summary>
        // <param name="ragdollName">Name/Path of the ragdoll model to check.</param>
        public static void IsValidRagdoll(string ragdollName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts a JSON string to a Lua table.</summary>
        // <param name="JSONstring">The JSON string to convert.</param>
        public static void JSONToTable(string JSONstring) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts a KeyValue string to a Lua table.</summary>
        // <param name="KeyValuestring">The KeyValue string to convert.</param>
        // <param name="preserveKeyCase">Whether we should preserve key case or not.</param>
        public static void KeyValuesToTable(string KeyValuestring, bool preserveKeyCase) {
        }
        
        // <realm>Shared</realm>
        // <summary>Similar to {{LibraryFunction|util|KeyValuesToTable}} but it also preserves order of keys.</summary>
        // <param name="keyvals">The key value string.</param>
        // <param name="preserveKeyCase">Whether we should preserve key case or not.</param>
        public static void KeyValuesToTablePreserveOrder(string keyvals, bool preserveKeyCase) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a vector in world coordinates based on an entity and local coordinates</summary>
        // <param name="ent">The entity lpos is local to.</param>
        // <param name="lpos">Coordinates local to the ent.</param>
        // <param name="bonenum">The bonenumber of the ent lpos is local to.</param>
        public static void LocalToWorld(Entity ent, Vector lpos, float bonenum) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the string associated with the given id.</summary>
        // <param name="stringTableID">ID to get the associated string of.</param>
        public static void NetworkIDToString(float stringTableID) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the string associated with the given id.</summary>
        // <param name="networkString">String to get the associated ID from.</param>
        public static void NetworkStringToID(string networkString) {
        }
        
        // <realm>Shared</realm>
        // <summary>Formats a float by stripping off extra 0's and .'s</summary>
        // <param name="float">The float to format.</param>
        public static void NiceFloat(float @float) {
        }
        
        // <realm>Shared</realm>
        // <summary>Creates a tracer effect with the given parameters.</summary>
        // <param name="name">The name of the tracer effect.</param>
        // <param name="startPos">The start position of the tracer.</param>
        // <param name="endPos">The end position of the tracer.</param>
        // <param name="doWhiz">Play the hit miss(whiz) sound.</param>
        public static void ParticleTracer(string name, Vector startPos, Vector endPos, bool doWhiz) {
        }
        
        // <realm>Shared</realm>
        // <summary>Creates a tracer effect with the given parameters.</summary>
        // <param name="name">The name of the tracer effect.</param>
        // <param name="startPos">The start position of the tracer.</param>
        // <param name="endPos">The end position of the tracer.</param>
        // <param name="entityIndex">Entity index of the emitting entity.</param>
        // <param name="doWhiz">Play the hit miss(whiz) sound.</param>
        // <param name="attachmentIndex">Attachment index to be used as origin.</param>
        public static void ParticleTracerEx(string name, Vector startPos, Vector endPos, float entityIndex, bool doWhiz, float attachmentIndex) {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the visibility of the PixVis with the specified parameters, visibility ranges from 0-1.</summary>
        // <param name="position">The PixVis position.</param>
        // <param name="radius">The radius of the PixVis.</param>
        // <param name="PixVis">The PixVis handle.</param>
        public static void PixelVisible(Vector position, float radius, pixelvis_handle_t PixVis) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the contents of the position specified.</summary>
        // <param name="position">Position to get the contents sample from.</param>
        public static void PointContents(Vector position) {
        }
        
        // <realm>Shared</realm>
        // <summary>Precaches a model for later use. Model is cached after being loaded once.</summary>
        // <param name="modelName">The model to precache.</param>
        public static void PrecacheModel(string modelName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Precaches a sound for later use. Sound is cached after being loaded once.</summary>
        // <param name="soundName">The sound to precache.</param>
        public static void PrecacheSound(string soundName) {
        }
        
        // <realm>Shared</realm>
        // <summary>Performs a trace with the given origin, direction and filter.</summary>
        // <param name="origin">The origin of the trace.</param>
        // <param name="direction">The direction of the trace.</param>
        // <param name="filter">Entity which should be ignored. Can also be a table of entities.</param>
        public static void QuickTrace(Vector origin, Vector direction, Entity filter) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the absolute system path the file relative to /garrysmod/.</summary>
        // <param name="file">The file to get the absolute path of.</param>
        public static void RelativePathToFull(string file) {
        }
        
        // <realm>Shared</realm>
        // <summary>Removes PData of offline player using his SteamID</summary>
        // <param name="steamID">SteamID of the player.</param>
        // <param name="name">Variable name to remove.</param>
        public static void RemovePData(string steamID, string name) {
        }
        
        // <realm>Shared</realm>
        // <summary>Makes the screen shake</summary>
        // <param name="pos">The origin of the effect.</param>
        // <param name="amplitude">The strength of the effect.</param>
        // <param name="frequency">The frequency of the effect in hz.</param>
        // <param name="duration">The duration of the effect in seconds.</param>
        // <param name="radius">The size of the effect in Garries.</param>
        public static void ScreenShake(Vector pos, float amplitude, float frequency, float duration, float radius) {
        }
        
        // <realm>Shared</realm>
        // <summary>Sets PData for offline player using his SteamID</summary>
        // <param name="steamID">SteamID of the player.</param>
        // <param name="name">Variable name to store the value in.</param>
        // <param name="value">The value to store.</param>
        public static void SetPData(string steamID, string name, any value) {
        }
        
        // <realm>Shared</realm>
        // <summary>Generates a random float value that should be the same on client and server.</summary>
        // <param name="uniqueName">The seed for the random value.</param>
        // <param name="min">The minimum value of the random range.</param>
        // <param name="max">The maximum value of the random range.</param>
        // <param name="additionalSeed">The additional seed.</param>
        public static void SharedRandom(string uniqueName, float min, float max, float additionalSeed) {
        }
        
        // <realm>Server</realm>
        // <summary>Adds a trail to the specified entity.</summary>
        // <param name="ent">Entity to attach trail to.</param>
        // <param name="attachmentID">Attachment ID of the entitiys model to attach trail to. If you are not sure, set this to 0.</param>
        // <param name="color">Color of the trail, use {{GlobalFunction|Color}}.</param>
        // <param name="additive">Should the trail be additive or not.</param>
        // <param name="startWidth">Start width of the trail.</param>
        // <param name="endWidth">End width of the trail.</param>
        // <param name="lifetime">How long it takes to transition from startWidth to endWidth.</param>
        // <param name="textureRes">The resolution of trails texture. A good value can be calculated using this formula: 1 / ( startWidth + endWidth ) * 0.5.</param>
        // <param name="texture">Path to the texture to use as a trail. Note that you should also include the ".vmt" or the game WILL crash!.</param>
        public static void SpriteTrail(Entity ent, float attachmentID, table color, bool additive, float startWidth, float endWidth, float lifetime, float textureRes, string texture) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns a new {{Type|Stack}} object</summary>
        public static void Stack() {
        }
        
        // <realm>Shared</realm>
        // <summary>Given a 64bit SteamID will return a STEAM_0: style Steam ID</summary>
        // <param name="id">The 64 bit Steam ID.</param>
        public static void SteamIDFrom64(string id) {
        }
        
        // <realm>Shared</realm>
        // <summary>Given a STEAM_0 style Steam ID will return a 64bit Steam ID</summary>
        // <param name="id">The STEAM_0 style id.</param>
        public static void SteamIDTo64(string id) {
        }
        
        // <realm>Shared</realm>
        // <summary>Convert a string to a certain type</summary>
        // <param name="str">The string to convert.</param>
        // <param name="typename">The type to attempt to convert the string to ('vector','angle','float','bool','string'), case insensitive.</param>
        public static void StringToType(string str, string typename) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts a table to a JSON string.</summary>
        // <param name="table">Table to convert.</param>
        public static void TableToJSON(table table) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts the given table into a key value string.</summary>
        // <param name="table">The table to convert.</param>
        public static void TableToKeyValues(table table) {
        }
        
        // <realm>Shared</realm>
        // <summary>Creates a timer object.</summary>
        public static void Timer() {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the time since this function has been last called</summary>
        public static void TimerCycle() {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Deprecated|You should use {{GlobalFunction|tobool}} instead.}}</summary>
        // <param name="input">A string or a number to convert.</param>
        public static void tobool(any input) {
        }
        
        // <realm>Shared</realm>
        // <summary>Runs a trace using the ent's collisionmodel between two points.</summary>
        // <param name="tracedata">Trace data. See {{Struct|Trace}}.</param>
        // <param name="ent">The entity to use.</param>
        public static void TraceEntity(table tracedata, Entity ent) {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Deprecated|This function is broken and returns the same values all the time}}</summary>
        // <param name="ent1">The first entity to trace from.</param>
        // <param name="ent2">The second entity to trace to.</param>
        public static void TraceEntityHull(Entity ent1, Entity ent2) {
        }
        
        // <realm>Shared</realm>
        // <summary>Performs a hull trace with the given trace data. This function is shared but will not give the desired results on the client; you should only use this serverside as the function utilizes certain physics mechanisms that do not exist on the client.</summary>
        // <param name="TraceData">The trace data to use. See {{Struct|HullTrace}}.</param>
        public static void TraceHull(table TraceData) {
        }
        
        // <realm>Shared</realm>
        // <summary>Performs a trace with the given trace data.</summary>
        // <param name="TraceData">The trace data to use. See {{Struct|Trace}}.</param>
        public static void TraceLine(table TraceData) {
        }
        
        // <realm>Shared</realm>
        // <summary>Converts a type to a (nice, but still parsable) string</summary>
        // <param name="input">What to convert.</param>
        public static void TypeToString(any input) {
        }
    }
}
