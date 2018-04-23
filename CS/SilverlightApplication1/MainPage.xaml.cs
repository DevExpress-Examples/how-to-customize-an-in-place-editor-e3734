using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Scheduler;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        #region #InplaceEditorShowing
        private void schedulerControl1_InplaceEditorShowing(object sender, InplaceEditorEventArgs e) {
            CustomInplaceEditor editor = new CustomInplaceEditor(this.schedulerControl1, e.Appointment);
            e.InplaceEditor = editor;
            editor.DataContext = editor;
            Point location = new Point(e.Bounds.Right, e.Bounds.Top);
            e.Bounds = new Rect(location, new Size(editor.Width, editor.Height));
        }
        #endregion #InplaceEditorShowing
    }
}
