﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASDAGeorgeApp.Models
{
    public class Item : Model
    {
        public Item()
        {

        }

        public Item(string title)
        {
            Title = title;
        }

        public Item(string title, double price)
        {
            Title = title;
            Price = price;
        }

        private string _UniqueID;
        public string UniqueID
        {
            get { return _UniqueID; }
            set
            {
                if (_UniqueID != value)
                {
                    _UniqueID = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set
            {
                if (_Title != value)
                {
                    _Title = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _IsThin = false;
        public bool IsThin
        {
            get { return _IsThin; }
            set
            {
                if (_IsThin != value)
                {
                    _IsThin = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _Description;
        public string Description
        {
            get { return _Description; }
            set
            {
                if (_Description != value)
                {
                    _Description = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double _Price;
        public double Price
        {
            get { return _Price; }
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double _WasPrice;
        public double WasPrice
        {
            get { return _WasPrice; }
            set
            {
                if (_WasPrice != value)
                {
                    _WasPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _ParentSub;
        public string ParentSub
        {
            get { return _ParentSub; }
            set
            {
                if (_ParentSub != value)
                {
                    _ParentSub = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _ParentCat;
        public string ParentCat
        {
            get { return _ParentCat; }
            set
            {
                if (_ParentCat != value)
                {
                    _ParentCat = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _DeliveryMethods;
        public string DeliveryMethods
        {
            get { return _DeliveryMethods; }
            set
            {
                if (_DeliveryMethods != value)
                {
                    _DeliveryMethods = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _ProductImage;
        public string ProductImage
        {
            get { return _ProductImage; }
            set
            {
                if (_ProductImage != value)
                {
                    _ProductImage = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _SizeVariants;
        public string SizeVariants
        {
            get { return _SizeVariants; }
            set
            {
                if (_SizeVariants != value)
                {
                    _SizeVariants = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private double _StarRating;
        public double StarRating
        {
            get { return _StarRating; }
            set
            {
                if (_StarRating != value)
                {
                    _StarRating = value;
                    NotifyPropertyChanged();
                }
            }
        }
    }
}
