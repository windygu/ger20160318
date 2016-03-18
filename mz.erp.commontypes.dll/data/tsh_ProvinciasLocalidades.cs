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
    public class tsh_ProvinciasLocalidadesDataset : DataSet {
        
        private tsh_ProvinciasLocalidadesDataTable tabletsh_ProvinciasLocalidades;
        
        public tsh_ProvinciasLocalidadesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_ProvinciasLocalidadesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_ProvinciasLocalidades"] != null)) {
                    this.Tables.Add(new tsh_ProvinciasLocalidadesDataTable(ds.Tables["tsh_ProvinciasLocalidades"]));
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
        public tsh_ProvinciasLocalidadesDataTable tsh_ProvinciasLocalidades {
            get {
                return this.tabletsh_ProvinciasLocalidades;
            }
        }
        
        public override DataSet Clone() {
            tsh_ProvinciasLocalidadesDataset cln = ((tsh_ProvinciasLocalidadesDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_ProvinciasLocalidades"] != null)) {
                this.Tables.Add(new tsh_ProvinciasLocalidadesDataTable(ds.Tables["tsh_ProvinciasLocalidades"]));
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
            this.tabletsh_ProvinciasLocalidades = ((tsh_ProvinciasLocalidadesDataTable)(this.Tables["tsh_ProvinciasLocalidades"]));
            if ((this.tabletsh_ProvinciasLocalidades != null)) {
                this.tabletsh_ProvinciasLocalidades.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_ProvinciasLocalidadesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_ProvinciasLocalidades.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_ProvinciasLocalidades = new tsh_ProvinciasLocalidadesDataTable();
            this.Tables.Add(this.tabletsh_ProvinciasLocalidades);
        }
        
        private bool ShouldSerializetsh_ProvinciasLocalidades() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_ProvinciasLocalidadesRowChangeEventHandler(object sender, tsh_ProvinciasLocalidadesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ProvinciasLocalidadesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdProvincia;
            
            private DataColumn columnIdLocalidad;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tsh_ProvinciasLocalidadesDataTable() : 
                    base("tsh_ProvinciasLocalidades") {
                this.InitClass();
            }
            
            internal tsh_ProvinciasLocalidadesDataTable(DataTable table) : 
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
            
            internal DataColumn IdProvinciaColumn {
                get {
                    return this.columnIdProvincia;
                }
            }
            
            internal DataColumn IdLocalidadColumn {
                get {
                    return this.columnIdLocalidad;
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
            
            public tsh_ProvinciasLocalidadesRow this[int index] {
                get {
                    return ((tsh_ProvinciasLocalidadesRow)(this.Rows[index]));
                }
            }
            
            public event tsh_ProvinciasLocalidadesRowChangeEventHandler tsh_ProvinciasLocalidadesRowChanged;
            
            public event tsh_ProvinciasLocalidadesRowChangeEventHandler tsh_ProvinciasLocalidadesRowChanging;
            
            public event tsh_ProvinciasLocalidadesRowChangeEventHandler tsh_ProvinciasLocalidadesRowDeleted;
            
            public event tsh_ProvinciasLocalidadesRowChangeEventHandler tsh_ProvinciasLocalidadesRowDeleting;
            
            public void Addtsh_ProvinciasLocalidadesRow(tsh_ProvinciasLocalidadesRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_ProvinciasLocalidadesRow Addtsh_ProvinciasLocalidadesRow(long IdProvincia, string IdLocalidad, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal) {
                tsh_ProvinciasLocalidadesRow rowtsh_ProvinciasLocalidadesRow = ((tsh_ProvinciasLocalidadesRow)(this.NewRow()));
                rowtsh_ProvinciasLocalidadesRow.ItemArray = new object[] {
                        IdProvincia,
                        IdLocalidad,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtsh_ProvinciasLocalidadesRow);
                return rowtsh_ProvinciasLocalidadesRow;
            }
            
            public tsh_ProvinciasLocalidadesRow FindByIdProvinciaIdLocalidad(long IdProvincia, string IdLocalidad) {
                return ((tsh_ProvinciasLocalidadesRow)(this.Rows.Find(new object[] {
                            IdProvincia,
                            IdLocalidad})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_ProvinciasLocalidadesDataTable cln = ((tsh_ProvinciasLocalidadesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_ProvinciasLocalidadesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdProvincia = this.Columns["IdProvincia"];
                this.columnIdLocalidad = this.Columns["IdLocalidad"];
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
                this.columnIdProvincia = new DataColumn("IdProvincia", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProvincia);
                this.columnIdLocalidad = new DataColumn("IdLocalidad", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdLocalidad);
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
                this.Constraints.Add(new UniqueConstraint("tsh_ProvinciasLocalidadesKey1", new DataColumn[] {
                                this.columnIdProvincia,
                                this.columnIdLocalidad}, true));
                this.columnIdProvincia.AllowDBNull = false;
                this.columnIdLocalidad.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_ProvinciasLocalidadesRow Newtsh_ProvinciasLocalidadesRow() {
                return ((tsh_ProvinciasLocalidadesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_ProvinciasLocalidadesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_ProvinciasLocalidadesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_ProvinciasLocalidadesRowChanged != null)) {
                    this.tsh_ProvinciasLocalidadesRowChanged(this, new tsh_ProvinciasLocalidadesRowChangeEvent(((tsh_ProvinciasLocalidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_ProvinciasLocalidadesRowChanging != null)) {
                    this.tsh_ProvinciasLocalidadesRowChanging(this, new tsh_ProvinciasLocalidadesRowChangeEvent(((tsh_ProvinciasLocalidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_ProvinciasLocalidadesRowDeleted != null)) {
                    this.tsh_ProvinciasLocalidadesRowDeleted(this, new tsh_ProvinciasLocalidadesRowChangeEvent(((tsh_ProvinciasLocalidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_ProvinciasLocalidadesRowDeleting != null)) {
                    this.tsh_ProvinciasLocalidadesRowDeleting(this, new tsh_ProvinciasLocalidadesRowChangeEvent(((tsh_ProvinciasLocalidadesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_ProvinciasLocalidadesRow(tsh_ProvinciasLocalidadesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ProvinciasLocalidadesRow : DataRow {
            
            private tsh_ProvinciasLocalidadesDataTable tabletsh_ProvinciasLocalidades;
            
            internal tsh_ProvinciasLocalidadesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_ProvinciasLocalidades = ((tsh_ProvinciasLocalidadesDataTable)(this.Table));
            }
            
            public long IdProvincia {
                get {
                    return ((long)(this[this.tabletsh_ProvinciasLocalidades.IdProvinciaColumn]));
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdProvinciaColumn] = value;
                }
            }
            
            public string IdLocalidad {
                get {
                    return ((string)(this[this.tabletsh_ProvinciasLocalidades.IdLocalidadColumn]));
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdLocalidadColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_ProvinciasLocalidades.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProvinciasLocalidades.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_ProvinciasLocalidades.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProvinciasLocalidades.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProvinciasLocalidades.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_ProvinciasLocalidades.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProvinciasLocalidades.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_ProvinciasLocalidades.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_ProvinciasLocalidades.IdSucursalColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_ProvinciasLocalidades.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_ProvinciasLocalidades.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_ProvinciasLocalidades.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_ProvinciasLocalidades.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_ProvinciasLocalidades.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_ProvinciasLocalidades.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_ProvinciasLocalidades.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_ProvinciasLocalidades.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_ProvinciasLocalidades.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_ProvinciasLocalidadesRowChangeEvent : EventArgs {
            
            private tsh_ProvinciasLocalidadesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_ProvinciasLocalidadesRowChangeEvent(tsh_ProvinciasLocalidadesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_ProvinciasLocalidadesRow Row {
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
