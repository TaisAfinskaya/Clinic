using System;
using System.Collections.Generic;
using System.Text;
using ClinicCore.Models;

namespace ClinicCore
{
    public interface IHealthRecordService
    {

        void AddRecord(HealthRecord newRecord);
        void UpdateRecord(HealthRecord updateRecord);
        HealthRecord GetById(string id);

        void Remove(string id);

        List<HealthRecord> GetAll();

    }
}
