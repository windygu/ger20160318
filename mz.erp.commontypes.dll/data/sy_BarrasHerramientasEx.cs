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
    public class sy_BarrasHerramientasExDataset : DataSet {
        
        private sy_BarrasHerramientasDataTable tablesy_BarrasHerramientas;
        
        public sy_BarrasHerramientasExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_BarrasHerramientasExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_BarrasHerramientas"] != null)) {
                    this.Tables.Add(new sy_BarrasHerramientasDataTable(ds.Tables["sy_BarrasHerramientas"]));
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
        public sy_BarrasHerramientasDataTable sy_BarrasHerramientas {
            get {
                return this.tablesy_BarrasHerramientas;
            }
        }
        
        public override DataSet Clone() {
            sy_BarrasHerramientasExDataset cln = ((sy_BarrasHerramientasExDataset)(base.Clone()));
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
            if ((ds.Tables["sy_BarrasHerramientas"] != null)) {
                this.Tables.Add(new sy_BarrasHerramientasDataTable(ds.Tables["sy_BarrasHerramientas"]));
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
            this.tablesy_BarrasHerramientas = ((sy_BarrasHerramientasDataTable)(this.Tables["sy_BarrasHerramientas"]));
            if ((this.tablesy_BarrasHerramientas != null)) {
                this.tablesy_BarrasHerramientas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_BarrasHerramientasExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_BarrasHerramientasEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_BarrasHerramientas = new sy_BarrasHerramientasDataTable();
            this.Tables.Add(this.tablesy_BarrasHerramientas);
        }
        
        private bool ShouldSerializesy_BarrasHerramientas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_BarrasHerramientasRowChangeEventHandler(object sender, sy_BarrasHerramientasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_BarrasHerramientasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdBarraHerramienta;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_BarrasHerramientasDataTable() : 
                    base("sy_BarrasHerramientas") {
                this.InitClass();
            }
            
            internal sy_BarrasHerramientasDataTable(DataTable table) : 
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
            
            internal DataColumn IdBarraHerramientaColumn {
                get {
                    return this.columnIdBarraHerramienta;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
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
            
            public sy_BarrasHerramientasRow this[int index] {
                get {
                    return ((sy_BarrasHerramientasRow)(this.Rows[index]));
                }
            }
            
            public event sy_BarrasHerramientasRowChangeEventHandler sy_BarrasHerramientasRowChanged;
            
            public event sy_BarrasHerramientasRowChangeEventHandler sy_BarrasHerramientasRowChanging;
            
            public event sy_BarrasHerramientasRowChangeEventHandler sy_BarrasHerramientasRowDeleted;
            
            public event sy_BarrasHerramientasRowChangeEventHandler sy_BarrasHerramientasRowDeleting;
            
            public void Addsy_BarrasHerramientasRow(sy_BarrasHerramientasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_BarrasHerramientasRow Addsy_BarrasHerramientasRow(long IdBarraHerramienta, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_BarrasHerramientasRow rowsy_BarrasHerramientasRow = ((sy_BarrasHerramientasRow)(this.NewRow()));
                rowsy_BarrasHerramientasRow.ItemArray = new object[] {
                        IdBarraHerramienta,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_BarrasHerramientasRow);
                return rowsy_BarrasHerramientasRow;
            }
            
            public sy_BarrasHerramientasRow FindByIdBarraHerramienta(long IdBarraHerramienta) {
                return ((sy_BarrasHerramientasRow)(this.Rows.Find(new object[] {
                            IdBarraHerramienta})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_BarrasHerramientasDataTable cln = ((sy_BarrasHerramientasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_BarrasHerramientasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdBarraHerramienta = this.Columns["IdBarraHerramienta"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdBarraHerramienta = new DataColumn("IdBarraHerramienta", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdBarraHerramienta);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
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
                this.Constraints.Add(new UniqueConstraint("sy_BarrasHerramientasExKey1", new DataColumn[] {
                                this.columnIdBarraHerramienta}, true));
                this.columnIdBarraHerramienta.AllowDBNull = false;
                this.columnIdBarraHerramienta.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_BarrasHerramientasRow Newsy_BarrasHerramientasRow() {
                return ((sy_BarrasHerramientasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_BarrasHerramientasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_BarrasHerramientasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_BarrasHerramientasRowChanged != null)) {
                    this.sy_BarrasHerramientasRowChanged(this, new sy_BarrasHerramientasRowChangeEvent(((sy_BarrasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_BarrasHerramientasRowChanging != null)) {
                    this.sy_BarrasHerramientasRowChanging(this, new sy_BarrasHerramientasRowChangeEvent(((sy_BarrasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_BarrasHerramientasRowDeleted != null)) {
                    this.sy_BarrasHerramientasRowDeleted(this, new sy_BarrasHerramientasRowChangeEvent(((sy_BarrasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_BarrasHerramientasRowDeleting != null)) {
                    this.sy_BarrasHerramientasRowDeleting(this, new sy_BarrasHerramientasRowChangeEvent(((sy_BarrasHerramientasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_BarrasHerramientasRow(sy_BarrasHerramientasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_BarrasHerramientasRow : DataRow {
            
            private sy_BarrasHerramientasDataTable tablesy_BarrasHerramientas;
            
            internal sy_BarrasHerramientasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_BarrasHerramientas = ((sy_BarrasHerramientasDataTable)(this.Table));
            }
            
            public long IdBarraHerramienta {
                get {
                    return ((long)(this[this.tablesy_BarrasHerramientas.IdBarraHerramientaColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientas.IdBarraHerramientaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tablesy_BarrasHerramientas.DescripcionColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientas.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_BarrasHerramientas.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_BarrasHerramientas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_BarrasHerramientas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_BarrasHerramientas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_BarrasHerramientas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_BarrasHerramientas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_BarrasHerramientas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_BarrasHerramientas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_BarrasHerramientas.RowIdColumn] = value;
                }
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_BarrasHerramientas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_BarrasHerramientas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_BarrasHerramientas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_BarrasHerramientas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_BarrasHerramientas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_BarrasHerramientas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_BarrasHerramientasRowChangeEvent : EventArgs {
            
            private sy_BarrasHerramientasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_BarrasHerramientasRowChangeEvent(sy_BarrasHerramientasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_BarrasHerramientasRow Row {
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
