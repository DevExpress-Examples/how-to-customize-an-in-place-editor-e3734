using System.Windows;
using DevExpress.Xpf.Scheduler;
using DevExpress.Xpf.Scheduler.UI;
using DevExpress.XtraScheduler;

namespace SilverlightApplication1 {
    #region #AppointmentInplaceEditorBase
    public partial class CustomInplaceEditor : AppointmentInplaceEditorBase {
        public CustomInplaceEditor(SchedulerControl control, Appointment apt)
            : base(control, apt) {
            InitializeComponent();
        }

        private void OK_button_Click(object sender, RoutedEventArgs e) {
            OnCommitChanges();
        }

        private void Cancel_button_Click(object sender, RoutedEventArgs e) {
            OnRollbackChanges();
        }

    }
    #endregion #AppointmentInplaceEditorBase
}
