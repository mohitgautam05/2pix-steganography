2pix Steganography README
Copyright (c) Scott Clayton 2010-1012

2Pix integrates with Windows to allow you to easily encrypt and hide files in bitmap images, a process called steganography (not to be confused with stenography). Data is encrypted and then stored in the low-order bits of each pixel of an image, so the file is completely hidden from view.

Revisions:

v1.2  - 6/29/2012
      - Added the option to turn on automatic update checking
      - Re-created the GUI so that is doesn't look like garbage anymore

v1.1b - Transferred project hosting to Google Code (no actual code changes)

v1.1  - 2/4/2012
      - Added feature to resize image to fit the file being encoded
      - Changed the format of the encoded data
        + Files encoded with v1.0 of 2Pix cannot be decoded with v1.1 - sorry.
        + The new format provides Plausable Deniability because even the header is encrypted.
          This means that unless you provide the correct decryption key you cannot prove that the 
          image contains hidden data. No signature is appended to the file in plain text.
      - The password for "sample.bmp" is "2pix"

v1.0  - Initial release