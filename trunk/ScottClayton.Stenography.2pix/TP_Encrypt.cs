using System;
using System.Collections.Generic;
using System.Text;

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

namespace ScottClayton.Stenography.Twopix
{
    class TP_Encrypt
    {
        // Rinjdael Encryption Settings
        static private string saltValue = "m$f#?s?$hu?tastaph3kesEtRUsw@steseTra!+c9EWru?achA#2@5ECHuGeswE@";
        static private string hashAlgorithm = "SHA1";
        static private int passwordIterations = 7;
        static private string initVector = "vafRe$!at!8makac"; // Must be 16 bytes
        static private int keySize = 256;

        /// <summary>
        /// Encrypt a byte array using the Rinjdael (AES) encryption algorithm.
        /// </summary>
        /// <param name="data">The data to encrypt.</param>
        /// <param name="key">The key to use.</param>\
        static public byte[] Encrypt(byte[] data, string key)
        {
            try
            {
                return RijndaelSimple.Encrypt(data,
                                               key,
                                               saltValue,
                                               hashAlgorithm,
                                               passwordIterations,
                                               initVector,
                                               keySize);
            }
            catch (Exception e)
            {
                throw new Exception("Rinjdael \"Encrypt()\": " + e.Message);
            }
        }

        /// <summary>
        /// Decrypt a byte array that was encrypted using the Rinjdael encryption algorithm.
        /// </summary>
        /// <param name="data">The encrypted data.</param>
        /// <param name="key">The key to decrypt with.</param>
        static public byte[] Decrypt(byte[] data, string key)
        {
            try
            {
                return RijndaelSimple.Decrypt(data,
                                               key,
                                               saltValue,
                                               hashAlgorithm,
                                               passwordIterations,
                                               initVector,
                                               keySize);
            }
            catch (Exception e)
            {
                throw new Exception("Rinjdael \"Decrypt()\": " + e.Message);
            }
        }
    }
}
