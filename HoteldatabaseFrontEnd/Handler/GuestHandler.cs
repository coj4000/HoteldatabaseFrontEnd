﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoteldatabaseFrontEnd.Viewmodel;

namespace HoteldatabaseFrontEnd.Handler
{
   public class GuestHandler
    {
        public GuestViewModel GuestViewModel { get; set; }

        public GuestHandler(GuestViewModel guestViewModel)
        {
            GuestViewModel = guestViewModel;
        }

        public void CreateGuest()
        {
            Model.Guest tempguest = new Model.Guest();
            tempguest.Address = GuestViewModel.Address;
            tempguest.Guest_No = GuestViewModel.Guest_No;
            tempguest.Name = GuestViewModel.Name;

            Model.GuestCatalogSingleton.Instance.AddGuest(tempguest);
            HoteldatabaseFrontEnd.Persistency.PersistencyService.SaveGuestAsJsonAsync(tempguest);
        }

        public void DeleteGuest()
        {
           GuestViewModel.GuestCatalogSingleton.RemoveGuest(GuestViewModel.SelectedGuest);
           // HoteldatabaseFrontEnd.Persistency.PersistencyService.SaveGuestAsJsonAsync();
        }

        public void UpdateGuestRigtig()
        {
            GuestViewModel.GuestCatalogSingleton.UpdateGuest(GuestViewModel.SelectedGuest);
        }



    }
}
