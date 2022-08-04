# DataProcessor

1) Two required parameters: "--filePath" and "--dataType".
2) Support three dataType-s: "binary", "text" and "textReverse".
  2-1) In case of binary the application should output first 5 bytes of data in base64 format.
  2-2) In case of text the application should output first 7 letters of presumably textual data in UTF8 format.
  2-3) In case of textReverse the application should output first 6 letters of presumably textual data in reverse order in UTF8 format.
