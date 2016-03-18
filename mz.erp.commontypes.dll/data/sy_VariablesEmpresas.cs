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
    public class sy_VariablesEmpresasDataset : DataSet {
        
        private sy_VariablesEmpresasDataTable tablesy_VariablesEmpresas;
        
        public sy_VariablesEmpresasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_VariablesEmpresasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_VariablesEmpresas"] != null)) {
                    this.Tables.Add(new sy_VariablesEmpresasDataTable(ds.Tables["sy_VariablesEmpresas"]));
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
        public sy_VariablesEmpresasDataTable sy_VariablesEmpresas {
            get {
                return this.tablesy_VariablesEmpresas;
            }
        }
        
        public override DataSet Clone() {
            sy_VariablesEmpresasDataset cln = ((sy_VariablesEmpresasDataset)(base.Clone()));
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
            if ((ds.Tables["sy_VariablesEmpresas"] != null)) {
                this.Tables.Add(new sy_VariablesEmpresasDataTable(ds.Tables["sy_VariablesEmpresas"]));
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
            this.tablesy_VariablesEmpresas = ((sy_VariablesEmpresasDataTable)(this.Tables["sy_VariablesEmpresas"]));
            if ((this.tablesy_VariablesEmpresas != null)) {
                this.tablesy_VariablesEmpresas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_VariablesEmpresasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_VariablesEmpresas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_VariablesEmpresas = new sy_VariablesEmpresasDataTable();
            this.Tables.Add(this.tablesy_VariablesEmpresas);
        }
        
        private bool ShouldSerializesy_VariablesEmpresas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_VariablesEmpresasRowChangeEventHandler(object sender, sy_VariablesEmpresasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_VariablesEmpresasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdVariable;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnValor;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_VariablesEmpresasDataTable() : 
                    base("sy_VariablesEmpresas") {
                this.InitClass();
            }
            
            internal sy_VariablesEmpresasDataTable(DataTable table) : 
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
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
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
            
            public sy_VariablesEmpresasRow this[int index] {
                get {
                    return ((sy_VariablesEmpresasRow)(this.Rows[index]));
                }
            }
            
            public event sy_VariablesEmpresasRowChangeEventHandler sy_VariablesEmpresasRowChanged;
            
            public event sy_VariablesEmpresasRowChangeEventHandler sy_VariablesEmpresasRowChanging;
            
            public event sy_VariablesEmpresasRowChangeEventHandler sy_VariablesEmpresasRowDeleted;
            
            public event sy_VariablesEmpresasRowChangeEventHandler sy_VariablesEmpresasRowDeleting;
            
            public void Addsy_VariablesEmpresasRow(sy_VariablesEmpresasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_VariablesEmpresasRow Addsy_VariablesEmpresasRow(string IdVariable, long IdEmpresa, string Valor, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_VariablesEmpresasRow rowsy_VariablesEmpresasRow = ((sy_VariablesEmpresasRow)(this.NewRow()));
                rowsy_VariablesEmpresasRow.ItemArray = new object[] {
                        IdVariable,
                        IdEmpresa,
                        Valor,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_VariablesEmpresasRow);
                return rowsy_VariablesEmpresasRow;
            }
            
            public sy_VariablesEmpresasRow FindByIdVariableIdEmpresa(string IdVariable, long IdEmpresa) {
                return ((sy_VariablesEmpresasRow)(this.Rows.Find(new object[] {
                            IdVariable,
                            IdEmpresa})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_VariablesEmpresasDataTable cln = ((sy_VariablesEmpresasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_VariablesEmpresasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdVariable = this.Columns["IdVariable"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnValor = this.Columns["Valor"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdVariable = new DataColumn("IdVariable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVariable);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
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
                this.Constraints.Add(new UniqueConstraint("sy_VariablesEmpresasDatasetKey1", new DataColumn[] {
                                this.columnIdVariable,
                                this.columnIdEmpresa}, true));
                this.columnIdVariable.AllowDBNull = false;
                this.columnIdEmpresa.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_VariablesEmpresasRow Newsy_VariablesEmpresasRow() {
                return ((sy_VariablesEmpresasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_VariablesEmpresasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_VariablesEmpresasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_VariablesEmpresasRowChanged != null)) {
                    this.sy_VariablesEmpresasRowChanged(this, new sy_VariablesEmpresasRowChangeEvent(((sy_VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_VariablesEmpresasRowChanging != null)) {
                    this.sy_VariablesEmpresasRowChanging(this, new sy_VariablesEmpresasRowChangeEvent(((sy_VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_VariablesEmpresasRowDeleted != null)) {
                    this.sy_VariablesEmpresasRowDeleted(this, new sy_VariablesEmpresasRowChangeEvent(((sy_VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_VariablesEmpresasRowDeleting != null)) {
                    this.sy_VariablesEmpresasRowDeleting(this, new sy_VariablesEmpresasRowChangeEvent(((sy_VariablesEmpresasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_VariablesEmpresasRow(sy_VariablesEmpresasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_VariablesEmpresasRow : DataRow {
            
            private sy_VariablesEmpresasDataTable tablesy_VariablesEmpresas;
            
            internal sy_VariablesEmpresasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_VariablesEmpresas = ((sy_VariablesEmpresasDataTable)(this.Table));
            }
            
            public string IdVariable {
                get {
                    return ((string)(this[this.tablesy_VariablesEmpresas.IdVariableColumn]));
                }
                set {
                    this[this.tablesy_VariablesEmpresas.IdVariableColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    return ((long)(this[this.tablesy_VariablesEmpresas.IdEmpresaColumn]));
                }
                set {
                    this[this.tablesy_VariablesEmpresas.IdEmpresaColumn] = value;
                }
            }
            
            public string Valor {
                get {
                    try {
                        return ((string)(this[this.tablesy_VariablesEmpresas.ValorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_VariablesEmpresas.ValorColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_VariablesEmpresas.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_VariablesEmpresas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_VariablesEmpresas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_VariablesEmpresas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_VariablesEmpresas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_VariablesEmpresas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_VariablesEmpresas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_VariablesEmpresas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_VariablesEmpresas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_VariablesEmpresas.RowIdColumn] = value;
                }
            }
            
            public bool IsValorNull() {
                return this.IsNull(this.tablesy_VariablesEmpresas.ValorColumn);
            }
            
            public void SetValorNull() {
                this[this.tablesy_VariablesEmpresas.ValorColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_VariablesEmpresas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_VariablesEmpresas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_VariablesEmpresas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_VariablesEmpresas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_VariablesEmpresas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_VariablesEmpresas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_VariablesEmpresasRowChangeEvent : EventArgs {
            
            private sy_VariablesEmpresasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_VariablesEmpresasRowChangeEvent(sy_VariablesEmpresasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_VariablesEmpresasRow Row {
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
