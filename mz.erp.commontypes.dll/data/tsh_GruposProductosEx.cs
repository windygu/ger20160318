﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
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
    public class tsh_GruposProductosExDataset : DataSet {
        
        private Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados;
        
        public tsh_GruposProductosExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_GruposProductosExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["Pr_tsh_GruposProductos_BuscarPadresNoDuplicados"] != null)) {
                    this.Tables.Add(new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable(ds.Tables["Pr_tsh_GruposProductos_BuscarPadresNoDuplicados"]));
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
        public Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable Pr_tsh_GruposProductos_BuscarPadresNoDuplicados {
            get {
                return this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados;
            }
        }
        
        public override DataSet Clone() {
            tsh_GruposProductosExDataset cln = ((tsh_GruposProductosExDataset)(base.Clone()));
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
            if ((ds.Tables["Pr_tsh_GruposProductos_BuscarPadresNoDuplicados"] != null)) {
                this.Tables.Add(new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable(ds.Tables["Pr_tsh_GruposProductos_BuscarPadresNoDuplicados"]));
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
            this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados = ((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable)(this.Tables["Pr_tsh_GruposProductos_BuscarPadresNoDuplicados"]));
            if ((this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados != null)) {
                this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_GruposProductosExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_GruposProductosEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados = new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable();
            this.Tables.Add(this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados);
        }
        
        private bool ShouldSerializePr_tsh_GruposProductos_BuscarPadresNoDuplicados() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEventHandler(object sender, Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdPadre;
            
            internal Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable() : 
                    base("Pr_tsh_GruposProductos_BuscarPadresNoDuplicados") {
                this.InitClass();
            }
            
            internal Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable(DataTable table) : 
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
            
            internal DataColumn IdPadreColumn {
                get {
                    return this.columnIdPadre;
                }
            }
            
            public Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow this[int index] {
                get {
                    return ((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(this.Rows[index]));
                }
            }
            
            public event Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEventHandler Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChanged;
            
            public event Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEventHandler Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChanging;
            
            public event Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEventHandler Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowDeleted;
            
            public event Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEventHandler Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowDeleting;
            
            public void AddPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow(Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow row) {
                this.Rows.Add(row);
            }
            
            public Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow AddPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow(string IdPadre) {
                Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow rowPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow = ((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(this.NewRow()));
                rowPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow.ItemArray = new object[] {
                        IdPadre};
                this.Rows.Add(rowPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow);
                return rowPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow;
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable cln = ((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdPadre = this.Columns["IdPadre"];
            }
            
            private void InitClass() {
                this.columnIdPadre = new DataColumn("IdPadre", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPadre);
                this.columnIdPadre.AllowDBNull = false;
            }
            
            public Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow NewPr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow() {
                return ((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChanged != null)) {
                    this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChanged(this, new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent(((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChanging != null)) {
                    this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChanging(this, new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent(((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowDeleted != null)) {
                    this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowDeleted(this, new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent(((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowDeleting != null)) {
                    this.Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowDeleting(this, new Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent(((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow)(e.Row)), e.Action));
                }
            }
            
            public void RemovePr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow(Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow : DataRow {
            
            private Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados;
            
            internal Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados = ((Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosDataTable)(this.Table));
            }
            
            public string IdPadre {
                get {
                    return ((string)(this[this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados.IdPadreColumn]));
                }
                set {
                    this[this.tablePr_tsh_GruposProductos_BuscarPadresNoDuplicados.IdPadreColumn] = value;
                }
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent : EventArgs {
            
            private Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow eventRow;
            
            private DataRowAction eventAction;
            
            public Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRowChangeEvent(Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public Pr_tsh_GruposProductos_BuscarPadresNoDuplicadosRow Row {
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