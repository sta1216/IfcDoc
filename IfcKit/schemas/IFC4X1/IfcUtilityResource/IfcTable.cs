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

using BuildingSmart.IFC.IfcConstraintResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcUtilityResource
{
	[Guid("a998a201-457f-4f17-9337-b5f2acb084d8")]
	public partial class IfcTable :
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect
	{
		[DataMember(Order=0)] 
		[XmlAttribute]
		IfcLabel? _Name;
	
		[DataMember(Order=1)] 
		[MinLength(1)]
		IList<IfcTableRow> _Rows = new List<IfcTableRow>();
	
		[DataMember(Order=2)] 
		[MinLength(1)]
		IList<IfcTableColumn> _Columns = new List<IfcTableColumn>();
	
	
		public IfcTable()
		{
		}
	
		public IfcTable(IfcLabel? __Name, IfcTableRow[] __Rows, IfcTableColumn[] __Columns)
		{
			this._Name = __Name;
			this._Rows = new List<IfcTableRow>(__Rows);
			this._Columns = new List<IfcTableColumn>(__Columns);
		}
	
		public IfcLabel? Name { get { return this._Name; } set { this._Name = value;} }
	
		[Description("Reference to information content of rows.")]
		public IList<IfcTableRow> Rows { get { return this._Rows; } }
	
		[Description("The column information associated with this table. ")]
		public IList<IfcTableColumn> Columns { get { return this._Columns; } }
	
		public new IfcInteger NumberOfCellsInRow { get { return new IfcInteger(); } }
	
		public new IfcInteger NumberOfHeadings { get { return new IfcInteger(); } }
	
		public new IfcInteger NumberOfDataRows { get { return new IfcInteger(); } }
	
	
	}
	
}
