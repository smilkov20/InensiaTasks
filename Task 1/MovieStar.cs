namespace Task_1
{
    using System;
    using System.Text;

    public class MovieStar
    {
        public string Name { get; init; }

        public string SurName { get; init; }

        public string Sex { get; init; }

        public string Nationality { get; init; }

        public DateTime DateOfBirth { get; init; }

        public int YearsOld
            => (DateTime.Now.Year - this.DateOfBirth.Year - 1) +
                (((DateTime.Now.Month > this.DateOfBirth.Month) ||
                ((DateTime.Now.Month == this.DateOfBirth.Month) && (DateTime.Now.Day >= this.DateOfBirth.Day))) ? 1 : 0);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Name + " " + this.SurName)
                .AppendLine(this.Sex)
                .AppendLine(this.Nationality)
                .AppendLine(YearsOld.ToString() + " years old");

            return sb.ToString();
        }
    }
}
