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
    
    
    public class File {
        
        // <realm>Shared</realm>
        // <summary>Dumps the file changes to disk and closes the file handle which makes the handle useless.</summary>
        public virtual void Close() {
        }
        
        // <realm>Shared</realm>
        // <summary>Dumps the file changes to disk and saves the file.</summary>
        public virtual void Flush() {
        }
        
        // <realm>Shared</realm>
        // <summary>Reads the specified amount of chars and returns them as a binary string.</summary>
        // <param name="length">Reads the specified amount of chars.</param>
        // <return>string|data</return>
        public virtual string Read(float length) {
            return "String";
        }
        
        // <realm>Shared</realm>
        // <summary>Reads one byte of the file and returns whenever that byte was not null.</summary>
        // <return>boolean|val</return>
        public virtual bool ReadBool() {
            return true;
        }
        
        // <realm>Shared</realm>
        // <summary>Reads one byte of the file and returns the decimal ASCII value.</summary>
        // <return>number|asciiVal</return>
        public virtual int ReadByte() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Reads 8 bytes from the file converts them to a double and returns them.</summary>
        // <return>number|value</return>
        public virtual int ReadDouble() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Reads 4 bytes from the file converts them to a float and returns them.</summary>
        // <return>number|value</return>
        public virtual int ReadFloat() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Reads 4 bytes from the file converts them to a long and returns them.</summary>
        // <return>number|value</return>
        public virtual int ReadLong() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Reads 2 bytes from the file converts them to a short and returns them.</summary>
        // <return>number|value</return>
        public virtual int ReadShort() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Sets the file pointer to the specified position.</summary>
        // <param name="pos">Pointer position.</param>
        public virtual void Seek(float pos) {
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the size of the file in bytes.</summary>
        // <return>number|size</return>
        public virtual int Size() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Moves the file pointer by the specified amount of chars.</summary>
        // <param name="amount">The amount of chars to skip, can be negative to skip backwards.</param>
        // <return>number|amount</return>
        public virtual int Skip(float amount) {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Returns the current position of the file pointer.</summary>
        // <return>number|pos</return>
        public virtual int Tell() {
            return 1;
        }
        
        // <realm>Shared</realm>
        // <summary>Writes the given string into the file.</summary>
        // <param name="data">Binary data to write to the file.</param>
        public virtual void Write(string data) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes on byte, representing the a Boolean to the file.</summary>
        // <param name="bool">The bool to be written to the file.</param>
        public virtual void WriteBool(boolean @bool) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a byte to the file.</summary>
        // <param name="byte">The byte to be written to the file.</param>
        public virtual void WriteByte(float @byte) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a 8byte floating point double to the file.</summary>
        // <param name="double">The double to be written to the file.</param>
        public virtual void WriteDouble(float @double) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a 4byte float to the file.</summary>
        // <param name="float">The float to be written to the file.</param>
        public virtual void WriteFloat(float @float) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a 4byte integer to the file.</summary>
        // <param name="int">The integer to be written to the file.</param>
        public virtual void WriteLong(float @int) {
        }
        
        // <realm>Shared</realm>
        // <summary>Writes a 2 byte integer to the file.</summary>
        // <param name="short">The short to be written to the file.</param>
        public virtual void WriteShort(float @short) {
        }
    }
}