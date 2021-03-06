## Convert SDE connections from app server to direct connections

  <div style="MARGIN-TOP: 0in; PADDING-LEFT: 0in; PADDING-RIGHT: 0in; MARGIN-BOTTOM: 0pt" xmlns="http://www.w3.org/1999/xhtml" xmlns:my="http://schemas.microsoft.com/office/infopath/2003/myXSD/2006-02-10T23:25:53">
    <span>C# code that will convert sde connections from app server to direct connections.</span>
  </div>  


<!-- TODO: Fill this section below with metadata about this sample-->
```
Language:              C#
Subject:               Geodatabase
Organization:          Esri, http://www.esri.com
Date:                  07/17/2020
ArcObjects SDK:        10.8
Visual Studio:         2017, 2019
.NET Target Framework: 4.5
```

### Resources

* [ArcObjects .NET API Reference online](http://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm)  
* [Sample Data Download](../../releases)  
* [What's new](http://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#91cabc68-2271-400a-8ff9-c7fb25108546.htm)  
* [Download the ArcObjects SDK for .Net from MyEsri.com](https://my.esri.com/)  

### Usage
#### Building the application  
1. It needs to be built on a machine that has ArcGIS Desktop and the ArcObjects SDK installed.  

#### Usage - run the app using 3 parameters:  
1. The first is a folder path that has the mxd’s you’d like to convert (by default it is the current directory).  
1. The second parameter is optional and holds the characters you’d like to add after an underscore to the new mxd after conversion is complete (by default, if nothing is passed in it uses “DC”– for example an mxd named “mymap.mxd” will get saved as a new converted mxd named “mymap_DC.mxd”).
				  
1. The last parameter is also optional and is a boolean for verbose output (by default is “false”).  
1. **For example:** MXDconnection_converter.exe --help<br>
					Usage: MXDconnection_converter.exe [{Current Directory | '<PathToMxdDirectory>'}] [{DC | '<newMxdStringToAdd>'}] [VERBOSE] [{? | --help}]
				  









---------------------------------

#### Licensing  
| Development licensing | Deployment licensing | 
| ------------- | ------------- | 
| ArcGIS Desktop Standard | ArcGIS Desktop Standard |  
| ArcGIS Desktop Advanced | ArcGIS Desktop Advanced |  
| Engine Developer Kit | Engine: Geodatabase Update |  


