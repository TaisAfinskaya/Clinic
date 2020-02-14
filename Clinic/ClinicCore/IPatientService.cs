using System;
using System.Collections.Generic;
using System.Text;
using ClinicCore.Models;

namespace ClinicCore
{
    public interface IPatientService
    {
        void AddPatient(Patient newPatient);
        void UpdatePatient(Patient updatePatient);
        Patient GetById(string id);
        Patient GetByFullNameAndId(string path);

        void Remove(string id);
        List<Patient> GetAll();

    }
}
