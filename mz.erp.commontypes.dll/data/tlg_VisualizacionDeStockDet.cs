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
    public class tlg_VisualizacionDeStockDetDataset : DataSet {
        
        private tlg_VisualizacionDeStockDetDataTable tabletlg_VisualizacionDeStockDet;
        
        public tlg_VisualizacionDeStockDetDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_VisualizacionDeStockDetDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_VisualizacionDeStockDet"] != null)) {
                    this.Tables.Add(new tlg_VisualizacionDeStockDetDataTable(ds.Tables["tlg_VisualizacionDeStockDet"]));
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
        public tlg_VisualizacionDeStockDetDataTable tlg_VisualizacionDeStockDet {
            get {
                return this.tabletlg_VisualizacionDeStockDet;
            }
        }
        
        public override DataSet Clone() {
            tlg_VisualizacionDeStockDetDataset cln = ((tlg_VisualizacionDeStockDetDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_VisualizacionDeStockDet"] != null)) {
                this.Tables.Add(new tlg_VisualizacionDeStockDetDataTable(ds.Tables["tlg_VisualizacionDeStockDet"]));
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
            this.tabletlg_VisualizacionDeStockDet = ((tlg_VisualizacionDeStockDetDataTable)(this.Tables["tlg_VisualizacionDeStockDet"]));
            if ((this.tabletlg_VisualizacionDeStockDet != null)) {
                this.tabletlg_VisualizacionDeStockDet.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_VisualizacionDeStockDetDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_VisualizacionDeStockDet.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_VisualizacionDeStockDet = new tlg_VisualizacionDeStockDetDataTable();
            this.Tables.Add(this.tabletlg_VisualizacionDeStockDet);
        }
        
        private bool ShouldSerializetlg_VisualizacionDeStockDet() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_VisualizacionDeStockDetRowChangeEventHandler(object sender, tlg_VisualizacionDeStockDetRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_VisualizacionDeStockDetDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdVisualizacionDeStock;
            
            private DataColumn columnIdEstadoDeStock;
            
            private DataColumn columnOperacion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tlg_VisualizacionDeStockDetDataTable() : 
                    base("tlg_VisualizacionDeStockDet") {
                this.InitClass();
            }
            
            internal tlg_VisualizacionDeStockDetDataTable(DataTable table) : 
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
            
            internal DataColumn IdEstadoDeStockColumn {
                get {
                    return this.columnIdEstadoDeStock;
                }
            }
            
            internal DataColumn OperacionColumn {
                get {
                    return this.columnOperacion;
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
            
            public tlg_VisualizacionDeStockDetRow this[int index] {
                get {
                    return ((tlg_VisualizacionDeStockDetRow)(this.Rows[index]));
                }
            }
            
            public event tlg_VisualizacionDeStockDetRowChangeEventHandler tlg_VisualizacionDeStockDetRowChanged;
            
            public event tlg_VisualizacionDeStockDetRowChangeEventHandler tlg_VisualizacionDeStockDetRowChanging;
            
            public event tlg_VisualizacionDeStockDetRowChangeEventHandler tlg_VisualizacionDeStockDetRowDeleted;
            
            public event tlg_VisualizacionDeStockDetRowChangeEventHandler tlg_VisualizacionDeStockDetRowDeleting;
            
            public void Addtlg_VisualizacionDeStockDetRow(tlg_VisualizacionDeStockDetRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_VisualizacionDeStockDetRow Addtlg_VisualizacionDeStockDetRow(string IdVisualizacionDeStock, string IdEstadoDeStock, short Operacion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tlg_VisualizacionDeStockDetRow rowtlg_VisualizacionDeStockDetRow = ((tlg_VisualizacionDeStockDetRow)(this.NewRow()));
                rowtlg_VisualizacionDeStockDetRow.ItemArray = new object[] {
                        IdVisualizacionDeStock,
                        IdEstadoDeStock,
                        Operacion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtlg_VisualizacionDeStockDetRow);
                return rowtlg_VisualizacionDeStockDetRow;
            }
            
            public tlg_VisualizacionDeStockDetRow FindByIdVisualizacionDeStockIdEstadoDeStock(string IdVisualizacionDeStock, string IdEstadoDeStock) {
                return ((tlg_VisualizacionDeStockDetRow)(this.Rows.Find(new object[] {
                            IdVisualizacionDeStock,
                            IdEstadoDeStock})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_VisualizacionDeStockDetDataTable cln = ((tlg_VisualizacionDeStockDetDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_VisualizacionDeStockDetDataTable();
            }
            
            internal void InitVars() {
                this.columnIdVisualizacionDeStock = this.Columns["IdVisualizacionDeStock"];
                this.columnIdEstadoDeStock = this.Columns["IdEstadoDeStock"];
                this.columnOperacion = this.Columns["Operacion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
            }
            
            private void InitClass() {
                this.columnIdVisualizacionDeStock = new DataColumn("IdVisualizacionDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdVisualizacionDeStock);
                this.columnIdEstadoDeStock = new DataColumn("IdEstadoDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEstadoDeStock);
                this.columnOperacion = new DataColumn("Operacion", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOperacion);
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
                this.Constraints.Add(new UniqueConstraint("tlg_VisualizacionDeStockDetKey1", new DataColumn[] {
                                this.columnIdVisualizacionDeStock,
                                this.columnIdEstadoDeStock}, true));
                this.columnIdVisualizacionDeStock.AllowDBNull = false;
                this.columnIdEstadoDeStock.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
                this.columnIdEmpresa.AllowDBNull = false;
            }
            
            public tlg_VisualizacionDeStockDetRow Newtlg_VisualizacionDeStockDetRow() {
                return ((tlg_VisualizacionDeStockDetRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_VisualizacionDeStockDetRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_VisualizacionDeStockDetRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_VisualizacionDeStockDetRowChanged != null)) {
                    this.tlg_VisualizacionDeStockDetRowChanged(this, new tlg_VisualizacionDeStockDetRowChangeEvent(((tlg_VisualizacionDeStockDetRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_VisualizacionDeStockDetRowChanging != null)) {
                    this.tlg_VisualizacionDeStockDetRowChanging(this, new tlg_VisualizacionDeStockDetRowChangeEvent(((tlg_VisualizacionDeStockDetRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_VisualizacionDeStockDetRowDeleted != null)) {
                    this.tlg_VisualizacionDeStockDetRowDeleted(this, new tlg_VisualizacionDeStockDetRowChangeEvent(((tlg_VisualizacionDeStockDetRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_VisualizacionDeStockDetRowDeleting != null)) {
                    this.tlg_VisualizacionDeStockDetRowDeleting(this, new tlg_VisualizacionDeStockDetRowChangeEvent(((tlg_VisualizacionDeStockDetRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_VisualizacionDeStockDetRow(tlg_VisualizacionDeStockDetRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_VisualizacionDeStockDetRow : DataRow {
            
            private tlg_VisualizacionDeStockDetDataTable tabletlg_VisualizacionDeStockDet;
            
            internal tlg_VisualizacionDeStockDetRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_VisualizacionDeStockDet = ((tlg_VisualizacionDeStockDetDataTable)(this.Table));
            }
            
            public string IdVisualizacionDeStock {
                get {
                    return ((string)(this[this.tabletlg_VisualizacionDeStockDet.IdVisualizacionDeStockColumn]));
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdVisualizacionDeStockColumn] = value;
                }
            }
            
            public string IdEstadoDeStock {
                get {
                    return ((string)(this[this.tabletlg_VisualizacionDeStockDet.IdEstadoDeStockColumn]));
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdEstadoDeStockColumn] = value;
                }
            }
            
            public short Operacion {
                get {
                    try {
                        return ((short)(this[this.tabletlg_VisualizacionDeStockDet.OperacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.OperacionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_VisualizacionDeStockDet.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStockDet.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_VisualizacionDeStockDet.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStockDet.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStockDet.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_VisualizacionDeStockDet.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_VisualizacionDeStockDet.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    return ((long)(this[this.tabletlg_VisualizacionDeStockDet.IdEmpresaColumn]));
                }
                set {
                    this[this.tabletlg_VisualizacionDeStockDet.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsOperacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.OperacionColumn);
            }
            
            public void SetOperacionNull() {
                this[this.tabletlg_VisualizacionDeStockDet.OperacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_VisualizacionDeStockDet.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_VisualizacionDeStockDet.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_VisualizacionDeStockDet.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_VisualizacionDeStockDet.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_VisualizacionDeStockDet.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_VisualizacionDeStockDet.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_VisualizacionDeStockDet.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_VisualizacionDeStockDet.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_VisualizacionDeStockDetRowChangeEvent : EventArgs {
            
            private tlg_VisualizacionDeStockDetRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_VisualizacionDeStockDetRowChangeEvent(tlg_VisualizacionDeStockDetRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_VisualizacionDeStockDetRow Row {
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
