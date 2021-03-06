namespace mz.erp.ui.forms.classes
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;
	using mz.erp.ui.controllers;

	/// <summary>
	/// Descripci�n breve de UsuariosPersonas.
	/// </summary>
	public class UsuariosPersonas //: IDisposable, IGridDocument
	{
		public UsuariosPersonas()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}

		public UsuariosPersonas( string[] fieldList )
		{
			_fieldList = fieldList;
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

		[ atMethodLayoutData ]
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

			if ( fl.Contains( "IdPersona" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPersona", "IdPersona",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",250) );
			if ( fl.Contains( "Comentarios" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentarios", "Comentarios",true ) );
			if ( fl.Contains( "Telefonos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefonos", "Telefonos",150) );
			if ( fl.Contains( "Email" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Email", "Email",200 ) );
			if ( fl.Contains( "InstantMesseger" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InstantMesseger", "InstantMesseger",200) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", true ));
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha de Creacion", true) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ,true) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "Ultima Modificacion",true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			if ( fl.Contains( "IdTratamiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTratamiento", "Tratamiento",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "Empresa", true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal",true) );
			sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();
		}


		[ SearchMember( "tsh_Personas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "Codigo",IsAlternativePrimaryKey= true ) ] string IdPersona,
			[ SearchParameterInfo( "Nombre", IsDescription= true ) ] string Nombre
			)
		{							
			sy_UsuariosDataset usuarios = mz.erp.businessrules.sy_Usuarios.GetList(IdPersona, Nombre);
			DataSet ds = new DataSet();
			ds = businessrules.data.UsuariosPersonas.GetPersonas(usuarios);
			if (ds.Tables[0].Rows.Count == 0) 
			{
				//string Telefonos = null;
				ds = mz.erp.businessrules.tsh_Personas.GetByPk(IdPersona).Table.DataSet;
			}
			return ds;
		}

		/*	
				string IdPersona = mz.erp.businessrules.sy_Usuarios.GetByPk(IdUsuario).IdPersona.ToString();			
				DataSet data = mz.erp.businessrules.tsh_Personas.GetByPk(IdPersona).Table.DataSet;			
				return (DataSet) data;
		}*/

		public void Dispose()
		{
		}

		
	}

	
	

}

	/*
namespace mz.erp.ui
{
	using System;
	using System.Data;
	using System.Text;
	using System.Collections;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.ui.controls;

	public class tsh_Personas : IDisposable, IGridDocument
	{
		public tsh_Personas()
		{
		}

		public tsh_Personas( string[] fieldList )
		{
			_fieldList = fieldList;
		}
		
		[ atMethodLayoutData ]
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
			

			if ( fl.Contains( "IdPersona" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdPersona", "IdPersona",true ) );
			if ( fl.Contains( "Nombre" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Nombre", "Nombre",250) );
			if ( fl.Contains( "Comentarios" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Comentarios", "Comentarios",true ) );
			if ( fl.Contains( "Telefonos" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Telefonos", "Telefonos",150) );
			if ( fl.Contains( "Email" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Email", "Email",200 ) );
			if ( fl.Contains( "InstantMesseger" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "InstantMesseger", "InstantMesseger",200) );
			if ( fl.Contains( "Observaciones" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Observaciones", "Observaciones", true ));
			if ( fl.Contains( "Activo" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "Activo", "Activo",true) );
			if ( fl.Contains( "FechaCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "FechaCreacion", "Fecha de Creacion", true) );
			if ( fl.Contains( "IdConexionCreacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionCreacion", "IdConexionCreacion" ,true) );
			if ( fl.Contains( "UltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "UltimaModificacion", "Ultima Modificacion",true) );
			if ( fl.Contains( "IdConexionUltimaModificacion" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdConexionUltimaModificacion", "IdConexionUltimaModificacion",true) );
			if ( fl.Contains( "IdReservado" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdReservado", "IdReservado",true ) );
			if ( fl.Contains( "RowId" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "RowId", "RowId", true ) );
			if ( fl.Contains( "IdTratamiento" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdTratamiento", "Tratamiento",true) );
			if ( fl.Contains( "IdEmpresa" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdEmpresa", "Empresa", true) );
			if ( fl.Contains( "IdSucursal" ) || _fieldList == null ) sb.Append( LayoutBuilder.GetRow( i++, "IdSucursal", "Sucursal",true) );
		sb.Append( LayoutBuilder.GetFooter() );

			return sb.ToString();

		}
		[ValueListGridMember]
		public DataTable GetList()
		{
			return mz.erp.businessrules.tsh_Personas.GetList().tsh_Personas;
		}
		
		public void Update( object dataTable )
		{
			mz.erp.businessrules.tsh_Personas.Update( ( tsh_PersonasDataset.tsh_PersonasDataTable )dataTable );
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

		[ SearchMember( "tsh_Personas" ) ]
		public static DataSet GetList( [ SearchParameterInfo( "Codigo",IsAlternativePrimaryKey= true ) ] string IdPersona, 
			[ SearchParameterInfo( "Nombre", IsDescription= true ) ] string Nombre, 
			[ SearchParameterInfo( "Telefonos" ) ] string Telefonos
			)
		{
			tsh_PersonasDataset data = mz.erp.businessrules.tsh_Personas.GetList( IdPersona, Nombre, Telefonos );
			return ( DataSet )data;
		}
		
		public void Dispose()
		{
		}
		
	}
}


	 */