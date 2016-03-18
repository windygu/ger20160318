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
    public class tlg_StockNumerosDeSerieDataset : DataSet {
        
        private tlg_StockNumerosDeSerieDataTable tabletlg_StockNumerosDeSerie;
        
        public tlg_StockNumerosDeSerieDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tlg_StockNumerosDeSerieDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tlg_StockNumerosDeSerie"] != null)) {
                    this.Tables.Add(new tlg_StockNumerosDeSerieDataTable(ds.Tables["tlg_StockNumerosDeSerie"]));
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
        public tlg_StockNumerosDeSerieDataTable tlg_StockNumerosDeSerie {
            get {
                return this.tabletlg_StockNumerosDeSerie;
            }
        }
        
        public override DataSet Clone() {
            tlg_StockNumerosDeSerieDataset cln = ((tlg_StockNumerosDeSerieDataset)(base.Clone()));
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
            if ((ds.Tables["tlg_StockNumerosDeSerie"] != null)) {
                this.Tables.Add(new tlg_StockNumerosDeSerieDataTable(ds.Tables["tlg_StockNumerosDeSerie"]));
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
            this.tabletlg_StockNumerosDeSerie = ((tlg_StockNumerosDeSerieDataTable)(this.Tables["tlg_StockNumerosDeSerie"]));
            if ((this.tabletlg_StockNumerosDeSerie != null)) {
                this.tabletlg_StockNumerosDeSerie.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tlg_StockNumerosDeSerieDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tlg_StockNumerosDeSerie.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletlg_StockNumerosDeSerie = new tlg_StockNumerosDeSerieDataTable();
            this.Tables.Add(this.tabletlg_StockNumerosDeSerie);
        }
        
        private bool ShouldSerializetlg_StockNumerosDeSerie() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tlg_StockNumerosDeSerieRowChangeEventHandler(object sender, tlg_StockNumerosDeSerieRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_StockNumerosDeSerieDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdStockNumerosDeSerie;
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnIdDeposito;
            
            private DataColumn columnIdSeccion;
            
            private DataColumn columnIdEstadoDeStock;
            
            private DataColumn columnNumeroDeSerie;
            
            private DataColumn columnObservaciones;
            
            private DataColumn columnAux1;
            
            private DataColumn columnAux2;
            
            private DataColumn columnAux3;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            internal tlg_StockNumerosDeSerieDataTable() : 
                    base("tlg_StockNumerosDeSerie") {
                this.InitClass();
            }
            
            internal tlg_StockNumerosDeSerieDataTable(DataTable table) : 
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
            
            internal DataColumn IdStockNumerosDeSerieColumn {
                get {
                    return this.columnIdStockNumerosDeSerie;
                }
            }
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
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
            
            internal DataColumn IdEstadoDeStockColumn {
                get {
                    return this.columnIdEstadoDeStock;
                }
            }
            
            internal DataColumn NumeroDeSerieColumn {
                get {
                    return this.columnNumeroDeSerie;
                }
            }
            
            internal DataColumn ObservacionesColumn {
                get {
                    return this.columnObservaciones;
                }
            }
            
            internal DataColumn Aux1Column {
                get {
                    return this.columnAux1;
                }
            }
            
            internal DataColumn Aux2Column {
                get {
                    return this.columnAux2;
                }
            }
            
            internal DataColumn Aux3Column {
                get {
                    return this.columnAux3;
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
            
            public tlg_StockNumerosDeSerieRow this[int index] {
                get {
                    return ((tlg_StockNumerosDeSerieRow)(this.Rows[index]));
                }
            }
            
            public event tlg_StockNumerosDeSerieRowChangeEventHandler tlg_StockNumerosDeSerieRowChanged;
            
            public event tlg_StockNumerosDeSerieRowChangeEventHandler tlg_StockNumerosDeSerieRowChanging;
            
            public event tlg_StockNumerosDeSerieRowChangeEventHandler tlg_StockNumerosDeSerieRowDeleted;
            
            public event tlg_StockNumerosDeSerieRowChangeEventHandler tlg_StockNumerosDeSerieRowDeleting;
            
            public void Addtlg_StockNumerosDeSerieRow(tlg_StockNumerosDeSerieRow row) {
                this.Rows.Add(row);
            }
            
            public tlg_StockNumerosDeSerieRow Addtlg_StockNumerosDeSerieRow(
                        string IdStockNumerosDeSerie, 
                        string IdProducto, 
                        string IdDeposito, 
                        string IdSeccion, 
                        string IdEstadoDeStock, 
                        string NumeroDeSerie, 
                        string Observaciones, 
                        string Aux1, 
                        string Aux2, 
                        string Aux3, 
                        System.DateTime FechaCreacion, 
                        long IdConexionCreacion, 
                        System.Byte[] UltimaModificacion, 
                        long IdConexionUltimaModificacion, 
                        long IdReservado, 
                        System.Guid RowId, 
                        long IdEmpresa, 
                        long IdSucursal) {
                tlg_StockNumerosDeSerieRow rowtlg_StockNumerosDeSerieRow = ((tlg_StockNumerosDeSerieRow)(this.NewRow()));
                rowtlg_StockNumerosDeSerieRow.ItemArray = new object[] {
                        IdStockNumerosDeSerie,
                        IdProducto,
                        IdDeposito,
                        IdSeccion,
                        IdEstadoDeStock,
                        NumeroDeSerie,
                        Observaciones,
                        Aux1,
                        Aux2,
                        Aux3,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal};
                this.Rows.Add(rowtlg_StockNumerosDeSerieRow);
                return rowtlg_StockNumerosDeSerieRow;
            }
            
            public tlg_StockNumerosDeSerieRow FindByIdStockNumerosDeSerie(string IdStockNumerosDeSerie) {
                return ((tlg_StockNumerosDeSerieRow)(this.Rows.Find(new object[] {
                            IdStockNumerosDeSerie})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tlg_StockNumerosDeSerieDataTable cln = ((tlg_StockNumerosDeSerieDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tlg_StockNumerosDeSerieDataTable();
            }
            
            internal void InitVars() {
                this.columnIdStockNumerosDeSerie = this.Columns["IdStockNumerosDeSerie"];
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnIdDeposito = this.Columns["IdDeposito"];
                this.columnIdSeccion = this.Columns["IdSeccion"];
                this.columnIdEstadoDeStock = this.Columns["IdEstadoDeStock"];
                this.columnNumeroDeSerie = this.Columns["NumeroDeSerie"];
                this.columnObservaciones = this.Columns["Observaciones"];
                this.columnAux1 = this.Columns["Aux1"];
                this.columnAux2 = this.Columns["Aux2"];
                this.columnAux3 = this.Columns["Aux3"];
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
                this.columnIdStockNumerosDeSerie = new DataColumn("IdStockNumerosDeSerie", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdStockNumerosDeSerie);
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnIdDeposito = new DataColumn("IdDeposito", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdDeposito);
                this.columnIdSeccion = new DataColumn("IdSeccion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSeccion);
                this.columnIdEstadoDeStock = new DataColumn("IdEstadoDeStock", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEstadoDeStock);
                this.columnNumeroDeSerie = new DataColumn("NumeroDeSerie", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNumeroDeSerie);
                this.columnObservaciones = new DataColumn("Observaciones", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnObservaciones);
                this.columnAux1 = new DataColumn("Aux1", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAux1);
                this.columnAux2 = new DataColumn("Aux2", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAux2);
                this.columnAux3 = new DataColumn("Aux3", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnAux3);
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
                this.Constraints.Add(new UniqueConstraint("tlg_StockNumerosDeSerieKey1", new DataColumn[] {
                                this.columnIdStockNumerosDeSerie}, true));
                this.columnIdStockNumerosDeSerie.AllowDBNull = false;
                this.columnIdStockNumerosDeSerie.Unique = true;
                this.columnIdProducto.AllowDBNull = false;
                this.columnIdDeposito.AllowDBNull = false;
                this.columnIdSeccion.AllowDBNull = false;
                this.columnNumeroDeSerie.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tlg_StockNumerosDeSerieRow Newtlg_StockNumerosDeSerieRow() {
                return ((tlg_StockNumerosDeSerieRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tlg_StockNumerosDeSerieRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tlg_StockNumerosDeSerieRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tlg_StockNumerosDeSerieRowChanged != null)) {
                    this.tlg_StockNumerosDeSerieRowChanged(this, new tlg_StockNumerosDeSerieRowChangeEvent(((tlg_StockNumerosDeSerieRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tlg_StockNumerosDeSerieRowChanging != null)) {
                    this.tlg_StockNumerosDeSerieRowChanging(this, new tlg_StockNumerosDeSerieRowChangeEvent(((tlg_StockNumerosDeSerieRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tlg_StockNumerosDeSerieRowDeleted != null)) {
                    this.tlg_StockNumerosDeSerieRowDeleted(this, new tlg_StockNumerosDeSerieRowChangeEvent(((tlg_StockNumerosDeSerieRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tlg_StockNumerosDeSerieRowDeleting != null)) {
                    this.tlg_StockNumerosDeSerieRowDeleting(this, new tlg_StockNumerosDeSerieRowChangeEvent(((tlg_StockNumerosDeSerieRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetlg_StockNumerosDeSerieRow(tlg_StockNumerosDeSerieRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_StockNumerosDeSerieRow : DataRow {
            
            private tlg_StockNumerosDeSerieDataTable tabletlg_StockNumerosDeSerie;
            
            internal tlg_StockNumerosDeSerieRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletlg_StockNumerosDeSerie = ((tlg_StockNumerosDeSerieDataTable)(this.Table));
            }
            
            public string IdStockNumerosDeSerie {
                get {
                    return ((string)(this[this.tabletlg_StockNumerosDeSerie.IdStockNumerosDeSerieColumn]));
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdStockNumerosDeSerieColumn] = value;
                }
            }
            
            public string IdProducto {
                get {
                    return ((string)(this[this.tabletlg_StockNumerosDeSerie.IdProductoColumn]));
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdProductoColumn] = value;
                }
            }
            
            public string IdDeposito {
                get {
                    return ((string)(this[this.tabletlg_StockNumerosDeSerie.IdDepositoColumn]));
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdDepositoColumn] = value;
                }
            }
            
            public string IdSeccion {
                get {
                    return ((string)(this[this.tabletlg_StockNumerosDeSerie.IdSeccionColumn]));
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdSeccionColumn] = value;
                }
            }
            
            public string IdEstadoDeStock {
                get {
                    try {
                        return ((string)(this[this.tabletlg_StockNumerosDeSerie.IdEstadoDeStockColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdEstadoDeStockColumn] = value;
                }
            }
            
            public string NumeroDeSerie {
                get {
                    return ((string)(this[this.tabletlg_StockNumerosDeSerie.NumeroDeSerieColumn]));
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.NumeroDeSerieColumn] = value;
                }
            }
            
            public string Observaciones {
                get {
                    try {
                        return ((string)(this[this.tabletlg_StockNumerosDeSerie.ObservacionesColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.ObservacionesColumn] = value;
                }
            }
            
            public string Aux1 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_StockNumerosDeSerie.Aux1Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.Aux1Column] = value;
                }
            }
            
            public string Aux2 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_StockNumerosDeSerie.Aux2Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.Aux2Column] = value;
                }
            }
            
            public string Aux3 {
                get {
                    try {
                        return ((string)(this[this.tabletlg_StockNumerosDeSerie.Aux3Column]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.Aux3Column] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletlg_StockNumerosDeSerie.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_StockNumerosDeSerie.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletlg_StockNumerosDeSerie.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletlg_StockNumerosDeSerie.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletlg_StockNumerosDeSerie.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletlg_StockNumerosDeSerie.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletlg_StockNumerosDeSerie.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletlg_StockNumerosDeSerie.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletlg_StockNumerosDeSerie.IdSucursalColumn] = value;
                }
            }
            
            public bool IsIdEstadoDeStockNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.IdEstadoDeStockColumn);
            }
            
            public void SetIdEstadoDeStockNull() {
                this[this.tabletlg_StockNumerosDeSerie.IdEstadoDeStockColumn] = System.Convert.DBNull;
            }
            
            public bool IsObservacionesNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.ObservacionesColumn);
            }
            
            public void SetObservacionesNull() {
                this[this.tabletlg_StockNumerosDeSerie.ObservacionesColumn] = System.Convert.DBNull;
            }
            
            public bool IsAux1Null() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.Aux1Column);
            }
            
            public void SetAux1Null() {
                this[this.tabletlg_StockNumerosDeSerie.Aux1Column] = System.Convert.DBNull;
            }
            
            public bool IsAux2Null() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.Aux2Column);
            }
            
            public void SetAux2Null() {
                this[this.tabletlg_StockNumerosDeSerie.Aux2Column] = System.Convert.DBNull;
            }
            
            public bool IsAux3Null() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.Aux3Column);
            }
            
            public void SetAux3Null() {
                this[this.tabletlg_StockNumerosDeSerie.Aux3Column] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletlg_StockNumerosDeSerie.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletlg_StockNumerosDeSerie.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletlg_StockNumerosDeSerie.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletlg_StockNumerosDeSerie.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletlg_StockNumerosDeSerie.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletlg_StockNumerosDeSerie.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletlg_StockNumerosDeSerie.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletlg_StockNumerosDeSerie.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletlg_StockNumerosDeSerie.IdSucursalColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tlg_StockNumerosDeSerieRowChangeEvent : EventArgs {
            
            private tlg_StockNumerosDeSerieRow eventRow;
            
            private DataRowAction eventAction;
            
            public tlg_StockNumerosDeSerieRowChangeEvent(tlg_StockNumerosDeSerieRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tlg_StockNumerosDeSerieRow Row {
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
