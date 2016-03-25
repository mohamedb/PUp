﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PUp.Models
{
    public class ValidationMessageHolder
    {
        public Dictionary<string,string> Messages { get; }
        
        public string Message { get; set; }

        public ValidationMessageHolder(int state=1, string message="Model is valid")
        {
            Messages = new Dictionary<string, string>();
            State = state;
            Message = message;
        }

        public ValidationMessageHolder Add(string key,string msg)
        {
            Messages.Add(key, msg);
            if (Message.Count() > 0) State = 0;
            Message = "Model is not valid";
            return this;
        }
        public ValidationMessageHolder Clear()
        {
            Messages.Clear();
            State = 1;
            Message = "Model is valid";
            return this;
        }

        public bool IsValid()
        {
            if (Message.Count() > 0) State = 0;
            return Message.Count() > 0;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            });
        }

        //Additional
        public int State { get; set; }
    }

     
}