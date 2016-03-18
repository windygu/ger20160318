namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_Comisiones : IDisposable, IGridDocument
	{
		public tsa_Comisiones()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdComision""><Caption>IdComision</Caption><DataMember>IdComision</DataMember><Key>IdComision</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Descripcion""><Caption>Descripcion</Caption><DataMember>Descripcion</DataMember><Key>Descripcion</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""SQLDatosOrigen""><Caption>SQLDatosOrigen</Caption><DataMember>SQLDatosOrigen</DataMember><Key>SQLDatosOrigen</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""VariableAplicacion""><Caption>VariableAplicacion</Caption><DataMember>VariableAplicacion</DataMember><Key>VariableAplicacion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""VariableRestriccion""><Caption>VariableRestriccion</Caption><DataMember>VariableRestriccion</DataMember><Key>VariableRestriccion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""ValorRestriccion""><Caption>ValorRestriccion</Caption><DataMember>ValorRestriccion</DataMember><Key>ValorRestriccion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""VigenciaDesde""><Caption>VigenciaDesde</Caption><DataMember>VigenciaDesde</DataMember><Key>VigenciaDesde</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""VigenciaHasta""><Caption>VigenciaHasta</Caption><DataMember>VigenciaHasta</DataMember><Key>VigenciaHasta</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""Activa""><Caption>Activa</Caption><DataMember>Activa</DataMember><Key>Activa</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""Sistema""><Caption>Sistema</Caption><DataMember>Sistema</DataMember><Key>Sistema</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>13</Position></Column13>";
			returnValue += @"<Column14 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>14</Position></Column14>";
			returnValue += @"<Column15 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>15</Position></Column15>";
			returnValue += @"<Column16 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>16</Position></Column16>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_Comisiones.GetList().tsa_Comisiones;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_Comisiones.Update( ( tsa_ComisionesDataset.tsa_ComisionesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

