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
    public class tlg_VisualizacionDeStockDataset : DataSet {
        
        private tlg_VisualizacionDeStockDataTable tabletlg_VisualizacionDeStock;
        
        public tlg_VisualizacionDeStockDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_VisualizacionDeStockDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_VisualizacionDeStock"] != null)) {
                    this.Tables.Add(new tlg_VisualizacionDeStockDataTable(ds.Tables["tlg_VisualizacionDeStock"]));
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
        public tlg_VisualizacionDeStockDataTable tlg_VisualizacionDeStock {
            get {
                return this.tabletlg_VisualizacionDeStock;
            }
        }
        
        public override DataSet Clone() {
            tlg_VisualizacionDeStockDataset cln = ((tlg_VisualizacionDeStockDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_VisualizacionDeStock"] != null)) {
                this.Tables.Add(new tlg_VisualizacionDeStockDataTable(ds.Tables["tlg_VisualizacionDeStock"]));
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
            this.tabletlg_VisualizacionDeStock = ((tlg_VisualizacionDeStockDataTable)(this.Tables["tlg_VisualizacionDeStock"]));
            if ((this.tabletlg_VisualizacionDeStock != null)) {
                this.tabletlg_VisualizacionDeStock.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_VisualizacionDeStockDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_VisualizacionDeStock.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_VisualizacionDeStock = new tlg_VisualizacionDeStockDataTable();
            this.Tables.Add(this.tabletlg_VisualizacionDeStock);
        }
        
        private bool ShouldSerializetlg_VisualizacionDeStock() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_VisualizacionDeStockRowChangeEventHandler(object sender, tlg_VisualizacionDeStockRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_VisualizacionDeStockDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdVisualizacionDeStock;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnOldIdVisualizacionDeStock;
            
            private DataColumn columnActivo;
            
            internal tlg_VisualizacionDeStockDataTable() : 
                    base("tlg_VisualizacionDeStock") {
                this.InitClass();
            }
            
            internal tlg_VisualizacionDeStockDataTable(DataTable table) : 
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
            
            internal DataColumn IdVisualizacionDeStockColumn {
                get {
                    return this.columnIdVisualizacionDeStock;
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
            
            internal DataColumn IdSucursalColumn {
                get {
                    return this.columnIdSucursal;
                }
            }
            
            internal DataColumn IdEmpresaColumn {
                get {
                    return this.columnIdEmpresa;
                }
            }
            
            internal DataColumn OldIdVisualizacionDeStockColumn {
                get {
                    return this.columnOldIdVisualizacionDeStock;
                }
            }
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
                }
            }
            
            public tlg_VisualizacionDeStockRow this[int index] {
                get {
                    return ((tlg_VisualizacionDeStockRow)(this.Rows[index]));
                }
            }
            
            public event tlg_VisualizacionDeStockRowChangeEventHandler tlg_VisualizacionDeStockRowChanged;
            
            public event tlg_VisualizacionDeStockRowChangeEventHandler tlg_VisualizacionDeStockRowChanging;
            
            public event tlg_VisualizacionDeStockRowChangeEventHandler tlg_VisualizacionDeStockRowDeleted;
            
            public event tlg_VisualizacionDeStockRowChangeEventHandler tlg_VisualizacionDeStockRowDeleting;
            
            public void Addtlg_VisualizacionDeStockRow(tlg_VisualizacionDeStockRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_VisualizacionDeStockRow Addtlg_VisualizacionDeStockRow(string IdVisualizacionDeStock, string Descripcion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa, long OldIdVisualizacionDeStock, bool Activo) {
                tlg_VisualizacionDeStockRow rowtlg_VisualizacionDeStockRow = ((tlg_VisualizacionDeStockRow)(this.NewRow()));
                rowtlg_VisualizacionDeStockRow.ItemArray = new object[] {
                        IdVisualizacionDeStock,
                        Descripcion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa,
                        OldIdVisualizacionDeStock,
                        Activo};
                this.Rows.Add(rowtlg_VisualizacionDeStockRow);
                return rowtlg_VisualizacionDeStockRow;
            }
            
            public tlg_VisualizacionDeStockRow FindByIdVisualizacionDeStock(string IdVisualizacionDeStock) {
                return ((tlg_VisualizacionDeStockRow)(this.Rows.Find(new object[] {
                            IdVisualizacionDeStock})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_VisualizacionDeStockDataTable cln = ((tlg_VisualizacionDeStockDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_VisualizacionDeStockDataTable();
            }
            
            internal void InitVars() {
                this.columnIdVisualizacionDeStock = this.Columns["IdVisualizacionDeStock"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnOldIdVisualizacionDeStock = this.Columns["OldIdVisualizacionDeStock"];
                this.columnActivo = this.Columns["Activo"];
            }
            
            private void InitClass() {
                this.columnIdVisualizacionDeStock = new DataColumn("IdVisualizacionDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVisualizacionDeStock);
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
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnOldIdVisualizacionDeStock = new DataColumn("OldIdVisualizacionDeStock", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOldIdVisualizacionDeStock);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
                this.Constraints.Add(new UniqueConstraint("tlg_VisualizacionDeStockKey1", new DataColumn[] {
                                this.columnIdVisualizacionDeStock}, true));
                this.columnIdVisualizacionDeStock.AllowDBNull = false;
                this.columnIdVisualizacionDeStock.Unique = true;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_VisualizacionDeStockRow Newtlg_VisualizacionDeStockRow() {
                return ((tlg_VisualizacionDeStockRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_VisualizacionDeStockRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_VisualizacionDeStockRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_VisualizacionDeStockRowChanged != null)) {
                    this.tlg_VisualizacionDeStockRowChanged(this, new tlg_VisualizacionDeStockRowChangeEvent(((tlg_VisualizacionDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_VisualizacionDeStockRowChanging != null)) {
                    this.tlg_VisualizacionDeStockRowChanging(this, new tlg_VisualizacionDeStockRowChangeEvent(((tlg_VisualizacionDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_VisualizacionDeStockRowDeleted != null)) {
                    this.tlg_VisualizacionDeStockRowDeleted(this, new tlg_VisualizacionDeStockRowChangeEvent(((tlg_VisualizacionDeStockRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_VisualizacionDeStockRowDeleting != null)) {
                    this.tlg_VisualizacionDeStockRowDeleting(this, new tlg_VisualizacionDeStockRowChangeEvent(((tlg_VisualizacionDeStockRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_VisualizacionDeStockRow(tlg_VisualizacionDeStockRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_VisualizacionDeStockRow : DataRow {
            
            private tlg_VisualizacionDeStockDataTable tabletlg_VisualizacionDeStock;
            
            internal tlg_VisualizacionDeStockRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_VisualizacionDeStock = ((tlg_VisualizacionDeStockDataTable)(this.Table));
            }
            
            public string IdVisualizacionDeStock {
                get {
                    return ((string)(this[this.tabletlg_VisualizacionDeStock.IdVisualizacionDeStockColumn]));
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.IdVisualizacionDeStockColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tabletlg_VisualizacionDeStock.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.DescripcionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_VisualizacionDeStock.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStock.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_VisualizacionDeStock.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStock.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStock.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_VisualizacionDeStock.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStock.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStock.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.IdEmpresaColumn] = value;
                }
            }
            
            public long OldIdVisualizacionDeStock {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStock.OldIdVisualizacionDeStockColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.OldIdVisualizacionDeStockColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletlg_VisualizacionDeStock.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStock.ActivoColumn] = value;
                }
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tabletlg_VisualizacionDeStock.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_VisualizacionDeStock.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_VisualizacionDeStock.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_VisualizacionDeStock.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_VisualizacionDeStock.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_VisualizacionDeStock.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_VisualizacionDeStock.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_VisualizacionDeStock.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletlg_VisualizacionDeStock.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsOldIdVisualizacionDeStockNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.OldIdVisualizacionDeStockColumn);
            }
            
            public void SetOldIdVisualizacionDeStockNull() {
                this[this.tabletlg_VisualizacionDeStock.OldIdVisualizacionDeStockColumn] = System.Convert.DBNull;
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStock.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletlg_VisualizacionDeStock.ActivoColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_VisualizacionDeStockRowChangeEvent : EventArgs {
            
            private tlg_VisualizacionDeStockRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_VisualizacionDeStockRowChangeEvent(tlg_VisualizacionDeStockRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_VisualizacionDeStockRow Row {
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