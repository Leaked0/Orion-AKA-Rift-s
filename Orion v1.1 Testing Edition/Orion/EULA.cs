using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Guna.UI2.WinForms.Interfaces;

namespace Orion
{
	public class EULA : Form
	{
		private _8F92C2D2 ToolStripRenderEventArgs_002D4815824;

		private IContainer CloseReason_002D4567380;

		private Guna2ShadowForm ListViewItemStates_002D7752229;

		private Guna2Elipse MultiSelectRootGridEntry_002D7196139;

		private Panel ToolStripProfessionalLowResolutionRenderer_002D7365336;

		private Guna2Button WebBrowserNavigatedEventHandler_002D5590076;

		private Guna2Button ToolStripSplitButton_002D9041531;

		private Guna2PictureBox DataGridViewColumnSortMode_002D9231780;

		private Guna2PictureBox KeyboardToolTipStateMachine_002D9240644;

		private Guna2PictureBox DataTableNewRowEventHandler_002D2764305;

		private Guna2Panel DockingBehavior_002D329361;

		private Label TypedDataSetGenerator_002D8583820;

		private Guna2CirclePictureBox AssemblyCache_002D8526626;

		private Guna2DragControl DataGridViewRowHeaderCell_002D24528;

		private Guna2AnimateWindow AutoIncrementValue_002D2236761;

		private RichTextBox DataRowState_002D3044534;

		private Guna2Button XmlBoundElement_002D3389560;

		private Guna2Button PrintControllerWithStatusDialog_002D3274202;

		public EULA()
		{
			_ = (new object[1] { this })[0];
			object obj = null;
			((EULA)obj).ToolStripRenderEventArgs_002D4815824 = F4B60600.ParameterDirection_002D7551389;
			((Form)obj)._002Ector();
			((EULA)obj).UICues_002D6216163();
		}

		private void AcceptRejectRule_002D8306337(object sender, EventArgs e)
		{
			object[] array = new object[3] { this, sender, e };
			_ = ((object[])((object[])array[1])[0])[2];
			Application.Exit();
		}

		private void DocCommentAccessibleObject_002D9415414(object sender, EventArgs e)
		{
			object[] array = new object[3] { this, sender, e };
			_ = ((object[])((object[])array[1])[2])[0];
			object obj = null;
			((Form)obj).WindowState = FormWindowState.Minimized;
		}

		private void SessionSwitchEventArgs_002D3138542(object sender, EventArgs e)
		{
			object[] array = new object[3] { this, sender, e };
			object obj = ((object[])array[1])[0];
			object obj2 = null;
			_ = ((object[])obj)[2];
			((Control)(object)((EULA)obj2).DockingBehavior_002D329361).BringToFront();
		}

		private void MissingSchemaAction_002D962570(object sender, EventArgs e)
		{
			object[] array = new object[3] { this, sender, e };
			object obj = array[0];
			object obj2 = null;
			_ = ((object[])((object[])obj)[2])[1];
			((EULA)obj2).ToolStripRenderEventArgs_002D4815824.DataGridViewComboBoxColumn_002D6017064("EULA", "1");
			((Control)obj2).Hide();
			new Main().ShowDialog();
			((Form)obj2).Close();
		}

		private void ListViewItemSelectionChangedEventArgs_002D3488694(object sender, EventArgs e)
		{
			object[] array = new object[3] { this, sender, e };
			_ = ((object[])((object[])array[1])[0])[2];
			Application.Exit();
		}

		private void ConstNode_002D9074589(object sender, EventArgs e)
		{
			object[] array = new object[3] { this, sender, e };
			_ = ((object[])((object[])array[2])[1])[0];
			object obj = null;
			((EULA)obj).DataRowState_002D3044534.Text = _755552C2.CheckLvalueKind_002D6935578;
		}

		protected override void Dispose(bool NullableType_002D4046733)
		{
			//IL_0020: Expected O, but got I4
			//IL_0030: Expected I4, but got O
			object[] array = new object[2] { this, NullableType_002D4046733 };
			object obj = array[1];
			bool flag = (byte)(int)null != 0;
			_ = ((object[])obj)[0];
			object obj2 = null;
			if (flag && ((EULA)obj2).CloseReason_002D4567380 != null)
			{
				((EULA)obj2).CloseReason_002D4567380.Dispose();
			}
			((Form)obj2).Dispose(flag);
		}

