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
	[Guid("124151ad-f32d-49c7-a2d4-857740425699")]
	public enum IfcEventTriggerTypeEnum
	{
		[Description("An event trigger that is a rule or constraint.")]
		EVENTRULE = 1,
	
		[Description("An event trigger that is a message or set of information.")]
		EVENTMESSAGE = 2,
	
		[Description("An event trigger that is at, or occurs after, a particular point in or period of " +
	    "time.")]
		EVENTTIME = 3,
	
		[Description("An event trigger that is a complex combination of things.")]
		EVENTCOMPLEX = 4,
	
		USERDEFINED = -1,
	
		NOTDEFINED = 0,
	
	}
}
