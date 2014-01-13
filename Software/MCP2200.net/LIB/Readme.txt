-------------------------------------------------------------------
              Readme for the MCP2200 DLL (Managed)
-------------------------------------------------------------------

                  Microchip Technology, Inc.




-------------------------------------------------------------------
System Requirements
-------------------------------------------------------------------
Operating System: 	
	Windows XP SP3, Vista, 7, and 8 (32 and 64 bit)
Other: 	
	.NET2 Framework, Microsoft Visual C++ 2008 Redistributable Package


-------------------------------------------------------------------
Versioning History
-------------------------------------------------------------------
Version 1.2.0 (Released 01/28/2013):
 - Added support for inverting UART polarity through ConfigureMCP2200() function
 - Added dedicated function for inverting UART polarity: fnInvertUartPol()

Version 1.1.2 (Released 08/16/2012):
 - Corrected issue that could cause incorrect number to be returned
   by the GetNoOfDevices() function on some systems
 - Resolved issue that caused baud rate to change when the function 
   ConfigureMCP2200() was used

Version 1.1.1:
 - Resolved bug in DLL memory management

Version 1.1.0:
 - Added EEPROM read/write support
- Added example project/demo

Version 1.0.0:
 - Initial release
  

-------------------------------------------------------------------
Contact Information
-------------------------------------------------------------------
Main Website: 		http://www.microchip.com
Technical Support: 	http://support.microchip.com

