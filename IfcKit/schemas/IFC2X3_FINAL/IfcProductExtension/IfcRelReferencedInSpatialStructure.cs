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

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("84e20472-51cc-4357-8e9a-6fd9f97f6e03")]
	public partial class IfcRelReferencedInSpatialStructure : IfcRelConnects
	{
		[DataMember(Order=0)] 
		[Required()]
		[MinLength(1)]
		ISet<IfcProduct> _RelatedElements = new HashSet<IfcProduct>();
	
		[DataMember(Order=1)] 
		[Required()]
		IfcSpatialStructureElement _RelatingStructure;
	
	
		public IfcRelReferencedInSpatialStructure()
		{
		}
	
		public IfcRelReferencedInSpatialStructure(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcProduct[] __RelatedElements, IfcSpatialStructureElement __RelatingStructure)
			: base(__GlobalId, __OwnerHistory, __Name, __Description)
		{
			this._RelatedElements = new HashSet<IfcProduct>(__RelatedElements);
			this._RelatingStructure = __RelatingStructure;
		}
	
		[Description(@"<EPM-HTML>
	Set of products, which are referenced within this level of the spatial structure hierarchy.
	<blockquote><small>NOTE&nbsp; Referenced elements are contained elsewhere within the spatial structure, they are referenced additionally by this spatial structure element, e.g., because they span several stories.</small>
	</blockquote>
	</EPM-HTML>")]
		public ISet<IfcProduct> RelatedElements { get { return this._RelatedElements; } }
	
		[Description("<EPM-HTML>\r\nSpatial structure element, within which the element is referenced. An" +
	    "y element can be contained within zero, one or many elements of the project spat" +
	    "ial structure.\r\n</EPM-HTML>")]
		public IfcSpatialStructureElement RelatingStructure { get { return this._RelatingStructure; } set { this._RelatingStructure = value;} }
	
	
	}
	
}
