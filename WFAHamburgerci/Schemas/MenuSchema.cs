﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MenuSchema {
    
    private MenuSchemaMenu[] menuField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Menu")]
    public MenuSchemaMenu[] Menu {
        get {
            return this.menuField;
        }
        set {
            this.menuField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class MenuSchemaMenu {
    
    private string menuAdiField;
    
    private decimal fiyatiField;
    
    /// <remarks/>
    public string MenuAdi {
        get {
            return this.menuAdiField;
        }
        set {
            this.menuAdiField = value;
        }
    }
    
    /// <remarks/>
    public decimal Fiyati {
        get {
            return this.fiyatiField;
        }
        set {
            this.fiyatiField = value;
        }
    }
}