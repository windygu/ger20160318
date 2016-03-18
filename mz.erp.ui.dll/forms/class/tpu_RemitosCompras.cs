namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tpu_RemitosCompras : IDisposable, IGridDocument
	{
		public tpu_RemitosCompras()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdRemitoCompra""><Caption>IdRemitoCompra</Caption><DataMember>IdRemitoCompra</DataMember><Key>IdRemitoCompra</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdProveedor""><Caption>IdProveedor</Caption><DataMember>IdProveedor</DataMember><Key>IdProveedor</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""Codigo""><Caption>Codigo</Caption><DataMember>Codigo</DataMember><Key>Codigo</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""Fecha""><Caption>Fecha</Caption><DataMember>Fecha</DataMember><Key>Fecha</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>11</Position></Column11>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tpu_RemitosCompras.GetList().tpu_RemitosCompras;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tpu_RemitosCompras.Update( ( tpu_RemitosComprasDataset.tpu_RemitosComprasDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

