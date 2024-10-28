using Amvip.Domain.Interfaces.Repositories;
using Amvip.Domain.Models.Entities;
using Amvip.Infrastructure.Data;

namespace Amvip.Infrastructure.Repository;

public class InvitationsRepository: BaseRepository<Invitation>, IInvitationsRepository
{
  public InvitationsRepository(JsonBaseContext context): base(context)
  { }
}
