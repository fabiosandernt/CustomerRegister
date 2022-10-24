

namespace Customer.Domain.Helpers.Extension
{
    public static class CalculaAge
    {
        public static int CalculaIdade(this DateTime dataNascimento )
        {
            var today = DateTime.Today;
            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dataNascimento.Year * 100 + dataNascimento.Month) * 100 + dataNascimento.Day;

            return (a - b) / 10000;            
        }
    }
}
