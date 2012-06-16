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

namespace ScottClayton.Stenography._pix
{
    /// <summary>
    /// This error is thrown when the file you are trying to put into an image is too big for that image.
    /// </summary>
    class OutOfSpaceExcecption : Exception
    {
        public OutOfSpaceExcecption()
            : base()
        {
        }

        public OutOfSpaceExcecption(string message)
            : base(message)
        {
        }

        public OutOfSpaceExcecption(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
