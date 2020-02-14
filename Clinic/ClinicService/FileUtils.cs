using System.IO;

namespace ClinicService
{
    // Предназначен для работы с файлами и сохранением пацентов, врачей и записей
    public static class FileUtils
    {

        private static string GetRootPath()
        {
            string path = Path.Combine(Directory.GetParent
                (Directory.GetCurrentDirectory()).Parent.Parent.FullName);

            return path;
        }

        #region Patient
        public static void WritePatients(string updateFilePatients)
        {
            string nameFile = "patients.json";
            string path = Path.Combine(GetRootPath(), nameFile);
            File.WriteAllText(path, updateFilePatients);
        }

        public static string GetFilePatients()
        {
            string nameFile = "patients.json";
            string path = Path.Combine(GetRootPath(), nameFile);

            var result = File.Exists(path);

            if (!result)
                File.Create(path);

            using (StreamReader r = new StreamReader(File.OpenRead(path)))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }


        #endregion

        #region Doctor

        public static void WriteDoctors(string updateFilePatients)
        {
            string nameFile = "doctors.json";
            string path = Path.Combine(GetRootPath(), nameFile);
            File.WriteAllText(path, updateFilePatients);
        }

        public static string GetFileDoctors()
        {
            string nameFile = "doctors.json";
            string path = Path.Combine(GetRootPath(), nameFile);

            var result = File.Exists(path);

            if (!result)
                File.Create(path);

            using (StreamReader r = new StreamReader(File.OpenRead(path)))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }


        #endregion

        #region HealthRecord

        public static void WriteHealthRecord(string updateFilePatients)
        {
            string nameFile = "healthRecord.json";
            string path = Path.Combine(GetRootPath(), nameFile);
            File.WriteAllText(path, updateFilePatients);
        }

        public static string GetHealthRecord()
        {
            string nameFile = "healthRecord.json";
            string path = Path.Combine(GetRootPath(), nameFile);

            var result = File.Exists(path);

            if (!result)
                File.Create(path);

            using (StreamReader r = new StreamReader(File.OpenRead(path)))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }

        #endregion
    }
}