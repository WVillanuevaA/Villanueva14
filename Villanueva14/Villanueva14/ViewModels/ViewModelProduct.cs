﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Villanueva14.Models;
using Villanueva14.Services;
using Xamarin.Forms;

namespace Villanueva14.ViewModels
{
    public class ViewModelProduct : BaseViewModel
    {
        private string color;
        public string Color
        {
            get { return this.color; }
            set { SetValue(ref this.color, value); }
        }


        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> product;
        public List<Compra> Product
        {
            get { return this.product; }
            set { SetValue(ref this.product, value); }
        }


        public ICommand SearchCommand { get; set; }

        public ViewModelProduct()
        {

            SearchCommand = new Command (()=>
            {   
                CompraService service = new CompraService();
                Product = service.GetByText(Filter);
                if (Product.Count > 3)
                    Color = "Red";
                else
                    Color = "Blue";

            });


        }


    }
}
