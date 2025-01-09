namespace wpf_all
{
    public class Employe
    {
        public string name { get; set; }
        public int age { get; set; }
        public string job { get; set; }
        public string joinDate { get; set; }
        public string sex { get; set; }

        public Employe()
        {
            this.name = "";
            this.age = 0;
            this.job = "";
            this.joinDate = "";
            this.sex = "";
        }
        public Employe(string name, int age, string job, string joinDate, string sex)
        {
            this.name = name;
            this.age = age;
            this.job = job;
            this.joinDate = joinDate;
            this.sex = sex;
        }

    }
}
