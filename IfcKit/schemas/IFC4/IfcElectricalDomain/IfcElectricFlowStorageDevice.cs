// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcSharedBldgServiceElements;

namespace BuildingSmart.IFC.IfcElectricalDomain
{
	[Guid("f2443c0e-5c57-46d2-83fe-668bd3d3367a")]
	public partial class IfcElectricFlowStorageDevice : IfcFlowStorageDevice
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcElectricFlowStorageDeviceTypeEnum? _PredefinedType;
	
	
		public IfcElectricFlowStorageDeviceTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
	
	}
	
}
