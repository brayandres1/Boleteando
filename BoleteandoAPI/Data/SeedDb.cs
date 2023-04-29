using BoleteandoShared.Entities;

namespace BoleteandoAPI.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketsAsync();
        }
        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                string fechaStr = "2000-01-15 15:30:00";
                DateTime fecha = DateTime.Parse(fechaStr);
                for (int i = 1; i <= 50000; i++)
                {
                   
                    _context.Tickets.Add(new Ticket {                         
                        DateUsed = fecha, 
                        State = false, 
                        Goal = "null" });                                        
                    await _context.SaveChangesAsync();
                }

            }


        }

    }
}