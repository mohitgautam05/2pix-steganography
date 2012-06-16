using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

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
    public class TP_Image
    {
        private Bitmap picture;

        /// <summary>
        /// The image stored in this object.
        /// </summary>
        public Image Picture
        {
            get { return (Image)picture; }
        }

        /// <summary>
        /// The maximum number of bytes that can be stored in this image.
        /// </summary>
        public int Capacity
        {
            get { return (int)((float)(picture.Width * picture.Height * 3) / 8.0f); }
        }
        
        /// <summary>
        /// Get a copy of this object.
        /// </summary>
        public TP_Image Clone()
        {
            return (TP_Image)this.MemberwiseClone();
        }

        /// <summary>
        /// Create a new TP image.
        /// </summary>
        public TP_Image(Bitmap image)
        {
            picture = image;
        }

        /// <summary>
        /// Create a new TP image.
        /// </summary>
        public TP_Image(Image image)
        {
            picture = (Bitmap)image;
        }

        /// <summary>
        /// Access the pixels in this image sequentially as opposed to a 2x2 array.
        /// </summary>
        /// <param name="index">The number of the pixel to get.</param>
        public Color GetPixel(int index)
        {
            int x = index % picture.Width;
            int y = (int)Math.Floor((double)index / (double)picture.Width);

            return picture.GetPixel(x, y);
        }

        /// <summary>
        /// Set the color of a pixel in this image.
        /// </summary>
        /// <param name="index">The index of the pixel in this image to set.</param>
        /// <param name="c">The color to set the pixel;</param>
        public void SetPixel(int index, Color c)
        {
            int x = index % picture.Width;
            int y = (int)Math.Floor((double)index / (double)picture.Width);

            picture.SetPixel(x, y, c);
        }
    }
}
