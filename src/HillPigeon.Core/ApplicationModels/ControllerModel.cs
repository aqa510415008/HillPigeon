﻿using System;
using System.Collections.Generic;

namespace HillPigeon
{
    public class ControllerModel
    {
        public ControllerModel( Type controllerType)
        {
            this.ControllerName = controllerType.Name;
            this.ModuleName = controllerType.Module.Name.Replace(".dll","");
            this.ControllerType = controllerType;
            this.Attributes = new List<Attribute>();
            this.Actions = new List<ActionModel>();
        }

        public string ControllerName { get; set; }
        public string ModuleName { get; set; }
        public Type ControllerType { get; }
        public IList<Attribute> Attributes { get; }
        public IList<ActionModel> Actions { get; }
        public ApplicationModel Application { get; set; }
    }
}
