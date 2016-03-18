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
    public class VariablesPuestosDataset : DataSet {
        
        private VariablesPuestosDataTable tableVariablesPuestos;
        
        public VariablesPuestosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected VariablesPuestosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["VariablesPuestos"] != null)) {
                    this.Tables.Add(new VariablesPuestosDataTable(ds.Tables["VariablesPuestos"]));
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
        public VariablesPuestosDataTable VariablesPuestos {
            get {
                return this.tableVariablesPuestos;
            }
        }
        
        public override DataSet Clone() {
            VariablesPuestosDataset cln = ((VariablesPuestosDataset)(base.Clone()));
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
            if ((ds.Tables["VariablesPuestos"] != null)) {
                this.Tables.Add(new VariablesPuestosDataTable(ds.Tables["VariablesPuestos"]));
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
            this.tableVariablesPuestos = ((VariablesPuestosDataTable)(this.Tables["VariablesPuestos"]));
            if ((this.tableVariablesPuestos != null)) {
                this.tableVariablesPuestos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "VariablesPuestosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/VariablesPuestosDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableVariablesPuestos = new VariablesPuestosDataTable();
            this.Tables.Add(this.tableVariablesPuestos);
        }
        
        private bool ShouldSerializeVariablesPuestos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void VariablesPuestosRowChangeEventHandler(object sender, VariablesPuestosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class VariablesPuestosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdVariable;
            
            private DataColumn columnIdPuesto;
            
            private DataColumn columnValor;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal VariablesPuestosDataTable() : 
                    base("VariablesPuestos") {
                this.InitClass();
            }
            
            internal VariablesPuestosDataTable(DataTable table) : 
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
            
            internal DataColumn IdVariableColumn {
                get {
                    return this.columnIdVariable;
                }
            }
            
            internal DataColumn IdPuestoColumn {
                get {
                    return this.columnIdPuesto;
                }
            }
            
            internal DataColumn ValorColumn {
                get {
                    return this.columnValor;
                }
            }
            
            internal DataColumn FechaCreacionColumn {
                get {
                    return this.columnFechaCreacion;
                }
            }
            
            internal DataColumn IdConexionCreacionColumn {
                get {
                    return this.columnIdConexionCreacion;
                }
            }
            
            internal DataColumn UltimaModificacionColumn {
                get {
                    return this.columnUltimaModificacion;
                }
            }
            
            internal DataColumn IdConexionUltimaModificacionColumn {
                get {
                    return this.columnIdConexionUltimaModificacion;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            public VariablesPuestosRow this[int index] {
                get {
                    return ((VariablesPuestosRow)(this.Rows[index]));
                }
            }
            
            public event VariablesPuestosRowChangeEventHandler VariablesPuestosRowChanged;
            
            public event VariablesPuestosRowChangeEventHandler VariablesPuestosRowChanging;
            
            public event VariablesPuestosRowChangeEventHandler VariablesPuestosRowDeleted;
            
            public event VariablesPuestosRowChangeEventHandler VariablesPuestosRowDeleting;
            
            public void AddVariablesPuestosRow(VariablesPuestosRow row) {
                this.Rows.Add(row);
            }
            
            public VariablesPuestosRow AddVariablesPuestosRow(long IdVariable, long IdPuesto, string Valor, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                VariablesPuestosRow rowVariablesPuestosRow = ((VariablesPuestosRow)(this.NewRow()));
                rowVariablesPuestosRow.ItemArray = new object[] {
                        IdVariable,
                        IdPuesto,
                        Valor,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowVariablesPuestosRow);
                return rowVariablesPuestosRow;
            }
            
            public VariablesPuestosRow FindByIdVariableIdPuesto(long IdVariable, long IdPuesto) {
                return ((VariablesPuestosRow)(this.Rows.Find(new object[] {
                            IdVariable,
                            IdPuesto})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                VariablesPuestosDataTable cln = ((VariablesPuestosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new VariablesPuestosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdVariable = this.Columns["IdVariable"];
                this.columnIdPuesto = this.Columns["IdPuesto"];
                this.columnValor = this.Columns["Valor"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdVariable = new DataColumn("IdVariable", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVariable);
                this.columnIdPuesto = new DataColumn("IdPuesto", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPuesto);
                this.columnValor = new DataColumn("Valor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.Constraints.Add(new UniqueConstraint("VariablesPuestosDatasetKey1", new DataColumn[] {
                                this.columnIdVariable,
                                this.columnIdPuesto}, true));
                this.columnIdVariable.AllowDBNull = false;
                this.columnIdPuesto.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public VariablesPuestosRow NewVariablesPuestosRow() {
                return ((VariablesPuestosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new VariablesPuestosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(VariablesPuestosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.VariablesPuestosRowChanged != null)) {
                    this.VariablesPuestosRowChanged(this, new VariablesPuestosRowChangeEvent(((VariablesPuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.VariablesPuestosRowChanging != null)) {
                    this.VariablesPuestosRowChanging(this, new VariablesPuestosRowChangeEvent(((VariablesPuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.VariablesPuestosRowDeleted != null)) {
                    this.VariablesPuestosRowDeleted(this, new VariablesPuestosRowChangeEvent(((VariablesPuestosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.VariablesPuestosRowDeleting != null)) {
                    this.VariablesPuestosRowDeleting(this, new VariablesPuestosRowChangeEvent(((VariablesPuestosRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveVariablesPuestosRow(VariablesPuestosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class VariablesPuestosRow : DataRow {
            
            private VariablesPuestosDataTable tableVariablesPuestos;
            
            internal VariablesPuestosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableVariablesPuestos = ((VariablesPuestosDataTable)(this.Table));
            }
            
            public long IdVariable {
                get {
                    return ((long)(this[this.tableVariablesPuestos.IdVariableColumn]));
                }
                set {
                    this[this.tableVariablesPuestos.IdVariableColumn] = value;
                }
            }
            
            public long IdPuesto {
                get {
                    return ((long)(this[this.tableVariablesPuestos.IdPuestoColumn]));
                }
                set {
                    this[this.tableVariablesPuestos.IdPuestoColumn] = value;
                }
            }
            
            public string Valor {
                get {
                    try {
                        return ((string)(this[this.tableVariablesPuestos.ValorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesPuestos.ValorColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableVariablesPuestos.FechaCreacionColumn]));
                }
                set {
                    this[this.tableVariablesPuestos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableVariablesPuestos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableVariablesPuestos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableVariablesPuestos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesPuestos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableVariablesPuestos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesPuestos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableVariablesPuestos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableVariablesPuestos.RowIdColumn] = value;
                }
            }
            
            public bool IsValorNull() {
                return this.IsNull(this.tableVariablesPuestos.ValorColumn);
            }
            
            public void SetValorNull() {
                this[this.tableVariablesPuestos.ValorColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableVariablesPuestos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableVariablesPuestos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableVariablesPuestos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableVariablesPuestos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableVariablesPuestos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableVariablesPuestos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class VariablesPuestosRowChangeEvent : EventArgs {
            
            private VariablesPuestosRow eventRow;
            
            private DataRowAction eventAction;
            
            public VariablesPuestosRowChangeEvent(VariablesPuestosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public VariablesPuestosRow Row {
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
