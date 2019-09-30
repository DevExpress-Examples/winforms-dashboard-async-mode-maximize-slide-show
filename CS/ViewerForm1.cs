using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace MaximizeSlideShow
{
    public partial class ViewerForm1 : XtraForm {
        bool isSlideShown = false;
        int index = 0;
        Timer slideShowTimer = new Timer() {
            Interval = 5000
        };

        public ViewerForm1() {
            InitializeComponent();
            slideShowTimer.Tick += OnSlideShowTimerTick;
        }

        async void OnSlideShowTimerTick(object sender, EventArgs e) {
            var items = dashboardViewer1.Dashboard.Items;
            int maxIndex = items.Count - 1;

            if(!isSlideShown) {
                slideShowTimer.Stop();
                return;
            }
            await dashboardViewer1.MaximizeDashboardItemAsync(items[index].ComponentName);
            if(index == maxIndex)
                index = 0;
            else
                index++;
        }

        void OnStartClick(object sender, MouseEventArgs e) {
            if(!isSlideShown) {
                isSlideShown = true;
                slideShowTimer.Start();
            }
        }
        async void OnStopClick(object sender, EventArgs e) {
            isSlideShown = false;
            await dashboardViewer1.RestoreDashboardItemAsync();
        }
    }
}