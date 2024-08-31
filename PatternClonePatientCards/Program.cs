using PatternClonePatientCards;


// PatientCards (карточка пациента) в котором проверяется работа паттерна Прототип (своей реализации) и интерфейса ICloneable
// Он наследует класс Patient который в свою очередь наследует Diagnosis 

Doctor doctor = new Doctor();
doctor.DoctorName = "Bob";
doctor.DoctorSurname = "Martinius";
doctor.DoctorDateBirth = DateTime.Now;
doctor.DoctorProfession = "InfectiousDiseasel";
doctor.DoctorSpecialization = "Infectious";

Disease disease = new Disease();
disease.Name = "Flu";
disease.Description = "Respiratory disease";
disease.RecoveryStatus = true;
disease.DateRecovery = DateTime.Now;
disease.DateOnsetIllness = DateTime.Now;


PatientCards patientCards = new PatientCards();
patientCards.PatientName = "Bob";
patientCards.PatientSurname = "Martinius";
patientCards.PatientDateBirth = DateTime.Now;
patientCards.Diagnosis.AddDiagnosis(doctor, disease);

patientCards.AddListHistoryPatient(patientCards.Diagnosis);  


ClonePatientCards clonePatientCards = new ClonePatientCards();
PatientCards PatientCardsMyClone = clonePatientCards.MuCloneClass(patientCards);

PatientCards patientCardsClone = (PatientCards)patientCards.Clone();

// Выводим в консоль клон из метода MuCloneClass

Console.WriteLine($"Имя пациента {PatientCardsMyClone.PatientName} Фамилия пациента {PatientCardsMyClone.PatientSurname} Дата рождения пациента {PatientCardsMyClone.PatientDateBirth}, В истории болезни пациента есть болезнь {PatientCardsMyClone.ListHistoryPatient[0].Name} ");
foreach (var data in patientCardsClone.Diagnosis.diagnosisData)
{
    Console.WriteLine($"Доктор говорит вы больны {data.Key.DoctorName} Такой то вот болезнm {data.Value.Name} ");
}

// Выводим в консоль клон из интерфейса ICloneable

Console.WriteLine($"Имя пациента {patientCardsClone.PatientName} Фамилия пациента {patientCardsClone.PatientSurname} Дата рождения пациента {patientCardsClone.PatientDateBirth} ");
foreach (var data in patientCardsClone.Diagnosis.diagnosisData)
{
    Console.WriteLine($"Доктор говорит вы больны {data.Key.DoctorName} Такой то вот болезни {data.Value.Name} ");
}

// Сравниваем ссылочные типы клона MuCloneClass и Clone (ICloneable)

bool MuCloneClass = PatientCardsMyClone.Diagnosis.diagnosisData.GetHashCode() == patientCards.Diagnosis.diagnosisData.GetHashCode();

bool Clone = patientCardsClone.Diagnosis.diagnosisData.GetHashCode() == patientCards.Diagnosis.diagnosisData.GetHashCode();

Console.WriteLine($" Результат стравнения равенства ссылок прототипа и клона MuCloneClass  {MuCloneClass} Результат стравнения равенства ссылок прототипа и клона Clone {Clone} ");

// Вывод метод интерфейса ICloneable не создает ссылочные объекты заново а копирует ссылки прототипа



