using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using mz.erp.commontypes;
using mz.erp.ui.forms.classes;
using mz.erp.ui.utility;

namespace mz.erp.ui.forms
{
	/// <summary>
	/// Descripci�n breve de FrmABMTiposObservacionesCuentas.
	/// </summary>
	public class FrmAbmTiposObservacionesCuentas : System.Windows.Forms.Form, ITaskForm
	{
		private System.Windows.Forms.ImageList imglStandar;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar ultraExplorerBar1;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl5;
		private System.Windows.Forms.Label labelTarea;
		private Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
		private System.Windows.Forms.ToolBar toolBarStandar;
		private System.Windows.Forms.ToolBarButton tbbAnterior;
		private System.Windows.Forms.ToolBarButton tbbSeparator;
		private System.Windows.Forms.ToolBarButton tbbSiguiente;
		private System.Windows.Forms.ToolBarButton tbbSeparator2;
		protected System.Windows.Forms.ToolBarButton tbbCancelar;
		private Infragistics.Win.UltraWinTree.UltraTree ultraTreeTiposObservaciones;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Janus.Windows.GridEX.GridEX gridEX1;
		private Infragistics.Win.UltraWinEditors.UltraCheckEditor chkActivo;
		private Infragistics.Win.Misc.UltraButton btnAgregarTipo;
		private System.Windows.Forms.TextBox txtDescripcionModifTipo;
		private Infragistics.Win.Misc.UltraButton btnModificarTipo;
		private System.Windows.Forms.Label label2;
		private Infragistics.Win.Misc.UltraButton btnEliminar;
		private System.Windows.Forms.TextBox txtIdTipo;
		private System.Windows.Forms.Label labelIdTipo;
		private System.ComponentModel.IContainer components;


        
		#region C�digo generado por el Dise�ador de Windows Forms
		/// <summary>
		/// M�todo necesario para admitir el Dise�ador. No se puede modificar
		/// el contenido del m�todo con el editor de c�digo.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
			Infragistics.Win.UltraWinTree.Override _override1 = new Infragistics.Win.UltraWinTree.Override();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup ultraExplorerBarGroup2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FrmAbmTiposObservacionesCuentas));
			this.ultraExplorerBarContainerControl5 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.labelTarea = new System.Windows.Forms.Label();
			this.ultraExplorerBarContainerControl2 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarContainerControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtIdTipo = new System.Windows.Forms.TextBox();
			this.labelIdTipo = new System.Windows.Forms.Label();
			this.gridEX1 = new Janus.Windows.GridEX.GridEX();
			this.chkActivo = new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
			this.btnAgregarTipo = new Infragistics.Win.Misc.UltraButton();
			this.txtDescripcionModifTipo = new System.Windows.Forms.TextBox();
			this.btnModificarTipo = new Infragistics.Win.Misc.UltraButton();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEliminar = new Infragistics.Win.Misc.UltraButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ultraTreeTiposObservaciones = new Infragistics.Win.UltraWinTree.UltraTree();
			this.ultraExplorerBar1 = new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar();
			this.imglStandar = new System.Windows.Forms.ImageList(this.components);
			this.toolBarStandar = new System.Windows.Forms.ToolBar();
			this.tbbAnterior = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator = new System.Windows.Forms.ToolBarButton();
			this.tbbSiguiente = new System.Windows.Forms.ToolBarButton();
			this.tbbSeparator2 = new System.Windows.Forms.ToolBarButton();
			this.tbbCancelar = new System.Windows.Forms.ToolBarButton();
			this.ultraExplorerBarContainerControl5.SuspendLayout();
			this.ultraExplorerBarContainerControl2.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ultraTreeTiposObservaciones)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).BeginInit();
			this.ultraExplorerBar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ultraExplorerBarContainerControl5
			// 
			this.ultraExplorerBarContainerControl5.Controls.Add(this.labelTarea);
			this.ultraExplorerBarContainerControl5.Location = new System.Drawing.Point(28, 24);
			this.ultraExplorerBarContainerControl5.Name = "ultraExplorerBarContainerControl5";
			this.ultraExplorerBarContainerControl5.Size = new System.Drawing.Size(755, 25);
			this.ultraExplorerBarContainerControl5.TabIndex = 4;
			// 
			// labelTarea
			// 
			this.labelTarea.BackColor = System.Drawing.Color.Transparent;
			this.labelTarea.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labelTarea.Location = new System.Drawing.Point(0, 0);
			this.labelTarea.Name = "labelTarea";
			this.labelTarea.Size = new System.Drawing.Size(755, 23);
			this.labelTarea.TabIndex = 1;
			this.labelTarea.Text = "Tarea";
			this.labelTarea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ultraExplorerBarContainerControl2
			// 
			this.ultraExplorerBarContainerControl2.Controls.Add(this.panel2);
			this.ultraExplorerBarContainerControl2.Controls.Add(this.panel1);
			this.ultraExplorerBarContainerControl2.Location = new System.Drawing.Point(28, 108);
			this.ultraExplorerBarContainerControl2.Name = "ultraExplorerBarContainerControl2";
			this.ultraExplorerBarContainerControl2.Size = new System.Drawing.Size(755, 390);
			this.ultraExplorerBarContainerControl2.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.txtIdTipo);
			this.panel2.Controls.Add(this.labelIdTipo);
			this.panel2.Controls.Add(this.gridEX1);
			this.panel2.Controls.Add(this.chkActivo);
			this.panel2.Controls.Add(this.btnAgregarTipo);
			this.panel2.Controls.Add(this.txtDescripcionModifTipo);
			this.panel2.Controls.Add(this.btnModificarTipo);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(243, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(512, 390);
			this.panel2.TabIndex = 103;
			// 
			// txtIdTipo
			// 
			this.txtIdTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtIdTipo.Location = new System.Drawing.Point(288, 96);
			this.txtIdTipo.Name = "txtIdTipo";
			this.txtIdTipo.ReadOnly = true;
			this.txtIdTipo.Size = new System.Drawing.Size(192, 20);
			this.txtIdTipo.TabIndex = 6;
			this.txtIdTipo.Text = "";
			// 
			// labelIdTipo
			// 
			this.labelIdTipo.BackColor = System.Drawing.Color.Transparent;
			this.labelIdTipo.Location = new System.Drawing.Point(240, 96);
			this.labelIdTipo.Name = "labelIdTipo";
			this.labelIdTipo.Size = new System.Drawing.Size(40, 16);
			this.labelIdTipo.TabIndex = 109;
			this.labelIdTipo.Text = "IdTipo";
			// 
			// gridEX1
			// 
			this.gridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridEX1.AlternatingColors = true;
			this.gridEX1.AutomaticSort = false;
			this.gridEX1.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.Cursor = System.Windows.Forms.Cursors.Default;
			this.gridEX1.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular;
			this.gridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridEX1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.gridEX1.GroupByBoxInfoText = "Arraste un encabezado de columna hasta aqu� para agrupar por esa columna.";
			this.gridEX1.GroupByBoxVisible = false;
			this.gridEX1.HeaderFormatStyle.FontBold = Janus.Windows.GridEX.TriState.True;
			this.gridEX1.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.gridEX1.IncrementalSearchMode = Janus.Windows.GridEX.IncrementalSearchMode.FirstCharacter;
			this.gridEX1.InvalidValueAction = Janus.Windows.GridEX.InvalidValueAction.DiscardChangesAndShowErrorMessage;
			this.gridEX1.Location = new System.Drawing.Point(20, 128);
			this.gridEX1.Name = "gridEX1";
			this.gridEX1.RecordNavigatorText = "Registro:|de";
			this.gridEX1.ShowEmptyFields = false;
			this.gridEX1.Size = new System.Drawing.Size(464, 160);
			this.gridEX1.TabIndex = 7;
			this.gridEX1.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			// 
			// chkActivo
			// 
			this.chkActivo.BackColor = System.Drawing.Color.Transparent;
			this.chkActivo.Enabled = false;
			this.chkActivo.Location = new System.Drawing.Point(200, 56);
			this.chkActivo.Name = "chkActivo";
			this.chkActivo.Size = new System.Drawing.Size(64, 20);
			this.chkActivo.TabIndex = 4;
			this.chkActivo.Text = "Activo";
			// 
			// btnAgregarTipo
			// 
			this.btnAgregarTipo.Enabled = false;
			this.btnAgregarTipo.Location = new System.Drawing.Point(104, 56);
			this.btnAgregarTipo.Name = "btnAgregarTipo";
			this.btnAgregarTipo.Size = new System.Drawing.Size(80, 24);
			this.btnAgregarTipo.TabIndex = 3;
			this.btnAgregarTipo.Text = "&Agregar";
			this.btnAgregarTipo.Click += new System.EventHandler(this.btnAgregarTipo_Click);
			// 
			// txtDescripcionModifTipo
			// 
			this.txtDescripcionModifTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtDescripcionModifTipo.Location = new System.Drawing.Point(96, 16);
			this.txtDescripcionModifTipo.Name = "txtDescripcionModifTipo";
			this.txtDescripcionModifTipo.Size = new System.Drawing.Size(192, 20);
			this.txtDescripcionModifTipo.TabIndex = 1;
			this.txtDescripcionModifTipo.Text = "";
			// 
			// btnModificarTipo
			// 
			this.btnModificarTipo.Enabled = false;
			this.btnModificarTipo.Location = new System.Drawing.Point(20, 56);
			this.btnModificarTipo.Name = "btnModificarTipo";
			this.btnModificarTipo.Size = new System.Drawing.Size(80, 24);
			this.btnModificarTipo.TabIndex = 2;
			this.btnModificarTipo.Text = "&Modificar";
			this.btnModificarTipo.Click += new System.EventHandler(this.btnModificarTipo_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(24, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 104;
			this.label2.Text = "Descripci�n";
			// 
			// btnEliminar
			// 
			this.btnEliminar.Enabled = false;
			this.btnEliminar.Location = new System.Drawing.Point(20, 96);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(80, 24);
			this.btnEliminar.TabIndex = 5;
			this.btnEliminar.Text = "&Eliminar";
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.ultraTreeTiposObservaciones);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(316, 390);
			this.panel1.TabIndex = 102;
			// 
			// ultraTreeTiposObservaciones
			// 
			this.ultraTreeTiposObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ultraTreeTiposObservaciones.HideSelection = false;
			this.ultraTreeTiposObservaciones.Location = new System.Drawing.Point(0, 0);
			this.ultraTreeTiposObservaciones.Name = "ultraTreeTiposObservaciones";
			ultraTreeNode1.Key = "RAIZ";
			ultraTreeNode1.Text = "Tipos de Observaciones";
			this.ultraTreeTiposObservaciones.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
																												  ultraTreeNode1});
			_override1.SelectionType = Infragistics.Win.UltraWinTree.SelectType.Single;
			this.ultraTreeTiposObservaciones.Override = _override1;
			this.ultraTreeTiposObservaciones.Size = new System.Drawing.Size(316, 390);
			this.ultraTreeTiposObservaciones.TabIndex = 0;
			// 
			// ultraExplorerBar1
			// 
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl5);
			this.ultraExplorerBar1.Controls.Add(this.ultraExplorerBarContainerControl2);
			this.ultraExplorerBar1.Dock = System.Windows.Forms.DockStyle.Fill;
			ultraExplorerBarGroup1.Container = this.ultraExplorerBarContainerControl5;
			ultraExplorerBarGroup1.Settings.ContainerHeight = 25;
			ultraExplorerBarGroup1.Settings.HeaderVisible = Infragistics.Win.DefaultableBoolean.False;
			ultraExplorerBarGroup1.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup1.Text = "Tarea";
			ultraExplorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
			ultraExplorerBarGroup2.Settings.ContainerHeight = 390;
			ultraExplorerBarGroup2.Settings.Style = Infragistics.Win.UltraWinExplorerBar.GroupStyle.ControlContainer;
			ultraExplorerBarGroup2.Text = "Edici�n y Adici�n de tipos de observaciones";
			this.ultraExplorerBar1.Groups.AddRange(new Infragistics.Win.UltraWinExplorerBar.UltraExplorerBarGroup[] {
																														ultraExplorerBarGroup1,
																														ultraExplorerBarGroup2});
			this.ultraExplorerBar1.Location = new System.Drawing.Point(0, 28);
			this.ultraExplorerBar1.Name = "ultraExplorerBar1"; this.ultraExplorerBar1.AnimationEnabled = false; //German 20101207 - Tarea Infragistics 2008 � Tarea 983
			this.ultraExplorerBar1.Size = new System.Drawing.Size(804, 546);
			this.ultraExplorerBar1.TabIndex = 49;
			// 
			// imglStandar
			// 
			this.imglStandar.ImageSize = new System.Drawing.Size(16, 16);
			this.imglStandar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglStandar.ImageStream")));
			this.imglStandar.TransparentColor = System.Drawing.Color.Magenta;
			// 
			// toolBarStandar
			// 
			this.toolBarStandar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBarStandar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																							  this.tbbAnterior,
																							  this.tbbSeparator,
																							  this.tbbSiguiente,
																							  this.tbbSeparator2,
																							  this.tbbCancelar});
			this.toolBarStandar.DropDownArrows = true;
			this.toolBarStandar.ImageList = this.imglStandar;
			this.toolBarStandar.Location = new System.Drawing.Point(0, 0);
			this.toolBarStandar.Name = "toolBarStandar";
			this.toolBarStandar.ShowToolTips = true;
			this.toolBarStandar.Size = new System.Drawing.Size(804, 28);
			this.toolBarStandar.TabIndex = 48;
			this.toolBarStandar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
			// 
			// tbbAnterior
			// 
			this.tbbAnterior.ImageIndex = 1;
			this.tbbAnterior.Text = "&Anterior";
			// 
			// tbbSeparator
			// 
			this.tbbSeparator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbSiguiente
			// 
			this.tbbSiguiente.ImageIndex = 2;
			this.tbbSiguiente.Text = "&Siguiente";
			// 
			// tbbSeparator2
			// 
			this.tbbSeparator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// tbbCancelar
			// 
			this.tbbCancelar.ImageIndex = 0;
			this.tbbCancelar.Text = "&Cancelar";
			// 
			// FrmAbmTiposObservacionesCuentas
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(804, 574);
			this.Controls.Add(this.ultraExplorerBar1);
			this.Controls.Add(this.toolBarStandar);
			this.Name = "FrmAbmTiposObservacionesCuentas";
			this.Text = "FrmABMTiposObservacionesCuentas";
			this.ultraExplorerBarContainerControl5.ResumeLayout(false);
			this.ultraExplorerBarContainerControl2.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ultraTreeTiposObservaciones)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ultraExplorerBar1)).EndInit();
			this.ultraExplorerBar1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Variables Privadas
		private controllers.TiposObservacionesCuentasController _uiController = null;
		private bool _expandir = true;
		//Lo que estaba antes para que no muestre el activo en el texto del arbol de la interfaz
		// private Infragistics.Win.UltraWinTree.UltraTreeNode _tree = new Infragistics.Win.UltraWinTree.UltraTreeNode();
		#endregion

		#region Constructores y Destructores

		public FrmAbmTiposObservacionesCuentas(controllers.TiposObservacionesCuentasController controller)
		{
			InitializeComponent();
			_uiController = controller;
			Init();			

		}


		/// <summary>
		/// Limpiar los recursos que se est�n utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
				this.toolBarStandar.ButtonClick -= new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
				_uiController.TiposObservacionesNuevasHasChanged-=new EventHandler(_uiController_TiposObservacionesNuevasHasChanged);

			}
			base.Dispose( disposing );
		}
		#endregion

		#region Inicializadores y Carga
		

		protected void Build_UI()
		{
			ConfigureInterface();	
			InitializeData();
			InitEventHandlers();
			InitDataBindings();			
		}

		
		private void ConfigureInterface()
		{
			tbbAnterior.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();
			tbbSeparator.Enabled = !_uiController.IsFirstTask() && !_uiController.IsFlushedState();

			this.Text = _uiController.LeyendaFormulario;
			labelTarea.Text = _uiController.LeyendaFormulario;	

			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;

			this.gridEX1.LayoutData = _uiController.GetLayout();

            ultraTreeTiposObservaciones.CollapseAll();

			labelIdTipo.Visible = mz.erp.businessrules.Security.PerteneceAPerfilSuperior;
			txtIdTipo.Visible = mz.erp.businessrules.Security.PerteneceAPerfilSuperior;
			KeyPreview = true;
		}

		private void InitializeData()
		{
			UpdateTree(ultraTreeTiposObservaciones.Nodes[0]);
			_expandir = false;
			ultraTreeTiposObservaciones.Nodes[0].Expanded = true;
			_expandir = true;

		}

		private void UpdateTree(Infragistics.Win.UltraWinTree.UltraTreeNode Node)
		{
			string key = Node.Key;
			_uiController.UpdateTree(key);
			while(_uiController.HasNext())
			{
				ArrayList nodo = _uiController.Next();
				string keyChildNode = Convert.ToString(nodo[0]);
				string descriptionChildNode = Convert.ToString(nodo[1]);
				Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
				/* Lo que estaba antes para que no muestre el activo en el texto del arbol de la interfaz
				Infragistics.Win.UltraWinTree.UltraTreeNode childNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, this.getDescriptionFrom(descriptionChildNode));
				Infragistics.Win.UltraWinTree.UltraTreeNode childNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
				*/
				if(!Node.Nodes.Exists(keyChildNode))
					Node.Nodes.Add(childNode);
				/*if(!_tree.Nodes.Exists(keyChildNode))
					_tree.Nodes.Add(childNode1);*/

			}
			int i = 0;
			foreach(Infragistics.Win.UltraWinTree.UltraTreeNode childNode in Node.Nodes)
			{
				string keyC = childNode.Key;
				_uiController.UpdateTree(keyC);
				while(_uiController.HasNext())
				{
					ArrayList nodo = _uiController.Next();
					string keyChildNode = Convert.ToString(nodo[0]);
					string descriptionChildNode = Convert.ToString(nodo[1]);
					Infragistics.Win.UltraWinTree.UltraTreeNode childChildNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
					/* Lo que estaba antes para que no muestre el activo en el texto del arbol de la interfaz
					Infragistics.Win.UltraWinTree.UltraTreeNode childChildNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, this.getDescriptionFrom(descriptionChildNode));
					Infragistics.Win.UltraWinTree.UltraTreeNode childChildNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode(keyChildNode, descriptionChildNode);
					*/
					if(!childNode.Nodes.Exists(keyChildNode))
						childNode.Nodes.Add(childChildNode);
					/*if(!_tree.Nodes[i].Nodes.Exists(keyChildNode))
						_tree.Nodes[i].Nodes.Add(childChildNode1);*/
				}
				i++;
			}

		}

		/* Lo que estaba antes para que no muestre el activo en el texto del arbol de la interfaz
		private Infragistics.Win.UltraWinTree.UltraTreeNode findNode(string key)
		{
			Infragistics.Win.UltraWinTree.UltraTreeNode clonedTree = (Infragistics.Win.UltraWinTree.UltraTreeNode)_tree.Clone();
			return this.findNode(clonedTree, key);
		}

		private Infragistics.Win.UltraWinTree.UltraTreeNode findNode(Infragistics.Win.UltraWinTree.UltraTreeNode node, string key)
		{
			Infragistics.Win.UltraWinTree.UltraTreeNode searchNode = null;
			if(node.Key.Equals(key))
				searchNode = node;
			else
			{
				int i = 0;
				while(i < node.Nodes.Count & searchNode == null){
					searchNode = this.findNode(node.Nodes[i], key);
					i++;
			     }
			}
			return searchNode;
		
		}
		*/

		private void InitEventHandlers()
		{
			ultraTreeTiposObservaciones.AfterActivate +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterActivate);
			ultraTreeTiposObservaciones.AfterExpand +=new Infragistics.Win.UltraWinTree.AfterNodeChangedEventHandler(ultraTreeAgrupamientos_AfterExpand);
			_uiController.TiposObservacionesNuevasHasChanged+=new EventHandler(_uiController_TiposObservacionesNuevasHasChanged);
			this.toolBarStandar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBarStandar_ButtonClick);			
			KeyDownManager KeyDown = new KeyDownManager(this);
		}	
	
		private void InitDataBindings()
		{
			gridEX1.DataSource = _uiController.TiposObservacionesNuevas;
			if(_uiController.TiposObservacionesNuevas.Count > 0)
				btnEliminar.Enabled = true;
		}

		#endregion

		#region Miembros de ITaskForm

		public void Execute()
		{
			this._uiController.Execute();
		}

		public void Previous()
		{
			this._uiController.Previous();
		}

		public void ShowForm()
		{
			if(this._uiController.AllowShow())
			{
				this.Build_UI();
				base.Show();
				_uiController.RefreshData();
			}
			else
			{
				if(_uiController.IsNextState())
					this._uiController.Execute();
				else
					if(_uiController.IsBackState())
					this._uiController.Previous();
			}
		}

		public void CloseForm()
		{			
			if (_uiController.PreguntarAlCancelar)
			{
				if ((MessageBox.Show(this,"Est� a punto de cerrar el fomulario. Realmente desea realizar esta operaci�n?","Atenci�n!",System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Stop )== System.Windows.Forms.DialogResult.OK))
					Close();
			}
			else
			{
				Close();
			}
		}

		public void KeyDownPrevious()
		{
			_uiController.Previous();
		}

		public void KeyDownNext()
		{
			SaveChanges();
		}

		#endregion

		#region Metodos Privados
		private void Init() 
		{			
			tbbAnterior.Text = _uiController.TextoBotonAnterior;
			tbbSiguiente.Text = _uiController.TextoBotonSiguiente;			
		}

		private void SaveChanges()
		{	
			Util.MoveFocus(this.ultraExplorerBarContainerControl2);
			_uiController.Execute();
		}

		private string getDescriptionFrom(string description)
		{
			int pos = description.IndexOf("(") -1;
			if(pos >0)
                return description.Substring(0,pos);
			else
				return description;

		}

		private bool isActivo(string description)
		{
			if(description.IndexOf("Activo") > 0)
				return true;
			else
				return false;
		
		}

		#endregion

		private void toolBarStandar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{	
			switch ( toolBarStandar.Buttons.IndexOf( e.Button ) )
			{
				case 0:
					_uiController.Previous();
					break;
				case 2:	//Guardar					
					SaveChanges();
					break;
				case 4:	//Salir					
					CloseForm();
					break;
			}						
		}

		private void ultraTreeAgrupamientos_AfterExpand(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			if (_expandir) {UpdateTree(e.TreeNode);}
		}

		private void ultraTreeAgrupamientos_AfterActivate(object sender, Infragistics.Win.UltraWinTree.NodeEventArgs e)
		{
			_uiController.CurrentKey = e.TreeNode.Key;
			_uiController.CurrentDescription = e.TreeNode.Text;
			if(_uiController.CurrentKey != "RAIZ")
			{
				_uiController.ParentKey = e.TreeNode.Parent.Key;
				_uiController.ParentDescription = e.TreeNode.Parent.Text;
                btnModificarTipo.Enabled = true;
				/*Lo que estaba antes para que no muestre el activo en el texto del arbol de la interfaz
				Infragistics.Win.UltraWinTree.UltraTreeNode node = this.findNode(e.TreeNode.Key);
				_uiController.Activo = this.isActivo(node.Text);
				*/
				_uiController.Activo = this.isActivo(_uiController.CurrentDescription);
				chkActivo.Checked = _uiController.Activo;
				chkActivo.Enabled = true;
			}
			else
			{
				btnModificarTipo.Enabled = false;
				chkActivo.Enabled = false;
			}			
			this.txtDescripcionModifTipo.Text = this.getDescriptionFrom(_uiController.CurrentDescription);
			btnAgregarTipo.Enabled = true;
			txtIdTipo.Text = _uiController.CurrentKey;
		}

		private void btnModificarTipo_Click(object sender, System.EventArgs e)
		{
			if(_uiController.CurrentKey != "RAIZ")
			{
				bool activo = false;
				if(chkActivo.Checked)
					activo = true;
				else
					activo = false;
				_uiController.AddMovimiento(txtDescripcionModifTipo.Text, _uiController.CurrentKey , _uiController.ParentKey, this.getDescriptionFrom(_uiController.ParentDescription), activo, "MODIF");			
			}

		}

		private void _uiController_TiposObservacionesNuevasHasChanged(object sender, EventArgs e)
		{			
			this.gridEX1.SetDataBinding( null, null );
			this.gridEX1.SetDataBinding(_uiController.TiposObservacionesNuevas, null );
			btnEliminar.Enabled = true;
		}

		private void btnAgregarTipo_Click(object sender, System.EventArgs e)
		{
			_uiController.AddMovimiento(txtDescripcionModifTipo.Text, "" , _uiController.CurrentKey, this.getDescriptionFrom(_uiController.CurrentDescription), true, "NEW");			

		}

		private void btnEliminar_Click(object sender, System.EventArgs e)
		{
			CurrencyManager cm = (CurrencyManager) this.BindingContext[_uiController.TiposObservacionesNuevas];
			int pos = cm.Position;
			if(pos >= 0)
			{
				cm.RemoveAt(pos);
				cm.Refresh();
			}		
			CurrencyManager cm1 = (CurrencyManager) this.BindingContext[_uiController.TiposObservacionesNuevasConfigVariables];
			int pos1 = cm1.Position;
			if(pos1 >= 0)
			{
				cm1.RemoveAt(pos1);
				cm1.Refresh();
			}		
			if(_uiController.TiposObservacionesNuevas.Count == 0)
				btnEliminar.Enabled = false;	
		}

	}
}
