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
    public class twf_ValidacionesDataset : DataSet {
        
        private twf_ValidacionesDataTable tabletwf_Validaciones;
        
        public twf_ValidacionesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected twf_ValidacionesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["twf_Validaciones"] != null)) {
                    this.Tables.Add(new twf_ValidacionesDataTable(ds.Tables["twf_Validaciones"]));
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
        public twf_ValidacionesDataTable twf_Validaciones {
            get {
                return this.tabletwf_Validaciones;
            }
        }
        
        public override DataSet Clone() {
            twf_ValidacionesDataset cln = ((twf_ValidacionesDataset)(base.Clone()));
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
            if ((ds.Tables["twf_Validaciones"] != null)) {
                this.Tables.Add(new twf_ValidacionesDataTable(ds.Tables["twf_Validaciones"]));
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
            this.tabletwf_Validaciones = ((twf_ValidacionesDataTable)(this.Tables["twf_Validaciones"]));
            if ((this.tabletwf_Validaciones != null)) {
                this.tabletwf_Validaciones.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "twf_ValidacionesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/twf_Validaciones.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletwf_Validaciones = new twf_ValidacionesDataTable();
            this.Tables.Add(this.tabletwf_Validaciones);
        }
        
        private bool ShouldSerializetwf_Validaciones() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void twf_ValidacionesRowChangeEventHandler(object sender, twf_ValidacionesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ValidacionesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdValidacion;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFormula;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnObservaciones;
            
            internal twf_ValidacionesDataTable() : 
                    base("twf_Validaciones") {
                this.InitClass();
            }
            
            internal twf_ValidacionesDataTable(DataTable table) : 
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
            
            internal DataColumn IdValidacionColumn {
                get {
                    return this.columnIdValidacion;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn FormulaColumn {
                get {
                    return this.columnFormula;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
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
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
                }
            }
            
            public twf_ValidacionesRow this[int index] {
                get {
                    return ((twf_ValidacionesRow)(this.Rows[index]));
                }
            }
            
            public event twf_ValidacionesRowChangeEventHandler twf_ValidacionesRowChanged;
            
            public event twf_ValidacionesRowChangeEventHandler twf_ValidacionesRowChanging;
            
            public event twf_ValidacionesRowChangeEventHandler twf_ValidacionesRowDeleted;
            
            public event twf_ValidacionesRowChangeEventHandler twf_ValidacionesRowDeleting;
            
            public void Addtwf_ValidacionesRow(twf_ValidacionesRow row) {
                this.Rows.Add(row);
            }
            
            public twf_ValidacionesRow Addtwf_ValidacionesRow(long IdValidacion, string Descripcion, string Formula, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, string Observaciones) {
                twf_ValidacionesRow rowtwf_ValidacionesRow = ((twf_ValidacionesRow)(this.NewRow()));
                rowtwf_ValidacionesRow.ItemArray = new object[] {
                        IdValidacion,
                        Descripcion,
                        Formula,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        Observaciones};
                this.Rows.Add(rowtwf_ValidacionesRow);
                return rowtwf_ValidacionesRow;
            }
            
            public twf_ValidacionesRow FindByIdValidacion(long IdValidacion) {
                return ((twf_ValidacionesRow)(this.Rows.Find(new object[] {
                            IdValidacion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                twf_ValidacionesDataTable cln = ((twf_ValidacionesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new twf_ValidacionesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdValidacion = this.Columns["IdValidacion"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFormula = this.Columns["Formula"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnObservaciones = this.Columns["Observaciones"];
            }
            
            private void InitClass() {
                this.columnIdValidacion = new DataColumn("IdValidacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdValidacion);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnFormula = new DataColumn("Formula", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFormula);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
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
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
                this.Constraints.Add(new UniqueConstraint("twf_ValidacionesKey1", new DataColumn[] {
                                this.columnIdValidacion}, true));
                this.columnIdValidacion.AllowDBNull = false;
                this.columnIdValidacion.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public twf_ValidacionesRow Newtwf_ValidacionesRow() {
                return ((twf_ValidacionesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new twf_ValidacionesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(twf_ValidacionesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.twf_ValidacionesRowChanged != null)) {
                    this.twf_ValidacionesRowChanged(this, new twf_ValidacionesRowChangeEvent(((twf_ValidacionesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.twf_ValidacionesRowChanging != null)) {
                    this.twf_ValidacionesRowChanging(this, new twf_ValidacionesRowChangeEvent(((twf_ValidacionesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.twf_ValidacionesRowDeleted != null)) {
                    this.twf_ValidacionesRowDeleted(this, new twf_ValidacionesRowChangeEvent(((twf_ValidacionesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.twf_ValidacionesRowDeleting != null)) {
                    this.twf_ValidacionesRowDeleting(this, new twf_ValidacionesRowChangeEvent(((twf_ValidacionesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetwf_ValidacionesRow(twf_ValidacionesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ValidacionesRow : DataRow {
            
            private twf_ValidacionesDataTable tabletwf_Validaciones;
            
            internal twf_ValidacionesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletwf_Validaciones = ((twf_ValidacionesDataTable)(this.Table));
            }
            
            public long IdValidacion {
                get {
                    return ((long)(this[this.tabletwf_Validaciones.IdValidacionColumn]));
                }
                set {
                    this[this.tabletwf_Validaciones.IdValidacionColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletwf_Validaciones.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.DescripcionColumn] = value;
                }
            }
            
            public string Formula {
                get {
                    try {
                        return ((string)(this[this.tabletwf_Validaciones.FormulaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.FormulaColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_Validaciones.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tabletwf_Validaciones.FechaCreacionColumn]));
                }
                set {
                    this[this.tabletwf_Validaciones.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tabletwf_Validaciones.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tabletwf_Validaciones.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletwf_Validaciones.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletwf_Validaciones.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletwf_Validaciones.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.RowIdColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletwf_Validaciones.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletwf_Validaciones.ObservacionesColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletwf_Validaciones.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletwf_Validaciones.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFormulaNull() {
                return this.IsNull(this.tabletwf_Validaciones.FormulaColumn);
            }
            
            public void SetFormulaNull() {
                this[this.tabletwf_Validaciones.FormulaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tabletwf_Validaciones.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tabletwf_Validaciones.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_Validaciones.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletwf_Validaciones.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletwf_Validaciones.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletwf_Validaciones.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletwf_Validaciones.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletwf_Validaciones.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletwf_Validaciones.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletwf_Validaciones.ObservacionesColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class twf_ValidacionesRowChangeEvent : EventArgs {
            
            private twf_ValidacionesRow eventRow;
            
            private DataRowAction eventAction;
            
            public twf_ValidacionesRowChangeEvent(twf_ValidacionesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public twf_ValidacionesRow Row {
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
