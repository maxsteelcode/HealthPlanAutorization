using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HealthCareAuthorization.Models
{
    public class Pacient
    {
        public string Name { get; set; }

        public int CardNumber { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public Pacient() { }

        public Pacient(string name, int cardNumber)
        {
            Name = name;
            CardNumber = cardNumber;            
        }

        public Pacient(string name, int cardNumber, Gender gender, int age)
        {
            Name = name;
            CardNumber = cardNumber;
            Gender = gender;
            Age = age;
        }
    }


    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        [EnumMember(Value = "")]
        NotSet,
        [EnumMember(Value = "Male")]
        Male,
        [EnumMember(Value = "Female")]
        Female
    }
}
