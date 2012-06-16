//    This file is part of 2Pix.
//
//    2Pix is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    2Pix is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with 2Pix.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Text;

static class Registry
{
    /// <summary>
    /// Creates a registry entry.
    /// </summary>
    /// <param name="root">The Registry Root: eg. HKEY_LOCAL_MACHINE</param>
    /// <param name="keyPath">The path to the key: eg. SOFTWARE\\skotCipher</param>
    /// <param name="keyName">The name of the value: eg. userName</param>
    /// <param name="keyValue">The value to put in the key: eg. spark128000</param>
    static public void SetValue(string root, string keyPath, string keyName, string keyValue)
    {
        Microsoft.Win32.Registry.SetValue(root + "\\" + keyPath, keyName, keyValue);
    }

    /// <summary>
    /// Retrieves a value from the registry.
    /// </summary>
    /// <param name="root">The Registry Root: eg. HKEY_LOCAL_MACHINE</param>
    /// <param name="keyPath">The path to the key: eg. SOFTWARE\\skotCipher</param>
    /// <param name="keyName">The name of the value: eg. userName</param>
    /// <param name="defaultValue">If the key cannot be found, this will be returned.</param>
    static public string GetValue(string root, string keyPath, string keyName, string defaultValue)
    {
        return Microsoft.Win32.Registry.GetValue(root + "\\" + keyPath, keyName, defaultValue).ToString();
    }
}
