namespace maui_all
{
    public class Employe
    {
        public string name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string job { get; set; }
        public string joinDate { get; set; }


        public Employe() { }

        public Employe(string name, string sex, int age, string job, string joinDate)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.job = job;
            this.joinDate = joinDate;
        }
    }
}
