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
    public class Prueba2Dataset : DataSet {
        
        private st_FilaDataTable tablest_Fila;
        
        public Prueba2Dataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected Prueba2Dataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["st_Fila"] != null)) {
                    this.Tables.Add(new st_FilaDataTable(ds.Tables["st_Fila"]));
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
        public st_FilaDataTable st_Fila {
            get {
                return this.tablest_Fila;
            }
        }
        
        public override DataSet Clone() {
            Prueba2Dataset cln = ((Prueba2Dataset)(base.Clone()));
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
            if ((ds.Tables["st_Fila"] != null)) {
                this.Tables.Add(new st_FilaDataTable(ds.Tables["st_Fila"]));
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
            this.tablest_Fila = ((st_FilaDataTable)(this.Tables["st_Fila"]));
            if ((this.tablest_Fila != null)) {
                this.tablest_Fila.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "Prueba2Dataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/Prueba2.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablest_Fila = new st_FilaDataTable();
            this.Tables.Add(this.tablest_Fila);
        }
        
        private bool ShouldSerializest_Fila() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void st_FilaRowChangeEventHandler(object sender, st_FilaRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_FilaDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdDeposito;
            
            private DataColumn columnIdSeccion;
            
            private DataColumn columnIdEstanteria;
            
            private DataColumn columnIdFila;
            
            private DataColumn columnCodigo;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            internal st_FilaDataTable() : 
                    base("st_Fila") {
                this.InitClass();
            }
            
            internal st_FilaDataTable(DataTable table) : 
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
            
            internal DataColumn IdDepositoColumn {
                get {
                    return this.columnIdDeposito;
                }
            }
            
            internal DataColumn IdSeccionColumn {
                get {
                    return this.columnIdSeccion;
                }
            }
            
            internal DataColumn IdEstanteriaColumn {
                get {
                    return this.columnIdEstanteria;
                }
            }
            
            internal DataColumn IdFilaColumn {
                get {
                    return this.columnIdFila;
                }
            }
            
            internal DataColumn CodigoColumn {
                get {
                    return this.columnCodigo;
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
            
            public st_FilaRow this[int index] {
                get {
                    return ((st_FilaRow)(this.Rows[index]));
                }
            }
            
            public event st_FilaRowChangeEventHandler st_FilaRowChanged;
            
            public event st_FilaRowChangeEventHandler st_FilaRowChanging;
            
            public event st_FilaRowChangeEventHandler st_FilaRowDeleted;
            
            public event st_FilaRowChangeEventHandler st_FilaRowDeleting;
            
            public void Addst_FilaRow(st_FilaRow row) {
                this.Rows.Add(row);
            }
            
            public st_FilaRow Addst_FilaRow(long IdDeposito, long IdSeccion, long IdEstanteria, long IdFila, string Codigo, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId) {
                st_FilaRow rowst_FilaRow = ((st_FilaRow)(this.NewRow()));
                rowst_FilaRow.ItemArray = new object[] {
                        IdDeposito,
                        IdSeccion,
                        IdEstanteria,
                        IdFila,
                        Codigo,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId};
                this.Rows.Add(rowst_FilaRow);
                return rowst_FilaRow;
            }
            
            public st_FilaRow FindByIdFila(long IdFila) {
                return ((st_FilaRow)(this.Rows.Find(new object[] {
                            IdFila})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                st_FilaDataTable cln = ((st_FilaDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new st_FilaDataTable();
            }
            
            internal void InitVars() {
                this.columnIdDeposito = this.Columns["IdDeposito"];
                this.columnIdSeccion = this.Columns["IdSeccion"];
                this.columnIdEstanteria = this.Columns["IdEstanteria"];
                this.columnIdFila = this.Columns["IdFila"];
                this.columnCodigo = this.Columns["Codigo"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdDeposito = new DataColumn("IdDeposito", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdDeposito);
                this.columnIdSeccion = new DataColumn("IdSeccion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSeccion);
                this.columnIdEstanteria = new DataColumn("IdEstanteria", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEstanteria);
                this.columnIdFila = new DataColumn("IdFila", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdFila);
                this.columnCodigo = new DataColumn("Codigo", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCodigo);
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
                this.Constraints.Add(new UniqueConstraint("Prueba2Key1", new DataColumn[] {
                                this.columnIdFila}, true));
                this.columnIdFila.AllowDBNull = false;
                this.columnIdFila.Unique = true;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public st_FilaRow Newst_FilaRow() {
                return ((st_FilaRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new st_FilaRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(st_FilaRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.st_FilaRowChanged != null)) {
                    this.st_FilaRowChanged(this, new st_FilaRowChangeEvent(((st_FilaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.st_FilaRowChanging != null)) {
                    this.st_FilaRowChanging(this, new st_FilaRowChangeEvent(((st_FilaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.st_FilaRowDeleted != null)) {
                    this.st_FilaRowDeleted(this, new st_FilaRowChangeEvent(((st_FilaRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.st_FilaRowDeleting != null)) {
                    this.st_FilaRowDeleting(this, new st_FilaRowChangeEvent(((st_FilaRow)(e.Row)), e.Action));
                }
            }
            
            public void Removest_FilaRow(st_FilaRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_FilaRow : DataRow {
            
            private st_FilaDataTable tablest_Fila;
            
            internal st_FilaRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablest_Fila = ((st_FilaDataTable)(this.Table));
            }
            
            public long IdDeposito {
                get {
                    try {
                        return ((long)(this[this.tablest_Fila.IdDepositoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.IdDepositoColumn] = value;
                }
            }
            
            public long IdSeccion {
                get {
                    try {
                        return ((long)(this[this.tablest_Fila.IdSeccionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.IdSeccionColumn] = value;
                }
            }
            
            public long IdEstanteria {
                get {
                    try {
                        return ((long)(this[this.tablest_Fila.IdEstanteriaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.IdEstanteriaColumn] = value;
                }
            }
            
            public long IdFila {
                get {
                    return ((long)(this[this.tablest_Fila.IdFilaColumn]));
                }
                set {
                    this[this.tablest_Fila.IdFilaColumn] = value;
                }
            }
            
            public string Codigo {
                get {
                    try {
                        return ((string)(this[this.tablest_Fila.CodigoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.CodigoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablest_Fila.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablest_Fila.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablest_Fila.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablest_Fila.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablest_Fila.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablest_Fila.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablest_Fila.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_Fila.RowIdColumn] = value;
                }
            }
            
            public bool IsIdDepositoNull() {
                return this.IsNull(this.tablest_Fila.IdDepositoColumn);
            }
            
            public void SetIdDepositoNull() {
                this[this.tablest_Fila.IdDepositoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSeccionNull() {
                return this.IsNull(this.tablest_Fila.IdSeccionColumn);
            }
            
            public void SetIdSeccionNull() {
                this[this.tablest_Fila.IdSeccionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEstanteriaNull() {
                return this.IsNull(this.tablest_Fila.IdEstanteriaColumn);
            }
            
            public void SetIdEstanteriaNull() {
                this[this.tablest_Fila.IdEstanteriaColumn] = System.Convert.DBNull;
            }
            
            public bool IsCodigoNull() {
                return this.IsNull(this.tablest_Fila.CodigoColumn);
            }
            
            public void SetCodigoNull() {
                this[this.tablest_Fila.CodigoColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablest_Fila.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablest_Fila.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablest_Fila.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablest_Fila.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablest_Fila.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablest_Fila.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablest_Fila.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablest_Fila.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablest_Fila.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablest_Fila.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_FilaRowChangeEvent : EventArgs {
            
            private st_FilaRow eventRow;
            
            private DataRowAction eventAction;
            
            public st_FilaRowChangeEvent(st_FilaRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public st_FilaRow Row {
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
