using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Persistence.Data;
using Persistence.Entities;

namespace Application.Repositories;

    public class AppointmentRepository : GenericRepository<Appointment>, IAppointment
    {
    private readonly dbVeterinariaContext _context;

    public AppointmentRepository(dbVeterinariaContext context) : base(context)
        {
            _context = context;
        }
    }