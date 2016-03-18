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
    public class sy_TiposRecursosExDataset : DataSet {
        
        private sy_TiposRecursosDataTable tablesy_TiposRecursos;
        
        public sy_TiposRecursosExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_TiposRecursosExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_TiposRecursos"] != null)) {
                    this.Tables.Add(new sy_TiposRecursosDataTable(ds.Tables["sy_TiposRecursos"]));
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
        public sy_TiposRecursosDataTable sy_TiposRecursos {
            get {
                return this.tablesy_TiposRecursos;
            }
        }
        
        public override DataSet Clone() {
            sy_TiposRecursosExDataset cln = ((sy_TiposRecursosExDataset)(base.Clone()));
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
            if ((ds.Tables["sy_TiposRecursos"] != null)) {
                this.Tables.Add(new sy_TiposRecursosDataTable(ds.Tables["sy_TiposRecursos"]));
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
            this.tablesy_TiposRecursos = ((sy_TiposRecursosDataTable)(this.Tables["sy_TiposRecursos"]));
            if ((this.tablesy_TiposRecursos != null)) {
                this.tablesy_TiposRecursos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_TiposRecursosExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_TiposRecursosEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_TiposRecursos = new sy_TiposRecursosDataTable();
            this.Tables.Add(this.tablesy_TiposRecursos);
        }
        
        private bool ShouldSerializesy_TiposRecursos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_TiposRecursosRowChangeEventHandler(object sender, sy_TiposRecursosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_TiposRecursosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoRecurso;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_TiposRecursosDataTable() : 
                    base("sy_TiposRecursos") {
                this.InitClass();
            }
            
            internal sy_TiposRecursosDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoRecursoColumn {
                get {
                    return this.columnIdTipoRecurso;
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
            
            public sy_TiposRecursosRow this[int index] {
                get {
                    return ((sy_TiposRecursosRow)(this.Rows[index]));
                }
            }
            
            public event sy_TiposRecursosRowChangeEventHandler sy_TiposRecursosRowChanged;
            
            public event sy_TiposRecursosRowChangeEventHandler sy_TiposRecursosRowChanging;
            
            public event sy_TiposRecursosRowChangeEventHandler sy_TiposRecursosRowDeleted;
            
            public event sy_TiposRecursosRowChangeEventHandler sy_TiposRecursosRowDeleting;
            
            public void Addsy_TiposRecursosRow(sy_TiposRecursosRow row) {
                this.Rows.Add(row);
            }
            
            public sy_TiposRecursosRow Addsy_TiposRecursosRow(long IdTipoRecurso, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_TiposRecursosRow rowsy_TiposRecursosRow = ((sy_TiposRecursosRow)(this.NewRow()));
                rowsy_TiposRecursosRow.ItemArray = new object[] {
                        IdTipoRecurso,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_TiposRecursosRow);
                return rowsy_TiposRecursosRow;
            }
            
            public sy_TiposRecursosRow FindByIdTipoRecurso(long IdTipoRecurso) {
                return ((sy_TiposRecursosRow)(this.Rows.Find(new object[] {
                            IdTipoRecurso})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_TiposRecursosDataTable cln = ((sy_TiposRecursosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_TiposRecursosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoRecurso = this.Columns["IdTipoRecurso"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdTipoRecurso = new DataColumn("IdTipoRecurso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoRecurso);
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
                this.Constraints.Add(new UniqueConstraint("sy_TiposRecursosExKey1", new DataColumn[] {
                                this.columnIdTipoRecurso}, true));
                this.columnIdTipoRecurso.AllowDBNull = false;
                this.columnIdTipoRecurso.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_TiposRecursosRow Newsy_TiposRecursosRow() {
                return ((sy_TiposRecursosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_TiposRecursosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_TiposRecursosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_TiposRecursosRowChanged != null)) {
                    this.sy_TiposRecursosRowChanged(this, new sy_TiposRecursosRowChangeEvent(((sy_TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_TiposRecursosRowChanging != null)) {
                    this.sy_TiposRecursosRowChanging(this, new sy_TiposRecursosRowChangeEvent(((sy_TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_TiposRecursosRowDeleted != null)) {
                    this.sy_TiposRecursosRowDeleted(this, new sy_TiposRecursosRowChangeEvent(((sy_TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_TiposRecursosRowDeleting != null)) {
                    this.sy_TiposRecursosRowDeleting(this, new sy_TiposRecursosRowChangeEvent(((sy_TiposRecursosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_TiposRecursosRow(sy_TiposRecursosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_TiposRecursosRow : DataRow {
            
            private sy_TiposRecursosDataTable tablesy_TiposRecursos;
            
            internal sy_TiposRecursosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_TiposRecursos = ((sy_TiposRecursosDataTable)(this.Table));
            }
            
            public long IdTipoRecurso {
                get {
                    return ((long)(this[this.tablesy_TiposRecursos.IdTipoRecursoColumn]));
                }
                set {
                    this[this.tablesy_TiposRecursos.IdTipoRecursoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablesy_TiposRecursos.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposRecursos.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_TiposRecursos.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_TiposRecursos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_TiposRecursos.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_TiposRecursos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_TiposRecursos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposRecursos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_TiposRecursos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposRecursos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_TiposRecursos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_TiposRecursos.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablesy_TiposRecursos.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablesy_TiposRecursos.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_TiposRecursos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_TiposRecursos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_TiposRecursos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_TiposRecursos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_TiposRecursos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_TiposRecursos.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_TiposRecursosRowChangeEvent : EventArgs {
            
            private sy_TiposRecursosRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_TiposRecursosRowChangeEvent(sy_TiposRecursosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_TiposRecursosRow Row {
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
