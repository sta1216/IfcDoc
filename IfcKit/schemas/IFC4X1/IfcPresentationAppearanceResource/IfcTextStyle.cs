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

namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("a79b1274-8b81-4827-baa7-03f278dc7a39")]
	public partial class IfcTextStyle : IfcPresentationStyle,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcPresentationStyleSelect
	{
		[DataMember(Order=0)] 
		[XmlElement]
		IfcTextStyleForDefinedFont _TextCharacterAppearance;
	
		[DataMember(Order=1)] 
		[XmlElement]
		IfcTextStyleTextModel _TextStyle;
	
		[DataMember(Order=2)] 
		[Required()]
		IfcTextFontSelect _TextFontStyle;
	
		[DataMember(Order=3)] 
		[XmlAttribute]
		IfcBoolean? _ModelOrDraughting;
	
	
		public IfcTextStyle()
		{
		}
	
		public IfcTextStyle(IfcLabel? __Name, IfcTextStyleForDefinedFont __TextCharacterAppearance, IfcTextStyleTextModel __TextStyle, IfcTextFontSelect __TextFontStyle, IfcBoolean? __ModelOrDraughting)
			: base(__Name)
		{
			this._TextCharacterAppearance = __TextCharacterAppearance;
			this._TextStyle = __TextStyle;
			this._TextFontStyle = __TextFontStyle;
			this._ModelOrDraughting = __ModelOrDraughting;
		}
	
		[Description("A character style to be used for presented text.\r\n<blockquote class=\"change-ifc2x" +
	    "4\">IFC4 CHANGE&nbsp; Superfluous select type IfcCharacterStyleSelect has been re" +
	    "moved.\r\n</blockquote>")]
		public IfcTextStyleForDefinedFont TextCharacterAppearance { get { return this._TextCharacterAppearance; } set { this._TextCharacterAppearance = value;} }
	
		[Description(@"The style applied to the text block for its visual appearance.
	<blockquote class=""change-ifc2x3"">IFC2x3 CHANGE&nbsp; The attribute <em>TextBlockStyle</em> has been changed from SET[1:?] to a non-aggregated optional and renamed into <em>TextStyles</em>.</blockquote>
	<blockquote class=""change-ifc2x4"">IFC4 CHANGE&nbsp; The IfcTextStyleWithBoxCharacteristics and the now superfluous select type IfcTextStyleSelect have been removed.
	</blockquote>")]
		public IfcTextStyleTextModel TextStyle { get { return this._TextStyle; } set { this._TextStyle = value;} }
	
		[Description(@"The style applied to the text font for its visual appearance. It defines the font family, font style, weight and size.
	  <blockquote class=""change-ifc2x2"">IFC2x2 Add2 CHANGE The attribute <em>TextFontStyle</em> is a new attribute attached to <em>IfcTextStyle</em>.
	  </blockquote>")]
		public IfcTextFontSelect TextFontStyle { get { return this._TextFontStyle; } set { this._TextFontStyle = value;} }
	
		[Description("Indication whether the length measures provided for the presentation style are mo" +
	    "del based, or draughting based.\r\n<blockquote class=\"change-ifc2x4\">IFC4 CHANGE&n" +
	    "bsp; New attribute.\r\n</blockquote>")]
		public IfcBoolean? ModelOrDraughting { get { return this._ModelOrDraughting; } set { this._ModelOrDraughting = value;} }
	
	
	}
	
}
