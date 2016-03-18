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
    public class tfi_ResponsablesCajasDataset : DataSet {
        
        private tfi_ResponsablesCajasDataTable tabletfi_ResponsablesCajas;
        
        public tfi_ResponsablesCajasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tfi_ResponsablesCajasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tfi_ResponsablesCajas"] != null)) {
                    this.Tables.Add(new tfi_ResponsablesCajasDataTable(ds.Tables["tfi_ResponsablesCajas"]));
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
        public tfi_ResponsablesCajasDataTable tfi_ResponsablesCajas {
            get {
                return this.tabletfi_ResponsablesCajas;
            }
        }
        
        public override DataSet Clone() {
            tfi_ResponsablesCajasDataset cln = ((tfi_ResponsablesCajasDataset)(base.Clone()));
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
            if ((ds.Tables["tfi_ResponsablesCajas"] != null)) {
                this.Tables.Add(new tfi_ResponsablesCajasDataTable(ds.Tables["tfi_ResponsablesCajas"]));
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
            this.tabletfi_ResponsablesCajas = ((tfi_ResponsablesCajasDataTable)(this.Tables["tfi_ResponsablesCajas"]));
            if ((this.tabletfi_ResponsablesCajas != null)) {
                this.tabletfi_ResponsablesCajas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tfi_ResponsablesCajasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tfi_ResponsablesCajas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletfi_ResponsablesCajas = new tfi_ResponsablesCajasDataTable();
            this.Tables.Add(this.tabletfi_ResponsablesCajas);
        }
        
        private bool ShouldSerializetfi_ResponsablesCajas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tfi_ResponsablesCajasRowChangeEventHandler(object sender, tfi_ResponsablesCajasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_ResponsablesCajasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdCaja;
            
            private DataColumn columnIdResponsable;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tfi_ResponsablesCajasDataTable() : 
                    base("tfi_ResponsablesCajas") {
                this.InitClass();
            }
            
            internal tfi_ResponsablesCajasDataTable(DataTable table) : 
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
            
            internal DataColumn IdCajaColumn {
                get {
                    return this.columnIdCaja;
                }
            }
            
            internal DataColumn IdResponsableColumn {
                get {
                    return this.columnIdResponsable;
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
            
            internal DataColumn IdReservadoColumn {
                get {
                    return this.columnIdReservado;
                }
            }
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            public tfi_ResponsablesCajasRow this[int index] {
                get {
                    return ((tfi_ResponsablesCajasRow)(this.Rows[index]));
                }
            }
            
            public event tfi_ResponsablesCajasRowChangeEventHandler tfi_ResponsablesCajasRowChanged;
            
            public event tfi_ResponsablesCajasRowChangeEventHandler tfi_ResponsablesCajasRowChanging;
            
            public event tfi_ResponsablesCajasRowChangeEventHandler tfi_ResponsablesCajasRowDeleted;
            
            public event tfi_ResponsablesCajasRowChangeEventHandler tfi_ResponsablesCajasRowDeleting;
            
            public void Addtfi_ResponsablesCajasRow(tfi_ResponsablesCajasRow row) {
                this.Rows.Add(row);
            }
            
            public tfi_ResponsablesCajasRow Addtfi_ResponsablesCajasRow(string IdCaja, string IdResponsable, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tfi_ResponsablesCajasRow rowtfi_ResponsablesCajasRow = ((tfi_ResponsablesCajasRow)(this.NewRow()));
                rowtfi_ResponsablesCajasRow.ItemArray = new object[] {
                        IdCaja,
                        IdResponsable,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtfi_ResponsablesCajasRow);
                return rowtfi_ResponsablesCajasRow;
            }
            
            public tfi_ResponsablesCajasRow FindByIdCajaIdResponsable(string IdCaja, string IdResponsable) {
                return ((tfi_ResponsablesCajasRow)(this.Rows.Find(new object[] {
                            IdCaja,
                            IdResponsable})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tfi_ResponsablesCajasDataTable cln = ((tfi_ResponsablesCajasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tfi_ResponsablesCajasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdCaja = this.Columns["IdCaja"];
                this.columnIdResponsable = this.Columns["IdResponsable"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
            }
            
            private void InitClass() {
                this.columnIdCaja = new DataColumn("IdCaja", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCaja);
                this.columnIdResponsable = new DataColumn("IdResponsable", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdResponsable);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.Constraints.Add(new UniqueConstraint("tfi_ResponsablesCajasKey1", new DataColumn[] {
                                this.columnIdCaja,
                                this.columnIdResponsable}, true));
                this.columnIdCaja.AllowDBNull = false;
                this.columnIdResponsable.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tfi_ResponsablesCajasRow Newtfi_ResponsablesCajasRow() {
                return ((tfi_ResponsablesCajasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tfi_ResponsablesCajasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tfi_ResponsablesCajasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tfi_ResponsablesCajasRowChanged != null)) {
                    this.tfi_ResponsablesCajasRowChanged(this, new tfi_ResponsablesCajasRowChangeEvent(((tfi_ResponsablesCajasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tfi_ResponsablesCajasRowChanging != null)) {
                    this.tfi_ResponsablesCajasRowChanging(this, new tfi_ResponsablesCajasRowChangeEvent(((tfi_ResponsablesCajasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tfi_ResponsablesCajasRowDeleted != null)) {
                    this.tfi_ResponsablesCajasRowDeleted(this, new tfi_ResponsablesCajasRowChangeEvent(((tfi_ResponsablesCajasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tfi_ResponsablesCajasRowDeleting != null)) {
                    this.tfi_ResponsablesCajasRowDeleting(this, new tfi_ResponsablesCajasRowChangeEvent(((tfi_ResponsablesCajasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetfi_ResponsablesCajasRow(tfi_ResponsablesCajasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_ResponsablesCajasRow : DataRow {
            
            private tfi_ResponsablesCajasDataTable tabletfi_ResponsablesCajas;
            
            internal tfi_ResponsablesCajasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletfi_ResponsablesCajas = ((tfi_ResponsablesCajasDataTable)(this.Table));
            }
            
            public string IdCaja {
                get {
                    return ((string)(this[this.tabletfi_ResponsablesCajas.IdCajaColumn]));
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdCajaColumn] = value;
                }
            }
            
            public string IdResponsable {
                get {
                    return ((string)(this[this.tabletfi_ResponsablesCajas.IdResponsableColumn]));
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdResponsableColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletfi_ResponsablesCajas.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ResponsablesCajas.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletfi_ResponsablesCajas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ResponsablesCajas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ResponsablesCajas.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletfi_ResponsablesCajas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ResponsablesCajas.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletfi_ResponsablesCajas.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_ResponsablesCajas.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletfi_ResponsablesCajas.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletfi_ResponsablesCajas.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletfi_ResponsablesCajas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletfi_ResponsablesCajas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletfi_ResponsablesCajas.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletfi_ResponsablesCajas.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletfi_ResponsablesCajas.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletfi_ResponsablesCajas.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletfi_ResponsablesCajas.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_ResponsablesCajasRowChangeEvent : EventArgs {
            
            private tfi_ResponsablesCajasRow eventRow;
            
            private DataRowAction eventAction;
            
            public tfi_ResponsablesCajasRowChangeEvent(tfi_ResponsablesCajasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tfi_ResponsablesCajasRow Row {
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