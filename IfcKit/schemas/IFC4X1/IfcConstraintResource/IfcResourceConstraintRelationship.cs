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
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcConstraintResource
{
	[Guid("a14f1e2c-6b41-4740-8797-3a51d8f35cc5")]
	public partial class IfcResourceConstraintRelationship : IfcResourceLevelRelationship
	{
		[DataMember(Order=0)] 
		[XmlElement]
		[Required()]
		IfcConstraint _RelatingConstraint;
	
		[DataMember(Order=1)] 
		[Required()]
		[MinLength(1)]
		ISet<IfcResourceObjectSelect> _RelatedResourceObjects = new HashSet<IfcResourceObjectSelect>();
	
	
		public IfcResourceConstraintRelationship()
		{
		}
	
		public IfcResourceConstraintRelationship(IfcLabel? __Name, IfcText? __Description, IfcConstraint __RelatingConstraint, IfcResourceObjectSelect[] __RelatedResourceObjects)
			: base(__Name, __Description)
		{
			this._RelatingConstraint = __RelatingConstraint;
			this._RelatedResourceObjects = new HashSet<IfcResourceObjectSelect>(__RelatedResourceObjects);
		}
	
		[Description("The constraint that is to be related.")]
		public IfcConstraint RelatingConstraint { get { return this._RelatingConstraint; } set { this._RelatingConstraint = value;} }
	
		[Description("The properties to which a constraint is to be related.")]
		public ISet<IfcResourceObjectSelect> RelatedResourceObjects { get { return this._RelatedResourceObjects; } }
	
	
	}
	
}
