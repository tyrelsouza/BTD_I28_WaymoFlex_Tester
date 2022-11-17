# 8082_Waymo_PC_2022-07-24


Copyright Benchtop Devices.


## File Structure


### FlexFlowXML.cs

Creates an XML Envelope for sending to Flextronics.com/FFTester20 (SOAP)

### I28FlexStatus.cs
  
Sets error codes for the class instance with a switch statement based on the I28 Status

### SaveResult.cs

#### SaveResult Class
Main controlling class, stores information about the station, parameters, and test results. 

Writes to file for Dumpy to upload.

#### SaveResultResponse Class

Parses responses from Flexflow to show to the UI


### Form1.cs

UI and Serial interaction.




