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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("f27d7589-d76f-4bdd-9102-d6fee84cd2a1")]
	public partial class IfcCompositeProfileDef : IfcProfileDef
	{
		[DataMember(Order=0)] 
		[Required()]
		ISet<IfcProfileDef> _Profiles = new HashSet<IfcProfileDef>();
	
		[DataMember(Order=1)] 
		[XmlAttribute]
		IfcLabel? _Label;
	
	
		[Description("The profiles which are used to define the composite profile.")]
		public ISet<IfcProfileDef> Profiles { get { return this._Profiles; } }
	
		[Description("The name by which the composition may be referred to. The actual meaning of the n" +
	    "ame has to be defined in the context of applications.")]
		public IfcLabel? Label { get { return this._Label; } set { this._Label = value;} }
	
	
	}
	
}
