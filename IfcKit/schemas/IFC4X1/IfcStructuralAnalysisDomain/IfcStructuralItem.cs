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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralLoadResource;

namespace BuildingSmart.IFC.IfcStructuralAnalysisDomain
{
	[Guid("a309fabc-b0bd-4c8d-a1e7-0a91f255ecce")]
	public abstract partial class IfcStructuralItem : IfcProduct,
		BuildingSmart.IFC.IfcStructuralAnalysisDomain.IfcStructuralActivityAssignmentSelect
	{
		[InverseProperty("RelatingElement")] 
		ISet<IfcRelConnectsStructuralActivity> _AssignedStructuralActivity = new HashSet<IfcRelConnectsStructuralActivity>();
	
	
		[Description("Inverse relationship to all structural activities (i.e. to actions or reactions) " +
	    "which are assigned to this structural member.")]
		public ISet<IfcRelConnectsStructuralActivity> AssignedStructuralActivity { get { return this._AssignedStructuralActivity; } }
	
	
	}
	
}
