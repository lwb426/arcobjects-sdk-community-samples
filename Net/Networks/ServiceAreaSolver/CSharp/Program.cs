/*

   Copyright 2019 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESRI.ArcGIS.esriSystem;

/*
*    '*************************************************************************
*    '       ArcGIS Network Analyst extension - Service Area Solver sample
*    '
*    '   This code shows how to :
*    '    1) Open a workspace and open a Network Dataset
*    '    2) Create a NAContext and its NASolver
*    '    3) Load Facilities from a Feature Class and create Network Locations
*    '    4) Set the Solver parameters
*    '    5) Solve a Service Area problem
*    '    6) Display SAPolygons output
*    '
*    '*************************************************************************
*/

namespace ServiceAreaSolver
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			if (!ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Engine))
			{
				if (!ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.Desktop))
				{
					System.Windows.Forms.MessageBox.Show("This application could not load the correct version of ArcGIS.");
					return;
				}
			}

			LicenseInitializer aoLicenseInitializer = new LicenseInitializer();
			if (!aoLicenseInitializer.InitializeApplication(new esriLicenseProductCode[] { esriLicenseProductCode.esriLicenseProductCodeEngine, esriLicenseProductCode.esriLicenseProductCodeBasic, esriLicenseProductCode.esriLicenseProductCodeStandard, esriLicenseProductCode.esriLicenseProductCodeAdvanced },
			new esriLicenseExtensionCode[] { esriLicenseExtensionCode.esriLicenseExtensionCodeNetwork }))
			{
				System.Windows.Forms.MessageBox.Show("This application could not initialize with the correct ArcGIS license and will shutdown. LicenseMessage: " + aoLicenseInitializer.LicenseMessage());
				aoLicenseInitializer.ShutdownApplication();
				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			frmServiceAreaSolver mainForm = new frmServiceAreaSolver();

			// Check that the form was not already disposed of during initialization before running it.
			if (mainForm != null && !mainForm.IsDisposed)
				Application.Run(mainForm);

			//ESRI License Initializer generated code.
			//Do not make any call to ArcObjects after ShutDownApplication()
			aoLicenseInitializer.ShutdownApplication();
		}
	}
}