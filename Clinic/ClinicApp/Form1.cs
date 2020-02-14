using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClinicCore.Models;
using ClinicService;
using DataGridView = System.Windows.Forms.DataGridView;

namespace ClinicApp
{
    // Данный файл содержет логику работы с интерфейсом, обработку нажатий клавишь и выбора данных
    public partial class Form1 : Form
    {
        private Patient selectedPatient;
        private Doctor selectedDoctor;
        private HealthRecord selectedHealthRecord;

        private Doctor healthDoctorRecord;
        private Patient healthPatientRecord;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Класс разбит на регионы (Пацента, Врача, Записи), так как количество полей интерфейса велико и записи выходят громоздкими
        // Логика всех регионов идентична, есть методы на добавление, обновление, удаление, отмену обновления, обработка выбранного элемента таблицы
        // Для региона с записями добавлены так же списки для выбора пациента и врача

        #region Patient

        // Добавляет пациента
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            PatientService service = new PatientService();

            if (!string.IsNullOrEmpty(txtNumber.Text) &&
                !string.IsNullOrEmpty(txtName.Text) &&
                !string.IsNullOrEmpty(txtLastName.Text) &&
                !string.IsNullOrEmpty(txtPatronomic.Text))
            {
                Patient patient = new Patient()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Patronimic = txtPatronomic.Text,
                    Number = txtNumber.Text,
                    DateBth = dateBth.Value,
                    Id = Guid.NewGuid().ToString()
                };
                service.AddPatient(patient);


