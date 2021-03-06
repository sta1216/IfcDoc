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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcPropertyResource
{
	[Guid("ae3fc958-993d-4887-827a-358811be21ac")]
	public partial class IfcPropertyEnumeratedValue : IfcSimpleProperty
	{
		[DataMember(Order=0)] 
		[Required()]
		[MinLength(1)]
		IList<IfcValue> _EnumerationValues = new List<IfcValue>();
	
		[DataMember(Order=1)] 
		IfcPropertyEnumeration _EnumerationReference;
	
	
		public IfcPropertyEnumeratedValue()
		{
		}
	
		public IfcPropertyEnumeratedValue(IfcIdentifier __Name, IfcText? __Description, IfcValue[] __EnumerationValues, IfcPropertyEnumeration __EnumerationReference)
			: base(__Name, __Description)
		{
			this._EnumerationValues = new List<IfcValue>(__EnumerationValues);
			this._EnumerationReference = __EnumerationReference;
		}
	
		[Description("Enumeration values, which shall be listed in the referenced IfcPropertyEnumeratio" +
	    "n, if such a reference is provided.")]
		public IList<IfcValue> EnumerationValues { get { return this._EnumerationValues; } }
	
		[Description("Enumeration from which a enumeration value has been selected. The referenced enum" +
	    "eration also establishes the unit of the enumeration value.")]
		public IfcPropertyEnumeration EnumerationReference { get { return this._EnumerationReference; } set { this._EnumerationReference = value;} }
	
	
	}
	
}
