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
    public class st_RepuestoOrdenReparacionDataset : DataSet {
        
        private st_RepuestoOrdenReparacionDataTable tablest_RepuestoOrdenReparacion;
        
        public st_RepuestoOrdenReparacionDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected st_RepuestoOrdenReparacionDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["st_RepuestoOrdenReparacion"] != null)) {
                    this.Tables.Add(new st_RepuestoOrdenReparacionDataTable(ds.Tables["st_RepuestoOrdenReparacion"]));
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
        public st_RepuestoOrdenReparacionDataTable st_RepuestoOrdenReparacion {
            get {
                return this.tablest_RepuestoOrdenReparacion;
            }
        }
        
        public override DataSet Clone() {
            st_RepuestoOrdenReparacionDataset cln = ((st_RepuestoOrdenReparacionDataset)(base.Clone()));
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
            if ((ds.Tables["st_RepuestoOrdenReparacion"] != null)) {
                this.Tables.Add(new st_RepuestoOrdenReparacionDataTable(ds.Tables["st_RepuestoOrdenReparacion"]));
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
            this.tablest_RepuestoOrdenReparacion = ((st_RepuestoOrdenReparacionDataTable)(this.Tables["st_RepuestoOrdenReparacion"]));
            if ((this.tablest_RepuestoOrdenReparacion != null)) {
                this.tablest_RepuestoOrdenReparacion.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "st_RepuestoOrdenReparacionDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/st_RepuestoOrdenreparacion.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablest_RepuestoOrdenReparacion = new st_RepuestoOrdenReparacionDataTable();
            this.Tables.Add(this.tablest_RepuestoOrdenReparacion);
        }
        
        private bool ShouldSerializest_RepuestoOrdenReparacion() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void st_RepuestoOrdenReparacionRowChangeEventHandler(object sender, st_RepuestoOrdenReparacionRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_RepuestoOrdenReparacionDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdRepuestoOrdenReparacion;
            
            private DataColumn columnIdInstanciaOrdenReparacion;
            
            private DataColumn columnIdProducto;
            
            private DataColumn columnDescripcion;
            
            private DataColumn columnCantidad;
            
            private DataColumn columnPrecio;
            
            private DataColumn columnPrecioSugerido;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnentregado;
            
            private DataColumn columnReservado;
            
            internal st_RepuestoOrdenReparacionDataTable() : 
                    base("st_RepuestoOrdenReparacion") {
                this.InitClass();
            }
            
            internal st_RepuestoOrdenReparacionDataTable(DataTable table) : 
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
            
            internal DataColumn IdRepuestoOrdenReparacionColumn {
                get {
                    return this.columnIdRepuestoOrdenReparacion;
                }
            }
            
            internal DataColumn IdInstanciaOrdenReparacionColumn {
                get {
                    return this.columnIdInstanciaOrdenReparacion;
                }
            }
            
            internal DataColumn IdProductoColumn {
                get {
                    return this.columnIdProducto;
                }
            }
            
            internal DataColumn DescripcionColumn {
                get {
                    return this.columnDescripcion;
                }
            }
            
            internal DataColumn CantidadColumn {
                get {
                    return this.columnCantidad;
                }
            }
            
            internal DataColumn PrecioColumn {
                get {
                    return this.columnPrecio;
                }
            }
            
            internal DataColumn PrecioSugeridoColumn {
                get {
                    return this.columnPrecioSugerido;
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
            
            internal DataColumn RowIdColumn {
                get {
                    return this.columnRowId;
                }
            }
            
            internal DataColumn entregadoColumn {
                get {
                    return this.columnentregado;
                }
            }
            
            internal DataColumn ReservadoColumn {
                get {
                    return this.columnReservado;
                }
            }
            
            public st_RepuestoOrdenReparacionRow this[int index] {
                get {
                    return ((st_RepuestoOrdenReparacionRow)(this.Rows[index]));
                }
            }
            
            public event st_RepuestoOrdenReparacionRowChangeEventHandler st_RepuestoOrdenReparacionRowChanged;
            
            public event st_RepuestoOrdenReparacionRowChangeEventHandler st_RepuestoOrdenReparacionRowChanging;
            
            public event st_RepuestoOrdenReparacionRowChangeEventHandler st_RepuestoOrdenReparacionRowDeleted;
            
            public event st_RepuestoOrdenReparacionRowChangeEventHandler st_RepuestoOrdenReparacionRowDeleting;
            
            public void Addst_RepuestoOrdenReparacionRow(st_RepuestoOrdenReparacionRow row) {
                this.Rows.Add(row);
            }
            
            public st_RepuestoOrdenReparacionRow Addst_RepuestoOrdenReparacionRow(long IdRepuestoOrdenReparacion, long IdInstanciaOrdenReparacion, string IdProducto, string Descripcion, System.Decimal Cantidad, System.Decimal Precio, System.Decimal PrecioSugerido, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, System.Decimal entregado, System.Decimal Reservado) {
                st_RepuestoOrdenReparacionRow rowst_RepuestoOrdenReparacionRow = ((st_RepuestoOrdenReparacionRow)(this.NewRow()));
                rowst_RepuestoOrdenReparacionRow.ItemArray = new object[] {
                        IdRepuestoOrdenReparacion,
                        IdInstanciaOrdenReparacion,
                        IdProducto,
                        Descripcion,
                        Cantidad,
                        Precio,
                        PrecioSugerido,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        entregado,
                        Reservado};
                this.Rows.Add(rowst_RepuestoOrdenReparacionRow);
                return rowst_RepuestoOrdenReparacionRow;
            }
            
            public st_RepuestoOrdenReparacionRow FindByIdRepuestoOrdenReparacion(long IdRepuestoOrdenReparacion) {
                return ((st_RepuestoOrdenReparacionRow)(this.Rows.Find(new object[] {
                            IdRepuestoOrdenReparacion})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                st_RepuestoOrdenReparacionDataTable cln = ((st_RepuestoOrdenReparacionDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new st_RepuestoOrdenReparacionDataTable();
            }
            
            internal void InitVars() {
                this.columnIdRepuestoOrdenReparacion = this.Columns["IdRepuestoOrdenReparacion"];
                this.columnIdInstanciaOrdenReparacion = this.Columns["IdInstanciaOrdenReparacion"];
                this.columnIdProducto = this.Columns["IdProducto"];
                this.columnDescripcion = this.Columns["Descripcion"];
                this.columnCantidad = this.Columns["Cantidad"];
                this.columnPrecio = this.Columns["Precio"];
                this.columnPrecioSugerido = this.Columns["PrecioSugerido"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnentregado = this.Columns["entregado"];
                this.columnReservado = this.Columns["Reservado"];
            }
            
            private void InitClass() {
                this.columnIdRepuestoOrdenReparacion = new DataColumn("IdRepuestoOrdenReparacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdRepuestoOrdenReparacion);
                this.columnIdInstanciaOrdenReparacion = new DataColumn("IdInstanciaOrdenReparacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdInstanciaOrdenReparacion);
                this.columnIdProducto = new DataColumn("IdProducto", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdProducto);
                this.columnDescripcion = new DataColumn("Descripcion", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnDescripcion);
                this.columnCantidad = new DataColumn("Cantidad", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnCantidad);
                this.columnPrecio = new DataColumn("Precio", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPrecio);
                this.columnPrecioSugerido = new DataColumn("PrecioSugerido", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnPrecioSugerido);
                this.columnFechaCreacion = new DataColumn("FechaCreacion", typeof(System.DateTime), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnFechaCreacion);
                this.columnIdConexionCreacion = new DataColumn("IdConexionCreacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionCreacion);
                this.columnUltimaModificacion = new DataColumn("UltimaModificacion", typeof(System.Byte[]), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnUltimaModificacion);
                this.columnIdConexionUltimaModificacion = new DataColumn("IdConexionUltimaModificacion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexionUltimaModificacion);
                this.columnRowId = new DataColumn("RowId", typeof(System.Guid), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnRowId);
                this.columnentregado = new DataColumn("entregado", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnentregado);
                this.columnReservado = new DataColumn("Reservado", typeof(System.Decimal), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnReservado);
                this.Constraints.Add(new UniqueConstraint("st_RepuestoOrdenReparacionDatasetKey1", new DataColumn[] {
                                this.columnIdRepuestoOrdenReparacion}, true));
                this.columnIdRepuestoOrdenReparacion.AllowDBNull = false;
                this.columnIdRepuestoOrdenReparacion.Unique = true;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public st_RepuestoOrdenReparacionRow Newst_RepuestoOrdenReparacionRow() {
                return ((st_RepuestoOrdenReparacionRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new st_RepuestoOrdenReparacionRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(st_RepuestoOrdenReparacionRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.st_RepuestoOrdenReparacionRowChanged != null)) {
                    this.st_RepuestoOrdenReparacionRowChanged(this, new st_RepuestoOrdenReparacionRowChangeEvent(((st_RepuestoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.st_RepuestoOrdenReparacionRowChanging != null)) {
                    this.st_RepuestoOrdenReparacionRowChanging(this, new st_RepuestoOrdenReparacionRowChangeEvent(((st_RepuestoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.st_RepuestoOrdenReparacionRowDeleted != null)) {
                    this.st_RepuestoOrdenReparacionRowDeleted(this, new st_RepuestoOrdenReparacionRowChangeEvent(((st_RepuestoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.st_RepuestoOrdenReparacionRowDeleting != null)) {
                    this.st_RepuestoOrdenReparacionRowDeleting(this, new st_RepuestoOrdenReparacionRowChangeEvent(((st_RepuestoOrdenReparacionRow)(e.Row)), e.Action));
                }
            }
            
            public void Removest_RepuestoOrdenReparacionRow(st_RepuestoOrdenReparacionRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_RepuestoOrdenReparacionRow : DataRow {
            
            private st_RepuestoOrdenReparacionDataTable tablest_RepuestoOrdenReparacion;
            
            internal st_RepuestoOrdenReparacionRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablest_RepuestoOrdenReparacion = ((st_RepuestoOrdenReparacionDataTable)(this.Table));
            }
            
            public long IdRepuestoOrdenReparacion {
                get {
                    return ((long)(this[this.tablest_RepuestoOrdenReparacion.IdRepuestoOrdenReparacionColumn]));
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.IdRepuestoOrdenReparacionColumn] = value;
                }
            }
            
            public long IdInstanciaOrdenReparacion {
                get {
                    try {
                        return ((long)(this[this.tablest_RepuestoOrdenReparacion.IdInstanciaOrdenReparacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.IdInstanciaOrdenReparacionColumn] = value;
                }
            }
            
            public string IdProducto {
                get {
                    try {
                        return ((string)(this[this.tablest_RepuestoOrdenReparacion.IdProductoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.IdProductoColumn] = value;
                }
            }
            
            public string Descripcion {
                get {
                    try {
                        return ((string)(this[this.tablest_RepuestoOrdenReparacion.DescripcionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.DescripcionColumn] = value;
                }
            }
            
            public System.Decimal Cantidad {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_RepuestoOrdenReparacion.CantidadColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.CantidadColumn] = value;
                }
            }
            
            public System.Decimal Precio {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_RepuestoOrdenReparacion.PrecioColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.PrecioColumn] = value;
                }
            }
            
            public System.Decimal PrecioSugerido {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_RepuestoOrdenReparacion.PrecioSugeridoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.PrecioSugeridoColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    try {
                        return ((System.DateTime)(this[this.tablest_RepuestoOrdenReparacion.FechaCreacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablest_RepuestoOrdenReparacion.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablest_RepuestoOrdenReparacion.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablest_RepuestoOrdenReparacion.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablest_RepuestoOrdenReparacion.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.RowIdColumn] = value;
                }
            }
            
            public System.Decimal entregado {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_RepuestoOrdenReparacion.entregadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.entregadoColumn] = value;
                }
            }
            
            public System.Decimal Reservado {
                get {
                    try {
                        return ((System.Decimal)(this[this.tablest_RepuestoOrdenReparacion.ReservadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablest_RepuestoOrdenReparacion.ReservadoColumn] = value;
                }
            }
            
            public bool IsIdInstanciaOrdenReparacionNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.IdInstanciaOrdenReparacionColumn);
            }
            
            public void SetIdInstanciaOrdenReparacionNull() {
                this[this.tablest_RepuestoOrdenReparacion.IdInstanciaOrdenReparacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdProductoNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.IdProductoColumn);
            }
            
            public void SetIdProductoNull() {
                this[this.tablest_RepuestoOrdenReparacion.IdProductoColumn] = System.Convert.DBNull;
            }
            
            public bool IsDescripcionNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.DescripcionColumn);
            }
            
            public void SetDescripcionNull() {
                this[this.tablest_RepuestoOrdenReparacion.DescripcionColumn] = System.Convert.DBNull;
            }
            
            public bool IsCantidadNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.CantidadColumn);
            }
            
            public void SetCantidadNull() {
                this[this.tablest_RepuestoOrdenReparacion.CantidadColumn] = System.Convert.DBNull;
            }
            
            public bool IsPrecioNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.PrecioColumn);
            }
            
            public void SetPrecioNull() {
                this[this.tablest_RepuestoOrdenReparacion.PrecioColumn] = System.Convert.DBNull;
            }
            
            public bool IsPrecioSugeridoNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.PrecioSugeridoColumn);
            }
            
            public void SetPrecioSugeridoNull() {
                this[this.tablest_RepuestoOrdenReparacion.PrecioSugeridoColumn] = System.Convert.DBNull;
            }
            
            public bool IsFechaCreacionNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.FechaCreacionColumn);
            }
            
            public void SetFechaCreacionNull() {
                this[this.tablest_RepuestoOrdenReparacion.FechaCreacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablest_RepuestoOrdenReparacion.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablest_RepuestoOrdenReparacion.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablest_RepuestoOrdenReparacion.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsentregadoNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.entregadoColumn);
            }
            
            public void SetentregadoNull() {
                this[this.tablest_RepuestoOrdenReparacion.entregadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsReservadoNull() {
                return this.IsNull(this.tablest_RepuestoOrdenReparacion.ReservadoColumn);
            }
            
            public void SetReservadoNull() {
                this[this.tablest_RepuestoOrdenReparacion.ReservadoColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class st_RepuestoOrdenReparacionRowChangeEvent : EventArgs {
            
            private st_RepuestoOrdenReparacionRow eventRow;
            
            private DataRowAction eventAction;
            
            public st_RepuestoOrdenReparacionRowChangeEvent(st_RepuestoOrdenReparacionRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public st_RepuestoOrdenReparacionRow Row {
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
