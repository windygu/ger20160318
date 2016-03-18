﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

namespace mz.erp.commontypes.data {
    using System;
    using System.Data;
    using System.Xml;
    using System.Runtime.Serialization;
    
    
    [Serializable()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Diagnostics.DebuggerStepThrough()]
    [System.ComponentModel.ToolboxItem(true)]
    public class tsy_ImpuestosExDataset : DataSet {
        
        private tsy_ImpuestosExDataTable tabletsy_ImpuestosEx;
        
        public tsy_ImpuestosExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsy_ImpuestosExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsy_ImpuestosEx"] != null)) {
                    this.Tables.Add(new tsy_ImpuestosExDataTable(ds.Tables["tsy_ImpuestosEx"]));
                }
                this.DataSetName = ds.DataSetName;
                this.Prefix = ds.Prefix;
                this.Namespace = ds.Namespace;
                this.Locale = ds.Locale;
                this.CaseSensitive = ds.CaseSensitive;
                this.EnforceConstraints = ds.EnforceConstraints;
                this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
                this.InitVars();
            }
            else {
                this.InitClass();
            }
            this.GetSerializationData(info, context);
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public tsy_ImpuestosExDataTable tsy_ImpuestosEx {
            get {
                return this.tabletsy_ImpuestosEx;
            }
        }
        
        public override DataSet Clone() {
            tsy_ImpuestosExDataset cln = ((tsy_ImpuestosExDataset)(base.Clone()));
            cln.InitVars();
            return cln;
        }
        
        protected override bool ShouldSerializeTables() {
            return false;
        }
        
        protected override bool ShouldSerializeRelations() {
            return false;
        }
        
        protected override void ReadXmlSerializable(XmlReader reader) {
            this.Reset();
            DataSet ds = new DataSet();
            ds.ReadXml(reader);
            if ((ds.Tables["tsy_ImpuestosEx"] != null)) {
                this.Tables.Add(new tsy_ImpuestosExDataTable(ds.Tables["tsy_ImpuestosEx"]));
            }
            this.DataSetName = ds.DataSetName;
            this.Prefix = ds.Prefix;
            this.Namespace = ds.Namespace;
            this.Locale = ds.Locale;
            this.CaseSensitive = ds.CaseSensitive;
            this.EnforceConstraints = ds.EnforceConstraints;
            this.Merge(ds, false, System.Data.MissingSchemaAction.Add);
            this.InitVars();
        }
        
        protected override System.Xml.Schema.XmlSchema GetSchemaSerializable() {
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            this.WriteXmlSchema(new XmlTextWriter(stream, null));
            stream.Position = 0;
            return System.Xml.Schema.XmlSchema.Read(new XmlTextReader(stream), null);
        }
        
        internal void InitVars() {
            this.tabletsy_ImpuestosEx = ((tsy_ImpuestosExDataTable)(this.Tables["tsy_ImpuestosEx"]));
            if ((this.tabletsy_ImpuestosEx != null)) {
                this.tabletsy_ImpuestosEx.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsy_ImpuestosExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsy_ImpuestosEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsy_ImpuestosEx = new tsy_ImpuestosExDataTable();
            this.Tables.Add(this.tabletsy_ImpuestosEx);
        }
        
        private bool ShouldSerializetsy_ImpuestosEx() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsy_ImpuestosExRowChangeEventHandler(object sender, tsy_ImpuestosExRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_ImpuestosExDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdImpuesto;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFormulaDeCalculo;
            
            private DataColumn columnIdTipoDeConcepto;
            
            private DataColumn columnMetodoDeComparacion;
            
            private DataColumn columnAplicadoA;
            
            private DataColumn columnImpuesto;
            
            private DataColumn columnDescripcionCorta;
            
            private DataColumn columnDescripcionLarga;
            
            private DataColumn columnAlicuota;
            
            internal tsy_ImpuestosExDataTable() : 
                    base("tsy_ImpuestosEx") {
                this.InitClass();
            }
            
            internal tsy_ImpuestosExDataTable(DataTable table) : 
                    base(table.TableName) {
                if ((table.CaseSensitive != table.DataSet.CaseSensitive)) {
                    this.CaseSensitive = table.CaseSensitive;
                }
                if ((table.Locale.ToString() != table.DataSet.Locale.ToString())) {
                    this.Locale = table.Locale;
                }
                if ((table.Namespace != table.DataSet.Namespace)) {
                    this.Namespace = table.Namespace;
                }
                this.Prefix = table.Prefix;
                this.MinimumCapacity = table.MinimumCapacity;
                this.DisplayExpression = table.DisplayExpression;
            }
            
            [System.ComponentModel.Browsable(false)]
            public int Count {
                get {
                    return this.Rows.Count;
                }
            }
            
            internal DataColumn IdImpuestoColumn {
                get {
                    return this.columnIdImpuesto;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn FormulaDeCalculoColumn {
                get {
                    return this.columnFormulaDeCalculo;
                }
            }
            
            internal DataColumn IdTipoDeConceptoColumn {
                get {
                    return this.columnIdTipoDeConcepto;
                }
            }
            
            internal DataColumn MetodoDeComparacionColumn {
                get {
                    return this.columnMetodoDeComparacion;
                }
            }
            
            internal DataColumn AplicadoAColumn {
                get {
                    return this.columnAplicadoA;
                }
            }
            
            internal DataColumn ImpuestoColumn {
                get {
                    return this.columnImpuesto;
                }
            }
            
            internal DataColumn DescripcionCortaColumn {
                get {
                    return this.columnDescripcionCorta;
                }
            }
            
            internal DataColumn DescripcionLargaColumn {
                get {
                    return this.columnDescripcionLarga;
                }
            }
            
            internal DataColumn AlicuotaColumn {
                get {
                    return this.columnAlicuota;
                }
            }
            
            public tsy_ImpuestosExRow this[int index] {
                get {
                    return ((tsy_ImpuestosExRow)(this.Rows[index]));
                }
            }
            
            public event tsy_ImpuestosExRowChangeEventHandler tsy_ImpuestosExRowChanged;
            
            public event tsy_ImpuestosExRowChangeEventHandler tsy_ImpuestosExRowChanging;
            
            public event tsy_ImpuestosExRowChangeEventHandler tsy_ImpuestosExRowDeleted;
            
            public event tsy_ImpuestosExRowChangeEventHandler tsy_ImpuestosExRowDeleting;
            
            public void Addtsy_ImpuestosExRow(tsy_ImpuestosExRow row) {
                this.Rows.Add(row);
            }
            
            public tsy_ImpuestosExRow Addtsy_ImpuestosExRow(string IdImpuesto, string Descripcion, string FormulaDeCalculo, string IdTipoDeConcepto, string MetodoDeComparacion, string AplicadoA, string Impuesto, string DescripcionCorta, string DescripcionLarga, System.Decimal Alicuota) {
                tsy_ImpuestosExRow rowtsy_ImpuestosExRow = ((tsy_ImpuestosExRow)(this.NewRow()));
                rowtsy_ImpuestosExRow.ItemArray = new object[] {
                        IdImpuesto,
                        Descripcion,
                        FormulaDeCalculo,
                        IdTipoDeConcepto,
                        MetodoDeComparacion,
                        AplicadoA,
                        Impuesto,
                        DescripcionCorta,
                        DescripcionLarga,
                        Alicuota};
                this.Rows.Add(rowtsy_ImpuestosExRow);
                return rowtsy_ImpuestosExRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsy_ImpuestosExDataTable cln = ((tsy_ImpuestosExDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsy_ImpuestosExDataTable();
            }
            
            internal void InitVars() {
                this.columnIdImpuesto = this.Columns["IdImpuesto"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFormulaDeCalculo = this.Columns["FormulaDeCalculo"];
                this.columnIdTipoDeConcepto = this.Columns["IdTipoDeConcepto"];
                this.columnMetodoDeComparacion = this.Columns["MetodoDeComparacion"];
                this.columnAplicadoA = this.Columns["AplicadoA"];
                this.columnImpuesto = this.Columns["Impuesto"];
                this.columnDescripcionCorta = this.Columns["DescripcionCorta"];
                this.columnDescripcionLarga = this.Columns["DescripcionLarga"];
                this.columnAlicuota = this.Columns["Alicuota"];
            }
            
            private void InitClass() {
                this.columnIdImpuesto = new DataColumn("IdImpuesto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdImpuesto);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnFormulaDeCalculo = new DataColumn("FormulaDeCalculo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFormulaDeCalculo);
                this.columnIdTipoDeConcepto = new DataColumn("IdTipoDeConcepto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeConcepto);
                this.columnMetodoDeComparacion = new DataColumn("MetodoDeComparacion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMetodoDeComparacion);
                this.columnAplicadoA = new DataColumn("AplicadoA", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAplicadoA);
                this.columnImpuesto = new DataColumn("Impuesto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnImpuesto);
                this.columnDescripcionCorta = new DataColumn("DescripcionCorta", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcionCorta);
                this.columnDescripcionLarga = new DataColumn("DescripcionLarga", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcionLarga);
                this.columnAlicuota = new DataColumn("Alicuota", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAlicuota);
                this.columnIdImpuesto.AllowDBNull = false;
                this.columnAplicadoA.ReadOnly = true;
            }
            
            public tsy_ImpuestosExRow Newtsy_ImpuestosExRow() {
                return ((tsy_ImpuestosExRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsy_ImpuestosExRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsy_ImpuestosExRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsy_ImpuestosExRowChanged != null)) {
                    this.tsy_ImpuestosExRowChanged(this, new tsy_ImpuestosExRowChangeEvent(((tsy_ImpuestosExRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsy_ImpuestosExRowChanging != null)) {
                    this.tsy_ImpuestosExRowChanging(this, new tsy_ImpuestosExRowChangeEvent(((tsy_ImpuestosExRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsy_ImpuestosExRowDeleted != null)) {
                    this.tsy_ImpuestosExRowDeleted(this, new tsy_ImpuestosExRowChangeEvent(((tsy_ImpuestosExRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsy_ImpuestosExRowDeleting != null)) {
                    this.tsy_ImpuestosExRowDeleting(this, new tsy_ImpuestosExRowChangeEvent(((tsy_ImpuestosExRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsy_ImpuestosExRow(tsy_ImpuestosExRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_ImpuestosExRow : DataRow {
            
            private tsy_ImpuestosExDataTable tabletsy_ImpuestosEx;
            
            internal tsy_ImpuestosExRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsy_ImpuestosEx = ((tsy_ImpuestosExDataTable)(this.Table));
            }
            
            public string IdImpuesto {
                get {
                    return ((string)(this[this.tabletsy_ImpuestosEx.IdImpuestoColumn]));
                }
                set {
                    this[this.tabletsy_ImpuestosEx.IdImpuestoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsy_ImpuestosEx.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.DescripcionColumn] = value;
                }
            }
            
            public string FormulaDeCalculo {
                get {
                    if (this.IsFormulaDeCalculoNull()) {
                        return string.Empty;
                    }
                    else {
                        return ((string)(this[this.tabletsy_ImpuestosEx.FormulaDeCalculoColumn]));
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.FormulaDeCalculoColumn] = value;
                }
            }
            
            public string IdTipoDeConcepto {
                get {
                    try {
                        return ((string)(this[this.tabletsy_ImpuestosEx.IdTipoDeConceptoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.IdTipoDeConceptoColumn] = value;
                }
            }
            
            public string MetodoDeComparacion {
                get {
                    try {
                        return ((string)(this[this.tabletsy_ImpuestosEx.MetodoDeComparacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.MetodoDeComparacionColumn] = value;
                }
            }
            
            public string AplicadoA {
                get {
                    try {
                        return ((string)(this[this.tabletsy_ImpuestosEx.AplicadoAColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.AplicadoAColumn] = value;
                }
            }
            
            public string Impuesto {
                get {
                    try {
                        return ((string)(this[this.tabletsy_ImpuestosEx.ImpuestoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.ImpuestoColumn] = value;
                }
            }
            
            public string DescripcionCorta {
                get {
                    if (this.IsDescripcionCortaNull()) {
                        return null;
                    }
                    else {
                        return ((string)(this[this.tabletsy_ImpuestosEx.DescripcionCortaColumn]));
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.DescripcionCortaColumn] = value;
                }
            }
            
            public string DescripcionLarga {
                get {
                    if (this.IsDescripcionLargaNull()) {
                        return null;
                    }
                    else {
                        return ((string)(this[this.tabletsy_ImpuestosEx.DescripcionLargaColumn]));
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.DescripcionLargaColumn] = value;
                }
            }
            
            public System.Decimal Alicuota {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsy_ImpuestosEx.AlicuotaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsy_ImpuestosEx.AlicuotaColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsy_ImpuestosEx.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFormulaDeCalculoNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.FormulaDeCalculoColumn);
            }
            
            public void SetFormulaDeCalculoNull() {
                this[this.tabletsy_ImpuestosEx.FormulaDeCalculoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdTipoDeConceptoNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.IdTipoDeConceptoColumn);
            }
            
            public void SetIdTipoDeConceptoNull() {
                this[this.tabletsy_ImpuestosEx.IdTipoDeConceptoColumn] = System.Convert.DBNull;
            }
            
            public bool IsMetodoDeComparacionNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.MetodoDeComparacionColumn);
            }
            
            public void SetMetodoDeComparacionNull() {
                this[this.tabletsy_ImpuestosEx.MetodoDeComparacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsAplicadoANull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.AplicadoAColumn);
            }
            
            public void SetAplicadoANull() {
                this[this.tabletsy_ImpuestosEx.AplicadoAColumn] = System.Convert.DBNull;
            }
            
            public bool IsImpuestoNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.ImpuestoColumn);
            }
            
            public void SetImpuestoNull() {
                this[this.tabletsy_ImpuestosEx.ImpuestoColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionCortaNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.DescripcionCortaColumn);
            }
            
            public void SetDescripcionCortaNull() {
                this[this.tabletsy_ImpuestosEx.DescripcionCortaColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionLargaNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.DescripcionLargaColumn);
            }
            
            public void SetDescripcionLargaNull() {
                this[this.tabletsy_ImpuestosEx.DescripcionLargaColumn] = System.Convert.DBNull;
            }
            
            public bool IsAlicuotaNull() {
                return this.IsNull(this.tabletsy_ImpuestosEx.AlicuotaColumn);
            }
            
            public void SetAlicuotaNull() {
                this[this.tabletsy_ImpuestosEx.AlicuotaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsy_ImpuestosExRowChangeEvent : EventArgs {
            
            private tsy_ImpuestosExRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsy_ImpuestosExRowChangeEvent(tsy_ImpuestosExRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsy_ImpuestosExRow Row {
                get {
                    return this.eventRow;
                }
            }
            
            public DataRowAction Action {
                get {
                    return this.eventAction;
                }
            }
        }
    }
}