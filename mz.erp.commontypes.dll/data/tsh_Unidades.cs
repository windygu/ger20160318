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
    public class tsh_UnidadesDataset : DataSet {
        
        private tsh_UnidadesDataTable tabletsh_Unidades;
        
        public tsh_UnidadesDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_UnidadesDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_Unidades"] != null)) {
                    this.Tables.Add(new tsh_UnidadesDataTable(ds.Tables["tsh_Unidades"]));
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
        public tsh_UnidadesDataTable tsh_Unidades {
            get {
                return this.tabletsh_Unidades;
            }
        }
        
        public override DataSet Clone() {
            tsh_UnidadesDataset cln = ((tsh_UnidadesDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_Unidades"] != null)) {
                this.Tables.Add(new tsh_UnidadesDataTable(ds.Tables["tsh_Unidades"]));
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
            this.tabletsh_Unidades = ((tsh_UnidadesDataTable)(this.Tables["tsh_Unidades"]));
            if ((this.tabletsh_Unidades != null)) {
                this.tabletsh_Unidades.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_UnidadesDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_Unidades.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_Unidades = new tsh_UnidadesDataTable();
            this.Tables.Add(this.tabletsh_Unidades);
        }
        
        private bool ShouldSerializetsh_Unidades() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_UnidadesRowChangeEventHandler(object sender, tsh_UnidadesRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_UnidadesDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdUnidad;
            
            private DataColumn columnNombre;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdGenerado;
            
            private DataColumn columnRowIdGenerado;
            
            internal tsh_UnidadesDataTable() : 
                    base("tsh_Unidades") {
                this.InitClass();
            }
            
            internal tsh_UnidadesDataTable(DataTable table) : 
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
            
            internal DataColumn IdUnidadColumn {
                get {
                    return this.columnIdUnidad;
                }
            }
            
            internal DataColumn NombreColumn {
                get {
                    return this.columnNombre;
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
            
            internal DataColumn IdGeneradoColumn {
                get {
                    return this.columnIdGenerado;
                }
            }
            
            internal DataColumn RowIdGeneradoColumn {
                get {
                    return this.columnRowIdGenerado;
                }
            }
            
            public tsh_UnidadesRow this[int index] {
                get {
                    return ((tsh_UnidadesRow)(this.Rows[index]));
                }
            }
            
            public event tsh_UnidadesRowChangeEventHandler tsh_UnidadesRowChanged;
            
            public event tsh_UnidadesRowChangeEventHandler tsh_UnidadesRowChanging;
            
            public event tsh_UnidadesRowChangeEventHandler tsh_UnidadesRowDeleted;
            
            public event tsh_UnidadesRowChangeEventHandler tsh_UnidadesRowDeleting;
            
            public void Addtsh_UnidadesRow(tsh_UnidadesRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_UnidadesRow Addtsh_UnidadesRow(string IdUnidad, string Nombre, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdEmpresa, long IdSucursal, string IdGenerado, string RowIdGenerado) {
                tsh_UnidadesRow rowtsh_UnidadesRow = ((tsh_UnidadesRow)(this.NewRow()));
                rowtsh_UnidadesRow.ItemArray = new object[] {
                        IdUnidad,
                        Nombre,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal,
                        IdGenerado,
                        RowIdGenerado};
                this.Rows.Add(rowtsh_UnidadesRow);
                return rowtsh_UnidadesRow;
            }
            
            public tsh_UnidadesRow FindByIdUnidad(string IdUnidad) {
                return ((tsh_UnidadesRow)(this.Rows.Find(new object[] {
                            IdUnidad})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_UnidadesDataTable cln = ((tsh_UnidadesDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_UnidadesDataTable();
            }
            
            internal void InitVars() {
                this.columnIdUnidad = this.Columns["IdUnidad"];
                this.columnNombre = this.Columns["Nombre"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdGenerado = this.Columns["IdGenerado"];
                this.columnRowIdGenerado = this.Columns["RowIdGenerado"];
            }
            
            private void InitClass() {
                this.columnIdUnidad = new DataColumn("IdUnidad", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdUnidad);
                this.columnNombre = new DataColumn("Nombre", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNombre);
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
                this.columnIdReservado = new DataColumn("IdReservado", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdReservado);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdGenerado = new DataColumn("IdGenerado", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdGenerado);
                this.columnRowIdGenerado = new DataColumn("RowIdGenerado", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowIdGenerado);
                this.Constraints.Add(new UniqueConstraint("tsh_UnidadesKey1", new DataColumn[] {
                                this.columnIdUnidad}, true));
                this.columnIdUnidad.AllowDBNull = false;
                this.columnIdUnidad.Unique = true;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsh_UnidadesRow Newtsh_UnidadesRow() {
                return ((tsh_UnidadesRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_UnidadesRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_UnidadesRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_UnidadesRowChanged != null)) {
                    this.tsh_UnidadesRowChanged(this, new tsh_UnidadesRowChangeEvent(((tsh_UnidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_UnidadesRowChanging != null)) {
                    this.tsh_UnidadesRowChanging(this, new tsh_UnidadesRowChangeEvent(((tsh_UnidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_UnidadesRowDeleted != null)) {
                    this.tsh_UnidadesRowDeleted(this, new tsh_UnidadesRowChangeEvent(((tsh_UnidadesRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_UnidadesRowDeleting != null)) {
                    this.tsh_UnidadesRowDeleting(this, new tsh_UnidadesRowChangeEvent(((tsh_UnidadesRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_UnidadesRow(tsh_UnidadesRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_UnidadesRow : DataRow {
            
            private tsh_UnidadesDataTable tabletsh_Unidades;
            
            internal tsh_UnidadesRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_Unidades = ((tsh_UnidadesDataTable)(this.Table));
            }
            
            public string IdUnidad {
                get {
                    return ((string)(this[this.tabletsh_Unidades.IdUnidadColumn]));
                }
                set {
                    this[this.tabletsh_Unidades.IdUnidadColumn] = value;
                }
            }
            
            public string Nombre {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Unidades.NombreColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.NombreColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletsh_Unidades.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_Unidades.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Unidades.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_Unidades.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Unidades.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Unidades.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsh_Unidades.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Unidades.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_Unidades.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_Unidades.IdSucursalColumn] = value;
                }
            }
            
            public string IdGenerado {
                get {
                    if (this.IsIdGeneradoNull()) {
                        return null;
                    }
                    else {
                        return ((string)(this[this.tabletsh_Unidades.IdGeneradoColumn]));
                    }
                }
                set {
                    this[this.tabletsh_Unidades.IdGeneradoColumn] = value;
                }
            }
            
            public string RowIdGenerado {
                get {
                    if (this.IsRowIdGeneradoNull()) {
                        return null;
                    }
                    else {
                        return ((string)(this[this.tabletsh_Unidades.RowIdGeneradoColumn]));
                    }
                }
                set {
                    this[this.tabletsh_Unidades.RowIdGeneradoColumn] = value;
                }
            }
            
            public bool IsNombreNull() {
                return this.IsNull(this.tabletsh_Unidades.NombreColumn);
            }
            
            public void SetNombreNull() {
                this[this.tabletsh_Unidades.NombreColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletsh_Unidades.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletsh_Unidades.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_Unidades.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_Unidades.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_Unidades.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_Unidades.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Unidades.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_Unidades.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_Unidades.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_Unidades.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_Unidades.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_Unidades.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_Unidades.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_Unidades.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_Unidades.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_Unidades.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_Unidades.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_Unidades.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdGeneradoNull() {
                return this.IsNull(this.tabletsh_Unidades.IdGeneradoColumn);
            }
            
            public void SetIdGeneradoNull() {
                this[this.tabletsh_Unidades.IdGeneradoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdGeneradoNull() {
                return this.IsNull(this.tabletsh_Unidades.RowIdGeneradoColumn);
            }
            
            public void SetRowIdGeneradoNull() {
                this[this.tabletsh_Unidades.RowIdGeneradoColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_UnidadesRowChangeEvent : EventArgs {
            
            private tsh_UnidadesRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_UnidadesRowChangeEvent(tsh_UnidadesRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_UnidadesRow Row {
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
