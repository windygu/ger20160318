namespace mz.erp.ui.controllers
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	
	using mz.erp.businessrules;
	public class tfi_FormasDePagoEx : IDisposable, IGridDocument
	{
		public tfi_FormasDePagoEx()
		{
		}

		public tfi_FormasDePagoEx( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
		public string GetLayout()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			
			if ( fl.Contains( "IdFormaDePago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFormaDePago", "Id Forma De Pago", true ) );
			if ( fl.Contains( "Descripcion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Descripcion", "Forma de Pago",310 ) );
			if ( fl.Contains( "DescripcionEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionEntidad", "Entidad",true ) );
			if ( fl.Contains( "Cuotas" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuotas", "Cuotas",true ) );
			if ( fl.Contains( "Recargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "Recargo",true ) );
			if ( fl.Contains( "Agrupado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Agrupado", "Agrupado", true ) );
			if ( fl.Contains( "IdTDComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTDComprobante", "IdTDComprobante", true ) );
			if ( fl.Contains( "IdEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEntidad", "IdEntidad", true ) );
			if ( fl.Contains( "IdMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdMoneda", "IdMoneda", true ) );
			if ( fl.Contains( "IdCotizacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdCotizacion", "IdCotizacion", true ) );
			if ( fl.Contains( "ImporteConRecargo" ) ) sb.Append( LayoutBuilder.GetRow( i++, "ImporteConRecargo", "Importe", 60,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			if ( fl.Contains( "ValorDeLaCuota" ) ) sb.Append( LayoutBuilder.GetRow( i++, "ValorDeLaCuota", "Cuota", 60,Types.Aligment.Far, Types.FormatDisplay.Money ,Types.EditType.NoEdit) );
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}

				
		public string GetLayoutDetail()
		{
			ArrayList fl = new ArrayList();
			if ( _fieldList != null )
			{
				fl.AddRange( _fieldList );
			}

			int i = 0;
			StringBuilder sb = new StringBuilder();
			sb.Append( LayoutBuilder.GetHeader() );
			if ( fl.Contains( "IdFormaDePago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFormaDePago", "Id Forma De Pago" ) );
			if ( fl.Contains( "DescripcionComprobante" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionComprobante", "Comprobante" ) );
			if ( fl.Contains( "DescripcionMoneda" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionMoneda", "Moneda" ) );
			if ( fl.Contains( "DescripcionEntidad" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "DescripcionEntidad", "Entidad" ) );
			if ( fl.Contains( "Cuotas" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Cuotas", "Cuotas" ) );
			if ( fl.Contains( "Recargo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Recargo", "Recargo" ) );
			//if ( fl.Contains( "Agrupado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Agrupado", "Agrupado" ) );
			//if ( fl.Contains( "HasDetail" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "HasDetail", "HasDetail" ) );
			//if ( fl.Contains( "Detalle" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Detalle", "Detalle" ) );
			/*if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado" ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId" ) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "IdEmpresa" ) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "IdSucursal" ) );
			if ( fl.Contains( "IdFormaDePago" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdFormaDePago", "IdFormaDePago" ) );*/
			
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		
		public DataTable GetList()
		{
			return mz.erp.businessrules.tfi_FormasDePago.GetList().tfi_FormasDePago;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tfi_FormasDePago.Update( ( tfi_FormasDePagoDataset.tfi_FormasDePagoDataTable )dataTable );
		}
		
		private string[] _fieldList;
		public string[] FieldList
		{
			get
			{
				return _fieldList;
			}
			set
			{
				_fieldList = value;
			}
		}

		[ SearchMember( "tfi_FormasDePago" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "IdTDCompTesoreria" ) ] string IdTDCompTesoreria, 
			[ SearchParameterInfo( "IdMoneda" ) ] string IdMoneda, 
			[ SearchParameterInfo( "IdEntidad" ) ] string IdEntidad, 
			[ SearchParameterInfo( "Cuotas" ) ] short Cuotas
			)
		{
			tfi_FormasDePagoDataset data = mz.erp.businessrules.tfi_FormasDePago.GetList( IdTDCompTesoreria, IdMoneda, IdEntidad, Cuotas );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}



		
	}
}


