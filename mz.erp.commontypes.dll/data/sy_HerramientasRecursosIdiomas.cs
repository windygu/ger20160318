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
    public class sy_HerramientasRecursosIdiomasDataset : DataSet {
        
        private sy_HerramientasRecursosIdiomasDataTable tablesy_HerramientasRecursosIdiomas;
        
        public sy_HerramientasRecursosIdiomasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_HerramientasRecursosIdiomasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_HerramientasRecursosIdiomas"] != null)) {
                    this.Tables.Add(new sy_HerramientasRecursosIdiomasDataTable(ds.Tables["sy_HerramientasRecursosIdiomas"]));
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
        public sy_HerramientasRecursosIdiomasDataTable sy_HerramientasRecursosIdiomas {
            get {
                return this.tablesy_HerramientasRecursosIdiomas;
            }
        }
        
        public override DataSet Clone() {
            sy_HerramientasRecursosIdiomasDataset cln = ((sy_HerramientasRecursosIdiomasDataset)(base.Clone()));
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
            if ((ds.Tables["sy_HerramientasRecursosIdiomas"] != null)) {
                this.Tables.Add(new sy_HerramientasRecursosIdiomasDataTable(ds.Tables["sy_HerramientasRecursosIdiomas"]));
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
            this.tablesy_HerramientasRecursosIdiomas = ((sy_HerramientasRecursosIdiomasDataTable)(this.Tables["sy_HerramientasRecursosIdiomas"]));
            if ((this.tablesy_HerramientasRecursosIdiomas != null)) {
                this.tablesy_HerramientasRecursosIdiomas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_HerramientasRecursosIdiomasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_HerramientasRecursosIdiomas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_HerramientasRecursosIdiomas = new sy_HerramientasRecursosIdiomasDataTable();
            this.Tables.Add(this.tablesy_HerramientasRecursosIdiomas);
        }
        
        private bool ShouldSerializesy_HerramientasRecursosIdiomas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_HerramientasRecursosIdiomasRowChangeEventHandler(object sender, sy_HerramientasRecursosIdiomasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_HerramientasRecursosIdiomasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdHerramienta;
            
            private DataColumn columnIdRecurso;
            
            private DataColumn columnIdIdioma;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal sy_HerramientasRecursosIdiomasDataTable() : 
                    base("sy_HerramientasRecursosIdiomas") {
                this.InitClass();
            }
            
            internal sy_HerramientasRecursosIdiomasDataTable(DataTable table) : 
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
            
            internal DataColumn IdHerramientaColumn {
                get {
                    return this.columnIdHerramienta;
                }
            }
            
            internal DataColumn IdRecursoColumn {
                get {
                    return this.columnIdRecurso;
                }
            }
            
            internal DataColumn IdIdiomaColumn {
                get {
                    return this.columnIdIdioma;
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
            
            public sy_HerramientasRecursosIdiomasRow this[int index] {
                get {
                    return ((sy_HerramientasRecursosIdiomasRow)(this.Rows[index]));
                }
            }
            
            public event sy_HerramientasRecursosIdiomasRowChangeEventHandler sy_HerramientasRecursosIdiomasRowChanged;
            
            public event sy_HerramientasRecursosIdiomasRowChangeEventHandler sy_HerramientasRecursosIdiomasRowChanging;
            
            public event sy_HerramientasRecursosIdiomasRowChangeEventHandler sy_HerramientasRecursosIdiomasRowDeleted;
            
            public event sy_HerramientasRecursosIdiomasRowChangeEventHandler sy_HerramientasRecursosIdiomasRowDeleting;
            
            public void Addsy_HerramientasRecursosIdiomasRow(sy_HerramientasRecursosIdiomasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_HerramientasRecursosIdiomasRow Addsy_HerramientasRecursosIdiomasRow(long IdHerramienta, long IdRecurso, long IdIdioma, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                sy_HerramientasRecursosIdiomasRow rowsy_HerramientasRecursosIdiomasRow = ((sy_HerramientasRecursosIdiomasRow)(this.NewRow()));
                rowsy_HerramientasRecursosIdiomasRow.ItemArray = new object[] {
                        IdHerramienta,
                        IdRecurso,
                        IdIdioma,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowsy_HerramientasRecursosIdiomasRow);
                return rowsy_HerramientasRecursosIdiomasRow;
            }
            
            public sy_HerramientasRecursosIdiomasRow FindByIdHerramientaIdRecursoIdIdioma(long IdHerramienta, long IdRecurso, long IdIdioma) {
                return ((sy_HerramientasRecursosIdiomasRow)(this.Rows.Find(new object[] {
                            IdHerramienta,
                            IdRecurso,
                            IdIdioma})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_HerramientasRecursosIdiomasDataTable cln = ((sy_HerramientasRecursosIdiomasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_HerramientasRecursosIdiomasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdHerramienta = this.Columns["IdHerramienta"];
                this.columnIdRecurso = this.Columns["IdRecurso"];
                this.columnIdIdioma = this.Columns["IdIdioma"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdHerramienta = new DataColumn("IdHerramienta", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdHerramienta);
                this.columnIdRecurso = new DataColumn("IdRecurso", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRecurso);
                this.columnIdIdioma = new DataColumn("IdIdioma", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdIdioma);
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
                this.Constraints.Add(new UniqueConstraint("sy_HerramientasRecursosIdiomasKey1", new DataColumn[] {
                                this.columnIdHerramienta,
                                this.columnIdRecurso,
                                this.columnIdIdioma}, true));
                this.columnIdHerramienta.AllowDBNull = false;
                this.columnIdRecurso.AllowDBNull = false;
                this.columnIdIdioma.AllowDBNull = false;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_HerramientasRecursosIdiomasRow Newsy_HerramientasRecursosIdiomasRow() {
                return ((sy_HerramientasRecursosIdiomasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_HerramientasRecursosIdiomasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_HerramientasRecursosIdiomasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_HerramientasRecursosIdiomasRowChanged != null)) {
                    this.sy_HerramientasRecursosIdiomasRowChanged(this, new sy_HerramientasRecursosIdiomasRowChangeEvent(((sy_HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_HerramientasRecursosIdiomasRowChanging != null)) {
                    this.sy_HerramientasRecursosIdiomasRowChanging(this, new sy_HerramientasRecursosIdiomasRowChangeEvent(((sy_HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_HerramientasRecursosIdiomasRowDeleted != null)) {
                    this.sy_HerramientasRecursosIdiomasRowDeleted(this, new sy_HerramientasRecursosIdiomasRowChangeEvent(((sy_HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_HerramientasRecursosIdiomasRowDeleting != null)) {
                    this.sy_HerramientasRecursosIdiomasRowDeleting(this, new sy_HerramientasRecursosIdiomasRowChangeEvent(((sy_HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_HerramientasRecursosIdiomasRow(sy_HerramientasRecursosIdiomasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_HerramientasRecursosIdiomasRow : DataRow {
            
            private sy_HerramientasRecursosIdiomasDataTable tablesy_HerramientasRecursosIdiomas;
            
            internal sy_HerramientasRecursosIdiomasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_HerramientasRecursosIdiomas = ((sy_HerramientasRecursosIdiomasDataTable)(this.Table));
            }
            
            public long IdHerramienta {
                get {
                    return ((long)(this[this.tablesy_HerramientasRecursosIdiomas.IdHerramientaColumn]));
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.IdHerramientaColumn] = value;
                }
            }
            
            public long IdRecurso {
                get {
                    return ((long)(this[this.tablesy_HerramientasRecursosIdiomas.IdRecursoColumn]));
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.IdRecursoColumn] = value;
                }
            }
            
            public long IdIdioma {
                get {
                    return ((long)(this[this.tablesy_HerramientasRecursosIdiomas.IdIdiomaColumn]));
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.IdIdiomaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_HerramientasRecursosIdiomas.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_HerramientasRecursosIdiomas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_HerramientasRecursosIdiomas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_HerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_HerramientasRecursosIdiomas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_HerramientasRecursosIdiomas.RowIdColumn] = value;
                }
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_HerramientasRecursosIdiomas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_HerramientasRecursosIdiomas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_HerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_HerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_HerramientasRecursosIdiomas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_HerramientasRecursosIdiomas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_HerramientasRecursosIdiomasRowChangeEvent : EventArgs {
            
            private sy_HerramientasRecursosIdiomasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_HerramientasRecursosIdiomasRowChangeEvent(sy_HerramientasRecursosIdiomasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_HerramientasRecursosIdiomasRow Row {
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
