using Entidade.Domain.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Domain.Interfaces
{
    public interface IEntidadeRepository
    {
        Task<string> PostAsync(EntidadeCommand command);
        void PostAsync();
    }
}
