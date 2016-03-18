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
    public class sy_HerramientasDataset : DataSet {
        
        private sy_HerramientasDataTable tablesy_Herramientas;
        
        public sy_HerramientasDataset() {
            this.InitClass();
            System.ComponentModel.CollectionChangeEventHandler schemaChangedHandler = new System.ComponentModel.CollectionChangeEventHandler(this.SchemaChanged);
            this.Tables.CollectionChanged += schemaChangedHandler;
            this.Relations.CollectionChanged += schemaChangedHandler;
        }
        
        protected sy_HerramientasDataset(SerializationInfo info, StreamingContext context) {
            string strSchema = ((string)(info.GetValue("XmlSchema", typeof(string))));
            if ((strSchema != null)) {
                DataSet ds = new DataSet();
                ds.ReadXmlSchema(new XmlTextReader(new System.IO.StringReader(strSchema)));
                if ((ds.Tables["sy_Herramientas"] != null)) {
                    this.Tables.Add(new sy_HerramientasDataTable(ds.Tables["sy_Herramientas"]));
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
        public sy_HerramientasDataTable sy_Herramientas {
            get {
                return this.tablesy_Herramientas;
            }
        }
        
        public override DataSet Clone() {
            sy_HerramientasDataset cln = ((sy_HerramientasDataset)(base.Clone()));
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
            if ((ds.Tables["sy_Herramientas"] != null)) {
                this.Tables.Add(new sy_HerramientasDataTable(ds.Tables["sy_Herramientas"]));
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
            this.tablesy_Herramientas = ((sy_HerramientasDataTable)(this.Tables["sy_Herramientas"]));
            if ((this.tablesy_Herramientas != null)) {
                this.tablesy_Herramientas.InitVars();
            }
        }
        
        private void InitClass() {
            this.DataSetName = "sy_HerramientasDataset";
            this.Prefix = "";
            this.Namespace = "http://tempuri.org/sy_Herramientas.xsd";
            this.Locale = new System.Globalization.CultureInfo("en-US");
            this.CaseSensitive = false;
            this.EnforceConstraints = true;
            this.tablesy_Herramientas = new sy_HerramientasDataTable();
            this.Tables.Add(this.tablesy_Herramientas);
        }
        
        private bool ShouldSerializesy_Herramientas() {
            return false;
        }
        
        private void SchemaChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e) {
            if ((e.Action == System.ComponentModel.CollectionChangeAction.Remove)) {
                this.InitVars();
            }
        }
        
        public delegate void sy_HerramientasRowChangeEventHandler(object sender, sy_HerramientasRowChangeEvent e);
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_HerramientasDataTable : DataTable, System.Collections.IEnumerable {
            
            private DataColumn columnIdHerramienta;
            
            private DataColumn columnIdHerramientaPadre;
            
            private DataColumn columnId;
            
            private DataColumn columnorden;
            
            private DataColumn columnHabilitado;
            
            private DataColumn columnIdConexion;
            
            private DataColumn columnFechaCreacion;
            
            private DataColumn columnIdConexionCreacion;
            
            private DataColumn columnUltimaModificacion;
            
            private DataColumn columnIdConexionUltimaModificacion;
            
            private DataColumn columnRowId;
            
            private DataColumn columnShortcut;
            
            internal sy_HerramientasDataTable() : 
                    base("sy_Herramientas") {
                this.InitClass();
            }
            
            internal sy_HerramientasDataTable(DataTable table) : 
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
            
            internal DataColumn IdHerramientaColumn {
                get {
                    return this.columnIdHerramienta;
                }
            }
            
            internal DataColumn IdHerramientaPadreColumn {
                get {
                    return this.columnIdHerramientaPadre;
                }
            }
            
            internal DataColumn IdColumn {
                get {
                    return this.columnId;
                }
            }
            
            internal DataColumn ordenColumn {
                get {
                    return this.columnorden;
                }
            }
            
            internal DataColumn HabilitadoColumn {
                get {
                    return this.columnHabilitado;
                }
            }
            
            internal DataColumn IdConexionColumn {
                get {
                    return this.columnIdConexion;
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
            
            internal DataColumn ShortcutColumn {
                get {
                    return this.columnShortcut;
                }
            }
            
            public sy_HerramientasRow this[int index] {
                get {
                    return ((sy_HerramientasRow)(this.Rows[index]));
                }
            }
            
            public event sy_HerramientasRowChangeEventHandler sy_HerramientasRowChanged;
            
            public event sy_HerramientasRowChangeEventHandler sy_HerramientasRowChanging;
            
            public event sy_HerramientasRowChangeEventHandler sy_HerramientasRowDeleted;
            
            public event sy_HerramientasRowChangeEventHandler sy_HerramientasRowDeleting;
            
            public void Addsy_HerramientasRow(sy_HerramientasRow row) {
                this.Rows.Add(row);
            }
            
            public sy_HerramientasRow Addsy_HerramientasRow(long IdHerramienta, long IdHerramientaPadre, string Id, short orden, bool Habilitado, long IdConexion, System.DateTime FechaCreacion, long IdConexionCreacion, System.Byte[] UltimaModificacion, long IdConexionUltimaModificacion, System.Guid RowId, string Shortcut) {
                sy_HerramientasRow rowsy_HerramientasRow = ((sy_HerramientasRow)(this.NewRow()));
                rowsy_HerramientasRow.ItemArray = new object[] {
                        IdHerramienta,
                        IdHerramientaPadre,
                        Id,
                        orden,
                        Habilitado,
                        IdConexion,
                        FechaCreacion,
                        IdConexionCreacion,
                        UltimaModificacion,
                        IdConexionUltimaModificacion,
                        RowId,
                        Shortcut};
                this.Rows.Add(rowsy_HerramientasRow);
                return rowsy_HerramientasRow;
            }
            
            public sy_HerramientasRow FindByIdHerramienta(long IdHerramienta) {
                return ((sy_HerramientasRow)(this.Rows.Find(new object[] {
                            IdHerramienta})));
            }
            
            public System.Collections.IEnumerator GetEnumerator() {
                return this.Rows.GetEnumerator();
            }
            
            public override DataTable Clone() {
                sy_HerramientasDataTable cln = ((sy_HerramientasDataTable)(base.Clone()));
                cln.InitVars();
                return cln;
            }
            
            protected override DataTable CreateInstance() {
                return new sy_HerramientasDataTable();
            }
            
            internal void InitVars() {
                this.columnIdHerramienta = this.Columns["IdHerramienta"];
                this.columnIdHerramientaPadre = this.Columns["IdHerramientaPadre"];
                this.columnId = this.Columns["Id"];
                this.columnorden = this.Columns["orden"];
                this.columnHabilitado = this.Columns["Habilitado"];
                this.columnIdConexion = this.Columns["IdConexion"];
                this.columnFechaCreacion = this.Columns["FechaCreacion"];
                this.columnIdConexionCreacion = this.Columns["IdConexionCreacion"];
                this.columnUltimaModificacion = this.Columns["UltimaModificacion"];
                this.columnIdConexionUltimaModificacion = this.Columns["IdConexionUltimaModificacion"];
                this.columnRowId = this.Columns["RowId"];
                this.columnShortcut = this.Columns["Shortcut"];
            }
            
            private void InitClass() {
                this.columnIdHerramienta = new DataColumn("IdHerramienta", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdHerramienta);
                this.columnIdHerramientaPadre = new DataColumn("IdHerramientaPadre", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdHerramientaPadre);
                this.columnId = new DataColumn("Id", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnId);
                this.columnorden = new DataColumn("orden", typeof(short), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnorden);
                this.columnHabilitado = new DataColumn("Habilitado", typeof(bool), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnHabilitado);
                this.columnIdConexion = new DataColumn("IdConexion", typeof(long), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnIdConexion);
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
                this.columnShortcut = new DataColumn("Shortcut", typeof(string), null, System.Data.MappingType.Element);
                this.Columns.Add(this.columnShortcut);
                this.Constraints.Add(new UniqueConstraint("sy_HerramientasDatasetKey1", new DataColumn[] {
                                this.columnIdHerramienta}, true));
                this.columnIdHerramienta.AllowDBNull = false;
                this.columnIdHerramienta.Unique = true;
                this.columnFechaCreacion.AllowDBNull = false;
                this.columnIdConexionCreacion.AllowDBNull = false;
                this.columnUltimaModificacion.ReadOnly = true;
            }
            
            public sy_HerramientasRow Newsy_HerramientasRow() {
                return ((sy_HerramientasRow)(this.NewRow()));
            }
            
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder) {
                return new sy_HerramientasRow(builder);
            }
            
            protected override System.Type GetRowType() {
                return typeof(sy_HerramientasRow);
            }
            
            protected override void OnRowChanged(DataRowChangeEventArgs e) {
                base.OnRowChanged(e);
                if ((this.sy_HerramientasRowChanged != null)) {
                    this.sy_HerramientasRowChanged(this, new sy_HerramientasRowChangeEvent(((sy_HerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowChanging(DataRowChangeEventArgs e) {
                base.OnRowChanging(e);
                if ((this.sy_HerramientasRowChanging != null)) {
                    this.sy_HerramientasRowChanging(this, new sy_HerramientasRowChangeEvent(((sy_HerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleted(DataRowChangeEventArgs e) {
                base.OnRowDeleted(e);
                if ((this.sy_HerramientasRowDeleted != null)) {
                    this.sy_HerramientasRowDeleted(this, new sy_HerramientasRowChangeEvent(((sy_HerramientasRow)(e.Row)), e.Action));
                }
            }
            
            protected override void OnRowDeleting(DataRowChangeEventArgs e) {
                base.OnRowDeleting(e);
                if ((this.sy_HerramientasRowDeleting != null)) {
                    this.sy_HerramientasRowDeleting(this, new sy_HerramientasRowChangeEvent(((sy_HerramientasRow)(e.Row)), e.Action));
                }
            }
            
            public void Removesy_HerramientasRow(sy_HerramientasRow row) {
                this.Rows.Remove(row);
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_HerramientasRow : DataRow {
            
            private sy_HerramientasDataTable tablesy_Herramientas;
            
            internal sy_HerramientasRow(DataRowBuilder rb) : 
                    base(rb) {
                this.tablesy_Herramientas = ((sy_HerramientasDataTable)(this.Table));
            }
            
            public long IdHerramienta {
                get {
                    return ((long)(this[this.tablesy_Herramientas.IdHerramientaColumn]));
                }
                set {
                    this[this.tablesy_Herramientas.IdHerramientaColumn] = value;
                }
            }
            
            public long IdHerramientaPadre {
                get {
                    try {
                        return ((long)(this[this.tablesy_Herramientas.IdHerramientaPadreColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.IdHerramientaPadreColumn] = value;
                }
            }
            
            public string Id {
                get {
                    try {
                        return ((string)(this[this.tablesy_Herramientas.IdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.IdColumn] = value;
                }
            }
            
            public short orden {
                get {
                    try {
                        return ((short)(this[this.tablesy_Herramientas.ordenColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.ordenColumn] = value;
                }
            }
            
            public bool Habilitado {
                get {
                    try {
                        return ((bool)(this[this.tablesy_Herramientas.HabilitadoColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.HabilitadoColumn] = value;
                }
            }
            
            public long IdConexion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Herramientas.IdConexionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.IdConexionColumn] = value;
                }
            }
            
            public System.DateTime FechaCreacion {
                get {
                    return ((System.DateTime)(this[this.tablesy_Herramientas.FechaCreacionColumn]));
                }
                set {
                    this[this.tablesy_Herramientas.FechaCreacionColumn] = value;
                }
            }
            
            public long IdConexionCreacion {
                get {
                    return ((long)(this[this.tablesy_Herramientas.IdConexionCreacionColumn]));
                }
                set {
                    this[this.tablesy_Herramientas.IdConexionCreacionColumn] = value;
                }
            }
            
            public System.Byte[] UltimaModificacion {
                get {
                    try {
                        return ((System.Byte[])(this[this.tablesy_Herramientas.UltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.UltimaModificacionColumn] = value;
                }
            }
            
            public long IdConexionUltimaModificacion {
                get {
                    try {
                        return ((long)(this[this.tablesy_Herramientas.IdConexionUltimaModificacionColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.IdConexionUltimaModificacionColumn] = value;
                }
            }
            
            public System.Guid RowId {
                get {
                    try {
                        return ((System.Guid)(this[this.tablesy_Herramientas.RowIdColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.RowIdColumn] = value;
                }
            }
            
            public string Shortcut {
                get {
                    try {
                        return ((string)(this[this.tablesy_Herramientas.ShortcutColumn]));
                    }
                    catch (InvalidCastException e) {
                        throw new StrongTypingException("No se puede obtener el valor porque es DBNull.", e);
                    }
                }
                set {
                    this[this.tablesy_Herramientas.ShortcutColumn] = value;
                }
            }
            
            public bool IsIdHerramientaPadreNull() {
                return this.IsNull(this.tablesy_Herramientas.IdHerramientaPadreColumn);
            }
            
            public void SetIdHerramientaPadreNull() {
                this[this.tablesy_Herramientas.IdHerramientaPadreColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdNull() {
                return this.IsNull(this.tablesy_Herramientas.IdColumn);
            }
            
            public void SetIdNull() {
                this[this.tablesy_Herramientas.IdColumn] = System.Convert.DBNull;
            }
            
            public bool IsordenNull() {
                return this.IsNull(this.tablesy_Herramientas.ordenColumn);
            }
            
            public void SetordenNull() {
                this[this.tablesy_Herramientas.ordenColumn] = System.Convert.DBNull;
            }
            
            public bool IsHabilitadoNull() {
                return this.IsNull(this.tablesy_Herramientas.HabilitadoColumn);
            }
            
            public void SetHabilitadoNull() {
                this[this.tablesy_Herramientas.HabilitadoColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionNull() {
                return this.IsNull(this.tablesy_Herramientas.IdConexionColumn);
            }
            
            public void SetIdConexionNull() {
                this[this.tablesy_Herramientas.IdConexionColumn] = System.Convert.DBNull;
            }
            
            public bool IsUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Herramientas.UltimaModificacionColumn);
            }
            
            public void SetUltimaModificacionNull() {
                this[this.tablesy_Herramientas.UltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsIdConexionUltimaModificacionNull() {
                return this.IsNull(this.tablesy_Herramientas.IdConexionUltimaModificacionColumn);
            }
            
            public void SetIdConexionUltimaModificacionNull() {
                this[this.tablesy_Herramientas.IdConexionUltimaModificacionColumn] = System.Convert.DBNull;
            }
            
            public bool IsRowIdNull() {
                return this.IsNull(this.tablesy_Herramientas.RowIdColumn);
            }
            
            public void SetRowIdNull() {
                this[this.tablesy_Herramientas.RowIdColumn] = System.Convert.DBNull;
            }
            
            public bool IsShortcutNull() {
                return this.IsNull(this.tablesy_Herramientas.ShortcutColumn);
            }
            
            public void SetShortcutNull() {
                this[this.tablesy_Herramientas.ShortcutColumn] = System.Convert.DBNull;
            }
        }
        
        [System.Diagnostics.DebuggerStepThrough()]
        public class sy_HerramientasRowChangeEvent : EventArgs {
            
            private sy_HerramientasRow eventRow;
            
            private DataRowAction eventAction;
            
            public sy_HerramientasRowChangeEvent(sy_HerramientasRow row, DataRowAction action) {
                this.eventRow = row;
                this.eventAction = action;
            }
            
            public sy_HerramientasRow Row {
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