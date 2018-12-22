using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelAdministation.Core.AppContext;
using HotelAdministation.Presenters.Enum;
using HotelAdministation.Services;
using HotelAdministation.ViewModels;
using HotelAdministation.Views;

namespace HotelAdministation.Presenters
{
    public class FilmListViewPresenter: AbstractPresenter<FilmListView, FilmListViewPresenter>
    {
        
        public Form ParentView { get; set; }

        FilmService filmService = AppGlobalContext.Current.Resolve<FilmService>();

        
        public override void InitializePresenter()
        {
            if (ParentView != null)
            {
                CreateView();
                SetupView();
                ShowView();
            }
        }

        public override void ShowView()
        {
            UpdateData();
            View.ActivateView();
        }
        
        private void SetupView()
        {
            View.Dock = DockStyle.Fill;
            View.Size = new System.Drawing.Size(0, 0);
        }
        
        private void UpdateData()
        {
            View.FilmDataGridView.DataSource = filmService.GetList();
        }

        public void InitializeAddFilmView()
        {
            var addFilmViewPresenter = AppGlobalContext.Current.Resolve<AddFilmViewPresenter>();
            addFilmViewPresenter.InitializePresenter();
        }

        public void InitializeAddFilmView(long sourceId)
        {
            var addFilmViewPresenter = AppGlobalContext.Current.Resolve<AddFilmViewPresenter>();
            var sourceInfo = new Dictionary<FilmInfo, List<object>>();
            var filmService = AppGlobalContext.Current.Resolve<FilmService>();

            var filmModel = filmService.GetById(sourceId);

            sourceInfo.Add(FilmInfo.ACTOR, filmService.GetActorsById(sourceId).Cast<object>().ToList());
            sourceInfo.Add(FilmInfo.DIRECTOR, filmService.GetDirectorsById(sourceId).Cast<object>().ToList());
            sourceInfo.Add(FilmInfo.OPERATOR, filmService.GetOperatorsById(sourceId).Cast<object>().ToList());
            sourceInfo.Add(FilmInfo.GENRE, filmService.GetGenresById(sourceId).Cast<object>().ToList());
            sourceInfo.Add(FilmInfo.PRODUCTION, filmService.GetProductionsById(sourceId).Cast<object>().ToList());
            sourceInfo.Add(FilmInfo.PRIZE, filmService.GetPrizesById(sourceId).Cast<object>().ToList());

            addFilmViewPresenter.InitializePresenter(filmModel, sourceInfo);
            addFilmViewPresenter.Added += UpdateData;
        }
    }
}