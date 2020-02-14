using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicCore;
using ClinicCore.Models;
using Newtonsoft.Json;

namespace ClinicService
{
    public class HealthRecordService : IHealthRecordService
    {
        public void AddRecord(HealthRecord newRecord)
        {
            var fileRecord = FileUtils.GetHealthRecord();
            var records = JsonConvert.DeserializeObject<List<HealthRecord>>(fileRecord);

            if (records == null)
                records = new List<HealthRecord>();

            records.Add(newRecord);

            var fileRecords = JsonConvert.SerializeObject(records);

            FileUtils.WriteHealthRecord(fileRecords);
        }

        public void UpdateRecord(HealthRecord updateRecord)
        {
            var fileRecord = FileUtils.GetHealthRecord();
            var records = JsonConvert.DeserializeObject<List<HealthRecord>>(fileRecord);

            var findRecord = GetById(updateRecord.Id);
            var index = CollectionUtils.FindHealthRecordIndex(updateRecord.Id, records);

            findRecord = updateRecord;

            records.RemoveAt(index);
            records.Insert(index, findRecord);

            var updateRecordFile = JsonConvert.SerializeObject(records);

            FileUtils.WriteHealthRecord(updateRecordFile);
        }

        public HealthRecord GetById(string id)
        {
            var recordFile = FileUtils.GetHealthRecord();

            var records = JsonConvert.DeserializeObject<List<HealthRecord>>(recordFile);
            return CollectionUtils.FindHealthRecord(id, records);
        }

        public void Remove(string id)
        {
            var fileRecord = FileUtils.GetHealthRecord();
            var records = JsonConvert.DeserializeObject<List<HealthRecord>>(fileRecord);

            var index = CollectionUtils.FindHealthRecordIndex(id, records);

            records.RemoveAt(index);

            var updateRecordFile = JsonConvert.SerializeObject(records);

            FileUtils.WriteHealthRecord(updateRecordFile);
        }

        public List<HealthRecord> GetAll()
        {
            var recordFile = FileUtils.GetHealthRecord();
            var records = JsonConvert.DeserializeObject<List<HealthRecord>>(recordFile);

            return records;
        }
    }
}
