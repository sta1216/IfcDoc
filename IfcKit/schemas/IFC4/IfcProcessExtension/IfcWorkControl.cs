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
	[Guid("d247df5b-2f6d-4ef6-bca1-19a0283512e0")]
	public abstract partial class IfcWorkControl : IfcControl
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		[Required()]
		IfcDateTime _CreationDate;
	
		[DataMember(Order=1)] 
		ISet<IfcPerson> _Creators = new HashSet<IfcPerson>();
	
		[DataMember(Order=2)] 
		[XmlAttribute]
		IfcLabel? _Purpose;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcDuration? _Duration;
	
		[DataMember(Order=4)] 
		[XmlAttribute]
		IfcDuration? _TotalFloat;
	
		[DataMember(Order=5)] 
		[XmlAttribute]
		[Required()]
		IfcDateTime _StartTime;
	
		[DataMember(Order=6)] 
		[XmlAttribute]
		IfcDateTime? _FinishTime;
	
	
		[Description("    The date that the plan is created.")]
		public IfcDateTime CreationDate { get { return this._CreationDate; } set { this._CreationDate = value;} }
	
		[Description("    The authors of the work plan.")]
		public ISet<IfcPerson> Creators { get { return this._Creators; } }
	
		[Description("    A description of the purpose of the work schedule.")]
		public IfcLabel? Purpose { get { return this._Purpose; } set { this._Purpose = value;} }
	
		[Description("    The total duration of the entire work schedule.")]
		public IfcDuration? Duration { get { return this._Duration; } set { this._Duration = value;} }
	
		[Description("    The total time float of the entire work schedule.")]
		public IfcDuration? TotalFloat { get { return this._TotalFloat; } set { this._TotalFloat = value;} }
	
		[Description("    The start time of the schedule.")]
		public IfcDateTime StartTime { get { return this._StartTime; } set { this._StartTime = value;} }
	
		[Description("    The finish time of the schedule.")]
		public IfcDateTime? FinishTime { get { return this._FinishTime; } set { this._FinishTime = value;} }
	
	
	}
	
}
