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
    public class HerramientasRecursosIdiomasDataset : DataSet {
        
        private HerramientasRecursosIdiomasDataTable tableHerramientasRecursosIdiomas;
        
        public HerramientasRecursosIdiomasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected HerramientasRecursosIdiomasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["HerramientasRecursosIdiomas"] != null)) {
                    this.Tables.Add(new HerramientasRecursosIdiomasDataTable(ds.Tables["HerramientasRecursosIdiomas"]));
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
        public HerramientasRecursosIdiomasDataTable HerramientasRecursosIdiomas {
            get {
                return this.tableHerramientasRecursosIdiomas;
            }
        }
        
        public override DataSet Clone() {
            HerramientasRecursosIdiomasDataset cln = ((HerramientasRecursosIdiomasDataset)(base.Clone()));
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
            if ((ds.Tables["HerramientasRecursosIdiomas"] != null)) {
                this.Tables.Add(new HerramientasRecursosIdiomasDataTable(ds.Tables["HerramientasRecursosIdiomas"]));
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
            this.tableHerramientasRecursosIdiomas = ((HerramientasRecursosIdiomasDataTable)(this.Tables["HerramientasRecursosIdiomas"]));
            if ((this.tableHerramientasRecursosIdiomas != null)) {
                this.tableHerramientasRecursosIdiomas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "HerramientasRecursosIdiomasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/HerramientasRecursosIdiomasDataset.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tableHerramientasRecursosIdiomas = new HerramientasRecursosIdiomasDataTable();
            this.Tables.Add(this.tableHerramientasRecursosIdiomas);
        }
        
        private bool ShouldSerializeHerramientasRecursosIdiomas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void HerramientasRecursosIdiomasRowChangeEventHandler(object sender, HerramientasRecursosIdiomasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HerramientasRecursosIdiomasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdHerramienta;
            
            private DataColumn columnIdRecurso;
            
            private DataColumn columnIdIdioma;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal HerramientasRecursosIdiomasDataTable() : 
                    base("HerramientasRecursosIdiomas") {
                this.InitClass();
            }
            
            internal HerramientasRecursosIdiomasDataTable(DataTable table) : 
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
            
            public HerramientasRecursosIdiomasRow this[int index] {
                get {
                    return ((HerramientasRecursosIdiomasRow)(this.Rows[index]));
                }
            }
            
            public event HerramientasRecursosIdiomasRowChangeEventHandler HerramientasRecursosIdiomasRowChanged;
            
            public event HerramientasRecursosIdiomasRowChangeEventHandler HerramientasRecursosIdiomasRowChanging;
            
            public event HerramientasRecursosIdiomasRowChangeEventHandler HerramientasRecursosIdiomasRowDeleted;
            
            public event HerramientasRecursosIdiomasRowChangeEventHandler HerramientasRecursosIdiomasRowDeleting;
            
            public void AddHerramientasRecursosIdiomasRow(HerramientasRecursosIdiomasRow row) {
                this.Rows.Add(row);
            }
            
            public HerramientasRecursosIdiomasRow AddHerramientasRecursosIdiomasRow(long IdHerramienta, long IdRecurso, long IdIdioma, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                HerramientasRecursosIdiomasRow rowHerramientasRecursosIdiomasRow = ((HerramientasRecursosIdiomasRow)(this.NewRow()));
                rowHerramientasRecursosIdiomasRow.ItemArray = new object[] {
                        IdHerramienta,
                        IdRecurso,
                        IdIdioma,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowHerramientasRecursosIdiomasRow);
                return rowHerramientasRecursosIdiomasRow;
            }
            
            public HerramientasRecursosIdiomasRow FindByIdHerramientaIdRecursoIdIdioma(long IdHerramienta, long IdRecurso, long IdIdioma) {
                return ((HerramientasRecursosIdiomasRow)(this.Rows.Find(new object[] {
                            IdHerramienta,
                            IdRecurso,
                            IdIdioma})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                HerramientasRecursosIdiomasDataTable cln = ((HerramientasRecursosIdiomasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new HerramientasRecursosIdiomasDataTable();
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
                this.Constraints.Add(new UniqueConstraint("HerramientasRecursosIdiomasDatasetKey1", new DataColumn[] {
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
            
            public HerramientasRecursosIdiomasRow NewHerramientasRecursosIdiomasRow() {
                return ((HerramientasRecursosIdiomasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new HerramientasRecursosIdiomasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(HerramientasRecursosIdiomasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.HerramientasRecursosIdiomasRowChanged != null)) {
                    this.HerramientasRecursosIdiomasRowChanged(this, new HerramientasRecursosIdiomasRowChangeEvent(((HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.HerramientasRecursosIdiomasRowChanging != null)) {
                    this.HerramientasRecursosIdiomasRowChanging(this, new HerramientasRecursosIdiomasRowChangeEvent(((HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.HerramientasRecursosIdiomasRowDeleted != null)) {
                    this.HerramientasRecursosIdiomasRowDeleted(this, new HerramientasRecursosIdiomasRowChangeEvent(((HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.HerramientasRecursosIdiomasRowDeleting != null)) {
                    this.HerramientasRecursosIdiomasRowDeleting(this, new HerramientasRecursosIdiomasRowChangeEvent(((HerramientasRecursosIdiomasRow)(e.Row)), e.Action));
                }
            }
            
            public void RemoveHerramientasRecursosIdiomasRow(HerramientasRecursosIdiomasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HerramientasRecursosIdiomasRow : DataRow {
            
            private HerramientasRecursosIdiomasDataTable tableHerramientasRecursosIdiomas;
            
            internal HerramientasRecursosIdiomasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tableHerramientasRecursosIdiomas = ((HerramientasRecursosIdiomasDataTable)(this.Table));
            }
            
            public long IdHerramienta {
                get {
                    return ((long)(this[this.tableHerramientasRecursosIdiomas.IdHerramientaColumn]));
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.IdHerramientaColumn] = value;
                }
            }
            
            public long IdRecurso {
                get {
                    return ((long)(this[this.tableHerramientasRecursosIdiomas.IdRecursoColumn]));
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.IdRecursoColumn] = value;
                }
            }
            
            public long IdIdioma {
                get {
                    return ((long)(this[this.tableHerramientasRecursosIdiomas.IdIdiomaColumn]));
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.IdIdiomaColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tableHerramientasRecursosIdiomas.FechaCreacionColumn]));
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tableHerramientasRecursosIdiomas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tableHerramientasRecursosIdiomas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tableHerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tableHerramientasRecursosIdiomas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tableHerramientasRecursosIdiomas.RowIdColumn] = value;
                }
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tableHerramientasRecursosIdiomas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tableHerramientasRecursosIdiomas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tableHerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tableHerramientasRecursosIdiomas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tableHerramientasRecursosIdiomas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tableHerramientasRecursosIdiomas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class HerramientasRecursosIdiomasRowChangeEvent : EventArgs {
            
            private HerramientasRecursosIdiomasRow eventRow;
            
            private DataRowAction eventAction;
            
            public HerramientasRecursosIdiomasRowChangeEvent(HerramientasRecursosIdiomasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public HerramientasRecursosIdiomasRow Row {
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
