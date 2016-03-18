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
    public class tsa_ComprobanteDetalleDePagosDataset : DataSet {
        
        private tsa_ComprobanteDetalleDePagosDataTable tabletsa_ComprobanteDetalleDePagos;
        
        public tsa_ComprobanteDetalleDePagosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsa_ComprobanteDetalleDePagosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsa_ComprobanteDetalleDePagos"] != null)) {
                    this.Tables.Add(new tsa_ComprobanteDetalleDePagosDataTable(ds.Tables["tsa_ComprobanteDetalleDePagos"]));
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
        public tsa_ComprobanteDetalleDePagosDataTable tsa_ComprobanteDetalleDePagos {
            get {
                return this.tabletsa_ComprobanteDetalleDePagos;
            }
        }
        
        public override DataSet Clone() {
            tsa_ComprobanteDetalleDePagosDataset cln = ((tsa_ComprobanteDetalleDePagosDataset)(base.Clone()));
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
            if ((ds.Tables["tsa_ComprobanteDetalleDePagos"] != null)) {
                this.Tables.Add(new tsa_ComprobanteDetalleDePagosDataTable(ds.Tables["tsa_ComprobanteDetalleDePagos"]));
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
            this.tabletsa_ComprobanteDetalleDePagos = ((tsa_ComprobanteDetalleDePagosDataTable)(this.Tables["tsa_ComprobanteDetalleDePagos"]));
            if ((this.tabletsa_ComprobanteDetalleDePagos != null)) {
                this.tabletsa_ComprobanteDetalleDePagos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsa_ComprobanteDetalleDePagosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsa_ComprobanteDetalleDePagos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsa_ComprobanteDetalleDePagos = new tsa_ComprobanteDetalleDePagosDataTable();
            this.Tables.Add(this.tabletsa_ComprobanteDetalleDePagos);
        }
        
        private bool ShouldSerializetsa_ComprobanteDetalleDePagos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsa_ComprobanteDetalleDePagosRowChangeEventHandler(object sender, tsa_ComprobanteDetalleDePagosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_ComprobanteDetalleDePagosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdTipoDeComprobante;
            
            private DataColumn columnNumero;
            
            private DataColumn columnIdComprobante;
            
            private DataColumn columnIdValor;
            
            private DataColumn columnMonto;
            
            private DataColumn columnIdMoneda;
            
            private DataColumn columnIdCotizaicon;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnMontoSinRecargos;
            
            private DataColumn columnIdFormaDePago;
            
            internal tsa_ComprobanteDetalleDePagosDataTable() : 
                    base("tsa_ComprobanteDetalleDePagos") {
                this.InitClass();
            }
            
            internal tsa_ComprobanteDetalleDePagosDataTable(DataTable table) : 
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
            
            internal DataColumn IdTipoDeComprobanteColumn {
                get {
                    return this.columnIdTipoDeComprobante;
                }
            }
            
            internal DataColumn NumeroColumn {
                get {
                    return this.columnNumero;
                }
            }
            
            internal DataColumn IdComprobanteColumn {
                get {
                    return this.columnIdComprobante;
                }
            }
            
            internal DataColumn IdValorColumn {
                get {
                    return this.columnIdValor;
                }
            }
            
            internal DataColumn MontoColumn {
                get {
                    return this.columnMonto;
                }
            }
            
            internal DataColumn IdMonedaColumn {
                get {
                    return this.columnIdMoneda;
                }
            }
            
            internal DataColumn IdCotizaiconColumn {
                get {
                    return this.columnIdCotizaicon;
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
            
            internal DataColumn MontoSinRecargosColumn {
                get {
                    return this.columnMontoSinRecargos;
                }
            }
            
            internal DataColumn IdFormaDePagoColumn {
                get {
                    return this.columnIdFormaDePago;
                }
            }
            
            public tsa_ComprobanteDetalleDePagosRow this[int index] {
                get {
                    return ((tsa_ComprobanteDetalleDePagosRow)(this.Rows[index]));
                }
            }
            
            public event tsa_ComprobanteDetalleDePagosRowChangeEventHandler tsa_ComprobanteDetalleDePagosRowChanged;
            
            public event tsa_ComprobanteDetalleDePagosRowChangeEventHandler tsa_ComprobanteDetalleDePagosRowChanging;
            
            public event tsa_ComprobanteDetalleDePagosRowChangeEventHandler tsa_ComprobanteDetalleDePagosRowDeleted;
            
            public event tsa_ComprobanteDetalleDePagosRowChangeEventHandler tsa_ComprobanteDetalleDePagosRowDeleting;
            
            public void Addtsa_ComprobanteDetalleDePagosRow(tsa_ComprobanteDetalleDePagosRow row) {
                this.Rows.Add(row);
            }
            
            public tsa_ComprobanteDetalleDePagosRow Addtsa_ComprobanteDetalleDePagosRow(
                        string IdTipoDeComprobante, 
                        string Numero, 
                        string IdComprobante, 
                        string IdValor, 
                        System.Decimal Monto, 
                        string IdMoneda, 
                        string IdCotizaicon, 
                        System.DateTime FechaCreacion, 
                        long IdConexionCreacion, 
                        System.Byte[] UltimaModificacion, 
                        long IdConexionUltimaModificacion, 
                        long IdReservado, 
                        System.Guid RowId, 
                        long IdSucursal, 
                        long IdEmpresa, 
                        System.Decimal MontoSinRecargos, 
                        string IdFormaDePago) {
                tsa_ComprobanteDetalleDePagosRow rowtsa_ComprobanteDetalleDePagosRow = ((tsa_ComprobanteDetalleDePagosRow)(this.NewRow()));
                rowtsa_ComprobanteDetalleDePagosRow.ItemArray = new object[] {
                        IdTipoDeComprobante,
                        Numero,
                        IdComprobante,
                        IdValor,
                        Monto,
                        IdMoneda,
                        IdCotizaicon,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdSucursal,
                        IdEmpresa,
                        MontoSinRecargos,
                        IdFormaDePago};
                this.Rows.Add(rowtsa_ComprobanteDetalleDePagosRow);
                return rowtsa_ComprobanteDetalleDePagosRow;
            }
            
            public tsa_ComprobanteDetalleDePagosRow FindByIdComprobanteIdValor(string IdComprobante, string IdValor) {
                return ((tsa_ComprobanteDetalleDePagosRow)(this.Rows.Find(new object[] {
                            IdComprobante,
                            IdValor})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsa_ComprobanteDetalleDePagosDataTable cln = ((tsa_ComprobanteDetalleDePagosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsa_ComprobanteDetalleDePagosDataTable();
            }
            
            internal void InitVars() {
                this.columnIdTipoDeComprobante = this.Columns["IdTipoDeComprobante"];
                this.columnNumero = this.Columns["Numero"];
                this.columnIdComprobante = this.Columns["IdComprobante"];
                this.columnIdValor = this.Columns["IdValor"];
                this.columnMonto = this.Columns["Monto"];
                this.columnIdMoneda = this.Columns["IdMoneda"];
                this.columnIdCotizaicon = this.Columns["IdCotizaicon"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnMontoSinRecargos = this.Columns["MontoSinRecargos"];
                this.columnIdFormaDePago = this.Columns["IdFormaDePago"];
            }
            
            private void InitClass() {
                this.columnIdTipoDeComprobante = new DataColumn("IdTipoDeComprobante", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeComprobante);
                this.columnNumero = new DataColumn("Numero", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNumero);
                this.columnIdComprobante = new DataColumn("IdComprobante", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdComprobante);
                this.columnIdValor = new DataColumn("IdValor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdValor);
                this.columnMonto = new DataColumn("Monto", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMonto);
                this.columnIdMoneda = new DataColumn("IdMoneda", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMoneda);
                this.columnIdCotizaicon = new DataColumn("IdCotizaicon", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCotizaicon);
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
                this.columnMontoSinRecargos = new DataColumn("MontoSinRecargos", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnMontoSinRecargos);
                this.columnIdFormaDePago = new DataColumn("IdFormaDePago", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdFormaDePago);
                this.Constraints.Add(new UniqueConstraint("tsa_ComprobanteDetalleDePagosDatasetKey1", new DataColumn[] {
                                this.columnIdComprobante,
                                this.columnIdValor}, true));
                this.columnIdTipoDeComprobante.AllowDBNull = false;
                this.columnNumero.AllowDBNull = false;
                this.columnIdComprobante.AllowDBNull = false;
                this.columnIdValor.AllowDBNull = false;
                this.columnMonto.AllowDBNull = false;
                this.columnIdMoneda.AllowDBNull = false;
                this.columnIdCotizaicon.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tsa_ComprobanteDetalleDePagosRow Newtsa_ComprobanteDetalleDePagosRow() {
                return ((tsa_ComprobanteDetalleDePagosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsa_ComprobanteDetalleDePagosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsa_ComprobanteDetalleDePagosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsa_ComprobanteDetalleDePagosRowChanged != null)) {
                    this.tsa_ComprobanteDetalleDePagosRowChanged(this, new tsa_ComprobanteDetalleDePagosRowChangeEvent(((tsa_ComprobanteDetalleDePagosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsa_ComprobanteDetalleDePagosRowChanging != null)) {
                    this.tsa_ComprobanteDetalleDePagosRowChanging(this, new tsa_ComprobanteDetalleDePagosRowChangeEvent(((tsa_ComprobanteDetalleDePagosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsa_ComprobanteDetalleDePagosRowDeleted != null)) {
                    this.tsa_ComprobanteDetalleDePagosRowDeleted(this, new tsa_ComprobanteDetalleDePagosRowChangeEvent(((tsa_ComprobanteDetalleDePagosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsa_ComprobanteDetalleDePagosRowDeleting != null)) {
                    this.tsa_ComprobanteDetalleDePagosRowDeleting(this, new tsa_ComprobanteDetalleDePagosRowChangeEvent(((tsa_ComprobanteDetalleDePagosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsa_ComprobanteDetalleDePagosRow(tsa_ComprobanteDetalleDePagosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_ComprobanteDetalleDePagosRow : DataRow {
            
            private tsa_ComprobanteDetalleDePagosDataTable tabletsa_ComprobanteDetalleDePagos;
            
            internal tsa_ComprobanteDetalleDePagosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsa_ComprobanteDetalleDePagos = ((tsa_ComprobanteDetalleDePagosDataTable)(this.Table));
            }
            
            public string IdTipoDeComprobante {
                get {
                    return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.IdTipoDeComprobanteColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdTipoDeComprobanteColumn] = value;
                }
            }
            
            public string Numero {
                get {
                    return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.NumeroColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.NumeroColumn] = value;
                }
            }
            
            public string IdComprobante {
                get {
                    return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.IdComprobanteColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdComprobanteColumn] = value;
                }
            }
            
            public string IdValor {
                get {
                    return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.IdValorColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdValorColumn] = value;
                }
            }
            
            public System.Decimal Monto {
                get {
                    return ((System.Decimal)(this[this.tabletsa_ComprobanteDetalleDePagos.MontoColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.MontoColumn] = value;
                }
            }
            
            public string IdMoneda {
                get {
                    return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.IdMonedaColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdMonedaColumn] = value;
                }
            }
            
            public string IdCotizaicon {
                get {
                    return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.IdCotizaiconColumn]));
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdCotizaiconColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsa_ComprobanteDetalleDePagos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComprobanteDetalleDePagos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsa_ComprobanteDetalleDePagos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComprobanteDetalleDePagos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComprobanteDetalleDePagos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletsa_ComprobanteDetalleDePagos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.RowIdColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComprobanteDetalleDePagos.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdSucursalColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsa_ComprobanteDetalleDePagos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdEmpresaColumn] = value;
                }
            }
            
            public System.Decimal MontoSinRecargos {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsa_ComprobanteDetalleDePagos.MontoSinRecargosColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.MontoSinRecargosColumn] = value;
                }
            }
            
            public string IdFormaDePago {
                get {
                    try {
                        return ((string)(this[this.tabletsa_ComprobanteDetalleDePagos.IdFormaDePagoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsa_ComprobanteDetalleDePagos.IdFormaDePagoColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsMontoSinRecargosNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.MontoSinRecargosColumn);
            }
            
            public void SetMontoSinRecargosNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.MontoSinRecargosColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdFormaDePagoNull() {
                return this.IsNull(this.tabletsa_ComprobanteDetalleDePagos.IdFormaDePagoColumn);
            }
            
            public void SetIdFormaDePagoNull() {
                this[this.tabletsa_ComprobanteDetalleDePagos.IdFormaDePagoColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsa_ComprobanteDetalleDePagosRowChangeEvent : EventArgs {
            
            private tsa_ComprobanteDetalleDePagosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsa_ComprobanteDetalleDePagosRowChangeEvent(tsa_ComprobanteDetalleDePagosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsa_ComprobanteDetalleDePagosRow Row {
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