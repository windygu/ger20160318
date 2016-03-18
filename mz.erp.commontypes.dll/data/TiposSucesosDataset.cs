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
    public class TiposSucesosDataset : DataSet {
        
        private TiposSucesosDataTable tableTiposSucesos;
        
        public TiposSucesosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected TiposSucesosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["TiposSucesos"] != null)) {
                    this.Tables.Add(new TiposSucesosDataTable(ds.Tables["TiposSucesos"]));
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
        public TiposSucesosDataTable TiposSucesos {
            get {
                return this.tableTiposSucesos;
            }
        }
        
        public override DataSet Clone() {
            TiposSucesosDataset cln = ((TiposSucesosDataset)(base.Clone()));
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
            if ((ds.Tables["TiposSucesos"] != null)) {
                this.Tables.Add(new TiposSucesosDataTable(ds.Tables["TiposSucesos"]));
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
            this.tableTiposSucesos = ((TiposSucesosDataTable)(this.Tables["TiposSucesos"]));
            if ((this.tableTiposSucesos != null)) {
                this.tableTiposSucesos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "TiposSucesosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/TiposSucesosDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableTiposSucesos = new TiposSucesosDataTable();
            this.Tables.Add(this.tableTiposSucesos);
        }
        
        private bool ShouldSerializeTiposSucesos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void TiposSucesosRowChangeEventHandler(object sender, TiposSucesosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposSucesosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoSuceso;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal TiposSucesosDataTable() : 
                    base("TiposSucesos") {
                this.InitClass();
            }
            
            internal TiposSucesosDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoSucesoColumn {
                get {
                    return this.columnIdTipoSuceso;
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
            
            public TiposSucesosRow this[int index] {
                get {
                    return ((TiposSucesosRow)(this.Rows[index]));
                }
            }
            
            public event TiposSucesosRowChangeEventHandler TiposSucesosRowChanged;
            
            public event TiposSucesosRowChangeEventHandler TiposSucesosRowChanging;
            
            public event TiposSucesosRowChangeEventHandler TiposSucesosRowDeleted;
            
            public event TiposSucesosRowChangeEventHandler TiposSucesosRowDeleting;
            
            public void AddTiposSucesosRow(TiposSucesosRow row) {
                this.Rows.Add(row);
            }
            
            public TiposSucesosRow AddTiposSucesosRow(long IdTipoSuceso, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                TiposSucesosRow rowTiposSucesosRow = ((TiposSucesosRow)(this.NewRow()));
                rowTiposSucesosRow.ItemArray = new object[] {
                        IdTipoSuceso,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowTiposSucesosRow);
                return rowTiposSucesosRow;
            }
            
            public TiposSucesosRow FindByIdTipoSuceso(long IdTipoSuceso) {
                return ((TiposSucesosRow)(this.Rows.Find(new object[] {
                            IdTipoSuceso})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                TiposSucesosDataTable cln = ((TiposSucesosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new TiposSucesosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoSuceso = this.Columns["IdTipoSuceso"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoSuceso = new DataColumn("IdTipoSuceso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoSuceso);
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
                this.Constraints.Add(new UniqueConstraint("TiposSucesosDatasetKey1", new DataColumn[] {
                                this.columnIdTipoSuceso}, true));
                this.columnIdTipoSuceso.AllowDBNull = false;
                this.columnIdTipoSuceso.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public TiposSucesosRow NewTiposSucesosRow() {
                return ((TiposSucesosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new TiposSucesosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(TiposSucesosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.TiposSucesosRowChanged != null)) {
                    this.TiposSucesosRowChanged(this, new TiposSucesosRowChangeEvent(((TiposSucesosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.TiposSucesosRowChanging != null)) {
                    this.TiposSucesosRowChanging(this, new TiposSucesosRowChangeEvent(((TiposSucesosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.TiposSucesosRowDeleted != null)) {
                    this.TiposSucesosRowDeleted(this, new TiposSucesosRowChangeEvent(((TiposSucesosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.TiposSucesosRowDeleting != null)) {
                    this.TiposSucesosRowDeleting(this, new TiposSucesosRowChangeEvent(((TiposSucesosRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveTiposSucesosRow(TiposSucesosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposSucesosRow : DataRow {
            
            private TiposSucesosDataTable tableTiposSucesos;
            
            internal TiposSucesosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableTiposSucesos = ((TiposSucesosDataTable)(this.Table));
            }
            
            public long IdTipoSuceso {
                get {
                    return ((long)(this[this.tableTiposSucesos.IdTipoSucesoColumn]));
                }
                set {
                    this[this.tableTiposSucesos.IdTipoSucesoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tableTiposSucesos.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposSucesos.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableTiposSucesos.FechaCreacionColumn]));
                }
                set {
                    this[this.tableTiposSucesos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableTiposSucesos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableTiposSucesos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableTiposSucesos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposSucesos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableTiposSucesos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposSucesos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableTiposSucesos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableTiposSucesos.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tableTiposSucesos.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tableTiposSucesos.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableTiposSucesos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableTiposSucesos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableTiposSucesos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableTiposSucesos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableTiposSucesos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableTiposSucesos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class TiposSucesosRowChangeEvent : EventArgs {
            
            private TiposSucesosRow eventRow;
            
            private DataRowAction eventAction;
            
            public TiposSucesosRowChangeEvent(TiposSucesosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public TiposSucesosRow Row {
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