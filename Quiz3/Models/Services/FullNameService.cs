namespace Quiz3.Models.Services
{
    public class FullNameService
    {
        FullName fullName = new FullName();

        public string PrintFullName()
        {
            return fullName.Name + " " + fullName.Family;
        }
    }
}
