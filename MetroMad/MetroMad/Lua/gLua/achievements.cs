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
    
    
    public class achievements {
        
        // <realm>Client</realm>
        // <summary>Tells the client that balloon has popped. This counts towards the Balloon Popper achievement.</summary>
        public static void BalloonPopped() {
        }
        
        // <realm>Client</realm>
        // <summary>Returns the amount of achievements in Garry's Mod.</summary>
        public static void Count() {
        }
        
        // <realm>Client</realm>
        // <summary>Adds one to the count of balls eaten. Once this count reaches 200, the 'Ball Eater' achievement is unlocked.</summary>
        public static void EatBall() {
        }
        
        // <realm>Client</realm>
        // <summary>Retrieves progress of given achievement</summary>
        // <param name="achievementID">The ID of achievement to retrieve progress of. Note: IDs start with 0, not 1.</param>
        public static void GetCount(float achievementID) {
        }
        
        // <realm>Client</realm>
        // <summary>Retrieves description of given achievement</summary>
        // <param name="achievementID">The ID of achievement to retrieve description of. Note: IDs start with 0, not 1.</param>
        public static void GetDesc(float achievementID) {
        }
        
        // <realm>Client</realm>
        // <summary>Retrieves progress goal of given achievement</summary>
        // <param name="achievementID">The ID of achievement to retrieve goal of. Note: IDs start with 0, not 1.</param>
        public static void GetGoal(float achievementID) {
        }
        
        // <realm>Client</realm>
        // <summary>Retrieves name of given achievement</summary>
        // <param name="achievementID">The ID of achievement to retrieve name of. Note: IDs start with 0, not 1.</param>
        public static void GetName(float achievementID) {
        }
        
        // <realm>Client</realm>
        // <summary>Increases "War Zone" achievement progress by 1.</summary>
        public static void IncBaddies() {
        }
        
        // <realm>Client</realm>
        // <summary>Increases "Innocent Bystander" achievement progress by 1.</summary>
        public static void IncBystander() {
        }
        
        // <realm>Client</realm>
        // <summary>Increases "Bad Friend" achievement progress by 1.</summary>
        public static void IncGoodies() {
        }
        
        // <realm>Client</realm>
        // <summary>Used in GMod 12 in the achievements menu to show the user if they have unlocked certain achievements.</summary>
        // <param name="AchievementID">Internal Achievement ID number.</param>
        public static void IsAchieved(float AchievementID) {
        }
        
        // <realm>Client</realm>
        // <summary>Called every time you use the remover tool on something, used by the engine to track achievement progress for 'Destroyer'.</summary>
        public static void Remover() {
        }
        
        // <realm>Client</realm>
        // <summary>Tracks achievement progress for 'Procreator' - used by the engine internally.</summary>
        public static void SpawnedNPC() {
        }
        
        // <realm>Client</realm>
        // <summary>Tells the client that a prop has been spawned by the user, used to track achievement progress for 'Creator' by the engine.</summary>
        public static void SpawnedProp() {
        }
        
        // <realm>Client</realm>
        // <summary>Tells the client that a ragdoll has been spawned. Used internally to track achievement progress for 'Dollhouse'.</summary>
        public static void SpawnedRagdoll() {
        }
        
        // <realm>Client</realm>
        // <summary>An automatically called function that adds one to a count of how many times the spawnmenu has been opened. It's purpose is to help unlock the achievement 'Menu User'.</summary>
        public static void SpawnMenuOpen() {
        }
    }
}