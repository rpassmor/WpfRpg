﻿using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.Actions
{
    public interface IAction
    {
        event EventHandler<string> OnActionPerformed;
        void Execute(LivingEntity actor, LivingEntity target);
    }
}
