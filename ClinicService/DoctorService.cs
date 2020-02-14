using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicCore;
using ClinicCore.Models;
using Newtonsoft.Json;

namespace ClinicService
{
    // Конкретная реализация логики врача
    // Вся логика находится в этом месте, все остальное относиться в работе с интерфейсом.
    // В данном файле реализовано: добавление/удаление/редактирование/поиск по фио/поиск по индентификатору/вывод все врачей
    // Хранится информация в файлах формата json
    // Для работы с файлами смотреть FileUtils
    public class DoctorService : IDoctorService
    {
        public void AddDoctor(Doctor newDoctor)
        {
            var fileDoctors = FileUtils.GetFileDoctors();
            var doctors = JsonConvert.DeserializeObject<List<Doctor>>(fileDoctors);

            if (doctors == null)
                doctors = new List<Doctor>();

            doctors.Add(newDoctor);

            var updateFilePatients = JsonConvert.SerializeObject(doctors);

            FileUtils.WriteDoctors(updateFilePatients);
        }

        public void UpdateDoctor(Doctor updateDoctor)
        {
            var fileDoctors = FileUtils.GetFileDoctors();
            var doctors = JsonConvert.DeserializeObject<List<Doctor>>(fileDoctors);

            var findDoctor = GetById(updateDoctor.Id);
            var index = CollectionUtils.FindDoctorIndex(updateDoctor.Id, doctors);

            findDoctor = updateDoctor;

            doctors.RemoveAt(index);
            doctors.Insert(index, findDoctor);

            var updateFilePatients = JsonConvert.SerializeObject(doctors);

            FileUtils.WriteDoctors(updateFilePatients);
        }

        public Doctor GetById(string id)
        {
            var fileDoctors = FileUtils.GetFileDoctors();

            var doctors = JsonConvert.DeserializeObject<List<Doctor>>(fileDoctors);
            return CollectionUtils.FindDoctor(id, doctors);
        }

        public Doctor GetByFullNameAndId(string path)
        {
            return CollectionUtils.FindDoctorByPath(path, GetAll());
        }

        public void Remove(string id)
        {
            var fileDoctors = FileUtils.GetFileDoctors();
            var doctors = JsonConvert.DeserializeObject<List<Doctor>>(fileDoctors);

            var index = CollectionUtils.FindDoctorIndex(id, doctors);
            doctors.RemoveAt(index);

            var updateFilePatients = JsonConvert.SerializeObject(doctors);

            FileUtils.WriteDoctors(updateFilePatients);
        }

        public List<Doctor> GetAll()
        {
            var fileDoctors = FileUtils.GetFileDoctors();
            var doctors = JsonConvert.DeserializeObject<List<Doctor>>(fileDoctors);

            return doctors;
        }
    }
}
