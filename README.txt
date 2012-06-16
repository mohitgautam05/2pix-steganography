2Pix integrates with Windows to allow you to easily encrypt and hide files in bitmap images, a process called steganography (not to be confused with stenography). Data is stored in the low-order bits of each pixel of an image, so the file is completely hidden from view. Version 1.1 now provides plausible deniability because no unencrypted signature is stored in the image header. It should be impossible to prove an image contains a hidden file (if you use a strong password and only use 1 or 2 bits per pixel component).

Revisions:

v1.0  - Initial release

v1.1  - 2/4/2012
      - Added feature to resize image to fit the file being encoded
      - Changed the format of the encoded data
        + Files encoded with v1.0 of 2Pix cannot be decoded with v1.1 - sorry.
        + The new format provides Plausable Deniability because even the header is encrypted.
          This means that unless you provide the correct decryption key you cannot prove that the 
          image contains hidden data at all. No signature is appended to the file in plain text.
      - The password for "sample.bmp" is "2pix"

v1.1b - Transferred project hosting to Google Code