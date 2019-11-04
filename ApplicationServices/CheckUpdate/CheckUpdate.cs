using Domain.Contract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Utility;

namespace ApplicationServices
{
    public class CheckUpdate : ICheckUpdate
    {
        private readonly IUnitOfWork unit;

        public CheckUpdate(IUnitOfWork unit)
        {
            this.unit = unit;
        }

        public string Execute(string Version)
        {
            List<Update> updates = unit.Update.GetUpdate(Version);
            string result = Messages.NoUpdateRaw;

            if (updates.Count > 0)
                result = Api.ToJson(updates[updates.Count - 1]);

            return result;
        }
    }
}
