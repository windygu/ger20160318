namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsa_ComisionesCotasVariables : IDisposable, IGridDocument
	{
		public tsa_ComisionesCotasVariables()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdComision""><Caption>IdComision</Caption><DataMember>IdComision</DataMember><Key>IdComision</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""Renglon""><Caption>Renglon</Caption><DataMember>Renglon</DataMember><Key>Renglon</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""CotaInferior""><Caption>CotaInferior</Caption><DataMember>CotaInferior</DataMember><Key>CotaInferior</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""CotaSuperior""><Caption>CotaSuperior</Caption><DataMember>CotaSuperior</DataMember><Key>CotaSuperior</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""ValorAAplicar""><Caption>ValorAAplicar</Caption><DataMember>ValorAAplicar</DataMember><Key>ValorAAplicar</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""FormaDeAplicacion""><Caption>FormaDeAplicacion</Caption><DataMember>FormaDeAplicacion</DataMember><Key>FormaDeAplicacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>6</Position></Column6>";
			returnValue += @"<Column7 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>7</Position></Column7>";
			returnValue += @"<Column8 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>8</Position></Column8>";
			returnValue += @"<Column9 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>9</Position></Column9>";
			returnValue += @"<Column10 ID=""IdReservado""><Caption>IdReservado</Caption><DataMember>IdReservado</DataMember><Key>IdReservado</Key><Position>10</Position></Column10>";
			returnValue += @"<Column11 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>11</Position></Column11>";
			returnValue += @"<Column12 ID=""IdLocal""><Caption>IdLocal</Caption><DataMember>IdLocal</DataMember><Key>IdLocal</Key><Position>12</Position></Column12>";
			returnValue += @"<Column13 ID=""IdEmpresa""><Caption>IdEmpresa</Caption><DataMember>IdEmpresa</DataMember><Key>IdEmpresa</Key><Position>13</Position></Column13>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsa_ComisionesCotasVariables.GetList().tsa_ComisionesCotasVariables;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsa_ComisionesCotasVariables.Update( ( tsa_ComisionesCotasVariablesDataset.tsa_ComisionesCotasVariablesDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

