//
// System.Windows.Forms.ListBox.cs
//
// Author:
//   stubbed out by Daniel Carrera (dcarrera@math.toronto.edu)
//   Dennis Hayes (dennish@Raytek.com)
//
// (C) 2002 Ximian, Inc
//
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms {

	// <summary>
	// </summary>

	public class ListBox : ListControl {

		//
		//  --- Constructor
		//
		[MonoTODO]
		public ListBox() {
			SubClassWndProc_ = true;
			BorderStyle_ = BorderStyle.Fixed3D;
		}

		//
		//	 --- Protected Fields
		//
		protected int ColumnWidth_ = 0; // The columns will have default width
		protected bool IntegralHeight_ = true;
		protected ListBox.ObjectCollection	Items_ = null;
		protected DrawMode DrawMode_ = DrawMode.Normal;
		protected bool UseTabStops_ = false;
		protected bool MultiColumn_ = false;
		int selectedIndex = -1;
		bool Sorted_ = false;
		internal int prevSelectedIndex = -1;
		BorderStyle	BorderStyle_;
		
		//
		//	 --- Public Fields
		//
		public const int DefaultItemHeight = 500;//just guessing FIXME // = ??;
		public const int NoMatches = 0 ;//just guessing FIXME // = ??;
		

		//
		//  --- Public Properties
		//

		[MonoTODO]
		public override Color BackColor {
			get {
				//FIXME:
				return base.BackColor;
			}
			set {
				//FIXME:
				base.BackColor = value;
			}
		}
		[MonoTODO]
		public override Image BackgroundImage {
			get {
				//FIXME:
				return base.BackgroundImage;
			}
			set {
				//FIXME:
				base.BackgroundImage = value;
			}
		}

		public BorderStyle BorderStyle {
			get {
				return BorderStyle_;				
			}
			set {
				if( BorderStyle_ != value) {
					BorderStyle_ = value;
					if( IsHandleCreated) {
						
					}
				}
			}
		}
		public bool MultiColumn {
			get {
				return MultiColumn_;
			}
			set {
				if( MultiColumn_ != value) {
					MultiColumn_ = value;
					RecreateHandle();
				}
			}
		}

		[MonoTODO]
		public override RightToLeft RightToLeft {
			get {
				//FIXME:
				return base.RightToLeft;
			}
			set {
				//FIXME:
				base.RightToLeft = value;
			}
		}
		[MonoTODO]
		public bool ScrollAlwaysVisible {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public override int SelectedIndex {
			get {
				if( IsHandleCreated) {
					return Win32.SendMessage(Handle, (int)ListBoxMessages.LB_GETCURSEL, 0, 0);
				}
				else {
					return selectedIndex;
				}
			}
			set {
				prevSelectedIndex = selectedIndex;
				if( selectedIndex != value) {
					//FIXME: set exception parameters
					selectedIndex = value;
					if( IsHandleCreated) {
						Win32.SendMessage(Handle, (int)ListBoxMessages.LB_SETCURSEL, selectedIndex, 0);
					}
					OnSelectedIndexChanged(new EventArgs());
				}
			}
		}
		
		[MonoTODO]
		public ListBox.SelectedIndexCollection SelectedIndices {
			get {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public object SelectedItem {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public ListBox.SelectedObjectCollection SelectedItems {
			get {
				throw new NotImplementedException ();
			}
		}
		[MonoTODO]
		public virtual SelectionMode SelectionMode {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public bool Sorted {
			get {
				return Sorted_;
			}
			set {
				if( Sorted_ != value){
					Sorted_ = value;
					if( Sorted_) {
						object[] items = new object[Items.Count];
						Items.CopyTo(items, 0);
						Items.Clear();
						Items.AddRange(items);
					}
				}
			}
		}
		[MonoTODO]
		public override string Text {
			get {
				return base.Text;
			}
			set {
				base.Text = value;
			}
		}
		[MonoTODO]
		public int TopIndex {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		[MonoTODO]
		public bool UseTabStops {
			get {
				return UseTabStops_;
			}
			set {
				UseTabStops_ = value;
			}
		}

		[MonoTODO]
		public virtual DrawMode DrawMode {
			get {
				return DrawMode_;
			}
			set {
				DrawMode_ = value;
				// FIXME: change styles of Windows control/ recreate control
			}
		}

		public int ColumnWidth {
			get {
				return ColumnWidth_;
			}
			set {
				ColumnWidth_ = value;
			}
		}
		
		[MonoTODO]
		public virtual int ItemHeight {
			get {
				throw new NotImplementedException ();
			}
			set {
				//FIXME:
			}
		}
		public bool IntegralHeight {
			get {
				return IntegralHeight_;
			}
			set {
				IntegralHeight_ = value;
			}
		}
		
		public ListBox.ObjectCollection Items {
			get {
				if( Items_ == null) {
					Items_ = new ListBox.ObjectCollection( this);
				}
				return Items_;
			}
		}
		
		//
		//  --- Public Methods
		//
		[MonoTODO]
		public void BeginUpdate() {
			//FIXME:
		}
		[MonoTODO]
		public void ClearSelected() {
			//FIXME:
		}
		[MonoTODO]
		public void EndUpdate() {
			//FIXME:
		}
		[MonoTODO]
		public int FindString(string str) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public int FindString(string str, int val) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public int FindStringExact(string str) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public int FindStringExact(string str, int val) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public int GetItemHeight(int index) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public Rectangle GetItemRectangle(int index) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public bool GetSelected(int index) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public int IndexFromPoint(Point pt) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public int IndexFromPoint(int val1, int val2) {
			throw new NotImplementedException ();
		}
		[MonoTODO]
		public void SetSelected(int index, bool val) {
			//FIXME:
		}
		[MonoTODO]
		public override string ToString() {
			//FIXME:
			return base.ToString();
		}

		//
		//  --- Public Events
		//
		[MonoTODO]
		public event DrawItemEventHandler DrawItem;
		[MonoTODO]
		public event MeasureItemEventHandler MeasureItem;
		public event EventHandler SelectedIndexChanged;
		//
		//  --- Protected Properties
		//
		[MonoTODO]
		protected override CreateParams CreateParams {
			get {
				// This is a child control, so it must have a parent for creation
				if( Parent != null) {
					CreateParams createParams = new CreateParams ();
					// CHECKME: here we must not overwrite window
					if( window == null) {
						window = new ControlNativeWindow (this);
					}

					createParams.Caption = Text;
					createParams.ClassName = "LISTBOX";
					createParams.X = Left;
					createParams.Y = Top;
					createParams.Width = Width;
					createParams.Height = Height;
					createParams.ClassStyle = 0;
					createParams.ExStyle = (int)WindowExStyles.WS_EX_CLIENTEDGE;
					createParams.Param = 0;
					createParams.Parent = Parent.Handle;
					createParams.Style = (int) (
						WindowStyles.WS_CHILD | 
						WindowStyles.WS_VISIBLE |
						WindowStyles.WS_CLIPSIBLINGS);
					createParams.Style |= (int) (ListBoxStyles.LBS_NOTIFY | 
						ListBoxStyles.LBS_HASSTRINGS );
					if( !IntegralHeight_) {
						createParams.Style |= (int)ListBoxStyles.LBS_NOINTEGRALHEIGHT;
					}
					if( UseTabStops_ ) {
						createParams.Style |= (int)ListBoxStyles.LBS_USETABSTOPS;
					}
					switch( DrawMode_){
						case DrawMode.OwnerDrawFixed:
							createParams.Style |= (int)ListBoxStyles.LBS_OWNERDRAWFIXED;
							break;
						case DrawMode.OwnerDrawVariable:
							createParams.Style |= (int)ListBoxStyles.LBS_OWNERDRAWVARIABLE;
							break;
					}
					if( MultiColumn_) {
						createParams.Style |= (int)ListBoxStyles.LBS_MULTICOLUMN | (int)WindowStyles.WS_HSCROLL;
					}
					else {
						createParams.Style |= (int)WindowStyles.WS_VSCROLL;
					}
					// CHECKME : this call is commented because (IMHO) Control.CreateHandle supposed to do this
					// and this function is CreateParams, not CreateHandle
					// window.CreateHandle (createParams);
					return createParams;
				}
				return null;
			}		
		}

		protected override void OnCreateControl ()
		{
			base.OnCreateControl();
		}

		[MonoTODO]
		protected override Size DefaultSize {
			get {
				return new Size(120,95);
			}
		}

		//
		//  --- Protected Methods
		//
		[MonoTODO]
		protected virtual ObjectCollection CreateItemCollection() {
			throw new NotImplementedException ();
		}

		[MonoTODO]
		protected override void OnChangeUICues(UICuesEventArgs e) {
			//FIXME:
			base.OnChangeUICues(e);
		}
		[MonoTODO]
		protected override void OnDataSourceChanged(EventArgs e) {
			//FIXME:
			base.OnDataSourceChanged(e);
		}
		[MonoTODO]
		protected override void OnDisplayMemberChanged(EventArgs e) {
			//FIXME:
			base.OnDisplayMemberChanged(e);
		}

		[MonoTODO]
		protected virtual void OnDrawItem(DrawItemEventArgs e) {
			if( DrawItem != null) {
				DrawItem(this, e);
			}
		}

		[MonoTODO]
		protected override void OnFontChanged(EventArgs e) {
			//FIXME:
			base.OnFontChanged(e);
		}
		[MonoTODO]
		protected override void OnHandleCreated(EventArgs e) {
			//FIXME:
			base.OnHandleCreated(e);
			if( Items_ != null) {
				foreach( object item in Items_) {
					Win32.SendMessage(Handle, (int)ListBoxMessages.LB_ADDSTRING, 0, item.ToString());
				}
			}
			if( ColumnWidth_ != 0 && MultiColumn_) {
				Win32.SendMessage( Handle, (int)ListBoxMessages.LB_SETCOLUMNWIDTH, ColumnWidth_, 0);
			}
			
		}
		[MonoTODO]
		protected override void OnHandleDestroyed(EventArgs e) {
			//FIXME:
			base.OnHandleDestroyed(e);
		}

		[MonoTODO]
		protected virtual void OnMeasureItem(MeasureItemEventArgs e) {
			if( MeasureItem != null) {
				MeasureItem(this, e);
			}
		}

		[MonoTODO]
		protected override void OnParentChanged(EventArgs e) {
			//FIXME:
			base.OnParentChanged(e);
		}
		[MonoTODO]
		protected override void OnResize(EventArgs e) {
			//FIXME:
			base.OnResize(e);
		}
		[MonoTODO]
		protected override void OnSelectedIndexChanged(EventArgs e) {
			//FIXME:
			base.OnSelectedIndexChanged(e);
			if( SelectedIndexChanged != null) {
				SelectedIndexChanged(this, e);
			}
		}

		[MonoTODO]
		protected override void OnSelectedValueChanged(EventArgs e) {
			//FIXME:
			base.OnSelectedValueChanged(e);
		}

		protected override void RefreshItem(int index) {
			//FIXME:
		}

		public override void Refresh() { // .NET V1.1 Beta
			base.Refresh();
		}
		
		[MonoTODO]
		protected override void SetBoundsCore( int x, int y,  int width, int height,  BoundsSpecified specified) {
			//FIXME:
			base.SetBoundsCore(x, y, width, height, specified);
		}
		[MonoTODO]
		protected void Sort() {
			//FIXME:
		}
		[MonoTODO]
		protected override void WndProc(ref Message m) {
			switch (m.Msg) {
				case Msg.WM_MEASUREITEM: {
					MEASUREITEMSTRUCT mis = new MEASUREITEMSTRUCT();
					mis = (MEASUREITEMSTRUCT)Marshal.PtrToStructure(m.LParam, mis.GetType());
					MeasureItemEventArgs args = new MeasureItemEventArgs(CreateGraphics(),mis.itemID);
					args.ItemHeight = mis.itemHeight;
					args.ItemWidth = mis.itemWidth;
					OnMeasureItem( args);
					mis.itemHeight = args.ItemHeight;
					mis.itemWidth = args.ItemWidth;
					Marshal.StructureToPtr(mis, m.LParam, false);
					m.Result = (IntPtr)1;
					}
					break;
				case Msg.WM_DRAWITEM: {
					DRAWITEMSTRUCT dis = new DRAWITEMSTRUCT();
					dis = (DRAWITEMSTRUCT)Marshal.PtrToStructure(m.LParam, dis.GetType());
					Rectangle	rect = new Rectangle(dis.rcItem.left, dis.rcItem.top, dis.rcItem.right - dis.rcItem.left, dis.rcItem.bottom - dis.rcItem.top);
					DrawItemEventArgs args = new DrawItemEventArgs(Graphics.FromHdc(dis.hDC), Font,
						rect, dis.itemID, (DrawItemState)dis.itemState);
					OnDrawItem( args);
					//Marshal.StructureToPtr(dis, m.LParam, false);
					m.Result = (IntPtr)1;
					}
					break;
				case Msg.WM_COMMAND: 
					switch(m.HiWordWParam) {
						case (uint)ListBoxNotifications.LBN_SELCHANGE:
							SelectedIndex = Win32.SendMessage(Handle, (int)ListBoxMessages.LB_GETCURSEL, 0, 0);
							m.Result = IntPtr.Zero;
							CallControlWndProc(ref m);
							break;
						default:
							CallControlWndProc(ref m);
							break;
					}
					break;
				default:
					base.WndProc(ref m);
					break;
			}
		}

		//
		// <summary>
		// This is a subclass
		// </summary>

		public class SelectedObjectCollection :  IList, ICollection, IEnumerable {

			//
			//  --- Constructor
			//
			[MonoTODO]
			public SelectedObjectCollection(ListBox owner) {
			}

			//
			//  --- Public Properties
			//
			[MonoTODO]
			public int Count {
				get {
					throw new NotImplementedException ();
				}
			}
			[MonoTODO]
			public bool IsReadOnly {
				get {
					throw new NotImplementedException ();
				}
			}
			[MonoTODO]
			public object this[int index] {
				get {
					throw new NotImplementedException ();
				}
				set {
					//FIXME:
				}
			}

			//
			//  --- Public Methods
			//
			[MonoTODO]
			public bool Contains(object selectedObject) {
				throw new NotImplementedException ();
			}
			[MonoTODO]
			public void CopyTo(Array dest, int index) {
				// FIXME:
			}
			[MonoTODO]
			public override bool Equals(object obj) {
				//FIXME:
				return base.Equals(obj);
			}
			[MonoTODO]
			public override int GetHashCode() {
				//FIXME add our proprities
				return base.GetHashCode();
			}
			[MonoTODO]
			public IEnumerator GetEnumerator() {
				throw new NotImplementedException ();
			}
			[MonoTODO]
			public int IndexOf(object selectedObject) {
				throw new NotImplementedException ();
			}
			/// <summary>
			/// IList Interface implmentation.
			/// </summary>
			bool IList.IsReadOnly{
				get{
					// We allow addition, removeal, and editing of items after creation of the list.
					return false;
				}
			}
			bool IList.IsFixedSize{
				get{
					// We allow addition and removeal of items after creation of the list.
					return false;
				}
			}

			//[MonoTODO]
#if A
			object IList.this[int index]{
				get{
					throw new NotImplementedException ();
				}
				set{
					throw new NotImplementedException ();
				}
			}
#endif
		
			[MonoTODO]
			void IList.Clear(){
				//FIXME:
			}
		
			[MonoTODO]
			int IList.Add( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			bool IList.Contains( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			int IList.IndexOf( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			void IList.Insert(int index, object value){
				//FIXME:
			}

			[MonoTODO]
			void IList.Remove( object value){
				//FIXME:
			}

			[MonoTODO]
			void IList.RemoveAt( int index){
				//FIXME:
			}
			// End of IList interface
			/// <summary>
			/// ICollection Interface implmentation.
			/// </summary>
			int ICollection.Count{
				get{
					throw new NotImplementedException ();
				}
			}
			bool ICollection.IsSynchronized{
				get{
					throw new NotImplementedException ();
				}
			}
			object ICollection.SyncRoot{
				get{
					throw new NotImplementedException ();
				}
			}
			void ICollection.CopyTo(Array array, int index){
				throw new NotImplementedException ();
			}
			// End Of ICollection
		}//End of subclass

		// <summary>
		// </summary>

		public class ObjectCollection : IList, ICollection {

			protected ListBox owner_ = null;
			protected ArrayList items_ = new ArrayList();
			//
			//  --- Constructor
			//
			[MonoTODO]
			public ObjectCollection(ListBox box) {
				owner_ = box;
			}
			[MonoTODO]
			public ObjectCollection(ListBox box, object[] objs) {
				owner_ = box;
				AddRange(objs);
			}

			//
			//  --- Public Properties
			//
			[MonoTODO]
			public int Count {
				get {
					return items_.Count;
				}
			}
			[MonoTODO]
			public bool IsReadOnly {
				get {
					// FIXME: Is it always not ReadOnly
					return false;
				}
			}
			[MonoTODO]
			public virtual object this[int index] {
				get {
					return items_[index];
				}
				set {
					throw new NotImplementedException ();
				}
			}

			//
			//  --- Public Methods
			//
			[MonoTODO]
			public int Add(object item) {
				// FIXME: not optimal 
				int idx = items_.Add(item);
				if( owner_.Sorted) {
					ListControl.ListControlComparer cic = new ListControl.ListControlComparer(owner_);
					items_.Sort(cic);
					idx = items_.BinarySearch(item,cic);
					if( owner_.IsHandleCreated) {
						Win32.SendMessage(owner_.Handle, (int)ListBoxMessages.LB_INSERTSTRING, idx, owner_.getDisplayMemberOfObj(item));
					}
				}
				else {
					if( owner_.IsHandleCreated) {
						Win32.SendMessage(owner_.Handle, (int)ListBoxMessages.LB_ADDSTRING, 0, owner_.getDisplayMemberOfObj(item));
					}
				}
				return idx;
			}
			
			[MonoTODO]
			public void AddRange(object[] items) {
				if( items != null) {
					// FIXME: not optimal 
					foreach(object item in items) {
						Add(item);
					}
				}
			}
			[MonoTODO]
			public void AddRange(ListBox.ObjectCollection collection) {
				//FIXME:
			}
			[MonoTODO]
			public void Clear() {
				//FIXME:
				items_.Clear();
				if( owner_.IsHandleCreated) {
					Win32.SendMessage(owner_.Handle, (int)ListBoxMessages.LB_RESETCONTENT, 0, 0);
				}
			}
			[MonoTODO]
			public bool Contains(object value) {
				return items_.Contains(value);
			}
			[MonoTODO]
			public void CopyTo(object[] dest, int arrayIndex) {
				items_.CopyTo(dest, arrayIndex);
			}
			[MonoTODO]
			public override bool Equals(object obj) {
				//FIXME:
				return base.Equals(obj);
			}
			[MonoTODO]
			public override int GetHashCode() {
				//FIXME add our proprities
				return base.GetHashCode();
			}
			[MonoTODO]
			public IEnumerator GetEnumerator() {
				return items_.GetEnumerator();
			}
			[MonoTODO]
			public int IndexOf(object val) {
				throw new NotImplementedException ();
			}
			[MonoTODO]
			public void Insert(int index, object item) {
				//FIXME:
			}
			[MonoTODO]
			public void Remove(object val) {
				int pos = items_.IndexOf(val);
				if( pos >= 0) {
					RemoveAt(pos);
				}
			}
			
			internal virtual void OnItemRemovedAt( int index) {
			}
			
			[MonoTODO]
			public void RemoveAt(int index) {
				if( index < 0 || index >= items_.Count) {
					//FIXME: set exception parameters
					throw new ArgumentOutOfRangeException();
				}
				items_.RemoveAt(index);
				if( owner_.IsHandleCreated) {
					Win32.SendMessage( owner_.Handle, (int)ListBoxMessages.LB_DELETESTRING, index, 0); 
				}
				OnItemRemovedAt(index);
			}
			/// <summary>
			/// IList Interface implmentation.
			/// </summary>
			bool IList.IsReadOnly{
				get{
					// We allow addition, removeal, and editing of items after creation of the list.
					return false;
				}
			}
			bool IList.IsFixedSize{
				get{
					// We allow addition and removeal of items after creation of the list.
					return false;
				}
			}

#if A
			//[MonoTODO]
			object IList.this[int index]{
				get{
					throw new NotImplementedException ();
				}
				set{
					throw new NotImplementedException ();
				}
			}
#endif
		
			[MonoTODO]
			void IList.Clear(){
				//FIXME:
			}
		
			[MonoTODO]
			int IList.Add( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			bool IList.Contains( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			int IList.IndexOf( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			void IList.Insert(int index, object value){
				//FIXME:
			}

			[MonoTODO]
			void IList.Remove( object value){
				//FIXME:
			}

			[MonoTODO]
			void IList.RemoveAt( int index){
				//FIXME:
			}
			// End of IList interface
			/// <summary>
			/// ICollection Interface implmentation.
			/// </summary>
			int ICollection.Count{
				get{
					throw new NotImplementedException ();
				}
			}
			bool ICollection.IsSynchronized{
				get{
					throw new NotImplementedException ();
				}
			}
			object ICollection.SyncRoot{
				get{
					throw new NotImplementedException ();
				}
			}
			void ICollection.CopyTo(Array array, int index){
				throw new NotImplementedException ();
			}
			// End Of ICollection
		}//end of SubClass

		// <summary>
		// </summary>

		public class SelectedIndexCollection :  IList, ICollection, IEnumerable {

			//
			//  --- Constructor
			//
			[MonoTODO]
			public SelectedIndexCollection(ListBox owner) {
			}

			//
			//  --- Public Properties
			//
			[MonoTODO]
			public int Count {
				get {
					throw new NotImplementedException ();
				}
			}
			[MonoTODO]
			public bool IsReadOnly {
				get {
					throw new NotImplementedException ();
				}
			}
			[MonoTODO]
			public int this[int index] {
				get {
					throw new NotImplementedException ();
				}
			}

			//
			//  --- Public Methods
			//
			[MonoTODO]
			public bool Contains(int selectedIndex) {
				throw new NotImplementedException ();
			}
			[MonoTODO]
			public void CopyTo(Array dest, int index) {
				//FIXME:
			}
			[MonoTODO]
			public override bool Equals(object obj) {
				//FIXME:
				return base.Equals(obj);
			}
			[MonoTODO]
			public override int GetHashCode() {
				//FIXME add our proprities
				return base.GetHashCode();
			}
			[MonoTODO]
			public IEnumerator GetEnumerator() {
				throw new NotImplementedException ();
			}
			/// <summary>
			/// IList Interface implmentation.
			/// </summary>
			bool IList.IsReadOnly{
				get{
					// We allow addition, removeal, and editing of items after creation of the list.
					return false;
				}
			}
			bool IList.IsFixedSize{
				get{
					// We allow addition and removeal of items after creation of the list.
					return false;
				}
			}

			//[MonoTODO]
			object IList.this[int index]{
				get{
					throw new NotImplementedException ();
				}
				set{
					//FIXME:
				}
			}
		
			[MonoTODO]
			void IList.Clear(){
				//FIXME:
			}
		
			[MonoTODO]
			int IList.Add( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			bool IList.Contains( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			int IList.IndexOf( object value){
				throw new NotImplementedException ();
			}

			[MonoTODO]
			void IList.Insert(int index, object value){
				//FIXME:
			}

			[MonoTODO]
			void IList.Remove( object value){
				//FIXME:
			}

			[MonoTODO]
			void IList.RemoveAt( int index){
				throw new NotImplementedException ();
			}
			// End of IList interface
			/// <summary>
			/// ICollection Interface implmentation.
			/// </summary>
			int ICollection.Count{
				get{
					throw new NotImplementedException ();
				}
			}
			bool ICollection.IsSynchronized{
				get{
					throw new NotImplementedException ();
				}
			}
			object ICollection.SyncRoot{
				get{
					throw new NotImplementedException ();
				}
			}
			void ICollection.CopyTo(Array array, int index){
				throw new NotImplementedException ();
			}
			// End Of ICollection

		}//End of subclass

		

	}
}
