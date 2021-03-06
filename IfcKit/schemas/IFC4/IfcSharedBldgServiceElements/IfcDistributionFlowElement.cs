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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;

namespace BuildingSmart.IFC.IfcSharedBldgServiceElements
{
	[Guid("63ee3d6e-fbeb-4c25-a0a5-13c7bceed367")]
	public partial class IfcDistributionFlowElement : IfcDistributionElement
	{
		[InverseProperty("RelatingFlowElement")] 
		ISet<IfcRelFlowControlElements> _HasControlElements = new HashSet<IfcRelFlowControlElements>();
	
	
		[Description("Reference to the relationship object that relates control elements.")]
		public ISet<IfcRelFlowControlElements> HasControlElements { get { return this._HasControlElements; } }
	
	
	}
	
}
