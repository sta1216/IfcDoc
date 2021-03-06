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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcCostResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("18081646-220a-42c0-a4f6-b045160da49d")]
	public enum IfcWorkCalendarTypeEnum
	{
		[Description("Belongs to the first shift.")]
		FIRSTSHIFT = 1,
	
		[Description("Belongs to the second shift.")]
		SECONDSHIFT = 2,
	
		[Description("Belongs to the third shift.")]
		THIRDSHIFT = 3,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
