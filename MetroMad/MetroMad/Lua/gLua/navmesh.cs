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
    
    
    public class navmesh {
        
        // <realm>Server</realm>
        // <summary>Add this position and normal to the list of walkable positions, used before map generation with {{LibraryFunction|navmesh|BeginGeneration}}</summary>
        // <param name="pos">The terrain position.</param>
        // <param name="dir">The normal of this terrain position.</param>
        public static void AddWalkableSeed(Vector pos, Vector dir) {
        }
        
        // <realm>Server</realm>
        // <summary>Starts the generation of a new navmesh.</summary>
        public static void BeginGeneration() {
        }
        
        // <realm>Server</realm>
        // <summary>Clears all the walkable positions, used before calling {{LibraryFunction|navmesh|BeginGeneration}}.</summary>
        public static void ClearWalkableSeeds() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns a bunch of areas within distance, used to find hiding spots by {{Type|NextBot}}s for example.</summary>
        // <param name="pos">The position to search around.</param>
        // <param name="radius">Radius to search within.</param>
        // <param name="stepdown">Maximum stepdown( fall distance ) allowed.</param>
        // <param name="stepup">Maximum stepup( jump height ) allowed.</param>
        public static void Find(Vector pos, float radius, float stepdown, float stepup) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the Nav Area contained in this position that also satisfies the elevation limit.</summary>
        // <param name="pos">The position to search for.</param>
        // <param name="beneathLimit">The elevation limit at which the Nav Area will be searched.</param>
        public static void GetNavArea(Vector pos, float beneathLimit) {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the Nav Area by the given ID.</summary>
        public static void GetNavAreaByID() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the count of how many Nav Areas are currently loaded in the map.</summary>
        public static void GetNavAreaCount() {
        }
        
        // <realm>Server</realm>
        // <summary>Returns the classname of the player spawn entity.</summary>
        public static void GetPlayerSpawnName() {
        }
        
        // <realm>Server</realm>
        // <summary>Whether we're currently generating a new navmesh with {{LibraryFunction|navmesh|BeginGeneration}}.</summary>
        public static void IsGenerating() {
        }
        
        // <realm>Server</realm>
        // <summary>Sets the classname of the default spawn point entity, used before generating a new navmesh with {{LibraryFunction|navmesh|BeginGeneration}}.</summary>
        // <param name="spawnPointClass">The classname of what the player uses to spawn, automatically adds it to the walkable positions during map generation.</param>
        public static void SetPlayerSpawnName(string spawnPointClass) {
        }
    }
}