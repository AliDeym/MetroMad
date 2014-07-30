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
    
    
    public class construct {
        
        // <realm>Server</realm>
        // <summary>Creates a magnet.</summary>
        // <param name="ply">Player that will have the numpad control over the magnet.</param>
        // <param name="pos">The position of the magnet.</param>
        // <param name="ang">The angles of the magnet.</param>
        // <param name="model">The model of the maget.</param>
        // <param name="material">Material of the magnet ( texture ).</param>
        // <param name="key">The key to toggle the magnet, see {{Enum|KEY}}.</param>
        // <param name="maxObjects">Maximum amount of objects the magnet can hold.</param>
        // <param name="strength">Strength of the magnet.</param>
        // <param name="nopull">If > 0, disallows the magnet to pull objects towards it.</param>
        // <param name="allowrot">If > 0, allows rotation of the objects attached.</param>
        // <param name="startOn">If > 0, enabled from spawn.</param>
        // <param name="toggle">If !.</param>
        // <param name="vel">Velocity to set on spawn.</param>
        // <param name="aVel">Angular velocity to set on spawn.</param>
        // <param name="frozen">Freeze the magnet on start.</param>
        public static void Magnet(Player ply, Vector pos, Angle ang, string model, string material, float key, float maxObjects, float strength, float nopull, float allowrot, float startOn, float toggle, Vector vel, Angle aVel, boolean frozen) {
        }
        
        // <realm>Server</realm>
        // <summary>Sets props physical properties.</summary>
        // <param name="ply">The player. This variable is not used and can be left out.</param>
        // <param name="ent">The entity to apply properties to.</param>
        // <param name="physObjID">You can use this or the argument below. This will be used in case you don't provide argument below.</param>
        // <param name="physObj">The physics object to apply the properties to.</param>
        // <param name="data">The table containing properties to apply. See {{Struct|PhysProperties}}.</param>
        public static void SetPhysProp(Player ply, Entity ent, float physObjID, PhysObj physObj, table data) {
        }
    }
}