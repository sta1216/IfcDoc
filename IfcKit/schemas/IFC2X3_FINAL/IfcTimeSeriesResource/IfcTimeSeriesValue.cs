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

namespace BuildingSmart.IFC.IfcTimeSeriesResource
{
	[Guid("77956129-ea99-44a3-9ef0-5ce85a0ba496")]
	public partial class IfcTimeSeriesValue
	{
		[DataMember(Order=0)] 
		[Required()]
		[MinLength(1)]
		IList<IfcValue> _ListValues = new List<IfcValue>();
	
	
		public IfcTimeSeriesValue()
		{
		}
	
		public IfcTimeSeriesValue(IfcValue[] __ListValues)
		{
			this._ListValues = new List<IfcValue>(__ListValues);
		}
	
		[Description("A list of time-series values. At least one value is required.")]
		public IList<IfcValue> ListValues { get { return this._ListValues; } }
	
	
	}
	
}
