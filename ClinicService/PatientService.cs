using System.Collections.Generic;
using System.Linq;
using ClinicCore;
using ClinicCore.Models;
using Newtonsoft.Json;

namespace ClinicService
{
    public class PatientService : IPatientService
    {
        public void AddPatient(Patient newPatient)
        {
            var filePatients = FileUtils.GetFilePatients();
            var patients = JsonConvert.DeserializeObject<List<Patient>>(filePatients);

            if (patients == null)
                patients = new List<Patient>();

            patients.Add(newPatient);

            var updateFilePatients = JsonConvert.SerializeObject(patients);

            FileUtils.WritePatients(updateFilePatients);
        }

        public void UpdatePatient(Patient updatePatient)
        {
            var filePatients = FileUtils.GetFilePatients();
            var patients = JsonConvert.DeserializeObject<List<Patient>>(filePatients);

            var findPatient = GetById(updatePatient.Id);
            var index = CollectionUtils.FindPatientIndex(updatePatient.Id, patients);

            findPatient = updatePatient;

            patients.RemoveAt(index);
            patients.Insert(index, findPatient);

            var updateFilePatients = JsonConvert.SerializeObject(patients);

            FileUtils.WritePatients(updateFilePatients);
        }

        public Patient GetById(string id)
        {
            var filePatients = FileUtils.GetFilePatients();

            var patients = JsonConvert.DeserializeObject<List<Patient>>(filePatients);
            return CollectionUtils.FindPatient(id, patients);
        }

        public Patient GetByFullNameAndId(string path)
        {
            return CollectionUtils.FindPatientByPath(path, GetAll());
        }

        public void Remove(string id)
        {
            var filePatients = FileUtils.GetFilePatients();
            var patients = JsonConvert.DeserializeObject<List<Patient>>(filePatients);

            var index = CollectionUtils.FindPatientIndex(id, patients);

            patients.RemoveAt(index);

            var updateFilePatients = JsonConvert.SerializeObject(patients);

            FileUtils.WritePatients(updateFilePatients);
        }

        public List<Patient> GetAll()
        {
            var filePatients = FileUtils.GetFilePatients();
            var patients = JsonConvert.DeserializeObject<List<Patient>>(filePatients);

            return patients;
        }

    }
}
