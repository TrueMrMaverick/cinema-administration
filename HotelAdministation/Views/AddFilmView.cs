using System.Windows.Forms;
using System;
using HotelAdministation.Presenters;
using HotelAdministation.Views.Base;
using HotelAdministation.Presenters.Enum;

namespace HotelAdministation.Views
{
    public partial class AddFilmView : Form, IView<AddFilmViewPresenter>
    {
        public AddFilmView()
        {
            InitializeComponent();
        }

        public AddFilmViewPresenter Presenter { get; set; }

        public void Show(object mdiParent = null)
        {
            Visible = true;
        }

        public void ActivateView()
        {
            if (Disposing || IsDisposed) return;

            Show();

            BringToFront();
        }

        private void addBtn_Click(object sender, System.EventArgs e)
        {
            string name = filmName.Text;

            DateTime dt = durationTimePicker.Value;
            TimeSpan duration = new TimeSpan(dt.Hour, dt.Minute, dt.Second);

            string image = "placeholder";

            int price = Int32.Parse(rentalPrice.Text);

            Presenter.SaveFilm(name, duration, image, price);
            Presenter.Dispose();
        }

        private void directorsButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddListItemsView(FilmInfo.DIRECTOR);
        }

        private void operatorsButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddListItemsView(FilmInfo.OPERATOR);
        }

        private void actorsButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddListItemsView(FilmInfo.ACTOR);
        }

        private void genresButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddListItemsView(FilmInfo.GENRE);
        }

        private void productionButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddListItemsView(FilmInfo.PRODUCTION);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Presenter.Dispose();
        }

        private void prizesButton_Click(object sender, EventArgs e)
        {
            Presenter.InitializeAddListItemsView(FilmInfo.PRIZE);
        }
    }
}
