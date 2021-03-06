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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedMgmtElements
{
	[Guid("7045cc64-c05a-4a43-aaa5-b5b4d849f3f5")]
	public partial class IfcActionRequest : IfcControl
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcActionRequestTypeEnum? _PredefinedType;
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcLabel? _Status;
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcText? _LongDescription;
	
	
		public IfcActionRequest()
		{
		}
	
		public IfcActionRequest(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcLabel? __ObjectType, IfcIdentifier? __Identification, IfcActionRequestTypeEnum? __PredefinedType, IfcLabel? __Status, IfcText? __LongDescription)
			: base(__GlobalId, __OwnerHistory, __Name, __Description, __ObjectType, __Identification)
		{
			this._PredefinedType = __PredefinedType;
			this._Status = __Status;
			this._LongDescription = __LongDescription;
		}
	
		[Description("Identifies the predefined type of sources through which a request can be made.\r\n\r" +
	    "\n<blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute has been added.</b" +
	    "lockquote>")]
		public IfcActionRequestTypeEnum? PredefinedType { get { return this._PredefinedType; } set { this._PredefinedType = value;} }
	
		[Description(@"The status currently assigned to the request.  Possible values include:<br/>
	Hold: wait to see if further requests are received before deciding on action<br/>
	NoAction: no action is required on this request<br/>
	Schedule: plan action to take place as part of maintenance or other task planning/scheduling<br/>
	Urgent: take action immediately<br/>
	
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE  The attribute has been added.</blockquote>")]
		public IfcLabel? Status { get { return this._Status; } set { this._Status = value;} }
	
		[Description("Detailed description of the permit.\r\n\r\n<blockquote class=\"change-ifc2x4\">IFC4 CHA" +
	    "NGE  The attribute has been added.</blockquote>")]
		public IfcText? LongDescription { get { return this._LongDescription; } set { this._LongDescription = value;} }
	
	
	}
	
}
