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
    public class tpu_RemitosCompComprasDetExDataset : DataSet {
        
        private tpu_RemitosCompComprasDetDataTable tabletpu_RemitosCompComprasDet;
        
        public tpu_RemitosCompComprasDetExDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tpu_RemitosCompComprasDetExDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tpu_RemitosCompComprasDet"] != null)) {
                    this.Tables.Add(new tpu_RemitosCompComprasDetDataTable(ds.Tables["tpu_RemitosCompComprasDet"]));
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
        public tpu_RemitosCompComprasDetDataTable tpu_RemitosCompComprasDet {
            get {
                return this.tabletpu_RemitosCompComprasDet;
            }
        }
        
        public override DataSet Clone() {
            tpu_RemitosCompComprasDetExDataset cln = ((tpu_RemitosCompComprasDetExDataset)(base.Clone()));
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
            if ((ds.Tables["tpu_RemitosCompComprasDet"] != null)) {
                this.Tables.Add(new tpu_RemitosCompComprasDetDataTable(ds.Tables["tpu_RemitosCompComprasDet"]));
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
            this.tabletpu_RemitosCompComprasDet = ((tpu_RemitosCompComprasDetDataTable)(this.Tables["tpu_RemitosCompComprasDet"]));
            if ((this.tabletpu_RemitosCompComprasDet != null)) {
                this.tabletpu_RemitosCompComprasDet.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tpu_RemitosCompComprasDetExDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tpu_RemitosCompComprasDetEx.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletpu_RemitosCompComprasDet = new tpu_RemitosCompComprasDetDataTable();
            this.Tables.Add(this.tabletpu_RemitosCompComprasDet);
        }
        
        private bool ShouldSerializetpu_RemitosCompComprasDet() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tpu_RemitosCompComprasDetRowChangeEventHandler(object sender, tpu_RemitosCompComprasDetRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_RemitosCompComprasDetDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdComprobanteCompra;
            
            private DataColumn columnRenglonCompra;
            
            private DataColumn columnIdRemitoCompra;
            
            private DataColumn columnRenglonRemito;
            
            private DataColumn columnCantidad;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            internal tpu_RemitosCompComprasDetDataTable() : 
                    base("tpu_RemitosCompComprasDet") {
                this.InitClass();
            }
            
            internal tpu_RemitosCompComprasDetDataTable(DataTable table) : 
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
            
            internal DataColumn IdComprobanteCompraColumn {
                get {
                    return this.columnIdComprobanteCompra;
                }
            }
            
            internal DataColumn RenglonCompraColumn {
                get {
                    return this.columnRenglonCompra;
                }
            }
            
            internal DataColumn IdRemitoCompraColumn {
                get {
                    return this.columnIdRemitoCompra;
                }
            }
            
            internal DataColumn RenglonRemitoColumn {
                get {
                    return this.columnRenglonRemito;
                }
            }
            
            internal DataColumn CantidadColumn {
                get {
                    return this.columnCantidad;
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
            
            public tpu_RemitosCompComprasDetRow this[int index] {
                get {
                    return ((tpu_RemitosCompComprasDetRow)(this.Rows[index]));
                }
            }
            
            public event tpu_RemitosCompComprasDetRowChangeEventHandler tpu_RemitosCompComprasDetRowChanged;
            
            public event tpu_RemitosCompComprasDetRowChangeEventHandler tpu_RemitosCompComprasDetRowChanging;
            
            public event tpu_RemitosCompComprasDetRowChangeEventHandler tpu_RemitosCompComprasDetRowDeleted;
            
            public event tpu_RemitosCompComprasDetRowChangeEventHandler tpu_RemitosCompComprasDetRowDeleting;
            
            public void Addtpu_RemitosCompComprasDetRow(tpu_RemitosCompComprasDetRow row) {
                this.Rows.Add(row);
            }
            
            public tpu_RemitosCompComprasDetRow Addtpu_RemitosCompComprasDetRow(long IdComprobanteCompra, short RenglonCompra, long IdRemitoCompra, short RenglonRemito, System.Decimal Cantidad, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId, long IdSucursal, long IdEmpresa) {
                tpu_RemitosCompComprasDetRow rowtpu_RemitosCompComprasDetRow = ((tpu_RemitosCompComprasDetRow)(this.NewRow()));
                rowtpu_RemitosCompComprasDetRow.ItemArray = new object[] {
                        IdComprobanteCompra,
                        RenglonCompra,
                        IdRemitoCompra,
                        RenglonRemito,
                        Cantidad,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa};
                this.Rows.Add(rowtpu_RemitosCompComprasDetRow);
                return rowtpu_RemitosCompComprasDetRow;
            }
            
            public tpu_RemitosCompComprasDetRow FindByIdComprobanteCompra(long IdComprobanteCompra) {
                return ((tpu_RemitosCompComprasDetRow)(this.Rows.Find(new object[] {
                            IdComprobanteCompra})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tpu_RemitosCompComprasDetDataTable cln = ((tpu_RemitosCompComprasDetDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tpu_RemitosCompComprasDetDataTable();
            }
            
            internal void InitVars() {
                this.columnIdComprobanteCompra = this.Columns["IdComprobanteCompra"];
                this.columnRenglonCompra = this.Columns["RenglonCompra"];
                this.columnIdRemitoCompra = this.Columns["IdRemitoCompra"];
                this.columnRenglonRemito = this.Columns["RenglonRemito"];
                this.columnCantidad = this.Columns["Cantidad"];
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
                this.columnIdComprobanteCompra = new DataColumn("IdComprobanteCompra", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdComprobanteCompra);
                this.columnRenglonCompra = new DataColumn("RenglonCompra", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRenglonCompra);
                this.columnIdRemitoCompra = new DataColumn("IdRemitoCompra", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRemitoCompra);
                this.columnRenglonRemito = new DataColumn("RenglonRemito", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRenglonRemito);
                this.columnCantidad = new DataColumn("Cantidad", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCantidad);
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
                this.Constraints.Add(new UniqueConstraint("tpu_RemitosCompComprasDetExKey1", new DataColumn[] {
                                this.columnIdComprobanteCompra}, true));
                this.columnIdComprobanteCompra.AllowDBNull = false;
                this.columnIdComprobanteCompra.Unique = true;
                this.columnRenglonCompra.AllowDBNull = false;
                this.columnIdRemitoCompra.AllowDBNull = false;
                this.columnRenglonRemito.AllowDBNull = false;
                this.columnCantidad.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tpu_RemitosCompComprasDetRow Newtpu_RemitosCompComprasDetRow() {
                return ((tpu_RemitosCompComprasDetRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tpu_RemitosCompComprasDetRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tpu_RemitosCompComprasDetRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tpu_RemitosCompComprasDetRowChanged != null)) {
                    this.tpu_RemitosCompComprasDetRowChanged(this, new tpu_RemitosCompComprasDetRowChangeEvent(((tpu_RemitosCompComprasDetRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tpu_RemitosCompComprasDetRowChanging != null)) {
                    this.tpu_RemitosCompComprasDetRowChanging(this, new tpu_RemitosCompComprasDetRowChangeEvent(((tpu_RemitosCompComprasDetRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tpu_RemitosCompComprasDetRowDeleted != null)) {
                    this.tpu_RemitosCompComprasDetRowDeleted(this, new tpu_RemitosCompComprasDetRowChangeEvent(((tpu_RemitosCompComprasDetRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tpu_RemitosCompComprasDetRowDeleting != null)) {
                    this.tpu_RemitosCompComprasDetRowDeleting(this, new tpu_RemitosCompComprasDetRowChangeEvent(((tpu_RemitosCompComprasDetRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetpu_RemitosCompComprasDetRow(tpu_RemitosCompComprasDetRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_RemitosCompComprasDetRow : DataRow {
            
            private tpu_RemitosCompComprasDetDataTable tabletpu_RemitosCompComprasDet;
            
            internal tpu_RemitosCompComprasDetRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletpu_RemitosCompComprasDet = ((tpu_RemitosCompComprasDetDataTable)(this.Table));
            }
            
            public long IdComprobanteCompra {
                get {
                    return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdComprobanteCompraColumn]));
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdComprobanteCompraColumn] = value;
                }
            }
            
            public short RenglonCompra {
                get {
                    return ((short)(this[this.tabletpu_RemitosCompComprasDet.RenglonCompraColumn]));
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.RenglonCompraColumn] = value;
                }
            }
            
            public long IdRemitoCompra {
                get {
                    return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdRemitoCompraColumn]));
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdRemitoCompraColumn] = value;
                }
            }
            
            public short RenglonRemito {
                get {
                    return ((short)(this[this.tabletpu_RemitosCompComprasDet.RenglonRemitoColumn]));
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.RenglonRemitoColumn] = value;
                }
            }
            
            public System.Decimal Cantidad {
                get {
                    return ((System.Decimal)(this[this.tabletpu_RemitosCompComprasDet.CantidadColumn]));
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.CantidadColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletpu_RemitosCompComprasDet.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletpu_RemitosCompComprasDet.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletpu_RemitosCompComprasDet.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletpu_RemitosCompComprasDet.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletpu_RemitosCompComprasDet.IdEmpresaColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletpu_RemitosCompComprasDet.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletpu_RemitosCompComprasDet.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletpu_RemitosCompComprasDet.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletpu_RemitosCompComprasDet.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletpu_RemitosCompComprasDet.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletpu_RemitosCompComprasDet.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletpu_RemitosCompComprasDet.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletpu_RemitosCompComprasDet.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletpu_RemitosCompComprasDet.IdEmpresaColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tpu_RemitosCompComprasDetRowChangeEvent : EventArgs {
            
            private tpu_RemitosCompComprasDetRow eventRow;
            
            private DataRowAction eventAction;
            
            public tpu_RemitosCompComprasDetRowChangeEvent(tpu_RemitosCompComprasDetRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tpu_RemitosCompComprasDetRow Row {
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
