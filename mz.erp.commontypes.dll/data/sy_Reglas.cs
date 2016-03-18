﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2407
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
    public class sy_ReglasDataset : DataSet {
        
        private sy_ReglasDataTable tablesy_Reglas;
        
        public sy_ReglasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_ReglasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_Reglas"] != null)) {
                    this.Tables.Add(new sy_ReglasDataTable(ds.Tables["sy_Reglas"]));
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
        public sy_ReglasDataTable sy_Reglas {
            get {
                return this.tablesy_Reglas;
            }
        }
        
        public override DataSet Clone() {
            sy_ReglasDataset cln = ((sy_ReglasDataset)(base.Clone()));
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
            if ((ds.Tables["sy_Reglas"] != null)) {
                this.Tables.Add(new sy_ReglasDataTable(ds.Tables["sy_Reglas"]));
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
            this.tablesy_Reglas = ((sy_ReglasDataTable)(this.Tables["sy_Reglas"]));
            if ((this.tablesy_Reglas != null)) {
                this.tablesy_Reglas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_ReglasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_Reglas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_Reglas = new sy_ReglasDataTable();
            this.Tables.Add(this.tablesy_Reglas);
        }
        
        private bool ShouldSerializesy_Reglas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_ReglasRowChangeEventHandler(object sender, sy_ReglasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_ReglasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdRegla;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnComentario;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_ReglasDataTable() : 
                    base("sy_Reglas") {
                this.InitClass();
            }
            
            internal sy_ReglasDataTable(DataTable table) : 
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
            
            internal DataColumn IdReglaColumn {
                get {
                    return this.columnIdRegla;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ComentarioColumn {
                get {
                    return this.columnComentario;
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
            
            public sy_ReglasRow this[int index] {
                get {
                    return ((sy_ReglasRow)(this.Rows[index]));
                }
            }
            
            public event sy_ReglasRowChangeEventHandler sy_ReglasRowChanged;
            
            public event sy_ReglasRowChangeEventHandler sy_ReglasRowChanging;
            
            public event sy_ReglasRowChangeEventHandler sy_ReglasRowDeleted;
            
            public event sy_ReglasRowChangeEventHandler sy_ReglasRowDeleting;
            
            public void Addsy_ReglasRow(sy_ReglasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_ReglasRow Addsy_ReglasRow(string IdRegla, string Descripcion, string Comentario, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_ReglasRow rowsy_ReglasRow = ((sy_ReglasRow)(this.NewRow()));
                rowsy_ReglasRow.ItemArray = new object[] {
                        IdRegla,
                        Descripcion,
                        Comentario,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_ReglasRow);
                return rowsy_ReglasRow;
            }
            
            public sy_ReglasRow FindByIdRegla(string IdRegla) {
                return ((sy_ReglasRow)(this.Rows.Find(new object[] {
                            IdRegla})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_ReglasDataTable cln = ((sy_ReglasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_ReglasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdRegla = this.Columns["IdRegla"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnComentario = this.Columns["Comentario"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdRegla = new DataColumn("IdRegla", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRegla);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnComentario = new DataColumn("Comentario", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnComentario);
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
                this.Constraints.Add(new UniqueConstraint("sy_ReglasKey1", new DataColumn[] {
                                this.columnIdRegla}, true));
                this.columnIdRegla.AllowDBNull = false;
                this.columnIdRegla.Unique = true;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_ReglasRow Newsy_ReglasRow() {
                return ((sy_ReglasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_ReglasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_ReglasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_ReglasRowChanged != null)) {
                    this.sy_ReglasRowChanged(this, new sy_ReglasRowChangeEvent(((sy_ReglasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_ReglasRowChanging != null)) {
                    this.sy_ReglasRowChanging(this, new sy_ReglasRowChangeEvent(((sy_ReglasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_ReglasRowDeleted != null)) {
                    this.sy_ReglasRowDeleted(this, new sy_ReglasRowChangeEvent(((sy_ReglasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_ReglasRowDeleting != null)) {
                    this.sy_ReglasRowDeleting(this, new sy_ReglasRowChangeEvent(((sy_ReglasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_ReglasRow(sy_ReglasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_ReglasRow : DataRow {
            
            private sy_ReglasDataTable tablesy_Reglas;
            
            internal sy_ReglasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_Reglas = ((sy_ReglasDataTable)(this.Table));
            }
            
            public string IdRegla {
                get {
                    return ((string)(this[this.tablesy_Reglas.IdReglaColumn]));
                }
                set {
                    this[this.tablesy_Reglas.IdReglaColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablesy_Reglas.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Reglas.DescripcionColumn] = value;
                }
            }
            
            public string Comentario {
                get {
                    try {
                        return ((string)(this[this.tablesy_Reglas.ComentarioColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Reglas.ComentarioColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablesy_Reglas.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Reglas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_Reglas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_Reglas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_Reglas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Reglas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Reglas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Reglas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_Reglas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Reglas.RowIdColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablesy_Reglas.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablesy_Reglas.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsComentarioNull() {
                return this.IsNull(this.tablesy_Reglas.ComentarioColumn);
            }
            
            public void SetComentarioNull() {
                this[this.tablesy_Reglas.ComentarioColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablesy_Reglas.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablesy_Reglas.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Reglas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_Reglas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Reglas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_Reglas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_Reglas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_Reglas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_ReglasRowChangeEvent : EventArgs {
            
            private sy_ReglasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_ReglasRowChangeEvent(sy_ReglasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_ReglasRow Row {
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
