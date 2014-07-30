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
    
    
    public class saverestore {
        
        // <realm>Shared</realm>
        // <summary>Adds a restore/load hook for the Half-Life 2 save system.</summary>
        // <param name="identifier">The unique identifier for this hook.</param>
        // <param name="callback">The function to be called when an engine save is being loaded. It has one argument:<br/>.</param>
        public static void AddRestoreHook(string identifier, function callback) {
        }
        
        // <realm>Shared</realm>
        // <summary>Adds a save hook for the Half-Life 2 save system. You can this to carry data through level transitions in Half-Life 2.</summary>
        // <param name="identifier">The unique identifier for this hook.</param>
        // <param name="callback">The function to be called when an engine save is being saved. It has one argument:<br/>.</param>
        public static void AddSaveHook(string identifier, function callback) {
        }
        
        // <realm>Shared</realm>
        // <summary>Loads {{ClassFunction|Entity|GetTable}} from the save game file that is being loaded and merges it with the given entitys {{ClassFunction|Entity|GetTable}}.</summary>
        // <param name="ent">The entity which will receive the loaded values from the save.</param>
        // <param name="save">The restore object to read the {{ClassFunction|Entity|GetTable}} from.</param>
        public static void LoadEntity(Entity ent, IRestore save) {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Internal}}</summary>
        // <param name="save">The restore object to read data from the save file with.</param>
        public static void LoadGlobal(IRestore save) {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Internal}}</summary>
        public static void PreRestore() {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Internal}}</summary>
        public static void PreSave() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads a table from the save game file that is being loaded.</summary>
        // <param name="save">The restore object to read the table from.</param>
        public static void ReadTable(IRestore save) {
        }
        
        // <realm>Shared</realm>
        // <summary>Loads a variable from the save game file that is being loaded.</summary>
        // <param name="save">The restore object to read variables from.</param>
        public static void ReadVar(IRestore save) {
        }
        
        // <realm>Shared</realm>
        // <summary>Saves entitys {{ClassFunction|Entity|GetTable}} to the save game file that is being saved.</summary>
        // <param name="ent">The entity to save {{ClassFunction|Entity|GetTable}} of.</param>
        // <param name="save">The save object to save {{ClassFunction|Entity|GetTable}} to.</param>
        public static void SaveEntity(Entity ent, ISave save) {
        }
        
        // <realm>Shared</realm>
        // <summary>{{Internal}}</summary>
        // <param name="save">The save object to write data into the save file.</param>
        public static void SaveGlobal(ISave save) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns how many writable keys are in the given table.</summary>
        // <param name="table">The table to test.</param>
        public static void WritableKeysInTable(table table) {
        }
        
        // <realm>Shared</realm>
        // <summary>Write a table to a save game file that is being saved.</summary>
        // <param name="table">The table to write.</param>
        // <param name="save">The save object to write the table to.</param>
        public static void WriteTable(table table, ISave save) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a variable to the save game file that is being saved.</summary>
        // <param name="value">The value to save.<br/>It can be one of the following types: {{Type|number}}, {{Type|bool}}, {{Type|string}}, {{Type|Entity}}, {{Type|Angle}}, {{Type|Vector}} or {{Type|table}}.</param>
        // <param name="save">The save object to write the variable to.</param>
        public static void WriteVar(any value, ISave save) {
        }
    }
}
