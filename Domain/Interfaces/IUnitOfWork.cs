using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public IAppointment Appointments { get; }
        public IBreed Breeds { get; }
        public ICity Cities { get; }
        public IClient Clients { get; }
        public IClientaddress Clientaddresses { get; }
        public IClientphone Clientphones { get; }
        public ICountry Countries { get; }
        public IPet Pets { get; }
        public IRefreshToken RefreshTokens { get; }
        public IRol Rols { get; }
        public IService Services { get; }
        public IState States { get; set; }
        public IUser Users { get; set; }
        Task<int> SaveAsync();
    }
}