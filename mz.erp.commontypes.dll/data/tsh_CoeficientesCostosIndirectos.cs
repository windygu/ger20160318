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
    public class tsh_CoeficientesCostosIndirectosDataset : DataSet {
        
        private tsh_CoeficientesCostosIndirectosDataTable tabletsh_CoeficientesCostosIndirectos;
        
        public tsh_CoeficientesCostosIndirectosDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected tsh_CoeficientesCostosIndirectosDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["tsh_CoeficientesCostosIndirectos"] != null)) {
                    this.Tables.Add(new tsh_CoeficientesCostosIndirectosDataTable(ds.Tables["tsh_CoeficientesCostosIndirectos"]));
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
        public tsh_CoeficientesCostosIndirectosDataTable tsh_CoeficientesCostosIndirectos {
            get {
                return this.tabletsh_CoeficientesCostosIndirectos;
            }
        }
        
        public override DataSet Clone() {
            tsh_CoeficientesCostosIndirectosDataset cln = ((tsh_CoeficientesCostosIndirectosDataset)(base.Clone()));
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
            if ((ds.Tables["tsh_CoeficientesCostosIndirectos"] != null)) {
                this.Tables.Add(new tsh_CoeficientesCostosIndirectosDataTable(ds.Tables["tsh_CoeficientesCostosIndirectos"]));
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
            this.tabletsh_CoeficientesCostosIndirectos = ((tsh_CoeficientesCostosIndirectosDataTable)(this.Tables["tsh_CoeficientesCostosIndirectos"]));
            if ((this.tabletsh_CoeficientesCostosIndirectos != null)) {
                this.tabletsh_CoeficientesCostosIndirectos.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "tsh_CoeficientesCostosIndirectosDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/tsh_CoeficientesCostosIndirectos.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tabletsh_CoeficientesCostosIndirectos = new tsh_CoeficientesCostosIndirectosDataTable();
            this.Tables.Add(this.tabletsh_CoeficientesCostosIndirectos);
        }
        
        private bool ShouldSerializetsh_CoeficientesCostosIndirectos() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void tsh_CoeficientesCostosIndirectosRowChangeEventHandler(object sender, tsh_CoeficientesCostosIndirectosRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_CoeficientesCostosIndirectosDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnIdReservado;
            
            private DataColumn columnRowId;
            
            private DataColumn columnIdEmpresa;
            
            private DataColumn columnIdSucursal;
            
            private DataColumn columnIdCoeficienteCostoIndirecto;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnValor;
            
            private DataColumn columnTipo;
            
            private DataColumn columnIdMoneda;
            
            private DataColumn columnIdFuenteDeCambio;
            
            private DataColumn columnOrden;
            
            private DataColumn columnActivo;
            
            internal tsh_CoeficientesCostosIndirectosDataTable() : 
                    base("tsh_CoeficientesCostosIndirectos") {
                this.InitClass();
            }
            
            internal tsh_CoeficientesCostosIndirectosDataTable(DataTable table) : 
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
            
            internal DataColumn IdCoeficienteCostoIndirectoColumn {
                get {
                    return this.columnIdCoeficienteCostoIndirecto;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn ValorColumn {
                get {
                    return this.columnValor;
                }
            }
            
            internal DataColumn TipoColumn {
                get {
                    return this.columnTipo;
                }
            }
            
            internal DataColumn IdMonedaColumn {
                get {
                    return this.columnIdMoneda;
                }
            }
            
            internal DataColumn IdFuenteDeCambioColumn {
                get {
                    return this.columnIdFuenteDeCambio;
                }
            }
            
            internal DataColumn OrdenColumn {
                get {
                    return this.columnOrden;
                }
            }
            
            internal DataColumn ActivoColumn {
                get {
                    return this.columnActivo;
                }
            }
            
            public tsh_CoeficientesCostosIndirectosRow this[int index] {
                get {
                    return ((tsh_CoeficientesCostosIndirectosRow)(this.Rows[index]));
                }
            }
            
            public event tsh_CoeficientesCostosIndirectosRowChangeEventHandler tsh_CoeficientesCostosIndirectosRowChanged;
            
            public event tsh_CoeficientesCostosIndirectosRowChangeEventHandler tsh_CoeficientesCostosIndirectosRowChanging;
            
            public event tsh_CoeficientesCostosIndirectosRowChangeEventHandler tsh_CoeficientesCostosIndirectosRowDeleted;
            
            public event tsh_CoeficientesCostosIndirectosRowChangeEventHandler tsh_CoeficientesCostosIndirectosRowDeleting;
            
            public void Addtsh_CoeficientesCostosIndirectosRow(tsh_CoeficientesCostosIndirectosRow row) {
                this.Rows.Add(row);
            }
            
            public tsh_CoeficientesCostosIndirectosRow Addtsh_CoeficientesCostosIndirectosRow(
                        System.DateTime FechaCreacion, 
                        long IdConexionCreacion, 
                        System.Byte[] UltimaModificacion, 
                        long IdConexionUltimaModificacion, 
                        long IdReservado, 
                        string RowId, 
                        long IdEmpresa, 
                        long IdSucursal, 
                        string IdCoeficienteCostoIndirecto, 
                        string Descripcion, 
                        System.Decimal Valor, 
                        bool Tipo, 
                        string IdMoneda, 
                        string IdFuenteDeCambio, 
                        long Orden, 
                        bool Activo) {
                tsh_CoeficientesCostosIndirectosRow rowtsh_CoeficientesCostosIndirectosRow = ((tsh_CoeficientesCostosIndirectosRow)(this.NewRow()));
                rowtsh_CoeficientesCostosIndirectosRow.ItemArray = new object[] {
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        IdReservado,
                        RowId,
                        IdEmpresa,
                        IdSucursal,
                        IdCoeficienteCostoIndirecto,
                        Descripcion,
                        Valor,
                        Tipo,
                        IdMoneda,
                        IdFuenteDeCambio,
                        Orden,
                        Activo};
                this.Rows.Add(rowtsh_CoeficientesCostosIndirectosRow);
                return rowtsh_CoeficientesCostosIndirectosRow;
            }
            
            public tsh_CoeficientesCostosIndirectosRow FindByIdCoeficienteCostoIndirecto(string IdCoeficienteCostoIndirecto) {
                return ((tsh_CoeficientesCostosIndirectosRow)(this.Rows.Find(new object[] {
                            IdCoeficienteCostoIndirecto})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                tsh_CoeficientesCostosIndirectosDataTable cln = ((tsh_CoeficientesCostosIndirectosDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new tsh_CoeficientesCostosIndirectosDataTable();
            }
            
            internal void InitVars() {
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnIdReservado = this.Columns["IdReservado"];
                this.columnRowId = this.Columns["RowId"];
                this.columnIdEmpresa = this.Columns["IdEmpresa"];
                this.columnIdSucursal = this.Columns["IdSucursal"];
                this.columnIdCoeficienteCostoIndirecto = this.Columns["IdCoeficienteCostoIndirecto"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnValor = this.Columns["Valor"];
                this.columnTipo = this.Columns["Tipo"];
                this.columnIdMoneda = this.Columns["IdMoneda"];
                this.columnIdFuenteDeCambio = this.Columns["IdFuenteDeCambio"];
                this.columnOrden = this.Columns["Orden"];
                this.columnActivo = this.Columns["Activo"];
            }
            
            private void InitClass() {
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
                this.columnRowId = new DataColumn("RowId", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnIdEmpresa = new DataColumn("IdEmpresa", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdEmpresa);
                this.columnIdSucursal = new DataColumn("IdSucursal", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdSucursal);
                this.columnIdCoeficienteCostoIndirecto = new DataColumn("IdCoeficienteCostoIndirecto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdCoeficienteCostoIndirecto);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnValor = new DataColumn("Valor", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnValor);
                this.columnTipo = new DataColumn("Tipo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnTipo);
                this.columnIdMoneda = new DataColumn("IdMoneda", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdMoneda);
                this.columnIdFuenteDeCambio = new DataColumn("IdFuenteDeCambio", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdFuenteDeCambio);
                this.columnOrden = new DataColumn("Orden", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnOrden);
                this.columnActivo = new DataColumn("Activo", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnActivo);
                this.Constraints.Add(new UniqueConstraint("tsh_CoeficientesCostosIndirectosKey1", new DataColumn[] {
                                this.columnIdCoeficienteCostoIndirecto}, true));
                this.columnUltimaModificacion.ReadOnly = true;
                this.columnIdCoeficienteCostoIndirecto.AllowDBNull = false;
                this.columnIdCoeficienteCostoIndirecto.Unique = true;
                this.columnDescripcion.AllowDBNull = false;
            }
            
            public tsh_CoeficientesCostosIndirectosRow Newtsh_CoeficientesCostosIndirectosRow() {
                return ((tsh_CoeficientesCostosIndirectosRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new tsh_CoeficientesCostosIndirectosRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(tsh_CoeficientesCostosIndirectosRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.tsh_CoeficientesCostosIndirectosRowChanged != null)) {
                    this.tsh_CoeficientesCostosIndirectosRowChanged(this, new tsh_CoeficientesCostosIndirectosRowChangeEvent(((tsh_CoeficientesCostosIndirectosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.tsh_CoeficientesCostosIndirectosRowChanging != null)) {
                    this.tsh_CoeficientesCostosIndirectosRowChanging(this, new tsh_CoeficientesCostosIndirectosRowChangeEvent(((tsh_CoeficientesCostosIndirectosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.tsh_CoeficientesCostosIndirectosRowDeleted != null)) {
                    this.tsh_CoeficientesCostosIndirectosRowDeleted(this, new tsh_CoeficientesCostosIndirectosRowChangeEvent(((tsh_CoeficientesCostosIndirectosRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.tsh_CoeficientesCostosIndirectosRowDeleting != null)) {
                    this.tsh_CoeficientesCostosIndirectosRowDeleting(this, new tsh_CoeficientesCostosIndirectosRowChangeEvent(((tsh_CoeficientesCostosIndirectosRow)(e.Row)), e.Action));
                }
            }
            
            public void Removetsh_CoeficientesCostosIndirectosRow(tsh_CoeficientesCostosIndirectosRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_CoeficientesCostosIndirectosRow : DataRow {
            
            private tsh_CoeficientesCostosIndirectosDataTable tabletsh_CoeficientesCostosIndirectos;
            
            internal tsh_CoeficientesCostosIndirectosRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tabletsh_CoeficientesCostosIndirectos = ((tsh_CoeficientesCostosIndirectosDataTable)(this.Table));
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tabletsh_CoeficientesCostosIndirectos.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_CoeficientesCostosIndirectos.IdConexionCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tabletsh_CoeficientesCostosIndirectos.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tabletsh_CoeficientesCostosIndirectos.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public long IdReservado {
                get {
                    try {
                        return ((long)(this[this.tabletsh_CoeficientesCostosIndirectos.IdReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdReservadoColumn] = value;
                }
            }
            
            public string RowId {
                get {
                    try {
                        return ((string)(this[this.tabletsh_CoeficientesCostosIndirectos.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.RowIdColumn] = value;
                }
            }
            
            public long IdEmpresa {
                get {
                    try {
                        return ((long)(this[this.tabletsh_CoeficientesCostosIndirectos.IdEmpresaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdEmpresaColumn] = value;
                }
            }
            
            public long IdSucursal {
                get {
                    try {
                        return ((long)(this[this.tabletsh_CoeficientesCostosIndirectos.IdSucursalColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdSucursalColumn] = value;
                }
            }
            
            public string IdCoeficienteCostoIndirecto {
                get {
                    return ((string)(this[this.tabletsh_CoeficientesCostosIndirectos.IdCoeficienteCostoIndirectoColumn]));
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdCoeficienteCostoIndirectoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    return ((string)(this[this.tabletsh_CoeficientesCostosIndirectos.DescripcionColumn]));
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.DescripcionColumn] = value;
                }
            }
            
            public System.Decimal Valor {
                get {
                    try {
                        return ((System.Decimal)(this[this.tabletsh_CoeficientesCostosIndirectos.ValorColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.ValorColumn] = value;
                }
            }
            
            public bool Tipo {
                get {
                    try {
                        return ((bool)(this[this.tabletsh_CoeficientesCostosIndirectos.TipoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.TipoColumn] = value;
                }
            }
            
            public string IdMoneda {
                get {
                    try {
                        return ((string)(this[this.tabletsh_CoeficientesCostosIndirectos.IdMonedaColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdMonedaColumn] = value;
                }
            }
            
            public string IdFuenteDeCambio {
                get {
                    try {
                        return ((string)(this[this.tabletsh_CoeficientesCostosIndirectos.IdFuenteDeCambioColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.IdFuenteDeCambioColumn] = value;
                }
            }
            
            public long Orden {
                get {
                    try {
                        return ((long)(this[this.tabletsh_CoeficientesCostosIndirectos.OrdenColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.OrdenColumn] = value;
                }
            }
            
            public bool Activo {
                get {
                    try {
                        return ((bool)(this[this.tabletsh_CoeficientesCostosIndirectos.ActivoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tabletsh_CoeficientesCostosIndirectos.ActivoColumn] = value;
                }
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionCreacionNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdConexionCreacionColumn);
            }
            
            public void SetIdConexionCreacionNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdConexionCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdReservadoNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdReservadoColumn);
            }
            
            public void SetIdReservadoNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdReservadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdEmpresaNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdEmpresaColumn);
            }
            
            public void SetIdEmpresaNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdEmpresaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdSucursalNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdSucursalColumn);
            }
            
            public void SetIdSucursalNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdSucursalColumn] = System.Convert.DBNull;
            }
            
            public bool IsValorNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.ValorColumn);
            }
            
            public void SetValorNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.ValorColumn] = System.Convert.DBNull;
            }
            
            public bool IsTipoNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.TipoColumn);
            }
            
            public void SetTipoNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.TipoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdMonedaNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdMonedaColumn);
            }
            
            public void SetIdMonedaNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdMonedaColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdFuenteDeCambioNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.IdFuenteDeCambioColumn);
            }
            
            public void SetIdFuenteDeCambioNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.IdFuenteDeCambioColumn] = System.Convert.DBNull;
            }
            
            public bool IsOrdenNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.OrdenColumn);
            }
            
            public void SetOrdenNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.OrdenColumn] = System.Convert.DBNull;
            }
            
            public bool IsActivoNull() {
                return this.IsNull(this.tabletsh_CoeficientesCostosIndirectos.ActivoColumn);
            }
            
            public void SetActivoNull() {
                this[this.tabletsh_CoeficientesCostosIndirectos.ActivoColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class tsh_CoeficientesCostosIndirectosRowChangeEvent : EventArgs {
            
            private tsh_CoeficientesCostosIndirectosRow eventRow;
            
            private DataRowAction eventAction;
            
            public tsh_CoeficientesCostosIndirectosRowChangeEvent(tsh_CoeficientesCostosIndirectosRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public tsh_CoeficientesCostosIndirectosRow Row {
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