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
    public class tsh_ContactosExDataset : DataSet {
        
        private tsh_ContactosDataTable tabletsh_Contactos;
        
        public tsh_ContactosExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_ContactosExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_Contactos"] != null)) {
                    this.Tables.Add(new tsh_ContactosDataTable(ds.Tables["tsh_Contactos"]));
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
        public tsh_ContactosDataTable tsh_Contactos {
            get {
                return this.tabletsh_Contactos;
            }
        }
        
        public override DataSet Clone() {
            tsh_ContactosExDataset cln = ((tsh_ContactosExDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_Contactos"] != null)) {
                this.Tables.Add(new tsh_ContactosDataTable(ds.Tables["tsh_Contactos"]));
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
            this.tabletsh_Contactos = ((tsh_ContactosDataTable)(this.Tables["tsh_Contactos"]));
            if ((this.tabletsh_Contactos != null)) {
                this.tabletsh_Contactos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_ContactosExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_ContactosEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_Contactos = new tsh_ContactosDataTable();
            this.Tables.Add(this.tabletsh_Contactos);
        }
        
        private bool ShouldSerializetsh_Contactos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_ContactosRowChangeEventHandler(object sender, tsh_ContactosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ContactosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdCuenta;
            
            private DataColumn columnIdPersona;
            
            private DataColumn columnIdTipoContacto;
            
            private DataColumn columnIdCargo;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            internal tsh_ContactosDataTable() : 
                    base("tsh_Contactos") {
                this.InitClass();
            }
            
            internal tsh_ContactosDataTable(DataTable table) : 
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
            
            internal DataColumn IdCuentaColumn {
                get {
                    return this.columnIdCuenta;
                }
            }
            
            internal DataColumn IdPersonaColumn {
                get {
                    return this.columnIdPersona;
                }
            }
            
            internal DataColumn IdTipoContactoColumn {
                get {
                    return this.columnIdTipoContacto;
                }
            }
            
            internal DataColumn IdCargoColumn {
                get {
                    return this.columnIdCargo;
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
            
            public tsh_ContactosRow this[int index] {
                get {
                    return ((tsh_ContactosRow)(this.Rows[index]));
                }
            }
            
            public event tsh_ContactosRowChangeEventHandler tsh_ContactosRowChanged;
            
            public event tsh_ContactosRowChangeEventHandler tsh_ContactosRowChanging;
            
            public event tsh_ContactosRowChangeEventHandler tsh_ContactosRowDeleted;
            
            public event tsh_ContactosRowChangeEventHandler tsh_ContactosRowDeleting;
            
            public void Addtsh_ContactosRow(tsh_ContactosRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_ContactosRow Addtsh_ContactosRow(string IdCuenta, string IdPersona, long IdTipoContacto, long IdCargo, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa) {
                tsh_ContactosRow rowtsh_ContactosRow = ((tsh_ContactosRow)(this.NewRow()));
                rowtsh_ContactosRow.ItemArray = new object[] {
                        IdCuenta,
                        IdPersona,
                        IdTipoContacto,
                        IdCargo,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa};
                this.Rows.Add(rowtsh_ContactosRow);
                return rowtsh_ContactosRow;
            }
            
            public tsh_ContactosRow FindByIdCuentaIdPersona(string IdCuenta, string IdPersona) {
                return ((tsh_ContactosRow)(this.Rows.Find(new object[] {
                            IdCuenta,
                            IdPersona})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_ContactosDataTable cln = ((tsh_ContactosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_ContactosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdCuenta = this.Columns["IdCuenta"];
                this.columnIdPersona = this.Columns["IdPersona"];
                this.columnIdTipoContacto = this.Columns["IdTipoContacto"];
                this.columnIdCargo = this.Columns["IdCargo"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdCuenta = new DataColumn("IdCuenta", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCuenta);
                this.columnIdPersona = new DataColumn("IdPersona", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdPersona);
                this.columnIdTipoContacto = new DataColumn("IdTipoContacto", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoContacto);
                this.columnIdCargo = new DataColumn("IdCargo", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCargo);
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
                this.Constraints.Add(new UniqueConstraint("tsh_ContactosExKey1", new DataColumn[] {
                                this.columnIdCuenta,
                                this.columnIdPersona}, true));
                this.columnIdCuenta.AllowDBNull = false;
                this.columnIdPersona.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_ContactosRow Newtsh_ContactosRow() {
                return ((tsh_ContactosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_ContactosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_ContactosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_ContactosRowChanged != null)) {
                    this.tsh_ContactosRowChanged(this, new tsh_ContactosRowChangeEvent(((tsh_ContactosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_ContactosRowChanging != null)) {
                    this.tsh_ContactosRowChanging(this, new tsh_ContactosRowChangeEvent(((tsh_ContactosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_ContactosRowDeleted != null)) {
                    this.tsh_ContactosRowDeleted(this, new tsh_ContactosRowChangeEvent(((tsh_ContactosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_ContactosRowDeleting != null)) {
                    this.tsh_ContactosRowDeleting(this, new tsh_ContactosRowChangeEvent(((tsh_ContactosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_ContactosRow(tsh_ContactosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ContactosRow : DataRow {
            
            private tsh_ContactosDataTable tabletsh_Contactos;
            
            internal tsh_ContactosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_Contactos = ((tsh_ContactosDataTable)(this.Table));
            }
            
            public string IdCuenta {
                get {
                    return ((string)(this[this.tabletsh_Contactos.IdCuentaColumn]));
                }
                set {
                    this[this.tabletsh_Contactos.IdCuentaColumn] = value;
                }
            }
            
            public string IdPersona {
                get {
                    return ((string)(this[this.tabletsh_Contactos.IdPersonaColumn]));
                }
                set {
                    this[this.tabletsh_Contactos.IdPersonaColumn] = value;
                }
            }
            
            public long IdTipoContacto {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Contactos.IdTipoContactoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.IdTipoContactoColumn] = value;
                }
            }
            
            public long IdCargo {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Contactos.IdCargoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.IdCargoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_Contactos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Contactos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_Contactos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Contactos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Contactos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_Contactos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Contactos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Contactos.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsIdTipoContactoNull() {
                return this.IsNull(this.tabletsh_Contactos.IdTipoContactoColumn);
            }
            
            public void SetIdTipoContactoNull() {
                this[this.tabletsh_Contactos.IdTipoContactoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdCargoNull() {
                return this.IsNull(this.tabletsh_Contactos.IdCargoColumn);
            }
            
            public void SetIdCargoNull() {
                this[this.tabletsh_Contactos.IdCargoColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_Contactos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_Contactos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_Contactos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_Contactos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Contactos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_Contactos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Contactos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_Contactos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_Contactos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_Contactos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_Contactos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_Contactos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_Contactos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_Contactos.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ContactosRowChangeEvent : EventArgs {
            
            private tsh_ContactosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_ContactosRowChangeEvent(tsh_ContactosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_ContactosRow Row {
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
