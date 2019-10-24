using Android.App;
using Android.Widget;
using Android.OS;
using Java.Lang;
using System;

Spinner spinnerDays = FindViewById<Spinner>(Resource.Id.spinner1);
            spinnerDays.ItemSelected += new EventHandler
               <AdapterView.ItemSelectedEventArgs>(SelectedDay);
            var adapter = ArrayAdapter.CreateFromResource(this,
               Resource.Array.days_array, Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerDays.Adapter = adapter;
            
            
            
            private void SelectedDay(object sender, AdapterView.ItemSelectedEventArgs e)
    {
        Spinner spinner = (Spinner)sender;
        //string toast = string.Format("The selected day is { 0}", spinner.GetItemAtPosition(e.Position)); 
   //Toast.MakeText(this, toast, ToastLength.Long).Show();
    }
