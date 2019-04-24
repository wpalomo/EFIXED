﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace FirmElect.Info.class_sri.Factura
{
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class factura
    {

        private infoTributaria infoTributariaField;

        private facturaInfoFactura infoFacturaField;

        private List< facturaDetalle> detallesField;

        private List< facturaCampoAdicional> infoAdicionalField;

        private facturaID idField;

        private bool idFieldSpecified;

        private string versionField;

        /// <comentarios/>
        public infoTributaria infoTributaria
        {
            get
            {
                return this.infoTributariaField;
            }
            set
            {
                this.infoTributariaField = value;
            }
        }

        /// <comentarios/>
        public facturaInfoFactura infoFactura
        {
            get
            {
                return this.infoFacturaField;
            }
            set
            {
                this.infoFacturaField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("detalle", IsNullable = false)]
        public List< facturaDetalle> detalles
        {
            get
            {
                return this.detallesField;
            }
            set
            {
                this.detallesField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlArrayItemAttribute("campoAdicional", IsNullable = false)]
        public List< facturaCampoAdicional> infoAdicional
        {
            get
            {
                return this.infoAdicionalField;
            }
            set
            {
                this.infoAdicionalField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public facturaID id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <comentarios/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <comentarios/>
    
    }

  
    