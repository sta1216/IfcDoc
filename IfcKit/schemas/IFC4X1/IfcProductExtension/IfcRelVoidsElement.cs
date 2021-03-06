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
	[Guid("5307e7a4-2270-4ad7-9e3c-ba76198cc09e")]
	public partial class IfcRelVoidsElement : IfcRelDecomposes
	{
		[DataMember(Order=0)] 
		[XmlIgnore]
		[Required()]
		IfcElement _RelatingBuildingElement;
	
		[DataMember(Order=1)] 
		[XmlElement]
		[Required()]
		IfcFeatureElementSubtraction _RelatedOpeningElement;
	
	
		public IfcRelVoidsElement()
		{
		}
	
		public IfcRelVoidsElement(IfcGloballyUniqueId __GlobalId, IfcOwnerHistory __OwnerHistory, IfcLabel? __Name, IfcText? __Description, IfcElement __RelatingBuildingElement, IfcFeatureElementSubtraction __RelatedOpeningElement)
			: base(__GlobalId, __OwnerHistory, __Name, __Description)
		{
			this._RelatingBuildingElement = __RelatingBuildingElement;
			this._RelatedOpeningElement = __RelatedOpeningElement;
		}
	
		[Description(@"Reference to element in which a void is created by associated feature subtraction element.
	<blockquote class=""change-ifc2x"">IFC2x CHANGE&nbsp; The data type has been changed from <em>IfcBuildingElement</em> to <em>IfcElement</em> with upward compatibility for file based exchange.</blockquote>
	")]
		public IfcElement RelatingBuildingElement { get { return this._RelatingBuildingElement; } set { this._RelatingBuildingElement = value;} }
	
		[Description(@"Reference to the feature subtraction element which defines a void in the associated element.
	<blockquote class=""change-ifc2x"">IFC2x CHANGE&nbsp; The data type has been changed from <em>IfcOpeningElement</em> to <em>IfcFeatureElementSubtraction</em> with upward compatibility for file based exchange.</blockquote>")]
		public IfcFeatureElementSubtraction RelatedOpeningElement { get { return this._RelatedOpeningElement; } set { this._RelatedOpeningElement = value;} }
	
	
	}
	
}
