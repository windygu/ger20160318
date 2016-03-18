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
    public class tfi_PagosMovimientosCajasDataset : DataSet {
        
        private tfi_PagosMovimientosCajasDataTable tabletfi_PagosMovimientosCajas;
        
        public tfi_PagosMovimientosCajasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tfi_PagosMovimientosCajasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tfi_PagosMovimientosCajas"] != null)) {
                    this.Tables.Add(new tfi_PagosMovimientosCajasDataTable(ds.Tables["tfi_PagosMovimientosCajas"]));
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
        public tfi_PagosMovimientosCajasDataTable tfi_PagosMovimientosCajas {
            get {
                return this.tabletfi_PagosMovimientosCajas;
            }
        }
        
        public override DataSet Clone() {
            tfi_PagosMovimientosCajasDataset cln = ((tfi_PagosMovimientosCajasDataset)(base.Clone()));
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
            if ((ds.Tables["tfi_PagosMovimientosCajas"] != null)) {
                this.Tables.Add(new tfi_PagosMovimientosCajasDataTable(ds.Tables["tfi_PagosMovimientosCajas"]));
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
            this.tabletfi_PagosMovimientosCajas = ((tfi_PagosMovimientosCajasDataTable)(this.Tables["tfi_PagosMovimientosCajas"]));
            if ((this.tabletfi_PagosMovimientosCajas != null)) {
                this.tabletfi_PagosMovimientosCajas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tfi_PagosMovimientosCajasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tfi_PagosMovimientosCajas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletfi_PagosMovimientosCajas = new tfi_PagosMovimientosCajasDataTable();
            this.Tables.Add(this.tabletfi_PagosMovimientosCajas);
        }
        
        private bool ShouldSerializetfi_PagosMovimientosCajas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tfi_PagosMovimientosCajasRowChangeEventHandler(object sender, tfi_PagosMovimientosCajasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_PagosMovimientosCajasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdMovimiento;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdInstanciaCaja;
            
            private DataColumn columnIdTipoDeMovimiento;
            
            private DataColumn columnNumero;
            
            private DataColumn columnIdValor;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            internal tfi_PagosMovimientosCajasDataTable() : 
                    base("tfi_PagosMovimientosCajas") {
                this.InitClass();
            }
            
            internal tfi_PagosMovimientosCajasDataTable(DataTable table) : 
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
            
            internal DataColumn IdMovimientoColumn {
                get {
                    return this.columnIdMovimiento;
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
            
            internal DataColumn IdInstanciaCajaColumn {
                get {
                    return this.columnIdInstanciaCaja;
                }
            }
            
            internal DataColumn IdTipoDeMovimientoColumn {
                get {
                    return this.columnIdTipoDeMovimiento;
                }
            }
            
            internal DataColumn NumeroColumn {
                get {
                    return this.columnNumero;
                }
            }
            
            internal DataColumn IdValorColumn {
                get {
                    return this.columnIdValor;
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
            
            public tfi_PagosMovimientosCajasRow this[int index] {
                get {
                    return ((tfi_PagosMovimientosCajasRow)(this.Rows[index]));
                }
            }
            
            public event tfi_PagosMovimientosCajasRowChangeEventHandler tfi_PagosMovimientosCajasRowChanged;
            
            public event tfi_PagosMovimientosCajasRowChangeEventHandler tfi_PagosMovimientosCajasRowChanging;
            
            public event tfi_PagosMovimientosCajasRowChangeEventHandler tfi_PagosMovimientosCajasRowDeleted;
            
            public event tfi_PagosMovimientosCajasRowChangeEventHandler tfi_PagosMovimientosCajasRowDeleting;
            
            public void Addtfi_PagosMovimientosCajasRow(tfi_PagosMovimientosCajasRow row) {
                this.Rows.Add(row);
            }
            
            public tfi_PagosMovimientosCajasRow Addtfi_PagosMovimientosCajasRow(string IdMovimiento, string IdEmpresa, string IdSucursal, string IdInstanciaCaja, string IdTipoDeMovimiento, string Numero, string IdValor, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, System.Guid RowId) {
                tfi_PagosMovimientosCajasRow rowtfi_PagosMovimientosCajasRow = ((tfi_PagosMovimientosCajasRow)(this.NewRow()));
                rowtfi_PagosMovimientosCajasRow.ItemArray = new object[] {
                        IdMovimiento,
                        IdEmpresa,
                        IdSucursal,
                        IdInstanciaCaja,
                        IdTipoDeMovimiento,
                        Numero,
                        IdValor,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId};
                this.Rows.Add(rowtfi_PagosMovimientosCajasRow);
                return rowtfi_PagosMovimientosCajasRow;
            }
            
            public tfi_PagosMovimientosCajasRow FindByIdMovimientoIdValor(string IdMovimiento, string IdValor) {
                return ((tfi_PagosMovimientosCajasRow)(this.Rows.Find(new object[] {
                            IdMovimiento,
                            IdValor})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tfi_PagosMovimientosCajasDataTable cln = ((tfi_PagosMovimientosCajasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tfi_PagosMovimientosCajasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdMovimiento = this.Columns["IdMovimiento"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdInstanciaCaja = this.Columns["IdInstanciaCaja"];
                this.columnIdTipoDeMovimiento = this.Columns["IdTipoDeMovimiento"];
                this.columnNumero = this.Columns["Numero"];
                this.columnIdValor = this.Columns["IdValor"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
            }
            
            private void InitClass() {
                this.columnIdMovimiento = new DataColumn("IdMovimiento", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMovimiento);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdInstanciaCaja = new DataColumn("IdInstanciaCaja", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdInstanciaCaja);
                this.columnIdTipoDeMovimiento = new DataColumn("IdTipoDeMovimiento", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdTipoDeMovimiento);
                this.columnNumero = new DataColumn("Numero", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnNumero);
                this.columnIdValor = new DataColumn("IdValor", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdValor);
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
                this.Constraints.Add(new UniqueConstraint("tfi_PagosMovimientosCajasKey1", new DataColumn[] {
                                this.columnIdMovimiento,
                                this.columnIdValor}, true));
                this.columnIdMovimiento.AllowDBNull = false;
                this.columnIdValor.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public tfi_PagosMovimientosCajasRow Newtfi_PagosMovimientosCajasRow() {
                return ((tfi_PagosMovimientosCajasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tfi_PagosMovimientosCajasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tfi_PagosMovimientosCajasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tfi_PagosMovimientosCajasRowChanged != null)) {
                    this.tfi_PagosMovimientosCajasRowChanged(this, new tfi_PagosMovimientosCajasRowChangeEvent(((tfi_PagosMovimientosCajasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tfi_PagosMovimientosCajasRowChanging != null)) {
                    this.tfi_PagosMovimientosCajasRowChanging(this, new tfi_PagosMovimientosCajasRowChangeEvent(((tfi_PagosMovimientosCajasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tfi_PagosMovimientosCajasRowDeleted != null)) {
                    this.tfi_PagosMovimientosCajasRowDeleted(this, new tfi_PagosMovimientosCajasRowChangeEvent(((tfi_PagosMovimientosCajasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tfi_PagosMovimientosCajasRowDeleting != null)) {
                    this.tfi_PagosMovimientosCajasRowDeleting(this, new tfi_PagosMovimientosCajasRowChangeEvent(((tfi_PagosMovimientosCajasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetfi_PagosMovimientosCajasRow(tfi_PagosMovimientosCajasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_PagosMovimientosCajasRow : DataRow {
            
            private tfi_PagosMovimientosCajasDataTable tabletfi_PagosMovimientosCajas;
            
            internal tfi_PagosMovimientosCajasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletfi_PagosMovimientosCajas = ((tfi_PagosMovimientosCajasDataTable)(this.Table));
            }
            
            public string IdMovimiento {
                get {
                    return ((string)(this[this.tabletfi_PagosMovimientosCajas.IdMovimientoColumn]));
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdMovimientoColumn] = value;
                }
            }
            
            public string IdEmpresa {
                get {
                    try {
                        return ((string)(this[this.tabletfi_PagosMovimientosCajas.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdEmpresaColumn] = value;
                }
            }
            
            public string IdSucursal {
                get {
                    try {
                        return ((string)(this[this.tabletfi_PagosMovimientosCajas.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdSucursalColumn] = value;
                }
            }
            
            public string IdInstanciaCaja {
                get {
                    try {
                        return ((string)(this[this.tabletfi_PagosMovimientosCajas.IdInstanciaCajaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdInstanciaCajaColumn] = value;
                }
            }
            
            public string IdTipoDeMovimiento {
                get {
                    try {
                        return ((string)(this[this.tabletfi_PagosMovimientosCajas.IdTipoDeMovimientoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdTipoDeMovimientoColumn] = value;
                }
            }
            
            public string Numero {
                get {
                    try {
                        return ((string)(this[this.tabletfi_PagosMovimientosCajas.NumeroColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.NumeroColumn] = value;
                }
            }
            
            public string IdValor {
                get {
                    return ((string)(this[this.tabletfi_PagosMovimientosCajas.IdValorColumn]));
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdValorColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletfi_PagosMovimientosCajas.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_PagosMovimientosCajas.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletfi_PagosMovimientosCajas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletfi_PagosMovimientosCajas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletfi_PagosMovimientosCajas.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.IdReservadoColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tabletfi_PagosMovimientosCajas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletfi_PagosMovimientosCajas.RowIdColumn] = value;
                }
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdInstanciaCajaNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdInstanciaCajaColumn);
            }
            
            public void SetIdInstanciaCajaNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdInstanciaCajaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdTipoDeMovimientoNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdTipoDeMovimientoColumn);
            }
            
            public void SetIdTipoDeMovimientoNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdTipoDeMovimientoColumn] = System.Convert.DBNull;
            }
            
            public bool IsNumeroNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.NumeroColumn);
            }
            
            public void SetNumeroNull() {
                this[this.tabletfi_PagosMovimientosCajas.NumeroColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletfi_PagosMovimientosCajas.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletfi_PagosMovimientosCajas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletfi_PagosMovimientosCajas.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletfi_PagosMovimientosCajas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletfi_PagosMovimientosCajas.RowIdColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tfi_PagosMovimientosCajasRowChangeEvent : EventArgs {
            
            private tfi_PagosMovimientosCajasRow eventRow;
            
            private DataRowAction eventAction;
            
            public tfi_PagosMovimientosCajasRowChangeEvent(tfi_PagosMovimientosCajasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tfi_PagosMovimientosCajasRow Row {
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