                var patients = service.GetAll();
                dgPatients.Rows.Clear();
                foreach (var p in patients)
                {
                    dgPatients.Rows.Add(p.Number, p.FirstName, p.LastName, p.Patronimic, p.DateBth, p.Id);
                }
            }
            else
            {
                lbError.Text = "Filed can't be empty";
            }

        }

        // Записываем выбранный рядок в таблице пациентов
        private void dgPatients_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = (sender as DataGridView)?.SelectedRows;
            selectedPatient = new Patient();

            if (selectedRows != null && selectedRows.Count > 0)
            {
                var selected = selectedRows[0];

                selectedPatient.FirstName = selected.Cells["ColumnFirstName"].Value.ToString();
                selectedPatient.LastName = selected.Cells["ColumnLastName"].Value.ToString();
                selectedPatient.Patronimic = selected.Cells["ColumnPatronimic"].Value.ToString();
                selectedPatient.DateBth = Convert.ToDateTime(selected.Cells["ColumnBth"].Value);
                selectedPatient.Id = selected.Cells["Id"].Value.ToString();
                selectedPatient.Number = selected.Cells["ColumnNumber"].Value.ToString();
            }

        }

        // Показываем всех пациентов на экране по клику
        private void btnGetAllPatients_Click(object sender, EventArgs e)
        {
            PatientService service = new PatientService();

            var patients = service.GetAll();

            if (patients?.Count > 0)
            {
                GetAllPatients(patients);
                selectedPatient = patients[0];
            }


        }

        // Функция отрисовки в таблице
        private void GetAllPatients(List<Patient> patients)
        {

            dgPatients.Rows.Clear();

            foreach (var p in patients)
            {
                dgPatients.Rows.Add(p.Number, p.FirstName, p.LastName, p.Patronimic, p.DateBth, p.Id);
            }
        }


        // Обновляем выбранного пациента
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PatientService service = new PatientService();
            if (btnUpdate.Text == "Confirm")
            {
                Patient patient = new Patient()
                {
                    FirstName = txtName.Text,
                    LastName = txtLastName.Text,
                    Patronimic = txtPatronomic.Text,
                    Number = txtNumber.Text,
                    DateBth = dateBth.Value,
                    Id = Guid.NewGuid().ToString()
                };
                patient.Id = selectedPatient.Id;
                service.UpdatePatient(patient);
                selectedPatient = null;
                btnUpdate.Text = "Update";
                btnCancel.Visible = false;
                ClearValues();


                var patients = service.GetAll();
                if (patients?.Count > 0)
                {
                    GetAllPatients(patients);
                }
            }
            else
            {
                if (selectedPatient != null)
                {
                    btnUpdate.Text = "Confirm";
                    txtNumber.Text = selectedPatient.Number;
                    txtName.Text = selectedPatient.FirstName;
                    txtLastName.Text = selectedPatient.LastName;
                    txtPatronomic.Text = selectedPatient.Patronimic;
                    dateBth.Value = selectedPatient.DateBth;
                    btnCancel.Visible = true;
                }
            }


        }


        // очистка экрана
        private void ClearValues()
        {
            txtNumber.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtPatronomic.Text = "";
            dateBth.Value = DateTime.Today;
        }

        // Отмена обновления
        private void btnCancel_Click(object sender, EventArgs e)
        {
            PatientService service = new PatientService();
            if (btnUpdate.Text == "Confirm")
            {
                selectedPatient = null;
                ClearValues();
                btnUpdate.Text = "Update";
                var patients = service.GetAll();
                if (patients?.Count > 0)
                {
                    GetAllPatients(patients);
                }
            }
        }


        // Удаление выбранного пациента
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                PatientService service = new PatientService();

                service.Remove(selectedPatient.Id);

                var patients = service.GetAll();
                if (patients?.Count > 0)
                {
                    GetAllPatients(patients);
                }
            }
        }


        #endregion

        #region Doctors

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            DoctorService service = new DoctorService();

            if (!string.IsNullOrEmpty(txtDoctorFirstName.Text) &&
                !string.IsNullOrEmpty(txtDoctorLastName.Text) &&
                !string.IsNullOrEmpty(txtDoctorPatronimic.Text) &&
                !string.IsNullOrEmpty(txtDoctorPosition.Text) &&
                !string.IsNullOrEmpty(txtSpec.Text))
            {


                Doctor doctor = new Doctor()
                {
                    FirstName = txtDoctorFirstName.Text,
                    LastName = txtDoctorLastName.Text,
                    Patronimic = txtDoctorPatronimic.Text,
                    Position = txtDoctorPosition.Text,
                    Specialization = txtSpec.Text,
                    Id = Guid.NewGuid().ToString()
                };
                service.AddDoctor(doctor);


                var doctors = service.GetAll();
                dgDoctor.Rows.Clear();
                if (doctors != null)
                {
                    foreach (var p in doctors)
                    {
                        dgDoctor.Rows.Add(p.Position, p.FirstName, p.LastName, p.Patronimic, p.Specialization, p.Id);
                    }
                }

            }
            else
            {
                lbError.Text = "Filed can't be empty";
            }

        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            DoctorService service = new DoctorService();
            if (btnUpdateDoctor.Text == "Confirm")
            {
                Doctor doctor = new Doctor()
                {
                    FirstName = txtDoctorFirstName.Text,
                    LastName = txtDoctorLastName.Text,
                    Patronimic = txtDoctorPatronimic.Text,
                    Position = txtDoctorPosition.Text,
                    Specialization = txtSpec.Text,
                    Id = Guid.NewGuid().ToString()
                };
                doctor.Id = selectedDoctor.Id;
                service.UpdateDoctor(doctor);
                selectedDoctor = null;
                btnUpdateDoctor.Text = "Update";
                btnCancelUpdateDoctor.Visible = false;
                ClearDoctorValues();

                var doctors = service.GetAll();
                dgDoctor.Rows.Clear();
                if (doctors != null)
                {
                    foreach (var p in doctors)
                    {
                        dgDoctor.Rows.Add(p.Position, p.FirstName, p.LastName, p.Patronimic, p.Specialization, p.Id);
                    }
                }
            }
            else
            {
                if (selectedDoctor != null)
                {
                    btnUpdateDoctor.Text = "Confirm";
                    txtSpec.Text = selectedDoctor.Specialization;
                    txtDoctorFirstName.Text = selectedDoctor.FirstName;
                    txtDoctorLastName.Text = selectedDoctor.LastName;
                    txtDoctorPatronimic.Text = selectedDoctor.Patronimic;
                    txtDoctorPosition.Text = selectedDoctor.Position;
                    btnCancelUpdateDoctor.Visible = true;
                }
            }

        }

        private void ClearDoctorValues()
        {
            txtSpec.Text = "";
            txtDoctorFirstName.Text = "";
            txtDoctorLastName.Text = "";
            txtDoctorPatronimic.Text = "";
            txtDoctorPosition.Text = "";
        }

        private void btnRemoveDoctor_Click(object sender, EventArgs e)
        {
            if (selectedDoctor != null)
            {
                DoctorService service = new DoctorService();

                service.Remove(selectedDoctor.Id);

                var doctors = service.GetAll();
                dgDoctor.Rows.Clear();
                if (doctors?.Count > 0)
                {
                    foreach (var p in doctors)
                    {
                        dgDoctor.Rows.Add(p.Position, p.FirstName, p.LastName, p.Patronimic, p.Specialization, p.Id);
                    }
                }
            }
        }

        private void btnGetAllDoctors_Click(object sender, EventArgs e)
        {
            DoctorService service = new DoctorService();
            var doctors = service.GetAll();
            dgDoctor.Rows.Clear();
            if (doctors != null)
            {
                foreach (var p in doctors)
                {
                    dgDoctor.Rows.Add(p.Position, p.FirstName, p.LastName, p.Patronimic, p.Specialization, p.Id);
                }
            }
        }

        private void btnCancelUpdateDoctor_Click(object sender, EventArgs e)
        {
            DoctorService service = new DoctorService();
            if (btnUpdateDoctor.Text == "Confirm")
            {
                selectedDoctor = null;
                ClearDoctorValues();
                btnUpdateDoctor.Text = "Update";
                var doctors = service.GetAll();
                dgDoctor.Rows.Clear();
                if (doctors?.Count > 0)
                {
                    foreach (var p in doctors)
                    {
                        dgDoctor.Rows.Add(p.Position, p.FirstName, p.LastName, p.Patronimic, p.Specialization, p.Id);
                    }
                }
            }
        }

        private void dgDoctor_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = (sender as DataGridView)?.SelectedRows;
            selectedDoctor = new Doctor();

            if (selectedRows != null && selectedRows.Count > 0)
            {
                var selected = selectedRows[0];

                selectedDoctor.FirstName = selected.Cells["CDFirstName"].Value.ToString();
                selectedDoctor.LastName = selected.Cells["CDLastName"].Value.ToString();
                selectedDoctor.Patronimic = selected.Cells["CDPatronimic"].Value.ToString();
                selectedDoctor.Specialization = selected.Cells["CDSpec"].Value.ToString();
                selectedDoctor.Id = selected.Cells["CDId"].Value.ToString();
                selectedDoctor.Position = selected.Cells["CDPosition"].Value.ToString();
            }
        }



        #endregion

        #region HealthRecord

        private void tabPatients_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            PatientService service = new PatientService();
            var patients = service.GetAll();


            DoctorService doctorService = new DoctorService();
            var doctors = doctorService.GetAll();

            var patientsName = patients.Select(p => p.GetFullName).ToList();
            var doctorsName = doctors.Select(d => d.GetFullName).ToList();

            foreach (var p in patientsName)
            {
                listBox1.Items.Add(p);
            }

            foreach (var d in doctorsName)
            {
                listBox2.Items.Add(d);
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            string fullName = (sender as ListBox)?.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fullName))
                healthPatientRecord = new PatientService().GetByFullNameAndId(fullName);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fullName = (sender as ListBox)?.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(fullName))
                healthDoctorRecord = new DoctorService().GetByFullNameAndId(fullName);
        }

        private void chCanWork_CheckedChanged(object sender, EventArgs e)
        {
            var result = ((CheckBox) sender).CheckState == CheckState.Checked;

            if (result)
            {
                label6.Visible = false;
                txtWithoutWork.Visible = false;
            }
            else
            {

                label6.Visible = true;
                txtWithoutWork.Visible = true;
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            HealthRecordService service = new HealthRecordService();

            if (!string.IsNullOrEmpty(txtDiagnose.Text) &&
                healthDoctorRecord != null && healthPatientRecord != null)
            {
                HealthRecord record = new HealthRecord()
                {
                    Patient = healthPatientRecord,
                    Doctor = healthDoctorRecord,
                    Diagnosis = txtDiagnose.Text,
                    IsAmbulance = chAmbulance.CheckState == CheckState.Checked,
                    IsDispencary = chDispancer.CheckState == CheckState.Checked,
                    Notes = txtNotes.Text,
                    Id = Guid.NewGuid().ToString()
                };

                if (chCanWork.CheckState == CheckState.Checked)
                {

                    record.IsCanContinueWork = true;
                    if (!string.IsNullOrEmpty(txtDiagnose.Text))
                        record.CountDayWithoutWork = 0;
                   

                }
                else
                {
                    record.IsCanContinueWork = false;
                    record.CountDayWithoutWork = Convert.ToInt32(txtWithoutWork.Text);
                }


                service.AddRecord(record);


                var records = service.GetAll();
                dataGridView1.Rows.Clear();

                if (records != null)
                {
                    foreach (var p in records)
                    {
                        dataGridView1.Rows.Add(p.Patient.GetFullName, p.Doctor.GetFullName, p.Diagnosis, p.IsAmbulance,
                            p.IsCanContinueWork, p.CountDayWithoutWork,
                            p.IsDispencary, p.Notes, p.Id);
                    }
                }

            }
            else
            {
                lbError.Text = "Filed can't be empty";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var selectedRows = (sender as DataGridView)?.SelectedRows;
            selectedHealthRecord = new HealthRecord();

            var patientService = new PatientService();
            var doctorService = new DoctorService();

            if (selectedRows != null && selectedRows.Count > 0)
            {
                var selected = selectedRows[0];

                selectedHealthRecord.Id = selected.Cells["RecordId"].Value.ToString();
                selectedHealthRecord.CountDayWithoutWork = Convert.ToInt32(selected.Cells["CWithoutWork"].Value);
                selectedHealthRecord.Notes = selected.Cells["CNotes"].Value.ToString();
                selectedHealthRecord.IsAmbulance = Convert.ToBoolean(selected.Cells["CAmbulance"].Value);
                selectedHealthRecord.IsCanContinueWork = Convert.ToBoolean(selected.Cells["CCanWork"].Value);
                selectedHealthRecord.Diagnosis = selected.Cells["CDiagnose"].Value.ToString();
                selectedHealthRecord.IsDispencary = Convert.ToBoolean(selected.Cells["CDispancer"].Value);
                selectedHealthRecord.Patient =
                    patientService.GetByFullNameAndId(selected.Cells["CPFullName"].Value.ToString());

                selectedHealthRecord.Doctor =
                    doctorService.GetByFullNameAndId(selected.Cells["CDFullName"].Value.ToString());
            }

        }

        private void btnGetAllRecord_Click(object sender, EventArgs e)
        {

            var records = new HealthRecordService().GetAll();
            dataGridView1.Rows.Clear();

            if (records?.Count > 0)
            {
                foreach (var p in records)
                {
                    dataGridView1.Rows.Add(p.Patient.GetFullName, p.Doctor.GetFullName, p.Diagnosis, p.IsAmbulance,
                        p.IsCanContinueWork, p.CountDayWithoutWork,
                        p.IsDispencary, p.Notes, p.Id);
                }
            }
        }

        private void btnRemoveRecord_Click(object sender, EventArgs e)
        {
            if (selectedHealthRecord != null)
            {
                HealthRecordService service = new HealthRecordService();

                service.Remove(selectedHealthRecord.Id);

                var records = service.GetAll();
                dataGridView1.Rows.Clear();
                if (records?.Count > 0)
                {
                    foreach (var p in records)
                    {
                        dataGridView1.Rows.Add(p.Patient.GetFullName, p.Doctor.GetFullName, p.Diagnosis, p.IsAmbulance,
                            p.IsCanContinueWork, p.CountDayWithoutWork,
                            p.IsDispencary, p.Notes, p.Id);
                    }
                }
            }
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            HealthRecordService service = new HealthRecordService();

            if (btnUpdateRecord.Text == "Confirm")
            {
                HealthRecord record = new HealthRecord()
                {
                    Patient = healthPatientRecord,
                    Doctor = healthDoctorRecord,
                    Diagnosis = txtDiagnose.Text,
                    IsAmbulance = chAmbulance.CheckState == CheckState.Checked,
                    IsDispencary = chDispancer.CheckState == CheckState.Checked,
                    Notes = txtNotes.Text,
                    Id = Guid.NewGuid().ToString()
                };

                if (chCanWork.CheckState == CheckState.Checked)
                {

                    record.IsCanContinueWork = true;
                    record.CountDayWithoutWork = 0;

                }
                else
                {
                    record.IsCanContinueWork = false;
                    if (!string.IsNullOrEmpty(txtDiagnose.Text))
                        record.CountDayWithoutWork = Convert.ToInt32(txtWithoutWork.Text);
                }

                record.Id = selectedHealthRecord.Id;
                service.UpdateRecord(record);
                selectedHealthRecord = null;
                btnUpdateRecord.Text = "Update";
                button1.Visible = false;
                ClearRecordValues();

                var records = service.GetAll();
                dataGridView1.Rows.Clear();
                if (records?.Count > 0)
                {
                    foreach (var p in records)
                    {
                        dataGridView1.Rows.Add(p.Patient.GetFullName, p.Doctor.GetFullName, p.Diagnosis, p.IsAmbulance,
                            p.IsCanContinueWork, p.CountDayWithoutWork,
                            p.IsDispencary, p.Notes, p.Id);
                    }
                }
            }
            else
            {
                if (selectedHealthRecord != null)
                {
                    btnUpdateRecord.Text = "Confirm";

                    txtDiagnose.Text = selectedHealthRecord.Diagnosis;
                    chAmbulance.CheckState =
                        selectedHealthRecord.IsAmbulance ? CheckState.Checked : CheckState.Unchecked;
                    chDispancer.CheckState =
                        selectedHealthRecord.IsDispencary ? CheckState.Checked : CheckState.Unchecked;
                    chCanWork.CheckState = selectedHealthRecord.IsCanContinueWork
                        ? CheckState.Checked
                        : CheckState.Unchecked;
                    txtWithoutWork.Text = selectedHealthRecord.CountDayWithoutWork.ToString();
                    txtNotes.Text = selectedHealthRecord.Notes;

                    healthPatientRecord = selectedHealthRecord.Patient;
                    healthDoctorRecord = selectedHealthRecord.Doctor;

                    button1.Visible = true;
                }
            }

        }

        private void ClearRecordValues()
        {
            txtDiagnose.Text = "";
            chAmbulance.CheckState = CheckState.Unchecked;
            chDispancer.CheckState = CheckState.Unchecked;
            chCanWork.CheckState = CheckState.Unchecked;
            txtWithoutWork.Text = "";
            txtNotes.Text = "";

            listBox1.SelectedItem = null;
            listBox2.SelectedItem = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HealthRecordService service = new HealthRecordService();
            if (btnUpdateRecord.Text == "Confirm")
            {
                selectedHealthRecord = null;
                ClearRecordValues();
                btnUpdateRecord.Text = "Update";
                var records = service.GetAll();
                dgDoctor.Rows.Clear();
                if (records?.Count > 0)
                {
                    foreach (var p in records)
                    {
                        dataGridView1.Rows.Add(p.Patient.GetFullName, p.Doctor.GetFullName, p.Diagnosis, p.IsAmbulance,
                            p.IsCanContinueWork, p.CountDayWithoutWork,
                            p.IsDispencary, p.Notes, p.Id);
                    }
                }
            }
        }


        #endregion
    }
}
