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
using BuildingSmart.IFC.IfcProfileResource;
using BuildingSmart.IFC.IfcSharedComponentElements;

namespace BuildingSmart.IFC.IfcStructuralElementsDomain
{
	[Guid("1e012790-9138-46ab-b075-8f853dffbdf8")]
	public partial class IfcReinforcementDefinitionProperties : IfcPreDefinedPropertySet
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcLabel? _DefinitionType;
	
		[DataMember(Order=1)] 
		[Required()]
		IList<IfcSectionReinforcementProperties> _ReinforcementSectionDefinitions = new List<IfcSectionReinforcementProperties>();
	
	
		[Description("Descriptive type name applied to reinforcement definition properties.")]
		public IfcLabel? DefinitionType { get { return this._DefinitionType; } set { this._DefinitionType = value;} }
	
		[Description("The list of section reinforcement properties attached to the reinforcement defini" +
	    "tion properties.")]
		public IList<IfcSectionReinforcementProperties> ReinforcementSectionDefinitions { get { return this._ReinforcementSectionDefinitions; } }
	
	
	}
	
}
