using System;
using System.Collections.Generic;
using System.Text;
using ClinicCore.Models;

namespace ClinicService
{
    public static class CollectionUtils
    {
        public static Patient FindPatient(string id, List<Patient> patients)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Id == id)
                    return patients[i];
            }

            return new Patient();
        }

        public static Patient FindPatientByPath(string path, List<Patient> patients)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Id == patients[i].GetFullName)
                    return patients[i];
            }

            return new Patient();
        }

        public static int FindPatientIndex(string id, List<Patient> patients)
        {
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients[i].Id == id)
                    return i;
            }

            return 0;
        }


        public static Doctor FindDoctor(string id, List<Doctor> doctors)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == id)
                    return doctors[i];
            }

            return new Doctor();
        }

        public static Doctor FindDoctorByPath(string path, List<Doctor> doctors)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == doctors[i].GetFullName)
                    return doctors[i];
            }

            return new Doctor();
        }

        public static int FindDoctorIndex(string id, List<Doctor> doctors)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == id)
                    return i;
            }

            return 0;
        }

        public static HealthRecord FindHealthRecord(string id, List<HealthRecord> healthRecords)
        {
            for (int i = 0; i < healthRecords.Count; i++)
            {
                if (healthRecords[i].Id == id)
                    return healthRecords[i];
            }

            return new HealthRecord();
        }

        public static int FindHealthRecordIndex(string id, List<HealthRecord> records)
        {
            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].Id == id)
                    return i;
            }

            return 0;
        }
    }
}
