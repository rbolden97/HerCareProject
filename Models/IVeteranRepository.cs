using System;
using System.Collections.Generic;

namespace  her_care.Models
{
    public interface IVeteranRepository : IDisposable
    {
        IEnumerable<Vetran> GetVeterans();
        Vetran GetVeteranByID(int vetranId);
        void InsertVeteran(Vetran vetran);
        void DeleteVeteran(int vetranID);
        void UpdateVeteran(Vetran vetran);
        void Save();
    }
}