		private void UICues_002D6216163()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected O, but got Unknown
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			object[] array = new object[1] { this };
			_ = ((object[])null)[0];
			object obj = null;
			ComponentResourceManager componentResourceManager = null;
			((EULA)obj).CloseReason_002D4567380 = new Container();
			componentResourceManager = new ComponentResourceManager(typeof(EULA));
			((EULA)obj).ListViewItemStates_002D7752229 = new Guna2ShadowForm(((EULA)obj).CloseReason_002D4567380);
			((EULA)obj).MultiSelectRootGridEntry_002D7196139 = new Guna2Elipse(((EULA)obj).CloseReason_002D4567380);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336 = new Panel();
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076 = new Guna2Button();
			((EULA)obj).ToolStripSplitButton_002D9041531 = new Guna2Button();
			((EULA)obj).AssemblyCache_002D8526626 = new Guna2CirclePictureBox();
			((EULA)obj).DockingBehavior_002D329361 = new Guna2Panel();
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202 = new Guna2Button();
			((EULA)obj).XmlBoundElement_002D3389560 = new Guna2Button();
			((EULA)obj).DataRowState_002D3044534 = new RichTextBox();
			((EULA)obj).TypedDataSetGenerator_002D8583820 = new Label();
			((EULA)obj).DataGridViewColumnSortMode_002D9231780 = new Guna2PictureBox();
			((EULA)obj).KeyboardToolTipStateMachine_002D9240644 = new Guna2PictureBox();
			((EULA)obj).DataTableNewRowEventHandler_002D2764305 = new Guna2PictureBox();
			((EULA)obj).DataGridViewRowHeaderCell_002D24528 = new Guna2DragControl(((EULA)obj).CloseReason_002D4567380);
			((EULA)obj).AutoIncrementValue_002D2236761 = new Guna2AnimateWindow(((EULA)obj).CloseReason_002D4567380);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.SuspendLayout();
			((ISupportInitialize)((EULA)obj).AssemblyCache_002D8526626).BeginInit();
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).SuspendLayout();
			((ISupportInitialize)((EULA)obj).DataGridViewColumnSortMode_002D9231780).BeginInit();
			((ISupportInitialize)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).BeginInit();
			((ISupportInitialize)((EULA)obj).DataTableNewRowEventHandler_002D2764305).BeginInit();
			((Control)obj).SuspendLayout();
			((EULA)obj).ListViewItemStates_002D7752229.set_TargetForm((Form)obj);
			((EULA)obj).MultiSelectRootGridEntry_002D7196139.set_BorderRadius(16);
			((EULA)obj).MultiSelectRootGridEntry_002D7196139.set_TargetControl((Control)obj);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.BackColor = Color.FromArgb(134, 102, 255);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).AssemblyCache_002D8526626);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).DockingBehavior_002D329361);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Controls.Add((Control)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Location = new Point(-6, -4);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Name = "panel1";
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.Size = new Size(647, 517);
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.TabIndex = 39;
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.set_BorderColor(Color.White);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.set_BorderRadius(8);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.set_BorderThickness(1);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_CheckedState().set_Parent((ICustomButtonControl)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).Cursor = Cursors.Hand;
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_CustomImages().set_Parent((ICustomButtonControl)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_DisabledState().set_BorderColor(Color.DarkGray);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_DisabledState().set_Parent((ICustomButtonControl)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076);
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.set_FillColor(Color.Gold);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).Font = new Font("Segoe UI", 9f);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).ForeColor = Color.White;
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_HoverState().set_Parent((ICustomButtonControl)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).Location = new Point(593, 16);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).Name = "guna2Button36";
			((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).Size = new Size(18, 18);
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).TabIndex = 72;
			((Control)(object)((EULA)obj).WebBrowserNavigatedEventHandler_002D5590076).Click += DocCommentAccessibleObject_002D9415414;
			((EULA)obj).ToolStripSplitButton_002D9041531.set_BorderColor(Color.White);
			((EULA)obj).ToolStripSplitButton_002D9041531.set_BorderRadius(8);
			((EULA)obj).ToolStripSplitButton_002D9041531.set_BorderThickness(1);
			((EULA)obj).ToolStripSplitButton_002D9041531.get_CheckedState().set_Parent((ICustomButtonControl)(object)((EULA)obj).ToolStripSplitButton_002D9041531);
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).Cursor = Cursors.Hand;
			((EULA)obj).ToolStripSplitButton_002D9041531.get_CustomImages().set_Parent((ICustomButtonControl)(object)((EULA)obj).ToolStripSplitButton_002D9041531);
			((EULA)obj).ToolStripSplitButton_002D9041531.get_DisabledState().set_BorderColor(Color.DarkGray);
			((EULA)obj).ToolStripSplitButton_002D9041531.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
			((EULA)obj).ToolStripSplitButton_002D9041531.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
			((EULA)obj).ToolStripSplitButton_002D9041531.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
			((EULA)obj).ToolStripSplitButton_002D9041531.get_DisabledState().set_Parent((ICustomButtonControl)(object)((EULA)obj).ToolStripSplitButton_002D9041531);
			((EULA)obj).ToolStripSplitButton_002D9041531.set_FillColor(Color.FromArgb(255, 128, 128));
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).Font = new Font("Segoe UI", 9f);
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).ForeColor = Color.White;
			((EULA)obj).ToolStripSplitButton_002D9041531.get_HoverState().set_Parent((ICustomButtonControl)(object)((EULA)obj).ToolStripSplitButton_002D9041531);
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).Location = new Point(617, 16);
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).Name = "guna2Button37";
			((EULA)obj).ToolStripSplitButton_002D9041531.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531);
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).Size = new Size(18, 18);
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).TabIndex = 71;
			((Control)(object)((EULA)obj).ToolStripSplitButton_002D9041531).Click += AcceptRejectRule_002D8306337;
			((Control)(object)((EULA)obj).AssemblyCache_002D8526626).BackColor = Color.Transparent;
			((PictureBox)(object)((EULA)obj).AssemblyCache_002D8526626).Image = (Image)componentResourceManager.GetObject("guna2CirclePictureBox4.Image");
			((EULA)obj).AssemblyCache_002D8526626.set_ImageRotate(0f);
			((Control)(object)((EULA)obj).AssemblyCache_002D8526626).Location = new Point(18, 16);
			((Control)(object)((EULA)obj).AssemblyCache_002D8526626).Name = "guna2CirclePictureBox4";
			((EULA)obj).AssemblyCache_002D8526626.get_ShadowDecoration().set_Mode((ShadowMode)1);
			((EULA)obj).AssemblyCache_002D8526626.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).AssemblyCache_002D8526626);
			((Control)(object)((EULA)obj).AssemblyCache_002D8526626).Size = new Size(98, 99);
			((PictureBox)(object)((EULA)obj).AssemblyCache_002D8526626).SizeMode = PictureBoxSizeMode.Zoom;
			((PictureBox)(object)((EULA)obj).AssemblyCache_002D8526626).TabIndex = 69;
			((PictureBox)(object)((EULA)obj).AssemblyCache_002D8526626).TabStop = false;
			((EULA)obj).AssemblyCache_002D8526626.set_UseTransparentBackground(true);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).BackColor = Color.Transparent;
			((EULA)obj).DockingBehavior_002D329361.set_BorderRadius(10);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Controls.Add((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Controls.Add((Control)(object)((EULA)obj).XmlBoundElement_002D3389560);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Controls.Add(((EULA)obj).DataRowState_002D3044534);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Controls.Add(((EULA)obj).TypedDataSetGenerator_002D8583820);
			((EULA)obj).DockingBehavior_002D329361.set_FillColor(Color.FromArgb(233, 236, 248));
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Location = new Point(122, 19);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Name = "guna2Panel26";
			((EULA)obj).DockingBehavior_002D329361.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).DockingBehavior_002D329361);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).Size = new Size(442, 407);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).TabIndex = 0;
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).BackColor = Color.Transparent;
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.set_BorderRadius(20);
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_CheckedState().set_Parent((ICustomButtonControl)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202);
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Cursor = Cursors.Hand;
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_CustomImages().set_Parent((ICustomButtonControl)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202);
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_DisabledState().set_BorderColor(Color.DarkGray);
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_DisabledState().set_Parent((ICustomButtonControl)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202);
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.set_FillColor(Color.FromArgb(134, 102, 255));
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Font = new Font("Nirmala UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).ForeColor = Color.White;
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_HoverState().set_FillColor(Color.FromArgb(149, 123, 253));
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_HoverState().set_Parent((ICustomButtonControl)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202);
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.set_ImageSize(new Size(25, 25));
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Location = new Point(243, 354);
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Name = "guna2Button1";
			((EULA)obj).PrintControllerWithStatusDialog_002D3274202.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202);
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Size = new Size(127, 42);
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).TabIndex = 79;
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Text = "Accept";
			((Control)(object)((EULA)obj).PrintControllerWithStatusDialog_002D3274202).Click += MissingSchemaAction_002D962570;
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).BackColor = Color.Transparent;
			((EULA)obj).XmlBoundElement_002D3389560.set_BorderRadius(20);
			((EULA)obj).XmlBoundElement_002D3389560.get_CheckedState().set_Parent((ICustomButtonControl)(object)((EULA)obj).XmlBoundElement_002D3389560);
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Cursor = Cursors.Hand;
			((EULA)obj).XmlBoundElement_002D3389560.get_CustomImages().set_Parent((ICustomButtonControl)(object)((EULA)obj).XmlBoundElement_002D3389560);
			((EULA)obj).XmlBoundElement_002D3389560.get_DisabledState().set_BorderColor(Color.DarkGray);
			((EULA)obj).XmlBoundElement_002D3389560.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
			((EULA)obj).XmlBoundElement_002D3389560.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
			((EULA)obj).XmlBoundElement_002D3389560.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
			((EULA)obj).XmlBoundElement_002D3389560.get_DisabledState().set_Parent((ICustomButtonControl)(object)((EULA)obj).XmlBoundElement_002D3389560);
			((EULA)obj).XmlBoundElement_002D3389560.set_FillColor(Color.FromArgb(134, 102, 255));
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Font = new Font("Nirmala UI", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).ForeColor = Color.White;
			((EULA)obj).XmlBoundElement_002D3389560.get_HoverState().set_FillColor(Color.FromArgb(149, 123, 253));
			((EULA)obj).XmlBoundElement_002D3389560.get_HoverState().set_Parent((ICustomButtonControl)(object)((EULA)obj).XmlBoundElement_002D3389560);
			((EULA)obj).XmlBoundElement_002D3389560.set_ImageSize(new Size(25, 25));
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Location = new Point(96, 354);
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Name = "deleter";
			((EULA)obj).XmlBoundElement_002D3389560.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).XmlBoundElement_002D3389560);
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Size = new Size(127, 42);
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).TabIndex = 78;
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Text = "Reject";
			((Control)(object)((EULA)obj).XmlBoundElement_002D3389560).Click += ListViewItemSelectionChangedEventArgs_002D3488694;
			((EULA)obj).DataRowState_002D3044534.BorderStyle = BorderStyle.None;
			((EULA)obj).DataRowState_002D3044534.Font = new Font("Nirmala UI", 10f);
			((EULA)obj).DataRowState_002D3044534.Location = new Point(96, 34);
			((EULA)obj).DataRowState_002D3044534.Name = "richTextBox1";
			((EULA)obj).DataRowState_002D3044534.ReadOnly = true;
			((EULA)obj).DataRowState_002D3044534.Size = new Size(274, 314);
			((EULA)obj).DataRowState_002D3044534.TabIndex = 71;
			((EULA)obj).DataRowState_002D3044534.Text = "";
			((EULA)obj).TypedDataSetGenerator_002D8583820.AutoSize = true;
			((EULA)obj).TypedDataSetGenerator_002D8583820.BackColor = Color.Transparent;
			((EULA)obj).TypedDataSetGenerator_002D8583820.Font = new Font("Nirmala UI", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			((EULA)obj).TypedDataSetGenerator_002D8583820.ForeColor = Color.FromArgb(134, 102, 255);
			((EULA)obj).TypedDataSetGenerator_002D8583820.Location = new Point(5, 5);
			((EULA)obj).TypedDataSetGenerator_002D8583820.Name = "label37";
			((EULA)obj).TypedDataSetGenerator_002D8583820.Size = new Size(50, 21);
			((EULA)obj).TypedDataSetGenerator_002D8583820.TabIndex = 66;
			((EULA)obj).TypedDataSetGenerator_002D8583820.Text = "EULA";
			((Control)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).BackColor = Color.Transparent;
			((PictureBox)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).Image = _755552C2.ConstraintException_002D1267829;
			((EULA)obj).DataGridViewColumnSortMode_002D9231780.set_ImageRotate(0f);
			((Control)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).Location = new Point(-771, 192);
			((Control)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).Name = "guna2PictureBox3";
			((EULA)obj).DataGridViewColumnSortMode_002D9231780.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780);
			((Control)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).Size = new Size(1629, 427);
			((PictureBox)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).SizeMode = PictureBoxSizeMode.Zoom;
			((PictureBox)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).TabIndex = 3;
			((PictureBox)(object)((EULA)obj).DataGridViewColumnSortMode_002D9231780).TabStop = false;
			((EULA)obj).DataGridViewColumnSortMode_002D9231780.set_UseTransparentBackground(true);
			((Control)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).BackColor = Color.Transparent;
			((PictureBox)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).Image = _755552C2.ISQLDebug_002D9657665;
			((EULA)obj).KeyboardToolTipStateMachine_002D9240644.set_ImageRotate(0f);
			((Control)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).Location = new Point(-26, 194);
			((Control)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).Name = "guna2PictureBox2";
			((EULA)obj).KeyboardToolTipStateMachine_002D9240644.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644);
			((Control)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).Size = new Size(884, 427);
			((PictureBox)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).SizeMode = PictureBoxSizeMode.Zoom;
			((PictureBox)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).TabIndex = 2;
			((PictureBox)(object)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).TabStop = false;
			((EULA)obj).KeyboardToolTipStateMachine_002D9240644.set_UseTransparentBackground(true);
			((Control)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).BackColor = Color.Transparent;
			((PictureBox)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).Image = _755552C2.GridEntryCollection_002D8464208;
			((EULA)obj).DataTableNewRowEventHandler_002D2764305.set_ImageRotate(0f);
			((Control)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).Location = new Point(-9, 256);
			((Control)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).Name = "guna2PictureBox1";
			((EULA)obj).DataTableNewRowEventHandler_002D2764305.get_ShadowDecoration().set_Parent((Control)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305);
			((Control)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).Size = new Size(854, 342);
			((PictureBox)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).SizeMode = PictureBoxSizeMode.Zoom;
			((PictureBox)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).TabIndex = 1;
			((PictureBox)(object)((EULA)obj).DataTableNewRowEventHandler_002D2764305).TabStop = false;
			((EULA)obj).DataTableNewRowEventHandler_002D2764305.set_UseTransparentBackground(true);
			((EULA)obj).DataGridViewRowHeaderCell_002D24528.set_TargetControl((Control)((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336);
			((EULA)obj).AutoIncrementValue_002D2236761.set_AnimationType((AnimateWindowType)524288);
			((EULA)obj).AutoIncrementValue_002D2236761.set_TargetForm((Form)obj);
			((ContainerControl)obj).AutoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)obj).AutoScaleMode = AutoScaleMode.Font;
			((Form)obj).ClientSize = new Size(642, 487);
			((Control)obj).Controls.Add(((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336);
			((Form)obj).FormBorderStyle = FormBorderStyle.None;
			((Form)obj).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			((Control)obj).Name = "EULA";
			((Control)obj).Text = "Orion";
			((Form)obj).Load += ConstNode_002D9074589;
			((EULA)obj).ToolStripProfessionalLowResolutionRenderer_002D7365336.ResumeLayout(performLayout: false);
			((ISupportInitialize)((EULA)obj).AssemblyCache_002D8526626).EndInit();
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).ResumeLayout(performLayout: false);
			((Control)(object)((EULA)obj).DockingBehavior_002D329361).PerformLayout();
			((ISupportInitialize)((EULA)obj).DataGridViewColumnSortMode_002D9231780).EndInit();
			((ISupportInitialize)((EULA)obj).KeyboardToolTipStateMachine_002D9240644).EndInit();
			((ISupportInitialize)((EULA)obj).DataTableNewRowEventHandler_002D2764305).EndInit();
			((Control)obj).ResumeLayout(performLayout: false);
		}
	}
}
