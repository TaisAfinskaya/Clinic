using System;
using System.Collections.Generic;
using System.Text;
using ClinicCore.Models;

namespace ClinicCore
{
    // Методы необходимые для реализации логики врача
    public interface IDoctorService
    {

        void AddDoctor(Doctor newDoctor);
        void UpdateDoctor(Doctor newDoctor);
        Doctor GetById(string id);

        Doctor GetByFullNameAndId(string path);

        void Remove(string id);
        List<Doctor> GetAll();


    }
}
