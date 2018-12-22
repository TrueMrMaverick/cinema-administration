using System;

namespace HotelAdministation.ViewModels.Base
{
    public class BaseViewModel : IViewModel
    {
        public virtual Int64 Id { get; set; }

        public override bool Equals(object obj)
        {
            var model = obj as BaseViewModel;
            return model != null &&
                   Id == model.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}