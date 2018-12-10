﻿using System.Runtime.CompilerServices;
using HotelAdministation.ViewModels;
using HotelAdministation.Views;

namespace HotelAdministation.Core.AppContext
{
    public class AppGlobalContext
    {
        public static UsersViewModel CurrentUser { get; set; }

        public static IContext Current
        {
            get
            {
                if (Singleton<IContext>.Instance == null) Initialize(false);
                return Singleton<IContext>.Instance;
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IContext Initialize(bool forceRecreate)
        {
            if (Singleton<IContext>.Instance == null || forceRecreate)
            {
                Singleton<IContext>.Instance = new AppContext();
                Singleton<IContext>.Instance.Initialize();
            }

            return Singleton<IContext>.Instance;
        }
    }
}