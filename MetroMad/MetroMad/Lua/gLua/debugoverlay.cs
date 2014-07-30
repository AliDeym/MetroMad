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
    
    
    public class debugoverlay {
        
        // <realm>Shared</realm>
        // <summary>Displays an axis indicator at the specified position.</summary>
        // <param name="origin">Position origin.</param>
        // <param name="ang">Angle of the axis.</param>
        // <param name="size">Size of the axis.</param>
        // <param name="lifetime">Number of seconds to appear (Defaults to 1).</param>
        // <param name="ignoreZ">If true, will draw on top of everything; ignoring the Z buffer.</param>
        public static void Axis(Vector origin, Angle ang, float size, float lifetime, boolean ignoreZ) {
        }
        
        // <realm>Shared</realm>
        // <summary>Displays a solid coloured cube at the specified position.</summary>
        // <param name="origin">Position origin.</param>
        // <param name="mins">Minimum bounds of the cube.</param>
        // <param name="maxs">Maximum bounds of the cube.</param>
        // <param name="lifetime">Number of seconds to appear.</param>
        // <param name="color">The color of the box. Uses the {{Struct|Color}}.</param>
        // <param name="ignoreZ">If true, will draw on top of everything; ignoring the Z buffer.</param>
        public static void Box(Vector origin, Vector mins, Vector maxs, float lifetime, table color, boolean ignoreZ) {
        }
        
        // <realm>Shared</realm>
        // <summary>Displays a solid colored rotated cube at the specified position.</summary>
        // <param name="pos">World position.</param>
        // <param name="mins">The mins of the cube ( Lowest corner ).</param>
        // <param name="maxs">The maxs of the cube ( Highest corner ).</param>
        // <param name="lifetime">Amount of seconds to show the box.</param>
        // <param name="color">The color of the box. Uses the {{Struct|Color}}.</param>
        // <param name="ignoreZ">If true, will draw on top of everything; ignoring the Z buffer.</param>
        public static void BoxAngles(Vector pos, Vector mins, Vector maxs, float lifetime, table color, boolean ignoreZ) {
        }
        
        // <realm>Shared</realm>
        // <summary>Creates a coloured cross at the specified position for the specified time.</summary>
        // <param name="position">Position origin.</param>
        // <param name="size">Size of the cross.</param>
        // <param name="lifetime">Number of seconds the cross to appear.</param>
        // <param name="color">The color of the cross. Uses the {{Struct|Color}}.</param>
        // <param name="ignoreZ">If true, will draw on top of everything; ignoring the Z buffer.</param>
        public static void Cross(Vector position, float size, float lifetime, table color, boolean ignoreZ) {
        }
        
        // <realm>Shared</realm>
        // <summary>Displays a coloured line at the specified position.</summary>
        // <param name="pos1">First position of the line.</param>
        // <param name="pos2">Second position of the line.</param>
        // <param name="lifetime">Number of seconds to appear.</param>
        // <param name="color">The color of the line. Uses the {{Struct|Color}}.</param>
        // <param name="ignoreZ">If true, will draw on top of everything; ignoring the Z buffer.</param>
        public static void Line(Vector pos1, Vector pos2, float lifetime, table color, boolean ignoreZ) {
        }
        
        // <realm>Shared</realm>
        // <summary>Displays a coloured sphere at the specified position.</summary>
        // <param name="origin">Position origin.</param>
        // <param name="size">Size of the sphere.</param>
        // <param name="lifetime">Number of seconds to appear.</param>
        // <param name="color">The color of the sphere. Uses the {{Struct|Color}}.</param>
        // <param name="ignoreZ">If true, will draw on top of everything; ignoring the Z buffer.</param>
        public static void Sphere(Vector origin, float size, float lifetime, table color, boolean ignoreZ) {
        }
        
        // <realm>Shared</realm>
        // <summary>Displays text at the specified position.</summary>
        // <param name="origin">Position origin.</param>
        // <param name="text">String message to display.</param>
        // <param name="lifetime">Number of seconds to appear.</param>
        public static void Text(Vector origin, string text, float lifetime) {
        }
    }
}