namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class sy_PerfilesHerramientas : IDisposable, IGridDocument
	{
		public sy_PerfilesHerramientas()
		{
		}
		
		public string GetLayout()
		{
			string returnValue = string.Empty;
			returnValue += @"<GridEXLayoutData><RootTable><Columns Collection=""true"">";
			returnValue += @"<Column0 ID=""IdPerfil""><Caption>IdPerfil</Caption><DataMember>IdPerfil</DataMember><Key>IdPerfil</Key><Position>0</Position></Column0>";
			returnValue += @"<Column1 ID=""IdHerramienta""><Caption>IdHerramienta</Caption><DataMember>IdHerramienta</DataMember><Key>IdHerramienta</Key><Position>1</Position></Column1>";
			returnValue += @"<Column2 ID=""FechaCreacion""><Caption>FechaCreacion</Caption><DataMember>FechaCreacion</DataMember><Key>FechaCreacion</Key><Position>2</Position></Column2>";
			returnValue += @"<Column3 ID=""IdConexionCreacion""><Caption>IdConexionCreacion</Caption><DataMember>IdConexionCreacion</DataMember><Key>IdConexionCreacion</Key><Position>3</Position></Column3>";
			returnValue += @"<Column4 ID=""UltimaModificacion""><Caption>UltimaModificacion</Caption><DataMember>UltimaModificacion</DataMember><Key>UltimaModificacion</Key><Position>4</Position></Column4>";
			returnValue += @"<Column5 ID=""IdConexionUltimaModificacion""><Caption>IdConexionUltimaModificacion</Caption><DataMember>IdConexionUltimaModificacion</DataMember><Key>IdConexionUltimaModificacion</Key><Position>5</Position></Column5>";
			returnValue += @"<Column6 ID=""RowId""><Caption>RowId</Caption><DataMember>RowId</DataMember><Key>RowId</Key><Position>6</Position></Column6>";
			returnValue += @"</Columns>";
			returnValue += @"<GroupCondition ID="""" />";
			returnValue += @"</RootTable>";
			returnValue += @"</GridEXLayoutData>";
			
			return returnValue;
		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.sy_PerfilesHerramientas.GetList().sy_PerfilesHerramientas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.sy_PerfilesHerramientas.Update( ( sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasDataTable )dataTable );
		}
		
		public void Dispose()
		{
		}
		
	}
}

