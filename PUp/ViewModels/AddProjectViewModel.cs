﻿using PUp.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PUp.ViewModels
{
    public class AddProjectViewModel
    {
        
        public string Name { get; set; }
        /*
         * A project may finish before estimated finish date time!
         */
        public DateTime StartAt { get; set; }
        public Nullable<DateTime> EndAt { get; set; }
        public int Id { get; set; }
        public AddProjectViewModel()
        {
            
        }
    }
}