using STGenetics.Web.Models;

namespace STGenetics.Web.Services
{
    public class AnimalService
    {
        public List<STGenericModel> AnimalItems { get; set; } = new List<STGenericModel>
        {
            new STGenericModel { AnimalId = 1, Name = "Cow 1", Breed = "Holstein", BirthDate = new DateTime(2020, 1, 15), Sex = "Female", Price = 1000, Status = true },
            new STGenericModel { AnimalId = 2, Name = "Bull 1", Breed = "Angus", BirthDate = new DateTime(2019, 3, 10), Sex = "Male", Price = 1200, Status = true },
            new STGenericModel { AnimalId = 3, Name = "Heifer 1", Breed = "Hereford", BirthDate = new DateTime(2022, 5, 20), Sex = "Female", Price = 800, Status = false },
            new STGenericModel { AnimalId = 4, Name = "Cow 2", Breed = "Simmental", BirthDate = new DateTime(2018, 8, 8), Sex = "Female", Price = 1500, Status = true },
            new STGenericModel { AnimalId = 5, Name = "Bull 2", Breed = "Angus", BirthDate = new DateTime(2021, 10, 5), Sex = "Male", Price = 900, Status = true },
            new STGenericModel { AnimalId = 6, Name = "Heifer 2", Breed = "Hereford", BirthDate = new DateTime(2020, 6, 25), Sex = "Female", Price = 1100, Status = false },
            new STGenericModel { AnimalId = 7, Name = "Cow 3", Breed = "Holstein", BirthDate = new DateTime(2019, 4, 12), Sex = "Female", Price = 950, Status = true },
            new STGenericModel { AnimalId = 8, Name = "Bull 3", Breed = "Simmental", BirthDate = new DateTime(2022, 2, 28), Sex = "Male", Price = 1300, Status = true },
            new STGenericModel { AnimalId = 9, Name = "Heifer 3", Breed = "Angus", BirthDate = new DateTime(2018, 9, 16), Sex = "Female", Price = 850, Status = false },
            new STGenericModel { AnimalId = 10, Name = "Cow 4", Breed = "Hereford", BirthDate = new DateTime(2021, 7, 3), Sex = "Female", Price = 1050, Status = true },
            new STGenericModel { AnimalId = 11, Name = "Cow 5", Breed = "Holstein", BirthDate = new DateTime(2020, 11, 11), Sex = "Male", Price = 880, Status = true },
            new STGenericModel { AnimalId = 12, Name = "Bull 4", Breed = "Simmental", BirthDate = new DateTime(2019, 12, 24), Sex = "Female", Price = 1450, Status = false },
            new STGenericModel { AnimalId = 13, Name = "Heifer 4", Breed = "Angus", BirthDate = new DateTime(2018, 2, 7), Sex = "Male", Price = 920, Status = true },
            new STGenericModel { AnimalId = 14, Name = "Cow 6", Breed = "Hereford", BirthDate = new DateTime(2021, 4, 19), Sex = "Female", Price = 1150, Status = true },
            new STGenericModel { AnimalId = 15, Name = "Bull 5", Breed = "Holstein", BirthDate = new DateTime(2020, 6, 30), Sex = "Male", Price = 780, Status = false },
            new STGenericModel { AnimalId = 16, Name = "Heifer 5", Breed = "Simmental", BirthDate = new DateTime(2019, 8, 22), Sex = "Female", Price = 1600, Status = true },
            new STGenericModel { AnimalId = 17, Name = "Cow 7", Breed = "Angus", BirthDate = new DateTime(2018, 10, 14), Sex = "Male", Price = 830, Status = true },
            new STGenericModel { AnimalId = 18, Name = "Bull 6", Breed = "Hereford", BirthDate = new DateTime(2021, 12, 1), Sex = "Female", Price = 1250, Status = false },
            new STGenericModel { AnimalId = 19, Name = "Heifer 6", Breed = "Holstein", BirthDate = new DateTime(2020, 3, 8), Sex = "Male", Price = 980, Status = true },
            new STGenericModel { AnimalId = 20, Name = "Cow 8", Breed = "Simmental", BirthDate = new DateTime(2019, 1, 5), Sex = "Female", Price = 1400, Status = true }
        };
    }
}
